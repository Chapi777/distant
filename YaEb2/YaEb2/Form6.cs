using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace YaEb2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Вставьте следующий код в обработчик события Load формы
            // Используется для создания заголовков
            ColumnHeader columnheader;
            // Используется для создания элементов в ListView
            ListViewItem listviewitem;
            // Устанавливаем нужный вид
            listView1.View = View.Details;
            // Создаем несколько элементов, содержащих имена и фамилии
            listviewitem = new ListViewItem("Александр");
            listviewitem.SubItems.Add("Суворов");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Наполеон");
            listviewitem.SubItems.Add("Бонапарт");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Михаил");
            listviewitem.SubItems.Add("Кутузов");
            this.listView1.Items.Add(listviewitem);
            listviewitem = new ListViewItem("Юлий");
            listviewitem.SubItems.Add("Цезарь");
            this.listView1.Items.Add(listviewitem);
            // Создаем колонки
            columnheader = new ColumnHeader();
            columnheader.Text = "Имя";
            this.listView1.Columns.Add(columnheader);
            columnheader = new ColumnHeader();
            columnheader.Text = "Фамилия";
            this.listView1.Columns.Add(columnheader);
            // Проходим через все элементы и устанавливаем размер каждого
            // заголовка колонки равным тексту
            foreach (ColumnHeader ch in this.listView1.Columns) { ch.Width = -2; }
            // Create a root node.
            TreeNode rootNode = treeView1.Nodes.Add("Коты");
            TreeNode childNode = rootNode.Nodes.Add("Барсик");
            childNode.Tag = "Барсик - большой и умный кот";
            childNode = rootNode.Nodes.Add("Рыжик");
            childNode.Tag = "Рыжик - очень любопытный кот";
            childNode = rootNode.Nodes.Add("Мурзик");
            childNode.Tag = "Мурзик - ленивый кот";
            childNode = rootNode.Nodes.Add("Пушок");
            childNode.Tag = "Пушок - белый и пушистый кот";
            // Раскрываем все узлы дерева
            rootNode.ExpandAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.Items.Add("Алла");
            listView1.Items.Add("София");
            listView1.Items[0].UseItemStyleForSubItems = false;
            listView1.Items[0].SubItems.Add("Пугачева", Color.Pink,
            Color.Yellow, Font);
            listView1.Items[1].UseItemStyleForSubItems = false;
            listView1.Items[1].SubItems.Add("Ротару", Color.Teal,
            Color.Violet, Font);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((int)Microsoft.Win32.Registry.GetValue(
            @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "EnableBalloonTips", 1) == 0)
                // Не использовать стиль Balloon
                this.Text = "Not use Balloon style";
            else
                this.toolTip1.IsBalloon = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.button1,
                    "Это кнопка\r\nСамая обычная кнопка");
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Получим узел в текущей позиции мыши
            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);
            // Установим ToolTip, только если мышь задержалась на узле
            if ((theNode != null))
                // Проверяем, что свойство tag не пустое
                if (theNode.Tag != null)
                {
                    // Меняем ToolTip, если мышь переместилась на другой узел
                    if (theNode.Tag.ToString() !=
                    this.toolTip1.GetToolTip(this.treeView1))
                    {
                        this.toolTip1.SetToolTip(this.treeView1,
                        theNode.Tag.ToString());
                    }
                }
                else
                {
                    this.toolTip1.SetToolTip(this.treeView1, "");
                }
                else // Если указатель не над узлом, то очистим подсказку
            {
                this.toolTip1.SetToolTip(this.treeView1, "");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Переключаемся на другую вкладку при помощи SelectedTab
            this.tabControl1.SelectedTab = this.tabPage2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Переключаемся на другую вкладку при помощи SelectedIndex
            this.tabControl1.SelectedIndex = 0;
        }
    }
}
