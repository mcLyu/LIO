using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class Statistic
    {
        List<ExerciseResultInfo> results;

        public Statistic() 
        {
            results = new List<ExerciseResultInfo>();
        }

        public Statistic(List<ExerciseResultInfo> results)
        {
            this.results = results;
        }

        public void addResult(ExerciseResultInfo result){
            results.Add(result);
        }

        public List<ExerciseResultInfo> getResultsByDate(DateTime date)
        {
            List<ExerciseResultInfo> resultsByDate = new List<ExerciseResultInfo>();

            foreach(ExerciseResultInfo resultInfo in results)
            {
                if (resultInfo.dateOfPassing.Day.Equals(date.Day))
                {
                    resultsByDate.Add(resultInfo);
                }
            }

            return resultsByDate;
        }
    }
}
