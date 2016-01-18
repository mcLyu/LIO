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
    public partial class UserMenuForm : Form
    {
        public UserMenuForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExerciseButton_Click(object sender, EventArgs e)
        {
            Session.CurrentExercise = new Exercise();
            FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetExerciseForm());  
        }

        private void statistic_Click(object sender, EventArgs e)
        {
            FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetStatisticForm());  
        }
    }
}
