using System.Collections.Generic;
using ToDoListProcess.Common;
using ToDoListProcess.DL;

namespace ToDoListProcess.Business
{
    public class ToDoListManager
    {
        private readonly ITaskData taskData;

        public ToDoListManager(ITaskData taskData)
        {
            this.taskData = taskData;
        }

        public bool AddTask(string username, string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return false;

            taskData.AddTask(username, description);
            return true;
        }

        public bool EditTask(int index, string newDescription, string username)
        {
            var tasks = taskData.GetAllTasks(username);

            if (!IsValidIndex(index, tasks.Count) || string.IsNullOrWhiteSpace(newDescription))
                return false;

            return taskData.EditTask(index, newDescription, username);
        }

        public bool DeleteTask(int index, string username)
        {
            var tasks = taskData.GetAllTasks(username);
            return IsValidIndex(index, tasks.Count) && taskData.DeleteTask(index, username);
        }

        public bool MarkAsDone(int index, string username)
        {
            var tasks = taskData.GetAllTasks(username);
            return IsValidIndex(index, tasks.Count) && taskData.MarkAsDone(index, username);
        }

        public List<TaskItem> GetTasks(string username)
        {
            return GetAllTasks(username);  
        }

        public List<TaskItem> GetAllTasks(string username)
        {
            return taskData.GetAllTasks(username);
        }

        public List<TaskItem> SearchTasks(string keyword, string username)
        {
            return taskData.SearchTasks(keyword, username);
        }

        private bool IsValidIndex(int index, int count)
        {
            return index >= 0 && index < count;
        }
    }
}
