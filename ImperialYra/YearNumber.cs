using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialYra
{
    internal class YearNumber
    {
        //基本クラス
        private int year1;
        private int year2;
        public int Year1 { get; set; }
        public int Year2 { get; set; }

        public YearNumber(int year1, int year2)
        {
            this.year1 = year1;
            this.year2 = year2;
        }
    }
}
