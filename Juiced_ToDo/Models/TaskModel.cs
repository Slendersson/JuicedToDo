using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juiced_ToDo
{
    public class TaskModel
    {
        public TaskModel(uint taskID, uint taskUserID, string taskTitle, DateTime? taskDueDate, bool isTaskCompleted = false)
        {
            this.taskID = taskID;
            this.taskUserID = taskUserID;
            this.taskTitle = taskTitle;
            this.taskDueDate = taskDueDate;
            this.isTaskCompleted = isTaskCompleted;
        }
        public uint taskID;
        public uint taskUserID;
        public string taskTitle;
        public DateTime? taskDueDate;
        public bool isTaskCompleted;

    }
}
