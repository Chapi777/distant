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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            richTextBox1.AllowDrop = true;
            this.richTextBox1.DragEnter +=
            new System.Windows.Forms.DragEventHandler(
            this.richTextBox1_DragEnter);
            this.richTextBox1.DragDrop +=
            new System.Windows.Forms.DragEventHandler(
            this.richTextBox1_DragEnter);
            RichTextBoxEx rboxex = new RichTextBoxEx();
            rboxex.Parent = this;
            rboxex.Top = 400;

        }
        class RichTextBoxEx : RichTextBox
        {
            protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                //Проверяем на нажатие Shift+Insert и Ctrl+V
                if ((keyData & (Keys.Shift | Keys.Insert)) ==
                (Keys.Shift | Keys.Insert)
                || ((keyData & (Keys.Control | Keys.V)) ==
                (Keys.Control | Keys.V)))
                return true;
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void richTextBox1_DragEnter(object sender,
            System.Windows.Forms.DragEventArgs e)
        {
            if (((DragEventArgs)e).Data.GetDataPresent(DataFormats.Text))
                ((DragEventArgs)e).Effect = DragDropEffects.Move;
            else
                ((DragEventArgs)e).Effect = DragDropEffects.None;
        }
        private void richTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            richTextBox1.LoadFile((String)e.Data.GetData("Text"),
            System.Windows.Forms.RichTextBoxStreamType.RichText);
        }

        private void butFormatRTF_Click(object sender, EventArgs e)
        {
            // Устанавливаем фокус на richTextBox
            richTextBox1.Focus();
            // Устанавливаем цвет для выделенного текста
            richTextBox1.SelectionColor = Color.Red;
            // Устанавливаем шрифт
            richTextBox1.SelectionFont = new Font("Courier", 10, FontStyle.Bold);
        }

        private void richTextBox1_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        const int GWL_STYLE = -16;
        const int WS_HSCROLL = 0x00100000;
        const int WS_VSCROLL = 0x00200000;

        // Проверка на наличие вертикальной прокрутки
        bool IsVertScrollPresent(Control control)
        {
            int style = GetWindowLong(control.Handle, GWL_STYLE);
            return (style & WS_VSCROLL) > 0;
        }

        // Проверка на наличие горизонтальной прокрутки
        bool IsHorScrollPresent(Control control)
           {
            int style = GetWindowLong(control.Handle, GWL_STYLE);
               return (style & WS_HSCROLL) > 0; 
            }
        private void butScrollExist_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Вертикальная прокрутка: " +
            IsVertScrollPresent(richTextBox1).ToString() +
            Environment.NewLine + "Горизонтальная прокрутка: " +
            IsHorScrollPresent(richTextBox1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = " ";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Устанавливаем фокус
            dateTimePicker1.Focus();
            // Посылаем команду
            SendKeys.Send("{F4}");
        }
    }
}
