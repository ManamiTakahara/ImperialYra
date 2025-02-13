using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialYra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var years = new List<YearNumber>();
            years.Add(new YearNumber("明治", 45, 1867));
            years.Add(new YearNumber("大正", 15, 1911));
            years.Add(new YearNumber("昭和", 64, 1925));
            years.Add(new YearNumber("平成", 31, 1988));
            years.Add(new YearNumber("令和", 7, 2018));
            
            foreach (YearNumber year in years)
            {
                year.YearCount(year.Gou,year.Year1,year.Year2);
            }
        }  
    }
}
