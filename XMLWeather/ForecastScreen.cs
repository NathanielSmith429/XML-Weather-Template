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
    public partial class ForecastScreen : UserControl
    {
        double outsideWeather;

        List<Label> weekday = new List<Label>();

        List <PictureBox> pictureBoxes = new List<PictureBox>();

        List<Label> highTempature = new List<Label>();

        public ForecastScreen()
        {
            InitializeComponent();

            // adding days of the week
            weekday.Add(dayLabel0);
            weekday.Add(dayLabel1);
            weekday.Add(dayLabel2);
            weekday.Add(dayLabel3);
            weekday.Add(dayLabel4);
            weekday.Add(dayLabel5);
            weekday.Add(dayLabel6);

            //adding weather images
            pictureBoxes.Add(dayBox0);
            pictureBoxes.Add(dayBox1);
            pictureBoxes.Add(dayBox2);
            pictureBoxes.Add(dayBox3);
            pictureBoxes.Add(dayBox4);
            pictureBoxes.Add(dayBox5);
            pictureBoxes.Add(dayBox6);

            //adding max tempatures
            highTempature.Add(dayMax0);
            highTempature.Add(dayMax1);
            highTempature.Add(dayMax2);
            highTempature.Add(dayMax3);
            highTempature.Add(dayMax4);
            highTempature.Add(dayMax5);
            highTempature.Add(dayMax6);



            displayForecast();
        }

        public void displayForecast()
        {
         for (int i = 6; i >=0; i--) // reversed to show the current weather background
            {

                weekday[i].Text = Form1.days[i].dayOfWeek;

                highTempature[i].Text = $"{Math.Round(Convert.ToDouble(Form1.days[i].tempHigh))}°";

                outsideWeather = Convert.ToDouble(Form1.days[i].weatherNumber);

                if (outsideWeather < 300 && outsideWeather >= 200)
                {
                    pictureBoxes[i].Image = Properties.Resources.thunderstrom;
                    BackgroundImage = Properties.Resources.thunderBackground;

                }
                else if (outsideWeather >= 300 && outsideWeather < 400)
                {
                    pictureBoxes[i].Image = Properties.Resources.showerRain;
                    BackgroundImage = Properties.Resources.showerRainBackground;
                }
                else if (outsideWeather >= 500 && outsideWeather < 600)
                {
                    pictureBoxes[i].Image = Properties.Resources.rain;
                    BackgroundImage = Properties.Resources.rainBackground;
                }
                else if (outsideWeather >= 600 && outsideWeather < 700)
                {
                    pictureBoxes[i].Image = Properties.Resources.snow;
                    BackgroundImage = Properties.Resources.snowBackground;
                }
                else if (outsideWeather >= 700 && outsideWeather < 800)
                {
                    pictureBoxes[i].Image = Properties.Resources.mist;
                    BackgroundImage = Properties.Resources.mistBackground;
                }
                else if (outsideWeather >= 800)
                {
                    pictureBoxes[i].Image = Properties.Resources.clearSky;
                    BackgroundImage = Properties.Resources.clearBackground;
                }
                else if (outsideWeather <= 80)
                {
                    pictureBoxes[i].Image = Properties.Resources.scatterdClouds;
                    BackgroundImage = Properties.Resources.cloudBackgrounds;
                }
            }
          
        }

        private void todayScreen_Click(object sender, EventArgs e) //changing to current screen
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void searchLabel_Click(object sender, EventArgs e) //changing to search screen
        {
            Form s = this.FindForm();
            s.Controls.Remove(this);

            SearchScreen fs = new SearchScreen();
            s.Controls.Add(fs);
        }
    }
}
