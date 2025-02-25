using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImperialYra2
{
    /// <summary>
    /// メインフォームの処理を管理
    /// </summary>
    public partial class ImperialYraForm : Form
    {
        
        private YearNumber YearNumber;
        public ImperialYraForm()
        {
            InitializeComponent();
            //年号のデータ
            var years = new List<YearNumber>();
            years.Add(new YearNumber("明治", 45, 1867));
            years.Add(new YearNumber("大正", 15, 1911));
            years.Add(new YearNumber("昭和", 64, 1925));
            years.Add(new YearNumber("平成", 31, 1988));
            years.Add(new YearNumber("令和", 7, 2018));

            var sw = new StreamWriter(@"C:\\Itest.txt");
            YearNumber.YearCount(YearNumber.Gou, YearNumber.Year1, YearNumber.Year2);
            sw.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {   
            textBox1.Text = string.Empty;
            var lines = File.ReadAllLines(@"C:\\Itest.txt");
            foreach (var line in lines) 
            { 
                westernLabel.Text = $"{textBox1.Text}年";
                inperiaLabel.Text = $"{} {}年";

            }

        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            westernLabel.Text = "西暦が表示されます";
            inperiaLabel.Text = "年号が表示されます";
        }
    }
}
