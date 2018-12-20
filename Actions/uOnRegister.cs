using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Rendering;
using Capstone.Personnel.Tools;
using System.IO;
using System.Threading;
using Capstone.Personnel.Utilities;

namespace Capstone.Personnel.Actions
{
    public partial class uOnRegister : UserControl
    {

        public uOnRegister()
        {
            InitializeComponent();
        }

        public static uOnRegister getInstance()
        {
            return new uOnRegister();
        }

        public void DrawQR()
        {

            if (bunifuMaterialTextbox1.Text.Trim().Length <= 0)
            {
                QR.Image.Dispose();
            }
            else
            {
                ZXing.BarcodeWriter bw = new ZXing.BarcodeWriter();
                bw.Format = BarcodeFormat.QR_CODE;
                bw.Renderer = new BitmapRenderer();
                bw.Options.Width = 150;
                bw.Options.Height = 150;
                bw.Options.Margin = 3;
                Bitmap qr = bw.Write(bunifuMaterialTextbox1.Text);
                QR.Image = qr;
            }

        }
        string defaultMessage = "Aim the scanner carefully, and please be patient";

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string code = bunifuMaterialTextbox1.Text;

            Regex regex = new Regex("[0-9]/[0-9]");
            if (regex.IsMatch(code) && code.Length >= 3)
            {
                string[] data = new string[2];

                try
                {
                    Focus();
                    data = code.Split('/');
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    //DrawQR();
                    //if (DateTime.Now.CompareTo(Convert.ToDateTime(UserInfo.EventDate)) < 0 )
                    //    MessageBox.Show("Cannot scan : too early");
                    //else {
                        //Go attendance
                       
                        var qrHelper = new QrHelper(QR.Height,QR.Width,5,bunifuMaterialTextbox1.Text.Trim());
                        QR.Image = qrHelper.GetQRCode();
                        string attendeeId = "";
                        var attendeeReader = SqlUtils.ExecuteQueryReader("select first_name + ' ' + last_name as attendee_fullname from attendee where attendee_id=" + data[1] + " and eventid=" + data[0], false);
                        while (attendeeReader.Read())
                        {
                            attendeeId = (string)attendeeReader["attendee_fullname"];
                        }

                        if (String.IsNullOrEmpty(attendeeId))
                            MessageBox.Show("There is no data found");
                        else
                        {
                            var x = SqlUtils.ExecuteQueryReader("select time_in,time_out from attendee where attendee_id=" + data[1] + " and eventid="+data[0],false);
                        while (x.Read())
                        {
                            if (String.IsNullOrEmpty(x["time_in"].ToString()))
                            {
                                    int totalAttendees = 0;
                                    SqlUtils.ExecuteInsert("update attendee set time_in='" + DateTime.Now.ToShortTimeString() + "' where attendee_id=@id and eventid=@eid", new string[] { "@id", "@eid" }, new string[] { data[1], data[0] });
                                    var reader = SqlUtils.ExecuteQueryReader("select count(*) as total_attendees from attendee where eventid=" + UserInfo.EventId + " and userid=" + UserInfo.UserId + " and time_in is not null", false);
                                    while (reader.Read())
                                    {
                                        totalAttendees = (int)reader["total_attendees"];
                                    }
                                    SqlUtils.ExecuteQuery("update custom_event set event_attended=" + totalAttendees + " where eventid=" + UserInfo.EventId, false);
                                    MessageBox.Show("Attendee Time In Success");
                                }
                                else if (!String.IsNullOrEmpty(x["time_in"].ToString()) && UserInfo.EventStrict == "0")
                                {
                                    SqlUtils.ExecuteInsert("update attendee set time_out='" + DateTime.Now.ToShortTimeString() + "' where attendee_id=@id and eventid=@eid", new string[] { "@id", "@eid" }, new string[] { data[1], data[0] });
                                    MessageBox.Show("Attendee Time Out Success");
                                }
                                else
                                {
                                    MessageBox.Show("This attendee has time in and time out");
                                }
                            }


                            DynamicPrompt.Text = "QR Validated Successfully.";
                            // Your shitty animations here...
                        }

                    //}
                }

            }
            else
            {
                MessageBox.Show("Not a valid entry");
            }
        }

        
    }
}
