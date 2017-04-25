using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLLClassLibrary;
using ModelClassLibrary;

namespace VehicleInfoApp1.UI
{
    public partial class ScheduleVehicleUI : Form
    {
        private List<RadioButton> shiftRadioButtonList;
        private string shift;

        public ScheduleVehicleUI()
        {
            InitializeComponent();
            shiftRadioButtonList = new List<RadioButton>();

            shiftPanel.SuspendLayout();
            SuspendLayout();

            int locX = 70;
            int locY = 10;

            foreach (var aShift in ScheduleManager.Get_Shift())
            {
                RadioButton shiftRadioButton = new RadioButton();
                shiftRadioButton.Name = aShift;
                shiftRadioButton.Text = aShift;
                shiftRadioButton.Location = new Point(locX, locY);
                shiftRadioButton.AutoSize = true;
                shiftRadioButton.UseVisualStyleBackColor = true;
                shiftRadioButton.CheckedChanged += new EventHandler(shiftRadioButton_CheckedChanged);
                shiftPanel.Controls.Add(shiftRadioButton);
                shiftRadioButtonList.Add(shiftRadioButton);
                locX += 100;
            }

            shiftPanel.ResumeLayout(false);
            shiftPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

            shiftRadioButtonList[0].Checked = true;
            this.shift = shiftRadioButtonList[0].Text;

            vehicleComboBox.DataSource = null;
            vehicleComboBox.Items.Clear();;
            vehicleComboBox.DisplayMember = "RegNo";
            vehicleComboBox.ValueMember = "DatabaseId";
            vehicleComboBox.DataSource = VehicleManager.Get_All();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Vehicle aVehicle = (Vehicle)vehicleComboBox.SelectedItem;
            Schedule aSchedule = new Schedule(aVehicle,selectDateTimePicker.Value,
                this.shift,bookedTextBox.Text,
                addressRichTextBox.Text);
            MessageBox.Show(ScheduleManager.Insert_Schedule(aSchedule));
            bookedTextBox.Text = string.Empty;
            addressRichTextBox.Text = string.Empty;
        }

        private void shiftRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton senderRadioButton = (RadioButton)sender;
            shift = senderRadioButton.Text;
        }
    }
}
