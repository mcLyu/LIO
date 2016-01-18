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
    public partial class ExerciseForm : Form
    {
        List<Char> list;
        int index;
        int missedCount = 3;
        public ExerciseForm()
        {
            InitializeComponent();
            pictureBox1.Load("1.jpg");

            list = new List<Char>();
            list.Add('a');
            list.Add('b');
            list.Add('c');
            list.Add('d');
            list.Add('e');

            index = 0;

            difficultyProgressBar.Minimum = 0;
            difficultyProgressBar.Maximum = list.Count;

        }
        Stats stats = new Stats();

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (index < list.Count && listBox1.Items.Count < 4)
            {
                listBox1.Items.Add(list[index]);
                index++;

            }

            if (stats.Missed >= 3)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game over");
                timer1.Stop();
            }

            if (stats.Correct == list.Count)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Win!!!!");
                timer1.Stop();
            }
        }

        private Char ConvertKeyToChar(KeyEventArgs e)
        {
            int keyValue = e.KeyValue;
            if (!e.Shift && keyValue >= (int)Keys.A && keyValue <= (int)Keys.Z)
                return (char)(keyValue + 32);
            return (char)keyValue;
        }

        private void ExerciseForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.ShiftKey && e.KeyCode != Keys.ControlKey && listBox1.Items.Count != 0)
            {

                Char keyChar = ConvertKeyToChar(e);
                Char firstChar = (Char)listBox1.Items[0];

                if (firstChar.Equals(keyChar))
                {
                    listBox1.Items.Remove(listBox1.Items[0]);
                    listBox1.Refresh();
                    stats.Update(true);
                    difficultyProgressBar.Value = stats.Correct;
                }
                else
                {
                    stats.Update(false);
                }
                // Update the labels on the StatusStrip
                lblCorrect.Text = "Correct: " + stats.Correct;
                lblMissed.Text = "Missed: " + stats.Missed;
                lblTotal.Text = "Total: " + stats.Total;
            }
        }

       
    }


    class Stats
    {
        public int Total = 0;
        public int Missed = 0;
        public int Correct = 0;
        public int Accuracy = 0;
        public void Update(bool correctKey)
        {
            Total++;
            if (!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }
            Accuracy = 100 * Correct / (Missed + Correct);
        }
    }

}
