using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialYra
{
    //基本クラス
    internal class YearNumber
    {
        private string gou;
        private int year1;
        private int year2;
        public string Gou { get; set; }
        public int Year1 { get; set; }
        public int Year2 { get; set; }

        public YearNumber(string gou, int year1, int year2)
        {
            Gou = gou;
            Year1 = year1;
            Year2 = year2;
        }

        public void YearCount(int year1, int year2)
        {
            var year = 1;
            while (year <= year1)
            {
                var yearCount = year + year2;
                Console.WriteLine($"yearCount");
                year += 1;
            }
        }
    }
}
