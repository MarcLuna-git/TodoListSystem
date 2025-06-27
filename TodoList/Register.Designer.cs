namespace TodoList
{
    partial class Register
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbUsername = new TextBox();
            textBox1 = new TextBox();
            btnRegister = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Stencil", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(375, 58);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(217, 47);
            label1.TabIndex = 1;
            label1.Text = "REGISTER";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(237, 195);
            label2.Name = "label2";
            label2.Size = new Size(229, 27);
            label2.TabIndex = 3;
            label2.Text = "ENTER USERNAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(237, 264);
            label3.Name = "label3";
            label3.Size = new Size(231, 27);
            label3.TabIndex = 4;
            label3.Text = "ENTER PASSWORD:";
            label3.Click += label3_Click;
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(486, 197);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(262, 27);
            tbUsername.TabIndex = 5;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(486, 264);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 27);
            textBox1.TabIndex = 6;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.LightCoral;
            btnRegister.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(317, 330);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(151, 40);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightCoral;
            btnLogin.Font = new Font("Stencil", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(545, 330);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(151, 40);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "BACK TO LOGIN";
            btnLogin.TextAlign = ContentAlignment.MiddleRight;
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(952, 553);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(textBox1);
            Controls.Add(tbUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbUsername;
        private TextBox textBox1;
        private Button btnRegister;
        private Button btnLogin;
    }
}