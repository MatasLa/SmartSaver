using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using ImageChartsLib;

namespace ePiggy.Utilities
{
    public class GraphDrawer
    {
        
        public static Bitmap DrawIncomesExpensesPieChart(decimal size1, decimal size2)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            var chartInfo = $"a:{size1.ToString(nfi)},{size2.ToString(nfi)}";

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

        public static Bitmap DrawMultipleVarPieChart(List<Decimal> valuesList, List<String> namesList, List<String> colorsList, Size size)
        {
            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            var values = string.Join(",", valuesList.Select(d => d.ToString(nfi)));
            var names = string.Join("|", namesList);
            var colors = string.Join("|", colorsList);


            var chartInfo = $"a:{values}";
            var chartSize = size.Height + "x" + size.Width;

            var pie = new ImageCharts()
                .cht("p")
                .chl(names)
                .chco(colors)
                .chd(chartInfo)
                .chs(chartSize);

            using var ms = new MemoryStream(pie.toBuffer());
            var bitmap = new Bitmap(ms);

            return bitmap;
        }
    }
}
