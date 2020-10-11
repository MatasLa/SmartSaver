using System.Windows.Forms;
using DataManager;

namespace ePiggy.forms.finances.goals
{
    public partial class ExpandedGoalForm : Form
    {
        private readonly Handler _handler;
        private Goal _goal;
        private readonly GoalsForm _parentForm;

        public Goal Goal
        {
            get => _goal;
            set
            {
                _goal = value;
                Init();
            }
        }

        public ExpandedGoalForm(Goal goal, Handler handler, GoalsForm parentForm)
        {
            InitializeComponent();

            _goal = goal;
            _handler = handler;
            _parentForm = parentForm;

            Init();
        }

        private void Init()
        {

        }
    }
}
