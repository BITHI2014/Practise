using System.Windows.Forms;
using EmployeeStoreApp.BusinessClass;
using EmployeeStoreApp.DBModule;
using EmployeeStoreApp.DBModule.DAO;

namespace EmployeeStoreApp.UI
{
    public partial class AddDesignationUI : Form
    {
        public AddDesignationUI()
        {
            InitializeComponent();
        }

        private EmployeeManager anEmployeeManager=new EmployeeManager();
        private void saveButton_Click(object sender, System.EventArgs e)
        {
            if (codeTextBox.Text != string.Empty && titleTextBox.Text != string.Empty)
            {
                try
                {
                    Designation aDesignation = new Designation();
                    aDesignation.Code = codeTextBox.Text;
                    aDesignation.Title = titleTextBox.Text;
                    anEmployeeManager.AddDesignation(aDesignation);
                    MessageBox.Show("Designation Added.");
                }
                catch (DuplicateDesignationCodeException anException)
                {
                    MessageBox.Show(anException.Message);
                }
            }
        }
    }
}
