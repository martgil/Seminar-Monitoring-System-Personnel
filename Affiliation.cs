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
    public partial class Affiliation : Form
    {
        public Affiliation()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (AffiliationText.Text.Trim().Length <= 3)
                MessageBox.Show("Affiliation is too short");
            else
            {
                SqlUtils.ExecuteInsert("update personnel set affiliation=@affiliation", new string[] { "@affiliation" }, new string[] { AffiliationText.Text.Trim() });
            }
        }
    }
}
