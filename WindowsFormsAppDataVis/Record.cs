using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppDataVis
{
    public class Record
    {
        public int id;
        public string time;  // ne pas mettre en string
        public double x;
        public double y;
        public double z;
        public string name;
        public int id1;

        public override string ToString()
        {
            return name;
        }
    }
}
