using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YaEb2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // не работает
            this.button1.Focus();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            // работает
            this.button1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Controls.Add(new TabPage("Новая вкладка"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Удалить выбранную вкладку
            tabControl1.Controls.Remove(tabControl1.SelectedTab);
        }

        /// <summary>
        /// Вставляет вкладку в заданную позицию
        /// </summary>
        /// <param name="tabNumber">Номер вкладки</param>
        /// <param name="tabControl">Элемент TabControl</param>
        private void InsertTab(int tabNumber, ref TabControl tabControl)
        {
            int counter = tabControl.Controls.Count;
            if (tabNumber < 0 || tabNumber > counter)
            {
                tabControl.Controls.Add(new TabPage("Вкладка"));
                return;
            }
            int target = tabControl.SelectedIndex;
            // сохраняем существующие ярлычки и очищаем элементы
            Control[] c = new Control[counter];
            tabControl.Controls.CopyTo(c, 0);
            tabControl.Controls.Clear();
            // Добавляем ярлычки до вставляемого элемента
            for (int i = 0; i < target; ++i)
                tabControl.Controls.Add(c[i]);
            // Вставляем свой ярлычок
            tabControl.Controls.Add(new TabPage("Вставленная вкладка"));
            // Добавляем ярлычки после вставляемого элемента
            for (int i = target; i < counter; ++i)
                tabControl.Controls.Add(c[i]);
            // Выбираем вставленную вкладку
            tabControl.SelectedIndex = target;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Добавляем ярлычок во вторую позицию
            InsertTab(2, ref tabControl1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = (int)(performanceCounter1.NextValue());
            label1.Text = "Загрузка процессора: " +
            progressBar1.Value.ToString() + "%";
        }
    }
}
