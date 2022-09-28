using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace задача3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //LoadStudents();
        }
        SqlConnection con = new SqlConnection(@"Data Source=WIN-U2TD77CA49G\SQLEXPRESS;Initial Catalog=Students;Integrated Security=True");

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (age.Text == "")
            {
                SqlCommand cmb = new SqlCommand("select * from Studnets", con);


                DataTable db = new DataTable();

                con.Open();
                SqlDataReader sdb = cmb.ExecuteReader();
                db.Load(sdb);
                con.Close();

                //LoadStudents.ItemsSource = db.DefaultView;

            }
            else
            {
                SqlCommand cmb = new SqlCommand("select * from Studnets WHERE Age = '" + age.Text + "'", con);


                DataTable db = new DataTable();


                con.Open();
                SqlDataReader sdb = cmb.ExecuteReader();
                db.Load(sdb);
                con.Close();

                //LoadStudents.ItemsSource = db.DefaultView;
            }

        }
    }
}
