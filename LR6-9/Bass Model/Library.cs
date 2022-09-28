using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6_9.Bass_Model
{
    [Serializable]
    public class Library
    {
        public List<Bass_Model.Bass> Basses { get; set; }
        public Library()
        {
            Basses = new List<Bass_Model.Bass>();
        }
    }
}
