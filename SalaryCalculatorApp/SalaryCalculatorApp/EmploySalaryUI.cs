using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculatorApp
{
    public partial class EmploySalaryUI : Form
    {
        public EmploySalaryUI()
        {
            InitializeComponent();
        }
        EmploySalary aEmploySalary=new EmploySalary();
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void showingSalaryButton_Click(object sender, EventArgs e)
        {
            aEmploySalary.employeeName = employNameTextBox.Text;
            aEmploySalary.basicAmount = Convert.ToDouble(basicAmountTextBox.Text);
            aEmploySalary.houseRent = Convert.ToDouble(houseRentTextBox.Text);
            aEmploySalary.medicalAllowance = Convert.ToDouble(medicalAllowanceTextBox.Text);
            MessageBox.Show(aEmploySalary.employeeName+" your salary is: "  + aEmploySalary.ShowingSalary());



        }
    }
}
