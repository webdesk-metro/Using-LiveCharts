namespace LiveCharts
{
    partial class Form1
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
            System.Windows.Media.SolidColorBrush solidColorBrush1 = new System.Windows.Media.SolidColorBrush();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.AngularGauge = new MetroFramework.Controls.MetroTabPage();
            this.angularGauge1 = new LiveCharts.WinForms.AngularGauge();
            this.Cartesian = new MetroFramework.Controls.MetroTabPage();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.GeoMap = new MetroFramework.Controls.MetroTabPage();
            this.geoMap1 = new LiveCharts.WinForms.GeoMap();
            this.Pie = new MetroFramework.Controls.MetroTabPage();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.SolidGauge = new MetroFramework.Controls.MetroTabPage();
            this.solidGauge6 = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge5 = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge4 = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge3 = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge2 = new LiveCharts.WinForms.SolidGauge();
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.metroTabControl1.SuspendLayout();
            this.AngularGauge.SuspendLayout();
            this.Cartesian.SuspendLayout();
            this.GeoMap.SuspendLayout();
            this.Pie.SuspendLayout();
            this.SolidGauge.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.AngularGauge);
            this.metroTabControl1.Controls.Add(this.Cartesian);
            this.metroTabControl1.Controls.Add(this.GeoMap);
            this.metroTabControl1.Controls.Add(this.Pie);
            this.metroTabControl1.Controls.Add(this.SolidGauge);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 75);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(900, 465);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // AngularGauge
            // 
            this.AngularGauge.Controls.Add(this.angularGauge1);
            this.AngularGauge.HorizontalScrollbarBarColor = true;
            this.AngularGauge.HorizontalScrollbarHighlightOnWheel = false;
            this.AngularGauge.HorizontalScrollbarSize = 8;
            this.AngularGauge.Location = new System.Drawing.Point(4, 38);
            this.AngularGauge.Name = "AngularGauge";
            this.AngularGauge.Size = new System.Drawing.Size(892, 423);
            this.AngularGauge.TabIndex = 2;
            this.AngularGauge.Text = "Angular Gauge";
            this.AngularGauge.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.AngularGauge.VerticalScrollbarBarColor = true;
            this.AngularGauge.VerticalScrollbarHighlightOnWheel = false;
            this.AngularGauge.VerticalScrollbarSize = 9;
            // 
            // angularGauge1
            // 
            this.angularGauge1.BackColor = System.Drawing.Color.Transparent;
            this.angularGauge1.Location = new System.Drawing.Point(296, 61);
            this.angularGauge1.Name = "angularGauge1";
            this.angularGauge1.Size = new System.Drawing.Size(300, 300);
            this.angularGauge1.TabIndex = 3;
            this.angularGauge1.Text = "angularGauge1";
            // 
            // Cartesian
            // 
            this.Cartesian.Controls.Add(this.cartesianChart1);
            this.Cartesian.HorizontalScrollbarBarColor = true;
            this.Cartesian.HorizontalScrollbarHighlightOnWheel = false;
            this.Cartesian.HorizontalScrollbarSize = 5;
            this.Cartesian.Location = new System.Drawing.Point(4, 38);
            this.Cartesian.Name = "Cartesian";
            this.Cartesian.Padding = new System.Windows.Forms.Padding(50);
            this.Cartesian.Size = new System.Drawing.Size(892, 423);
            this.Cartesian.TabIndex = 0;
            this.Cartesian.Text = "Cartesian Chart";
            this.Cartesian.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Cartesian.VerticalScrollbarBarColor = true;
            this.Cartesian.VerticalScrollbarHighlightOnWheel = false;
            this.Cartesian.VerticalScrollbarSize = 7;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.Color.Transparent;
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Hoverable = true;
            this.cartesianChart1.Location = new System.Drawing.Point(50, 50);
            this.cartesianChart1.Name = "cartesianChart1";
            solidColorBrush1.Color = System.Windows.Media.Color.FromArgb(((byte)(30)), ((byte)(30)), ((byte)(30)), ((byte)(30)));
            this.cartesianChart1.ScrollBarFill = solidColorBrush1;
            this.cartesianChart1.ScrollHorizontalFrom = 0D;
            this.cartesianChart1.ScrollHorizontalTo = 0D;
            this.cartesianChart1.ScrollMode = LiveCharts.ScrollMode.None;
            this.cartesianChart1.ScrollVerticalFrom = 0D;
            this.cartesianChart1.ScrollVerticalTo = 0D;
            this.cartesianChart1.Size = new System.Drawing.Size(792, 323);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // GeoMap
            // 
            this.GeoMap.Controls.Add(this.geoMap1);
            this.GeoMap.HorizontalScrollbarBarColor = true;
            this.GeoMap.HorizontalScrollbarHighlightOnWheel = false;
            this.GeoMap.HorizontalScrollbarSize = 8;
            this.GeoMap.Location = new System.Drawing.Point(4, 38);
            this.GeoMap.Name = "GeoMap";
            this.GeoMap.Padding = new System.Windows.Forms.Padding(50, 15, 50, 15);
            this.GeoMap.Size = new System.Drawing.Size(892, 423);
            this.GeoMap.TabIndex = 4;
            this.GeoMap.Text = "Geo Map";
            this.GeoMap.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.GeoMap.VerticalScrollbarBarColor = true;
            this.GeoMap.VerticalScrollbarHighlightOnWheel = false;
            this.GeoMap.VerticalScrollbarSize = 9;
            // 
            // geoMap1
            // 
            this.geoMap1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.geoMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geoMap1.Location = new System.Drawing.Point(50, 15);
            this.geoMap1.Name = "geoMap1";
            this.geoMap1.Size = new System.Drawing.Size(792, 393);
            this.geoMap1.TabIndex = 2;
            this.geoMap1.Text = "geoMap1";
            // 
            // Pie
            // 
            this.Pie.Controls.Add(this.pieChart1);
            this.Pie.HorizontalScrollbarBarColor = true;
            this.Pie.HorizontalScrollbarHighlightOnWheel = false;
            this.Pie.HorizontalScrollbarSize = 5;
            this.Pie.Location = new System.Drawing.Point(4, 38);
            this.Pie.Name = "Pie";
            this.Pie.Size = new System.Drawing.Size(892, 423);
            this.Pie.TabIndex = 1;
            this.Pie.Text = " Pie Chart";
            this.Pie.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Pie.VerticalScrollbarBarColor = true;
            this.Pie.VerticalScrollbarHighlightOnWheel = false;
            this.Pie.VerticalScrollbarSize = 7;
            // 
            // pieChart1
            // 
            this.pieChart1.BackColor = System.Drawing.Color.Transparent;
            this.pieChart1.Location = new System.Drawing.Point(296, 61);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(300, 300);
            this.pieChart1.TabIndex = 2;
            this.pieChart1.Text = "pieChart1";
            // 
            // SolidGauge
            // 
            this.SolidGauge.Controls.Add(this.solidGauge6);
            this.SolidGauge.Controls.Add(this.solidGauge5);
            this.SolidGauge.Controls.Add(this.solidGauge4);
            this.SolidGauge.Controls.Add(this.solidGauge3);
            this.SolidGauge.Controls.Add(this.solidGauge2);
            this.SolidGauge.Controls.Add(this.solidGauge1);
            this.SolidGauge.HorizontalScrollbarBarColor = true;
            this.SolidGauge.HorizontalScrollbarHighlightOnWheel = false;
            this.SolidGauge.HorizontalScrollbarSize = 8;
            this.SolidGauge.Location = new System.Drawing.Point(4, 38);
            this.SolidGauge.Name = "SolidGauge";
            this.SolidGauge.Size = new System.Drawing.Size(892, 423);
            this.SolidGauge.TabIndex = 3;
            this.SolidGauge.Text = "Solid Gauge";
            this.SolidGauge.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.SolidGauge.VerticalScrollbarBarColor = true;
            this.SolidGauge.VerticalScrollbarHighlightOnWheel = false;
            this.SolidGauge.VerticalScrollbarSize = 9;
            // 
            // solidGauge6
            // 
            this.solidGauge6.BackColor = System.Drawing.Color.Transparent;
            this.solidGauge6.Location = new System.Drawing.Point(574, 231);
            this.solidGauge6.Margin = new System.Windows.Forms.Padding(20);
            this.solidGauge6.Name = "solidGauge6";
            this.solidGauge6.Size = new System.Drawing.Size(175, 175);
            this.solidGauge6.TabIndex = 8;
            this.solidGauge6.Text = "solidGauge6";
            // 
            // solidGauge5
            // 
            this.solidGauge5.BackColor = System.Drawing.Color.Transparent;
            this.solidGauge5.Location = new System.Drawing.Point(359, 231);
            this.solidGauge5.Margin = new System.Windows.Forms.Padding(20);
            this.solidGauge5.Name = "solidGauge5";
            this.solidGauge5.Size = new System.Drawing.Size(175, 175);
            this.solidGauge5.TabIndex = 7;
            this.solidGauge5.Text = "solidGauge5";
            // 
            // solidGauge4
            // 
            this.solidGauge4.BackColor = System.Drawing.Color.Transparent;
            this.solidGauge4.Location = new System.Drawing.Point(144, 231);
            this.solidGauge4.Margin = new System.Windows.Forms.Padding(20);
            this.solidGauge4.Name = "solidGauge4";
            this.solidGauge4.Size = new System.Drawing.Size(175, 175);
            this.solidGauge4.TabIndex = 6;
            this.solidGauge4.Text = "solidGauge4";
            // 
            // solidGauge3
            // 
            this.solidGauge3.BackColor = System.Drawing.Color.Transparent;
            this.solidGauge3.Location = new System.Drawing.Point(574, 16);
            this.solidGauge3.Margin = new System.Windows.Forms.Padding(20);
            this.solidGauge3.Name = "solidGauge3";
            this.solidGauge3.Size = new System.Drawing.Size(175, 175);
            this.solidGauge3.TabIndex = 5;
            this.solidGauge3.Text = "solidGauge3";
            // 
            // solidGauge2
            // 
            this.solidGauge2.BackColor = System.Drawing.Color.Transparent;
            this.solidGauge2.Location = new System.Drawing.Point(359, 16);
            this.solidGauge2.Margin = new System.Windows.Forms.Padding(20);
            this.solidGauge2.Name = "solidGauge2";
            this.solidGauge2.Size = new System.Drawing.Size(175, 175);
            this.solidGauge2.TabIndex = 4;
            this.solidGauge2.Text = "solidGauge2";
            // 
            // solidGauge1
            // 
            this.solidGauge1.BackColor = System.Drawing.Color.Transparent;
            this.solidGauge1.Location = new System.Drawing.Point(144, 16);
            this.solidGauge1.Margin = new System.Windows.Forms.Padding(20);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(175, 175);
            this.solidGauge1.TabIndex = 3;
            this.solidGauge1.Text = "solidGauge1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.metroTabControl1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 540);
            this.MinimumSize = new System.Drawing.Size(900, 540);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 75, 0, 0);
            this.Text = "Live Charts";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.AngularGauge.ResumeLayout(false);
            this.Cartesian.ResumeLayout(false);
            this.GeoMap.ResumeLayout(false);
            this.Pie.ResumeLayout(false);
            this.SolidGauge.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage Cartesian;
        private MetroFramework.Controls.MetroTabPage Pie;
        private WinForms.CartesianChart cartesianChart1;
        private WinForms.PieChart pieChart1;
        private MetroFramework.Controls.MetroTabPage AngularGauge;
        private WinForms.AngularGauge angularGauge1;
        private MetroFramework.Controls.MetroTabPage SolidGauge;
        private WinForms.SolidGauge solidGauge1;
        private WinForms.SolidGauge solidGauge6;
        private WinForms.SolidGauge solidGauge5;
        private WinForms.SolidGauge solidGauge4;
        private WinForms.SolidGauge solidGauge3;
        private WinForms.SolidGauge solidGauge2;
        private MetroFramework.Controls.MetroTabPage GeoMap;
        private WinForms.GeoMap geoMap1;
    }
}

