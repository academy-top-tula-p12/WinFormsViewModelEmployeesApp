namespace WinFormsViewModelEmployeesApp
{
    partial class EmployeesForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstBoxEmployees = new ListBox();
            grpEmployee = new GroupBox();
            txtName = new TextBox();
            txtAge = new NumericUpDown();
            btnAdd = new Button();
            grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).BeginInit();
            SuspendLayout();
            // 
            // lstBoxEmployees
            // 
            lstBoxEmployees.Font = new Font("Segoe UI", 16F);
            lstBoxEmployees.FormattingEnabled = true;
            lstBoxEmployees.ItemHeight = 30;
            lstBoxEmployees.Location = new Point(12, 12);
            lstBoxEmployees.Name = "lstBoxEmployees";
            lstBoxEmployees.Size = new Size(304, 424);
            lstBoxEmployees.TabIndex = 0;
            // 
            // grpEmployee
            // 
            grpEmployee.Controls.Add(btnAdd);
            grpEmployee.Controls.Add(txtAge);
            grpEmployee.Controls.Add(txtName);
            grpEmployee.Font = new Font("Segoe UI", 16F);
            grpEmployee.Location = new Point(348, 12);
            grpEmployee.Name = "grpEmployee";
            grpEmployee.Size = new Size(410, 412);
            grpEmployee.TabIndex = 1;
            grpEmployee.TabStop = false;
            grpEmployee.Text = "Employee";
            // 
            // txtName
            // 
            txtName.Location = new Point(26, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(362, 36);
            txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(26, 111);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(362, 36);
            txtAge.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(26, 173);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(362, 49);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // EmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 450);
            Controls.Add(grpEmployee);
            Controls.Add(lstBoxEmployees);
            Name = "EmployeesForm";
            Text = "Employees";
            grpEmployee.ResumeLayout(false);
            grpEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtAge).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstBoxEmployees;
        private GroupBox grpEmployee;
        private Button btnAdd;
        private NumericUpDown txtAge;
        private TextBox txtName;
    }
}
