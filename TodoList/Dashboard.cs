using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ToDoListProcess.Business;
using ToDoListProcess.Common;
using ToDoListProcess.DL;

namespace TodoList
{
    public partial class Dashboard : Form
    {
        private readonly ToDoListManager toDoManager;
        private readonly string currentUser;

        public Dashboard(string username)
        {
            InitializeComponent();
            currentUser = username;
            toDoManager = new ToDoListManager(new DbTaskData());
            LoadTasks();
        }

        private void LoadTasks()
        {
            listBoxTasks.Items.Clear();
            var tasks = toDoManager.GetAllTasks(currentUser);
            foreach (var task in tasks)
            {
                listBoxTasks.Items.Add(task.Task + "  |  Added: " + task.DateAndTime.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }

        private void BtnAddTask_Click(object sender, EventArgs e)
        {
            string taskDesc = textbAddTask.Text.Trim();
            if (!string.IsNullOrWhiteSpace(taskDesc))
            {
                bool success = toDoManager.AddTask(currentUser, taskDesc);
                if (success)
                {
                    MessageBox.Show("Task added.");
                    textbAddTask.Clear();
                    LoadTasks();
                }
                else
                {
                    MessageBox.Show("Failed to add task.");
                }
            }
            else
            {
                MessageBox.Show("Task description cannot be empty.");
            }
        }

        private void BtnEditTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                string currentTask = listBoxTasks.SelectedItem.ToString();
                string newDesc = Microsoft.VisualBasic.Interaction.InputBox("Edit task:", "Edit Task", currentTask);
                if (!string.IsNullOrWhiteSpace(newDesc))
                {
                    bool success = toDoManager.EditTask(listBoxTasks.SelectedIndex, newDesc, currentUser);
                    if (success)
                    {
                        MessageBox.Show("Task updated.");
                        LoadTasks();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update task.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.");
            }
        }

        private void BtnDeleteTask_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this task?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    bool success = toDoManager.DeleteTask(listBoxTasks.SelectedIndex, currentUser);
                    if (success)
                    {
                        MessageBox.Show("Task deleted.");
                        LoadTasks();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete task.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.");
            }
        }

        private void BtnMarkAsDone_Click(object sender, EventArgs e)
        {
            if (listBoxTasks.SelectedIndex >= 0)
            {
                bool success = toDoManager.MarkAsDone(listBoxTasks.SelectedIndex, currentUser);
                if (success)
                {
                    MessageBox.Show("Task marked as done.");
                    LoadTasks();
                }
                else
                {
                    MessageBox.Show("Failed to mark task as done.");
                }
            }
            else
            {
                MessageBox.Show("Please select a task to mark as done.");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = tbSearchBox.Text.Trim();
            listBoxTasks.Items.Clear();
            var results = toDoManager.SearchTasks(keyword, currentUser);
            if (results.Count == 0)
            {
                MessageBox.Show("No tasks found.");
            }
            else
            {
                foreach (var task in results)
                {
                    listBoxTasks.Items.Add(task.Task + "  |  Added: " + task.DateAndTime.ToString("yyyy-MM-dd HH:mm:ss"));
                }
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged out successfully.");
            this.Hide();
            Form1 loginForm = new Form1();
            loginForm.Show();
        }

        private void TbSearchBox_TextChanged(object sender, EventArgs e) { }
        private void ListBoxTasks_SelectedIndexChanged(object sender, EventArgs e) { }
        private void TextbAddTask_TextChanged(object sender, EventArgs e) { }
        private void ListBoxMarkAsDone_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}
