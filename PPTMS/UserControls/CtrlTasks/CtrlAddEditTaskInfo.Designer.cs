namespace PPTMS.UserControls.CtrlTasks
{
    partial class CtrlAddEditTaskInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlAddEditTaskInfo));
            this.gbTask = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.txtEstimatedMinutes = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.lblCreateDate = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTask
            // 
            this.gbTask.Controls.Add(this.lblStatus);
            this.gbTask.Controls.Add(this.label15);
            this.gbTask.Controls.Add(this.txtTitle);
            this.gbTask.Controls.Add(this.dtpDueDate);
            this.gbTask.Controls.Add(this.txtEstimatedMinutes);
            this.gbTask.Controls.Add(this.cbCategory);
            this.gbTask.Controls.Add(this.cbPriority);
            this.gbTask.Controls.Add(this.txtDescription);
            this.gbTask.Controls.Add(this.label10);
            this.gbTask.Controls.Add(this.label6);
            this.gbTask.Controls.Add(this.label5);
            this.gbTask.Controls.Add(this.label3);
            this.gbTask.Controls.Add(this.label18);
            this.gbTask.Controls.Add(this.label17);
            this.gbTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTask.Location = new System.Drawing.Point(111, 183);
            this.gbTask.Name = "gbTask";
            this.gbTask.Size = new System.Drawing.Size(929, 486);
            this.gbTask.TabIndex = 88;
            this.gbTask.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(732, 117);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(121, 25);
            this.lblStatus.TabIndex = 91;
            this.lblStatus.Text = "In Progress";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Image = global::PPTMS.Properties.Resources.loading;
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Location = new System.Drawing.Point(518, 115);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 27);
            this.label15.TabIndex = 90;
            this.label15.Text = "Status";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(270, 50);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(189, 29);
            this.txtTitle.TabIndex = 89;
            this.txtTitle.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(270, 113);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(189, 29);
            this.dtpDueDate.TabIndex = 88;
            // 
            // txtEstimatedMinutes
            // 
            this.txtEstimatedMinutes.Location = new System.Drawing.Point(270, 194);
            this.txtEstimatedMinutes.Name = "txtEstimatedMinutes";
            this.txtEstimatedMinutes.Size = new System.Drawing.Size(189, 29);
            this.txtEstimatedMinutes.TabIndex = 87;
            this.txtEstimatedMinutes.Text = "30";
            this.txtEstimatedMinutes.TextChanged += new System.EventHandler(this.txtEstimatedMinutes_TextChanged);
            this.txtEstimatedMinutes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstimatedMinutes_KeyPress);
            this.txtEstimatedMinutes.Validating += new System.ComponentModel.CancelEventHandler(this.TextBox_Validating);
            // 
            // cbCategory
            // 
            this.cbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(737, 51);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(145, 32);
            this.cbCategory.TabIndex = 86;
            // 
            // cbPriority
            // 
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Critical"});
            this.cbPriority.Location = new System.Drawing.Point(737, 189);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(145, 32);
            this.cbPriority.TabIndex = 84;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(270, 292);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(635, 166);
            this.txtDescription.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Image = global::PPTMS.Properties.Resources.timer;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label10.Location = new System.Drawing.Point(23, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(226, 34);
            this.label10.TabIndex = 79;
            this.label10.Text = "Estimated Minutes";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::PPTMS.Properties.Resources.checklist;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(24, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 27);
            this.label6.TabIndex = 66;
            this.label6.Text = "Title ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::PPTMS.Properties.Resources.category_5;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(518, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 27);
            this.label5.TabIndex = 67;
            this.label5.Text = "Category";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::PPTMS.Properties.Resources.pencil;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(19, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 32);
            this.label3.TabIndex = 65;
            this.label3.Text = "Description";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Image = ((System.Drawing.Image)(resources.GetObject("label18.Image")));
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(24, 114);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(225, 27);
            this.label18.TabIndex = 73;
            this.label18.Text = "Due Date";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Image = global::PPTMS.Properties.Resources.priority;
            this.label17.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Location = new System.Drawing.Point(518, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 24);
            this.label17.TabIndex = 74;
            this.label17.Text = "Priority";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskID.Location = new System.Drawing.Point(376, 155);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(60, 25);
            this.lblTaskID.TabIndex = 68;
            this.lblTaskID.Text = "[???]";
            // 
            // lblCreateDate
            // 
            this.lblCreateDate.AutoSize = true;
            this.lblCreateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateDate.Location = new System.Drawing.Point(843, 155);
            this.lblCreateDate.Name = "lblCreateDate";
            this.lblCreateDate.Size = new System.Drawing.Size(132, 25);
            this.lblCreateDate.TabIndex = 84;
            this.lblCreateDate.Text = "[????/??/??]";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.DarkViolet;
            this.lblMode.Location = new System.Drawing.Point(566, 31);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(163, 39);
            this.lblMode.TabIndex = 86;
            this.lblMode.Text = "Add Task";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Image = ((System.Drawing.Image)(resources.GetObject("label12.Image")));
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label12.Location = new System.Drawing.Point(588, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(204, 27);
            this.label12.TabIndex = 83;
            this.label12.Text = "Create Date";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picIcon
            // 
            this.picIcon.Image = global::PPTMS.Properties.Resources.add_task;
            this.picIcon.Location = new System.Drawing.Point(431, 3);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(116, 96);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 87;
            this.picIcon.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::PPTMS.Properties.Resources.id;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(135, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 24);
            this.label2.TabIndex = 63;
            this.label2.Text = "Task ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::PPTMS.Properties.Resources.download;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(883, 689);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(143, 39);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::PPTMS.Properties.Resources.return__1_;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(135, 689);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 39);
            this.btnBack.TabIndex = 59;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // CtrlAddEditTaskInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblCreateDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTaskID);
            this.Controls.Add(this.gbTask);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Name = "CtrlAddEditTaskInfo";
            this.Size = new System.Drawing.Size(1168, 740);
            this.Load += new System.EventHandler(this.CtrlAddEditTaskInfo_Load);
            this.gbTask.ResumeLayout(false);
            this.gbTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gbTask;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.Label lblCreateDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.TextBox txtEstimatedMinutes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
