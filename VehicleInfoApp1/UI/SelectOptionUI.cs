using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//   MAHMUDUL   HASAN   KHAN
//   BASIS   5

namespace VehicleInfoApp1.UI
{
    public partial class SelectOptionUI : Form
    {
        public SelectOptionUI()
        {
            InitializeComponent();
        }

        private void insertVehcleButton_Click(object sender, EventArgs e)
        {
            VehicleInfoUI aVehicleInfoUI = new VehicleInfoUI();
            aVehicleInfoUI.ShowDialog(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void scheduleVehicleutton_Click(object sender, EventArgs e)
        {
            ScheduleVehicleUI aScheduleVehicleUI = new ScheduleVehicleUI();
            aScheduleVehicleUI.ShowDialog(this);
        }

        private void viewScheduleButton_Click(object sender, EventArgs e)
        {
            ViewScheduleUI aViewScheduleUI = new ViewScheduleUI();
            aViewScheduleUI.ShowDialog(this);
        }

        private void viewDateBetweenScheduleButton_Click(object sender, EventArgs e)
        {
            ViewDateBetweenScheduleUI aViewDateBetweenScheduleUI 
                = new ViewDateBetweenScheduleUI();
            aViewDateBetweenScheduleUI.ShowDialog(this);
        }
    }
}
