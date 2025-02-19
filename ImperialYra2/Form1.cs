using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImperialYra2
{
    /// <summary>
    /// メインフォームの処理を管理
    /// </summary>
    public partial class ImperialYraForm : Form
    {
        
        private YearNumber2 YearNumber2;
        public ImperialYraForm(int year3)
        {
            InitializeComponent();
            //年号のデータ
            var years = new List<YearNumber2>();
            years.Add(new YearNumber2("明治", 45, 1867, year3));
            years.Add(new YearNumber2("大正", 15, 1911, year3));
            years.Add(new YearNumber2("昭和", 64, 1925, year3));
            years.Add(new YearNumber2("平成", 31, 1988, year3));
            years.Add(new YearNumber2("令和", 7, 2018, year3));

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            YearNumber2.Year3 = textBox1.Text.Length;
            YearNumber2.YearCount2(YearNumber2.Gou,YearNumber2.Year1,YearNumber2.Year2,YearNumber2.Year3);

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            westernLabel.Text = "西暦が表示されます";
            inperiaLabel.Text = "年号が表示されます";
        }
    }
}
