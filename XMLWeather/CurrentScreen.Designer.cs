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
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.todayLabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.underscore = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.feelsLikeLabel = new System.Windows.Forms.Label();
            this.weather = new System.Windows.Forms.Label();
            this.cityOutput = new System.Windows.Forms.Label();
            this.dateOutput = new System.Windows.Forms.Label();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.feelsLikeOutput = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.currentLabel = new System.Windows.Forms.Label();
            this.ccc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(106, 365);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(113, 13);
            this.maxOutput.TabIndex = 32;
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(10, 365);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(38, 18);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "MAX";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(106, 342);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(113, 13);
            this.minOutput.TabIndex = 30;
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.BackColor = System.Drawing.Color.Transparent;
            this.minLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(10, 342);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(35, 18);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "MIN";
            // 
            // todayLabel
            // 
            this.todayLabel.BackColor = System.Drawing.Color.Transparent;
            this.todayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayLabel.ForeColor = System.Drawing.Color.White;
            this.todayLabel.Location = new System.Drawing.Point(13, 418);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(209, 28);
            this.todayLabel.TabIndex = 40;
            this.todayLabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(13, 456);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(209, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "7 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // underscore
            // 
            this.underscore.BackColor = System.Drawing.Color.Transparent;
            this.underscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underscore.ForeColor = System.Drawing.Color.White;
            this.underscore.Location = new System.Drawing.Point(11, 424);
            this.underscore.Name = "underscore";
            this.underscore.Size = new System.Drawing.Size(115, 27);
            this.underscore.TabIndex = 42;
            this.underscore.Text = "____________________________";
            this.underscore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(85, 253);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 44;
            // 
            // feelsLikeLabel
            // 
            this.feelsLikeLabel.BackColor = System.Drawing.Color.Transparent;
            this.feelsLikeLabel.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feelsLikeLabel.ForeColor = System.Drawing.Color.White;
            this.feelsLikeLabel.Location = new System.Drawing.Point(10, 319);
            this.feelsLikeLabel.Name = "feelsLikeLabel";
            this.feelsLikeLabel.Size = new System.Drawing.Size(79, 18);
            this.feelsLikeLabel.TabIndex = 48;
            this.feelsLikeLabel.Text = "FEELS LIKE";
            // 
            // weather
            // 
            this.weather.BackColor = System.Drawing.Color.Transparent;
            this.weather.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weather.ForeColor = System.Drawing.Color.Black;
            this.weather.Location = new System.Drawing.Point(34, 75);
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(207, 31);
            this.weather.TabIndex = 50;
            this.weather.Text = "Weather";
            this.weather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cityOutput
            // 
            this.cityOutput.BackColor = System.Drawing.Color.Transparent;
            this.cityOutput.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityOutput.ForeColor = System.Drawing.Color.Black;
            this.cityOutput.Location = new System.Drawing.Point(34, 198);
            this.cityOutput.Name = "cityOutput";
            this.cityOutput.Size = new System.Drawing.Size(207, 31);
            this.cityOutput.TabIndex = 51;
            this.cityOutput.Text = "cityOutput";
            this.cityOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateOutput
            // 
            this.dateOutput.BackColor = System.Drawing.Color.Transparent;
            this.dateOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOutput.ForeColor = System.Drawing.Color.Black;
            this.dateOutput.Location = new System.Drawing.Point(57, 222);
            this.dateOutput.Name = "dateOutput";
            this.dateOutput.Size = new System.Drawing.Size(160, 25);
            this.dateOutput.TabIndex = 52;
            this.dateOutput.Text = "YYYY/MM/DD";
            this.dateOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // weatherLabel
            // 
            this.weatherLabel.BackColor = System.Drawing.Color.Transparent;
            this.weatherLabel.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherLabel.ForeColor = System.Drawing.Color.White;
            this.weatherLabel.Location = new System.Drawing.Point(46, 125);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(184, 73);
            this.weatherLabel.TabIndex = 54;
            this.weatherLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // feelsLikeOutput
            // 
            this.feelsLikeOutput.BackColor = System.Drawing.Color.White;
            this.feelsLikeOutput.Location = new System.Drawing.Point(106, 319);
            this.feelsLikeOutput.Name = "feelsLikeOutput";
            this.feelsLikeOutput.Size = new System.Drawing.Size(113, 13);
            this.feelsLikeOutput.TabIndex = 49;
            // 
            // searchButton
            // 
            this.searchButton.Image = global::XMLWeather.Properties.Resources.search;
            this.searchButton.Location = new System.Drawing.Point(197, 248);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(25, 25);
            this.searchButton.TabIndex = 46;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // currentLabel
            // 
            this.currentLabel.BackColor = System.Drawing.Color.Transparent;
            this.currentLabel.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLabel.ForeColor = System.Drawing.Color.White;
            this.currentLabel.Location = new System.Drawing.Point(0, 0);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(275, 73);
            this.currentLabel.TabIndex = 45;
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ccc
            // 
            this.ccc.BackColor = System.Drawing.Color.Transparent;
            this.ccc.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccc.ForeColor = System.Drawing.Color.White;
            this.ccc.Location = new System.Drawing.Point(82, 276);
            this.ccc.Name = "ccc";
            this.ccc.Size = new System.Drawing.Size(103, 31);
            this.ccc.TabIndex = 53;
            this.ccc.Text = "City, Country Code";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.ccc);
            this.Controls.Add(this.dateOutput);
            this.Controls.Add(this.cityOutput);
            this.Controls.Add(this.weather);
            this.Controls.Add(this.feelsLikeOutput);
            this.Controls.Add(this.feelsLikeLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.underscore);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(275, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label underscore;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label feelsLikeOutput;
        private System.Windows.Forms.Label feelsLikeLabel;
        private System.Windows.Forms.Label weather;
        private System.Windows.Forms.Label cityOutput;
        private System.Windows.Forms.Label dateOutput;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Label ccc;
    }
}
