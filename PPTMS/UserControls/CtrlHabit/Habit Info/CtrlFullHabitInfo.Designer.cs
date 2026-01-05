namespace PPTMS.UserControls.CtrlHabit.Habit_Info
{
    partial class CtrlFullHabitInfo
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
            this.ctrlHabitInfo1 = new PPTMS.UserControls.CtrlHabit.Habit_Info.CtrlHabitInfo();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.ctrlHabitInfo1);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1168, 432);
            this.panelMain.TabIndex = 0;
            // 
            // ctrlHabitInfo1
            // 
            this.ctrlHabitInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlHabitInfo1.Name = "ctrlHabitInfo1";
            this.ctrlHabitInfo1.Size = new System.Drawing.Size(1168, 432);
            this.ctrlHabitInfo1.TabIndex = 0;
            this.ctrlHabitInfo1.OnBack_Click += new System.EventHandler(this.ctrlHabitInfo1_OnBack_Click);
            this.ctrlHabitInfo1.OnEditHabitInfo_LinkClicke += new System.Action<int>(this.ctrlHabitInfo1_OnEditHabitInfo_LinkClicke);
            // 
            // CtrlFullHabitInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "CtrlFullHabitInfo";
            this.Size = new System.Drawing.Size(1168, 432);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private CtrlHabitInfo ctrlHabitInfo1;
    }
}
