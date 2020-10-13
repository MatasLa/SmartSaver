using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ImageChartsLib;

namespace ePiggy.backend
{
    class GraphDrawer
    {
        
        public static void DrawIncomesExpensesPieChart(decimal incomes, decimal expenses)
        {

            NumberFormatInfo nfi = new NumberFormatInfo();
            nfi.NumberDecimalSeparator = ".";

            string inc = incomes.ToString(nfi);
            string exp = expenses.ToString(nfi);
            string chartInfo = String.Format("a:{0},{1}", inc, exp);

            ImageCharts pie = new ImageCharts().cht("p").chl("Incomes|Expenses").chd(chartInfo).chs("400x400");

            string path1 = @"resources/charts";
            Debug.WriteLine(path1);

            string projectDirectory = System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug\\netcoreapp3.1", "");

            string fullPath = projectDirectory + "/resources/charts/PieChart.png";
            // string fullPaths = String.Format("{1}/PieChart.png", fullPath);

            //Debug.WriteLine(fullPaths);

            pie.toFile(fullPath); //
        }
    }
}
