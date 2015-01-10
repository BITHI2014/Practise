using System.Linq;
using System.Windows.Forms;
using EmployeeStoreApp.BusinessClass;
using EmployeeStoreApp.DBModule.DAO;

namespace EmployeeStoreApp.UI
{
    public partial class EmployeeInfoUI : Form
    {
        public EmployeeInfoUI()
        {
            InitializeComponent();
        }
        EmployeeManager anEmployeeManager=new EmployeeManager();
        private void saveButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Employee anEmployee = new Employee();
                anEmployee.Name = nameTextBox.Text;
                anEmployee.Email = emailTextBox.Text;
                anEmployee.Address = addressTextBox.Text;
                anEmployee.Designation = (Designation) designationComboBox.SelectedItem;
                anEmployeeManager.AddEmployee(anEmployee);
                MessageBox.Show("Employee Added.");
            }
            catch (DuplicateEmployeeEmailException anException)
            {
                MessageBox.Show(anException.Message);
            }
        }

        private void EmployeeInfoUI_Load(object sender, System.EventArgs e)
        {
            designationComboBox.DataSource = null;
            designationComboBox.DataSource = anEmployeeManager.GetAllDesignations().ToList();
            designationComboBox.DisplayMember = "Title";
        }
    }
}
