namespace apnf
{
    partial class AddPaymentForm
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
            this.PatchLabel = new System.Windows.Forms.Label();
            this.IDEployeeLabel = new System.Windows.Forms.Label();
            this.AddPaymentButton = new System.Windows.Forms.Button();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.PatchNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PatchNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // PatchLabel
            // 
            this.PatchLabel.AutoSize = true;
            this.PatchLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatchLabel.Location = new System.Drawing.Point(57, 95);
            this.PatchLabel.Name = "PatchLabel";
            this.PatchLabel.Size = new System.Drawing.Size(149, 21);
            this.PatchLabel.TabIndex = 9;
            this.PatchLabel.Text = "Заработная плата";
            // 
            // IDEployeeLabel
            // 
            this.IDEployeeLabel.AutoSize = true;
            this.IDEployeeLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDEployeeLabel.Location = new System.Drawing.Point(65, 31);
            this.IDEployeeLabel.Name = "IDEployeeLabel";
            this.IDEployeeLabel.Size = new System.Drawing.Size(126, 21);
            this.IDEployeeLabel.TabIndex = 8;
            this.IDEployeeLabel.Text = "ID сотрудника";
            // 
            // AddPaymentButton
            // 
            this.AddPaymentButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPaymentButton.Location = new System.Drawing.Point(12, 172);
            this.AddPaymentButton.Name = "AddPaymentButton";
            this.AddPaymentButton.Size = new System.Drawing.Size(236, 43);
            this.AddPaymentButton.TabIndex = 7;
            this.AddPaymentButton.Text = "Совершить выплату";
            this.AddPaymentButton.UseVisualStyleBackColor = true;
            this.AddPaymentButton.Click += new System.EventHandler(this.AddPaymentButton_Click);
            // 
            // IDTextBox
            // 
            this.IDTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDTextBox.Location = new System.Drawing.Point(22, 55);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(214, 29);
            this.IDTextBox.TabIndex = 5;
            // 
            // PatchNumericUpDown
            // 
            this.PatchNumericUpDown.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.PatchNumericUpDown.Location = new System.Drawing.Point(22, 122);
            this.PatchNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.PatchNumericUpDown.Name = "PatchNumericUpDown";
            this.PatchNumericUpDown.Size = new System.Drawing.Size(214, 29);
            this.PatchNumericUpDown.TabIndex = 10;
            this.PatchNumericUpDown.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // AddPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 227);
            this.Controls.Add(this.PatchNumericUpDown);
            this.Controls.Add(this.PatchLabel);
            this.Controls.Add(this.IDEployeeLabel);
            this.Controls.Add(this.AddPaymentButton);
            this.Controls.Add(this.IDTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(276, 266);
            this.MinimumSize = new System.Drawing.Size(276, 266);
            this.Name = "AddPaymentForm";
            this.Text = "Создание выплаты";
            ((System.ComponentModel.ISupportInitialize)(this.PatchNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatchLabel;
        private System.Windows.Forms.Label IDEployeeLabel;
        private System.Windows.Forms.Button AddPaymentButton;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.NumericUpDown PatchNumericUpDown;
    }
}