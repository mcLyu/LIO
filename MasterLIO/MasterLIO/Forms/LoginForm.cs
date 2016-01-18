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
            DBUtils.LoadExercises();
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            //MONKEY CODE!!!   ↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓

            if (loginField.Text == "" || passwordField.Text == "") {
                this.TopMost = true; //Ставим текущую форму поверх всех окон
                MessageBox.Show("Не все поля заполнены!"); 
                return;
            }

            UserProfile profile = DBUtils.AuthorizeUser(loginField.Text, passwordField.Text);

            //такой пользователь не найден
            if (profile.password.Equals("") && profile.login.Equals(""))
            {
                DialogResult result = MessageBox.Show("Такой пользователь не найден! Зарегистрировать?",
                    "Зарегистрировать?", MessageBoxButtons.YesNo);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    profile = DBUtils.RegisterUser(loginField.Text, passwordField.Text);

                    this.Close();
                    return;
                }
            }
            //логин найден, пароль нет
            else if (profile.password.Equals(""))
            {
                this.TopMost = true; 
                MessageBox.Show("Пароль неверен! Повторите ввод!");
                return;
            }

            FormsFactory.SetUser(profile);

            if (profile.role.Equals(Role.STUDENT))
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
