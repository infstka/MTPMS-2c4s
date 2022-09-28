using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a, b;
            a = Convert.ToString(textBox1.Text);
            b = Convert.ToString(textBox2.Text);
            int count = Regex.Matches(a, @"[уеэоаыяиюё]", RegexOptions.IgnoreCase).Count;
            int count2 = Regex.Matches(a, @"[йцкнгшщзхъждлрпвфчсмтб]", RegexOptions.IgnoreCase).Count;
            int count3 = Regex.Matches(a, @"[.]", RegexOptions.IgnoreCase).Count;
            string[] textArray = textBox1.Text.Split(new char[] { ' ', '.', ',' });

            switch (comboBox1.Text)
            {
                case "Замена":
                    textBox3.Text = Convert.ToString(a.Replace(a.ToString(), b));
                    break;
                case "Удаление заданных подстрок":
                    textBox3.Text = Convert.ToString(a.Trim(b.ToCharArray()));
                    break;
                case "Получение символа по индексу":
                    char ch = a[Convert.ToInt32(b)];
                    textBox3.Text = Convert.ToString(ch);
                    break;
                case "Длина строки":
                    textBox3.Text = Convert.ToString(a.Length);
                    break;
                case "Подсчет гласных":
                    textBox3.Text = Convert.ToString(count);
                    break;
                case "Подсчет согласных":
                    textBox3.Text = Convert.ToString(count2);
                    break;
                case "Подсчет предложений":
                    textBox3.Text = Convert.ToString(count3);
                    break;
                case "Подсчет слов":
                    textBox3.Text = textArray.Length.ToString();
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }
    }
} 
