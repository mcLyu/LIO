using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterLIO
{
    class Exercise
    {
        public int id { get; set; }
        public String name { get; set; }
        public int length { get; set; }
        public int maxErrors { get; set; }
        public int maxTime { get; set; }
        public List<KeyboardArea> areas { get; set; }
        public String text { get; set; }
        public int level { get; set; }

        public Exercise()//sample
        {
            this.name = "Sample";
            this.text = "aaa";
            
            List<KeyboardArea> sampleAreas = new List<KeyboardArea>();
            sampleAreas.Add(KeyboardArea.NINE);
            sampleAreas.Add(KeyboardArea.ONE);

            this.areas = sampleAreas;

            this.maxErrors = 4;
            this.level = areas.Capacity;
            this.length = this.text.Length;
        }

        public Exercise(String name, String text, List<KeyboardArea> areas, int maxErrors) 
        {
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = areas.Capacity; // уровень = количеству заюзаных зон
            this.length = text.Length;
        }

        public Exercise(String name, String text, List<KeyboardArea> areas, int maxErrors, int maxTime) 
        {
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = areas.Capacity;
            this.maxTime = maxTime;
            this.length = text.Length;
        }

        public Exercise(int id, String name, String text, List<KeyboardArea> areas, int maxErrors)
        {
            this.id = id;
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = areas.Capacity; // уровень = количеству заюзаных зон
            this.length = text.Length;
        }

        public Exercise(int id, String name, String text, List<KeyboardArea> areas, int maxErrors, int maxTime)
        {
            this.id = id;
            this.name = name;
            this.text = text;
            this.areas = areas;
            this.maxErrors = maxErrors;
            this.level = areas.Capacity; // уровень = количеству заюзаных зон
            this.maxTime = maxTime;
            this.length = text.Length;
        }

        public String getAreasAsString()
        {
            String stringAreas = "";
            foreach (KeyboardArea area in areas)
            {
                stringAreas += area.ToString() + " ";
            }
            return stringAreas;
        }

        public List<Char> getTextsAsArrayChar()
        {
            List<Char> arrayChar = new List<Char>();
            for (int i = 0; i < this.text.Length;i++ )
            {
                arrayChar.Add(this.text[i]);
            }
            return arrayChar;
        }

        public static List<KeyboardArea> getAreasList(String areas)
        {
            List<KeyboardArea> enumAreas = new List<KeyboardArea>();

            string[] areasList = areas.Split(new Char [] {' '});
            
            foreach (string area in areasList){
                if (System.Enum.IsDefined(typeof(KeyboardArea), area))
                {
                    KeyboardArea enumArea = (KeyboardArea)Enum.Parse(typeof(KeyboardArea), area);
                    enumAreas.Add(enumArea);
                }
            }

            return enumAreas;
        }
    }

    enum KeyboardArea { ONE,TWO,THREE,FOUR,FIVE,SIX,SEVEN,EIGHT,NINE }//девять зон клавиатуры
}
