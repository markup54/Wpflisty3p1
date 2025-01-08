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

namespace Wpflisty3p1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> Slowa { get; set; }
        public List <Produkt> Produkty { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Slowa = new List<string>();
            Slowa.Add("programista");
            Slowa.Add("optymista");
            Slowa.Add("pesymista");
            Slowa.Add("futbolista");
            DataContext = this;

            Produkty = new List<Produkt>();
            Produkty.Add(new Produkt("jajka", 8.30, true, "nabiał"));
            Produkty.Add(new Produkt("mleko", 3.30, true, "nabiał"));
            Produkty.Add(new Produkt("chleb", 5.70, false, "pieczywo"));
            Produkty.Add(new Produkt("jabłka", 2.70, true, "owoce"));
            Produkty.Add(new Produkt("sok", 8.70, true, "napoje"));
            Produkty.Add(new Produkt("kawa", 48.70, true, "napoje"));

        }
    }
}
