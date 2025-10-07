using Juiced_ToDo.Commands;
using Juiced_ToDo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Juiced_ToDo.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        private string _newTaskDescription;
        public ObservableCollection<TaskModel> Tasks { get; set; }
        public UserModel SelectedUser { get; set; }

        public string NewTaskDescription
        {
            get => _newTaskDescription;
            set { _newTaskDescription = value; OnPropertyChanged("newTaskDescription"); }
        }

        public TaskModel SelectedTask { get; set; }

        public ICommand AddTaskCommand { get; }
        public ICommand DeleteTaskCommand { get; }
        public ICommand EditTaskCommand { get; }

        public TaskViewModel(UserModel user)
        {
            SelectedUser = user;
            Tasks = new ObservableCollection<TaskModel>();
            AddTaskCommand = new RelayCommand(_ => AddTask());
            DeleteTaskCommand = new RelayCommand(_ => DeleteTask(), _ => SelectedTask != null);
            EditTaskCommand = new RelayCommand(_ => EditTask(), _ => SelectedTask != null);
        }

        private void AddTask()
        {
            if (!string.IsNullOrWhiteSpace(NewTaskDescription))
            {
                Tasks.Add(new TaskModel
                {
                    taskID = 0,
                    taskName = NewTaskDescription,
                });
                NewTaskDescription = string.Empty;
            }
        }

        private void DeleteTask()
        {
            if (SelectedTask != null)
                Tasks.Remove(SelectedTask);
        }

        private void EditTask()
        {
            // Example: toggling completion
            SelectedTask.isTaskCompleted = !SelectedTask.IsCompleted;
            OnPropertyChanged(nameof(Tasks));
        }
    }
}
