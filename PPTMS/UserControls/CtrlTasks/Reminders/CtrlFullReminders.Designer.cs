namespace PPTMS.UserControls.CtrlTasks.Reminders
{
    partial class CtrlFullReminders
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
            this.ctrlReminders1 = new PPTMS.UserControls.CtrlTasks.Reminders.CtrlReminders();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.ctrlReminders1);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1168, 935);
            this.panelMain.TabIndex = 0;
            // 
            // ctrlReminders1
            // 
            this.ctrlReminders1.Location = new System.Drawing.Point(0, 0);
            this.ctrlReminders1.Name = "ctrlReminders1";
            this.ctrlReminders1.Size = new System.Drawing.Size(1168, 935);
            this.ctrlReminders1.TabIndex = 0;
            this.ctrlReminders1.OnBack_Click += new System.EventHandler(this.ctrlReminders1_OnBack_Click);
            this.ctrlReminders1.OnAddNewReminder_Click += new System.EventHandler(this.ctrlReminders1_OnAddNewReminder_Click);
            this.ctrlReminders1.OnEdit_Click += new System.Action<int>(this.ctrlReminders1_OnEdit_Click);
            // 
            // CtrlFullReminders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "CtrlFullReminders";
            this.Size = new System.Drawing.Size(1168, 935);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private CtrlReminders ctrlReminders1;
    }
}
