using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weightlifting     {
    public class weightlift    {
        public List<Athlete> Athletes { get; set; }
    }
    public class Athlete    {
        public string gender { get; set; }      // Пол
        public string first_name { get; set; }  // Имя
        public string last_name { get; set; }   // Фамилия
        public string country { get; set; }     // Страна
        public int bWeight { get; set; }        // Вес
        public int clean_jerk { get; set; }     // Толчок
        public int snatch { get; set; }         // Рывок
        public int summary_res { get; set; }    // Суммарный результат

        public override string ToString()        {
            var str = first_name + " " + last_name + " из " + country + ", с результатом: " + snatch + "/" + clean_jerk + ":" + summary_res + " || Вес:" + bWeight + ", " + gender;
            return str;
        }
    }
}
