using System;
using System.Windows.Forms;

namespace SmartHospitalManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            PatientForm pf = new PatientForm();
            pf.Show();
            this.Hide();
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm af = new AppointmentForm();
            af.Show();
            this.Hide();
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            BillingForm bf = new BillingForm();
            bf.Show();
            this.Hide();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm rf = new ReportForm();
            rf.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }
    }
}