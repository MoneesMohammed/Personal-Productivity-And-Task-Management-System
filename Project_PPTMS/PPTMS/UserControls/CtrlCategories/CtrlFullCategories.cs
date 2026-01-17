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
    public partial class CtrlFullCategories : UserControl
    {
        public CtrlFullCategories()
        {
            InitializeComponent();
        }

        private void LoadControl(UserControl control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelMain.Controls.Add(control);
        }

        private void ctrlCategories1_OnAddNewCategory_Click(object sender, EventArgs e)
        {
            CtrlAddEditCategoryInfo ctrlAddCategory = new CtrlAddEditCategoryInfo();
            ctrlAddCategory.OnBack_Click += CtrlAddEditCategoryInfo1_OnBack_Click;
            LoadControl(ctrlAddCategory);
        }

       

        private void ctrlCategories1_OnEdit_Click(int obj)
        {
            CtrlAddEditCategoryInfo ctrlEditCategory = new CtrlAddEditCategoryInfo(obj);
            ctrlEditCategory.OnBack_Click += CtrlAddEditCategoryInfo1_OnBack_Click;
            LoadControl(ctrlEditCategory);
        }

        private void CtrlAddEditCategoryInfo1_OnBack_Click(object sender, EventArgs e)
        {
            ctrlCategories1.RefreshCategoriesList();
            LoadControl(ctrlCategories1);
        }
    }
}
