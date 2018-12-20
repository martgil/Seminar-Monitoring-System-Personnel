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
    public partial class uAttendance : UserControl
    {
        public uAttendance()
        {
            InitializeComponent();
        }

        private static uAttendance _instance = null;
        public static uAttendance Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new uAttendance();
                return _instance;
            }
        }
        private Color ColorCoded(string str)
        {
            return str.ToString() != String.Empty ? Color.FromArgb(149, 245, 144) : Color.FromArgb(240, 96, 89);
        }

        public void Init()
        {
            Filters.SelectedIndex = 0;
            AttendeeView.Rows.Clear();
            AttendeeView.Refresh();
            AttendeeView.RowTemplate.Height = 30;
            AttendeeView.ColumnHeadersDefaultCellStyle.Font = new Font("Roboto", 11F, FontStyle.Regular);
            SqlDataReader rd = SqlUtils.ExecuteQueryReader("select * from attendee where eventid="+UserInfo.EventId,false);
            while (rd.Read())
            {
                AttendeeView.Rows.Add();
                AttendeeView.Rows[AttendeeView.Rows.Count - 1].DefaultCellStyle.BackColor = ColorCoded(rd["time_in"].ToString());
                AttendeeView.Rows[AttendeeView.Rows.Count - 1].DefaultCellStyle.Font = new Font("Roboto", 9F, FontStyle.Regular);
                AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[0].Value = rd["first_name"].ToString() + " " + rd["middle_initial"].ToString() + " " + rd["last_name"].ToString();
                AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[1].Value = rd["yrsec"].ToString();
                AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[2].Value = rd["time_in"].ToString();
                AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[3].Value = rd["time_out"].ToString();
                AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[4].Value = rd["college_info"].ToString();
                AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[5].Value = rd["course"].ToString();
                AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[6].Value = rd["payment"].ToString();
                AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[7].Value = rd["ticket_price"].ToString();
                AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[8].Value = rd["balance"].ToString();
                //MessageBox.Show(time.TotalHours);
            }
            
        }


        // Search for...
        private void bunifuMaterialTextbox1_KeyUp(object sender, KeyEventArgs e)
        {
            string keyword = bunifuMaterialTextbox1.Text.ToLower();
            AttendeeView.Rows.Clear();
            if (keyword.Trim().Length > 0)
            {
                var pattern = new Regex(Regex.Escape(bunifuMaterialTextbox1.Text),RegexOptions.IgnoreCase);
                SqlDataReader rd = SqlUtils.ExecuteQueryReader("select * from attendee where eventid="+UserInfo.EventId, false);
                while (rd.Read())
                {
                    if (Filters.SelectedIndex == 1 && pattern.IsMatch((string)rd["first_name"].ToString().ToLower())) // Name - 0 YearSec - 1 Code -2
                    {
                        AttendeeView.Rows.Add();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].DefaultCellStyle.BackColor = ColorCoded(rd["time_in"].ToString());
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].DefaultCellStyle.Font = new Font("Roboto", 9F, FontStyle.Regular);
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[0].Value = rd["first_name"].ToString() + " " + rd["middle_initial"].ToString() + " " + rd["last_name"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[1].Value = rd["yrsec"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[2].Value = rd["time_in"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[3].Value = rd["time_out"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[4].Value = rd["college_info"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[4].Value = rd["course"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[6].Value = rd["payment"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[7].Value = rd["ticket_price"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[8].Value = rd["balance"].ToString();
                    }
                    else if (Filters.SelectedIndex == 0 && pattern.IsMatch((string)rd["college_info"].ToString().ToLower())) // Name - 0 YearSec - 1 Code -2
                    {
                        AttendeeView.Rows.Add();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].DefaultCellStyle.BackColor = ColorCoded(rd["time_in"].ToString());
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].DefaultCellStyle.Font = new Font("Roboto", 9F, FontStyle.Regular);
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[0].Value = rd["first_name"].ToString() + " " + rd["middle_initial"].ToString() + " " + rd["last_name"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[1].Value = rd["yrsec"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[2].Value = rd["time_in"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[3].Value = rd["time_out"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[4].Value = rd["college_info"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[4].Value = rd["course"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[6].Value = rd["payment"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[7].Value = rd["ticket_price"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[8].Value = rd["balance"].ToString();
                    }
                    else if (Filters.SelectedIndex == 2 && pattern.IsMatch((string)rd["attendee_yrsec"].ToString().ToLower())) // Name - 0 YearSec - 1 Code -2
                    {
                        AttendeeView.Rows.Add();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].DefaultCellStyle.BackColor = ColorCoded(rd["time_in"].ToString());
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].DefaultCellStyle.Font = new Font("Roboto", 9F, FontStyle.Regular);
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[0].Value = rd["first_name"].ToString() + " " + rd["middle_initial"].ToString() + " " + rd["last_name"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[1].Value = rd["yrsec"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[2].Value = rd["time_in"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[3].Value = rd["time_out"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[4].Value = rd["college_info"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[4].Value = rd["course"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[6].Value = rd["payment"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[7].Value = rd["ticket_price"].ToString();
                        AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[8].Value = rd["balance"].ToString();
                    }


                }
            }
            else
            {
                SqlDataReader rd = SqlUtils.ExecuteQueryReader("select * from attendee where eventid="+UserInfo.EventId, false);
                while (rd.Read())
                {
                    AttendeeView.Rows.Add();
                    AttendeeView.Rows[AttendeeView.Rows.Count - 1].DefaultCellStyle.BackColor = ColorCoded(rd["time_in"].ToString());
                    AttendeeView.Rows[AttendeeView.Rows.Count - 1].DefaultCellStyle.Font = new Font("Roboto", 9F, FontStyle.Regular);
                    AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[0].Value = rd["first_name"].ToString() + " " + rd["middle_initial"].ToString() + " " + rd["last_name"].ToString();
                    AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[1].Value = rd["yrsec"].ToString();
                    AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[2].Value = rd["time_in"].ToString();
                    AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[3].Value = rd["time_out"].ToString();
                    AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[4].Value = rd["college_info"].ToString();
                    AttendeeView.Rows[AttendeeView.Rows.Count - 1].Cells[4].Value = rd["course"].ToString();
                }
            }
        }
    }
}
