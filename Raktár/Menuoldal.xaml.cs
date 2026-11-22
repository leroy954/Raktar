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

namespace Raktár
{
    /// <summary>
    /// Interaction logic for Menuoldal.xaml
    /// </summary>
    public partial class Menuoldal : Window
    {
        public Menuoldal()
        {
            InitializeComponent();
        }

        private void btnTermeklista_Click(object sender, RoutedEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
            this.Hide();
        }

        private void btnEladas_Click(object sender, RoutedEventArgs e)
        {
            Eladas el1 = new Eladas();
            el1.Show();
            this.Hide();
        }

        private void btnStatisztika_Click(object sender, RoutedEventArgs e)
        {
            Statisztika st1 = new Statisztika();
            st1.Show();
            this.Hide();
        }
    }
}
