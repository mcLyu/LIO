using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class Exercise
    {
        public String name { get; set; }
        public int length { get; set; }
        public int maxErrors { get; set; }
        public DateTime maxTime { get; set; }
        public List<KeyboardArea> areas { get; set; }
        public String text { get; set; }
        public int level { get; set; }

        public Exercise(String name, String text, List<KeyboardArea> areas, int maxErrors) 
        {
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = areas.Capacity; // уровень = количеству заюзаных зон
        }

        public Exercise(String name, String text, List<KeyboardArea> areas, int maxErrors, DateTime maxTime) 
        {
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = areas.Capacity;
            this.maxTime = maxTime;
        }
    }

    enum KeyboardArea { ONE,TWO,THREE,FOUR,FIVE,SIX,SEVEN,EIGHT,NINE }//девять зон клавиатуры
}
