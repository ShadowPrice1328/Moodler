﻿namespace Moodler
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "MOODLER";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(77, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(311, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 109);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(98, 109);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(186, 109);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(273, 109);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(31, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.Text = "4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(357, 109);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(31, 17);
            this.radioButton5.TabIndex = 7;
            this.radioButton5.Text = "5";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // Send
            // 
            this.Send.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Send.Location = new System.Drawing.Point(301, 134);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(87, 30);
            this.Send.TabIndex = 9;
            this.Send.Text = "Send";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // hourChoice
            // 
            this.hourChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hourChoice.Location = new System.Drawing.Point(89, 140);
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
            this.hourChoice.Size = new System.Drawing.Size(39, 24);
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
            this.AM.Location = new System.Drawing.Point(134, 134);
            this.AM.Name = "AM";
            this.AM.Size = new System.Drawing.Size(41, 17);
            this.AM.TabIndex = 11;
            this.AM.TabStop = true;
            this.AM.Text = "AM";
            this.AM.UseVisualStyleBackColor = true;
            // 
            // PM
            // 
            this.PM.AutoSize = true;
            this.PM.Location = new System.Drawing.Point(134, 151);
            this.PM.Name = "PM";
            this.PM.Size = new System.Drawing.Size(41, 17);
            this.PM.TabIndex = 12;
            this.PM.Text = "PM";
            this.PM.UseVisualStyleBackColor = true;
            // 
            // Remind
            // 
            this.Remind.AutoSize = true;
            this.Remind.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Remind.Location = new System.Drawing.Point(12, 140);
            this.Remind.Name = "Remind";
            this.Remind.Size = new System.Drawing.Size(69, 21);
            this.Remind.TabIndex = 13;
            this.Remind.Text = "Remind";
            // 
            // remSet
            // 
            this.remSet.BackColor = System.Drawing.Color.ForestGreen;
            this.remSet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.remSet.Location = new System.Drawing.Point(186, 140);
            this.remSet.Name = "remSet";
            this.remSet.Size = new System.Drawing.Size(23, 23);
            this.remSet.TabIndex = 14;
            this.remSet.UseVisualStyleBackColor = false;
            this.remSet.Click += new System.EventHandler(this.remSet_Click);
            // 
            // remDelete
            // 
            this.remDelete.BackColor = System.Drawing.Color.Red;
            this.remDelete.Location = new System.Drawing.Point(210, 140);
            this.remDelete.Name = "remDelete";
            this.remDelete.Size = new System.Drawing.Size(23, 23);
            this.remDelete.TabIndex = 15;
            this.remDelete.UseVisualStyleBackColor = false;
            this.remDelete.Click += new System.EventHandler(this.remDelete_Click);
            // 
            // _hour
            // 
            this._hour.AutoSize = true;
            this._hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._hour.ForeColor = System.Drawing.Color.ForestGreen;
            this._hour.Location = new System.Drawing.Point(236, 141);
            this._hour.Name = "_hour";
            this._hour.Size = new System.Drawing.Size(48, 18);
            this._hour.TabIndex = 16;
            this._hour.Text = "empty";
            this._hour.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(400, 175);
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

