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

namespace задача2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lang_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Ru.IsHighlighted)
            {
                var uri = new Uri(@"Lang\Ru.xaml", UriKind.Relative);
                ResourceDictionary resourceDictionary = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
            }

            else if (By.IsHighlighted)
            {
                var uri = new Uri(@"Lang\By.xaml", UriKind.Relative);
                ResourceDictionary resourceDictionary = Application.LoadComponent(uri) as ResourceDictionary;
                Application.Current.Resources.Clear();
                Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(T1.Text + "\r" + T2.Text, "Message");
        }
    }
}
