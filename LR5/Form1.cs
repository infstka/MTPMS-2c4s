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

        public void add_Click(object sender, EventArgs e)
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
            if (spec.Text.Length == 0)
            {
                MessageBox.Show("Специальность должна быть указана");
                return;
            }
            if (lect.Text.Length == 0)
            {
                MessageBox.Show("Количество лекций должно быть указано");
                return;
            }
            if (labs.Text.Length == 0)
            {
                MessageBox.Show("Количество лабораторных должно быть указано");
                return;
            }
            if (control.Text.Length == 0)
            {
                MessageBox.Show("Вид контроля должен быть указан");
                return;
            }
            if (fio.Text.Length == 0)
            {
                MessageBox.Show("ФИО лектора должно быть указано");
                return;
            }
            if (depart.Text.Length == 0)
            {
                MessageBox.Show("Кафедра должна быть указана");
                return;
            }
            if (aud.Text.Length == 0)
            {
                MessageBox.Show("Аудитория должна быть указана");
                return;
            }

            Discipline currentDiscipline = new Discipline
            {
                Name = name.Text,
                Semestr = Decimal.ToInt32(semestr.Value),
                Course = course.Value,
                Specialization = spec.Text,
                NumberOfLectures = lect.Text,
                NumberOfLabs = labs.Text,
                TypeOfControl = control.Text,
                Lector = new Lector
                {
                    FullName = fio.Text,
                    Department = depart.Text,
                    Audience = aud.Text
                }
        };
            uchebnyotdel.Disciplines.Add(currentDiscipline);
            currentDiscipline.Result = "Название дисциплины: " + currentDiscipline.Name + " Курс: " + currentDiscipline.Course + " Семестр:  " + currentDiscipline.Semestr +  " Специальность: " + currentDiscipline.Specialization + " Кол-во лекций: " + currentDiscipline.NumberOfLectures + " Кол-во лабораторных: " + currentDiscipline.NumberOfLabs + " Вид контроля: " + currentDiscipline.TypeOfControl + " ФИО лектора: " + currentDiscipline.Lector.FullName + " Аудитория: " + currentDiscipline.Lector.Audience + " Кафедра: " + currentDiscipline.Lector.Department;
            disciplines.Items.Add(currentDiscipline.Result);
            //Director dir = new Director();
            //var discipline = dir.BuildMinimalDiscipline(name.Text, Decimal.ToInt32(semestr.Value), course.Value, lect.Text, labs.Text);
            //disciplines.Items.Add(discipline);

            //Discipline FD;
            //Director director = new Director();
            //Builder builder = new Builder();
            //director.Builder = builder;

            //director.BuildFullDiscipline(name.Text, Decimal.ToInt32(semestr.Value), course.Value, lect.Text, labs.Text, spec.Text, control.Text, NLector.lector);;
            //FD = builder.GetDiscipline();
        }

        private void save_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UchebnyOtdel));
            using (FileStream stream = new FileStream("LR3.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, uchebnyotdel);
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UchebnyOtdel));
            using (FileStream stream = new FileStream("LR3.xml", FileMode.Open))
            {
                uchebnyotdel = serializer.Deserialize(stream) as UchebnyOtdel;
            }
            foreach (Discipline discipline in uchebnyotdel.Disciplines)
                disciplines.Items.Add(discipline.Result);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            name.Text = "";
            semestr.Value = 0;
            course.Value = 1;
            spec.Text = "";
            lect.Text = "";
            labs.Text = "";
            control.Text = "";
            disciplines.Items.Clear();
            fio.Text = "";
            depart.Text = "";
            aud.Text = "";
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
        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
                Form2 search = new Form2();
                search.ShowDialog(this);
        }

        private void SortByNOL_Click(object sender, EventArgs e)
        {
            disciplines.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(UchebnyOtdel));
            using (FileStream stream = new FileStream("LR3.xml", FileMode.Open))
               uchebnyotdel = ser.Deserialize(stream) as UchebnyOtdel;

            IEnumerable<Discipline> ordered = uchebnyotdel.Disciplines.OrderBy(p => p.NumberOfLectures);
            foreach (Discipline discipline in ordered)
                disciplines.Items.Add(discipline.Result);
        }

        private void SortByTOC_Click(object sender, EventArgs e)
        {
            disciplines.Items.Clear();
            XmlSerializer ser = new XmlSerializer(typeof(UchebnyOtdel));
            using (FileStream stream = new FileStream("LR3.xml", FileMode.Open))
                uchebnyotdel = ser.Deserialize(stream) as UchebnyOtdel;

            IEnumerable<Discipline> ordered = uchebnyotdel.Disciplines.OrderBy(p => p.TypeOfControl);
            foreach (Discipline discipline in ordered)
                disciplines.Items.Add(discipline.Result);
        }

        private void about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Лабораторная работа №3 - Регулярные выражения, атрибуты валидации, меню, панели инструментов, строки состояния");
        }

        private void date_Click(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToString();
        }
        private void next_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UchebnyOtdel));
            using (FileStream stream = new FileStream("LR3.xml", FileMode.Open))
            {
                uchebnyotdel = serializer.Deserialize(stream) as UchebnyOtdel;
            }
            foreach (Discipline discipline in uchebnyotdel.Disciplines)
                disciplines.Items.Add(discipline.Result);
        }

        private void back_Click(object sender, EventArgs e)
        {
            disciplines.Items.RemoveAt(disciplines.Items.Count - 1);
        }
        private void progress_Click_1(object sender, EventArgs e)
        {
            progress.Text = disciplines.Items.Count.ToString();
        }
        private void formabout_Click(object sender, EventArgs e)
        {
            SettingSingleton form1 = SettingSingleton.getInstance(BackColor, Font, Size);
            MessageBox.Show(form1.ToString(), "Информация об форме");
        }

        private void clone_Click(object sender, EventArgs e)
        {
            Discipline currentDiscipline = new Discipline(name.Text, Decimal.ToInt32(semestr.Value), course.Value, spec.Text, lect.Text, labs.Text, control.Text, disciplines.Text, new Lector());
            currentDiscipline.Clone();
            uchebnyotdel.Disciplines.Add(currentDiscipline);
            currentDiscipline.Result = "Название дисциплины: " + currentDiscipline.Name + " Курс: " + currentDiscipline.Course + " Семестр:  " + currentDiscipline.Semestr + " Специальность: " + currentDiscipline.Specialization + " Кол-во лекций: " + currentDiscipline.NumberOfLectures + " Кол-во лабораторных: " + currentDiscipline.NumberOfLabs + " Вид контроля: " + currentDiscipline.TypeOfControl + " ФИО лектора: " + currentDiscipline.Lector.FullName + " Аудитория: " + currentDiscipline.Lector.Audience + " Кафедра: " + currentDiscipline.Lector.Department;
            disciplines.Items.Add(currentDiscipline.Result);
        }

        private void director_Click(object sender, EventArgs e)
        {
        }
    }
}
