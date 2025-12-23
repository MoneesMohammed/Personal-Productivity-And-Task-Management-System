namespace PPTMS
{
    partial class frmMain
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnCategories = new System.Windows.Forms.Button();
            this.btnHabits = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.butLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelSidebar.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelSidebar.Controls.Add(this.btnCategories);
            this.panelSidebar.Controls.Add(this.btnHabits);
            this.panelSidebar.Controls.Add(this.label1);
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Controls.Add(this.btnStatistics);
            this.panelSidebar.Controls.Add(this.btnTask);
            this.panelSidebar.Controls.Add(this.butLogout);
            this.panelSidebar.Controls.Add(this.btnProfile);
            this.panelSidebar.Controls.Add(this.btnHome);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(352, 947);
            this.panelSidebar.TabIndex = 7;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 80);
            this.label1.TabIndex = 15;
            this.label1.Text = "Personal Productivity And Task Management System";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelSidebar);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1585, 947);
            this.panelMain.TabIndex = 14;
            // 
            // panelContent
            // 
            this.panelContent.Location = new System.Drawing.Point(355, 3);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(1227, 941);
            this.panelContent.TabIndex = 8;
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.Transparent;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategories.ForeColor = System.Drawing.Color.White;
            this.btnCategories.Image = global::PPTMS.Properties.Resources.Categories;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.Location = new System.Drawing.Point(11, 262);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(338, 61);
            this.btnCategories.TabIndex = 17;
            this.btnCategories.Text = "Categories";
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnCategories.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnHabits
            // 
            this.btnHabits.BackColor = System.Drawing.Color.Transparent;
            this.btnHabits.FlatAppearance.BorderSize = 0;
            this.btnHabits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabits.ForeColor = System.Drawing.Color.White;
            this.btnHabits.Image = global::PPTMS.Properties.Resources.Habits;
            this.btnHabits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHabits.Location = new System.Drawing.Point(11, 330);
            this.btnHabits.Name = "btnHabits";
            this.btnHabits.Size = new System.Drawing.Size(338, 61);
            this.btnHabits.TabIndex = 16;
            this.btnHabits.Text = "Habits";
            this.btnHabits.UseVisualStyleBackColor = false;
            this.btnHabits.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnHabits.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::PPTMS.Properties.Resources.effective_1_;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistics.ForeColor = System.Drawing.Color.White;
            this.btnStatistics.Image = global::PPTMS.Properties.Resources.Statistics;
            this.btnStatistics.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistics.Location = new System.Drawing.Point(11, 398);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(338, 61);
            this.btnStatistics.TabIndex = 13;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            this.btnStatistics.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnStatistics.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnTask
            // 
            this.btnTask.BackColor = System.Drawing.Color.Transparent;
            this.btnTask.FlatAppearance.BorderSize = 0;
            this.btnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask.ForeColor = System.Drawing.Color.White;
            this.btnTask.Image = global::PPTMS.Properties.Resources.task;
            this.btnTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.Location = new System.Drawing.Point(11, 194);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(338, 61);
            this.btnTask.TabIndex = 12;
            this.btnTask.Text = "Task";
            this.btnTask.UseVisualStyleBackColor = false;
            this.btnTask.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnTask.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // butLogout
            // 
            this.butLogout.BackColor = System.Drawing.Color.Transparent;
            this.butLogout.FlatAppearance.BorderSize = 0;
            this.butLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogout.ForeColor = System.Drawing.Color.White;
            this.butLogout.Image = global::PPTMS.Properties.Resources.Logout;
            this.butLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butLogout.Location = new System.Drawing.Point(11, 534);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(338, 61);
            this.butLogout.TabIndex = 11;
            this.butLogout.Text = "Logout";
            this.butLogout.UseVisualStyleBackColor = false;
            this.butLogout.Click += new System.EventHandler(this.butLogout_Click);
            this.butLogout.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.butLogout.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = global::PPTMS.Properties.Resources.Profile;
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(11, 466);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(338, 61);
            this.btnProfile.TabIndex = 9;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnProfile.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = global::PPTMS.Properties.Resources.home;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(11, 126);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(338, 61);
            this.btnHome.TabIndex = 8;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            this.btnHome.MouseLeave += new System.EventHandler(this.btn_MouseLeave);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 947);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            this.panelSidebar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button butLogout;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCategories;
        private System.Windows.Forms.Button btnHabits;
        private System.Windows.Forms.Panel panelContent;
    }
}

