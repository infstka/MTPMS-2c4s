using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace ЛР6_9.Patterns
{
    class ApplicationsViewModel 
    {
        private RelayCommand addBass;
        public RelayCommand AddBass
        {
            get
            {
                return addBass ?? (addBass = new RelayCommand(obj =>
                {
                    CreateBass.CreateBass create = new CreateBass.CreateBass(MainWindow.MainForm.languagePath);
                    create.Show();
                }));
            }
        }

        private RelayCommand sortByPrice;
        public RelayCommand SortByPrice
        {
            get
            {
                return sortByPrice ?? (sortByPrice = new RelayCommand(obj =>
                {
                    Sort.Sort.SortByPrice();
                }));
            }
        }

        private RelayCommand sortByCount;
        public RelayCommand SortByCount
        {
            get
            {
                return sortByCount ?? (sortByCount = new RelayCommand(obj =>
                {
                    Sort.Sort.SortByCount();
                }));
            }
        }

        private RelayCommand saveInXML;
        public RelayCommand SaveInXML
        {
            get
            {
                return saveInXML ?? (saveInXML = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.SaveInXml();
                }));
            }
        }

        private RelayCommand loadFromXML;
        public RelayCommand LoadFromXML
        {
            get
            {
                return loadFromXML ?? (loadFromXML = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.LoadFromXml();
                }));
            }
        }

        private RelayCommand search;
        public RelayCommand Search
        {
            get
            {
                return search ?? (search = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.Search();
                }));
            }
        }

        private RelayCommand changeLanguageToRu;
        public RelayCommand ChangeLanguageToRu
        {
            get
            {
                return changeLanguageToRu ?? (changeLanguageToRu = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.ChangeLanguageToRu();
                }));
            }
        }

        private RelayCommand changeLanguageToEn;
        public RelayCommand ChangeLanguageToEn
        {
            get
            {
                return changeLanguageToEn ?? (changeLanguageToEn = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.ChangeLanguageToEn();
                }));
            }
        }

        private RelayCommand changeLanguageToBy;
        public RelayCommand ChangeLanguageToBy
        {
            get
            {
                return changeLanguageToBy ?? (changeLanguageToBy = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.ChangeLanguageToBy();
                }));
            }
        }

        private RelayCommand chooseByPrice;
        public RelayCommand ChooseByPrice
        {
            get
            {
                return chooseByPrice ?? (chooseByPrice = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.ChooseByPrice();
                }));
            }
        }

        private RelayCommand chooseByType;
        public RelayCommand ChooseByType
        {
            get
            {
                return chooseByType ?? (chooseByType = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.ChooseByType();
                }));
            }
        }

        private RelayCommand setStyle1;
        public RelayCommand SetStyle1
        {
            get
            {
                return setStyle1 ?? (setStyle1 = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.SetStyle1();
                }));
            }
        }

        private RelayCommand setStyle2;
        public RelayCommand SetStyle2
        {
            get
            {
                return setStyle2 ?? (setStyle2 = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.SetStyle2();
                }));
            }
        }

        private RelayCommand openUserControl;
        public RelayCommand OpenUserControl
        {
            get
            {
                return openUserControl ?? (openUserControl = new RelayCommand(obj =>
                {
                    ForUC forUC = new ForUC();
                    forUC.Show();
                }));
            }
        }

        private RelayCommand undoFunc;
        public RelayCommand UndoFunc
        {
            get
            {
                return undoFunc ?? (undoFunc = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.UndoFunc();
                }));
            }
        }

        private RelayCommand redoFunc;
        public RelayCommand RedoFunc
        {
            get
            {
                return redoFunc ?? (redoFunc = new RelayCommand(obj =>
                {
                    MainWindow.MainForm.RedoFunc();
                }));
            }
        }
    }
}
