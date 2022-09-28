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
using System.Text.RegularExpressions;

namespace ЛР6_9.SeachBass
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public string LanguagePath;
        public Search(string languagePath)
        {
            InitializeComponent();

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
            LanguagePath = languagePath;
        }

        private void FindBass(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(FindName.Text);
            foreach(Bass_Model.Bass bass in MainWindow.MainForm.basses)
            {
                if(regex.IsMatch(bass.Name))
                {
                    BassDescription.BassDescription bassDescription = new BassDescription.BassDescription(bass,LanguagePath);
                    bassDescription.Show();
                }
            }
        }
    }
}
