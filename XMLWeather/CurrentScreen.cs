using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Drawing.Text;

namespace XMLWeather
{
    public partial class CurrentScreen : UserControl
    {
        public int weatherValue = Convert.ToInt32(Form1.dayList[0].icon);

        public CurrentScreen()
        {
            InitializeComponent();
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            DisplayBackgroud();
            
            if (weatherValue >= 200 && weatherValue < 300)
            {
               weatherLabel.Image = Properties.Resources._11d_2x__1_;
            }
            else if (weatherValue >= 300 && weatherValue < 400 || weatherValue >= 520 && weatherValue < 532)
            {
               weatherLabel.Image = Properties.Resources._09d_2x__1_;
            }
            else if (weatherValue >= 500 && weatherValue < 505)
            {
               weatherLabel.Image = Properties.Resources._10d_2x__1_;
            }
            else if (weatherValue >= 600 && weatherValue < 623 || weatherValue == 511)
            {
               weatherLabel.Image = Properties.Resources._13d_2x__1_;
            }
            else if (weatherValue >= 701 && weatherValue < 782)
            {
               weatherLabel.Image = Properties.Resources._50d_2x;
            }
            else if (weatherValue == 800)
            {
                weatherLabel.Image = Properties.Resources._01d_2x;
            }
            else if (weatherValue == 801)
            {
                weatherLabel.Image = Properties.Resources._02d_2x__1_;
            }
            else if (weatherValue == 802)
            {
                weatherLabel.Image = Properties.Resources._03d1;
            }
            else if (weatherValue == 803 || weatherValue == 804)
            {
                weatherLabel.Image = Properties.Resources._04d_2x;
            }

            currentLabel.Text = $"{Form1.dayList[0].currentTemp} °C";
            searchBox.Text = Form1.dayList[0].location;
            cityOutput.Text = Form1.dayList[0].location;
            feelsLikeOutput.Text = $"{Form1.dayList[0].feelsLike} °C";
            minOutput.Text = $"{Form1.dayList[0].tempLow} °C";
            maxOutput.Text = $"{Form1.dayList[0].tempHigh} °C";
            dateOutput.Text = Form1.dayList[0].date;

            if (weatherValue > 700)
            {
                weather.Text = $"{Form1.dayList[0].condition} with no precipitation";
            }
            else
            {
                weather.Text = $"{Form1.dayList[0].condition} with {Form1.dayList[0].precipitationType}";
            }
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string newCity = searchBox.Text;
                Form1.currentCity = newCity;

                Form1.dayList.Clear();
                Form1 f = (Form1)this.FindForm();
                f.ExtractForecast();
                f.ExtractCurrent();

                f.Controls.Clear();
                CurrentScreen cs = new CurrentScreen();
                f.Controls.Add(cs);

                DisplayBackgroud();
            }
            catch
            {
                searchBox.Text = "ERROR";
            }
        }    

        public void DisplayBackgroud()
        {
            if (weatherValue > 800 || weatherValue > 700 && weatherValue < 782)
            {
                BackgroundImage = Properties.Resources.New_Cloudy_Sky__2_;
            }
            else if (weatherValue == 800)
            {
                BackgroundImage = Properties.Resources.New_Clear_Sky__2_;
                currentLabel.ForeColor = Color.Black;
                feelsLikeLabel.ForeColor = Color.Black;
                minLabel.ForeColor = Color.Black;
                maxLabel.ForeColor = Color.Black;
                todayLabel.ForeColor = Color.Black;
                underscore.ForeColor = Color.Black;
                forecastLabel.ForeColor = Color.Black;
            }
            else if (weatherValue > 199 && weatherValue < 505 || weatherValue > 519 && weatherValue < 532)
            {
                BackgroundImage = Properties.Resources.New_Rainy_Sky__2_;
                currentLabel.ForeColor = Color.Black;
            }
            else
            {
                BackgroundImage = Properties.Resources.New_Snowy_Sky;
                ccc.ForeColor = Color.Black;
                weather.ForeColor = Color.White;
            }
        }
    }
}
