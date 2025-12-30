using PPTMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlTasks.Attachments
{
    public partial class CtrlAttachments : UserControl
    {
        public event EventHandler OnBack_Click;
        public event EventHandler OnAddNewAttachment_Click;

        private DataTable _dtAttachments;
        private int _TaskID = -1;

        public CtrlAttachments()
        {
            InitializeComponent();
        }

        public void SetTaskID(int TaskID)
        {
            _TaskID = TaskID;
        }

        public void RefreshAttachmentsList()
        {
            if (_TaskID == -1)
                return;

            _dtAttachments = clsTaskAttachment.GetAllAttachments(_TaskID);

            dgvAttachments.DataSource = _dtAttachments;

            lblRecodes.Text = dgvAttachments.Rows.Count.ToString();
            _FormatDGV();

        }

        private void _FormatDGV()
        {
            if (dgvAttachments.Rows.Count <= 0)
            {
                return;
            }

            dgvAttachments.Columns[0].Width = 145;
            dgvAttachments.Columns[1].Width = 253;
            dgvAttachments.Columns[2].Width = 170;
        }

        private void CtrlAttachments_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
                return;

            RefreshAttachmentsList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender,e);
        }

        private void AddNewAttachment_Click(object sender, EventArgs e)
        {
            OnAddNewAttachment_Click?.Invoke(sender, e);
        }

        private void tsmOpen_Click(object sender, EventArgs e)
        {
            clsTaskAttachment TaskAttachment = clsTaskAttachment.Find((int)dgvAttachments.CurrentRow.Cells[0].Value);

            System.Diagnostics.Process.Start(TaskAttachment.FilePath);

        }

        private void tsmRemove_Click(object sender, EventArgs e)
        {
            clsTaskAttachment TaskAttachment = clsTaskAttachment.Find((int)dgvAttachments.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Are you sure you want to Delete the Attachment \nby AttachmentID: {TaskAttachment.AttachmentID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                try
                {
                    File.Delete(TaskAttachment.FilePath);
                }
                catch (IOException)
                {
                    //Log 
                }

                if (TaskAttachment.Delete())
                {
                    MessageBox.Show("Attachment has been Deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Attachment was not Deleted because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            RefreshAttachmentsList();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvAttachments.Rows.Count <= 0)
            {
                tsmOpen.Enabled = false;
                tsmRemove.Enabled = false;
            }
            else
            {
                tsmOpen.Enabled = true;
                tsmRemove.Enabled = true;
            }
        }
    }
}
