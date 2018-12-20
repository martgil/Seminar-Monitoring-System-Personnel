using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone.Personnel.Tools;
using Capstone.Personnel.Utilities;

namespace Capstone.Personnel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            var reader = SqlUtils.ExecuteQueryReader("select count (*) from personnel",false);
            
            if (!reader.HasRows)
            {
                MessageBox.Show("There is no personnel accounts, contact your local administrator");
            }
            else
            {
                if (username.Text.Trim().Length <= 0 || passwd.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Please fill-up or select necessary fields to proceed!");
                }
                else if (VerifyUser(username.Text.Trim(),passwd.Text.Trim()))
                {
                    var dashboard = new PersonnelDashboard();
                    var rd = SqlUtils.ExecuteQueryReader("select * from personnel where username='" + username.Text +"'",false);
                    while (rd.Read())
                    {
                        UserInfo.UserId = rd["userid"].ToString();
                        UserInfo.Givenname = rd["given_name"].ToString();
                        UserInfo.Lastname = rd["last_name"].ToString();
                        UserInfo.Contact = rd["contact_no"].ToString();
                        UserInfo.Affiliation = rd["affiliation"].ToString();

                    }
                    int assigned = 0;
                    var rd0= SqlUtils.ExecuteQueryReader("select count(*) as assigned from assigned_personnel where userid=" + UserInfo.UserId, false);
                    while (rd0.Read())
                    {
                        assigned = Convert.ToInt32(rd0["assigned"].ToString());
                    }
                    if(assigned >= 1)
                    {
                        UserInfo.Username = username.Text;
                        UserInfo.Fullname = UserInfo.Lastname + ", " + UserInfo.Givenname;

                        int EventList = 0;

                        var readerz = SqlUtils.ExecuteQueryReader("select * from assigned_personnel where userid=" + UserInfo.UserId, false);
                        while (readerz.Read())
                        {
                            var rdz0 = SqlUtils.ExecuteQueryReader("select * from custom_event where eventid=" + readerz["eventid"].ToString() + " and event_open=1", false);
                            while (rdz0.Read())
                            {
                                EventList += 1;
                                UserInfo.EventDate = rdz0["event_date"].ToString();
                                UserInfo.EventTime = rdz0["event_stime"].ToString();
                                UserInfo.EventStrict = rdz0["strict"].ToString();
                                UserInfo.EventPartial = rdz0["event_partial"].ToString();
                            }
                        }

                        if(EventList >= 1)
                        {
                            dashboard.Init();
                            dashboard.Show();
                            Hide();
                        }
                        else
                            MessageBox.Show("No event is assigned to this account or either event\'s are closed.");


                    }
                    else
                    {
                        MessageBox.Show("Your account exist, but never been assigned on any event or seminar");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }

            }
        }

        private bool VerifyUser(string username, string password)
        {
            bool userFound = false;
            var findUser = SqlUtils.ExecuteQueryReader("SELECT username from personnel where username='"+username+"' and passwd='"+password+"'",false);
            while (findUser.Read())
            {
                userFound = true;
            }

            return userFound;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Please contact your local adminstrator to create your new account.","Notification",MessageBoxButtons.OK);
        }

        private void passwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                loginBtn_Click(null,EventArgs.Empty);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
