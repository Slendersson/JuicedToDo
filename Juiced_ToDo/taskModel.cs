using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juiced_ToDo
{
    public class taskModel
    {
        private uint taskId;
        private int taskUserId;
        private string taskTitle;
        private string taskDescription;
        private DateTime? taskDueDate;
        private bool isTaskCompleted;

        public taskModel(uint taskId, int taskUserId, string taskTitle, string taskDescription, DateTime? taskDueDate, bool isTaskCompleted)
        {
            this.taskId = taskId;
            this.taskUserId = taskUserId;
            this.taskTitle = taskTitle;
            this.taskDescription = taskDescription;
            this.taskDueDate = taskDueDate;
            this.isTaskCompleted = false;
        }

        public void setTaskId(uint taskId)
        {
            this.taskId = taskId;
        }

        public void setTaskUserId(int taskUserId)
        {
            this.taskUserId = taskUserId;
        }

        public void setTaskTitle(string taskTitle)
        {
            this.taskTitle = taskTitle;
        }

        public void setTaskDescription(string taskDescription)
        {
            this.taskDescription = taskDescription;
        }
        public void setTaskDueDate(DateTime? taskDueDate)
        {
            this.taskDueDate = taskDueDate;
        }

        public void setIsTaskCompleted(bool isTaskCompleted)
        {
            this.isTaskCompleted = isTaskCompleted;
        }
        public uint getTaskId()
        {
            return taskId;
        }
        public int getTaskUserId()
        {
            return taskUserId;
        }
        public string getTaskTitle()
        {
            return taskTitle;
        }
        public string getTaskDescription()
        {
            return taskDescription;
        }
        public DateTime? getTaskDueDate()
        {
            return taskDueDate;
        }
        public bool getIsTaskCompleted()
        {
            return isTaskCompleted;
        }

    }
}
