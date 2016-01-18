using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterLIO.Forms;

namespace MasterLIO.Forms
{
    class FormsFactory
    {
        private static UserProfile userProfile;

        public static Form GetLoginForm()
        {
            return new LoginForm();
        }

        public static Form GetUserMenuForm()
        {
            return new UserMenuForm();
        }
        public static Form GetAdminMenuForm()
        {
            return new AdminMenuForm();
        }

        public static Form GetExerciseForm()
        {
            return new ExerciseForm();
        }


        public static Form GetStatisticForm()
        {
            return new StatisticForm();
        }

        public static Form GetEditAccounForm()
        {
            return new EditAccounForm();
        }

        public static Form GetCreateExercsieForm()
        {
            return new CreateExercise();
        }

        public static void SetUser(UserProfile usr)
        {
            userProfile = usr;
        }
    }
}
