using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;

namespace ЛР2
{
    public partial class Form1 : Form
    {
        public UchebnyOtdel uchebnyotdel;
        public Form1()
        {
            InitializeComponent();
            uchebnyotdel = new UchebnyOtdel();
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (name.Text.Length == 0)
            {
                MessageBox.Show("Название дисциплины должно быть указано");
                return;
            }
            if (semestr.Value == 0)
            {
                MessageBox.Show("Семестр должен быть указан");
                return;
            }
            if (specialization.Text.Length == 0)
            {
                MessageBox.Show("Специальность должна быть указана");
                return;
            }
            if (lectures.Text.Length == 0)
            {
                MessageBox.Show("Количество лекций должно быть указано");
                return;
            }
            if (labs.Text.Length == 0)
            {
                MessageBox.Show("Количество лабораторных должно быть указано");
                return;
            }
            if (typeofcontrol.Text.Length == 0)
            {
                MessageBox.Show("Вид контроля должен быть указан");
                return;
            }
            if (fullname.Text.Length == 0)
            {
                MessageBox.Show("ФИО лектора должно быть указано");
                return;
            }
            if (department.Text.Length == 0)
            {
                MessageBox.Show("Кафедра должна быть указана");
                return;
            }
            if (audience.Text.Length == 0)
            {
                MessageBox.Show("Аудитория должна быть указана");
                return;
            }

            Discipline currentDiscipline = new Discipline
            {
                Name = name.Text,
                Semestr = Decimal.ToInt32(semestr.Value),
                Course = course.Value,
                Specialization = specialization.Text,
                NumberOfLectures = lectures.Text,
                NumberOfLabs = labs.Text,
                TypeOfControl = typeofcontrol.Text,
                Lector = new Lector
                {
                    FullName = fullname.Text,
                    Department = department.Text,
                    Audience = audience.Text
                }
            };
            uchebnyotdel.Disciplines.Add(currentDiscipline);
            currentDiscipline.Result = "Название дисциплины: " + currentDiscipline.Name + " Курс: " + currentDiscipline.Course + " Семестр:  " + currentDiscipline.Semestr + " Специальность: " + currentDiscipline.Specialization + " Кол-во лекций: " + currentDiscipline.NumberOfLectures + " Кол-во лабораторных: " + currentDiscipline.NumberOfLabs + " Вид контроля: " + currentDiscipline.TypeOfControl + " ФИО лектора: " + currentDiscipline.Lector.FullName + " Аудитория: " + currentDiscipline.Lector.Audience + " Кафедра: " + currentDiscipline.Lector.Department;
            disciplines.Items.Add(currentDiscipline.Result);
        }

        private void save_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UchebnyOtdel));
            using (FileStream stream = new FileStream("LR2.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, uchebnyotdel);
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UchebnyOtdel));
            using (FileStream stream = new FileStream("LR2.xml", FileMode.Open))
            {
                uchebnyotdel = serializer.Deserialize(stream) as UchebnyOtdel;
            }
            foreach (Discipline discipline in uchebnyotdel.Disciplines)
                disciplines.Items.Add(discipline.Result);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            name.Text = " ";
            semestr.Value = 0;
            course.Value = 1;
            specialization.Text = " ";
            lectures.Text = " ";
            labs.Text = " ";
            typeofcontrol.Text = " ";
            disciplines.Items.Clear();
            fullname.Text = " ";
            department.Text = " ";
            audience.Text = " ";
        }

        private void course_Scroll(object sender, EventArgs e)
        {
            coursetxt.Text = String.Format("Курс: {0}", course.Value);
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 )
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 )
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-я А-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-я А-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            string Symbol = e.KeyChar.ToString();
            if (!Regex.Match(Symbol, @"[а-я А-Я]|[a-zA-Z]").Success && number != 8)
            {
                e.Handled = true;
            }
        }
        private void textBox5_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
