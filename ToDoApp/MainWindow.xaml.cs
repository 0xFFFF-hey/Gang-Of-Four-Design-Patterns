using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly TaskManager _taskManager;
        private readonly CommandInvoker _commandInvoker;

        public MainWindow()
        {
            InitializeComponent();

            _taskManager = new TaskManager();
            _commandInvoker = new CommandInvoker();

            var logger = new TaskLogger(message => LogBox.AppendText(message + "\n"));
            _taskManager.AddObserver(logger);
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var task = TaskInput.Text;
            if (string.IsNullOrWhiteSpace(task)) return;

            var command = new AddTaskCommand(_taskManager, task);
            _commandInvoker.ExecuteCommand(command);

            UpdateTaskList();
            TaskInput.Clear();
        }

        private void UndoButton_Click(object sender, RoutedEventArgs e)
        {
            _commandInvoker.UndoLastCommand();
            UpdateTaskList();
        }

        private void UpdateTaskList()
        {
            TaskList.ItemsSource = null;
            TaskList.ItemsSource = _taskManager.GetTasks();
        }
    }
}