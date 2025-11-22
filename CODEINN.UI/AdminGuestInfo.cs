using System.DirectoryServices.ActiveDirectory;
using CODEINN.Controller;
using CODEINN.Model;

namespace CODEINN.UI
{
    public partial class AdminGuestInfo : Form
    {
        private readonly GuestInfoController guestController;
        public AdminGuestInfo()
        {
            InitializeComponent();
            guestController = new GuestInfoController();

        }
        private void LoadGuestData()
        {
            dtgInfo1.DataSource = null;
            dtgInfo1.DataSource = guestController.GetAllGuests();
        }

        private void btnAddadmin_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime birthDate = dtpBirtdateadmin.Value;
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now.Date < birthDate.Date.AddYears(age))
                    age--;

                txtAgeadmin.Text = age.ToString();
                var guest = new Guests
                {
                    LastName = txtLastnameadmin.Text,
                    FirstName = txtFirstnameadmin.Text,
                    MiddleInitial = txtInitialadmin.Text,
                    ContactNumber = txtPhoneadmin.Text,
                    Email = txtEmailadmin.Text,
                    Gender = cbGenderadmin.Text,
                    Address = txtadress.Text,
                    BirthDate = birthDate,
                    Age = age
                };

                int guestId = guestController.AddGuest(guest);
                txtGuestIdadmin.Text = guestId.ToString();

                LoadGuestData();

                MessageBox.Show("Guest added successfully! Guest ID: " + guestId,
                                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding guest: " + ex.Message);
            }
            ClearFields();
        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            string searchCriterion = txtSearchadmin.Text;

            if (string.IsNullOrEmpty(searchCriterion))
            {
                MessageBox.Show("Please enter a value to search.", "Missing Search Term", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {


                MessageBox.Show("Guest information loaded.", "Search Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during search: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSaveadmin_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtGuestIdadmin.Text, out int guestId))
                {
                    MessageBox.Show("Select a guest to save.");
                    return;
                }

                DateTime birthDate = dtpBirtdateadmin.Value;
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now.Date < birthDate.Date.AddYears(age))
                    age--;

                var guest = new Guests
                {
                    GuestID = guestId,
                    LastName = txtLastnameadmin.Text,
                    FirstName = txtFirstnameadmin.Text,
                    MiddleInitial = txtInitialadmin.Text,
                    ContactNumber = txtPhoneadmin.Text,
                    Email = txtEmailadmin.Text,
                    Gender = cbGenderadmin.Text,
                    Address = txtadress.Text,
                    BirthDate = birthDate,
                    Age = age
                };

                guestController.EditGuest(guest);
                LoadGuestData();

                MessageBox.Show("Guest updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving guest: " + ex.Message);
            }
            ClearFields();
        }
        private void btnEditadmin_Click(object sender, EventArgs e)
        {
            if (dtgInfo1.CurrentRow == null) return;

            int guestId = Convert.ToInt32(dtgInfo1.CurrentRow.Cells["GuestID"].Value);
            var guest = guestController.GetGuestbyID(guestId);

            txtGuestIdadmin.Text = guest.GuestID.ToString();
            txtLastnameadmin.Text = guest.LastName;
            txtFirstnameadmin.Text = guest.FirstName;
            txtInitialadmin.Text = guest.MiddleInitial;
            txtPhoneadmin.Text = guest.ContactNumber;
            txtEmailadmin.Text = guest.Email;


        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchadmin_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchadmin.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                LoadGuestData();
            }
            else
            {
                dtgInfo1.DataSource = guestController.SearchGuests(keyword);
            }
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();

            this.Hide();
        }

        private void AdminGuestInfo_Load(object sender, EventArgs e)
        {
            LoadGuestData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgInfo1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore header row clicks
            if (e.RowIndex < 0) return;

            // Get the selected row
            DataGridViewRow row = dtgInfo1.Rows[e.RowIndex];

            // Fill textboxes
            txtGuestIdadmin.Text = row.Cells["GuestID"].Value?.ToString();
            txtLastnameadmin.Text = row.Cells["LastName"].Value?.ToString();
            txtFirstnameadmin.Text = row.Cells["FirstName"].Value?.ToString();
            txtInitialadmin.Text = row.Cells["MiddleInitial"].Value?.ToString();
            txtPhoneadmin.Text = row.Cells["ContactNumber"].Value?.ToString();
            txtEmailadmin.Text = row.Cells["Email"].Value?.ToString();
            cbGenderadmin.Text = row.Cells["Gender"].Value?.ToString();
            txtadress.Text = row.Cells["Address"].Value?.ToString();

            // ✅ Handle BirthDate safely and auto-calculate age
            if (row.Cells["BirthDate"].Value != DBNull.Value && row.Cells["BirthDate"].Value != null)
            {
                DateTime birthDate = Convert.ToDateTime(row.Cells["BirthDate"].Value);
                dtpBirtdateadmin.Value = birthDate;

                // Auto-calculate age
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now.Date < birthDate.Date.AddYears(age))
                    age--;

                txtAgeadmin.Text = age.ToString();
            }
            else
            {
                dtpBirtdateadmin.Value = DateTime.Today;
                txtAgeadmin.Clear();
            }
        }

        private void dtpBirtdateadmin_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthDate = dtpBirtdateadmin.Value;
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.Date < birthDate.Date.AddYears(age))
                age--;

            txtAgeadmin.Text = age.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGuestIdadmin.Text))
            {
                MessageBox.Show("Please select a guest to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int guestId = Convert.ToInt32(txtGuestIdadmin.Text);

            var confirm = MessageBox.Show("Are you sure you want to delete this guest?",
                                          "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    guestController.DeleteGuest(guestId);
                    LoadGuestData();
                    ClearGuestFields();

                    MessageBox.Show("Guest deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting guest: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearGuestFields()
        {
            txtGuestIdadmin.Clear();
            txtLastnameadmin.Clear();
            txtFirstnameadmin.Clear();
            txtInitialadmin.Clear();
            txtPhoneadmin.Clear();
            txtEmailadmin.Clear();
            txtadress.Clear();
            txtAgeadmin.Clear();
            cbGenderadmin.SelectedIndex = -1;
            dtpBirtdateadmin.Value = DateTime.Today;
        }

        private void enter(object sender, EventArgs e)
        {
            if (txtSearchadmin.Text == "Search Guest")
            {
                txtSearchadmin.Text = "";
                txtSearchadmin.ForeColor = Color.Black;
            }
        }

        private void exit(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchadmin.Text))
            {
                txtSearchadmin.Text = "Search Guest";
                txtSearchadmin.ForeColor = Color.Gray;
            }
        }

        private void ClearFields()
        {
            txtLastnameadmin.Clear();
            txtFirstnameadmin.Clear();
            txtInitialadmin.Clear();
            txtPhoneadmin.Clear();
            txtEmailadmin.Clear();
            dtpBirtdateadmin.ResetText();
            txtAgeadmin.Clear();
            cbGenderadmin.SelectedIndex = -1;
            txtadress.Clear();
        }

    }
}


