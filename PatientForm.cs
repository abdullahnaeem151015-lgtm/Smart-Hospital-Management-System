using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartHospitalManagementSystem
{
    public partial class PatientForm : Form
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True";

        public PatientForm()
        {
            InitializeComponent();
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            cmbGender.Items.Clear();
            cmbBlood.Items.Clear();

            cmbGender.Items.Add("Male");
            cmbGender.Items.Add("Female");

            cmbBlood.Items.Add("A+");
            cmbBlood.Items.Add("A-");
            cmbBlood.Items.Add("B+");
            cmbBlood.Items.Add("B-");
            cmbBlood.Items.Add("O+");
            cmbBlood.Items.Add("O-");
            cmbBlood.Items.Add("AB+");
            cmbBlood.Items.Add("AB-");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Patients VALUES (@PatientID,@FullName,@Gender,@Age,@BloodGroup,@Disease,@Contact,@Address,@DoctorAssigned)", con);

                    cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);
                    cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", cmbBlood.Text);
                    cmd.Parameters.AddWithValue("@Disease", txtDisease.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContract.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@DoctorAssigned", txtDoctor.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Patient Added Successfully");
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
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Patients", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPatients.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                        "SELECT * FROM Patients WHERE PatientID=@PatientID", con);

                    da.SelectCommand.Parameters.AddWithValue("@PatientID", txtPatientID.Text);

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvPatients.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                        "UPDATE Patients SET FullName=@FullName, Gender=@Gender, Age=@Age, BloodGroup=@BloodGroup, Disease=@Disease, Contact=@Contact, Address=@Address, DoctorAssigned=@DoctorAssigned WHERE PatientID=@PatientID", con);

                    cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);
                    cmd.Parameters.AddWithValue("@FullName", txtName.Text);
                    cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                    cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                    cmd.Parameters.AddWithValue("@BloodGroup", cmbBlood.Text);
                    cmd.Parameters.AddWithValue("@Disease", txtDisease.Text);
                    cmd.Parameters.AddWithValue("@Contact", txtContract.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.Parameters.AddWithValue("@DoctorAssigned", txtDoctor.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Patient Record Updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "DELETE FROM Patients WHERE PatientID=@PatientID", con);

                    cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Patient Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatientID.Clear();
            txtName.Clear();
            txtContract.Clear();
            txtAge.Clear();
            txtDisease.Clear();
            txtAddress.Clear();
            txtDoctor.Clear();

            cmbBlood.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;

            dgvPatients.DataSource = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}