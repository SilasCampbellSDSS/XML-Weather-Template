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

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        public static List<Day> dayList = new List<Day>();
        public static string currentCity = "Stratford,CA";

        public Form1()
        {
            InitializeComponent();
            ExtractForecast();
            ExtractCurrent();
            
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public void ExtractForecast()
        {
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/forecast/daily?q={currentCity}&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0");

            while (reader.Read())
            {
                Day d = new Day();

                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.futurePrecipitationType = reader.GetAttribute("name");

                reader.ReadToFollowing("precipitation");
                d.precipitationChance = reader.GetAttribute("probability");

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                reader.ReadToFollowing("clouds");
                d.futureClouds = reader.GetAttribute("value");

                dayList.Add(d);
            }
        }

        public void ExtractCurrent()
        {
            XmlReader reader = XmlReader.Create($"http://api.openweathermap.org/data/2.5/weather?q={currentCity}&mode=xml&units=metric&appid=3f2e224b815c0ed45524322e145149f0");

            reader.ReadToFollowing("city");
            dayList[0].location = reader.GetAttribute("name");

            reader.ReadToFollowing("temperature");
            dayList[0].currentTemp = reader.GetAttribute("value");

            reader.ReadToFollowing("feels_like");
            dayList[0].feelsLike = reader.GetAttribute("value");

            reader.ReadToFollowing("clouds");
            dayList[0].condition = reader.GetAttribute("name");

            reader.ReadToFollowing("precipitation");
            dayList[0].precipitation = reader.GetAttribute("mode");

            reader.ReadToFollowing("weather");
            dayList[0].precipitationType = reader.GetAttribute("value");
            dayList[0].icon = reader.GetAttribute("number");
        }     
    }
}
