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
    /// Logika interakcji dla klasy DodajNazwaWindow.xaml
    /// </summary>
    public partial class DodajNazwaWindow : Window
    {
        public MainWindow mw;
        public DodajWindow dw;
        public DodajNazwaWindow(MainWindow mw, DodajWindow dw)
        {
            InitializeComponent();

            this.mw = mw;
            this.dw = dw;
        }

        private void ZapiszNazweBut_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NazwaTxt.Text))
            {
                MessageBox.Show("Wprowadzono złe dane");
            }

            else
            {
                NazwaGra nazwa = new NazwaGra(NazwaTxt.Text);
                mw.db.NazwaGry.Add(nazwa);
                mw.db.SaveChanges();

                dw.Zaladuj();
                this.Close();
            }
        }
    }
}
