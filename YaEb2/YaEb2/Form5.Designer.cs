
namespace YaEb2
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.lnkSearchUrl = new System.Windows.Forms.LinkLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lnkCommon = new System.Windows.Forms.LinkLabel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.ToolStripMenuItem = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lnkSearchUrl
            // 
            this.lnkSearchUrl.AutoSize = true;
            this.lnkSearchUrl.Location = new System.Drawing.Point(13, 36);
            this.lnkSearchUrl.Name = "lnkSearchUrl";
            this.lnkSearchUrl.Size = new System.Drawing.Size(254, 13);
            this.lnkSearchUrl.TabIndex = 1;
            this.lnkSearchUrl.TabStop = true;
            this.lnkSearchUrl.Text = "Листинг 6.41. Управление ссылками в LinkLabel";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Листинг 6.44. Создание мигающего значка ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lnkCommon
            // 
            this.lnkCommon.AutoSize = true;
            this.lnkCommon.Location = new System.Drawing.Point(13, 9);
            this.lnkCommon.Name = "lnkCommon";
            this.lnkCommon.Size = new System.Drawing.Size(62, 13);
            this.lnkCommon.TabIndex = 3;
            this.lnkCommon.TabStop = true;
            this.lnkCommon.Text = "lnkCommon";
            this.lnkCommon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCommon_LinkClicked);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Location = new System.Drawing.Point(16, 108);
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(251, 40);
            this.ToolStripMenuItem.TabIndex = 4;
            this.ToolStripMenuItem.Text = "Листинг 6.46. Сворачивание вместо закрытия ";
            this.ToolStripMenuItem.UseVisualStyleBackColor = true;
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Листинг 6.47. Снятие выделения с элемента ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(274, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(156, 132);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 200);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Листинг 6.48. Программное выделение элемента в ListView";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ToolStripMenuItem);
            this.Controls.Add(this.lnkCommon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lnkSearchUrl);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkSearchUrl;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel lnkCommon;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button ToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button3;
    }
}