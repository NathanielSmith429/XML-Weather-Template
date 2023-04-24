namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maxLabel = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.windsLabel = new System.Windows.Forms.Label();
            this.humidityLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.weatherBox = new System.Windows.Forms.PictureBox();
            this.dateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox)).BeginInit();
            this.SuspendLayout();
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(158, 430);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(74, 35);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            this.maxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(261, 430);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(66, 35);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            this.minLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 128);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // tempLabel
            // 
            this.tempLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempLabel.Font = new System.Drawing.Font("Berlin Sans FB", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.ForeColor = System.Drawing.Color.White;
            this.tempLabel.Location = new System.Drawing.Point(89, 176);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(357, 95);
            this.tempLabel.TabIndex = 26;
            this.tempLabel.Text = "Current";
            this.tempLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(180, 13);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(37, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.White;
            this.cityOutput.Location = new System.Drawing.Point(128, 128);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(249, 48);
            this.cityOutput.TabIndex = 22;
            this.cityOutput.Text = "City";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weatherLabel
            // 
            this.weatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.weatherLabel.Font = new System.Drawing.Font("Berlin Sans FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherLabel.ForeColor = System.Drawing.Color.White;
            this.weatherLabel.Location = new System.Drawing.Point(128, 359);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(249, 48);
            this.weatherLabel.TabIndex = 43;
            this.weatherLabel.Text = "weather";
            this.weatherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // windsLabel
            // 
            this.windsLabel.BackColor = System.Drawing.Color.Transparent;
            this.windsLabel.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windsLabel.ForeColor = System.Drawing.Color.White;
            this.windsLabel.Location = new System.Drawing.Point(33, 503);
            this.windsLabel.Name = "windsLabel";
            this.windsLabel.Size = new System.Drawing.Size(432, 48);
            this.windsLabel.TabIndex = 45;
            this.windsLabel.Text = "Wind speeds";
            this.windsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // humidityLabel
            // 
            this.humidityLabel.BackColor = System.Drawing.Color.Transparent;
            this.humidityLabel.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityLabel.ForeColor = System.Drawing.Color.White;
            this.humidityLabel.Location = new System.Drawing.Point(33, 551);
            this.humidityLabel.Name = "humidityLabel";
            this.humidityLabel.Size = new System.Drawing.Size(432, 48);
            this.humidityLabel.TabIndex = 46;
            this.humidityLabel.Text = "Humidity";
            this.humidityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchLabel
            // 
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.White;
            this.searchLabel.Location = new System.Drawing.Point(302, 13);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(83, 28);
            this.searchLabel.TabIndex = 89;
            this.searchLabel.Text = "Search";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // weatherBox
            // 
            this.weatherBox.BackColor = System.Drawing.Color.Transparent;
            this.weatherBox.Location = new System.Drawing.Point(197, 275);
            this.weatherBox.Name = "weatherBox";
            this.weatherBox.Size = new System.Drawing.Size(97, 81);
            this.weatherBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.weatherBox.TabIndex = 44;
            this.weatherBox.TabStop = false;
            // 
            // dateLabel
            // 
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.White;
            this.dateLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateLabel.Location = new System.Drawing.Point(33, 599);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(432, 51);
            this.dateLabel.TabIndex = 90;
            this.dateLabel.Text = "Day";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.humidityLabel);
            this.Controls.Add(this.windsLabel);
            this.Controls.Add(this.weatherBox);
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(500, 750);
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.PictureBox weatherBox;
        private System.Windows.Forms.Label windsLabel;
        private System.Windows.Forms.Label humidityLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label dateLabel;
    }
}
