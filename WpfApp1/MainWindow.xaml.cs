using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName = "Помидоры",
                ProdPrice = 70,
                ProdImage = "Data/t.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Огурцы",
                ProdPrice = 50,
                ProdImage = "Data/o.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Лук",
                ProdPrice = 30,
                ProdImage = "Data/l.jpg",
                ProductCategory = ProductCategorys.Food
            });
            products.Add(new Product()
            {
                ProdName = "Телефон",
                ProdPrice = 50000,
                ProdImage = "Data/p.jpg",
                ProductCategory = ProductCategorys.AppLiances
            });
            products.Add(new Product()
            {
                ProdName = "Часы",
                ProdPrice = 25000,
                ProdImage = "Data/w.jpg",
                ProductCategory = ProductCategorys.AppLiances
            });
            products.Add(new Product()
            {
                ProdName = "Наушники",
                ProdPrice = 15000,
                ProdImage = "Data/h.jpg",
                ProductCategory = ProductCategorys.AppLiances
            });
            Listbox.ItemsSource = products;
        }
    }
}
