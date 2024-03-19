namespace WindowsFormsApp1
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
            this.PressMe = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.SuspendLayout();
            // 
            // PressMe
            // 
            this.PressMe.Location = new System.Drawing.Point(12, 518);
            this.PressMe.Name = "PressMe";
            this.PressMe.Size = new System.Drawing.Size(75, 23);
            this.PressMe.TabIndex = 0;
            this.PressMe.Text = "PressMe";
            this.PressMe.UseVisualStyleBackColor = true;
            this.PressMe.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBox
            // 
            this.TextBox.AutoSize = true;
            this.TextBox.Location = new System.Drawing.Point(259, 253);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(0, 13);
            this.TextBox.TabIndex = 2;
            this.TextBox.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(93, 518);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(615, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 555);
            this.vScrollBar1.TabIndex = 4;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 553);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.PressMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PressMe;
        private System.Windows.Forms.Label TextBox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.VScrollBar vScrollBar1;
    }
}

