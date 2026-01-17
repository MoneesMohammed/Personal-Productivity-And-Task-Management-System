using PPTMS.UserControls.CtrlTasks.Reminders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlTasks.Attachments
{
    public partial class CtrlFullAttachments : UserControl
    {
        public event EventHandler OnBack_Click;

        private int _TaskID = -1;

        public CtrlFullAttachments(int TaskID)
        {
            InitializeComponent();
            _TaskID = TaskID;
            ctrlAttachments1.SetTaskID(_TaskID);
        }

        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void ctrlAttachments1_OnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender, e);
        }

        private void ctrlAttachments1_OnAddNewAttachment_Click(object sender, EventArgs e)
        {
            CtrlAddEditAttachment ctrlAddAttachment = new CtrlAddEditAttachment(_TaskID);
            ctrlAddAttachment.OnBack_Click += CtrlAttachment1_OnBack_Click;
            LoadControl(ctrlAddAttachment);
        }

        private void CtrlAttachment1_OnBack_Click(object sender, EventArgs e)
        {
            ctrlAttachments1.RefreshAttachmentsList();
            LoadControl(ctrlAttachments1);
        }
    }
}
