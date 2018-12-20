using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;
using ZXing.Rendering;
using ZXing.Presentation;
using Capstone.Personnel.Tools;
using Capstone.Personnel.Actions;
using Capstone.Personnel.Utilities;
using System.Drawing.Printing;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.Threading;
using Capstone.Personnel.Properties;

namespace Capstone.Personnel.Actions
{
    public partial class uGenerate : UserControl
    {
        string eventname = UserInfo.EventName;
        string attendee;
        string UId = "";

        public uGenerate()
        {
            InitializeComponent();
        }
        
        public uGenerate(string AttendeeName)
            : this()
        {
            attendee = AttendeeName;
        }

        public void Serialize(string attendeeId)
        {
            UId = attendeeId;
            var qrCreator = new QrHelper(QR.Height,QR.Width,3,UserInfo.EventId.ToString() + "/" + attendeeId);
             
            //var Ticket = new Bitmap(QR.Width,QR.Height);
            //var graphics = Graphics.FromImage(Ticket); 
            //graphics.DrawRectangle(new Pen(Brushes.Black), new Rectangle(new Point(0, 0), new Size(QR.Width - 1, QR.Height - 1))); // Outline
            //graphics.DrawImage(Resources.bulsu_colored, new Rectangle(new Point(2, 2), new Size(50, 50)));
            //graphics.DrawString("Bulacan State University", new Font("century gothic", 10F), Brushes.Black, new Point(60, 20)); // Authority Name
            //graphics.DrawString("Malolos Bulacan, Philippines", new Font("century gothic", 10F), Brushes.Black, new Point(60, 35)); // Authority Address
            //graphics.DrawImage(qr, new PointF(20, 65)); // QR
            //graphics.DrawString(UserInfo.EventName, new Font("century gothic", 10F, FontStyle.Regular), new SolidBrush(Color.DarkSlateGray), new Point(20, 220)); // Event Name
            //graphics.DrawString("Ticket No: " + attendeeId, new Font("century gothic", 10F, FontStyle.Regular), Brushes.Black, new Point(10, 240)); // Ticket No
            //graphics.DrawString(attendee, new Font("century gothic", 10F, FontStyle.Regular), Brushes.Black, new Point(10, 255)); // Owner Name
            //graphics.DrawString(UserInfo.EventLocation, new Font("century gothic", 10F, FontStyle.Regular), Brushes.Black, new Point(10, 270)); // Event Location
            QR.Image = qrCreator.GetQRCode();
        }

        private void Redirect()
        {
            uRegister.Instance = null;
            panel1.Controls.Add(uRegister.Instance);
            uRegister.Instance.Dock = DockStyle.Fill;
            uRegister.Instance.InitializeData();
            uRegister.Instance.BringToFront();
        }
        // Print Function
        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

            PrintDialog printDialog = new PrintDialog();
            PrintDocument qrPicture = new PrintDocument();

            printDialog.Document = qrPicture;
            qrPicture.PrintPage += QrPicture_PrintPage;

            var printResult = printDialog.ShowDialog();
            if (printResult == DialogResult.OK)
            {
                qrPicture.Print();
                Redirect();
            }
        }

      

        private void QrPicture_PrintPage(object sender, PrintPageEventArgs e) // Print Info Delegates
        {
            Bitmap printedQR = new Bitmap(QR.Width, QR.Height);
            QR.DrawToBitmap(printedQR, new Rectangle( 0, 0, QR.Width, QR.Height));
            e.Graphics.DrawImage(printedQR,0,0);
        }

        // Send to Mobile Function
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

            Image qr = QR.Image;
            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), "temp")))
            {
                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "temp"));
            }
            qr.Save(Path.Combine(Directory.GetCurrentDirectory(), "temp/generated.jpg"));

            new BluetoothDeviceChooser().Show();
            //}
            //Redirect();
        }
    }
}
