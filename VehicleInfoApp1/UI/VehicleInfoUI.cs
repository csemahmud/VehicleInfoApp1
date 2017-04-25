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
    public partial class VehicleInfoUI : Form
    {
        public VehicleInfoUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(VehicleManager.Insert_Vehicle(
                regNoTextBox.Text, engineNoTextBox.Text));

            regNoTextBox.Text = string.Empty;
            engineNoTextBox.Text = string.Empty;
        }
    }
}
