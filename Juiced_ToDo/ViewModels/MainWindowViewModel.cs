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
    public class MainWindowViewModel : ViewModelBase
    {
        public UserViewModel UserVM { get; set; }
        public TaskViewModel TodoVM { get; set; }

        public MainWindowViewModel()
        {
            UserVM = new UserViewModel();
            TodoVM = new TaskViewModel(new Models.UserModel { Id = 0, Name = "Default User" });
        }
    }
}
