using System.Windows.Forms;
using ePiggy.backend;

namespace ePiggy.forms.reports
{
    public partial class FormIncomeVExpenses : Form
    {
        public FormIncomeVExpenses()
        {
            InitializeComponent();
            //Example
            GraphDrawer.DrawIncomesExpensesPieChart(1500,1000);
        }
    }
}
