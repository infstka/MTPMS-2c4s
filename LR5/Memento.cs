using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2
{
    public class Memento 
    {
        public List<Discipline> disciplines = new List<Discipline>();
        public string State { get; private set; }
        public Memento(List<Discipline> State)
        {
            if (State != null)
            {
                foreach (Discipline i in State)
                {
                    disciplines.Add(i);
                }
            }
            else if (State == null)
                disciplines.Clear();
        }
    }
    public class Caretaker 
    {
        public Stack<Memento> History { get; private set; }
        public Caretaker()
        {
            History = new Stack<Memento>();
        }
    }

    public class Originator 
    {
        public List<Discipline> disciplines = new List<Discipline>();
        public string State { get; set; }
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
        public Memento CreateMemento()
        {
            return new Memento(disciplines);
        }
    }
}
