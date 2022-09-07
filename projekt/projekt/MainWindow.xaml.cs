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

namespace projekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Baza db;
        public MainWindow()
        {
            InitializeComponent();
            db = new Baza();


            NazwaCombo.ItemsSource = db.NazwaGry.ToList();
            NazwaCombo.SelectedIndex = 0;

            GatunekCombo.ItemsSource = db.Gatunki.ToList();
            GatunekCombo.SelectedIndex = 0;

            TypCombo.ItemsSource = db.TrybGry.ToList();
            TypCombo.SelectedIndex = 0;

            WidokCombo.ItemsSource = db.Widoki.ToList();
            WidokCombo.SelectedIndex = 0;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AdminWind ad = new AdminWind(this);
            ad.ShowDialog();
        }

        private void TypCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CaloscBut_Click(object sender, RoutedEventArgs e)
        {

            string nazwa = "";
            string tryb = "";
            string widok = "";
            string gatunek = "";

            if (NazwaCombo.SelectedItem != null)
            {
                NazwaGra nazwa1 = (NazwaGra)NazwaCombo.SelectedItem;
                nazwa = nazwa1.NameGry;
            }

            if (TypCombo.SelectedItem != null)
            {
                Tryb tryb1 = (Tryb)TypCombo.SelectedItem;
                tryb = tryb1.NameTryb;
            }

            if (GatunekCombo.SelectedItem != null)
            {
                Gatunek gatunek1 = (Gatunek)GatunekCombo.SelectedItem;
                gatunek = gatunek1.NameGatunek;
            }

            if (WidokCombo.SelectedItem != null)
            {
                Widok widok1 = (Widok)WidokCombo.SelectedItem;
                widok = widok1.NameWidok;
            }
            

            CaloscLabel.Content = $"Nazwa gry: {nazwa}, Tryb gry: {tryb}, Widok gry: {widok}, Gatunek gry: {gatunek}";
        }
    }
}
