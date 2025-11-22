using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CODEINN.Controller;
using CODEINN.Model;
using System.Globalization;

namespace CODEINN.UI
{
    public partial class Adminpayment : Form
    {
        private PaymentsController paymentController;
        public Adminpayment()
        {
            InitializeComponent();
            paymentController = new PaymentsController();

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

                // ✅ Guest info
                txtLastnameadmin.Text = row.Cells["LastName"].Value?.ToString();
                txtFirstnameadmin.Text = row.Cells["FirstName"].Value?.ToString();
                txtInitialadmin.Text = row.Cells["MiddleInitial"].Value?.ToString();
                txtGuestIdadmin.Text = row.Cells["ReservationID"].Value?.ToString();

                // ✅ Room info
                txt_roomtype.Text = row.Cells["RoomType"].Value?.ToString();

                // ✅ Date info — detect if already DateTime
                object checkInObj = row.Cells["CheckInDate"].Value;
                object checkOutObj = row.Cells["CheckOutDate"].Value;

                DateTime checkIn, checkOut;

                try
                {
                    if (checkInObj is DateTime)
                        checkIn = (DateTime)checkInObj;
                    else
                        checkIn = Convert.ToDateTime(checkInObj, CultureInfo.InvariantCulture);

                    if (checkOutObj is DateTime)
                        checkOut = (DateTime)checkOutObj;
                    else
                        checkOut = Convert.ToDateTime(checkOutObj, CultureInfo.InvariantCulture);

                    // ✅ Update your DateTimePickers directly
                    checkindate.Value = checkIn;
                    checkoutdate.Value = checkOut;

                    int nights = (checkOut - checkIn).Days;
                    if (nights < 1) nights = 1;
                    txt_num.Text = nights.ToString();

                    // ✅ Total price
                    decimal pricePerNight = Convert.ToDecimal(row.Cells["Price"].Value);
                    decimal totalPrice = pricePerNight * nights;
                    txt_price.Text = totalPrice.ToString("0.00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Invalid check-in/check-out date format.\n\n{ex.Message}",
                        "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                // ✅ Status
                txt_status.Text = row.Cells["Status"].Value?.ToString();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_amount.Text, out decimal received) &&
               decimal.TryParse(txt_price.Text, out decimal price))
            {
                txt_change.Text = (received - price).ToString("0.00");
            }
        }

        private void Adminpayment_Load(object sender, EventArgs e)
        {
            dtgInfo.DataSource = paymentController.GetReservedPayments();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGuestIdadmin.Text))
            {
                MessageBox.Show("Please select a reservation first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ✅ Create payment object
                var payment = new PaymentModel
                {
                    ReservationID = int.Parse(txtGuestIdadmin.Text),
                    AmountReceived = decimal.Parse(txt_amount.Text),
                    Change = decimal.Parse(txt_change.Text),
                    Price = decimal.Parse(txt_price.Text),
                    Status = "Paid"
                };

                // ✅ Save payment and update reservation
                paymentController.AddPayment(payment);
                paymentController.UpdatePaymentStatus(payment.ReservationID, "Paid");

                // ✅ Also update the room to "Available"
                paymentController.UpdateRoomAvailability(payment.ReservationID, "Available");

                MessageBox.Show("✅ Payment saved and room marked as Available!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgInfo.DataSource = paymentController.GetReservedPayments(); // Refresh grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFields();
        }

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
        private void ClearFields()
        {
            txtLastnameadmin.Clear();
            txtFirstnameadmin.Clear();
            txtInitialadmin.Clear();
            txtGuestIdadmin.Clear();
            txt_roomtype.Clear();
            txt_status.Clear();

            txt_amount.Clear();
            txt_change.Clear();
            txt_price.Clear();
            txt_num.Clear();

            checkindate.Value = DateTime.Today;
            checkoutdate.Value = DateTime.Today;

            txtSearchadmin.Clear();
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
    }
}

