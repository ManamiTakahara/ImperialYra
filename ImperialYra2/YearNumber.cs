using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialYra2
{
    /// <summary>
    /// 年号と西暦を管理するクラス
    /// </summary>
    public class YearNumber
    {
        private string gou;
        private int year1;
        private int year2;
        private int year3;
        public string Gou { get; set; }
        public int Year1 { get; set; }
        public int Year2 { get; set; }

        public YearNumber(string gou, int year1, int year2)
        {
            Gou = gou;
            Year1 = year1;
            Year2 = year2;
        }

        //年号と西暦を全て出力
        public void YearCount(string gou, int year1, int year2)
        {
            var year = 1;
            while (year <= year1)
            {
                var yearCount = year + year2;
                Console.WriteLine($"{gou} {year}年 {yearCount}年");
                year += 1;
            }
            Console.WriteLine();
        }

        protected static void YearCount()
        {
            throw new NotImplementedException();
        }
    }
    public class YearNumber2 : YearNumber
    {
        private int year3;
        public int Year3 { get; set; }
        public YearNumber2(string gou, int year1, int year2, int year3) : base(gou,year1,year2)
        { 
            Year3 = year3;
        }
        public void YearCount2(string gou, int year1, int year2, int year3)
        {
            var year = year2;
            if (year == year3)
            {
                YearNumber.YearCount();
            }
        }
    }
}
