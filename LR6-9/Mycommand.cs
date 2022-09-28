using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ЛР6_9
{
    public class WindowCommands
    {
        static WindowCommands()
        {
            Exit = new RoutedCommand("Exit", typeof(MainWindow));
        }
        public static RoutedCommand Exit { get; set; }
    } 
}



//public class Qwerty
//{
//    public int a;
//    public void ABC()
//    {
//    }
//}

//Qwerty qwe = new Qwerty();
//qwe.a = 1;
//qwe.ABC();
