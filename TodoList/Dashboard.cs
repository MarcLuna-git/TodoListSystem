using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListProcess.Business;
using ToDoListProcess.DL;

namespace TodoList
{
    public partial class Dashboard : Form
    {
        private readonly ITaskData taskData = new DbTaskData();
        private readonly ToDoListManager toDoList;
        private readonly string currentUser;

        public Dashboard(string username)
        {
            InitializeComponent();
            currentUser = username;
            toDoList = new ToDoListManager(taskData);
            LoadTasks();
        }
        private void LoadTasks()
        {
            listBoxTasks.Items.Clear();
            var tasks = toDoList.GetTasks(currentUser);
            foreach (var task in tasks)
            {
                listBoxTasks.Items.Add(task.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbSearchBox.Text.Trim();
            if (!string.IsNullOrWhiteSpace(keyword))
            {
                var results = toDoList.SearchTasks(keyword, currentUser);
                listBoxTasks.Items.Clear();
                foreach (var task in results)
                {
                    listBoxTasks.Items.Add(task.ToString());
                }

                if (results.Count == 0)
                    MessageBox.Show("No tasks found.");
            }
            else
            {
                LoadTasks(); 
            }
        }

        private void tbSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully..");
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();

        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                string current = listBoxTasks.SelectedItem.ToString();
                string newDesc = Microsoft.VisualBasic.Interaction.InputBox("Edit task:", "Edit Task", current);

                if (!string.IsNullOrWhiteSpace(newDesc))
                {
                    var result = toDoList.EditTask(listBoxTasks.SelectedIndex, newDesc, currentUser);
                    MessageBox.Show(result == "success" ? "Task updated." : result);
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.");
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    var result = toDoList.DeleteTask(listBoxTasks.SelectedIndex, currentUser);
                    MessageBox.Show(result == "success" ? "Task deleted." : result);
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void btnMarkAsDone_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                var result = toDoList.MarkAsDone(listBoxTasks.SelectedIndex, currentUser);
                MessageBox.Show(result == "success" ? "Task marked as done." : result);
                LoadTasks();
                LoadDoneTasks(); 
            }
            else
            {
                MessageBox.Show("Please select a task to mark as done.");
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            string taskDesc = textbAddTask.Text.Trim();
            if (!string.IsNullOrWhiteSpace(taskDesc))
            {
                var result = toDoList.AddTask(currentUser, taskDesc);
                MessageBox.Show(result == "success" ? "Task added." : result);
                textbAddTask.Clear();
                LoadTasks();
            }
            else
            {
                MessageBox.Show("Task description cannot be empty...");
            }
        }

        private void LoadDoneTasks()
        {
            listBoxMarkAsDone.Items.Clear();

            var tasks = toDoList.GetTaskItems(currentUser);

            foreach (var task in tasks)
            {
                if (task.Task.StartsWith("[√] "))  
                {
                    listBoxMarkAsDone.Items.Add(task.ToString());
                }
            }

            if (listBoxMarkAsDone.Items.Count == 0)
            {
                listBoxMarkAsDone.Items.Add("No completed tasks yet.");
            }
        }



        private void textbAddTask_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBoxMarkAsDone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
