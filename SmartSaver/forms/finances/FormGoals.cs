using System.Windows.Forms;
using DataManager;
using ePiggy.utilities;

namespace ePiggy.forms.finances
{
    public partial class FormGoals : Form
    {
        private Handler _handler;

        private Form _goalForm1;
        private Form _goalForm2;
        private Form _goalForm3;
        private Form _goalForm4;
        private Form _goalForm5;

        public FormGoals(Handler handler)
        {
            InitializeComponent();
            _handler = handler;

            Init();
        }

        private void Init()
        {
            DisplayGoals();
        }

        private void DisplayGoals()
        {
            FormChanger.OpenChildForm(ref _goalForm1, new GoalForm(new Goal(), _handler), panelGoal1);

            FormChanger.OpenChildForm(ref _goalForm2, new GoalForm(new Goal(), _handler), panelGoal2);

            FormChanger.OpenChildForm(ref _goalForm3, new GoalForm(new Goal(), _handler), panelGoal3);



        }

        private void AddGoalButtonClick(object sender, System.EventArgs e)
        {
            OpenGoalDialog();
        }

        private void OpenGoalDialog()
        {
            new GoalDialogForm().ShowDialog();
        }

        private void panelGoal1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
