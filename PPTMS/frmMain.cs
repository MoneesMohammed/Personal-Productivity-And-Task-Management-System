using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //picMain.Size = new System.Drawing.Size(this.Size.Width - 373, this.Size.Height - 85);
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panelSidebar.ClientRectangle,
                Color.FromArgb(60, 120, 200),
                Color.FromArgb(120, 60, 160),
                90f))
            {
                e.Graphics.FillRectangle(brush, panelSidebar.ClientRectangle);
            }
        }

        
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text == "Logout")
            {
                btn.BackColor = Color.FromArgb(40, Color.Red);
            }
            else
            btn.BackColor = Color.FromArgb(40, Color.RoyalBlue);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Transparent;
        }

        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void but4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
