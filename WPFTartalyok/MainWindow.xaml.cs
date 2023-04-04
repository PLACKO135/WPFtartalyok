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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Osztalyok;

namespace WPFTartalyok
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Tartaly> tartalyok = new List<Tartaly>();
        public MainWindow()
        {
            InitializeComponent();
            rdoTeglatest.IsChecked = true;
        }

        private void rdoKocka_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.IsEnabled = false;
            txtAel.Text = "10";
            txtBel.IsEnabled = false;
            txtBel.Text = "10";
            txtCel.IsEnabled = false;
            txtCel.Text = "10";

        }

        private void rdoTeglatest_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.IsEnabled = true;
            txtAel.Text = "";
            txtBel.IsEnabled = true;
            txtBel.Text = "";
            txtCel.IsEnabled = true;
            txtCel.Text = "";
        }

        private void btnFelvesz_Click(object sender, RoutedEventArgs e)
        {

            Tartaly ujTest;
           
            if (rdoKocka.IsChecked == true)
            {
                ujTest = new Tartaly(txtNev.Text);
            }
            else
            {
                ujTest = new Tartaly(txtNev.Text, int.Parse(txtAel.Text), int.Parse(txtBel.Text), int.Parse(txtCel.Text));
            }


            lbTartalyok.Items.Add(ujTest.Info());
            tartalyok.Add(ujTest);

        }

        private void btnRogzit_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter sw = new StreamWriter("tartalyok.txt", append: true);
            sw.WriteLine();
            sw.Close();
            foreach (Tartaly aktElem in tartalyok)
            {
                String csvsor = $"{aktElem.Nev};{aktElem.aEl};{aktElem.bEl};{aktElem.cEl};{aktElem.AktLiter}";
                sw.WriteLine(csvsor);
            }
        }
    }
}
