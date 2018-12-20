using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone.Personnel.Tools;
using Capstone.Personnel.Utilities;

namespace Capstone.Personnel.Actions
{
    public partial class uDashboard : UserControl
    {
        public uDashboard()
        {
            InitializeComponent();
        }

        public void InitEventList()
        {
            // PanelController
            OverviewPanel.Visible = ParentForm.Controls[0].Controls["bunifuCards1"].Controls["bunifuFlatButton3"].Visible;
            
            string totalRegistered = "";
            var read = SqlUtils.ExecuteQueryReader("SELECT count(*) as Total from attendee where userid=" + UserInfo.UserId + " and eventid=" + UserInfo.EventId , false);
            while (read.Read())
            {
                totalRegistered = read["Total"].ToString();
            }
            TotalRegistered.Text = totalRegistered;
            string total = "";
            read = SqlUtils.ExecuteQueryReader("SELECT count(*) as Total from attendee where userid=" + UserInfo.UserId + " and time_in is not null and eventid="+UserInfo.EventId , false);
            while (read.Read())
            {
                total = read["Total"].ToString();
            }
            TotalAttendee.Text = total;

            EventList.Clear();
            List<string> Events = new List<string>();
            var reader = SqlUtils.ExecuteQueryReader("select * from assigned_personnel where userid=" + UserInfo.UserId, false);
            while (reader.Read())
            {
                var rd0 = SqlUtils.ExecuteQueryReader("select * from custom_event where eventid=" + reader["eventid"].ToString() + " and event_open=1", false);
                while (rd0.Read())  
                {
                    Events.Add(rd0["event_name"].ToString());
                }
            }
            foreach (string eventItem in Events)
            {
                EventList.AddItem(eventItem);
            }
            EventList.selectedIndex = 0;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string Selected = EventList.selectedValue.Trim();
            var reader = SqlUtils.ExecuteQueryReader("select * from custom_event where event_name='"+Selected+"'",false);
            while (reader.Read())
            {
                UserInfo.EventId = Convert.ToInt32(reader["eventid"]);
                UserInfo.EventLocation = reader["event_location"].ToString();
                UserInfo.EventName = reader["event_name"].ToString();
            }
            List<Control> controlsToVisible = new List<Control>();

            controlsToVisible.Add(ParentForm.Controls[0].Controls["bunifuCards1"].Controls["ProfileBtn"]);
            controlsToVisible.Add(ParentForm.Controls[0].Controls["bunifuCards1"].Controls["bunifuFlatButton1"]);
            controlsToVisible.Add(ParentForm.Controls[0].Controls["bunifuCards1"].Controls["bunifuFlatButton2"]);
            controlsToVisible.Add(ParentForm.Controls[0].Controls["bunifuCards1"].Controls["bunifuFlatButton4"]);
            controlsToVisible.Add(ParentForm.Controls[0].Controls["bunifuCards1"].Controls["bunifuFlatButton3"]);

            foreach (Control item in controlsToVisible)
            {
                item.Visible = true;
            }

            ParentForm.Controls[0].Controls["EventInfo"].Visible = true;
            ParentForm.Controls[0].Controls["EventInfo"].Text = "You are now assigned to manage " + UserInfo.EventName;

            ParentForm.Controls[0].Controls["Navigator"].Text = "Attendee Registration";
            int count = 0;
            var rd = SqlUtils.ExecuteQueryReader("select count(*) from custom_event where event_open=1", false);
            while (rd.Read())
            {
                count = (Int32)rd.GetValue(0);
            }
            if (count < 1)
            {
                MessageBox.Show("Please contact your local administrator for adding/opening events for registration");
            }
            else
            {
                uRegister.Instance = null;
                Controls.Add(uRegister.Instance);

                uRegister.Instance.Dock = DockStyle.Fill;
                uRegister.Instance.InitializeData();
                uRegister.Instance.BringToFront();
            }
        }
    }
}
