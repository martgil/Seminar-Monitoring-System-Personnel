using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capstone.Personnel.Utilities;

namespace Capstone.Personnel
{
    public partial class UserProfile : UserControl
    {
        public UserProfile()
        {
            InitializeComponent();
        }
        
        public void SetDetails()
        {
            uname.Text = UserInfo.Username;
            FirstName.Text = UserInfo.Givenname;
            LastName.Text = UserInfo.Lastname;
            Contact.Text = UserInfo.Contact;
            Afil.Text = UserInfo.Affiliation;
        }

        public static UserProfile Instance()
        {
            return new UserProfile();
        }

        private void ChangePasswordBtn_Click(object sender, EventArgs e)
        {
            new ChangePassword().Show();
        }

        private void ChangeUsername_Click(object sender, EventArgs e)
        {
            new ChangeUsername().Show();
        }

        private void ChangeFirstName_Click(object sender, EventArgs e)
        {
            UpdateName nameupdater = new UpdateName();
            nameupdater.SetWinTitle("First Name");
            nameupdater.Show();
        }

        private void ChangeLastName_Click(object sender, EventArgs e)
        {
            UpdateName nameupdater = new UpdateName();
            nameupdater.SetWinTitle("Last Name");
            nameupdater.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new Affiliation().Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new ContactNumber().Show();
        }
    }
}
