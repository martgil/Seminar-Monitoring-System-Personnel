using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode;
using ZXing.Common;
using ZXing.Rendering;
using ZXing;
using Capstone.Personnel.Tools;
using Capstone.Personnel.Utilities;

namespace Capstone.Personnel.Actions
{
    public partial class uRegister : UserControl
    {
        public uRegister()
        {
            InitializeComponent();
        }
        private static uRegister _instance = null;

        public static uRegister Instance
        {
            get
            {
                if( _instance == null) {
                    _instance = new uRegister();
                }
                return _instance;
            }
            set
            {
                _instance = null;
            }
        }

        public void InitializeData()
        {
            GetValidAmount();
            GetValidCollege();
            // amount
            // college 
        }
        private void GetValidCollege()
        {
            CollegeCombo.Clear();
            var reader = SqlUtils.ExecuteQueryReader("Select * from college", false);
            while (reader.Read())
            {
                CollegeCombo.AddItem(reader["college_info"].ToString());
            }
        }

        private void GetValidAmount()
        {
            PaymentCombo.Clear();
            string cost = "";
            var reader = SqlUtils.ExecuteQueryReader("Select event_cost from custom_event where eventid=" + UserInfo.EventId, false);
            while (reader.Read())
            {
                cost = reader["event_cost"].ToString();
            }
            List<string> Payments = new List<string>();
            try
            {
                foreach (string data in cost.Split(','))
                {
                    Payments.Add(data);
                }
            }
            catch (Exception)
            {

            }
            //finally{
            //    Payments.Add("0");
            //}
            foreach (string payment in Payments)
            {
                PaymentCombo.AddItem(payment);
            }
        }

        //public void Init()
        //{
        //    // make 2000 to money format of 2,000
        //    string money = UserInfo.EventCost.ToString();
        //    int c = 1;
        //    for (int i = money.Length - 1; i >= 0; i--)
        //    {
        //        if (c == 3 && (i - 1) >= 0)
        //        {
        //            c = 0;
        //            money = money.Insert(i,",");
        //        }
        //        c += 1;
        //    }
        //}


       



        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            int payment = 0;
            int balance = 0;

         

            List<string> SchoolInfo = new List<string>();
            List<string> FullName = new List<string>();
            if (bunifuCheckbox1.Checked == false)
            {
                SchoolInfo.Add(""); // College
                SchoolInfo.Add(""); // Course
                SchoolInfo.Add(""); // Year Section
            }
            else if (CollegeCombo.selectedIndex != -1 && CourseCombo.selectedIndex != -1 && LevelCombo.selectedIndex != -1 && SectionCombo.selectedIndex != -1)
            {   
                SchoolInfo.Add(CollegeCombo.selectedValue.Trim());
                SchoolInfo.Add(CourseCombo.selectedValue.Trim());
                SchoolInfo.Add(LevelCombo.selectedValue.Trim() + " " + SectionCombo.selectedValue.Trim());
            }
            FullName.Add(FirstName.Text.Trim());
            FullName.Add(MiddleInitial.Text.Trim());
            FullName.Add(LastName.Text.Trim());


            if ((CollegeCombo.selectedIndex == -1 || CourseCombo.selectedIndex == -1 || LevelCombo.selectedIndex == -1 || SectionCombo.selectedIndex == -1) && (bunifuCheckbox1.Checked))
                MessageBox.Show("Invalid University Identity Info.");
            else if (FullName[0].Length < 3 || FullName[1].Length < 1 || FullName[2].Length < 3)
                MessageBox.Show("Invalid attendee name.");
            else if (PaymentCombo.selectedIndex == -1)
                MessageBox.Show("Invalid payment selection.");
            else if (Int32.TryParse(Balance.Text.Trim(), out payment) == false)
                MessageBox.Show("Invalid Amount");
            else if (payment > Convert.ToInt32(PaymentCombo.selectedValue.Trim()))
                balance = payment;
            else if (UserInfo.EventPartial.Trim().Length <= 0 && Convert.ToInt32(Balance.Text) < Convert.ToInt32(UserInfo.EventPartial))
                MessageBox.Show("Minimum payment does not meet, at least "+UserInfo.EventPartial);
            else
            {
                try
                {
                    // Check if event is open
                    int b = Convert.ToInt32(payment.ToString()) - Convert.ToInt32(balance.ToString());
                    SqlUtils.ExecuteInsert("insert into attendee(first_name,middle_initial,last_name,college_info,course,yrsec,balance,payment,ticket_price,eventid,userid) values (@first,@middle,@last,@college,@course,@yrsec,@payment,@balance,@price,@id,@userid)", new string[] { "@first", "@middle", "@last", "@college", "@course", "@yrsec","@payment", "@balance", "@price","@id", "@userid" }, new string[] { FullName[0], FullName[1], FullName[2], SchoolInfo[0], SchoolInfo[1], SchoolInfo[2], (Convert.ToInt32(PaymentCombo.selectedValue) - Convert.ToInt32(Balance.Text.Trim().ToString())).ToString(), Balance.Text.Trim().ToString(), PaymentCombo.selectedValue , UserInfo.EventId.ToString(), UserInfo.UserId });

                    var rd = SqlUtils.ExecuteQueryReader("select attendee_id from attendee order by attendee_id", false);
                    string Id = "";

                    while (rd.Read())
                    {
                        Id = Convert.ToString(rd["attendee_id"]);
                    }
                    // Update event 
                    int registered = 0;
                    var reader = SqlUtils.ExecuteQueryReader("select count(*) as registered from attendee where eventid=" + UserInfo.EventId, false);
                    while (reader.Read())
                    {
                        registered = (int)reader["registered"];
                    }
                    SqlUtils.ExecuteQuery("update custom_event set event_registered=" + registered + " where eventid=" + UserInfo.EventId, false);

                    var Generator = new uGenerate(FullName[0] + " " + FullName[1] + " " + FullName[2]);
                    RegisterPanel.Controls.Add(Generator);
                    Generator.Serialize(Id);
                    Generator.Dock = DockStyle.Fill;
                    Generator.BringToFront();

                }
                catch (Exception ex)
                {
                }
            }
            

        }

        private void CollegeCombo_onItemSelected(object sender, EventArgs e)
        {
            CourseCombo.Clear();
            var reader = SqlUtils.ExecuteQueryReader("select course from course where college_info='" + CollegeCombo.selectedValue.Trim() + "'", false);
            while (reader.Read())
            {
                CourseCombo.AddItem(reader["course"].ToString());
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (!bunifuCheckbox1.Checked)
                UniHelper.Visible = bunifuCheckbox1.Checked; 
            UniHelper.Visible = bunifuCheckbox1.Checked;


        }
    }
}
