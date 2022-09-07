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
    /// Logika interakcji dla klasy DodajWidokWindow.xaml
    /// </summary>
    public partial class DodajWidokWindow : Window
    {
        public MainWindow mw;
        public DodajWindow dw;
        public DodajWidokWindow(MainWindow mw, DodajWindow dw)
        {
            InitializeComponent();

            this.mw = mw;
            this.dw = dw;
        }

        private void ZapiszWidokBut_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(WidokTxt.Text))
            {
                MessageBox.Show("Wprowadzono złe dane");
            }

            else
            {
                Widok widok = new Widok(WidokTxt.Text);
                mw.db.Widoki.Add(widok);
                mw.db.SaveChanges();

                dw.Zaladuj();
                this.Close();
            }
        }
    }
}
