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

namespace projekt
{
    /// <summary>
    /// Logika interakcji dla klasy AdminWind.xaml
    /// </summary>
    public partial class AdminWind : Window
    {
        public MainWindow mw;
        public AdminWind(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void LoginBut_Click(object sender, RoutedEventArgs e)
        {
            if (UzytkownikTxt.Text == "admin" && HasloTxt.Text == "admin123")
            {
                DodajWindow aw = new DodajWindow(mw);
                aw.ShowDialog();
            }
            else
            {
                MessageBox.Show("Podano złe dane");
            }
        }
    }
}
