namespace VehicleInfoApp1.UI
{
    partial class SelectOptionUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.insertVehcleButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.scheduleVehicleutton = new System.Windows.Forms.Button();
            this.viewScheduleButton = new System.Windows.Forms.Button();
            this.viewDateBetweenScheduleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // insertVehcleButton
            // 
            this.insertVehcleButton.Location = new System.Drawing.Point(159, 47);
            this.insertVehcleButton.Name = "insertVehcleButton";
            this.insertVehcleButton.Size = new System.Drawing.Size(157, 45);
            this.insertVehcleButton.TabIndex = 0;
            this.insertVehcleButton.Text = "Insert   Vehicle";
            this.insertVehcleButton.UseVisualStyleBackColor = true;
            this.insertVehcleButton.Click += new System.EventHandler(this.insertVehcleButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(159, 398);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(157, 36);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // scheduleVehicleutton
            // 
            this.scheduleVehicleutton.Location = new System.Drawing.Point(159, 116);
            this.scheduleVehicleutton.Name = "scheduleVehicleutton";
            this.scheduleVehicleutton.Size = new System.Drawing.Size(157, 45);
            this.scheduleVehicleutton.TabIndex = 2;
            this.scheduleVehicleutton.Text = "Schedule   Vehicle";
            this.scheduleVehicleutton.UseVisualStyleBackColor = true;
            this.scheduleVehicleutton.Click += new System.EventHandler(this.scheduleVehicleutton_Click);
            // 
            // viewScheduleButton
            // 
            this.viewScheduleButton.Location = new System.Drawing.Point(159, 189);
            this.viewScheduleButton.Name = "viewScheduleButton";
            this.viewScheduleButton.Size = new System.Drawing.Size(239, 47);
            this.viewScheduleButton.TabIndex = 3;
            this.viewScheduleButton.Text = "View   Schedule   of   a   Vehicle   :-";
            this.viewScheduleButton.UseVisualStyleBackColor = true;
            this.viewScheduleButton.Click += new System.EventHandler(this.viewScheduleButton_Click);
            // 
            // viewDateBetweenScheduleButton
            // 
            this.viewDateBetweenScheduleButton.Location = new System.Drawing.Point(159, 270);
            this.viewDateBetweenScheduleButton.Name = "viewDateBetweenScheduleButton";
            this.viewDateBetweenScheduleButton.Size = new System.Drawing.Size(262, 43);
            this.viewDateBetweenScheduleButton.TabIndex = 4;
            this.viewDateBetweenScheduleButton.Text = "View   Date   Between   Schedule   :-";
            this.viewDateBetweenScheduleButton.UseVisualStyleBackColor = true;
            this.viewDateBetweenScheduleButton.Click += new System.EventHandler(this.viewDateBetweenScheduleButton_Click);
            // 
            // SelectOptionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 483);
            this.Controls.Add(this.viewDateBetweenScheduleButton);
            this.Controls.Add(this.viewScheduleButton);
            this.Controls.Add(this.scheduleVehicleutton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.insertVehcleButton);
            this.Name = "SelectOptionUI";
            this.Text = "Select   an   Option   :-";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insertVehcleButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button scheduleVehicleutton;
        private System.Windows.Forms.Button viewScheduleButton;
        private System.Windows.Forms.Button viewDateBetweenScheduleButton;
    }
}