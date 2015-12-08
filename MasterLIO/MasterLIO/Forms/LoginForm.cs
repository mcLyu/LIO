using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterLIO.Forms;

namespace MasterLIO
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            //TODO: Add the checker for User, Admin and correct password and user name 
            Boolean isUser = false;
            //FormsFactory.SetUser();

            if (isUser)
            {
                FormUtils.OpenFormAndCloseCurrent(this, FormsFactory.GetUserMenuForm());
            }
            else
            {
                FormUtils.OpenFormAndCloseCurrent(this, FormsFactory.GetAdminMenuForm());
            }

        }
    }
}
