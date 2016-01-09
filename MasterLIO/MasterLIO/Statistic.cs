using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class Statistic
    {
        public long userId {get;set;}
        List<ExerciseResultInfo> results;

        public Statistic(long userId) 
        {
            this.userId = userId;
            results = new List<ExerciseResultInfo>();
        }

        public Statistic(int userId,List<ExerciseResultInfo> results)
        {
            this.userId = userId;
            this.results = results;
        }

        public void addResult(ExerciseResultInfo result){
            results.Add(result);
        }

        public List<ExerciseResultInfo> getResultsInfo()
        {
            return results;
        }

        public List<ExerciseResultInfo> getResultsByDate(DateTime date)
        {
            List<ExerciseResultInfo> resultsByDate = new List<ExerciseResultInfo>();

            foreach(ExerciseResultInfo resultInfo in results)
            {
                if (resultInfo.dateOfPassing.Day.Equals(date.Day)
                        && resultInfo.dateOfPassing.Month.Equals(date.Month)
                            && resultInfo.dateOfPassing.Year.Equals(date.Year))
                {
                    resultsByDate.Add(resultInfo);
                }
            }

            return resultsByDate;
        }
    }
}
