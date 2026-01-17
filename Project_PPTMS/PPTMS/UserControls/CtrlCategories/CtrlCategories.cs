using PPTMS.Global_Classes;
using PPTMS_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPTMS.UserControls.CtrlCategories
{
    public partial class CtrlCategories : UserControl
    {
        public event EventHandler OnAddNewCategory_Click;
        
        public event Action<int> OnEdit_Click;

        //protected virtual void Edit_Click(int CategoryID)
        //{
        //    Action<int> handler = OnEdit_Click;
        //    if (handler != null)
        //    {
        //        handler(CategoryID);
        //    }

        //}

        private DataTable _dtCategories;

        public CtrlCategories()
        {
            InitializeComponent();
        }

        public void RefreshCategoriesList()
        {
            _dtCategories = clsTaskCategory.GetAllCategories(clsGlobal.CurrentUser.UserID);

            dgvCategories.DataSource = _dtCategories;

            lblRecodes.Text = dgvCategories.Rows.Count.ToString();
            _FormatDGV();

        }

        private void _FormatDGV()
        {
            if (dgvCategories.Rows.Count <= 0)
            {
                return;
            }

            dgvCategories.Columns[0].Width = 170;
            dgvCategories.Columns[1].Width = 244;
            
        }

        private void CtrlCategories_Load(object sender, EventArgs e)
        {
            if (this.DesignMode)
                return;

            RefreshCategoriesList();
        }

        private void AddNewCategory_Click(object sender, EventArgs e)
        {
            OnAddNewCategory_Click?.Invoke(sender, e);
            
        }

        private void tsmEdit_Click(object sender, EventArgs e)
        {
            int CategoryID = (int)dgvCategories.CurrentRow.Cells[0].Value;
            OnEdit_Click(CategoryID);

            
        }

        private void tsmDelete_Click(object sender, EventArgs e)
        {
            clsTaskCategory TaskCategory = clsTaskCategory.Find((int)dgvCategories.CurrentRow.Cells[0].Value);

            var result = MessageBox.Show($"Are you sure you want to delete the Task Category \nby CategoryID: {TaskCategory.CategoryID}", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (TaskCategory.Delete())
                {

                    MessageBox.Show("Task Category has been deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Task Category was not deleted because it has data linked to it.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

            RefreshCategoriesList();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int CategoryID = (int)dgvCategories.CurrentRow.Cells[0].Value;
            clsTaskCategory TaskCategory = clsTaskCategory.Find(CategoryID);

            if (TaskCategory.UserID == -1)
            {
                tsmEdit.Enabled = false;
                tsmDelete.Enabled = false;
            }
            else
            {
                tsmEdit.Enabled = true;
                tsmDelete.Enabled = true;
            }

        }
    }
}
