using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.IO;

namespace ЛР2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void form2search_Click(object sender, EventArgs e)
        {
            Regex r1 = new Regex(fullnamesearch.Text);
            UchebnyOtdel uchebnyotdel = null;

            XmlSerializer ser = new XmlSerializer(typeof(UchebnyOtdel));
            using (FileStream stream = new FileStream("LR3.xml", FileMode.Open))
            {
                uchebnyotdel = ser.Deserialize(stream) as UchebnyOtdel;
            }
            discipline.Items.Clear();
            List<Discipline> searchResult = new List<Discipline>();
            foreach (Discipline discipline in uchebnyotdel.Disciplines)
            {
                if (r1.IsMatch(discipline.Result))
                {
                    if (coursesearch.Value != discipline.Course)
                        continue;
                    if (semestrsearch.Value != discipline.Semestr )
                        continue;
                    searchResult.Add(discipline);
                }
            }

            IEnumerable<Discipline> ordered = null;
            if (form2sort.Text == "По кол-ву лекций")
                ordered = searchResult.OrderBy(p => p.NumberOfLectures);
            else
                ordered = searchResult.OrderBy(p => p.TypeOfControl);
            foreach (Discipline item in ordered)
                discipline.Items.Add(item.Result);
        }
    }
}
