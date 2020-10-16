using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ImageChartsLib;

namespace ePiggy.DataManager
{
    class GraphDrawer
    {
        
        public static Bitmap DrawIncomesExpensesPieChart(decimal size1, decimal size2)
        {
            var inc = size1.ToString(CultureInfo.CurrentCulture.NumberFormat);
            var exp = size2.ToString(CultureInfo.CurrentCulture.NumberFormat);
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
