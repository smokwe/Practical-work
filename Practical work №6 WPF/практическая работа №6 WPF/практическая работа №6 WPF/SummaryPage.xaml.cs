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

namespace практическая_работа__6_WPF
{    
    public partial class SummaryPage : Page
    {
        private Frame _mainFrame;
        private UserData _userData;

        public SummaryPage(Frame mainFrame, UserData userData)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
            _userData = userData;
            DisplayUserData();
        }

        private void DisplayUserData()
        {
            NameTextBlock.Text = "Имя: " + _userData.Name;
            AgeTextBlock.Text = "Возраст: " + _userData.Age;
            EmailTextBlock.Text = "Email: " + _userData.Email;
            if (File.Exists(_userData.PhotoPath))
            {
                ProfileImage.Source = new BitmapImage(new Uri(_userData.PhotoPath));
            }
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new MainPage(_mainFrame));
        }
    }
}
