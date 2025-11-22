using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CODEINN.Controller;
using CODEINN.Model;

namespace CODEINN.UI
{
    public partial class FrontDeskGuestInfo : Form
    {
        private readonly GuestInfoController guestController;
        public FrontDeskGuestInfo()
        {
            InitializeComponent();
            guestController = new GuestInfoController(); // same controller as admin
        }
        private void LoadGuestData()
        {
            dtgInfo.DataSource = null;
            dtgInfo.DataSource = guestController.GetAllGuests();
        }


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrontdeskDashboard dashboard = new FrontdeskDashboard();
            dashboard.Show();

            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrontDeskGuestInfo_Load(object sender, EventArgs e)
        {

            LoadGuestData();
            btnSave.Enabled = false;
            btnAdd.Enabled = true;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime birthDate = dtpBirtdate.Value;
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now.Date < birthDate.AddYears(age)) age--;

                var guest = new Guests
                {
                    LastName = txtLastname.Text,
                    FirstName = txtFirstname.Text,
                    MiddleInitial = txtInitial.Text,
                    ContactNumber = txtPhone.Text,
                    Email = txtEmail.Text,
                    Gender = cbGender.Text,
                    Address = txtadress.Text,
                    BirthDate = birthDate,
                    Age = age
                };

                int guestId = guestController.AddGuest(guest);
                txtGuestId.Text = guestId.ToString();

                LoadGuestData();
                ClearFields();

                btnSave.Enabled = false;
                btnAdd.Enabled = true;

                MessageBox.Show("Guest added successfully!", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding guest: " + ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtGuestId.Text, out int guestId))
            {
                MessageBox.Show("Please select a guest first.");
                return;
            }

            DateTime birthDate = dtpBirtdate.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.Date < birthDate.AddYears(age)) age--;

            var guest = new Guests
            {
                GuestID = guestId,
                LastName = txtLastname.Text,
                FirstName = txtFirstname.Text,
                MiddleInitial = txtInitial.Text,
                ContactNumber = txtPhone.Text,
                Email = txtEmail.Text,
                Gender = cbGender.Text,
                Address = txtadress.Text,
                BirthDate = birthDate,
                Age = age
            };

            guestController.EditGuest(guest);
            LoadGuestData();
            ClearFields();

            btnSave.Enabled = false;
            btnAdd.Enabled = true;


            MessageBox.Show("Guest updated successfully!", "Success");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadGuestData();
            }
            else
            {
                dtgInfo.DataSource = guestController.SearchGuests(keyword);
            }
        }

        private void dtgInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;
            DataGridViewRow row = dtgInfo.Rows[e.RowIndex];

            txtGuestId.Text = row.Cells["GuestID"].Value?.ToString();
            txtLastname.Text = row.Cells["LastName"].Value?.ToString();
            txtFirstname.Text = row.Cells["FirstName"].Value?.ToString();
            txtInitial.Text = row.Cells["MiddleInitial"].Value?.ToString();
            txtPhone.Text = row.Cells["ContactNumber"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            cbGender.Text = row.Cells["Gender"].Value?.ToString();
            txtadress.Text = row.Cells["Address"].Value?.ToString();

            if (DateTime.TryParse(row.Cells["BirthDate"].Value?.ToString(), out DateTime birthDate))
            {
                dtpBirtdate.Value = birthDate;

                // 👇 Calculate and display the age
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now.Date < birthDate.AddYears(age)) age--;
                txtAge.Text = age.ToString();
            }

            btnAdd.Enabled = false;
            btnSave.Enabled = true;
        }
        private void ClearFields()
        {
            txtGuestId.Clear();
            txtLastname.Clear();
            txtFirstname.Clear();
            txtInitial.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtadress.Clear();
            cbGender.SelectedIndex = -1;
            dtpBirtdate.Value = DateTime.Today;
        }

        private void dtpBirtdate_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDate = dtpBirtdate.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.Date < birthDate.AddYears(age)) age--;

            txtAge.Text = age.ToString();
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            // When textbox gets focus, clear placeholder
            if (txtSearch.Text == "Search Guest")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black; // Normal typing color
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {  // When textbox loses focus and is empty, show placeholder again
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search Guest";
                txtSearch.ForeColor = Color.Gray;
            }
        }
    }
}
