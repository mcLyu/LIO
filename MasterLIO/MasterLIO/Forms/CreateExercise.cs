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
    public partial class CreateExercise : Form
    {
        public CreateExercise()
        {
            InitializeComponent();
        }

        private void selectAreaButton_Click(object sender, EventArgs e)
        {
            Form f = new SelectAreaForm();
            f.Show();
        }
    }
}
