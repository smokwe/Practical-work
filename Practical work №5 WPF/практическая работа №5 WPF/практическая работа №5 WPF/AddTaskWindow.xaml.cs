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
using System.Windows.Shapes;

namespace практическая_работа__5_WPF
{
    /// <summary>
    /// Логика взаимодействия для AddTaskWindow.xaml
    /// </summary>
    public partial class AddTaskWindow : Window
    {
        private MainWindow _mainWindow;

        public AddTaskWindow(MainWindow mainWindow)
        {
            InitializeComponent();
            this._mainWindow = mainWindow;
        }

        private void SaveTaskButton_Click(object sender, RoutedEventArgs e)
        {
            string title = TaskTitleTextBox.Text;
            string category = (TaskCategoryComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            string priority = (NewTaskPriorityComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();

            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(category) && !string.IsNullOrWhiteSpace(priority))
            {
                Task newTask = new Task(title, category, priority);
                _mainWindow.AddTask(newTask);
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
                //string priority = ((ComboBoxItem)NewTaskPriorityComboBox.SelectedItem).Content.ToString();

                //if (!string.IsNullOrEmpty(title))
                //{
                //    Task newTask = new Task { Title = title, Priority = priority };


                //    if (_mainWindow.TaskCategoriesTabControl.SelectedItem == _mainWindow.PersonalTasksTab)
                //    {
                //        newTask.Category = "Личные";
                //        _mainWindow.personalTasks.Add(newTask);
                //    }
                //    else if (_mainWindow.TaskCategoriesTabControl.SelectedItem == _mainWindow.WorkTasksTab)
                //    {
                //        newTask.Category = "Рабочие";
                //        _mainWindow.workTasks.Add(newTask);
                //    }
                //    else if (_mainWindow.TaskCategoriesTabControl.SelectedItem == _mainWindow.AdditionalTasksTab)
                //    {
                //        newTask.Category = "Дополнительные";
                //        _mainWindow.additionalTasks.Add(newTask);
                //    }


                //    _mainWindow.UpdateTaskCount();
                //    this.Close();
                //}
            }
        }
}
