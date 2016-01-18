using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    static class Session
    {
        public static Exercise CurrentExercise { get; set; }
        public static ExerciseResultInfo CurrentResultInfo { get; set; }
    }
}
