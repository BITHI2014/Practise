using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorApp
{
    public partial class RefrigeratorUI : Form
    {
        public RefrigeratorUI()
        {
            InitializeComponent();
        }

        Refrigerator aRefrigerator=new Refrigerator();
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                aRefrigerator.MaxWeight = double.Parse(maxWeightTextBox.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(@"Please Enter maximum weight (kg) first and try again.");
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Invalid Weight. Please Enter a valid weight in kg.");
            }
            catch (OverwritingMaxWeightException aException)
            {
                maxWeightTextBox.Text = aRefrigerator.MaxWeight.ToString();
                MessageBox.Show(aException.Message);
            }
            catch (NegetiveMaxWeightException aException)
            {
                MessageBox.Show(aException.Message);
            }
            
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                aRefrigerator.AddItems(int.Parse(noOfItemsTextBox.Text), double.Parse(weightTextBox.Text));
                currentWeightTextBox.Text = aRefrigerator.CurrentWeight.ToString();
                remainingWeightTextBox.Text = aRefrigerator.RemainingWeight.ToString();
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show(@"Please Enter no of items and weight per unit and try again.");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(@"Invalid input. Please Enter a valid input.");
            }
            catch (OverflowToMaxWeightException exception)
            {
                MessageBox.Show(exception.Message);
            }
            catch (MaxWeightNotSetException aException)
            {
                MessageBox.Show(aException.Message);
            }
        }

        private void RefrigeratorUI_Load(object sender, EventArgs e)
        {
        }
    }
}
