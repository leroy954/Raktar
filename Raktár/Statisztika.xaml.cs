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
    /// <summary>
    /// Interaction logic for Statisztika.xaml
    /// </summary>
    public partial class Statisztika : Window
    {
        public static List<Elad> eladasok = new List<Elad>();

        public Statisztika()
        {
            InitializeComponent();
            string[] sorok = File.Exists("eladasok.txt") ? File.ReadAllLines("eladasok.txt") : new string[0];
            List<string> nevek = sorok.Where(sor => sor.Trim() != "").Select(sor => sor.Split(';')[0].Trim()).Distinct().ToList();

            foreach (string nev in nevek)
            {
                long darab = sorok.Where(sor => sor.Trim() != "").Where(sor => sor.Split(';')[0].Trim() == nev).Sum(sor => long.Parse(sor.Split(';')[2]));
                dgStat.ItemsSource = dgStat.ItemsSource ?? new List<object>();
                ((List<object>)dgStat.ItemsSource).Add(new { Termek = nev, Osszesen = darab });
                dgStat.Items.Refresh();
            }
        }

        private void btnFomenu_Click(object sender, RoutedEventArgs e)
        {
            Menuoldal m1 = new Menuoldal();
            m1.Show();
            this.Hide();
        }

        public void btnNyomtatas_Click(object sender, RoutedEventArgs e)
        {
            if (dgStat.Items.Count == 0)
            {
                MessageBox.Show("Nincs mit nyomtatni, még nincs eladás.");
                return;
            }

            MessageBox.Show("Nyomtatás folyamatban...");
            StreamWriter sw = new StreamWriter("statisztika.txt");
            foreach (dynamic s in dgStat.ItemsSource)
            {
                sw.WriteLine($"{s.Termek}: {s.Osszesen}");
            }
            sw.Close();
        }
    }
}
