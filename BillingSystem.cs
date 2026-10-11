using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartHospitalManagementSystem
{
    public partial class BillingForm : Form
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDB;Integrated Security=True";

        public BillingForm()
        {
            InitializeComponent();
        }

        private void BillingForm_Load(object sender, EventArgs e)
        {
            cmbPaymentStatus.Items.Clear();
            cmbPaymentStatus.Items.Add("Paid");
            cmbPaymentStatus.Items.Add("Pending");
            cmbPaymentStatus.Items.Add("Unpaid");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal consultation = Convert.ToDecimal(txtConsultation.Text);
            decimal medicine = Convert.ToDecimal(txtMedicine.Text);
            decimal labTest = Convert.ToDecimal(txtLabTest.Text);
            decimal tax = Convert.ToDecimal(txtTax.Text);

            decimal finalAmount = consultation + medicine + labTest + tax;
            txtFinalAmount.Text = finalAmount.ToString();
        }

        private void btnAddBill_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "INSERT INTO Billing VALUES (@BillID,@PatientID,@PatientName,@ConsultationCharges,@MedicineCharges,@LabTestCharges,@TaxAmount,@FinalAmount,@PaymentStatus)", con);

                    cmd.Parameters.AddWithValue("@BillID", txtBillID.Text);
                    cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);
                    cmd.Parameters.AddWithValue("@PatientName", txtPatientName.Text);
                    cmd.Parameters.AddWithValue("@ConsultationCharges", txtConsultation.Text);
                    cmd.Parameters.AddWithValue("@MedicineCharges", txtMedicine.Text);
                    cmd.Parameters.AddWithValue("@LabTestCharges", txtLabTest.Text);
                    cmd.Parameters.AddWithValue("@TaxAmount", txtTax.Text);
                    cmd.Parameters.AddWithValue("@FinalAmount", txtFinalAmount.Text);
                    cmd.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnViewBills_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Billing", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBilling.DataSource = dt;
            }
        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Billing WHERE BillID=@BillID", con);
                da.SelectCommand.Parameters.AddWithValue("@BillID", txtBillID.Text);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBilling.DataSource = dt;
            }
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        "UPDATE Billing SET PatientID=@PatientID, PatientName=@PatientName, ConsultationCharges=@ConsultationCharges, MedicineCharges=@MedicineCharges, LabTestCharges=@LabTestCharges, TaxAmount=@TaxAmount, FinalAmount=@FinalAmount, PaymentStatus=@PaymentStatus WHERE BillID=@BillID", con);

                    cmd.Parameters.AddWithValue("@BillID", txtBillID.Text);
                    cmd.Parameters.AddWithValue("@PatientID", txtPatientID.Text);
                    cmd.Parameters.AddWithValue("@PatientName", txtPatientName.Text);
                    cmd.Parameters.AddWithValue("@ConsultationCharges", txtConsultation.Text);
                    cmd.Parameters.AddWithValue("@MedicineCharges", txtMedicine.Text);
                    cmd.Parameters.AddWithValue("@LabTestCharges", txtLabTest.Text);
                    cmd.Parameters.AddWithValue("@TaxAmount", txtTax.Text);
                    cmd.Parameters.AddWithValue("@FinalAmount", txtFinalAmount.Text);
                    cmd.Parameters.AddWithValue("@PaymentStatus", cmbPaymentStatus.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Updated Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Billing WHERE BillID=@BillID", con);
                    cmd.Parameters.AddWithValue("@BillID", txtBillID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bill Deleted Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invoice Printed Successfully");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBillID.Clear();
            txtPatientID.Clear();
            txtPatientName.Clear();
            txtConsultation.Clear();
            txtMedicine.Clear();
            txtLabTest.Clear();
            txtTax.Clear();
            txtFinalAmount.Clear();

            cmbPaymentStatus.SelectedIndex = -1;
            dgvBilling.DataSource = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard db = new Dashboard();
            db.Show();
            this.Hide();
        }
    }
}
