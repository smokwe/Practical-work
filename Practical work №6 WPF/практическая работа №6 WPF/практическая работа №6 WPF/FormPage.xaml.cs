using Microsoft.Win32;
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

namespace практическая_работа__6_WPF
{ 
    public partial class FormPage : Page
    {
        private Frame _mainFrame;
        private string _photoPath;
        public FormPage(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
        }

        private void UploadPhoto_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.png)|*.jpg;*.png";
            if (openFileDialog.ShowDialog() == true)
            {
                _photoPath = openFileDialog.FileName;
                MessageBox.Show("Фотография успешно загружена!", "Загрузка завершена", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            var userData = new UserData
            {
                Name = NameTextBox.Text,
                Age = AgeTextBox.Text,
                Email = EmailTextBox.Text,
                PhotoPath = _photoPath
            };
            _mainFrame.Navigate(new SummaryPage(_mainFrame, userData));
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && (textBox.Text == "Имя" || textBox.Text == "Возраст" || textBox.Text == "Email"))
            {
                textBox.Text = string.Empty;
                textBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox.Name == "NameTextBox")
                    textBox.Text = "Имя";
                else if (textBox.Name == "AgeTextBox")
                    textBox.Text = "Возраст";
                else if (textBox.Name == "EmailTextBox")
                    textBox.Text = "Email";

                textBox.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }              
    }
}
