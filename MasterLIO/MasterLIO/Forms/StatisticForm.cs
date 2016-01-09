using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MasterLIO.Forms
{
    public partial class StatisticForm : Form
    {
        private static int CURRENT_USER_ID = 1;
        private Statistic statistic = DBUtils.GetUserStatistic(CURRENT_USER_ID);
        private List<ExerciseResultInfo> resultsInfo;

        public StatisticForm()
        {
            InitializeComponent();
            statisticChart1.Series["Series1"].Enabled = false;
            dateTimePicker1.Text = "";
        }

        private void statisticSearchButton1_Click(object sender, EventArgs e)
        {
            resultsInfo = statistic.getResultsByDate(dateTimePicker1.Value);
            foreach (ExerciseResultInfo result in resultsInfo)
            {
                String level = result.level.ToString();
                String exerciseNum = result.exerciseId.ToString().Substring(1);// MAGIC!
                exerciseNumbercomboBox1.Items.Add("№"+exerciseNum+", ур-нь "+level);
            }
        }

        private void exerciseNumbercomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int exerciseNum = Convert.ToInt32(convertToExersiceId(exerciseNumbercomboBox1.SelectedItem.ToString()));
            ExerciseResultInfo currentResultInfo = getResultInfoByNum(exerciseNum);
            errorCounttextBox3.Text = currentResultInfo.errorsCount.ToString();
            exerciseSpeedtextBox4.Text = currentResultInfo.speed.ToString();
            assessmentTextBox5.Text = currentResultInfo.assesment.ToString();
        }

        private ExerciseResultInfo getResultInfoByNum(int exerciseNum)
        {
            ExerciseResultInfo exercise = null;
            foreach (ExerciseResultInfo result in resultsInfo)
            {
                if (result.exerciseId == exerciseNum)
                    exercise = result;        
            }
            return exercise;
        }

        private int convertToExersiceId(string stringName)
        {
            string exerciseId = "";

            string pattern = @"\b(\d)\b";
            Regex regex = new Regex(pattern);

            Match match = regex.Match(stringName);

            while (match.Success)
            {
                exerciseId += match.Groups[1].Value;

                match = match.NextMatch();
            }

            exerciseId = exerciseId.Substring(exerciseId.Length - 1) + exerciseId.Substring(0,exerciseId.Length-1);

            return Convert.ToInt32(exerciseId);
        }

    }
}
