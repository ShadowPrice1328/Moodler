namespace Moodler
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.Send = new System.Windows.Forms.Button();
            this.hourChoice = new System.Windows.Forms.NumericUpDown();
            this.AM = new System.Windows.Forms.RadioButton();
            this.PM = new System.Windows.Forms.RadioButton();
            this.Remind = new System.Windows.Forms.Label();
            this.remSet = new System.Windows.Forms.Button();
            this.remDelete = new System.Windows.Forms.Button();
            this._hour = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hourChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOODLER";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(90, 67);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(362, 31);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 126);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(114, 126);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(217, 126);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 19);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(318, 126);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 19);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(416, 126);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 19);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Send.Location = new System.Drawing.Point(351, 155);
            this.Send.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(102, 35);
            this.Send.TabIndex = 9;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // hourChoice
            // 
            this.hourChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hourChoice.Location = new System.Drawing.Point(104, 162);
            this.hourChoice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.hourChoice.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.hourChoice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.hourChoice.Name = "hourChoice";
            this.hourChoice.ReadOnly = true;
            this.hourChoice.Size = new System.Drawing.Size(46, 24);
            this.hourChoice.TabIndex = 10;
            this.hourChoice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AM
            // 
            this.AM.AutoSize = true;
            this.AM.Location = new System.Drawing.Point(156, 155);
            this.AM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AM.Name = "AM";
            this.AM.Size = new System.Drawing.Size(44, 19);
            this.AM.TabIndex = 11;
            this.AM.TabStop = true;
            this.AM.Text = "AM";
            this.AM.UseVisualStyleBackColor = true;
            // 
            // PM
            // 
            this.PM.AutoSize = true;
            this.PM.Location = new System.Drawing.Point(156, 174);
            this.PM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PM.Name = "PM";
            this.PM.Size = new System.Drawing.Size(43, 19);
            this.PM.TabIndex = 12;
            this.PM.Text = "PM";
            this.PM.UseVisualStyleBackColor = true;
            // 
            // Remind
            // 
            this.Remind.AutoSize = true;
            this.Remind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Remind.Location = new System.Drawing.Point(14, 162);
            this.Remind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Remind.Name = "Remind";
            this.Remind.Size = new System.Drawing.Size(69, 21);
            this.Remind.TabIndex = 13;
            this.Remind.Text = "Remind";
            // 
            // remSet
            // 
            this.remSet.BackColor = System.Drawing.Color.ForestGreen;
            this.remSet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.remSet.Location = new System.Drawing.Point(217, 162);
            this.remSet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.remSet.Name = "remSet";
            this.remSet.Size = new System.Drawing.Size(27, 27);
            this.remSet.TabIndex = 14;
            this.remSet.UseVisualStyleBackColor = false;
            this.remSet.Click += new System.EventHandler(this.remSet_Click);
            // 
            // remDelete
            // 
            this.remDelete.BackColor = System.Drawing.Color.Red;
            this.remDelete.Location = new System.Drawing.Point(245, 162);
            this.remDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.remDelete.Name = "remDelete";
            this.remDelete.Size = new System.Drawing.Size(27, 27);
            this.remDelete.TabIndex = 15;
            this.remDelete.UseVisualStyleBackColor = false;
            this.remDelete.Click += new System.EventHandler(this.remDelete_Click);
            // 
            // _hour
            // 
            this._hour.AutoSize = true;
            this._hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this._hour.ForeColor = System.Drawing.Color.ForestGreen;
            this._hour.Location = new System.Drawing.Point(275, 163);
            this._hour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this._hour.Name = "_hour";
            this._hour.Size = new System.Drawing.Size(48, 18);
            this._hour.TabIndex = 16;
            this._hour.Text = "empty";
            this._hour.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(467, 202);
            this.Controls.Add(this._hour);
            this.Controls.Add(this.remDelete);
            this.Controls.Add(this.remSet);
            this.Controls.Add(this.Remind);
            this.Controls.Add(this.PM);
            this.Controls.Add(this.AM);
            this.Controls.Add(this.hourChoice);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Moodler";
            ((System.ComponentModel.ISupportInitialize)(this.hourChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.NumericUpDown hourChoice;
        private System.Windows.Forms.RadioButton AM;
        private System.Windows.Forms.RadioButton PM;
        private System.Windows.Forms.Label Remind;
        private System.Windows.Forms.Button remSet;
        private System.Windows.Forms.Button remDelete;
        private System.Windows.Forms.Label _hour;
    }
}

