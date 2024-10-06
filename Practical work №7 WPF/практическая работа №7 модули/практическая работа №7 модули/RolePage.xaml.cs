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
    /// Логика взаимодействия для RolePage.xaml
    /// </summary>
    public partial class RolePage : Page
    {    

        public RolePage()
        {
            InitializeComponent();             
        }
       
        private void RoleButton_Click(object sender, RoutedEventArgs e)
        {
            if (RoleBox.SelectedItem is ComboBoxItem selectedItem)
            {
                // Проверка, что Tag у элемента не null
                if (selectedItem.Tag != null)
                {
                    // Парсим роль из тега
                    int selectedRole = int.Parse(selectedItem.Tag.ToString());

                    // Переход на нужную страницу в зависимости от выбранной роли
                    switch (selectedRole)
                    {
                        case 0: // Администратор
                            this.NavigationService.Navigate(new AdministratorPage(selectedRole));
                            break;
                        case 1: // Менеджер
                            this.NavigationService.Navigate(new ManagerPage(selectedRole));
                            break;
                        case 2: // Пользователь
                            this.NavigationService.Navigate(new UserPage());
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось определить роль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите роль.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}
