namespace Calculator
{
    partial class Calculator
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.symb = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.Results = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HistoryLabel = new System.Windows.Forms.Label();
            this.History = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            this.SuspendLayout();
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divide.ForeColor = System.Drawing.SystemColors.Highlight;
            this.divide.Location = new System.Drawing.Point(288, 62);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(29, 28);
            this.divide.TabIndex = 2;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiply.ForeColor = System.Drawing.SystemColors.Highlight;
            this.multiply.Location = new System.Drawing.Point(322, 62);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(29, 28);
            this.multiply.TabIndex = 3;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.minus.Location = new System.Drawing.Point(356, 62);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(29, 28);
            this.minus.TabIndex = 4;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus.ForeColor = System.Drawing.SystemColors.Highlight;
            this.plus.Location = new System.Drawing.Point(391, 62);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(29, 28);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Location = new System.Drawing.Point(288, 106);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(132, 34);
            this.clear.TabIndex = 6;
            this.clear.Text = "очистить";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // symb
            // 
            this.symb.AutoSize = true;
            this.symb.Location = new System.Drawing.Point(121, 17);
            this.symb.Name = "symb";
            this.symb.Size = new System.Drawing.Size(0, 13);
            this.symb.TabIndex = 8;
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(15, 12);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(98, 20);
            this.num1.TabIndex = 9;
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(145, 13);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(100, 20);
            this.num2.TabIndex = 10;
            // 
            // Results
            // 
            this.Results.Location = new System.Drawing.Point(289, 14);
            this.Results.Name = "Results";
            this.Results.ReadOnly = true;
            this.Results.Size = new System.Drawing.Size(131, 20);
            this.Results.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "=";
            // 
            // HistoryLabel
            // 
            this.HistoryLabel.AutoSize = true;
            this.HistoryLabel.Location = new System.Drawing.Point(13, 42);
            this.HistoryLabel.Name = "HistoryLabel";
            this.HistoryLabel.Size = new System.Drawing.Size(50, 13);
            this.HistoryLabel.TabIndex = 16;
            this.HistoryLabel.Text = "История";
            // 
            // History
            // 
            this.History.HideSelection = false;
            this.History.Location = new System.Drawing.Point(15, 61);
            this.History.Multiline = true;
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(229, 79);
            this.History.TabIndex = 17;
            this.History.TextChanged += new System.EventHandler(this.History_TextChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(435, 169);
            this.Controls.Add(this.History);
            this.Controls.Add(this.HistoryLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Results);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.symb);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.divide);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label symb;
        private System.Windows.Forms.NumericUpDown num1;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.TextBox Results;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HistoryLabel;
        private System.Windows.Forms.TextBox History;
    }
}

