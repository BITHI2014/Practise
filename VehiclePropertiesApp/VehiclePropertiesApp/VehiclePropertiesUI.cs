using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle
{
    public partial class VehiclePropertiesUI : Form
    {
        public VehiclePropertiesUI()
        {
            InitializeComponent();
        }
        Vehicle aVehicle;
        private void createButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text) || string.IsNullOrEmpty(regNoTextBox.Text) ||
                string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(regNoTextBox.Text))
                MessageBox.Show("Please Enter Vehicle Name and RegNo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                 aVehicle = new Vehicle(nameTextBox.Text, regNoTextBox.Text);
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            try
            {
                aVehicle.Speed = double.Parse(speedTextBox.Text);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Please Enter Vehicle Speed.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid Speed. Enter a valid speed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No Vehicle found. You need to create a vehicle first to set the speed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                minSpeedTextBox.Text = aVehicle.MinSpeed.ToString();
                maxSpeedTextBox.Text = aVehicle.MaxSpeed.ToString();
                averageSpeedTextBox.Text = aVehicle.AverageSpeed.ToString();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("No Vehicle found. You need to create a vehicle first and set the speed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VehiclePropertiesUI_Load(object sender, EventArgs e)
        {
            
        }
    }
}
