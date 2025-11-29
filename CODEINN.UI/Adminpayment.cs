using System.Data;
using System.Data.SqlClient;
using CODEINN.Controller;
using CODEINN.Model;
using CODEINN.Repository;
using Microsoft.Data.Sql;
using System.Data.SqlClient;

namespace CODEINN.UI
{
    public partial class Adminpayment : Form
    {
        private PaymentsRepository paymentsRepository;

        private PaymentsController paymentController;
        private HistoryController historyController;
        public Adminpayment()
        {
            InitializeComponent();
            paymentsRepository = new PaymentsRepository();

            paymentController = new PaymentsController(paymentsRepository);
            historyController = new HistoryController();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInitialadmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch1_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
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
                txt_number.Text = roomNumber;

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


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_amount.Text, out decimal received) &&
               decimal.TryParse(txt_balance.Text, out decimal price))
            {
                txt_change.Text = (received - price).ToString("0.00");
            }
        }

        private void Adminpayment_Load(object sender, EventArgs e)
        {
            // Fetch the data from the controller
            DataTable paymentData = paymentController.GetReservedPayments();

            // Bind the data to the DataGridView
            dtgInfo.DataSource = paymentData;

            // Optionally, ensure the grid is refreshed if it's not automatically refreshing
            dtgInfo.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Check if guest ID is available
            if (string.IsNullOrWhiteSpace(lbl_guestid.Text))
            {
                MessageBox.Show("Please select a reservation first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Ensure AmountReceived, Change, and Price are valid decimals
                decimal amountReceived = 0;
                decimal change = 0;
                decimal price = 0;
                int roomNumber = 0;

                // Validate if the fields contain valid numbers
                bool validAmountReceived = decimal.TryParse(txt_amount.Text, out amountReceived);
                bool validChange = decimal.TryParse(txt_change.Text, out change);
                bool validPrice = decimal.TryParse(txt_balance.Text, out price);
                bool validRoomNumber = int.TryParse(txt_number.Text, out roomNumber);

                // Debugging: Check what values are being parsed
                Console.WriteLine($"AmountReceived: {amountReceived}, Change: {change}, Price: {price}, RoomNumber: {roomNumber}");
                Console.WriteLine($"Valid fields? Amount: {validAmountReceived}, Change: {validChange}, Price: {validPrice}, RoomNumber: {validRoomNumber}");

                // If any of the fields are not valid decimals or room number is invalid, show an error message
                if (!validAmountReceived || !validChange || !validPrice || !validRoomNumber)
                {
                    MessageBox.Show("Please ensure all fields are filled correctly with valid numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create payment object
                var payment = new PaymentModel
                {
                    ReservationID = int.Parse(lbl_guestid.Text),
                    AmountReceived = amountReceived,
                    Change = change,
                    Price = price,
                    Status = "Paid",
                    PaymentDate = DateTime.Now, // Set current date for the payment date
                    RoomNumber = roomNumber.ToString() // Ensure it's passed as a string if required
                };
            }

            // Begin a transaction to ensure atomicity
            //SqlTransaction transaction = new SqlTransaction();

            //    try
            //    {
            //        // Save payment record
            //        paymentController.AddPayment(payment);

            //        // Update payment status to "Paid"
            //        paymentController.UpdatePaymentStatus(payment.ReservationID, "Paid");

            //        // Get the reservation details for transferring to the History table
            //        var reservation = paymentController.GetReservationById(payment.ReservationID);

            //        // Transfer reservation data to History
            //        var history = new History
            //        {
            //            PaymentID = payment.ReservationID,  // Assuming PaymentID is the ReservationID in History
            //            LastName = reservation.LastName,
            //            FirstName = reservation.FirstName,
            //            MiddleInitial = reservation.MiddleInitial,
            //            RoomType = reservation.RoomType,
            //            Status = "CheckedOut",  // Mark as checked-out
            //            NumberOfNights = reservation.NumberOfNights,
            //            CheckInDate = reservation.CheckInDate,
            //            CheckOutDate = DateTime.Now,  // Check-out date is now
            //            Balance = reservation.Balance,
            //            AmountReceived = payment.AmountReceived,
            //            Change = payment.Change,
            //            RoomNumber = reservation.RoomNumber,
            //            CheckOutDateTime = DateTime.Now // Set check-out datetime
            //        };

            //        // Create and use the HistoryController to add history with the transaction
            //        var historyController = new HistoryController();
            //        historyController.AddToHistory(history, transaction); // Pass the transaction here

            //        // Delete the reservation from Reservations table
            //        //paymentController.DeleteReservation(payment.ReservationID, transaction);

            //        // Update room availability status
            //        //paymentController.UpdateRoomAvailability(reservation.RoomID, true, transaction);  // Mark room as available

            //        // Commit the transaction
            //        //transaction.Complete();

            //        // Success message
            //        MessageBox.Show("✅ Payment saved, room marked as Available, and reservation transferred to History!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        // Refresh the grid after saving payment
            //        dtgInfo.DataSource = paymentController.GetReservedPayments();

            //        // Optionally clear fields after saving
            //        ClearFields();
            //    }
            //    catch (Exception ex)
            //    {
            //        // Rollback the transaction if any error occurs
            //        MessageBox.Show($"Error during transaction: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        transaction.Dispose();
            //    }
            //}

            catch (Exception ex)
            {
                MessageBox.Show($"Error saving payment: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearFields();
        }

        
        private void ClearFields()
        {
            txtLastnameadmin.Clear();
            txtFirstnameadmin.Clear();
            txtInitialadmin.Clear();
            lbl_guestid.Text = "";
            txt_roomtype.Clear();
            txt_status.Clear();

            txt_amount.Clear();
            txt_change.Clear();
            txt_balance.Clear();
            txt_num.Clear();

            checkindate.Value = DateTime.Today;
            checkoutdate.Value = DateTime.Today;

            txtSearchadmin.Clear();
        }


        // Method to clear all form fields after saving the payment


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearchadmin_Enter(object sender, EventArgs e)
        {
            if (txtSearchadmin.Text == "Search Guest")
            {
                txtSearchadmin.Text = "";
                txtSearchadmin.ForeColor = Color.Black;
            }
        }

        private void txtSearchadmin_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchadmin.Text))
            {
                txtSearchadmin.Text = "Search Guest";
                txtSearchadmin.ForeColor = Color.Gray;
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void txt_change_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();    
            invoice.Show();
            this.Hide();
        }
    }
}

