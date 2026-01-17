namespace PPTMS.UserControls.CtrlHabit
{
    partial class CtrlFullHabits
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
            this.ctrlHabits1 = new PPTMS.UserControls.CtrlHabit.CtrlHabits();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.ctrlHabits1);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1168, 935);
            this.panelMain.TabIndex = 0;
            // 
            // ctrlHabits1
            // 
            this.ctrlHabits1.Location = new System.Drawing.Point(0, 0);
            this.ctrlHabits1.Name = "ctrlHabits1";
            this.ctrlHabits1.Size = new System.Drawing.Size(1168, 935);
            this.ctrlHabits1.TabIndex = 0;
            this.ctrlHabits1.OnAddNewHabit_Click += new System.EventHandler(this.ctrlHabits1_OnAddNewHabit_Click);
            this.ctrlHabits1.OnShowDetails_Click += new System.Action<int>(this.ctrlHabits1_OnShowDetails_Click);
            this.ctrlHabits1.OnEdit_Click += new System.Action<int>(this.ctrlHabits1_OnEdit_Click);
            this.ctrlHabits1.OnViewProgress_Click += new System.Action<int>(this.ctrlHabits1_OnViewProgress_Click);
            // 
            // CtrlFullHabits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "CtrlFullHabits";
            this.Size = new System.Drawing.Size(1168, 935);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private CtrlHabits ctrlHabits1;
    }
}
