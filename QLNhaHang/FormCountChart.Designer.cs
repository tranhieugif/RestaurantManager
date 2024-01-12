namespace QLNhaHang
{
    partial class FormCountChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCountChart));
            panel1 = new Panel();
            chartMonthly = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartMonthly).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chartMonthly);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(740, 451);
            panel1.TabIndex = 0;
            // 
            // chartMonthly
            // 
            chartArea1.Name = "ChartArea1";
            chartMonthly.ChartAreas.Add(chartArea1);
            chartMonthly.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartMonthly.Legends.Add(legend1);
            chartMonthly.Location = new Point(0, 0);
            chartMonthly.Name = "chartMonthly";
            chartMonthly.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chartMonthly.Series.Add(series1);
            chartMonthly.Size = new Size(740, 451);
            chartMonthly.TabIndex = 0;
            chartMonthly.Text = "chart1";
            // 
            // FormCountChart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 451);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCountChart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biểu đồ";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartMonthly).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonthly;
    }
}