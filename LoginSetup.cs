using System;
using System.Windows.Forms;

namespace SmartHospitalManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Role.Items.Add("Admin");
            Role.Items.Add("Doctor");
            Role.Items.Add("Receptionist");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = Role.Text;

            if (username == "admin" && password == "123" && role == "Admin")
            {
                MessageBox.Show("Admin Login Successful");
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
            }
            else if (username == "doctor" && password == "123" && role == "Doctor")
            {
                MessageBox.Show("Doctor Login Successful");
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
            }
            else if (username == "reception" && password == "123" && role == "Receptionist")
            {
                MessageBox.Show("Receptionist Login Successful");
                Dashboard db = new Dashboard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username, password, or role");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}