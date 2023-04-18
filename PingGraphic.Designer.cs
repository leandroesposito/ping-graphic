namespace ping_graphic
{
    partial class PingGraphic
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpViewTime = new System.Windows.Forms.DateTimePicker();
            this.lblMean = new System.Windows.Forms.Label();
            this.chrtPing = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chbRun = new System.Windows.Forms.CheckBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPing)).BeginInit();
            this.SuspendLayout();
            // 
            // chart2
            // 
            chartArea7.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chart2.Legends.Add(legend7);
            this.chart2.Location = new System.Drawing.Point(530, 150);
            this.chart2.Name = "chart2";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.chart2.Series.Add(series7);
            this.chart2.Size = new System.Drawing.Size(8, 8);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(745, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "minutes";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(627, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "View last";
            // 
            // dtpViewTime
            // 
            this.dtpViewTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpViewTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpViewTime.Location = new System.Drawing.Point(682, 29);
            this.dtpViewTime.Name = "dtpViewTime";
            this.dtpViewTime.Size = new System.Drawing.Size(57, 20);
            this.dtpViewTime.TabIndex = 14;
            this.dtpViewTime.Value = new System.DateTime(2021, 10, 13, 12, 0, 30, 0);
            // 
            // lblMean
            // 
            this.lblMean.AutoSize = true;
            this.lblMean.Location = new System.Drawing.Point(98, 33);
            this.lblMean.Name = "lblMean";
            this.lblMean.Size = new System.Drawing.Size(10, 13);
            this.lblMean.TabIndex = 13;
            this.lblMean.Text = "-";
            // 
            // chrtPing
            // 
            this.chrtPing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Name = "ChartArea1";
            this.chrtPing.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chrtPing.Legends.Add(legend8);
            this.chrtPing.Location = new System.Drawing.Point(15, 55);
            this.chrtPing.Name = "chrtPing";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Ping";
            this.chrtPing.Series.Add(series8);
            this.chrtPing.Size = new System.Drawing.Size(773, 383);
            this.chrtPing.TabIndex = 12;
            this.chrtPing.Text = "Ping";
            // 
            // chbRun
            // 
            this.chbRun.AutoSize = true;
            this.chbRun.Checked = true;
            this.chbRun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbRun.Location = new System.Drawing.Point(15, 32);
            this.chbRun.Name = "chbRun";
            this.chbRun.Size = new System.Drawing.Size(46, 17);
            this.chbRun.TabIndex = 11;
            this.chbRun.Text = "Run";
            this.chbRun.UseVisualStyleBackColor = true;
            this.chbRun.CheckedChanged += new System.EventHandler(this.chbRun_CheckedChanged);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(53, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(735, 20);
            this.txtUrl.TabIndex = 10;
            this.txtUrl.Text = "google.com";
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "URL:";
            // 
            // PingGraphic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpViewTime);
            this.Controls.Add(this.lblMean);
            this.Controls.Add(this.chrtPing);
            this.Controls.Add(this.chbRun);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Name = "PingGraphic";
            this.Text = "Ping Graphic";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PingGraphic_FormClosing);
            this.Load += new System.EventHandler(this.PingGraphic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chrtPing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpViewTime;
        private System.Windows.Forms.Label lblMean;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtPing;
        private System.Windows.Forms.CheckBox chbRun;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label1;
    }
}

