using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        double outsideWeather;
        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
        outsideWeather = Convert.ToDouble(Form1.days[0].weatherNumber);

            cityOutput.Text = $"{Form1.days[0].location}";
            tempLabel.Text = $"{Math.Round(Convert.ToDouble(Form1.days[0].currentTemp))}°"; // displaying all important weather information
            minLabel.Text = $"L: {Math.Round(Convert.ToDouble(Form1.days[0].tempLow))}°";
            maxLabel.Text = $"H: {Math.Round(Convert.ToDouble(Form1.days[0].tempHigh))}°";
            weatherLabel.Text = $"{Form1.days[0].weatherValue}";
            humidityLabel.Text = $" Humidity: {Form1.days[0].humidity}%";
            windsLabel.Text = $" Wind: {Form1.days[0].windSpeed}m/s | {Form1.days[0].windName}";

            if (outsideWeather < 300  && outsideWeather >= 200)
            {
                weatherBox.Image = Properties.Resources.thunderstrom;
                BackgroundImage = Properties.Resources.thunderBackground;

            }
            else if (outsideWeather >=300 && outsideWeather < 400)
            {
                weatherBox.Image = Properties.Resources.showerRain;
                BackgroundImage = Properties.Resources.showerRainBackground;
            }
            else if (outsideWeather >= 500 && outsideWeather < 600)
            {
                weatherBox.Image = Properties.Resources.rain;
                BackgroundImage = Properties.Resources.rainBackground;
            }
            else if (outsideWeather >= 600 && outsideWeather < 700)
            {
                weatherBox.Image = Properties.Resources.snow;
                BackgroundImage = Properties.Resources.snowBackground;
            }
            else if (outsideWeather >= 700 && outsideWeather < 800)
            {
                weatherBox.Image = Properties.Resources.mist;
                BackgroundImage = Properties.Resources.mistBackground;
            }
            else if (outsideWeather >= 800)
            {
                weatherBox.Image = Properties.Resources.clearSky;
                BackgroundImage = Properties.Resources.clearBackground;
            }
            else if (outsideWeather <= 80)
            {
                weatherBox.Image = Properties.Resources.scatterdClouds;
                BackgroundImage = Properties.Resources.cloudBackgrounds;
            }

        }

        private void forecastLabel_Click(object sender, EventArgs e) // travlling to forcast screen
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchLabel_Click(object sender, EventArgs e) // travlling to search screen
        {
            Form s = this.FindForm();
            s.Controls.Remove(this);

            SearchScreen fs = new SearchScreen();
            s.Controls.Add(fs);
        }

        private void CurrentScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
