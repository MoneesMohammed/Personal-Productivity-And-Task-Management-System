namespace PPTMS.UserControls.CtrlTasks
{
    partial class CtrlFullTasks
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
            this.ctrlTasks1 = new PPTMS.UserControls.CtrlTasks.CtrlTasks();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.ctrlTasks1);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1168, 935);
            this.panelMain.TabIndex = 0;
            // 
            // ctrlTasks1
            // 
            this.ctrlTasks1.Location = new System.Drawing.Point(0, 0);
            this.ctrlTasks1.Name = "ctrlTasks1";
            this.ctrlTasks1.Size = new System.Drawing.Size(1168, 935);
            this.ctrlTasks1.TabIndex = 0;
            this.ctrlTasks1.OnAddNewTask_Click += new System.EventHandler(this.ctrlTasks1_OnAddNewTask_Click);
            this.ctrlTasks1.OnShowDetails_Click += new System.Action<int>(this.ctrlTasks1_OnShowDetails_Click);
            this.ctrlTasks1.OnEdit_Click += new System.Action<int>(this.ctrlTasks1_OnEdit_Click);
            this.ctrlTasks1.OnReminders_Click += new System.Action<int>(this.ctrlTasks1_OnReminders_Click);
            this.ctrlTasks1.OnAttachments_Click += new System.Action<int>(this.ctrlTasks1_OnAttachments_Click);
            // 
            // CtrlFullTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "CtrlFullTasks";
            this.Size = new System.Drawing.Size(1168, 935);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private CtrlTasks ctrlTasks1;
    }
}
