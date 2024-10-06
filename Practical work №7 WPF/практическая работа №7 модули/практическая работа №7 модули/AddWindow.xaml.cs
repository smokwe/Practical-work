using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Shapes;

namespace практическая_работа__7_модули
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public int CurrentUserRole { get; set; }
        public Employee employee { get; set; }
        public int count;
        public AddWindow(int count, int userRole)
        {
            InitializeComponent();
            this.count = count;
            CurrentUserRole = userRole;
            SetAccessBasedOnRole();           
        }     
        public AddWindow(Employee employee)
        {
            InitializeComponent();
            this.count= employee.Id - 1;
            NameBox.Text = employee.FirstName;
            LastBox.Text = employee.LastName;
            AgeBox.Text = employee.Age.ToString();
            PositionBox.Text = employee.Position;   
            RoleBox.Text = employee.Role;
        }
        private void SetAccessBasedOnRole()
        {
            if (CurrentUserRole != 0)
            {
                TextBlockRole.Visibility = Visibility.Collapsed;
                RoleBox.Visibility = Visibility.Collapsed;
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {           
            if (int.TryParse(AgeBox.Text, out int Age))
            {
                employee = new Employee
                {
                    Id = count + 1,
                    FirstName = NameBox.Text,
                    LastName = LastBox.Text,
                    Age = Age,
                    Position = PositionBox.Text,
                    // менеджер не может выбирать роль
                    Role = CurrentUserRole == 0 ? RoleBox.Text : "Менеджер"
                };
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректный возраст (число).", "Ошибка ввода", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            this.Close();
        }

        }
    }

