using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using CODEINN.Controller;
using CODEINN.Model;
using CODEINN.Model.CODEINN.Model;
using CODEINN.Repository;
using System.Data.SqlClient;

namespace CODEINN.UI
{
    public partial class FrontdeskPayment : Form
    {
        private PaymentsController paymentController;
        private string connectionString = "Data Source=LAPTOP-JCHBPFPV\\SQLEXPRESS01;Initial Catalog=HOTELFinalldb;Integrated Security=True;TrustServerCertificate=True";


        public FrontdeskPayment()
        {
            InitializeComponent();
            PaymentsRepository paymentRepository = new PaymentsRepository(); // Create repository
            paymentController = new PaymentsController(paymentRepository);

        }

        private void FrontdeskPayment_Load(object sender, EventArgs e)
        {
            // Fetch the data from the controller
            DataTable paymentData = paymentController.GetReservedPayments();

            // Bind the data to the DataGridView
            dtgInfo.DataSource = paymentData;

            // Optionally, ensure the grid is refreshed if it's not automatically refreshing
            dtgInfo.Refresh();

            txtSearchadmin.Enter += enter;
            txtSearchadmin.Leave += exit;

        }

        private void dtgInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgInfo.Rows[e.RowIndex];

                // Reservation & Guest Info


                txtLastnameadmin.Text = row.Cells["LastName"].Value.ToString();
                txtFirstnameadmin.Text = row.Cells["FirstName"].Value.ToString();
                txtInitialadmin.Text = row.Cells["MiddleInitial"].Value.ToString();

                // Room Info
                string roomType = row.Cells["RoomType"].Value.ToString();
                string roomNumber = row.Cells["RoomNumber"].Value.ToString();

                // Room type and room number will just be shown in textboxes now (no ComboBox needed)
                txt_roomtype.Text = roomType;
                txt_num.Text = roomNumber;

                // Dates & Time
                checkindate.Value = Convert.ToDateTime(row.Cells["CheckInDate"].Value);
                checkoutdate.Value = Convert.ToDateTime(row.Cells["CheckOutDate"].Value);

                // Number of nights
                txt_num.Text = row.Cells["NumberOfNights"].Value.ToString();

                // Balance (Remaining balance from the query)
                if (row.Cells["RemainingBalance"] != null && row.Cells["RemainingBalance"].Value != DBNull.Value)
                {
                    decimal balance = Convert.ToDecimal(row.Cells["RemainingBalance"].Value);
                    txt_balance.Text = balance.ToString("0.00");
                }
                else
                {
                    txt_balance.Text = "0.00"; // Default if no balance is found
                }

                // Status
                txt_status.Text = row.Cells["Status"].Value?.ToString();
            }
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected in the DataGridView
            if (dtgInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the ReservationID from the selected row
            var selectedRow = dtgInfo.SelectedRows[0];  // Get the first selected row
            int paymentId = Convert.ToInt32(selectedRow.Cells["ReservationID"].Value);  // Get the ReservationID

            var reservation = paymentController.GetReservationById(paymentId);

            if (reservation == null)
            {
                MessageBox.Show("Reservation not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (var transaction = conn.BeginTransaction()) // Start transaction
                    {
                        try
                        {
                            // Step 1: Delete the reservation
                            paymentController.DeleteReservation(paymentId, transaction);

                            // Step 2: Update room availability to "Available"
                            string roomNumber = reservation.RoomNumber;  // RoomNumber is a string, not an int
                            paymentController.UpdateRoomAvailability(roomNumber, "Available", transaction); // Pass the string roomNumber

                            // Step 3: Commit the transaction
                            transaction.Commit();

                            // Success message
                            MessageBox.Show("Guests been Checked_Out!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Refresh the DataGridView
                            dtgInfo.DataSource = paymentController.GetReservedPayments();

                            // Optionally clear fields after processing
                            ClearFields();
                        }
                        catch (Exception ex)
                        {
                            // If any error occurs, rollback the transaction and display the error
                            transaction.Rollback();
                            MessageBox.Show($"Error during check-out: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // If there's a problem opening the connection or other DB issues
                MessageBox.Show($"Database connection error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFields()
        {
            txtLastnameadmin.Clear();
            txtFirstnameadmin.Clear();
            txtInitialadmin.Clear();
            lbl_guestid.Text = "";
            txt_roomtype.Clear();
            txt_status.Clear();

            // Set the balance and amount to 0.00 if they are empty
            txt_balance.Text = "0.00";
            txt_change.Text = "0.00";
            txt_amount.Text = "0.00";
            txt_num.Clear();

            checkindate.Value = DateTime.Today;
            checkoutdate.Value = DateTime.Today;

            txtSearchadmin.Clear();
        }



        private void btnBack1_Click(object sender, EventArgs e)
        {
            FrontdeskDashboard dashboard = new FrontdeskDashboard();
            dashboard.Show();
            this.Hide();
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
            // When textbox gets focus, clear placeholder
            if (txtSearchadmin.Text == "Search Guest")
            {
                txtSearchadmin.Text = "";
                txtSearchadmin.ForeColor = Color.Black; // Normal typing color
            }
        }

        private void txtSearchadmin_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchadmin.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                // Reload all data when search box is cleared
                dtgInfo.DataSource = paymentController.GetReservedPayments();
            }
            else
            {
                // Show filtered results
                dtgInfo.DataSource = paymentController.SearchReservedPayments(keyword);
            }
        }

        private void txt_amount_TextChanged_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_amount.Text, out decimal received) &&
               decimal.TryParse(txt_balance.Text, out decimal price))
            {
                txt_change.Text = (received - price).ToString("0.00");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.Show();
            this.Hide();
        }
    }
}
