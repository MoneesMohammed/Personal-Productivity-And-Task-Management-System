namespace PPTMS.UserControls.CtrlCategories
{
    partial class CtrlFullCategories
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
            this.ctrlCategories1 = new PPTMS.UserControls.CtrlCategories.CtrlCategories();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.ctrlCategories1);
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(559, 822);
            this.panelMain.TabIndex = 0;
            // 
            // ctrlCategories1
            // 
            this.ctrlCategories1.Location = new System.Drawing.Point(0, 0);
            this.ctrlCategories1.Name = "ctrlCategories1";
            this.ctrlCategories1.Size = new System.Drawing.Size(559, 822);
            this.ctrlCategories1.TabIndex = 0;
            this.ctrlCategories1.OnAddNewCategory_Click += new System.EventHandler(this.ctrlCategories1_OnAddNewCategory_Click);
            this.ctrlCategories1.OnEdit_Click += new System.Action<int>(this.ctrlCategories1_OnEdit_Click);
            // 
            // CtrlFullCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Name = "CtrlFullCategories";
            this.Size = new System.Drawing.Size(559, 822);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private CtrlCategories ctrlCategories1;
    }
}
