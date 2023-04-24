using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Web;
using System.Security.Cryptography.X509Certificates;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // list to hold day objects
      public static List <Day> days =new List<Day>();
      public static string location = "Stratford,CA";
        public static string oldLocation = "Stratford,CA";


        public Form1()
        {
          
            InitializeComponent();
            ExtractForecast();
            ExtractCurrent();
            
            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast() // Extracting the 7 day forcast
        {
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={location}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {

                //create a day object
                Day d = new Day();

                //fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");
                d.dayOfWeek =  Convert.ToDateTime(reader.GetAttribute("day")).ToString("dddd");

                reader.ReadToFollowing("symbol");
                d.weatherNumber = reader.GetAttribute("number");

                reader.ReadToFollowing("precipitation");

                d.precipitationChance = reader.GetAttribute("probability");
                d.precipitationType = reader.GetAttribute("type");  

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");


                // if day object not null add to the days list
                if (d.date != null)
                {
                days.Add(d);
                }

            }
        }
        

        public static void ExtractCurrent() //extracting the daily forcast
        {
            // current info is not included in forecast file so we need to use this file to get it
            string URL = $"http://api.openweathermap.org/data/2.5/weather?q={location}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0";
            XmlReader reader = XmlReader.Create(URL);

            // find the city and current temperature and add to appropriate item in days list

            reader.ReadToFollowing("city");
            days[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            days[0].currentTemp = reader.GetAttribute("value");
            days[0].tempLow = reader.GetAttribute("min");
            days[0].tempHigh = reader.GetAttribute("max");

            reader.ReadToFollowing("humidity");
            days[0].humidity = reader.GetAttribute("value");

            reader.ReadToFollowing("speed");
            days[0].windSpeed = reader.GetAttribute("value");
            days[0].windName = reader.GetAttribute("name");

            reader.ReadToFollowing("weather");
            days[0].weatherNumber = reader.GetAttribute("number");
            days[0].weatherValue = reader.GetAttribute("value");

        }


    }
}
