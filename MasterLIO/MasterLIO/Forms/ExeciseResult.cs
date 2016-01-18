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
    public partial class ExeciseResult : Form
    {
        int command = 0;
        public ExeciseResult()
        {
            InitializeComponent();
            ExerciseResultInfo exerciseInfo = Session.CurrentResultInfo;
            wrongNumber.Text = "Количество ошибок: " + exerciseInfo.errorsCount.ToString();
            markLabel.Text = exerciseInfo.assesment.ToString();
            time.Text = "Время выполнения: " + exerciseInfo.speed + " сек.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            command = 1;
            this.Close();
        }

        public int getCommand()
        {
            return command;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            command = 2;
            this.Close();
        }
    }
}
