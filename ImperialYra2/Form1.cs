using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Reflection;


namespace ImperialYra2
{
    /// <summary>
    /// メインフォームの処理を管理
    /// </summary>
    public partial class ImperialYraForm : Form
    {
        private List<YearNumber> yearList = new List<YearNumber>();

        public ImperialYraForm()
        {
            InitializeComponent();
            LoadEraData(); // JSONデータ読み込み
        }

        private void LoadEraData()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "ImperialYra2.Resources.era_data.json";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string json = reader.ReadToEnd();
                yearList = JsonSerializer.Deserialize<List<YearNumber>>(json);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int year))
            {
                MessageBox.Show("西暦を正しく入力してください");
                return;
            }

            List<string> matchedEras = new List<string>();

            foreach (var yn in yearList)
            {
                string result = yn.GetImperial(year);
                if (result != null)
                {
                    matchedEras.Add(result);
                }
            }

            if (matchedEras.Count > 0)
            {
                // 2つずつで改行する形式に整形
                List<string> formattedLines = new List<string>();
                for (int i = 0; i < matchedEras.Count; i += 2)
                {
                    if (i + 1 < matchedEras.Count)
                        formattedLines.Add($"{matchedEras[i]} / {matchedEras[i + 1]}");
                    else
                        formattedLines.Add(matchedEras[i]);
                }

                inperiaLabel.Text = string.Join("\n", formattedLines);
            }
            else
            {
                inperiaLabel.Text = "該当なし";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            westernLabel.Text = "西暦が表示されます";
            inperiaLabel.Text = "年号が表示されます";
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text.Trim();  // 例：「昭和45」や「平成元」

            if (string.IsNullOrEmpty(input)) return;

            string gou = null;
            int nen = 0;

            // 「元年」に対応
            if (input.EndsWith("元"))
            {
                gou = input.Substring(0, input.Length - 1);
                nen = 1;
            }
            else
            {
                // 漢字＋数字の分離（例：「昭和45」→「昭和」「45」）
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]))
                    {
                        gou = input.Substring(0, i);
                        if (!int.TryParse(input.Substring(i), out nen)) return;
                        break;
                    }
                }
            }

            int? seireki = null;
            foreach (var yn in yearList)
            {
                var result = yn.ToSeireki(gou, nen);
                if (result != null)
                {
                    seireki = result;
                    break;
                }
            }

            if (seireki != null)
            {
                inperiaLabel.Text = $"{gou}{(nen == 1 ? "元" : nen.ToString())}年";
                westernLabel.Text = $"西暦{seireki}年";
            }
            else
            {
                MessageBox.Show("該当する和暦が見つかりませんでした。");
            }
        }
    }
}