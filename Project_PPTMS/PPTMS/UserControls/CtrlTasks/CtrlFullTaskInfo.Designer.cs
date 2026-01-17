namespace PPTMS.UserControls.CtrlTasks
{
    partial class CtrlFullTaskInfo
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
            this.ctrlTaskInfo1 = new PPTMS.UserControls.CtrlTasks.CtrlTaskInfo();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.ctrlTaskInfo1);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1168, 740);
            this.panelMain.TabIndex = 0;
            // 
            // ctrlTaskInfo1
            // 
            this.ctrlTaskInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlTaskInfo1.Name = "ctrlTaskInfo1";
            this.ctrlTaskInfo1.Size = new System.Drawing.Size(1168, 740);
            this.ctrlTaskInfo1.TabIndex = 0;
            this.ctrlTaskInfo1.OnBack_Click += new System.EventHandler(this.ctrlTaskInfo1_OnBack_Click);
            this.ctrlTaskInfo1.OnEditTaskInfo_LinkClicke += new System.Action<int>(this.ctrlTaskInfo1_OnEditTaskInfo_LinkClicke);
            // 
            // CtrlFullTaskInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "CtrlFullTaskInfo";
            this.Size = new System.Drawing.Size(1168, 740);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private CtrlTaskInfo ctrlTaskInfo1;
    }
}
