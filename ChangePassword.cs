using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone.Personnel.Tools;
using Capstone.Personnel.Utilities;

namespace Capstone.Personnel
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
       

        // Change Password Btn Click Event
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SqlDataReader rd = SqlUtils.ExecuteQueryReader("select passwd from personnel where username='"+ UserInfo.Username + "'",false);
            string oldpassword = null;
            while (rd.Read())
            {
                oldpassword = rd.GetString(0);
            }
            if (oldPass.Text.Trim().Equals(oldpassword) && !newPass.Text.Trim().Equals(oldpassword))
            {
                string newpass = newPass.Text.Trim();
                string confirmpass = confirmPass.Text.Trim();
                if (newpass.Length < 7 || confirmpass.Length < 7)
                {
                    MessageBox.Show("Password Must be atleast 8 characters");
                }
                else
                {
                    if (newpass.Equals(confirmpass))
                    {
                        SqlUtils.ExecuteInsert("update personnel set passwd=@passwd where username=@uname", new string[] { "@passwd", "@uname" }, new string[] { newPass.Text.Trim(), UserInfo.Username });
                        MessageBox.Show("Password Changed Successfully");
                        oldPass.Text = "";
                        newPass.Text = "";
                        confirmPass.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Mismatch New Password!");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Old Password Do not Match or you are using the same password again ?");
            }
        }
    }
}
