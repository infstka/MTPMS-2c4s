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

namespace ЛР6_9.EditBass
{
    /// <summary>
    /// Логика взаимодействия для EditBass.xaml
    /// </summary>
    public partial class EditBass : Window
    {

        public Bass_Model.Bass CurrentBass;
        public EditBass(Bass_Model.Bass bass,string languagePath)
        {
            

            InitializeComponent();

            

            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);

            CurrentBass = bass;
            EditBassName.Text = bass.Name;
            EditBassManufacturer.Text = bass.Manufacturer;
            EditBassPrice.Text = bass.Price.ToString();
            EditBassCount.Text = bass.Count.ToString();
            EditBassRate.Text = bass.Rate.ToString();
            EditBassSale.Text = bass.Sale;
            EditBassDescr.Text = bass.Description;

            if(bass.Type=="Bass")
            {
                FourString.IsChecked = true;
            }
            if (bass.Type == "TypeFiveString")
            {
                TypeFiveString.IsChecked = true;
            }
            if (bass.Type == "StudentBass")
            {
                SixString.IsChecked = true;
            }
        

    }


        private void EditCurrentBass(object sender, RoutedEventArgs e)
        {
            try
            {
                if (EditBassName.Text != "")
                {
                    CurrentBass.Name = EditBassName.Text;
                }
                if (EditBassManufacturer.Text != "")
                {
                    CurrentBass.Manufacturer = EditBassManufacturer.Text;
                }
                if (EditBassPrice.Text != "")
                {
                    CurrentBass.Price = int.Parse(EditBassPrice.Text);
                }
                if (EditBassCount.Text != "")
                {
                    CurrentBass.Count = int.Parse(EditBassCount.Text);
                }
                if (EditBassDescr.Text != "")
                {
                    CurrentBass.Description = EditBassDescr.Text;
                }
                if (EditBassRate.Text != "") 
                {
                    CurrentBass.Rate = int.Parse(EditBassRate.Text);
                }
                if(EditBassSale.Text != "")
                {
                    CurrentBass.Sale = EditBassSale.Text;
                }

                

                MainWindow.MainForm.ShowLibrary();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введите данные корректно");
            }
        }

        private void EditCurrentImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openDialog.ShowDialog() == true)
            {
                CurrentBass.ImagePath = openDialog.FileName;
                EditBassImage.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }
    }
}
