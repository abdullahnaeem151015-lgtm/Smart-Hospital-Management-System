using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartHospitalManagementSystem
{
    public partial class AppointmentForm : Form
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True";

        public AppointmentForm()
        {
            InitializeComponent();
        }

        private void AppointmentForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Scheduled");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Cancelled");
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Appointments VALUES (@AppointmentID,@PatientID,@PatientName,@DoctorName,@AppointmentDate,@AppointmentTime,@Status)", con);

                    cmd.Parameters.AddWithValue("@AppointmentID", txtAppointmentID.Text);
                    cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);
                    cmd.Parameters.AddWithValue("@PatientName", txtPatientName.Text);
                    cmd.Parameters.AddWithValue("@DoctorName", txtDoctorName.Text);
                    cmd.Parameters.AddWithValue("@AppointmentDate", dtpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@AppointmentTime", dtpDate.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Scheduled Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Appointments", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAppointments.DataSource = dt;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Appointments WHERE AppointmentID=@AppointmentID", con);
                da.SelectCommand.Parameters.AddWithValue("@AppointmentID", txtAppointmentID.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvAppointments.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Appointments SET PatientID=@PatientID, PatientName=@PatientName, DoctorName=@DoctorName, AppointmentDate=@AppointmentDate, AppointmentTime=@AppointmentTime, Status=@Status WHERE AppointmentID=@AppointmentID", con);

                    cmd.Parameters.AddWithValue("@AppointmentID", txtAppointmentID.Text);
                    cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);
                    cmd.Parameters.AddWithValue("@PatientName", txtPatientName.Text);
                    cmd.Parameters.AddWithValue("@DoctorName", txtDoctorName.Text);
                    cmd.Parameters.AddWithValue("@AppointmentDate", dtpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@AppointmentTime", dtpDate.Value.TimeOfDay);
                    cmd.Parameters.AddWithValue("@Status", cmbStatus.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Updated Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Appointments WHERE AppointmentID=@AppointmentID", con);
                    cmd.Parameters.AddWithValue("@AppointmentID", txtAppointmentID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Appointment Cancelled/Deleted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAppointmentID.Clear();
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtDoctorName.Clear();
            cmbStatus.SelectedIndex = -1;
            dgvAppointments.DataSource = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}
