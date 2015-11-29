using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class ExerciseResultInfo
    {
        public Exercise exercise { get; set; }
        public DateTime dateOfPassing { get; set; }//дата прохождения
        public int errorsCount { get; set; }
        public int assesment { get; set; }//оценка

        public ExerciseResultInfo(Exercise exercise, DateTime dateOfPassing, int errorsCount, int assesment)
        {
            this.exercise=exercise;
            this.dateOfPassing = dateOfPassing;
            this.errorsCount=errorsCount;
            this.assesment = assesment;
        }
    }
}
