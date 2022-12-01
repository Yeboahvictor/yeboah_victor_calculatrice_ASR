namespace calculator
{
    partial class Form1
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
            this.UserInputText = new System.Windows.Forms.TextBox();
            this.CalculationResultText = new System.Windows.Forms.Label();
            this.ButtomsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CEButton = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Key7 = new System.Windows.Forms.Button();
            this.Key8 = new System.Windows.Forms.Button();
            this.Key9 = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Key4 = new System.Windows.Forms.Button();
            this.Key5 = new System.Windows.Forms.Button();
            this.Key6 = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Key1 = new System.Windows.Forms.Button();
            this.Key2 = new System.Windows.Forms.Button();
            this.Key3 = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Plus_minus = new System.Windows.Forms.Button();
            this.Key0 = new System.Windows.Forms.Button();
            this.Point = new System.Windows.Forms.Button();
            this.Equal_sign = new System.Windows.Forms.Button();
            this.ButtomsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserInputText
            // 
            this.UserInputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserInputText.Location = new System.Drawing.Point(2, 0);
            this.UserInputText.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.UserInputText.Name = "UserInputText";
            this.UserInputText.Size = new System.Drawing.Size(495, 19);
            this.UserInputText.TabIndex = 0;
            // 
            // CalculationResultText
            // 
            this.CalculationResultText.Location = new System.Drawing.Point(-1, 22);
            this.CalculationResultText.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CalculationResultText.Name = "CalculationResultText";
            this.CalculationResultText.Size = new System.Drawing.Size(472, 36);
            this.CalculationResultText.TabIndex = 1;
            this.CalculationResultText.Text = "Saisir une equation";
            // 
            // ButtomsPanel
            // 
            this.ButtomsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtomsPanel.ColumnCount = 4;
            this.ButtomsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtomsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtomsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtomsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtomsPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtomsPanel.Controls.Add(this.Divide, 3, 0);
            this.ButtomsPanel.Controls.Add(this.Key7, 0, 1);
            this.ButtomsPanel.Controls.Add(this.Key8, 1, 1);
            this.ButtomsPanel.Controls.Add(this.Key9, 2, 1);
            this.ButtomsPanel.Controls.Add(this.Multiply, 3, 1);
            this.ButtomsPanel.Controls.Add(this.Key4, 0, 2);
            this.ButtomsPanel.Controls.Add(this.Key5, 1, 2);
            this.ButtomsPanel.Controls.Add(this.Key6, 2, 2);
            this.ButtomsPanel.Controls.Add(this.Subtract, 3, 2);
            this.ButtomsPanel.Controls.Add(this.Key1, 0, 3);
            this.ButtomsPanel.Controls.Add(this.Key2, 1, 3);
            this.ButtomsPanel.Controls.Add(this.Key3, 2, 3);
            this.ButtomsPanel.Controls.Add(this.Add, 3, 3);
            this.ButtomsPanel.Controls.Add(this.Plus_minus, 0, 4);
            this.ButtomsPanel.Controls.Add(this.Key0, 1, 4);
            this.ButtomsPanel.Controls.Add(this.Point, 2, 4);
            this.ButtomsPanel.Controls.Add(this.Equal_sign, 3, 4);
            this.ButtomsPanel.Location = new System.Drawing.Point(2, 61);
            this.ButtomsPanel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.ButtomsPanel.Name = "ButtomsPanel";
            this.ButtomsPanel.RowCount = 5;
            this.ButtomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtomsPanel.Size = new System.Drawing.Size(474, 283);
            this.ButtomsPanel.TabIndex = 2;
            // 
            // CEButton
            // 
            this.CEButton.BackColor = System.Drawing.Color.Red;
            this.CEButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Location = new System.Drawing.Point(5, 3);
            this.CEButton.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(108, 50);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = false;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // Divide
            // 
            this.Divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Divide.Location = new System.Drawing.Point(359, 3);
            this.Divide.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(110, 50);
            this.Divide.TabIndex = 3;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Key7
            // 
            this.Key7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Key7.Location = new System.Drawing.Point(5, 59);
            this.Key7.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Key7.Name = "Key7";
            this.Key7.Size = new System.Drawing.Size(108, 50);
            this.Key7.TabIndex = 4;
            this.Key7.Text = "7";
            this.Key7.UseVisualStyleBackColor = true;
            this.Key7.Click += new System.EventHandler(this.button2_Click);
            // 
            // Key8
            // 
            this.Key8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Key8.Location = new System.Drawing.Point(123, 59);
            this.Key8.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Key8.Name = "Key8";
            this.Key8.Size = new System.Drawing.Size(108, 50);
            this.Key8.TabIndex = 5;
            this.Key8.Text = "8";
            this.Key8.UseVisualStyleBackColor = true;
            this.Key8.Click += new System.EventHandler(this.Key8_Click);
            // 
            // Key9
            // 
            this.Key9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Key9.Location = new System.Drawing.Point(241, 59);
            this.Key9.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Key9.Name = "Key9";
            this.Key9.Size = new System.Drawing.Size(108, 50);
            this.Key9.TabIndex = 6;
            this.Key9.Text = "9";
            this.Key9.UseVisualStyleBackColor = true;
            this.Key9.Click += new System.EventHandler(this.Key9_Click);
            // 
            // Multiply
            // 
            this.Multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multiply.Location = new System.Drawing.Point(359, 59);
            this.Multiply.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(110, 50);
            this.Multiply.TabIndex = 7;
            this.Multiply.Text = "X";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Key4
            // 
            this.Key4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Key4.Location = new System.Drawing.Point(5, 115);
            this.Key4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Key4.Name = "Key4";
            this.Key4.Size = new System.Drawing.Size(108, 50);
            this.Key4.TabIndex = 8;
            this.Key4.Text = "4";
            this.Key4.UseVisualStyleBackColor = true;
            this.Key4.Click += new System.EventHandler(this.Key4_Click);
            // 
            // Key5
            // 
            this.Key5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Key5.Location = new System.Drawing.Point(123, 115);
            this.Key5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Key5.Name = "Key5";
            this.Key5.Size = new System.Drawing.Size(108, 50);
            this.Key5.TabIndex = 9;
            this.Key5.Text = "5";
            this.Key5.UseVisualStyleBackColor = true;
            this.Key5.Click += new System.EventHandler(this.Key5_Click);
            // 
            // Key6
            // 
            this.Key6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Key6.Location = new System.Drawing.Point(241, 115);
            this.Key6.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Key6.Name = "Key6";
            this.Key6.Size = new System.Drawing.Size(108, 50);
            this.Key6.TabIndex = 10;
            this.Key6.Text = "6";
            this.Key6.UseVisualStyleBackColor = true;
            this.Key6.Click += new System.EventHandler(this.Key6_Click);
            // 
            // Subtract
            // 
            this.Subtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subtract.Location = new System.Drawing.Point(359, 115);
            this.Subtract.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(110, 50);
            this.Subtract.TabIndex = 11;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Key1
            // 
            this.Key1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Key1.Location = new System.Drawing.Point(5, 171);
            this.Key1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Key1.Name = "Key1";
            this.Key1.Size = new System.Drawing.Size(108, 50);
            this.Key1.TabIndex = 12;
            this.Key1.Text = "1";
            this.Key1.UseVisualStyleBackColor = true;
            this.Key1.Click += new System.EventHandler(this.Key1_Click);
            // 
            // Key2
            // 
            this.Key2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Key2.Location = new System.Drawing.Point(123, 171);
            this.Key2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Key2.Name = "Key2";
            this.Key2.Size = new System.Drawing.Size(108, 50);
            this.Key2.TabIndex = 13;
            this.Key2.Text = "2";
            this.Key2.UseVisualStyleBackColor = true;
            this.Key2.Click += new System.EventHandler(this.Key2_Click);
            // 
            // Key3
            // 
            this.Key3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Key3.Location = new System.Drawing.Point(241, 171);
            this.Key3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Key3.Name = "Key3";
            this.Key3.Size = new System.Drawing.Size(108, 50);
            this.Key3.TabIndex = 14;
            this.Key3.Text = "3";
            this.Key3.UseVisualStyleBackColor = true;
            this.Key3.Click += new System.EventHandler(this.button12_Click);
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add.Location = new System.Drawing.Point(359, 171);
            this.Add.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(110, 50);
            this.Add.TabIndex = 15;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Plus_minus
            // 
            this.Plus_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Plus_minus.Location = new System.Drawing.Point(5, 227);
            this.Plus_minus.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Plus_minus.Name = "Plus_minus";
            this.Plus_minus.Size = new System.Drawing.Size(108, 53);
            this.Plus_minus.TabIndex = 16;
            this.Plus_minus.Text = "+/-";
            this.Plus_minus.UseVisualStyleBackColor = true;
            // 
            // Key0
            // 
            this.Key0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Key0.Location = new System.Drawing.Point(123, 227);
            this.Key0.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Key0.Name = "Key0";
            this.Key0.Size = new System.Drawing.Size(108, 53);
            this.Key0.TabIndex = 17;
            this.Key0.Text = "0";
            this.Key0.UseVisualStyleBackColor = true;
            this.Key0.Click += new System.EventHandler(this.Key0_Click);
            // 
            // Point
            // 
            this.Point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Point.Location = new System.Drawing.Point(241, 227);
            this.Point.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Point.Name = "Point";
            this.Point.Size = new System.Drawing.Size(108, 53);
            this.Point.TabIndex = 18;
            this.Point.Text = ".";
            this.Point.UseVisualStyleBackColor = true;
            this.Point.Click += new System.EventHandler(this.Point_Click);
            // 
            // Equal_sign
            // 
            this.Equal_sign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equal_sign.Location = new System.Drawing.Point(359, 227);
            this.Equal_sign.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Equal_sign.Name = "Equal_sign";
            this.Equal_sign.Size = new System.Drawing.Size(110, 53);
            this.Equal_sign.TabIndex = 19;
            this.Equal_sign.Text = "=";
            this.Equal_sign.UseVisualStyleBackColor = true;
            this.Equal_sign.Click += new System.EventHandler(this.Equal_sign_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Equal_sign;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(475, 339);
            this.Controls.Add(this.ButtomsPanel);
            this.Controls.Add(this.CalculationResultText);
            this.Controls.Add(this.UserInputText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MinimumSize = new System.Drawing.Size(32, 48);
            this.Name = "Form1";
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtomsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserInputText;
        private System.Windows.Forms.Label CalculationResultText;
        private System.Windows.Forms.TableLayoutPanel ButtomsPanel;
        private System.Windows.Forms.Button CEButton;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Key7;
        private System.Windows.Forms.Button Key8;
        private System.Windows.Forms.Button Key9;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Key4;
        private System.Windows.Forms.Button Key5;
        private System.Windows.Forms.Button Key6;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Key1;
        private System.Windows.Forms.Button Key2;
        private System.Windows.Forms.Button Key3;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Plus_minus;
        private System.Windows.Forms.Button Key0;
        private System.Windows.Forms.Button Point;
        private System.Windows.Forms.Button Equal_sign;
    }
}

