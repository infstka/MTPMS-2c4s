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
using System.Windows.Shapes;

namespace ЛР6_9.Selection
{
    /// <summary>
    /// Логика взаимодействия для SelectByPrice.xaml
    /// </summary>
    public partial class SelectByPrice : Window
    {
        public List<Bass_Model.Bass> CurrentBasses;
        public SelectByPrice(List<Bass_Model.Bass> Basses, string languagePath)
        {
            InitializeComponent();

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);

            CurrentBasses = Basses;
        }

        private void Find(object sender, RoutedEventArgs e)
        {
            MainWindow.MainForm.ChoosedBasses.Clear();
            foreach (Bass_Model.Bass bass in CurrentBasses)
            {
                if(bass.Price>=int.Parse(lowPrice.Text) && bass.Price<=int.Parse(highPrice.Text))
                {
                    MainWindow.MainForm.ChoosedBasses.Add(bass);
                }
            }
            MainWindow.MainForm.ShowSelectedBasses();
            this.Close();
        }
    }
}
