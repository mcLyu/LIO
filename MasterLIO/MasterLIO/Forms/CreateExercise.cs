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

        private void validateAll()
        {
            if ((textBox1.Text != "")
                && (areasTextBox.Text!=""))
            {
                richTextBox1.ReadOnly = false;
                richTextBox1.BackColor = Color.White;
            }
        }

        private void selectAreaButton_Click(object sender, EventArgs e)
        {
            List<Boolean> areasList = new List<Boolean>();
            Form f = new SelectAreaForm(ref areasList);
            f.ShowDialog();

            String areas = "";
            int areasCount = 0;

            for (int i = 0; i < areasList.Count; i++)
            {
                int realNum = i + 1;
                if (areasList[i] == true)
                {
                    areas += i + " ";
                    areasCount++;
                }
            }

            areasTextBox.Text = areas;
            textBox4.Text = areasList.Count.ToString();

            areasTextBox.BackColor = Color.GreenYellow;

            if (textBox1.Text == "")
            {
                List<Exercise> exercises = DBUtils.LoadExercises(areasCount);
                int maxnum = 0;
                int num;
                foreach (Exercise exercise in exercises)
                {
                    num = Convert.ToInt16(exercise.id.ToString().Substring(1));
                    if (num > maxnum) maxnum = num;
                }

                maxnum++;
                textBox1.Text = "Упражнение " + maxnum;
                textBox1.BackColor = Color.GreenYellow;
            }

            validateAll();
        }


        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.BackColor = Color.GreenYellow;

            validateAll();
        }
    }
}
