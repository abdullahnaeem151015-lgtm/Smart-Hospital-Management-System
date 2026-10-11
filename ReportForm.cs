using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SmartHospitalManagementSystem
{
    public partial class ReportForm : Form
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True";

        public ReportForm()
        {
            InitializeComponent();
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmdPatients = new SqlCommand("SELECT COUNT(*) FROM Patients", con);
                    txtTotalPatients.Text = cmdPatients.ExecuteScalar().ToString();

                    SqlCommand cmdDoctors = new SqlCommand("SELECT COUNT(DISTINCT DoctorAssigned) FROM Patients", con);
                    txtTotalDoctors.Text = cmdDoctors.ExecuteScalar().ToString();

                    SqlCommand cmdAppointments = new SqlCommand("SELECT COUNT(*) FROM Appointments", con);
                    txtAppointmentsPerDay.Text = cmdAppointments.ExecuteScalar().ToString();

                    SqlCommand cmdRevenue = new SqlCommand("SELECT ISNULL(SUM(FinalAmount),0) FROM Billing", con);
                    txtRevenue.Text = cmdRevenue.ExecuteScalar().ToString();

                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Billing", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvReports.DataSource = dt;

                    MessageBox.Show("Report Loaded Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnShowChart_Click(object sender, EventArgs e)
        {
            chartReports.Series.Clear();

            Series series = new Series("Hospital Statistics");
            series.ChartType = SeriesChartType.Column;

            series.Points.AddXY("Patients", Convert.ToInt32(txtTotalPatients.Text));
            series.Points.AddXY("Doctors", Convert.ToInt32(txtTotalDoctors.Text));
            series.Points.AddXY("Appointments", Convert.ToInt32(txtAppointmentsPerDay.Text));
            series.Points.AddXY("Revenue", Convert.ToDecimal(txtRevenue.Text));

            chartReports.Series.Add(series);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotalPatients.Clear();
            txtTotalDoctors.Clear();
            txtAppointmentsPerDay.Clear();
            txtRevenue.Clear();

            chartReports.Series.Clear();
            dgvReports.DataSource = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}
