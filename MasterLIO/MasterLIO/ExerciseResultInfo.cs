using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class ExerciseResultInfo
    {
        public int exerciseId { get; set; }
        public Exercise exercise { get; set; }
        public DateTime dateOfPassing { get; set; }//дата прохождения
        public int errorsCount { get; set; }
        public int assesment { get; set; }//оценка
        public int speed { get; set; }//скорость в буквах в секунду
        public int level { get; set; }//скорость в буквах в секунду


        public ExerciseResultInfo(Exercise exercise, DateTime dateOfPassing, int errorsCount, int assesment)
        {
            this.exercise = exercise;
            this.dateOfPassing = dateOfPassing;
            this.errorsCount = errorsCount;
            this.assesment = assesment;
            this.speed = 0;
            this.level = 0;
        }

        public ExerciseResultInfo(Exercise exercise, DateTime dateOfPassing, int errorsCount, int assesment, int speed)
        {
            this.exercise=exercise;
            this.dateOfPassing = dateOfPassing;
            this.errorsCount=errorsCount;
            this.assesment = assesment;
            this.speed = speed;
            this.level = level;
        }

        public ExerciseResultInfo(int exerciseId, DateTime dateOfPassing, int errorsCount, int assesment, int speed)
        {
            this.exerciseId = exerciseId;
            this.dateOfPassing = dateOfPassing;
            this.errorsCount = errorsCount;
            this.assesment = assesment;
            this.speed = speed;
            this.level = level;
        }
    }
}
