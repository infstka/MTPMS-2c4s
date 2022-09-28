using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6_9.Sort
{
    class Sort
    {
        public static void SortByPrice()
        {
            int index = 0;
            var SortedByPrice = from i in MainWindow.MainForm.basses
                                orderby i.Price
                                select i;
            foreach (Bass_Model.Bass bass in SortedByPrice)
            {
                MainWindow.MainForm.basses[index] = bass;
                index++;
            }
            MainWindow.MainForm.ShowLibrary();
        }

        public static void SortByCount()
        {
            int index = 0;
            var SortedByPrice = from i in MainWindow.MainForm.basses
                                orderby i.Count
                                select i;
            foreach (Bass_Model.Bass bass in SortedByPrice)
            {
                MainWindow.MainForm.basses[index] = bass;
                index++;
            }
            MainWindow.MainForm.ShowLibrary();
        }
    }
}
