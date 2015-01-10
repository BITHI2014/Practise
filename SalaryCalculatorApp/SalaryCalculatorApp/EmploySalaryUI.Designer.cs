namespace SalaryCalculatorApp
{
    partial class EmploySalaryUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employNameTextBox = new System.Windows.Forms.TextBox();
            this.basicAmountTextBox = new System.Windows.Forms.TextBox();
            this.houseRentTextBox = new System.Windows.Forms.TextBox();
            this.medicalAllowanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showingSalaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employNameTextBox
            // 
            this.employNameTextBox.Location = new System.Drawing.Point(93, 16);
            this.employNameTextBox.Name = "employNameTextBox";
            this.employNameTextBox.Size = new System.Drawing.Size(261, 20);
            this.employNameTextBox.TabIndex = 0;
            // 
            // basicAmountTextBox
            // 
            this.basicAmountTextBox.Location = new System.Drawing.Point(93, 52);
            this.basicAmountTextBox.Name = "basicAmountTextBox";
            this.basicAmountTextBox.Size = new System.Drawing.Size(140, 20);
            this.basicAmountTextBox.TabIndex = 1;
            // 
            // houseRentTextBox
            // 
            this.houseRentTextBox.Location = new System.Drawing.Point(93, 100);
            this.houseRentTextBox.Name = "houseRentTextBox";
            this.houseRentTextBox.Size = new System.Drawing.Size(140, 20);
            this.houseRentTextBox.TabIndex = 2;
            // 
            // medicalAllowanceTextBox
            // 
            this.medicalAllowanceTextBox.Location = new System.Drawing.Point(104, 164);
            this.medicalAllowanceTextBox.Name = "medicalAllowanceTextBox";
            this.medicalAllowanceTextBox.Size = new System.Drawing.Size(129, 20);
            this.medicalAllowanceTextBox.TabIndex = 3;
            this.medicalAllowanceTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Employ Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Medical Allowance";
            // 
            // showingSalaryButton
            // 
            this.showingSalaryButton.Location = new System.Drawing.Point(81, 243);
            this.showingSalaryButton.Name = "showingSalaryButton";
            this.showingSalaryButton.Size = new System.Drawing.Size(231, 23);
            this.showingSalaryButton.TabIndex = 8;
            this.showingSalaryButton.Text = "Show Me Salary";
            this.showingSalaryButton.UseVisualStyleBackColor = true;
            this.showingSalaryButton.Click += new System.EventHandler(this.showingSalaryButton_Click);
            // 
            // EmploySalaryUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 336);
            this.Controls.Add(this.showingSalaryButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.medicalAllowanceTextBox);
            this.Controls.Add(this.houseRentTextBox);
            this.Controls.Add(this.basicAmountTextBox);
            this.Controls.Add(this.employNameTextBox);
            this.Name = "EmploySalaryUI";
            this.Text = "EmploySalaryUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox employNameTextBox;
        private System.Windows.Forms.TextBox basicAmountTextBox;
        private System.Windows.Forms.TextBox houseRentTextBox;
        private System.Windows.Forms.TextBox medicalAllowanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button showingSalaryButton;
    }
}

