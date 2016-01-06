using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterLIO.Forms
{
    public partial class EditAccounForm : Form
    {
        public EditAccounForm()
        {
            InitializeComponent();
            passwordtextBox2.UseSystemPasswordChar = true;

            List<UserProfile> users = DBUtils.LoadAllUsers();
            userlistBox1.Items.AddRange(users.ToArray());

            rolecomboBox1.Items.Add(Role.ADMIN);
            rolecomboBox1.Items.Add(Role.STUDENT);
        }

        private void userlistBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserProfile selectedUser = (UserProfile) userlistBox1.SelectedItem;
            logintextBox2.Text = selectedUser.login;
            passwordtextBox2.Text = selectedUser.password;
            rolecomboBox1.Text = selectedUser.role.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
                passwordtextBox2.UseSystemPasswordChar = false;
            else
                passwordtextBox2.UseSystemPasswordChar = true;
        }


    }
    
}
