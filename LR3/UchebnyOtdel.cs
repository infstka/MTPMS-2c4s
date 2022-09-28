using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    [Serializable]
    public class UchebnyOtdel
    {
        public List<Discipline> Disciplines { get; set; }
        public Lector Lectors { get; set; }
        public UchebnyOtdel()
        {
            Lectors = new Lector();
            Disciplines = new List<Discipline>();
        }
    }
}
