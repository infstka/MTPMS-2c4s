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
using Microsoft.Win32;

namespace ЛР6_9.BassDescription
{
    /// <summary>
    /// Логика взаимодействия для BassDescription.xaml
    /// </summary>
    public partial class BassDescription : Window
    {
        public Bass_Model.Bass CurrentBass;
        public BassDescription(Bass_Model.Bass bass,string languagePath)
        {
            InitializeComponent();
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
            CurrentBass = bass;
            ShowInfo();

        }

        public void ShowInfo()
        {
            BassName.Text = CurrentBass.Name;
            BassManufacturer.Text = CurrentBass.Manufacturer;
            BassPrice.Text = CurrentBass.Price.ToString();
            BassCount.Text = CurrentBass.Count.ToString();
            BassDescr.Text = CurrentBass.Description.ToString();
            BassRate.Text = CurrentBass.Rate.ToString();
            if(CurrentBass.ImagePath!=null)
            {
                BassImage.Source = new BitmapImage(new Uri(CurrentBass.ImagePath));
            }
            
            MainWindow.MainForm.ShowLibrary();
        }

        private void BuyBass(object sender, RoutedEventArgs e)
        {
            if(CurrentBass.Count>0)
            {
                CurrentBass.Count--;
                ShowInfo();
                MainWindow.MainForm.ShowSelectedBasses();
            }
            
            
        }
    }
}
