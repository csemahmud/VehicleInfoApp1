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
    public partial class ViewDateBetweenScheduleUI : Form
    {
        public ViewDateBetweenScheduleUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            scheduleDataGridView.DataSource = null;
            scheduleDataGridView.AutoGenerateColumns = false;
            scheduleDataGridView.DataSource = ScheduleManager.Get_All(
                startDateTimePicker.Value, endDateTimePicker.Value);
            scheduleDataGridView.Columns[0].DataPropertyName = "Date_S";
            scheduleDataGridView.Columns[1].DataPropertyName = "VehicleRegNo";
            scheduleDataGridView.Columns[2].DataPropertyName = "Shift";
        }
    }
}
