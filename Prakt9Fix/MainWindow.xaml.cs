using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Data;
using Prakt9Fix;

namespace Prakt9
{

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public int populationcc;
        worldc country1 = new worldc("Россия", 148000000, "Москва", "Рубль");
        worldc country2 = new worldc("США", 331000000, "Вашингтон", "Доллар");
        worldc country3 = new worldc("Япония", 125700000, "Токио", "Иена");
        worldc country4 = new worldc("Китай", 1412000000, "Пекин", "Юань");
        worldc country5 = new worldc("Казахстан", 19000000, "Астана", "Тенге");

        public MainWindow()
        {
            InitializeComponent();
            dgCountryList.Items.Add(country1);
            dgCountryList.Items.Add(country2);
            dgCountryList.Items.Add(country3);
            dgCountryList.Items.Add(country4);
            dgCountryList.Items.Add(country5);
            populationcc = country1.Population + country2.Population + country3.Population + country4.Population + country5.Population;
        }

        private void About_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show("Борькин Иван ИСП-31 \nЗаполнить таблицу со списком 5 стран мира с полями: страна, народонаселение, столица, денежная единица.Вывести результат на экран.Вывести общее населениевсех стран.");
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void totalpopulation_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Convert.ToString(populationcc));
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Int32.TryParse(Cpopulation.Text, out int populationc);
            if (populationc > 0 && populationc != 0)
            {
                populationcc += populationc;
                string countryc = Cname.Text; string capital = Ccapital.Text; string monetaryu = Cmonetaryu.Text;
                worldc countryn = new worldc { Country = countryc, Population = populationc, Сapital = capital, Monetaryu = monetaryu };
                dgCountryList.Items.Add(countryn);
            }
            else
            {
                MessageBox.Show("Населенее не может быть меньше или равное 0");
            }
            Cname.Clear();
            Cpopulation.Clear();
            Ccapital.Clear();
            Cmonetaryu.Clear();
        }
    }
}
