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
    public partial class MainPage : Page
    {
        private Frame _mainFrame;
        public MainPage(Frame mainFrame)
        {
            InitializeComponent();
            _mainFrame = mainFrame;
        }

        private void GoToFormPage_Click(object sender, RoutedEventArgs e)
        {
            _mainFrame.Navigate(new FormPage(_mainFrame));
        }
    }
}
