using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    public interface ITarget
    {
        string StartWork();
    }
    public class Adapter : ITarget 
    {
        private readonly Discipline discipline;
        public Adapter(Discipline discipline)
        {
            discipline = discipline;
        }
        public string StartWork()
        {
            return $"{discipline.Name} {discipline.Course}";
        }
    }
}
