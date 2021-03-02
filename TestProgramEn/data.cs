using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgramEn
{
    class data
    {
        public int testNo;
        public string name;
        public string unit;
        public string hour;
        public string day;
        public string storage;
        public string note;

        public string to_string()
        {
            return testNo + " / " + name + " / " + unit + " / " + hour + " / " + day + " / " + storage + " / " + note;
        }
    }
}
