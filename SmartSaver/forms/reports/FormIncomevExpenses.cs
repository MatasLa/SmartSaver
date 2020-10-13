using System.Windows.Forms;
using ePiggy.backend;

namespace ePiggy.forms.reports
{
    public partial class FormIncomeVExpenses : Form
    {
        public FormIncomeVExpenses()
        {
            InitializeComponent();
            GraphDrawer.DrawIncomesExpensesPieChart(1000,1000);
        }
    }
}
