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

namespace практическая_работа__5_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Изменяем тип списка на ObservableCollection
        public ObservableCollection<Task> personalTasks = new ObservableCollection<Task>();
        public ObservableCollection<Task> workTasks = new ObservableCollection<Task>();
        public ObservableCollection<Task> additionalTasks = new ObservableCollection<Task>();

        public MainWindow()
        {
            InitializeComponent();

            // Привязываем ListBox к коллекции personalTasks
            PersonalTasksListBox.ItemsSource = personalTasks;
            WorktasksListBox.ItemsSource = workTasks;
            AdditionaltasksListBox.ItemsSource = additionalTasks;
            UpdateTaskCount();
        }

        public void UpdateTaskCount()
        {
            PersonalTaskCountLabel.Content = $"Задач: {personalTasks.Count}";
            WorktasksCountLabel.Content = $"Задач: {workTasks.Count}";
            AdditionaltasksCountLabel.Content = $"Задач: {additionalTasks.Count}";
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            AddTaskWindow addTaskWindow = new AddTaskWindow(this);
            addTaskWindow.ShowDialog();
        }

        private void RemoveTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (PersonalTasksListBox.SelectedItem is Task selectedTask)
            {
                personalTasks.Remove(selectedTask);
                UpdateTaskCount();
            }
        }
        public void AddTask(Task task)
        {
            switch (task.Category)
            {
                case "Личные":
                    personalTasks.Add(task);
                    PersonalTasksListBox.ItemsSource = null;
                    PersonalTasksListBox.ItemsSource = personalTasks;
                    break;
                case "Рабочие":
                    workTasks.Add(task);
                    WorktasksListBox.ItemsSource = null;
                    WorktasksListBox.ItemsSource = workTasks;
                    break;
                case "Дополнительные":
                    additionalTasks.Add(task);
                    AdditionaltasksListBox.ItemsSource = null;
                    AdditionaltasksListBox.ItemsSource = additionalTasks;
                    break;
            }
        }

        private void PersonalPriorityComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectesPriority = (PersonalPriorityComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            var filteredTasks = personalTasks.Where(task => task.Priority == selectesPriority).ToList();
            PersonalTasksListBox.ItemsSource = null;
            PersonalTasksListBox.ItemsSource = filteredTasks;
            //string selectedPriority = ((ComboBoxItem)PersonalPriorityComboBox.SelectedItem).Content.ToString();           

            //var filteredTasks = personalTasks.Where(task => task.Priority == selectedPriority).ToList();        

            //PersonalTasksListBox.ItemsSource = filteredTasks;
        }

        private void AdditionaltasksComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectesPriority = (AdditionaltasksComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            var filteredTasks = additionalTasks.Where(task => task.Priority == selectesPriority).ToList();
            AdditionaltasksListBox.ItemsSource = null;
            AdditionaltasksListBox.ItemsSource = filteredTasks;
            //string selectedPriority = ((ComboBoxItem)AdditionaltasksComboBox.SelectedItem).Content.ToString();

            //var filteredTasks = personalTasks.Where(task => task.Priority == selectedPriority).ToList();

            //AdditionaltasksListBox.ItemsSource = filteredTasks;
        }

        private void WorktasksComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectesPriority = (WorktasksComboBox.SelectedItem as ComboBoxItem)?.Content.ToString();
            var filteredTasks = workTasks.Where(task => task.Priority == selectesPriority).ToList();
            WorktasksListBox.ItemsSource = null;
            WorktasksListBox.ItemsSource = filteredTasks;
        }
    }
}
