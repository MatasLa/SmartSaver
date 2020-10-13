using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ImageChartsLib;

namespace ePiggy.backend
{
    class GraphDrawer
    {
        
        public static Bitmap DrawIncomesExpensesPieChart(decimal incomes, decimal expenses)
        {

            var nfi = CultureInfo.CurrentCulture.NumberFormat;

            var inc = incomes.ToString(nfi);
            var exp = expenses.ToString(nfi);
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
