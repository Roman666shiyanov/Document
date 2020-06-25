using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Genesis : Form
    {
        public Genesis()
        {
            InitializeComponent();
        }
        public Genesis(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.Yellow;
        }
            private void button1_Click(object sender, EventArgs e)
        {
            Form1 newForm1 = new Form1();
            newForm1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор проекта студент группы 19ИТ17, это единственная информация которую удалось получить.","Полученная информация");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение для обработки массивов. Массив — структура данных, хранящая набор значений (элементов массива), идентифицируемых по индексу или набору индексов, принимающих целые (или приводимые к целым) значения из некоторого заданного непрерывного диапазона. Данная программа предназначена для обработки одномерных массивов, заданных случайным образом. ", "Справка");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox1.Show();
            else textBox1.Hide();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                textBox2.Show();
            else textBox2.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
