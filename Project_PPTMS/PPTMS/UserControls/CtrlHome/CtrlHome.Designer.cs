namespace PPTMS.UserControls.CtrlHome
{
    partial class CtrlHome
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblToday = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMessHaveTasks = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblInsight = new System.Windows.Forms.Label();
            this.lblGreetingMessage = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDueToday = new System.Windows.Forms.Label();
            this.lblActiveHabits = new System.Windows.Forms.Label();
            this.lblTotalTasks = new System.Windows.Forms.Label();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.dgvTodayTasks = new System.Windows.Forms.DataGridView();
            this.dgvCheckInHabitsToday = new System.Windows.Forms.DataGridView();
            this.lblMessCheckInHabits = new System.Windows.Forms.Label();
            this.lblMessNoTasks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInHabitsToday)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(8)))), ((int)(((byte)(73)))));
            this.lblTitle.Location = new System.Drawing.Point(477, 99);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 39);
            this.lblTitle.TabIndex = 72;
            this.lblTitle.Text = "Home";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.lblTitle_Paint);
            // 
            // pBox1
            // 
            this.pBox1.Image = global::PPTMS.Properties.Resources.home_5;
            this.pBox1.Location = new System.Drawing.Point(471, 0);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(116, 96);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox1.TabIndex = 73;
            this.pBox1.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(36, 37);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(229, 29);
            this.lblWelcome.TabIndex = 74;
            this.lblWelcome.Text = "👋 Welcome Ahmed";
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.Location = new System.Drawing.Point(36, 82);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(349, 29);
            this.lblToday.TabIndex = 75;
            this.lblToday.Text = "Today is Tuesday, 30 Dec 2026";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Completed Tasks";
            // 
            // lblMessHaveTasks
            // 
            this.lblMessHaveTasks.AutoSize = true;
            this.lblMessHaveTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessHaveTasks.Location = new System.Drawing.Point(762, 76);
            this.lblMessHaveTasks.Name = "lblMessHaveTasks";
            this.lblMessHaveTasks.Size = new System.Drawing.Size(304, 29);
            this.lblMessHaveTasks.TabIndex = 76;
            this.lblMessHaveTasks.Text = "You have 3 tasks due today";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(588, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 25);
            this.label5.TabIndex = 79;
            this.label5.Text = "Active Habits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(158, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 25);
            this.label6.TabIndex = 78;
            this.label6.Text = "Total Tasks";
            // 
            // lblInsight
            // 
            this.lblInsight.AutoSize = true;
            this.lblInsight.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsight.Location = new System.Drawing.Point(345, 736);
            this.lblInsight.Name = "lblInsight";
            this.lblInsight.Size = new System.Drawing.Size(424, 25);
            this.lblInsight.TabIndex = 81;
            this.lblInsight.Text = "You complete more tasks in the evening 🌙";
            // 
            // lblGreetingMessage
            // 
            this.lblGreetingMessage.AutoSize = true;
            this.lblGreetingMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreetingMessage.Location = new System.Drawing.Point(762, 37);
            this.lblGreetingMessage.Name = "lblGreetingMessage";
            this.lblGreetingMessage.Size = new System.Drawing.Size(198, 29);
            this.lblGreetingMessage.TabIndex = 80;
            this.lblGreetingMessage.Text = "Good Evening 🌙";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(158, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 25);
            this.label9.TabIndex = 83;
            this.label9.Text = "Due Today";
            // 
            // lblDueToday
            // 
            this.lblDueToday.AutoSize = true;
            this.lblDueToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueToday.Location = new System.Drawing.Point(302, 215);
            this.lblDueToday.Name = "lblDueToday";
            this.lblDueToday.Size = new System.Drawing.Size(31, 29);
            this.lblDueToday.TabIndex = 87;
            this.lblDueToday.Text = "--";
            // 
            // lblActiveHabits
            // 
            this.lblActiveHabits.AutoSize = true;
            this.lblActiveHabits.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveHabits.Location = new System.Drawing.Point(738, 215);
            this.lblActiveHabits.Name = "lblActiveHabits";
            this.lblActiveHabits.Size = new System.Drawing.Size(31, 29);
            this.lblActiveHabits.TabIndex = 86;
            this.lblActiveHabits.Text = "--";
            // 
            // lblTotalTasks
            // 
            this.lblTotalTasks.AutoSize = true;
            this.lblTotalTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTasks.Location = new System.Drawing.Point(302, 180);
            this.lblTotalTasks.Name = "lblTotalTasks";
            this.lblTotalTasks.Size = new System.Drawing.Size(31, 29);
            this.lblTotalTasks.TabIndex = 85;
            this.lblTotalTasks.Text = "--";
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.Location = new System.Drawing.Point(738, 180);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(31, 29);
            this.lblCompleted.TabIndex = 84;
            this.lblCompleted.Text = "--";
            // 
            // dgvTodayTasks
            // 
            this.dgvTodayTasks.AllowUserToAddRows = false;
            this.dgvTodayTasks.AllowUserToDeleteRows = false;
            this.dgvTodayTasks.AllowUserToOrderColumns = true;
            this.dgvTodayTasks.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodayTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTodayTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTodayTasks.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvTodayTasks.GridColor = System.Drawing.SystemColors.Menu;
            this.dgvTodayTasks.Location = new System.Drawing.Point(41, 303);
            this.dgvTodayTasks.Name = "dgvTodayTasks";
            this.dgvTodayTasks.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTodayTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTodayTasks.RowHeadersVisible = false;
            this.dgvTodayTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTodayTasks.Size = new System.Drawing.Size(439, 318);
            this.dgvTodayTasks.TabIndex = 88;
            // 
            // dgvCheckInHabitsToday
            // 
            this.dgvCheckInHabitsToday.AllowUserToAddRows = false;
            this.dgvCheckInHabitsToday.AllowUserToDeleteRows = false;
            this.dgvCheckInHabitsToday.AllowUserToOrderColumns = true;
            this.dgvCheckInHabitsToday.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckInHabitsToday.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvCheckInHabitsToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckInHabitsToday.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvCheckInHabitsToday.GridColor = System.Drawing.SystemColors.Menu;
            this.dgvCheckInHabitsToday.Location = new System.Drawing.Point(525, 303);
            this.dgvCheckInHabitsToday.Name = "dgvCheckInHabitsToday";
            this.dgvCheckInHabitsToday.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckInHabitsToday.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCheckInHabitsToday.RowHeadersVisible = false;
            this.dgvCheckInHabitsToday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCheckInHabitsToday.Size = new System.Drawing.Size(623, 318);
            this.dgvCheckInHabitsToday.TabIndex = 89;
            // 
            // lblMessCheckInHabits
            // 
            this.lblMessCheckInHabits.AutoSize = true;
            this.lblMessCheckInHabits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessCheckInHabits.Location = new System.Drawing.Point(709, 634);
            this.lblMessCheckInHabits.Name = "lblMessCheckInHabits";
            this.lblMessCheckInHabits.Size = new System.Drawing.Size(199, 25);
            this.lblMessCheckInHabits.TabIndex = 90;
            this.lblMessCheckInHabits.Text = "There are no habits";
            this.lblMessCheckInHabits.Visible = false;
            // 
            // lblMessNoTasks
            // 
            this.lblMessNoTasks.AutoSize = true;
            this.lblMessNoTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessNoTasks.Location = new System.Drawing.Point(126, 634);
            this.lblMessNoTasks.Name = "lblMessNoTasks";
            this.lblMessNoTasks.Size = new System.Drawing.Size(214, 25);
            this.lblMessNoTasks.TabIndex = 91;
            this.lblMessNoTasks.Text = "🎉 No tasks for today";
            this.lblMessNoTasks.Visible = false;
            // 
            // CtrlHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMessNoTasks);
            this.Controls.Add(this.lblMessCheckInHabits);
            this.Controls.Add(this.dgvCheckInHabitsToday);
            this.Controls.Add(this.dgvTodayTasks);
            this.Controls.Add(this.lblDueToday);
            this.Controls.Add(this.lblActiveHabits);
            this.Controls.Add(this.lblTotalTasks);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblInsight);
            this.Controls.Add(this.lblGreetingMessage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMessHaveTasks);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.lblTitle);
            this.Name = "CtrlHome";
            this.Size = new System.Drawing.Size(1168, 935);
            this.Load += new System.EventHandler(this.CtrlHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckInHabitsToday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMessHaveTasks;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblInsight;
        private System.Windows.Forms.Label lblGreetingMessage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDueToday;
        private System.Windows.Forms.Label lblActiveHabits;
        private System.Windows.Forms.Label lblTotalTasks;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.DataGridView dgvTodayTasks;
        private System.Windows.Forms.DataGridView dgvCheckInHabitsToday;
        private System.Windows.Forms.Label lblMessCheckInHabits;
        private System.Windows.Forms.Label lblMessNoTasks;
    }
}
