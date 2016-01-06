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
    public partial class StatisticForm : Form
    {
        private Statistic statistic = DBStub.GetUserStatistic(12345);
        
        public StatisticForm()
        {
            InitializeComponent();
            statisticChart1.Series["Series1"].Enabled = false;
            dateTimePicker1.Text = "";
        }

        private void statisticSearchButton1_Click(object sender, EventArgs e)
        {
            List<ExerciseResultInfo> resultInfo = statistic.getResultsByDate(dateTimePicker1.Value);
            exerciseNumbercomboBox1.Items.AddRange(resultInfo.ToArray());

        }

    }
}
