using PPTMS.Global_Classes;
using PPTMS.Properties;
using PPTMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlTasks.Attachments
{
    public partial class CtrlAddEditAttachment : UserControl
    {
        public event EventHandler OnBack_Click;

        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;
        private int _AttachmentID = -1;
        private int _TaskID = -1;
        private clsTaskAttachment _TaskAttachment;

        public CtrlAddEditAttachment(int TaskID)
        {
            InitializeComponent();
            _TaskID = TaskID;
            _Mode = enMode.AddNew;
        }

        public CtrlAddEditAttachment(int TaskID, int AttachmentID)
        {
            InitializeComponent();
            _TaskID = TaskID;
            _AttachmentID = AttachmentID;
            _Mode = enMode.Update;
        }

        private void _ResatDefualtValues()
        {

            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add Attachment";
                _TaskAttachment = new clsTaskAttachment();
            }
            else
            {
                lblMode.Text = "Edit Attachment";
                
                btnSave.Enabled = true;
            }

            llblRemove.Visible = false;

            lblTaskID.Text = _TaskID.ToString();
            lblUploadedDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            lblFileName.Text = "[???]";
            lblAttachmentID.Text = "[???]";

        }

        private void CtrlAddEditAttachment_Load(object sender, EventArgs e)
        {
            _ResatDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _LoadData()
        {
            _TaskAttachment = clsTaskAttachment.Find(_AttachmentID);

            if (_TaskAttachment == null)
            {
                MessageBox.Show($"No Task Attachment with ID= {_AttachmentID} ", "Task Attachment Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this.Close();
                return;
            }

            lblAttachmentID.Text = _TaskAttachment.AttachmentID.ToString();
            lblFileName.Text = _TaskAttachment.FileName;
            lblTaskID.Text = _TaskID.ToString();
            lblUploadedDate.Text = _TaskAttachment.UploadedDate.ToString("dd/MM/yyyy");

            llblRemove.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_TaskAttachment.FilePath == "")
            {
                MessageBox.Show("You should add a file" , "Error" , MessageBoxButtons.OK , MessageBoxIcon.Error);
                return;
            }

            if (!_HandleFileAttachment())
                return;

            _TaskAttachment.TaskID = _TaskID;
            _TaskAttachment.UploadedDate = DateTime.Now;

            if (_TaskAttachment.Save())
            {
                lblAttachmentID.Text = _TaskAttachment.AttachmentID.ToString();
                _Mode = enMode.Update;
                lblMode.Text = "Update Attachment";


                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Trigger the event to send data back to the caller form.
                OnBack_Click?.Invoke(sender, e);

            }
            else
            {

                MessageBox.Show("Error : data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void llblAddFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.DefaultExt = "JPG";

            openFileDialog1.Title  = "Select Attachment";
            openFileDialog1.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|" +
                                     "PDF Files (*.pdf)|*.pdf|" +
                                     "Word Files (*.doc;*.docx)|*.doc;*.docx|" +
                                     "Excel Files (*.xls;*.xlsx)|*.xls;*.xlsx|" +
                                     "All Files (*.*)|*.*";
                

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = Path.GetFileName(openFileDialog1.FileName);

                _TaskAttachment.FilePath = openFileDialog1.FileName;

                MessageBox.Show(openFileDialog1.FileName);
                llblRemove.Visible = true;
            }
        }

        private void llblRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lblFileName.Text = "[???]";
            _TaskAttachment.FileName = "";
            _TaskAttachment.FilePath = "";
            llblRemove.Visible = false;
        }


        private bool _HandleFileAttachment()
        {
            string sourceFile = _TaskAttachment.FilePath;

            if (clsUtil.CopyAttachmentToProjectAttachmentsFolder(_TaskID,ref sourceFile))
            {
                lblFileName.Text = Path.GetFileName(sourceFile);
                _TaskAttachment.FileName = lblFileName.Text;
                _TaskAttachment.FilePath = sourceFile;

                return true;
            }
            else
            {

                MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender,e);
        }

    }
}
