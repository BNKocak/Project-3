namespace Connection_to_database
{
    partial class Main
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Streetnames = new System.Windows.Forms.Button();
            this.Streetname = new System.Windows.Forms.Label();
            this.Parkinglot = new System.Windows.Forms.Button();
            this.ParkinglotTxt = new System.Windows.Forms.Label();
            this.StreetBox = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.select = new System.Windows.Forms.ComboBox();
            this.Value1 = new System.Windows.Forms.TextBox();
            this.Value2 = new System.Windows.Forms.TextBox();
            this.Search2 = new System.Windows.Forms.Button();
            this.Keuze1 = new System.Windows.Forms.ComboBox();
            this.keuze3 = new System.Windows.Forms.ComboBox();
            this.Amount1 = new System.Windows.Forms.TextBox();
            this.Amount2 = new System.Windows.Forms.TextBox();
            this.ShowMap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // Streetnames
            // 
            this.Streetnames.Location = new System.Drawing.Point(3, 3);
            this.Streetnames.Name = "Streetnames";
            this.Streetnames.Size = new System.Drawing.Size(120, 28);
            this.Streetnames.TabIndex = 3;
            this.Streetnames.Text = "Street Names";
            this.Streetnames.UseVisualStyleBackColor = true;
            this.Streetnames.Click += new System.EventHandler(this.button2_Click);
            // 
            // Streetname
            // 
            this.Streetname.AutoSize = true;
            this.Streetname.Location = new System.Drawing.Point(773, 33);
            this.Streetname.Name = "Streetname";
            this.Streetname.Size = new System.Drawing.Size(126, 13);
            this.Streetname.TabIndex = 4;
            this.Streetname.Text = "Put here the street name:";
            this.Streetname.Click += new System.EventHandler(this.Streetname_Click);
            // 
            // Parkinglot
            // 
            this.Parkinglot.Location = new System.Drawing.Point(129, 3);
            this.Parkinglot.Name = "Parkinglot";
            this.Parkinglot.Size = new System.Drawing.Size(120, 28);
            this.Parkinglot.TabIndex = 5;
            this.Parkinglot.Text = "Parkinglot";
            this.Parkinglot.UseVisualStyleBackColor = true;
            this.Parkinglot.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ParkinglotTxt
            // 
            this.ParkinglotTxt.AutoSize = true;
            this.ParkinglotTxt.Location = new System.Drawing.Point(781, 33);
            this.ParkinglotTxt.Name = "ParkinglotTxt";
            this.ParkinglotTxt.Size = new System.Drawing.Size(117, 13);
            this.ParkinglotTxt.TabIndex = 7;
            this.ParkinglotTxt.Text = "Put here the parkinglot:";
            this.ParkinglotTxt.Visible = false;
            this.ParkinglotTxt.Click += new System.EventHandler(this.ParkinglotTxt_Click);
            // 
            // StreetBox
            // 
            this.StreetBox.FormattingEnabled = true;
            this.StreetBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.StreetBox.Items.AddRange(new object[] {
            "Bouwjaar"});
            this.StreetBox.Location = new System.Drawing.Point(904, 33);
            this.StreetBox.Name = "StreetBox";
            this.StreetBox.Size = new System.Drawing.Size(121, 21);
            this.StreetBox.TabIndex = 9;
            this.StreetBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(87, 216);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Amount of Streets";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Amount of Pay Methods";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Amount of Services";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Amount of Parking Spaces";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(811, 377);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // select
            // 
            this.select.FormattingEnabled = true;
            this.select.Location = new System.Drawing.Point(332, 146);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(121, 21);
            this.select.TabIndex = 11;
            this.select.Visible = false;
            this.select.SelectedIndexChanged += new System.EventHandler(this.Select_SelectedIndexChanged);
            // 
            // Value1
            // 
            this.Value1.Location = new System.Drawing.Point(226, 147);
            this.Value1.Name = "Value1";
            this.Value1.Size = new System.Drawing.Size(100, 20);
            this.Value1.TabIndex = 12;
            this.Value1.Visible = false;
            this.Value1.TextChanged += new System.EventHandler(this.Value1_TextChanged);
            // 
            // Value2
            // 
            this.Value2.Location = new System.Drawing.Point(459, 147);
            this.Value2.Name = "Value2";
            this.Value2.Size = new System.Drawing.Size(100, 20);
            this.Value2.TabIndex = 13;
            this.Value2.Visible = false;
            this.Value2.TextChanged += new System.EventHandler(this.Value2_TextChanged);
            // 
            // Search2
            // 
            this.Search2.Location = new System.Drawing.Point(586, 147);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(75, 23);
            this.Search2.TabIndex = 14;
            this.Search2.Text = "Search";
            this.Search2.UseVisualStyleBackColor = true;
            this.Search2.Visible = false;
            this.Search2.Click += new System.EventHandler(this.Search2_Click);
            // 
            // Keuze1
            // 
            this.Keuze1.FormattingEnabled = true;
            this.Keuze1.Location = new System.Drawing.Point(205, 146);
            this.Keuze1.Name = "Keuze1";
            this.Keuze1.Size = new System.Drawing.Size(121, 21);
            this.Keuze1.TabIndex = 15;
            this.Keuze1.Visible = false;
            this.Keuze1.SelectedIndexChanged += new System.EventHandler(this.Keuze1_SelectedIndexChanged);
            // 
            // keuze3
            // 
            this.keuze3.FormattingEnabled = true;
            this.keuze3.Location = new System.Drawing.Point(459, 146);
            this.keuze3.Name = "keuze3";
            this.keuze3.Size = new System.Drawing.Size(121, 21);
            this.keuze3.TabIndex = 16;
            this.keuze3.Visible = false;
            this.keuze3.SelectedIndexChanged += new System.EventHandler(this.keuze3_SelectedIndexChanged);
            // 
            // Amount1
            // 
            this.Amount1.Location = new System.Drawing.Point(214, 190);
            this.Amount1.Name = "Amount1";
            this.Amount1.Size = new System.Drawing.Size(100, 20);
            this.Amount1.TabIndex = 17;
            this.Amount1.Visible = false;
            // 
            // Amount2
            // 
            this.Amount2.Location = new System.Drawing.Point(469, 190);
            this.Amount2.Name = "Amount2";
            this.Amount2.Size = new System.Drawing.Size(100, 20);
            this.Amount2.TabIndex = 18;
            this.Amount2.Visible = false;
            // 
            // ShowMap
            // 
            this.ShowMap.Location = new System.Drawing.Point(1028, 190);
            this.ShowMap.Name = "ShowMap";
            this.ShowMap.Size = new System.Drawing.Size(75, 23);
            this.ShowMap.TabIndex = 20;
            this.ShowMap.Text = "Show Map";
            this.ShowMap.UseVisualStyleBackColor = true;
            this.ShowMap.Click += new System.EventHandler(this.ShowMap_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Connection_to_database.Properties.Resources.dasdsa;
            this.pictureBox1.Location = new System.Drawing.Point(952, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 422);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(87, 190);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Lift";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(831, 422);
            this.chart2.TabIndex = 28;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            this.chart2.Click += new System.EventHandler(this.chart2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 642);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.StreetBox);
            this.Controls.Add(this.ParkinglotTxt);
            this.Controls.Add(this.Parkinglot);
            this.Controls.Add(this.Streetname);
            this.Controls.Add(this.Streetnames);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ShowMap);
            this.Controls.Add(this.Amount2);
            this.Controls.Add(this.Amount1);
            this.Controls.Add(this.Search2);
            this.Controls.Add(this.keuze3);
            this.Controls.Add(this.Value2);
            this.Controls.Add(this.select);
            this.Controls.Add(this.Keuze1);
            this.Controls.Add(this.Value1);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Parkeerplaats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Streetnames;
        private System.Windows.Forms.Label Streetname;
        private System.Windows.Forms.Button Parkinglot;
        private System.Windows.Forms.Label ParkinglotTxt;
        private System.Windows.Forms.ComboBox StreetBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox select;
        private System.Windows.Forms.TextBox Value1;
        private System.Windows.Forms.TextBox Value2;
        private System.Windows.Forms.Button Search2;
        private System.Windows.Forms.ComboBox Keuze1;
        private System.Windows.Forms.ComboBox keuze3;
        private System.Windows.Forms.TextBox Amount1;
        private System.Windows.Forms.TextBox Amount2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ShowMap;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}