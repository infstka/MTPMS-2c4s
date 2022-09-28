using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6_9.Bass_Model
{
    [Serializable]
    public class Bass
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Type { get; set; }
        public int Rate { get; set; }
        public string Sale { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        public Bass(string name,string manufacturer,int price,int count,string type,string description)
        {
            
            Name = name;
            Manufacturer = manufacturer;
            Price = price;
            Count = count;
            Type = type;
            Description = description;
        }
        public Bass() { }
    }
}
