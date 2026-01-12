namespace PPTMS.UserControls.CtrlHabit
{
    partial class CtrlHabits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlHabits));
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecodes = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHabits = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmViewProgress = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUndoCheckIn = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmActivateAndDeactivate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmArchiveHabit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAddNewHabit = new System.Windows.Forms.ToolStripMenuItem();
            this.pBox1 = new System.Windows.Forms.PictureBox();
            this.butAddNewHabit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabits)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.SystemColors.Window;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(279, 117);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(135, 28);
            this.cbFilter.TabIndex = 76;
            this.cbFilter.Visible = false;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.Location = new System.Drawing.Point(279, 117);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(234, 29);
            this.txtFilterBy.TabIndex = 75;
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
            "Habit ID",
            "Name",
            "Frequency",
            "Is Active",
            "Archived"});
            this.cbFilterBy.Location = new System.Drawing.Point(113, 117);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(148, 28);
            this.cbFilterBy.TabIndex = 74;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 73;
            this.label3.Text = "Filter By :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(936, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "Add New Habit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(562, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 39);
            this.label1.TabIndex = 69;
            this.label1.Text = "Habits";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRecodes
            // 
            this.lblRecodes.AutoSize = true;
            this.lblRecodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecodes.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRecodes.Location = new System.Drawing.Point(145, 879);
            this.lblRecodes.Name = "lblRecodes";
            this.lblRecodes.Size = new System.Drawing.Size(49, 29);
            this.lblRecodes.TabIndex = 79;
            this.lblRecodes.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(9, 879);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 78;
            this.label2.Text = "Recordes :";
            // 
            // dgvHabits
            // 
            this.dgvHabits.AllowUserToAddRows = false;
            this.dgvHabits.AllowUserToDeleteRows = false;
            this.dgvHabits.AllowUserToOrderColumns = true;
            this.dgvHabits.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHabits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHabits.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHabits.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHabits.GridColor = System.Drawing.SystemColors.Menu;
            this.dgvHabits.Location = new System.Drawing.Point(113, 167);
            this.dgvHabits.Name = "dgvHabits";
            this.dgvHabits.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHabits.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHabits.RowHeadersVisible = false;
            this.dgvHabits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHabits.Size = new System.Drawing.Size(923, 696);
            this.dgvHabits.TabIndex = 77;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDetails,
            this.tsmEdit,
            this.tsmViewProgress,
            this.toolStripSeparator3,
            this.tsmCheckIn,
            this.tsmUndoCheckIn,
            this.toolStripSeparator1,
            this.tsmActivateAndDeactivate,
            this.tsmArchiveHabit,
            this.toolStripSeparator2,
            this.tsmAddNewHabit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 390);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(232, 6);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // tsmShowDetails
            // 
            this.tsmShowDetails.Image = global::PPTMS.Properties.Resources.info;
            this.tsmShowDetails.Name = "tsmShowDetails";
            this.tsmShowDetails.Size = new System.Drawing.Size(235, 46);
            this.tsmShowDetails.Text = "Show Details";
            this.tsmShowDetails.Click += new System.EventHandler(this.tsmShowDetails_Click);
            // 
            // tsmEdit
            // 
            this.tsmEdit.Image = global::PPTMS.Properties.Resources.pen;
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(235, 46);
            this.tsmEdit.Text = "Edit";
            this.tsmEdit.Click += new System.EventHandler(this.tsmEdit_Click);
            // 
            // tsmViewProgress
            // 
            this.tsmViewProgress.Image = global::PPTMS.Properties.Resources.progress;
            this.tsmViewProgress.Name = "tsmViewProgress";
            this.tsmViewProgress.Size = new System.Drawing.Size(235, 46);
            this.tsmViewProgress.Text = "View Progress";
            this.tsmViewProgress.Click += new System.EventHandler(this.tsmViewProgress_Click);
            // 
            // tsmCheckIn
            // 
            this.tsmCheckIn.Image = ((System.Drawing.Image)(resources.GetObject("tsmCheckIn.Image")));
            this.tsmCheckIn.Name = "tsmCheckIn";
            this.tsmCheckIn.Size = new System.Drawing.Size(235, 46);
            this.tsmCheckIn.Text = "Check-in";
            this.tsmCheckIn.Click += new System.EventHandler(this.tsmCheckIn_Click);
            // 
            // tsmUndoCheckIn
            // 
            this.tsmUndoCheckIn.Image = global::PPTMS.Properties.Resources._return;
            this.tsmUndoCheckIn.Name = "tsmUndoCheckIn";
            this.tsmUndoCheckIn.Size = new System.Drawing.Size(235, 46);
            this.tsmUndoCheckIn.Text = "Undo Check-in";
            this.tsmUndoCheckIn.Click += new System.EventHandler(this.tsmUndoCheckIn_Click);
            // 
            // tsmActivateAndDeactivate
            // 
            this.tsmActivateAndDeactivate.Image = global::PPTMS.Properties.Resources.switch_off;
            this.tsmActivateAndDeactivate.Name = "tsmActivateAndDeactivate";
            this.tsmActivateAndDeactivate.Size = new System.Drawing.Size(235, 46);
            this.tsmActivateAndDeactivate.Text = "Deactivate";
            this.tsmActivateAndDeactivate.Click += new System.EventHandler(this.tsmActivateAndDeactivate_Click);
            // 
            // tsmArchiveHabit
            // 
            this.tsmArchiveHabit.Image = global::PPTMS.Properties.Resources.inbox;
            this.tsmArchiveHabit.Name = "tsmArchiveHabit";
            this.tsmArchiveHabit.Size = new System.Drawing.Size(235, 46);
            this.tsmArchiveHabit.Text = "Archive Habit";
            this.tsmArchiveHabit.Click += new System.EventHandler(this.tsmArchiveHabit_Click);
            // 
            // tsmAddNewHabit
            // 
            this.tsmAddNewHabit.Image = global::PPTMS.Properties.Resources.mental_health__1_;
            this.tsmAddNewHabit.Name = "tsmAddNewHabit";
            this.tsmAddNewHabit.Size = new System.Drawing.Size(235, 46);
            this.tsmAddNewHabit.Text = "Add New Habit";
            this.tsmAddNewHabit.Click += new System.EventHandler(this.AddNewHabit_Click);
            // 
            // pBox1
            // 
            this.pBox1.Image = global::PPTMS.Properties.Resources.mental_health;
            this.pBox1.Location = new System.Drawing.Point(440, 3);
            this.pBox1.Name = "pBox1";
            this.pBox1.Size = new System.Drawing.Size(116, 96);
            this.pBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox1.TabIndex = 71;
            this.pBox1.TabStop = false;
            // 
            // butAddNewHabit
            // 
            this.butAddNewHabit.BackColor = System.Drawing.Color.Transparent;
            this.butAddNewHabit.FlatAppearance.BorderSize = 0;
            this.butAddNewHabit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddNewHabit.Image = global::PPTMS.Properties.Resources.mental_health__1_;
            this.butAddNewHabit.Location = new System.Drawing.Point(948, 31);
            this.butAddNewHabit.Name = "butAddNewHabit";
            this.butAddNewHabit.Size = new System.Drawing.Size(73, 75);
            this.butAddNewHabit.TabIndex = 70;
            this.butAddNewHabit.UseVisualStyleBackColor = false;
            this.butAddNewHabit.Click += new System.EventHandler(this.AddNewHabit_Click);
            // 
            // CtrlHabits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRecodes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHabits);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pBox1);
            this.Controls.Add(this.butAddNewHabit);
            this.Controls.Add(this.label1);
            this.Name = "CtrlHabits";
            this.Size = new System.Drawing.Size(1168, 935);
            this.Load += new System.EventHandler(this.CtrlHabits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHabits)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pBox1;
        private System.Windows.Forms.Button butAddNewHabit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRecodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHabits;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmShowDetails;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmArchiveHabit;
        private System.Windows.Forms.ToolStripMenuItem tsmCheckIn;
        private System.Windows.Forms.ToolStripMenuItem tsmActivateAndDeactivate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmAddNewHabit;
        private System.Windows.Forms.ToolStripMenuItem tsmViewProgress;
        private System.Windows.Forms.ToolStripMenuItem tsmUndoCheckIn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
