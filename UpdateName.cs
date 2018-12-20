using Capstone.Personnel.Tools;
using Capstone.Personnel.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone.Personnel
{
    public partial class UpdateName : Form
    {
        
        public UpdateName()
        {
            InitializeComponent();
        }
        string UpdateWhat;
        public void SetWinTitle(string updateWhat)
        {
            UpdateWhat = updateWhat;
            this.Text = "Update " + updateWhat;
            labelNotify.Text = "Enter your new " + updateWhat.ToLower();
        }

        public static UpdateName Instance()
        {
            return new UpdateName();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e) //Button Save
        {
            // Check Data Validation
            if (Detail.Text.Trim().Length <= 15 && Detail.Text.Trim().Length >= 3)
            {
                string toUpdate;
                // check if request is firstname or lastname
                if (UpdateWhat.Equals("First Name"))
                    toUpdate = "given_name";
                else
                    toUpdate = "last_name";
                // check if request same as still 
                if (Detail.Text.Equals(UserInfo.Lastname) || Detail.Text.Equals(UserInfo.Givenname))
                    MessageBox.Show("It seems that you are still using it?");
                else
                {
                    SqlUtils.ExecuteQuery("update personnel set "+toUpdate+"='"+Detail.Text.Trim()+"' where userid="+UserInfo.UserId,false);
                    if (UpdateWhat.Equals("First Name"))
                        UserInfo.Givenname = Detail.Text.Trim();
                    else
                        UserInfo.Lastname = Detail.Text.Trim();
                    
                    MessageBox.Show("Update Successfully");
                }
                // persist usage
            }
            else
                MessageBox.Show("Must be atleast 3 character and cannot be exceeds with 15 characters.");
        }
    }
}
