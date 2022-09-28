using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    [Serializable]
   public class Discipline
    {
        public string Name { get; set; }
        public int Semestr { get; set; }
        public int Course { get; set; }
        public string Specialization { get; set; }
        public string NumberOfLectures { get; set; }
        public string NumberOfLabs { get; set; }
        public string TypeOfControl { get; set; }
        public string Result { get; set; }
        public Lector Lector { get; set; }
    }
}
