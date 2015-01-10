using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultCalculatorApp
{
    public partial class ResultCalculatorUI : Form
    {
        public ResultCalculatorUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            ResultCalculator aResultCalculator=new ResultCalculator();
            double averageMark=aResultCalculator.CalculateAverage(double.Parse(physicsTextBox.Text), double.Parse(chemistryTextBox.Text),
                double.Parse(mathTextBox.Text));
            averageTextBox.Text = averageMark.ToString();
            gradeLetterTextBox.Text = aResultCalculator.GetLetterGrade(averageMark);
        }
    }
}
