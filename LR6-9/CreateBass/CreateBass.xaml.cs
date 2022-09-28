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
using System.Windows.Resources;
using System.Windows.Shapes;

using Microsoft.Win32;

namespace ЛР6_9.CreateBass
{
    /// <summary>
    /// Логика взаимодействия для CreateBass.xaml
    /// </summary>
    public partial class CreateBass : Window
    {
        public Bass_Model.Bass NewBass = new Bass_Model.Bass();
        public CreateBass(string languagePath)
        {
            InitializeComponent();
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);

            StreamResourceInfo sri = Application.GetResourceStream(
    new Uri("pick.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;
        }

        private void AddBass(object sender, RoutedEventArgs e)
        {
            
            try
            {
                if (NewBassName.Text == "" || NewBassManufacturer.Text == "" || NewBassPrice.Text == "" || NewBassCount.Text == "" || NewBassDescr.Text == "") 
                {
                    throw new Exception();
                }
                NewBass.Name = NewBassName.Text;
                NewBass.Manufacturer = NewBassManufacturer.Text;
                NewBass.Price = int.Parse(NewBassPrice.Text);
                NewBass.Count = int.Parse(NewBassCount.Text);
                NewBass.Rate = int.Parse(NewBassRate.Text);
                NewBass.Sale = NewBassSale.Text;
                NewBass.Description = NewBassDescr.Text;
                if(FourString.IsChecked==true)
                {
                    NewBass.Type = "Bass";
                }
                if (TypeTypeFiveString.IsChecked == true)
                {
                    NewBass.Type = "TypeFiveString";
                }
                if (SixString.IsChecked == true)
                {
                    NewBass.Type = "StudentBass";
                }
                NewBass.ID = MainWindow.MainForm.basses.Count;

                MainWindow.MainForm.basses.Add(NewBass);

                
                

                MainWindow.MainForm.History.Add(MainWindow.MainForm.basses.GetRange(0,MainWindow.MainForm.basses.Count));
                MainWindow.MainForm.CurrentPosition++;

                MainWindow.MainForm.ShowLibrary();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Введите данные корректно!");
            }
           
        }

        private void AddImage(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
            if (openDialog.ShowDialog() == true)
            {
                NewBass.ImagePath = openDialog.FileName;
                NewBassImage.Source = new BitmapImage(new Uri(openDialog.FileName));
            }
        }

        private void NewBassName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (NewBassName.Text == "")
            {
                TopName.Foreground = Brushes.Red;
            }
            else
            {
                TopName.Foreground = Brushes.Black;
            }
        }
    }
    
}
