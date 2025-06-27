namespace TodoList
{
    partial class Form1
    {
        
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(307, 83);
            label1.Name = "label1";
            label1.Size = new Size(396, 47);
            label1.TabIndex = 0;
            label1.Text = "TO DO LIST SYSTEM";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(274, 223);
            label2.Name = "label2";
            label2.Size = new Size(146, 27);
            label2.TabIndex = 2;
            label2.Text = "USERNAME:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(272, 283);
            label3.Name = "label3";
            label3.Size = new Size(148, 27);
            label3.TabIndex = 3;
            label3.Text = "PASSWORD:";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(441, 223);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(262, 27);
            tbUsername.TabIndex = 4;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(441, 283);
            tbPassword.Name = "tbPassword";
            tbPassword.PasswordChar = '*';
            tbPassword.Size = new Size(262, 27);
            tbPassword.TabIndex = 5;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightCoral;
            btnLogin.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(363, 352);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(151, 40);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightCoral;
            btnRegister.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(552, 352);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(151, 40);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightCoral;
            btnExit.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(789, 501);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(151, 40);
            btnExit.TabIndex = 8;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(952, 553);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnExit;
    }
}
