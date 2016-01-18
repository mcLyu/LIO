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
    public partial class AdminMenuForm : Form
    {
        public AdminMenuForm()
        {
            InitializeComponent();
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

        private void CreateExercsieButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetCreateExercsieForm()); 
        }

        private void EditAccountButton_Click(object sender, EventArgs e)
        {
            FormUtils.OpenFormAndSaveHierarchy(this, FormsFactory.GetEditAccounForm()); 
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
