
namespace LoginPage
{
    partial class Sign_In
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_In));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.PictureBox();
            this.btnMinimized = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Signuplink = new System.Windows.Forms.LinkLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtExistedUser = new System.Windows.Forms.TextBox();
            this.txtCorrectPassword = new System.Windows.Forms.TextBox();
            this.btnRem = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 548);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(65, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // textuser
            // 
            this.textuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.textuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textuser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textuser.ForeColor = System.Drawing.Color.LightGray;
            this.textuser.Location = new System.Drawing.Point(342, 79);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(408, 25);
            this.textuser.TabIndex = 1;
            this.textuser.Text = "Username";
            this.textuser.TextChanged += new System.EventHandler(this.textuser_TextChanged);
            this.textuser.Enter += new System.EventHandler(this.textuser_Enter);
            this.textuser.Leave += new System.EventHandler(this.textuser_Leave);
            // 
            // textpassword
            // 
            this.textpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.textpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textpassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textpassword.ForeColor = System.Drawing.Color.LightGray;
            this.textpassword.Location = new System.Drawing.Point(342, 142);
            this.textpassword.Name = "textpassword";
            this.textpassword.Size = new System.Drawing.Size(408, 25);
            this.textpassword.TabIndex = 2;
            this.textpassword.Text = "Password";
            this.textpassword.Enter += new System.EventHandler(this.textpassword_Enter);
            this.textpassword.Leave += new System.EventHandler(this.textpassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(470, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.DarkGray;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnlogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnlogin.Location = new System.Drawing.Point(342, 256);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(408, 36);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Log in";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(773, 3);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(20, 20);
            this.btnexit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnexit.TabIndex = 6;
            this.btnexit.TabStop = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnMinimized
            // 
            this.btnMinimized.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimized.Image")));
            this.btnMinimized.Location = new System.Drawing.Point(750, 3);
            this.btnMinimized.Name = "btnMinimized";
            this.btnMinimized.Size = new System.Drawing.Size(20, 20);
            this.btnMinimized.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimized.TabIndex = 7;
            this.btnMinimized.TabStop = false;
            this.btnMinimized.Click += new System.EventHandler(this.btnMinimized_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(342, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(342, 161);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(408, 1);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(314, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(314, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 22);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(386, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Don\'t have an account ?";
            // 
            // Signuplink
            // 
            this.Signuplink.ActiveLinkColor = System.Drawing.Color.LightGray;
            this.Signuplink.AutoSize = true;
            this.Signuplink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Signuplink.ForeColor = System.Drawing.Color.LightGray;
            this.Signuplink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Signuplink.Location = new System.Drawing.Point(594, 307);
            this.Signuplink.Name = "Signuplink";
            this.Signuplink.Size = new System.Drawing.Size(81, 23);
            this.Signuplink.TabIndex = 0;
            this.Signuplink.TabStop = true;
            this.Signuplink.Text = "Sign Up";
            this.Signuplink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Signuplink_LinkClicked);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(730, 141);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 12;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // txtExistedUser
            // 
            this.txtExistedUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.txtExistedUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExistedUser.ForeColor = System.Drawing.Color.Red;
            this.txtExistedUser.Location = new System.Drawing.Point(649, 101);
            this.txtExistedUser.Name = "txtExistedUser";
            this.txtExistedUser.Size = new System.Drawing.Size(101, 15);
            this.txtExistedUser.TabIndex = 20;
            // 
            // txtCorrectPassword
            // 
            this.txtCorrectPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.txtCorrectPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorrectPassword.ForeColor = System.Drawing.Color.Red;
            this.txtCorrectPassword.Location = new System.Drawing.Point(649, 164);
            this.txtCorrectPassword.Name = "txtCorrectPassword";
            this.txtCorrectPassword.Size = new System.Drawing.Size(101, 15);
            this.txtCorrectPassword.TabIndex = 21;
            // 
            // btnRem
            // 
            this.btnRem.AutoSize = true;
            this.btnRem.BackColor = System.Drawing.Color.Transparent;
            this.btnRem.ForeColor = System.Drawing.Color.DarkGray;
            this.btnRem.Location = new System.Drawing.Point(314, 189);
            this.btnRem.Name = "btnRem";
            this.btnRem.Size = new System.Drawing.Size(135, 25);
            this.btnRem.TabIndex = 22;
            this.btnRem.Text = "Remember me";
            this.btnRem.UseVisualStyleBackColor = false;
            this.btnRem.CheckedChanged += new System.EventHandler(this.btnRem_CheckedChanged);
            // 
            // Sign_In
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(848, 548);
            this.Controls.Add(this.btnRem);
            this.Controls.Add(this.txtCorrectPassword);
            this.Controls.Add(this.txtExistedUser);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Signuplink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnMinimized);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpassword);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sign_In";
            this.Opacity = 0.9D;
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RadForm1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RadForm1_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnexit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btnexit;
        private System.Windows.Forms.PictureBox btnMinimized;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel Signuplink;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox txtExistedUser;
        private System.Windows.Forms.TextBox txtCorrectPassword;
        private System.Windows.Forms.CheckBox btnRem;
    }
}