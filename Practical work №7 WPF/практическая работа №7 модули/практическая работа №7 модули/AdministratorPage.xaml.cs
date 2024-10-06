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

namespace практическая_работа__7_модули
{
    /// <summary>
    /// Логика взаимодействия для AdministratorPage.xaml
    /// </summary>
    public partial class AdministratorPage : Page
    {
        public int CurrentUserRole { get; set; }

        public Employee employee = new Employee();
        public List<Employee> employees { get; set; } = new List<Employee>();
        public AdministratorPage(int userRole)
        {
            InitializeComponent();
            CurrentUserRole = userRole;
            employees = new List<Employee>();
            EmployeeDG.ItemsSource = Employee.employees;        
        }      

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // проверка на наличие сотрудников и корректность роли
            if (employees != null && CurrentUserRole >= 0)
            {
                AddWindow add = new AddWindow(employees.Count, CurrentUserRole);
                add.ShowDialog();
                // проверка на добавление сотрудника
                if (add.employee != null) 
                {
                    employees.Add(add.employee);
                    employee.addEmployee(add.employee);
                    EmployeeDG.ItemsSource = null;
                    EmployeeDG.ItemsSource = employees;
                }
                else
                {
                    MessageBox.Show("Сотрудник не был добавлен.");
                }
            }
            else
            {
                MessageBox.Show("Ошибка при добавлении сотрудника. Проверьте корректность данных.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeDG.SelectedItem is Employee selectEmployee)
            {
                AddWindow add = new AddWindow(selectEmployee);
                add.ShowDialog();

                // проверка, чтобы индекс был в пределах списка
                if (EmployeeDG.SelectedIndex >= 0 && EmployeeDG.SelectedIndex < employees.Count)
                {
                    employees[EmployeeDG.SelectedIndex] = add.employee;
                    Employee.employees[EmployeeDG.SelectedIndex] = add.employee; // также обновляем глобальный список, если он используется
                }
                else
                {
                    MessageBox.Show("Индекс за пределами диапазона. Попробуйте снова выбрать сотрудника.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }

                EmployeeDG.ItemsSource = null;
                EmployeeDG.ItemsSource = employees;
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для редактирования.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeDG.SelectedItem is Employee selectEmployee)
            {
                employees.Remove(selectEmployee);
                Employee.employees.Remove(selectEmployee);
                EmployeeDG.ItemsSource = null;
                EmployeeDG.ItemsSource = employees;
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления");
            }
        }

        private void SortBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (SortBox.SelectedIndex)
            {
                case 0:
                    employees = employees.OrderBy(emp => emp.LastName).ThenBy(emp => emp.Age).ToList();
                    break;
                case 1:
                    employees = employees.OrderByDescending(emp => emp.LastName).ThenByDescending(emp => emp.Age).ToList();
                    break;
            }
            EmployeeDG.ItemsSource = null;
            EmployeeDG.ItemsSource = employees;
        }
    }
}
