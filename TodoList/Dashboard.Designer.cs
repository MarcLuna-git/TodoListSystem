namespace TodoList
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            label1 = new Label();
            btnSearch = new Button();
            tbSearchBox = new TextBox();
            btnLogout = new Button();
            btnAddTask = new Button();
            listBoxTasks = new ListBox();
            btnEditTask = new Button();
            btnDeleteTask = new Button();
            btnMarkAsDone = new Button();
            textbAddTask = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Fax", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 36);
            label1.Name = "label1";
            label1.Size = new Size(443, 36);
            label1.TabIndex = 0;
            label1.Text = "WELCOME TO DASHBOARD";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RosyBrown;
            btnSearch.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(114, 109);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(139, 40);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_Click;
            // 
            // tbSearchBox
            // 
            tbSearchBox.Location = new Point(269, 118);
            tbSearchBox.Name = "tbSearchBox";
            tbSearchBox.Size = new Size(266, 27);
            tbSearchBox.TabIndex = 2;
            tbSearchBox.TextChanged += TbSearchBox_TextChanged;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.RosyBrown;
            btnLogout.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(967, 32);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(139, 40);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.RosyBrown;
            btnAddTask.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTask.Location = new Point(823, 485);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(219, 40);
            btnAddTask.TabIndex = 4;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Click += BtnAddTask_Click;
            // 
            // listBoxTasks
            // 
            listBoxTasks.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxTasks.FormattingEnabled = true;
            listBoxTasks.ItemHeight = 26;
            listBoxTasks.Location = new Point(104, 259);
            listBoxTasks.Name = "listBoxTasks";
            listBoxTasks.Size = new Size(644, 394);
            listBoxTasks.TabIndex = 5;
            listBoxTasks.SelectedIndexChanged += ListBoxTasks_SelectedIndexChanged;
            // 
            // btnEditTask
            // 
            btnEditTask.BackColor = Color.RosyBrown;
            btnEditTask.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditTask.Location = new Point(823, 259);
            btnEditTask.Name = "btnEditTask";
            btnEditTask.Size = new Size(219, 40);
            btnEditTask.TabIndex = 6;
            btnEditTask.Text = "Edit Task";
            btnEditTask.UseVisualStyleBackColor = false;
            btnEditTask.Click += BtnEditTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.RosyBrown;
            btnDeleteTask.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteTask.Location = new Point(823, 336);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(219, 40);
            btnDeleteTask.TabIndex = 7;
            btnDeleteTask.Text = "Delete Task";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += BtnDeleteTask_Click;
            // 
            // btnMarkAsDone
            // 
            btnMarkAsDone.BackColor = Color.RosyBrown;
            btnMarkAsDone.Font = new Font("Lucida Fax", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMarkAsDone.Location = new Point(823, 413);
            btnMarkAsDone.Name = "btnMarkAsDone";
            btnMarkAsDone.Size = new Size(219, 40);
            btnMarkAsDone.TabIndex = 8;
            btnMarkAsDone.Text = "Mark As Done";
            btnMarkAsDone.UseVisualStyleBackColor = false;
            btnMarkAsDone.Click += BtnMarkAsDone_Click;
            // 
            // textbAddTask
            // 
            textbAddTask.Location = new Point(823, 558);
            textbAddTask.Name = "textbAddTask";
            textbAddTask.Size = new Size(219, 27);
            textbAddTask.TabIndex = 9;
            textbAddTask.TextChanged += TextbAddTask_TextChanged;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1178, 736);
            Controls.Add(textbAddTask);
            Controls.Add(btnMarkAsDone);
            Controls.Add(btnDeleteTask);
            Controls.Add(btnEditTask);
            Controls.Add(listBoxTasks);
            Controls.Add(btnAddTask);
            Controls.Add(btnLogout);
            Controls.Add(tbSearchBox);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSearch;
        private TextBox tbSearchBox;
        private Button btnLogout;
        private Button btnAddTask;
        private ListBox listBoxTasks;
        private Button btnEditTask;
        private Button btnDeleteTask;
        private Button btnMarkAsDone;
        private TextBox textbAddTask;
    }
}
