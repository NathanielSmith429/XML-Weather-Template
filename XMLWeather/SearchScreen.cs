using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class SearchScreen : UserControl
    {
        public SearchScreen()
        {
            InitializeComponent();
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            // errorLabel.Text = "Please input City";
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void todayLabel_Click(object sender, EventArgs e)
        {
            // errorLabel.Text = "Please input City";
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);


        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Form1.oldLocation = Form1.location; //rembering the previous location
            try // trying to find the loction
            {
                Form1.location = inputBox.Text;
                Form1.days.Clear();
                Form1.ExtractForecast();
                Form1.ExtractCurrent();

                Form s = this.FindForm(); // showing the new info
                s.Controls.Remove(this);
                CurrentScreen fs = new CurrentScreen();
                s.Controls.Add(fs);

            }
            catch 
            {
                inputBox.Text = "";
                errorLabel.Text = "Input not valid";
                Form1.location = Form1.oldLocation; // reverting to the old location
                Form1.ExtractForecast();
                Form1.ExtractCurrent();
            }
        }
    }
}
