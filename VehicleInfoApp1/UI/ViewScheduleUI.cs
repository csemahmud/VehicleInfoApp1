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

namespace VehicleInfoApp1.UI
{
    public partial class ViewScheduleUI : Form
    {
        public ViewScheduleUI()
        {
            InitializeComponent();
            vehicleComboBox.DataSource = null;
            vehicleComboBox.Items.Clear();
            vehicleComboBox.DataSource = VehicleManager.Get_All();
            vehicleComboBox.DisplayMember = "RegNo";
            vehicleComboBox.ValueMember = "DatabaseId";
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            scheduleDataGridView.AutoGenerateColumns = false;
            scheduleDataGridView.DataSource = null;
            scheduleDataGridView.DataSource = ScheduleManager.Get_All(
                Convert.ToInt32(vehicleComboBox.SelectedValue));
            scheduleDataGridView.Columns[0].DataPropertyName = "Date_S";
            scheduleDataGridView.Columns[1].DataPropertyName = "Shift";
        }
    }
}
