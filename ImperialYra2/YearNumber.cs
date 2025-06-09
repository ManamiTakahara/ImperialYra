using System;
using System.Text.Json.Serialization;

namespace ImperialYra2
{
    // 元号の処理クラス
    public class YearNumber
    {
        [JsonPropertyName("Gou")]
        public string Gou { get; set; }        // 元号名（例：令和）
        [JsonPropertyName("Lengeth")]
        public int Length { get; set; }        // 継続年数（例：31）
        [JsonPropertyName("startYear")]
        public int StartYear { get; set; }     // 開始年の西暦（例：1989）

        public string GetImperial(int westernYear)
        {
            if (westernYear >= StartYear && westernYear < StartYear + Length)
            {
                int gengouYear = westernYear - StartYear + 1;
                return $"{Gou}{(gengouYear == 1 ? "元" : gengouYear.ToString())}年";
            }
            return null;
        }

        // 逆引きのメソッド
        public int? ToSeireki(string gou, int nen)
        {
            if (Gou == gou && nen >= 1 && nen <= Length)
            {
                return StartYear + nen - 1;
            }
            return null;
        }

    }
}
