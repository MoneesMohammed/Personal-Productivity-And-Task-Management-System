using PPTMS.Global_Classes;
using PPTMS.Properties;
using PPTMS_BusinessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PPTMS_BusinessLayer.clsHabit;
using static PPTMS_BusinessLayer.clsTask;

namespace PPTMS.UserControls.CtrlHabit.Add_Edit_Habit
{
    public partial class CtrlAddEditHabit : UserControl
    {
        public event EventHandler OnBack_Click;

        //Delegate
        public delegate void DataFoundEventHandler(object sender, int CategoryID);

        public event DataFoundEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 }

        private enMode _Mode;
        private int _HabitID = -1;
        private clsHabit _Habit;


        public CtrlAddEditHabit()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }

        public CtrlAddEditHabit(int HabitID)
        {
            InitializeComponent();
            _HabitID = HabitID;
            _Mode = enMode.Update;
        }

        private void _ResatDefualtValues()
        {
            if (_Mode == enMode.AddNew)
            {
                lblMode.Text = "Add New Habit";
                _Habit = new clsHabit();
                
            }
            else
            {
                lblMode.Text = "Edit Habit";
                
                btnSave.Enabled = true;
            }

            txtHabitName.Text = "";
            lblHabitID.Text = "[???]";
            cbFrequency.SelectedIndex = 0;

            lblCreateDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void CtrlAddEditHabit_Load(object sender, EventArgs e)
        {
            _ResatDefualtValues();
            if (_Mode == enMode.Update)
                _LoadData();
        }

        private void _LoadData()
        {
            _Habit = clsHabit.Find(_HabitID);

            if (_Habit == null)
            {
                MessageBox.Show($"No Habit with ID= {_HabitID} ", "Habit Not Found ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // this.Close();
                return;
            }

            lblHabitID.Text = _HabitID.ToString();
            txtHabitName.Text = _Habit.Name;
            cbFrequency.SelectedIndex = cbFrequency.FindString(_Habit.FrequencyText);
            lblCreateDate.Text = _Habit.CreateDate.ToString("dd/MM/yyyy");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            OnBack_Click?.Invoke(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _Habit.UserID = clsGlobal.CurrentUser.UserID;
            _Habit.Name = txtHabitName.Text;
            _Habit.Frequency = (clsHabit.enFrequency)cbFrequency.SelectedIndex;
           
            _Habit.CreateDate = DateTime.Now;


            if (_Habit.Save())
            {
                _Mode = enMode.Update;

                lblMode.Text = "Edit Habit";
                lblHabitID.Text = _Habit.HabitID.ToString();

                MessageBox.Show("Data saved successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Habit.HabitID);
            }
            else
            {
                MessageBox.Show("Error : data is not saved successfully", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtHabitName_Validating(object sender, CancelEventArgs e)
        {
            TextBox Tepm = ((TextBox)sender);

            if (string.IsNullOrEmpty(Tepm.Text.Trim()))
            {
                e.Cancel = true;

                errorProvider1.SetError(Tepm, "this field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Tepm, null);
            }
        }
    }
}
