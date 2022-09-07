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
    /// Logika interakcji dla klasy DodajGatunekWindow.xaml
    /// </summary>
    public partial class DodajGatunekWindow : Window
    {
        public MainWindow mw;
        public DodajWindow dw;
        public DodajGatunekWindow(MainWindow mw, DodajWindow dw)
        {
            InitializeComponent();

            this.mw = mw;
            this.dw = dw;
        }


        private void ZapiszGatunekBut_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(GatunekTxt.Text))
            {
                MessageBox.Show("Wprowadzono złe dane");
            }

            else
            {
                Gatunek gatunek = new Gatunek(GatunekTxt.Text);
                mw.db.Gatunki.Add(gatunek);
                mw.db.SaveChanges();

                dw.Zaladuj();
                this.Close();
            }
        }
    }
}
