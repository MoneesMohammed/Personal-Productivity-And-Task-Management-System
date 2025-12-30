namespace PPTMS.UserControls.CtrlUser
{
    partial class CtrlFullUser
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
            this.ctrlChangePassword1 = new PPTMS.UserControls.CtrlUser.CtrlChangePassword();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.ctrlChangePassword1);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(849, 885);
            this.panelMain.TabIndex = 1;
            // 
            // ctrlChangePassword1
            // 
            this.ctrlChangePassword1.Location = new System.Drawing.Point(119, 0);
            this.ctrlChangePassword1.Name = "ctrlChangePassword1";
            this.ctrlChangePassword1.Size = new System.Drawing.Size(616, 868);
            this.ctrlChangePassword1.TabIndex = 0;
            // 
            // CtrlFullUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "CtrlFullUser";
            this.Size = new System.Drawing.Size(849, 885);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private CtrlChangePassword ctrlChangePassword1;
    }
}
