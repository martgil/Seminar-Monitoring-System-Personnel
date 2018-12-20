using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone.Personnel.Tools;
using Capstone.Personnel.Utilities;
using System.Text.RegularExpressions;

namespace Capstone.Personnel.Actions
{
    public partial class uAttendeeUpdate : UserControl
    {

        public uAttendeeUpdate()
        {
            InitializeComponent();
            GetValidAmount();
            SchoolInfo();
        }

        public static uAttendeeUpdate getInstance()
        {
            return new uAttendeeUpdate();
        }
        List<string> GlobalNames = new List<string>();
        public void InitAttendee()
        {
            List<string> LocalNames = new List<string>();
            var reader = SqlUtils.ExecuteQueryReader("select attendee_id, first_name + ' ' + middle_initial + ' ' + last_name as fullname from attendee where eventid= " + UserInfo.EventId, false);
            while (reader.Read())
            {
                LocalNames.Add(reader["attendee_id"].ToString() + ":" + reader["fullname"].ToString());
            }
            ResultCombo.Items.Clear();
            GlobalNames = LocalNames;
            foreach (var name in LocalNames)
            {
                ResultCombo.Items.Add(StripColonRight(name));
            }
            //----------------------------------------------------
            // fetch valid amounts
            // fetch drop downs
            // on selected via resultcombo. use it default
            // works only with separated list
        }
        List<string> College = new List<string>();
        List<string> Course = new List<string>();
        List<string> Level = new List<string>();
        List<string> Section = new List<string>();
        private void SchoolInfo()
        {
            // college
            CollegeCombo.Clear();
            var reader = SqlUtils.ExecuteQueryReader("Select * from college", false);
            while (reader.Read())
            {
                CollegeCombo.AddItem(reader["college_info"].ToString());
                College.Add(reader["college_info"].ToString());
            }
            string[] itemsLevel = LevelCombo.Items;
            foreach (var item in itemsLevel)
            {
                Level.Add(item);
            }
            string[] itemsSection = SectionCombo.Items;
            foreach (var item in itemsSection)
            {
                Section.Add(item);   
            }
        }

        List<string> PaymentList = new List<string>();
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
                PaymentList.Add(payment);
            }
        }

        private string StripColonLeft(string str)
        {
            string moded = "";
            int i = str.IndexOf(":");
            moded = str.Substring(0, i);
            return moded;
        }
        private string StripColonRight(string str)
        {
            string moded = "";
            int i = str.IndexOf(":");
            moded = str.Substring(i+1,str.Length-(i+1));
            return moded;
        }



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
            else
            {
                try
                {
                    int index = ResultCombo.SelectedIndex;
                    string value = GlobalNames[index];
                    int id = Convert.ToInt32(StripColonLeft(value));
                    // Check if event is open
                    SqlUtils.ExecuteInsert("update attendee set first_name=@first,middle_initial=@middle,last_name=@last,college_info=@college,course=@course,yrsec=@yrsec,balance=@balance,payment=@payment,eventid=@id,userid=@userid where attendee_id=@aid", new string[] { "@first", "@middle", "@last", "@college", "@course", "@yrsec", "@balance", "@payment", "@id", "@userid", "@aid" }, new string[] { FullName[0], FullName[1], FullName[2], SchoolInfo[0], SchoolInfo[1], SchoolInfo[2], balance.ToString(), payment.ToString(), UserInfo.EventId.ToString(), UserInfo.UserId, id.ToString() });

                    var Generator = new uGenerate(FullName[0] + " " + FullName[1] + " " + FullName[2]);
                    panel1.Controls.Add(Generator);
                    Generator.Serialize(id.ToString());
                    Generator.Dock = DockStyle.Fill;
                    Generator.BringToFront();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void CollegeCombo_onItemSelected_1(object sender, EventArgs e)
        {
            CourseCombo.Clear();
            var reader = SqlUtils.ExecuteQueryReader("select course from course where college_info='" + CollegeCombo.selectedValue.Trim() + "'", false);
            while (reader.Read())
            {
                CourseCombo.AddItem(reader["course"].ToString());
            }
        }

        private void ResultCombo_onItemSelected_1(object sender, EventArgs e)
        {
           // True here in Itemselected
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            if (bunifuCheckbox1.Checked == true)
                UniHelper.Visible = bunifuCheckbox1.Checked;
            UniHelper.Visible = bunifuCheckbox1.Checked;
        }

        private void ResultCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = ResultCombo.SelectedIndex;
                string value = GlobalNames[index];
                int id = Convert.ToInt32(StripColonLeft(value));
                var reader = SqlUtils.ExecuteQueryReader("select * from attendee where attendee_id=" + id, false);
                while (reader.Read())
                {
                    FirstName.Text = reader["first_name"].ToString();
                    MiddleInitial.Text = reader["middle_initial"].ToString();
                    LastName.Text = reader["last_name"].ToString();
                    Balance.Text = reader["balance"].ToString();
                    if (String.IsNullOrEmpty(reader["course"].ToString()))
                        bunifuCheckbox1.Checked = false;
                    else
                    {
                        bunifuCheckbox1.Checked = true;
                        foreach (var college in College)
                        {
                            if (college == reader["college_info"].ToString())
                                CollegeCombo.selectedIndex = College.IndexOf(college);
                        }
                        CourseCombo.Clear();
                        CourseCombo.AddItem(reader["course"].ToString());
                        CourseCombo.selectedIndex = 0;
                        string[] yrsec = reader["yrsec"].ToString().Split();
                        foreach (var level in Level)
                        {
                            if (level == yrsec[0])
                                LevelCombo.selectedIndex = Level.IndexOf(level);
                        }
                        foreach (var section in Section)
                        {
                            if (section == yrsec[1])
                                SectionCombo.selectedIndex = Section.IndexOf(section);
                        }
                    }
                    bunifuCheckbox1_OnChange(null, EventArgs.Empty);

                    foreach (var amount in PaymentList)
                    {
                        if (amount == reader["payment"].ToString())
                        {
                            PaymentCombo.selectedIndex = PaymentList.IndexOf(amount);
                        }
                    }
                }
            }
            catch (Exception) { }
        }
    }
}
