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

namespace Практическая_работа__4_модули
{
    /// <summary>
    /// Логика взаимодействия для UserPersonalCabinetPage.xaml
    /// </summary>
    public partial class UserPersonalCabinetPage : Page
    {
        public List<Book> Books { get; set; } = new List<Book>();

        public UserPersonalCabinetPage(string fullName)
        {
            InitializeComponent();
            WelcomeMessage.Text = $"Добро пожаловать, {fullName}.";
        }

        private void AddBookButton_Click(object sender, RoutedEventArgs e)
        {
            string title = BookTitleInput.Text;
            string author = BookAuthorInput.Text;

            if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(author))
            {
                Books.Add(new Book { Title = title, Author = author });
                UpdateBooksList();
                BookTitleInput.Clear();
                BookAuthorInput.Clear();
            }
            else
            {
                MessageBox.Show("Введите название и автора книги.");
            }
        }

        private void RemoveBookButton_Click(object sender, RoutedEventArgs e)
        {
            if (BooksList.SelectedItem is Book selectedBook)
            {
                Books.Remove(selectedBook);
                UpdateBooksList();
            }
            else
            {
                MessageBox.Show("Выберите книгу для удаления.");
            }
        }

        // обновление списка книг
        private void UpdateBooksList()
        {
            BooksList.Items.Clear();
            foreach (var book in Books)
            {
                BooksList.Items.Add(book);
            }
        }
    }

}
