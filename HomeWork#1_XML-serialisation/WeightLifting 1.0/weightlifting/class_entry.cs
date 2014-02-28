using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weightlifting     {
    public class weightlift    {
        public List<Athletes> Athlete { get; set; }
    }
    public class Athletes    {
        public string gender { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string country { get; set; }
        public int clean_jerk { get; set; }
        public int snatch { get; set; }
        public int summary_res { get; set; }

        public override string ToString()        {
            var str = first_name + last_name + country + clean_jerk + snatch + summary_res + gender;
            return str;
        }
    }
}
