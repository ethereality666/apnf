namespace apnf
{
    partial class AddEmployeeForm
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
            this.FirstEployeeLabel = new System.Windows.Forms.Label();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.ThirdTextBox = new System.Windows.Forms.TextBox();
            this.RoleTextBox = new System.Windows.Forms.TextBox();
            this.SecondEployeeLabel = new System.Windows.Forms.Label();
            this.ThirdEployeeLabel = new System.Windows.Forms.Label();
            this.RoleEployeeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstEployeeLabel
            // 
            this.FirstEployeeLabel.AutoSize = true;
            this.FirstEployeeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstEployeeLabel.Location = new System.Drawing.Point(65, 39);
            this.FirstEployeeLabel.Name = "FirstEployeeLabel";
            this.FirstEployeeLabel.Size = new System.Drawing.Size(141, 21);
            this.FirstEployeeLabel.TabIndex = 13;
            this.FirstEployeeLabel.Text = "Имя сотрудника";
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEmployeeButton.Location = new System.Drawing.Point(12, 296);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(236, 63);
            this.AddEmployeeButton.TabIndex = 12;
            this.AddEmployeeButton.Text = "Добавить сотрудника в базу";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstTextBox.Location = new System.Drawing.Point(22, 63);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Size = new System.Drawing.Size(214, 29);
            this.FirstTextBox.TabIndex = 11;
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondTextBox.Location = new System.Drawing.Point(22, 117);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(214, 29);
            this.SecondTextBox.TabIndex = 16;
            // 
            // ThirdTextBox
            // 
            this.ThirdTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdTextBox.Location = new System.Drawing.Point(22, 173);
            this.ThirdTextBox.Name = "ThirdTextBox";
            this.ThirdTextBox.Size = new System.Drawing.Size(214, 29);
            this.ThirdTextBox.TabIndex = 17;
            // 
            // RoleTextBox
            // 
            this.RoleTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleTextBox.Location = new System.Drawing.Point(22, 229);
            this.RoleTextBox.Name = "RoleTextBox";
            this.RoleTextBox.Size = new System.Drawing.Size(214, 29);
            this.RoleTextBox.TabIndex = 18;
            // 
            // SecondEployeeLabel
            // 
            this.SecondEployeeLabel.AutoSize = true;
            this.SecondEployeeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondEployeeLabel.Location = new System.Drawing.Point(48, 95);
            this.SecondEployeeLabel.Name = "SecondEployeeLabel";
            this.SecondEployeeLabel.Size = new System.Drawing.Size(179, 21);
            this.SecondEployeeLabel.TabIndex = 19;
            this.SecondEployeeLabel.Text = "Фамилия сотрудника";
            this.SecondEployeeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ThirdEployeeLabel
            // 
            this.ThirdEployeeLabel.AutoSize = true;
            this.ThirdEployeeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdEployeeLabel.Location = new System.Drawing.Point(44, 149);
            this.ThirdEployeeLabel.Name = "ThirdEployeeLabel";
            this.ThirdEployeeLabel.Size = new System.Drawing.Size(183, 21);
            this.ThirdEployeeLabel.TabIndex = 20;
            this.ThirdEployeeLabel.Text = "Отчество сотрудника";
            // 
            // RoleEployeeLabel
            // 
            this.RoleEployeeLabel.AutoSize = true;
            this.RoleEployeeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RoleEployeeLabel.Location = new System.Drawing.Point(79, 205);
            this.RoleEployeeLabel.Name = "RoleEployeeLabel";
            this.RoleEployeeLabel.Size = new System.Drawing.Size(101, 21);
            this.RoleEployeeLabel.TabIndex = 21;
            this.RoleEployeeLabel.Text = "Должность";
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 387);
            this.Controls.Add(this.RoleEployeeLabel);
            this.Controls.Add(this.ThirdEployeeLabel);
            this.Controls.Add(this.SecondEployeeLabel);
            this.Controls.Add(this.RoleTextBox);
            this.Controls.Add(this.ThirdTextBox);
            this.Controls.Add(this.SecondTextBox);
            this.Controls.Add(this.FirstEployeeLabel);
            this.Controls.Add(this.AddEmployeeButton);
            this.Controls.Add(this.FirstTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(276, 426);
            this.MinimumSize = new System.Drawing.Size(276, 426);
            this.Name = "AddEmployeeForm";
            this.Text = "Добавление сотрудка";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label FirstEployeeLabel;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.TextBox FirstTextBox;
        private System.Windows.Forms.TextBox SecondTextBox;
        private System.Windows.Forms.TextBox ThirdTextBox;
        private System.Windows.Forms.TextBox RoleTextBox;
        private System.Windows.Forms.Label SecondEployeeLabel;
        private System.Windows.Forms.Label ThirdEployeeLabel;
        private System.Windows.Forms.Label RoleEployeeLabel;
    }
}