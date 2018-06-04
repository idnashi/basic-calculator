namespace Basic_Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.button_7 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_decimal = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.history = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_7
            // 
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(16, 71);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(45, 45);
            this.button_7.TabIndex = 0;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button_8
            // 
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(67, 71);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(45, 45);
            this.button_8.TabIndex = 1;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button_9
            // 
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(118, 71);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(45, 45);
            this.button_9.TabIndex = 2;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.Button_Click);
            // 
            // button_divide
            // 
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.Location = new System.Drawing.Point(169, 71);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(45, 45);
            this.button_divide.TabIndex = 3;
            this.button_divide.Text = "/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cancel.Location = new System.Drawing.Point(220, 71);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(54, 45);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "CE";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // button_clear
            // 
            this.button_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(220, 122);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(54, 45);
            this.button_clear.TabIndex = 9;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multiply.Location = new System.Drawing.Point(169, 122);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(45, 45);
            this.button_multiply.TabIndex = 8;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button_6
            // 
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(118, 122);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(45, 45);
            this.button_6.TabIndex = 7;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button_5
            // 
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(67, 122);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(45, 45);
            this.button_5.TabIndex = 6;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button_4
            // 
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(16, 122);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(45, 45);
            this.button_4.TabIndex = 5;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button_minus
            // 
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_minus.Location = new System.Drawing.Point(169, 173);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(45, 45);
            this.button_minus.TabIndex = 13;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button_3
            // 
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(118, 173);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(45, 45);
            this.button_3.TabIndex = 12;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button_2
            // 
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(67, 173);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(45, 45);
            this.button_2.TabIndex = 11;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button_1
            // 
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(16, 173);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(45, 45);
            this.button_1.TabIndex = 10;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.Button_Click);
            // 
            // button_equal
            // 
            this.button_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equal.Location = new System.Drawing.Point(220, 173);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(54, 96);
            this.button_equal.TabIndex = 19;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.Equate_Click);
            // 
            // button_plus
            // 
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus.Location = new System.Drawing.Point(169, 224);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(45, 45);
            this.button_plus.TabIndex = 18;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.Operator_Click);
            // 
            // button_decimal
            // 
            this.button_decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_decimal.Location = new System.Drawing.Point(118, 224);
            this.button_decimal.Name = "button_decimal";
            this.button_decimal.Size = new System.Drawing.Size(45, 45);
            this.button_decimal.TabIndex = 17;
            this.button_decimal.Text = ".";
            this.button_decimal.UseVisualStyleBackColor = true;
            this.button_decimal.Click += new System.EventHandler(this.Button_Click);
            // 
            // button_0
            // 
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(16, 224);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(96, 45);
            this.button_0.TabIndex = 15;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.Button_Click);
            // 
            // textBox_result
            // 
            this.textBox_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_result.Location = new System.Drawing.Point(16, 36);
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(258, 29);
            this.textBox_result.TabIndex = 20;
            this.textBox_result.Text = "0";
            this.textBox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // history
            // 
            this.history.AutoSize = true;
            this.history.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.history.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.history.Location = new System.Drawing.Point(12, 9);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(0, 24);
            this.history.TabIndex = 21;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(289, 289);
            this.Controls.Add(this.history);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_decimal);
            this.Controls.Add(this.button_0);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_3);
            this.Controls.Add(this.button_2);
            this.Controls.Add(this.button_1);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_multiply);
            this.Controls.Add(this.button_6);
            this.Controls.Add(this.button_5);
            this.Controls.Add(this.button_4);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_divide);
            this.Controls.Add(this.button_9);
            this.Controls.Add(this.button_8);
            this.Controls.Add(this.button_7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calcutor";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_decimal;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label history;
    }
}

