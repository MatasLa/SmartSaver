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
    public static class GraphDrawer
    {
        public static Size DefaultSize = new Size(400, 400);
        public static readonly List<string> ColorsList = new List<string> { "009933", "ff3300", "ff9900", "669900", "0099cc" };
        public static Bitmap DrawIncomesExpensesPieChart(decimal size1, decimal size2)
        {
            var nfi = new NumberFormatInfo {NumberDecimalSeparator = "."};

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

        public static Bitmap DrawMultipleVarPieChart(IEnumerable<decimal> valuesList, IEnumerable<string> namesList, IEnumerable<string> colorsList, Size size)
        {
            var nfi = new NumberFormatInfo {NumberDecimalSeparator = "."};

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

        public static Bitmap DrawMultipleVarBarChart(string name, IEnumerable<decimal> valuesList, IEnumerable<string> namesList, int highestValue, Size size)
        {
            var nfi = new NumberFormatInfo {NumberDecimalSeparator = "."};

            var values = string.Join(",", valuesList.Select(d => d.ToString(nfi)));
            var names = string.Join("|", namesList);

            var chartInfo = $"a:{values}";
            var barNames = $"0:|{names}";

            var chartSize = size.Height + "x" + size.Width;

            var bar = new ImageCharts()
                .cht("bvs")
                .chbr("8")
                .chs(chartSize)
                .chtt(name)
                .chxl(barNames)
                .chd(chartInfo)
                .chxt("x,y")
                .chxr($"1,0,{highestValue}");

            using var ms = new MemoryStream(bar.toBuffer());
            var bitmap = new Bitmap(ms);

            return bitmap;
        }
    }
}
