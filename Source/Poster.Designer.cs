
namespace LoginPage
{
    partial class Poster
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poster));
            this.photo = new System.Windows.Forms.PictureBox();
            this.coursename = new System.Windows.Forms.Label();
            this.startcourse = new System.Windows.Forms.LinkLabel();
            this.btndownload = new Bunifu.Framework.UI.BunifuImageButton();
            this.progressBar = new Telerik.WinControls.UI.RadProgressBar();
            this.fluentTheme1 = new Telerik.WinControls.Themes.FluentTheme();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.coursedescreption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            this.SuspendLayout();
            // 
            // photo
            // 
            this.photo.BackColor = System.Drawing.Color.Transparent;
            this.photo.Image = ((System.Drawing.Image)(resources.GetObject("photo.Image")));
            this.photo.Location = new System.Drawing.Point(53, 50);
            this.photo.Margin = new System.Windows.Forms.Padding(4);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(160, 123);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photo.TabIndex = 0;
            this.photo.TabStop = false;
            // 
            // coursename
            // 
            this.coursename.AutoSize = true;
            this.coursename.BackColor = System.Drawing.Color.Transparent;
            this.coursename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursename.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursename.ForeColor = System.Drawing.Color.Cyan;
            this.coursename.Location = new System.Drawing.Point(227, 50);
            this.coursename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(109, 25);
            this.coursename.TabIndex = 2;
            this.coursename.Text = "OScourse";
            // 
            // startcourse
            // 
            this.startcourse.ActiveLinkColor = System.Drawing.Color.Transparent;
            this.startcourse.AutoSize = true;
            this.startcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startcourse.LinkColor = System.Drawing.Color.Teal;
            this.startcourse.Location = new System.Drawing.Point(227, 130);
            this.startcourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startcourse.Name = "startcourse";
            this.startcourse.Size = new System.Drawing.Size(151, 29);
            this.startcourse.TabIndex = 4;
            this.startcourse.TabStop = true;
            this.startcourse.Text = "StartCourse";
            this.startcourse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.startcourse_LinkClicked);
            // 
            // btndownload
            // 
            this.btndownload.BackColor = System.Drawing.Color.SeaGreen;
            this.btndownload.Image = ((System.Drawing.Image)(resources.GetObject("btndownload.Image")));
            this.btndownload.ImageActive = null;
            this.btndownload.Location = new System.Drawing.Point(392, 134);
            this.btndownload.Margin = new System.Windows.Forms.Padding(4);
            this.btndownload.Name = "btndownload";
            this.btndownload.Size = new System.Drawing.Size(27, 25);
            this.btndownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btndownload.TabIndex = 5;
            this.btndownload.TabStop = false;
            this.btndownload.Zoom = 10;
            this.btndownload.Click += new System.EventHandler(this.btndownload_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(220, 167);
            this.progressBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(199, 30);
            this.progressBar.TabIndex = 6;
            this.progressBar.ThemeName = "FluentDark";
            // 
            // coursedescreption
            // 
            this.coursedescreption.BackColor = System.Drawing.Color.Transparent;
            this.coursedescreption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.coursedescreption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coursedescreption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.coursedescreption.Location = new System.Drawing.Point(228, 75);
            this.coursedescreption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.coursedescreption.Name = "coursedescreption";
            this.coursedescreption.Size = new System.Drawing.Size(428, 57);
            this.coursedescreption.TabIndex = 3;
            this.coursedescreption.Text = "fsgnfjmh nkjghtedsfghn";
            // 
            // Poster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btndownload);
            this.Controls.Add(this.startcourse);
            this.Controls.Add(this.coursedescreption);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.photo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 24, 22);
            this.Name = "Poster";
            this.Size = new System.Drawing.Size(704, 222);
            this.Load += new System.EventHandler(this.Poster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btndownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Label coursename;
        private System.Windows.Forms.LinkLabel startcourse;
        private Bunifu.Framework.UI.BunifuImageButton btndownload;
        private Telerik.WinControls.UI.RadProgressBar progressBar;
        private Telerik.WinControls.Themes.FluentTheme fluentTheme1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private System.Windows.Forms.Label coursedescreption;
    }
}
