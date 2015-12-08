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
        String exec_text = "A B C D V E F G H I J K L M N O";

        public ExerciseForm()
        {
            InitializeComponent();
            //textBox2.Fo
            textBox1.Text = exec_text;
            richTextBox1.Text = "";
            textBox2.Text = "";
            pictureBox1.Load("1.jpg");

        }



        private void ExerciseForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text.StartsWith(e.KeyChar.ToString()))
            {
                textBox2.Text = textBox2.Text + e.KeyChar;
                richTextBox1.Text = richTextBox1.Text + e.KeyChar;
                textBox1.Text = textBox1.Text.Substring(1);
                if (richTextBox1.TextLength > 8)
                {
                    richTextBox1.Text = richTextBox1.Text.Substring(1);  
                }
            }
            else
            {

                //TODO Add the red letter

            }
        }
    }
}
