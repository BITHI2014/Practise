using System.Windows.Forms;

namespace EmployeeStoreApp.UI
{
    public partial class EmployeeActivityUI : Form
    {
        public EmployeeActivityUI()
        {
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, System.EventArgs e)
        {
            new EmployeeInfoUI().Show();
        }

        private void addDesignationButton_Click(object sender, System.EventArgs e)
        {
            new AddDesignationUI().Show();
        }

        private void findAndEditButton_Click(object sender, System.EventArgs e)
        {
            new SearchOrModifyEmployeeUI().Show();
        }

        private void EmployeeActivityUI_Load(object sender, System.EventArgs e)
        {

        }
    }
}
