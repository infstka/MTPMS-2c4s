using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6_9.Patterns
{
    public class Memento
    {
        public ObservableCollection<Bass_Model.Bass> BassList = new ObservableCollection<Bass_Model.Bass>();
        public Memento(ObservableCollection<Bass_Model.Bass> state)
        {
            if (state != null)
            {
                foreach (Bass_Model.Bass x in state)
                {
                    this.BassList.Add(x);
                }
            }
            else if (state == null)
                this.BassList.Clear();
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

    public class BassCollections
    {
        public ObservableCollection<Bass_Model.Bass> BassList { get; set; }
        public void RestoreState(Memento memento)
        {
            BassList = memento.BassList;
        }
        public Memento SaveState()
        {
            return new Memento(BassList);
        }
    }
}
