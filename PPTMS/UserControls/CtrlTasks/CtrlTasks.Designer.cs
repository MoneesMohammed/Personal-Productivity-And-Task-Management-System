namespace PPTMS.UserControls.CtrlTasks
{
    partial class CtrlTasks
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRecodes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.butAddNewTask = new System.Windows.Forms.Button();
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReminders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAttachments = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInProgressTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOnHoldTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmArchiveTask = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMarkAsCompleted = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddNewTask = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRecodes
            // 
            this.lblRecodes.AutoSize = true;
            this.lblRecodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecodes.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRecodes.Location = new System.Drawing.Point(142, 888);
            this.lblRecodes.Name = "lblRecodes";
            this.lblRecodes.Size = new System.Drawing.Size(49, 29);
            this.lblRecodes.TabIndex = 63;
            this.lblRecodes.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(6, 888);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 62;
            this.label2.Text = "Recordes :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(1056, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Add New Task";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(565, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 39);
            this.label1.TabIndex = 58;
            this.label1.Text = "Tasks";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AllowUserToDeleteRows = false;
            this.dgvTasks.AllowUserToOrderColumns = true;
            this.dgvTasks.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTasks.GridColor = System.Drawing.SystemColors.Menu;
            this.dgvTasks.Location = new System.Drawing.Point(3, 160);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(1162, 711);
            this.dgvTasks.TabIndex = 57;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.tsmEdit,
            this.toolStripSeparator1,
            this.tsmReminders,
            this.tsmAttachments,
            this.toolStripSeparator3,
            this.tsmInProgressTask,
            this.tsmOnHoldTask,
            this.tsmArchiveTask,
            this.tsmMarkAsCompleted,
            this.toolStripSeparator2,
            this.tsmAddNewTask});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(272, 458);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(268, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(268, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(268, 6);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(282, 114);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(135, 28);
            this.cbFilter.TabIndex = 68;
            this.cbFilter.Visible = false;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.Location = new System.Drawing.Point(282, 114);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(234, 29);
            this.txtFilterBy.TabIndex = 67;
            this.txtFilterBy.Visible = false;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Task ID",
            "Title",
            "Category",
            "Status",
            "Priority"});
            this.cbFilterBy.Location = new System.Drawing.Point(116, 114);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(148, 28);
            this.cbFilterBy.TabIndex = 66;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "Filter By :";
            // 
            // pBox1
            // 
            this.pBox1.Image = global::PPTMS.Properties.Resources.task1;
            this.pBox1.Location = new System.Drawing.Point(443, 0);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(116, 96);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox1.TabIndex = 60;
            this.pBox1.TabStop = false;
            // 
            // butAddNewTask
            // 
            this.butAddNewTask.BackColor = System.Drawing.Color.Transparent;
            this.butAddNewTask.FlatAppearance.BorderSize = 0;
            this.butAddNewTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddNewTask.Image = global::PPTMS.Properties.Resources.tab;
            this.butAddNewTask.Location = new System.Drawing.Point(1068, 28);
            this.butAddNewTask.Name = "butAddNewTask";
            this.butAddNewTask.Size = new System.Drawing.Size(73, 75);
            this.butAddNewTask.TabIndex = 59;
            this.butAddNewTask.UseVisualStyleBackColor = false;
            this.butAddNewTask.Click += new System.EventHandler(this.AddNewTask_Click);
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Image = global::PPTMS.Properties.Resources.list;
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(271, 46);
            this.tsmShowDetails.Text = "Show Details";
            this.tsmShowDetails.Click += new System.EventHandler(this.tsmShowDetails_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Image = global::PPTMS.Properties.Resources.clipboard;
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(271, 46);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmReminders
            // 
            this.tsmReminders.Image = global::PPTMS.Properties.Resources.reminder;
            this.tsmReminders.Name = "tsmReminders";
            this.tsmReminders.Size = new System.Drawing.Size(271, 46);
            this.tsmReminders.Text = "Reminders";
            this.tsmReminders.Click += new System.EventHandler(this.tsmReminders_Click);
            // 
            // tsmAttachments
            // 
            this.tsmAttachments.Image = global::PPTMS.Properties.Resources.attached;
            this.tsmAttachments.Name = "tsmAttachments";
            this.tsmAttachments.Size = new System.Drawing.Size(271, 46);
            this.tsmAttachments.Text = "Attachments";
            this.tsmAttachments.Click += new System.EventHandler(this.tsmAttachments_Click);
            // 
            // tsmInProgressTask
            // 
            this.tsmInProgressTask.Image = global::PPTMS.Properties.Resources.settings;
            this.tsmInProgressTask.Name = "tsmInProgressTask";
            this.tsmInProgressTask.Size = new System.Drawing.Size(271, 46);
            this.tsmInProgressTask.Text = "In Progress Task";
            this.tsmInProgressTask.Click += new System.EventHandler(this.tsmInProgressTask_Click);
            // 
            // tsmOnHoldTask
            // 
            this.tsmOnHoldTask.Image = global::PPTMS.Properties.Resources.stop;
            this.tsmOnHoldTask.Name = "tsmOnHoldTask";
            this.tsmOnHoldTask.Size = new System.Drawing.Size(271, 46);
            this.tsmOnHoldTask.Text = "On Hold Task";
            this.tsmOnHoldTask.Click += new System.EventHandler(this.tsmOnHoldTask_Click);
            // 
            // tsmArchiveTask
            // 
            this.tsmArchiveTask.Image = global::PPTMS.Properties.Resources.archive;
            this.tsmArchiveTask.Name = "tsmArchiveTask";
            this.tsmArchiveTask.Size = new System.Drawing.Size(271, 46);
            this.tsmArchiveTask.Text = "Archive Task";
            this.tsmArchiveTask.Click += new System.EventHandler(this.tsmArchiveTask_Click);
            // 
            // tsmMarkAsCompleted
            // 
            this.tsmMarkAsCompleted.Image = global::PPTMS.Properties.Resources.test1;
            this.tsmMarkAsCompleted.Name = "tsmMarkAsCompleted";
            this.tsmMarkAsCompleted.Size = new System.Drawing.Size(271, 46);
            this.tsmMarkAsCompleted.Text = "Mark as Completed";
            this.tsmMarkAsCompleted.Click += new System.EventHandler(this.tsmMarkAsCompleted_Click);
            // 
            // tsmAddNewTask
            // 
            this.tsmAddNewTask.Image = global::PPTMS.Properties.Resources.tab;
            this.tsmAddNewTask.Name = "tsmAddNewTask";
            this.tsmAddNewTask.Size = new System.Drawing.Size(271, 46);
            this.tsmAddNewTask.Text = "Add New Task";
            this.tsmAddNewTask.Click += new System.EventHandler(this.AddNewTask_Click);
            // 
            // CtrlTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblRecodes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.butAddNewTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTasks);
            this.Name = "CtrlTasks";
            this.Size = new System.Drawing.Size(1168, 935);
            this.Load += new System.EventHandler(this.CtrlTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Button butAddNewTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewTask;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmArchiveTask;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmMarkAsCompleted;
        private System.Windows.Forms.ToolStripMenuItem tsmReminders;
        private System.Windows.Forms.ToolStripMenuItem tsmAttachments;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem tsmInProgressTask;
        private System.Windows.Forms.ToolStripMenuItem tsmOnHoldTask;
    }
}
