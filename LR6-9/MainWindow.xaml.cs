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
using System.IO;
using System.Xml.Serialization;
using System.Windows.Resources;


namespace ЛР6_9
{

    public partial class MainWindow : Window
    {
        public static MainWindow MainForm;
        public List<Bass_Model.Bass> basses = new List<Bass_Model.Bass>();

        public List<Bass_Model.Bass> ChoosedBasses = new List<Bass_Model.Bass>();
        

        public List<List<Bass_Model.Bass>> History  = new List<List<Bass_Model.Bass>>();
        public int CurrentPosition = 0;
        
        public string languagePath;
        public string stylePath;
        public MainWindow()
        {
            InitializeComponent();
            MainForm = this;

            //this.MaxHeight = 900;
            //this.MaxWidth = 1600;
            this.MinHeight = 450;
            this.MinWidth = 800;
            History.Add(new List<Bass_Model.Bass>(basses));
            StreamResourceInfo sri = Application.GetResourceStream(
               new Uri("pick.cur", UriKind.Relative));
            Cursor customCursor = new Cursor(sri.Stream);
            this.Cursor = customCursor;

            ResourceDictionary language = new ResourceDictionary();
            languagePath = "Dictionaries/Ru.Xaml";
            language.Source = new Uri(languagePath,UriKind.Relative);

            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("Styles/Style_Red_Gray.xaml", UriKind.Relative);
            stylePath = "Styles/Style_Red_Gray.xaml";
            Resources.MergedDictionaries.Add(dict);

            //Подключение динамического ресурса
            this.Resources = new ResourceDictionary()
            {
                Source = new Uri("D:/уник/ООП/ЛР6-9/Resources/DynamicDictionary.xaml")
            };

           

            DataContext = new Patterns.ApplicationsViewModel();
            ShowLibrary();
        }

        public void ShowLibrary()
        {
            BassesList.ItemsSource = null;
            BassesList.ItemsSource = basses;
        }

        public void ShowSelectedBasses()
        {
            foreach(Bass_Model.Bass bass in ChoosedBasses)
            {
                foreach(Bass_Model.Bass nativeBass in basses)
                {
                    
                }
            }
            BassesListChoosed.ItemsSource = null;
            BassesListChoosed.ItemsSource = ChoosedBasses;
        }

        private void AddBass(object sender, RoutedEventArgs e)
        {
            MenuAddBass.Command = ApplicationCommands.New;
            CreateBass.CreateBass AddBass = new CreateBass.CreateBass(languagePath);
            AddBass.Show();
            
        }

        

        private void BassDescription(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(e.Source.ToString().Last().ToString());
            ЛР6_9.BassDescription.BassDescription bassDescription = new ЛР6_9.BassDescription.BassDescription(basses[index],languagePath);
            bassDescription.Show();
            
        }

        private void BassDelete(object sender, RoutedEventArgs e)
        {


           
            int index = int.Parse(e.Source.ToString().Last().ToString());
            this.basses.RemoveAt(index);
            
            CurrentPosition++;
            for (int i = basses.Count - 1; i >= index; i--)
            {
                this.basses[i].ID--;
                

            }
            
            
            History.Add(new List<Bass_Model.Bass>(basses).GetRange(0,basses.Count));

            ShowLibrary();
            BassesListChoosed.ItemsSource = null;
        }

        private void BassEdit(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(e.Source.ToString().Last().ToString());
            EditBass.EditBass editBass = new EditBass.EditBass(basses[index],languagePath);
            editBass.Show();
            BassesListChoosed.ItemsSource = null;
        }
        public void SaveInXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Bass_Model.Bass>));
            using (FileStream stream = new FileStream("Bass.xml", FileMode.Create))
            {
                serializer.Serialize(stream, basses);
            }
        }
        
        public void LoadFromXml()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Bass_Model.Bass>));
            using (FileStream stream = new FileStream("Bass.xml", FileMode.Open))
            {
                List<Bass_Model.Bass> NewBasses = serializer.Deserialize(stream) as List<Bass_Model.Bass>;
                basses.Clear();
                foreach(Bass_Model.Bass bass in NewBasses)
                {
                    basses.Add(bass);
                }
            }
            ShowLibrary();
        }

        public void Search()
        {
            SeachBass.Search search = new SeachBass.Search(languagePath);
            search.Show();
        }

        public void ChangeLanguageToRu()
        {
            languagePath = "Dictionaries/Ru.Xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        public void ChangeLanguageToEn()
        {
            languagePath = "Dictionaries/En.Xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }
        public void ChangeLanguageToBy()
        {
            languagePath = "Dictionaries/By.Xaml";
            ResourceDictionary language = new ResourceDictionary();
            language.Source = new Uri(languagePath, UriKind.Relative);
            Resources.MergedDictionaries.Add(language);
        }

        public void ChooseByPrice()
        {
            Selection.SelectByPrice selectByPrice = new Selection.SelectByPrice(basses,languagePath);
            selectByPrice.Show();
        }

        public void ChooseByType()
        {
            Selection.SelectByType selectByType = new Selection.SelectByType(basses,languagePath);
            selectByType.Show();
        }

        public void SetStyle1()
        {
            MessageBox.Show("work");
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("Styles/Style_Red_Gray.xaml", UriKind.Relative);
            stylePath = "Styles/Style_Red_Gray.xaml";
            Resources.MergedDictionaries.Add(dict);
        }

        public void SetStyle2()
        {
            MessageBox.Show("work");
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("Styles/Style_Orange_Gray.xaml", UriKind.Relative);
            stylePath = "Styles/Style_Orange_Gray.xaml";
            Resources.MergedDictionaries.Add(dict);
        }

        

        

        public void UndoFunc()
        {
            if (CurrentPosition > 0)
            {
                CurrentPosition--;
                basses = History[CurrentPosition];
                ShowLibrary();
                BassesListChoosed.ItemsSource = null;
            }
        }
        public void RedoFunc()
        {
            if(CurrentPosition<History.Count-1)
            {
                basses = History[++CurrentPosition];
                ShowLibrary();
                BassesListChoosed.ItemsSource = null;
            }
                
            
        }

        private void ReOpen(object sender, RoutedEventArgs e)
        {
            RoutedEventsEx routedEventsEx = new RoutedEventsEx();
            routedEventsEx.Show();
        }

        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " +
                DateTime.Now.ToLongTimeString());
                writer.Flush();
            }

            this.Close();
        }

    }
}
