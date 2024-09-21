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

namespace Практическая__3_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> Products { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Products = new List<Product>();
            ProductsDataGrid.ItemsSource = Products;
        }


        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string filmName = FilmNameTextBox.Text;
            string filmProducer = FilmProducerTextBox.Text;
            DateTime filmReleaseYear;
           
            if (!string.IsNullOrEmpty(FilmReleaseYearTextBox.Text))
            {
                if (DateTime.TryParse(FilmReleaseYearTextBox.Text, out filmReleaseYear))
                {                   
                    AddFilm(filmName, filmProducer, filmReleaseYear.ToString("dd/MM/yyyy"));
                }
                else
                {
                    MessageBox.Show("Введите корректную дату в текстовое поле.");
                }
            }          
            else
            {
                MessageBox.Show("Заполните поля");
            }           
            FilmNameTextBox.Clear();
            FilmProducerTextBox.Clear();
            FilmReleaseYearTextBox.Clear();            
        }

        private void AddFilm(string filmName, string filmProducer, string filmReleaseYear)
        {
            Products.Add(new Product
            {
                FilmName = filmName,
                FilmProducer = filmProducer,
                FilmReleaseYear = filmReleaseYear
            });           
            ProductsDataGrid.Items.Refresh();
        }
    }

    public class Product
    {
        public string FilmName { get; set; }
        public string FilmProducer { get; set; }
        public string FilmReleaseYear { get; set; }
    }
}
