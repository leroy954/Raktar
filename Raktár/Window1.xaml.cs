using System;
using System.Collections.Generic;
using System.IO;
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

namespace Raktár
{

    public partial class Window1 : Window
    {
        static List<Termekek> termek = new List<Termekek>();

        public Window1()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("termekek.txt");
            while (!sr.EndOfStream)
            {
                string[] darabok = sr.ReadLine().Split(';');
                termek.Add(new Termekek(darabok[1], int.Parse(darabok[0])));
            }
            sr.Close();
            dataGrid1.ItemsSource = termek;
            dataGrid1.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Menuoldal mw = new Menuoldal();
            mw.Show();
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxTermeknev_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnFelvitel_Click(object sender, RoutedEventArgs e)
        {
            bool helyes = false;
            try
            {
                int beirtCikkszam = int.Parse(tbxCikkszam.Text);
                string beirtTermek = tbxTermeknev.Text;
                termek.Add(new Termekek(beirtTermek, beirtCikkszam));
                dataGrid1.Items.Refresh();
            }
            catch (Exception)
            {

                MessageBox.Show("Hibás adatok!");
            }



        }

        private void btnTorles_Click(object sender, RoutedEventArgs e)
        {
            bool torles = false;
            foreach (var item in termek)
            {
                if (item.Cikkszam == int.Parse(tbxCikkszam1.Text))
                {
                    torles = true;
                    termek.Remove(item);
                    dataGrid1.Items.Refresh();
                    break;
                }
            }
            if (!torles)
            {
                MessageBox.Show("Nincs ilyen termék!");
            }
        }
    }
}
