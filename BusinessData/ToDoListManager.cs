using System.Collections.Generic;
using ToDoListProcess.Common;
using ToDoListProcess.DL;

namespace ToDoListProcess.Business //dito is taskmanager sya and ang work nya is middle man of ui layer and data logic like validations 
{
    public class ToDoListManager
    {
        private readonly ITaskData taskData;

        public ToDoListManager(ITaskData taskData)
        {
            this.taskData = taskData;
        }

        public List<string> GetTasks(string username)
        {
            var tasks = taskData.GetAllTasks(username);
            var list = new List<string>();

            foreach (var task in tasks)
            {
                list.Add($"{task.Task} ({task.DateAndTime:yyyy-MM-dd HH:mm:ss})");
            }

            return list;
        }

        public string AddTask(string username, string description)
        {
            if (string.IsNullOrWhiteSpace(description))
                return "Please enter a valid description.";

            taskData.AddTask(username, description);
            return "Task added.";
        }

        public string EditTask(int index, string newDescription, string username)
        {
            var tasks = taskData.GetAllTasks(username);

            if (!IsValidIndex(index, tasks.Count))
                return "Task number is out of range.";

            if (string.IsNullOrWhiteSpace(newDescription))
                return "Description cannot be empty.";

            return taskData.EditTask(index, newDescription, username)
                ? "Task updated."
                : "Something went wrong while updating.";
        }

        public string DeleteTask(int index, string username)
        {
            var tasks = taskData.GetAllTasks(username);

            if (!IsValidIndex(index, tasks.Count))
                return "Task number is out of range.";

            return taskData.DeleteTask(index, username)
                ? "Task deleted."
                : "Failed to delete task.";
        }

        public string MarkAsDone(int index, string username)
        {
            var tasks = taskData.GetAllTasks(username);

            if (!IsValidIndex(index, tasks.Count))
                return "Task number is out of range.";

            return taskData.MarkAsDone(index, username)
                ? "Task marked as done."
                : "Unable to mark task.";
        }

        public List<string> SearchTasks(string keyword, string username)
        {
            var matches = taskData.SearchTasks(keyword, username);
            var result = new List<string>();

            foreach (var task in matches)
            {
                result.Add($"{task.Task} ({task.DateAndTime:yyyy-MM-dd HH:mm:ss})");
            }

            return result;
        }

        public List<TaskItem> GetTaskItems(string username)
        {
            return taskData.GetAllTasks(username);
        }

        private bool IsValidIndex(int index, int count)
        {
            return index >= 0 && index < count;
        }
    }
}
