using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace YaEb2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            // Вставьте код в конструктор формы после вызова
            // метода InitializeComponent
            // Создаем экземпляр ListViewColumnSorter и связываем его с ListView
            lvwColumnSorter = new ListViewColumnSorter();
            this.listView1.ListViewItemSorter = lvwColumnSorter;
        }

        private ListViewColumnSorter lvwColumnSorter;

        private void Form5_Load(object sender, EventArgs e)
        {
            lnkSearchUrl.Text = "Yandex Google Rambler GoGo";
            lnkSearchUrl.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkSearchUrl.Links.Add(0, 6, "www.yandex.ru");
            lnkSearchUrl.Links.Add(7, 6, "www.google.ru");
            lnkSearchUrl.Links.Add(14, 7, "www.rambler.ru");
            lnkSearchUrl.Links.Add(22, 4, "www.gogo.ru");
            lnkSearchUrl.LinkClicked +=
            new LinkLabelLinkClickedEventHandler(lnkCommon_LinkClicked);
           
        }

        private void Form1_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (notifyIcon1.Visible)
                notifyIcon1.Visible = false;
            else
                notifyIcon1.Visible = true;
        }
        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            notifyIcon1.Visible = true;
            MessageBox.Show("Мигание приостановлено");
        }

        private void lnkCommon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            LinkLabel lnk = new LinkLabel();
            lnk = (LinkLabel)sender;
            lnk.Links[lnk.Links.IndexOf(e.Link)].Visited = true;
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private Icon[] aIcons = new Icon[8];
        // текущий значок
        int curIcon = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            notifyIcon1.Icon = aIcons[curIcon];
            curIcon++;
            if (curIcon > 7) curIcon = 0;
        }

        private bool m_CloseOK = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Пользователь выходит из программы не через контекстное меню
            if (m_CloseOK == false)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // выходим из программы по-настоящему
            m_CloseOK = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Убираем выделение с нужного элемента
            this.listView1.SelectedItems.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Установим фокус
            listView1.Focus();
            // Выбираем второй элемент
            listView1.Items[1].Selected = true;
        }
    }
}
