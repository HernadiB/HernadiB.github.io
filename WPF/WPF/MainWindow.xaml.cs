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
using WPF.Models;
using static WPF.Models.MainWindowViewModel;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_megjelenit_Click(object sender, RoutedEventArgs e)
        {
            Megjelenit(AllData(OpenConnection()));
        }

        private void btn_exportal_Click(object sender, RoutedEventArgs e)
        {
            Exportal(AllData(OpenConnection()));
        }

        private void btn_szures_Click(object sender, RoutedEventArgs e)
        {
            Megjelenit(FilteredData());
        }

        private void btn_ujadat_Click(object sender, RoutedEventArgs e)
        {
            SecondWindow secondWindow = new SecondWindow();
            secondWindow.Show();
        }
        public void Megjelenit(List<Adat> data)
        {
            dataGrid1.ItemsSource = data;
            dataGrid1.Visibility = Visibility.Visible;
        }
        public List<Adat> FilteredData() //Javítani: Ha üresek a valuek, dobjon messaget
        {
            string nev = tb_nev.Text;
            int ar = int.Parse(tb_ar.Text);
            List<Adat> lista = FilterData(AllData(OpenConnection()), nev, ar);
            return lista;
        }
        public void Figyelmeztet()
        {
            //Implementálni
        }
    }
}
