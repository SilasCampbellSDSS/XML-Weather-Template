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
        public int weatherValue = Convert.ToInt32(Form1.dayList[0].icon);

        public double precipitationChance1 = Convert.ToDouble(Form1.dayList[1].precipitationChance) * 100;
        public double precipitationChance2 = Convert.ToDouble(Form1.dayList[2].precipitationChance) * 100;
        public double precipitationChance3 = Convert.ToDouble(Form1.dayList[3].precipitationChance) * 100;
        public double precipitationChance4 = Convert.ToDouble(Form1.dayList[4].precipitationChance) * 100;
        public double precipitationChance5 = Convert.ToDouble(Form1.dayList[5].precipitationChance) * 100;
        public double precipitationChance6 = Convert.ToDouble(Form1.dayList[6].precipitationChance) * 100;

        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            if (weatherValue > 800 || weatherValue > 700 && weatherValue < 782)
            {
                BackgroundImage = Properties.Resources.Forecast_Cloudy_Sky__2_;
            }
            else if (weatherValue == 800)
            {
                BackgroundImage = Properties.Resources.Forecast_Clear_Sky__2_;
            }
            else if (weatherValue > 199 && weatherValue < 505 || weatherValue > 519 && weatherValue < 532)
            {
                BackgroundImage = Properties.Resources.Forecast_Rainy_Sky__2_;
            }
            else
            {
                BackgroundImage = Properties.Resources.Forecast_Snowy_Sky__2_;
                forecastLabel.ForeColor = Color.Black;
                underscore.ForeColor = Color.Black;
            }

            date1.Text = Form1.dayList[1].date;
            date2.Text = Form1.dayList[2].date;
            date3.Text = Form1.dayList[3].date;
            date4.Text = Form1.dayList[4].date;
            date5.Text = Form1.dayList[5].date;
            date6.Text = Form1.dayList[6].date;

            minMax1.Text = $"{Form1.dayList[1].tempLow} °C    -    {Form1.dayList[1].tempHigh} °C";
            minMax2.Text = $"{Form1.dayList[2].tempLow} °C    -    {Form1.dayList[2].tempHigh} °C";
            minMax3.Text = $"{Form1.dayList[3].tempLow} °C    -    {Form1.dayList[3].tempHigh} °C";
            minMax4.Text = $"{Form1.dayList[4].tempLow} °C    -    {Form1.dayList[4].tempHigh} °C";
            minMax5.Text = $"{Form1.dayList[5].tempLow} °C    -    {Form1.dayList[5].tempHigh} °C";
            minMax6.Text = $"{Form1.dayList[6].tempLow} °C    -    {Form1.dayList[6].tempHigh} °C";

            if (Form1.dayList[1].precipitationChance == "0")
            {
                futureWeather1.Text = $"{Form1.dayList[1].futureClouds} with no chance of precipitation";
            }
            else
            {

                futureWeather1.Text = $"{Form1.dayList[1].futureClouds} with a {precipitationChance1}% chance of {Form1.dayList[1].futurePrecipitationType}";
            }

            if (Form1.dayList[2].precipitationChance == "0")
            {
                futureWeather2.Text = $"{Form1.dayList[2].futureClouds} with no chance of precipitation";
            }
            else
            {
                futureWeather2.Text = $"{Form1.dayList[2].futureClouds} with a {precipitationChance2}% chance of {Form1.dayList[2].futurePrecipitationType}";
            }

            if (Form1.dayList[3].precipitationChance == "0")
            {
                futureWeather3.Text = $"{Form1.dayList[3].futureClouds} with no chance of precipitation";
            }
            else
            {
                futureWeather3.Text = $"{Form1.dayList[3].futureClouds} with a {precipitationChance3}% chance of {Form1.dayList[3].futurePrecipitationType}";
            }

            if (Form1.dayList[4].precipitationChance == "0")
            {
                futureWeather4.Text = $"{Form1.dayList[4].futureClouds} with no chance of precipitation";
            }
            else
            {
                futureWeather4.Text = $"{Form1.dayList[4].futureClouds} with a {precipitationChance4}% chance of {Form1.dayList[4].futurePrecipitationType}";
            }

            if (Form1.dayList[5].precipitationChance == "0")
            {
                futureWeather5.Text = $"{Form1.dayList[5].futureClouds} with no chance of precipitation";
            }
            else
            {
                futureWeather5.Text = $"{Form1.dayList[5].futureClouds} with a {precipitationChance5}% chance of {Form1.dayList[5].futurePrecipitationType}";
            }

            if (Form1.dayList[1].precipitationChance == "0")
            {
                futureWeather6.Text = $"{Form1.dayList[6].futureClouds} with no chance of precipitation";
            }
            else
            {
                futureWeather6.Text = $"{Form1.dayList[6].futureClouds} with a {precipitationChance6}% chance of {Form1.dayList[6].futurePrecipitationType}";
            }
        }

        private void dateOutput_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
