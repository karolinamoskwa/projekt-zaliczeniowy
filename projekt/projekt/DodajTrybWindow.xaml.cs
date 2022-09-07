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
    /// Logika interakcji dla klasy DodajTrybWindow.xaml
    /// </summary>
    public partial class DodajTrybWindow : Window
    {
        public MainWindow mw;
        public DodajWindow dw;
        public DodajTrybWindow(MainWindow mw, DodajWindow dw)
        {
            InitializeComponent();

            this.mw = mw;
            this.dw = dw;
        }

        

        private void ZapiszTrybBut_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TrybTxt.Text))
            {
                MessageBox.Show("Wprowadzono złe dane");
            }

            else
            {
                Tryb tryb = new Tryb(TrybTxt.Text);
                mw.db.TrybGry.Add(tryb);
                mw.db.SaveChanges();

                dw.Zaladuj();
                this.Close();
            }
        }
    }
}
