using System.Drawing;
using System.Globalization;
using System.IO;
using ImageChartsLib;

namespace ePiggy.Utilities
{
    public class GraphDrawer
    {
        
        public static Bitmap DrawIncomesExpensesPieChart(decimal size1, decimal size2)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            var inc = size1.ToString(nfi);
            var exp = size2.ToString(nfi);
            var chartInfo = $"a:{inc},{exp}";

            var pie = new ImageCharts()
                .cht("p")
                .chl("Incomes|Expenses")
                .chco("00b7ff|eb5244")
                .chd(chartInfo)
                .chs("400x400");

            using var ms = new MemoryStream(pie.toBuffer());
            var bitmap = new Bitmap(ms);

            return bitmap;
        }
    }
}
