using System.Windows.Forms;
using EmployeeStoreApp.BusinessClass;
using EmployeeStoreApp.DBModule.DAO;

namespace EmployeeStoreApp.UI
{
    public partial class SearchOrModifyEmployeeUI : Form
    {
        public SearchOrModifyEmployeeUI()
        {
            InitializeComponent();
        }

        private EmployeeManager anEmployeeManager=new EmployeeManager();
        private void searchButton_Click(object sender, System.EventArgs e)
        {
            resultView.Items.Clear();
            if (nameTextBox.Text != string.Empty)
            {
                foreach (Employee employee in anEmployeeManager.GetEmployeesByName(nameTextBox.Text))
                {
                    ListViewItem aListViewItem=new ListViewItem(employee.Serial.ToString());
                    aListViewItem.SubItems.Add(employee.Name);
                    aListViewItem.SubItems.Add(employee.Email);
                    resultView.Items.Add(aListViewItem);
                }
                ;
            }
        }
    }
}
