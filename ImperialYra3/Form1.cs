using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImperialYra3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(yearText.Text, out int year))
            {
                try
                {
                    // 和暦に変換
                    DateTime date = new DateTime(year, 1, 1);
                    JapaneseCalendar jc = new JapaneseCalendar();
                    CultureInfo ci = new CultureInfo("ja-JP", false);
                    ci.DateTimeFormat.Calendar = jc;

                    string wareke = date.ToString("ggyy", ci);
                    westernLabel.Text = $"{yearText.Text}年";
                    inperiaLabel.Text = $"{wareke}年";
                }
                catch
                {
                    westernLabel.Text = "変換できません";
                    inperiaLabel.Text = "変換できません";
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            westernLabel.Text = "西暦が表示されます";
            inperiaLabel.Text = "年号が表示されます";
        }
    }
}
