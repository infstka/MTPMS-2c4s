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
    /// Логика взаимодействия для SelectByType.xaml
    /// </summary>
    public partial class SelectByType : Window
    {
        public List<Bass_Model.Bass> CurrentBasses;
        public SelectByType(List<Bass_Model.Bass> basses,string languagePath)
        {
            InitializeComponent();

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);

            CurrentBasses = basses;
        }

        private void Find(object sender, RoutedEventArgs e)
        {
            MainWindow.MainForm.ChoosedBasses.Clear();
            if (FourString.IsChecked == true)
            {
                foreach(Bass_Model.Bass bass in CurrentBasses)
                {
                    if(bass.Type == "Bass")
                    {
                        MainWindow.MainForm.ChoosedBasses.Add(bass);
                    }
                }
            }
            if (TypeTypeFiveString.IsChecked == true)
            {
                foreach (Bass_Model.Bass bass in CurrentBasses)
                {
                    if (bass.Type == "TypeFiveString")
                    {
                        MainWindow.MainForm.ChoosedBasses.Add(bass);
                    }
                }
            }
            if (SixString.IsChecked == true)
            {
                foreach (Bass_Model.Bass bass in CurrentBasses)
                {
                    if (bass.Type == "StudentBass")
                    {
                        MainWindow.MainForm.ChoosedBasses.Add(bass);
                    }
                }
            }
            MainWindow.MainForm.ShowSelectedBasses();
            this.Close();
        }
    }
}
