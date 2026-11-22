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

namespace Raktár
{


    public partial class MainWindow : Window
    {
        static List<User> users = new List<User>();




        public MainWindow()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("User.txt");
            while (!sr.EndOfStream)
            {
                string[] darabok = sr.ReadLine().Split(' ');
                users.Add(new User(darabok[0], darabok[1]));



            }
            sr.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool be = true;
            string beirtUser = tbxNev.Text;
            string beirtPassword = tbxJelszo.Text;
            foreach (User u in users)
            {
                if (beirtUser == u.Name && beirtPassword == u.Password)
                {
                    be = true;
                }
            }
            if (be) {
                Menuoldal m1 = new Menuoldal();
                m1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nem megfelelőek az adatok.");
            }
        }

        private void tbxNev_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxJelszo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
