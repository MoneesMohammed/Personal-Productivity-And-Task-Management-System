namespace PPTMS.UserControls.CtrlTasks.Attachments
{
    partial class CtrlFullAttachments
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.ctrlAttachments1 = new PPTMS.UserControls.CtrlTasks.Attachments.CtrlAttachments();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.ctrlAttachments1);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1168, 935);
            this.panelMain.TabIndex = 0;
            // 
            // ctrlAttachments1
            // 
            this.ctrlAttachments1.Location = new System.Drawing.Point(0, 0);
            this.ctrlAttachments1.Name = "ctrlAttachments1";
            this.ctrlAttachments1.Size = new System.Drawing.Size(1168, 935);
            this.ctrlAttachments1.TabIndex = 0;
            this.ctrlAttachments1.OnBack_Click += new System.EventHandler(this.ctrlAttachments1_OnBack_Click);
            this.ctrlAttachments1.OnAddNewAttachment_Click += new System.EventHandler(this.ctrlAttachments1_OnAddNewAttachment_Click);
            // 
            // CtrlFullAttachments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "CtrlFullAttachments";
            this.Size = new System.Drawing.Size(1168, 935);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private CtrlAttachments ctrlAttachments1;
    }
}
