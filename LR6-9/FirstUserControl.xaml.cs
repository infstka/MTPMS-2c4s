using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ЛР6_9
{
    /// <summary>
    /// Логика взаимодействия для FirstUserControl.xaml
    /// </summary>
    /// 
    
    public partial class FirstUserControl : UserControl
    {
        public FirstUserControl()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TypeFiveString five = (TypeFiveString)this.Resources["ModernTypeFiveString"]; // получаем ресурс по ключу
            MessageBox.Show("Цена " + five.Title + " равна " + five.Price.ToString());
        }
    }
}
