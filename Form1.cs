using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public int flag;

        float a, b;
        int count;
        bool znak = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (count == 2)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (count == 3)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (count == 4)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            a = Convert.ToInt32(textBox1.Text);
            label1.Text = $"X^2 {a}";
            textBox1.Clear();
            count = 5;
            znak = true;
            label2.Text = "x^2";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            string a = textBox3.Text.ToLower().ToString();
            textBox4.Text = a;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            string a = textBox3.Text.ToUpper().ToString();
            textBox4.Text = a;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string a = textBox3.Text.Length.ToString();
            label5.Text = $"Длина строки:{a}";
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.Text = textBox3.Text.Replace("чю", "чу");

            textBox4.Text = textBox3.Text.Replace("щю", "щу");

            textBox4.Text = textBox3.Text.Replace("чя", "ча");
            
            textBox4.Text = textBox3.Text.Replace("щя", "ща");
            
            textBox4.Text = textBox3.Text.Replace("жы", "жи");
            
            textBox4.Text = textBox3.Text.Replace("шы", "ши");
            
            textBox4.Text = textBox3.Text.Replace("чьн", "чн");
            
            textBox4.Text = textBox3.Text.Replace("чьк", "чк");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


                                        //Конвертер


        private void button19_Click(object sender, EventArgs e)
        {

            double i = int.Parse(Text_Box7.Text);

            // перевод из сантиметра 

            if (Combo_Box1.SelectedItem == "Сантиметр" && Combo_Box2.SelectedItem == "Дюйм")// Сантиметр - Дюйм
            {
                double conver = i * 0.3937;
                Label10.Text = "Конвертированная сумма: " + conver;
            }
            if (Combo_Box1.SelectedItem == "Сантиметр" && Combo_Box2.SelectedItem == "Фут")// Сантиметр - Фут
            {
                double conver = i * 0.0328;
                Label10.Text = "Конвертированная сумма: " + conver;
                
            }
            if (Combo_Box1.SelectedItem == "Сантиметр" && Combo_Box2.SelectedItem == "Пье")//Сантиметр - Пье
            {
                double conver = i * 0.030788;
                Label10.Text = "Конвертированная сумма: " + conver;

            }
            if (Combo_Box1.SelectedItem == "Сантиметр" && Combo_Box2.SelectedItem == "Пьеда")//Сантиметр - Пьеда
            {
                double conver = i * 0.033602;
                Label10.Text = "Конвертированная сумма: " + conver;
               
                
                // Перевод из Дюйма


            }
            double c = int.Parse(Text_Box7.Text);
            if (Combo_Box1.SelectedItem == "Дюйм" && Combo_Box2.SelectedItem == "Сантиметр") //Дюйм-Сантиметр
            {
                double conver = i * 2.54;
                Label10.Text = "Конвертированная сумма: " + conver;
            }
            if (Combo_Box1.SelectedItem == "Дюйм" && Combo_Box2.SelectedItem == "Фут") //Дюйм- Фут
            {
                double conver = i * 0.0833;
                Label10.Text = "Конвертированная сумма: " + conver;

            }
            if (Combo_Box1.SelectedItem == "Дюйм" && Combo_Box2.SelectedItem == "Пье") // Дюйм - Пье
            {
                double conver = i * 0.09117;
                Label10.Text = "Конвертированная сумма: " + conver;

            }
            if (Combo_Box1.SelectedItem == "Дюйм" && Combo_Box2.SelectedItem == "Пьеда") //Дюйм - Пьеда
            {
                double conver = i * 0.2354;
                Label10.Text = "Конвертированная сумма: " + conver;

            }


            // перевод из Фута


            double r = int.Parse(Text_Box7.Text);
            if (Combo_Box1.SelectedItem == "Фут" && Combo_Box2.SelectedItem == "Сантиметр") //фут -Сантиметр
            {
                double conver = i * 30.48;
                Label10.Text = "Конвертированная сумма: " + conver;
            }
            if (Combo_Box1.SelectedItem == "Фут" && Combo_Box2.SelectedItem == "Дюйм") // Фут - Дюйм
            {
                double conver = i * 12;
                Label10.Text = "Конвертированная сумма: " + conver;

            }
            if (Combo_Box1.SelectedItem == "Дюйм" && Combo_Box2.SelectedItem == "Пье") // Фут - Пье
            {
                double conver = i * 0.938424;
                Label10.Text = "Конвертированная сумма: " + conver;

            }
            if (Combo_Box1.SelectedItem == "Дюйм" && Combo_Box2.SelectedItem == "Пьеда") // Фут -Пьеда
            {
                double conver = i * 0.2564;
                Label10.Text = "Конвертированная сумма: " + conver;

            }

            //перевод из Пье


            double l = int.Parse(Text_Box7.Text);
            if (Combo_Box1.SelectedItem == "Пье" && Combo_Box2.SelectedItem == "Сантиметр") //Пье -Сантиметр
            {
                double conver = i * 32.48;
                Label10.Text = "Конвертированная сумма: " + conver;
            }
            if (Combo_Box1.SelectedItem == "Пье" && Combo_Box2.SelectedItem == "Дюйм") // Пье - Дюйм
            {
                double conver = i * 10.968504;
                Label10.Text = "Конвертированная сумма: " + conver;

            }
            if (Combo_Box1.SelectedItem == "Пье" && Combo_Box2.SelectedItem == "Фут") // Пье - фут
            {
                double conver = i * 1.0940;
                Label10.Text = "Конвертированная сумма: " + conver;

            }
            if (Combo_Box1.SelectedItem == "Пье" && Combo_Box2.SelectedItem == "Пьеда") // Пье - Пьеда
            {
                double conver = i * 0.76602;
                Label10.Text = "Конвертированная сумма: " + conver;

            }

            //перевод из Пьеды

            double n = int.Parse(Text_Box7.Text);
            if (Combo_Box1.SelectedItem == "Пьеда" && Combo_Box2.SelectedItem == "Сантиметр") //Пьеда -Сантиметр
            {
                double conver = i * 29.76;
                Label10.Text = "Конвертированная сумма: " + conver;
            }
            if (Combo_Box1.SelectedItem == "Пьеда" && Combo_Box2.SelectedItem == "Дюйм") // Пьеда - Дюйм
            {
                double conver = i * 1.546574;
                Label10.Text = "Конвертированная сумма: " + conver;

            }
            if (Combo_Box1.SelectedItem == "Пьеда" && Combo_Box2.SelectedItem == "Пье") // Пьеда - Пье
            {
                double conver = i * 1.09;
                Label10.Text = "Конвертированная сумма: " + conver;

            }
            if (Combo_Box1.SelectedItem == "Пьеда" && Combo_Box2.SelectedItem == "Дюйм") // Пьеда - Фут
            {
                double conver = i * 1.03 ;
                Label10.Text = "Конвертированная сумма: " + conver;

            }
            {

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }
    }
}
