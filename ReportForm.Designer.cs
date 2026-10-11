namespace SmartHospitalManagementSystem
{
    partial class ReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalPatients = new System.Windows.Forms.TextBox();
            this.txtTotalDoctors = new System.Windows.Forms.TextBox();
            this.txtAppointmentsPerDay = new System.Windows.Forms.TextBox();
            this.txtRevenue = new System.Windows.Forms.TextBox();
            this.btnLoadReport = new System.Windows.Forms.Button();
            this.btnShowChart = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.chartReports = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Patients";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Doctors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Appointments Per day";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Revenue Statistics";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // txtTotalPatients
            // 
            this.txtTotalPatients.Location = new System.Drawing.Point(261, 65);
            this.txtTotalPatients.Name = "txtTotalPatients";
            this.txtTotalPatients.Size = new System.Drawing.Size(100, 26);
            this.txtTotalPatients.TabIndex = 5;
            // 
            // txtTotalDoctors
            // 
            this.txtTotalDoctors.Location = new System.Drawing.Point(261, 98);
            this.txtTotalDoctors.Name = "txtTotalDoctors";
            this.txtTotalDoctors.Size = new System.Drawing.Size(100, 26);
            this.txtTotalDoctors.TabIndex = 6;
            // 
            // txtAppointmentsPerDay
            // 
            this.txtAppointmentsPerDay.Location = new System.Drawing.Point(261, 143);
            this.txtAppointmentsPerDay.Name = "txtAppointmentsPerDay";
            this.txtAppointmentsPerDay.Size = new System.Drawing.Size(100, 26);
            this.txtAppointmentsPerDay.TabIndex = 7;
            // 
            // txtRevenue
            // 
            this.txtRevenue.Location = new System.Drawing.Point(261, 186);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(100, 26);
            this.txtRevenue.TabIndex = 8;
            // 
            // btnLoadReport
            // 
            this.btnLoadReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadReport.Location = new System.Drawing.Point(4, 261);
            this.btnLoadReport.Name = "btnLoadReport";
            this.btnLoadReport.Size = new System.Drawing.Size(141, 45);
            this.btnLoadReport.TabIndex = 9;
            this.btnLoadReport.Text = "Load Report";
            this.btnLoadReport.UseVisualStyleBackColor = true;
            this.btnLoadReport.Click += new System.EventHandler(this.btnLoadReport_Click);
            // 
            // btnShowChart
            // 
            this.btnShowChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowChart.Location = new System.Drawing.Point(162, 261);
            this.btnShowChart.Name = "btnShowChart";
            this.btnShowChart.Size = new System.Drawing.Size(145, 49);
            this.btnShowChart.TabIndex = 10;
            this.btnShowChart.Text = "Show Chart";
            this.btnShowChart.UseVisualStyleBackColor = true;
            this.btnShowChart.Click += new System.EventHandler(this.btnShowChart_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(12, 316);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 37);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(162, 316);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(129, 50);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // chartReports
            // 
            chartArea1.Name = "ChartArea1";
            this.chartReports.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartReports.Legends.Add(legend1);
            this.chartReports.Location = new System.Drawing.Point(380, 12);
            this.chartReports.Name = "chartReports";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartReports.Series.Add(series1);
            this.chartReports.Size = new System.Drawing.Size(421, 220);
            this.chartReports.TabIndex = 13;
            this.chartReports.Text = "chartReports";
            // 
            // dgvReports
            // 
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(316, 253);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.RowHeadersWidth = 62;
            this.dgvReports.RowTemplate.Height = 28;
            this.dgvReports.Size = new System.Drawing.Size(424, 196);
            this.dgvReports.TabIndex = 14;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.chartReports);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowChart);
            this.Controls.Add(this.btnLoadReport);
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.txtAppointmentsPerDay);
            this.Controls.Add(this.txtTotalDoctors);
            this.Controls.Add(this.txtTotalPatients);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.chartReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalPatients;
        private System.Windows.Forms.TextBox txtTotalDoctors;
        private System.Windows.Forms.TextBox txtAppointmentsPerDay;
        private System.Windows.Forms.TextBox txtRevenue;
        private System.Windows.Forms.Button btnLoadReport;
        private System.Windows.Forms.Button btnShowChart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReports;
        private System.Windows.Forms.DataGridView dgvReports;
    }
}