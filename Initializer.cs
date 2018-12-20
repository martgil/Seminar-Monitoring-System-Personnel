using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone.Personnel.Tools;
using Newtonsoft.Json;

namespace Capstone.Personnel
{
    public partial class Initializer : Form
    {
        public Initializer()
        { 
            InitializeComponent();
            
            
        }
        // Load Config Button
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.InitialDirectory = Environment.SpecialFolder.MyDocuments.ToString();
            fd.Filter = "Config File(*.json)|*.json";
            DialogResult dr = fd.ShowDialog();
            if (dr.Equals(DialogResult.OK))
            {
               File.Copy(Path.GetFullPath(fd.FileName),Path.Combine(Directory.GetCurrentDirectory(),"configs/config.json"));
                MessageBox.Show("Configuration File Import Successfully,Re-run the application to take effect.");
                Close();
            }
        }

        private void Initializer_Activated(object sender, EventArgs e)
        {
            
            string configFile = Path.Combine(Directory.GetCurrentDirectory(), "configs/config.json");
            if (Windows.existPath() == false)
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"/configs");
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + @"/temp");
            }
            else
            {
                Login login = new Login();
                login.Show();
                Hide();
            }
           
        }

        
    }
}
