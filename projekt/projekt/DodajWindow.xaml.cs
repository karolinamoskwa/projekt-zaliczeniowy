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
    /// Logika interakcji dla klasy DodajWindow.xaml
    /// </summary>
    public partial class DodajWindow : Window
    {
        public MainWindow mw;
        public DodajWindow(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
            Zaladuj();
        }

        public void Zaladuj()
        {
            NazwaGrid.ItemsSource = null;
            NazwaGrid.ItemsSource = mw.db.NazwaGry.ToList();

            TrybGrid.ItemsSource = null;
            TrybGrid.ItemsSource = mw.db.TrybGry.ToList();

            WidokGrid.ItemsSource = null;
            WidokGrid.ItemsSource = mw.db.Widoki.ToList();

            GatunkiGrid.ItemsSource = null;
            GatunkiGrid.ItemsSource = mw.db.Gatunki.ToList();
        }

        

        private void DodajNazwaBut_Click(object sender, RoutedEventArgs e)
        {
            DodajNazwaWindow dw = new DodajNazwaWindow(mw, this);
            dw.ShowDialog();
        }

        private void UsunNazwaBut_Click(object sender, RoutedEventArgs e)
        {
            if (NazwaGrid.SelectedItem != null && NazwaGrid.SelectedItem is NazwaGra)
            {
                NazwaGra r = (NazwaGra)NazwaGrid.SelectedItem;
                NazwaGra gra = mw.db.NazwaGry.Find(r.Id);
                mw.db.NazwaGry.Remove(gra);
                mw.db.SaveChanges();

                Zaladuj();
            }

            else
            {
                MessageBox.Show("Wybierz nazwę");
            }
        }

        private void DodajTrybBut_Click(object sender, RoutedEventArgs e)
        {
            DodajTrybWindow dw = new DodajTrybWindow(mw, this);
            dw.ShowDialog();
        }

        private void UsunTrybBut_Click(object sender, RoutedEventArgs e)
        {
            if (TrybGrid.SelectedItem != null && TrybGrid.SelectedItem is Tryb)
            {
                Tryb r = (Tryb)TrybGrid.SelectedItem;
                Tryb tryb = mw.db.TrybGry.Find(r.Id);
                mw.db.TrybGry.Remove(tryb);
                mw.db.SaveChanges();

                Zaladuj();
            }

            else
            {
                MessageBox.Show("Wybierz nazwę");
            }
        }

        private void DodajWidokBut_Click(object sender, RoutedEventArgs e)
        {
            DodajWidokWindow dw = new DodajWidokWindow(mw, this);
            dw.ShowDialog();
        }

        private void UsunWidokBut_Click(object sender, RoutedEventArgs e)
        {
            if (WidokGrid.SelectedItem != null && WidokGrid.SelectedItem is Widok)
            {
                Widok r = (Widok)WidokGrid.SelectedItem;
                Widok widok = mw.db.Widoki.Find(r.Id);
                mw.db.Widoki.Remove(widok);
                mw.db.SaveChanges();

                Zaladuj();
            }

            else
            {
                MessageBox.Show("Wybierz nazwę");
            }
        }

        private void UsunGatunekBut_Click(object sender, RoutedEventArgs e)
        {
            if (GatunkiGrid.SelectedItem != null && GatunkiGrid.SelectedItem is Gatunek)
            {
                Gatunek r = (Gatunek)GatunkiGrid.SelectedItem;
                Gatunek gatunek = mw.db.Gatunki.Find(r.Id);
                mw.db.Gatunki.Remove(gatunek);
                mw.db.SaveChanges();

                Zaladuj();
            }

            else
            {
                MessageBox.Show("Wybierz nazwę");
            }
        }

        private void DodajGatunekBut(object sender, RoutedEventArgs e)
        {
            DodajGatunekWindow dw = new DodajGatunekWindow(mw, this);
            dw.ShowDialog();
        }
    }
}
