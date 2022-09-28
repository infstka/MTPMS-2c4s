using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
   internal static class NLector
    {
        static Lector Lector = null;
        public static Discipline Factorys(AbstractFactory factory)
        {
            return factory.CreateDiscipline();
        }
        public static Lector lector
        {
            get => Lector;
        }
    }
}
