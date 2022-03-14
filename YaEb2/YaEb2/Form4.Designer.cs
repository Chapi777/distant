
namespace YaEb2
{
    partial class Form4
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
            this.butFormatRTF = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.butScrollExist = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butFormatRTF
            // 
            this.butFormatRTF.Location = new System.Drawing.Point(12, 12);
            this.butFormatRTF.Name = "butFormatRTF";
            this.butFormatRTF.Size = new System.Drawing.Size(238, 35);
            this.butFormatRTF.TabIndex = 0;
            this.butFormatRTF.Text = "Листинг 6.31. Управление цветом и шрифтом в RichTextBox";
            this.butFormatRTF.UseVisualStyleBackColor = true;
            this.butFormatRTF.Click += new System.EventHandler(this.butFormatRTF_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(256, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(188, 35);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.richTextBox1_LinkClicked);
            // 
            // butScrollExist
            // 
            this.butScrollExist.Location = new System.Drawing.Point(12, 53);
            this.butScrollExist.Name = "butScrollExist";
            this.butScrollExist.Size = new System.Drawing.Size(238, 35);
            this.butScrollExist.TabIndex = 3;
            this.butScrollExist.Text = "Листинг 6.34. Проверка на наличие полосы прокрутки в RichTextBox";
            this.butScrollExist.UseVisualStyleBackColor = true;
            this.butScrollExist.Click += new System.EventHandler(this.butScrollExist_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 35);
            this.textBox1.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(256, 100);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Листинг 6.36. Вывод пустого текста в DateTimePicker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 37);
            this.button2.TabIndex = 7;
            this.button2.Text = "Листинг 6.37. Программное раскрытие списка DateTimePicker";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butScrollExist);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.butFormatRTF);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butFormatRTF;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button butScrollExist;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}