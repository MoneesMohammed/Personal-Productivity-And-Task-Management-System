namespace PPTMS.UserControls.CtrlTasks.Attachments
{
    partial class CtrlAddEditAttachment
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
            this.lblAttachmentID = new System.Windows.Forms.Label();
            this.lblTaskID = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblUploadedDate = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.llblAddFile = new System.Windows.Forms.LinkLabel();
            this.llblRemove = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAttachmentID
            // 
            this.lblAttachmentID.AutoSize = true;
            this.lblAttachmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachmentID.Location = new System.Drawing.Point(618, 114);
            this.lblAttachmentID.Name = "lblAttachmentID";
            this.lblAttachmentID.Size = new System.Drawing.Size(60, 25);
            this.lblAttachmentID.TabIndex = 109;
            this.lblAttachmentID.Text = "[???]";
            // 
            // lblTaskID
            // 
            this.lblTaskID.AutoSize = true;
            this.lblTaskID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskID.Location = new System.Drawing.Point(618, 157);
            this.lblTaskID.Name = "lblTaskID";
            this.lblTaskID.Size = new System.Drawing.Size(60, 25);
            this.lblTaskID.TabIndex = 103;
            this.lblTaskID.Text = "[???]";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMode.Location = new System.Drawing.Point(501, 28);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(264, 39);
            this.lblMode.TabIndex = 100;
            this.lblMode.Text = "Add Attachment";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUploadedDate
            // 
            this.lblUploadedDate.AutoSize = true;
            this.lblUploadedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUploadedDate.Location = new System.Drawing.Point(618, 200);
            this.lblUploadedDate.Name = "lblUploadedDate";
            this.lblUploadedDate.Size = new System.Drawing.Size(60, 25);
            this.lblUploadedDate.TabIndex = 110;
            this.lblUploadedDate.Text = "[???]";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(618, 243);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(60, 25);
            this.lblFileName.TabIndex = 112;
            this.lblFileName.Text = "[???]";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // llblAddFile
            // 
            this.llblAddFile.AutoSize = true;
            this.llblAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblAddFile.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblAddFile.Location = new System.Drawing.Point(503, 290);
            this.llblAddFile.Name = "llblAddFile";
            this.llblAddFile.Size = new System.Drawing.Size(103, 29);
            this.llblAddFile.TabIndex = 113;
            this.llblAddFile.TabStop = true;
            this.llblAddFile.Text = "Add File";
            this.llblAddFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblAddFile_LinkClicked);
            // 
            // llblRemove
            // 
            this.llblRemove.AutoSize = true;
            this.llblRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblRemove.Location = new System.Drawing.Point(339, 290);
            this.llblRemove.Name = "llblRemove";
            this.llblRemove.Size = new System.Drawing.Size(103, 29);
            this.llblRemove.TabIndex = 114;
            this.llblRemove.TabStop = true;
            this.llblRemove.Text = "Remove";
            this.llblRemove.Visible = false;
            this.llblRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblRemove_LinkClicked);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::PPTMS.Properties.Resources.folder;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(366, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 27);
            this.label4.TabIndex = 111;
            this.label4.Text = "File Name";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::PPTMS.Properties.Resources.id;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(370, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 24);
            this.label3.TabIndex = 108;
            this.label3.Text = "Attachment ID";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Image = global::PPTMS.Properties.Resources.download;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(728, 344);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 39);
            this.btnSave.TabIndex = 107;
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
            this.btnBack.Location = new System.Drawing.Point(166, 344);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(156, 39);
            this.btnBack.TabIndex = 106;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Image = global::PPTMS.Properties.Resources.calendar;
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Location = new System.Drawing.Point(366, 198);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(213, 27);
            this.label18.TabIndex = 104;
            this.label18.Text = "Uploaded Date";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::PPTMS.Properties.Resources.id;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(366, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 102;
            this.label2.Text = "Task ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picIcon
            // 
            this.picIcon.Image = global::PPTMS.Properties.Resources.attach_file;
            this.picIcon.Location = new System.Drawing.Point(366, 0);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(116, 96);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 101;
            this.picIcon.TabStop = false;
            // 
            // CtrlAddEditAttachment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.llblRemove);
            this.Controls.Add(this.llblAddFile);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUploadedDate);
            this.Controls.Add(this.lblAttachmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblTaskID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.lblMode);
            this.Name = "CtrlAddEditAttachment";
            this.Size = new System.Drawing.Size(1168, 408);
            this.Load += new System.EventHandler(this.CtrlAddEditAttachment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAttachmentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblTaskID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label lblUploadedDate;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel llblAddFile;
        private System.Windows.Forms.LinkLabel llblRemove;
    }
}
