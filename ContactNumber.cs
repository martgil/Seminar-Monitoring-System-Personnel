using Capstone.Personnel.Tools;
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
    public partial class ContactNumber : Form
    {
        public ContactNumber()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text.Trim().Length < 11)
                MessageBox.Show("Number too shortt");
            else
            {
                SqlUtils.ExecuteInsert("update personnel set contact_no=@contact", new string[] { "@contact" }, new string[] { bunifuMetroTextbox1.Text.Trim() });
                MessageBox.Show("Update Successfully");
                this.Close();
            }
        }
    }
}
