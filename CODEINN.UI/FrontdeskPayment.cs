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

namespace CODEINN.UI
{
    public partial class FrontdeskPayment : Form
    {
        private PaymentsController paymentController;

        public FrontdeskPayment()
        {
            InitializeComponent();
            paymentController = new PaymentsController();
        }

        private void FrontdeskPayment_Load(object sender, EventArgs e)
        {
            dtgInfo.DataSource = paymentController.GetReservedPayments();

            txtSearchadmin.Enter += enter;
            txtSearchadmin.Leave += exit;

        }

        private void dtgInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgInfo.Rows[e.RowIndex];

                txtLastnameadmin.Text = row.Cells["LastName"].Value?.ToString();
                txtFirstnameadmin.Text = row.Cells["FirstName"].Value?.ToString();
                txtInitialadmin.Text = row.Cells["MiddleInitial"].Value?.ToString();
                txtGuestIdadmin.Text = row.Cells["ReservationID"].Value?.ToString();

                txt_roomtype.Text = row.Cells["RoomType"].Value?.ToString();

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

                    checkindate.Value = checkIn;
                    checkoutdate.Value = checkOut;

                    int nights = (checkOut - checkIn).Days;
                    if (nights < 1) nights = 1;
                    txt_num.Text = nights.ToString();

                    decimal pricePerNight = Convert.ToDecimal(row.Cells["Price"].Value);
                    decimal totalPrice = pricePerNight * nights;

                    txt_price.Text = totalPrice.ToString("0.00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Date format error:\n" + ex.Message);
                }

                txt_status.Text = row.Cells["Status"].Value?.ToString();
            }
        }

        private void txt_amount_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_amount.Text, out decimal received) &&
               decimal.TryParse(txt_price.Text, out decimal price))
            {
                txt_change.Text = (received - price).ToString("0.00");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtGuestIdadmin.Text))
            {
                MessageBox.Show("Please select a reservation first.");
                return;
            }

            try
            {
                var payment = new PaymentModel
                {
                    ReservationID = int.Parse(txtGuestIdadmin.Text),
                    AmountReceived = decimal.Parse(txt_amount.Text),
                    Change = decimal.Parse(txt_change.Text),
                    Price = decimal.Parse(txt_price.Text),
                    Status = "Paid"
                };

                // Save payment
                paymentController.AddPayment(payment);

                // Update reservation status
                paymentController.UpdatePaymentStatus(payment.ReservationID, "Paid");

                // Free the room
                paymentController.UpdateRoomAvailability(payment.ReservationID, "Available");

                MessageBox.Show("Payment completed successfully!");

                dtgInfo.DataSource = paymentController.GetReservedPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment error: " + ex.Message);
            }

            ClearFields();
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            FrontdeskDashboard dashboard = new FrontdeskDashboard();
            dashboard.Show();
            this.Hide();
        }
        private void ClearFields()
        {
            txtLastnameadmin.Clear();
            txtFirstnameadmin.Clear();
            txtInitialadmin.Clear();
            txtGuestIdadmin.Clear();
            txt_roomtype.Clear();
            txt_status.Clear();
            txt_price.Clear();
            txt_amount.Clear();
            txt_change.Clear();
            txt_num.Clear();

            checkindate.Value = DateTime.Today;
            checkoutdate.Value = DateTime.Today;


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
    }
}
