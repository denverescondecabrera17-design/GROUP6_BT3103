using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CODEINN.Controller;
using CODEINN.Model;
using CODEINN.Model.CODEINN.Model;

namespace CODEINN.UI
{
    public partial class FrontdeskReservation : Form
    {
        private readonly ReservationController reservationController;
        private readonly GuestInfoController guestController;

        private List<Rooms> availableRooms;
        private int selectedReservationId = 0;
        private int? currentRoomId = null;
        public FrontdeskReservation()
        {
            InitializeComponent();
            reservationController = new ReservationController();
            guestController = new GuestInfoController();



        }
        private void LoadReservationList()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reservationController.GetReservationDetails();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridView1.Columns.Contains("RoomID"))
                dataGridView1.Columns["RoomID"].Visible = false;
        }

        private void LoadGuestInfo()
        {
            dtgInfo.DataSource = null;
            dtgInfo.DataSource = guestController.GetAllGuests();
            dtgInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void RefreshAvailableRooms()
        {
            if (cm_roomtype.SelectedIndex == -1)
            {
                cb_roomnumber.DataSource = null;
                availableRooms = new List<Rooms>();
                return;
            }

            string selectedType = cm_roomtype.SelectedItem.ToString();
            availableRooms = reservationController.GetAvailableRoomsByType(selectedType);

            // include current room
            if (currentRoomId.HasValue && !availableRooms.Any(r => r.RoomID == currentRoomId.Value))
            {
                var currentRoom = reservationController.GetRoomById(currentRoomId.Value);
                if (currentRoom != null)
                    availableRooms.Insert(0, currentRoom);
            }

            cb_roomnumber.DataSource = availableRooms;
            cb_roomnumber.DisplayMember = "RoomNumber";
            cb_roomnumber.ValueMember = "RoomID";
            cb_roomnumber.SelectedIndex = -1;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cm_roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAvailableRooms();
        }

        private void FrontdeskReservation_Load(object sender, EventArgs e)
        {
            // Load room types
            cm_roomtype.Items.AddRange(new string[]
            {
                "Standard", "Deluxe", "Suite", "Family", "Presidential"
            });

            cm_roomtype.SelectedIndexChanged += cm_roomtype_SelectedIndexChanged;

            LoadGuestInfo();
            LoadReservationList();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //1) Validate guest and room
            if (!ValidateGuestAndRoom(out int guestId, out Rooms selectedRoom)) return;

            // 2) Active reservation check
            var existingReservation = reservationController.GetActiveReservationByGuest(guestId);
            if (existingReservation != null)
            {
                MessageBox.Show("This guest already has an active reservation!");
                return;
            }
            // 3) Dates
            DateTime checkIn = dtpBirtdateadmin.Value.Date;
            DateTime checkOut = dateTimePicker1.Value.Date;

            if (!ValidateDates(checkIn, checkOut)) return;

            // Calculate the number of nights (no +1)
            int nights = (checkOut - checkIn).Days;  // No +1 to avoid including the check-out date

            // Ensure the nights count is at least 1
            if (nights < 1)
            {
                nights = 1;  // If check-in and check-out are the same day, it's considered 1 night
            }

            // 4) Show the calculated number of nights in the textbox
            txt_num.Text = nights.ToString();  // This will display the number of nights in the txt_numnights textbox

            // 5) Compute total price  
            decimal roomPrice = reservationController.GetRoomPrice(selectedRoom.RoomID);
            decimal total = roomPrice * nights;

            // 6) Insert reservation
            var reservation = new Reservation
            {
                GuestID = guestId,
                RoomID = selectedRoom.RoomID,
                CheckInDate = checkIn,
                CheckOutDate = checkOut,
                NumberOfNights = nights,
                Status = "Reserved"
            };

            int reservationId = reservationController.AddReservation(reservation);

            // 7) Set room unavailable
            reservationController.UpdateRoomAvailability(selectedRoom.RoomID, false);

            // 8) Payment inputs
            decimal received = 0;
            decimal.TryParse(txt_payment.Text, out received);

            // Compute balance + change
            decimal balance = total - received;
            decimal change = 0;

            if (received >= total)
            {
                change = received - total;
                balance = 0;
            }

            string status = balance <= 0 ? "Paid" : "Partial";

            // 9) Save payment
            var payment = new PaymentModel
            {
                ReservationID = reservationId,
                AmountReceived = received,
                Balance = balance,
                Price = total,
                Status = status
            };

            reservationController.AddPayment(payment);  // Ensure payment is added to the database

            // 10) Show amounts
            lbl_balance.Text = balance.ToString("0.00");

            MessageBox.Show($"Reservation added successfully!\nPayment status: {status}");

            // 11) Reset fields
            txtFirstnameadmin.Clear();
            txtLastnameadmin.Clear();
            txtInitialadmin.Clear();
            txt_payment.Clear();
            txt_num.Clear();  // Reset the nights textbox after the reservation is added
            cm_roomtype.SelectedIndex = -1;
            cb_roomnumber.SelectedIndex = -1;

            // Optionally reset any labels or additional UI elements
            lbl_balance.Text = "0.00";

            // 12) Reload data
            LoadReservationList();
            RefreshAvailableRooms();
        }


        private void ClearFields()
        {
            lbl_guestid.Text = "";
            txtLastnameadmin.Clear();
            txtFirstnameadmin.Clear();
            txtInitialadmin.Clear();
            cm_roomtype.SelectedIndex = -1;
            cb_roomnumber.SelectedIndex = -1;

            dtpBirtdateadmin.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;

            txt_num.Clear();
            txt_payment.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedReservationId == 0)
            {
                MessageBox.Show("Select a reservation first!");
                return;
            }

            if (!ValidateGuestAndRoom(out int guestId, out Rooms selectedRoom)) return;

            DateTime checkIn = dtpBirtdateadmin.Value;
            DateTime checkOut = dateTimePicker1.Value;

            if (!ValidateDates(checkIn, checkOut)) return;

            int nights = (checkOut - checkIn).Days;

            var reservation = new Reservation
            {
                ReservationID = selectedReservationId,
                GuestID = guestId,
                RoomID = selectedRoom.RoomID,
                CheckInDate = checkIn,
                CheckOutDate = checkOut,
                NumberOfNights = nights,
                Status = "Reserved"
            };

            bool updated = reservationController.UpdateReservation(reservation);
            if (updated)
            {
                // Calculate balance
                CalculateBalance();

                // Create and save the payment
                decimal received = 0;
                decimal.TryParse(txt_payment.Text, out received);

                decimal total = reservationController.GetRoomPrice(selectedRoom.RoomID) * nights;
                decimal balance = total - received;
                string status = balance <= 0 ? "Paid" : "Partial";

                var payment = new PaymentModel
                {
                    ReservationID = selectedReservationId,
                    AmountReceived = received,
                    Balance = balance,
                    Price = total,
                    Status = status
                };

                reservationController.AddPayment(payment);  // Ensure payment is added to the database

                MessageBox.Show("Reservation updated successfully!");

                // Refresh reservation list
                LoadReservationList();
                RefreshAvailableRooms();
            }
            else
            {
                MessageBox.Show("Failed to update reservation.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgInfo.Rows[e.RowIndex];

                // Reservation & Guest Info
                selectedReservationId = Convert.ToInt32(row.Cells["ReservationID"].Value);
                lbl_guestid.Text = row.Cells["GuestID"].Value.ToString();
                txtLastnameadmin.Text = row.Cells["LastName"].Value.ToString();
                txtFirstnameadmin.Text = row.Cells["FirstName"].Value.ToString();
                txtInitialadmin.Text = row.Cells["MiddleInitial"].Value.ToString();

                // Room Info
                string roomType = row.Cells["RoomType"].Value.ToString();
                string roomNumber = row.Cells["RoomNumber"].Value.ToString();
                currentRoomId = Convert.ToInt32(row.Cells["RoomID"].Value);

                // ✅ Select the room type safely
                if (cm_roomtype.Items.Contains(roomType))
                {
                    cm_roomtype.SelectedItem = roomType;
                }
                else
                {
                    cm_roomtype.SelectedIndex = -1;
                }

                // ✅ Refresh available rooms after selecting type
                RefreshAvailableRooms();

                // ✅ Ensure current room appears even if unavailable
                if (availableRooms != null && availableRooms.Any(r => r.RoomID == currentRoomId))
                {
                    cb_roomnumber.SelectedValue = currentRoomId;
                }
                else
                {
                    cb_roomnumber.Text = roomNumber; // fallback display
                }

                // ✅ Hide RoomID column from user
                if (dtgInfo.Columns.Contains("RoomID"))
                    dtgInfo.Columns["RoomID"].Visible = false;

                // Dates & Time
                dtpBirtdateadmin.Value = Convert.ToDateTime(row.Cells["CheckInDate"].Value);
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["CheckOutDate"].Value);

                txt_num.Text = row.Cells["NumberOfNights"].Value.ToString();

                // Balance
                if (row.Cells["Balance"] != null && row.Cells["Balance"].Value != DBNull.Value)
                {
                    decimal balance = Convert.ToDecimal(row.Cells["Balance"].Value);
                    lbl_balance.Text = balance.ToString("0.00");
                }
                else
                {
                    lbl_balance.Text = "0.00"; // Default if no balance is found
                }
            }
        }

        private void dtgInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtgInfo.Rows[e.RowIndex];

                lbl_guestid.Text = row.Cells["GuestID"].Value.ToString();
                txtLastnameadmin.Text = row.Cells["LastName"].Value.ToString();
                txtFirstnameadmin.Text = row.Cells["FirstName"].Value.ToString();
                txtInitialadmin.Text = row.Cells["MiddleInitial"].Value.ToString();
            }
        }

        private bool ValidateGuestAndRoom(out int guestId, out Rooms selectedRoom)
        {
            guestId = 0;
            selectedRoom = null;

            if (!int.TryParse(lbl_guestid.Text, out guestId))
            {
                MessageBox.Show("Select a guest first!");
                return false;
            }

            if (cm_roomtype.SelectedIndex == -1 || cb_roomnumber.SelectedIndex == -1)
            {
                MessageBox.Show("Select a room type and a room.");
                return false;
            }

            if (cb_roomnumber.SelectedValue == null)
            {
                MessageBox.Show("Invalid room selection.");
                return false;
            }

            int roomId = (int)cb_roomnumber.SelectedValue;
            selectedRoom = availableRooms.FirstOrDefault(r => r.RoomID == roomId);

            return selectedRoom != null;
        }

        private bool ValidateDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out must be after check-in.");
                return false;
            }

            return true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Get the check-in and check-out dates without time information
            DateTime checkIn = dtpBirtdateadmin.Value.Date;  // Check-in date
            DateTime checkOut = dateTimePicker1.Value.Date;  // Check-out date

            // Ensure check-out is after check-in
            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out date must be after the check-in date.");
                return;
            }

            // Calculate the number of nights (including both check-in and check-out dates)
            int nights = (checkOut - checkIn).Days;  // Calculate the difference in days

            // If the check-out is the same day as check-in, ensure it's 1 night
            if (nights < 1)
            {
                nights = 1;  // Ensure there's at least 1 night
            }

            // Update the txt_numnights textbox with the calculated nights
            txt_num.Text = nights.ToString();
        }

        private void txtSearchadmin_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchadmin.Text.Trim();

            if (keyword == "Search Guest" || string.IsNullOrEmpty(keyword))
            {
                // Load original data
                dtgInfo.DataSource = guestController.GetAllGuests();
                dataGridView1.DataSource = reservationController.GetReservationDetails();
                return;
            }

            // Filtered results
            dtgInfo.DataSource = guestController.SearchGuests(keyword);
            dataGridView1.DataSource = reservationController.SearchReservations(keyword);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearchadmin.Text == "Search Guest")
            {
                txtSearchadmin.Text = "";
                txtSearchadmin.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchadmin.Text))
            {
                txtSearchadmin.Text = "Search Guest";
                txtSearchadmin.ForeColor = Color.Gray;
            }
        }



        private void btnBack1_Click(object sender, EventArgs e)
        {
            FrontdeskDashboard dashboard = new FrontdeskDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {
            CalculateBalance();
        }

        private void CalculateBalance()
        {
            // Ensure room is selected, and textboxes for nights and payment are not empty
            if (cb_roomnumber.SelectedValue == null || string.IsNullOrWhiteSpace(txt_num.Text) || string.IsNullOrWhiteSpace(txt_payment.Text))
                return;

            // Parse the number of nights (from the text box)
            int nights = int.Parse(txt_num.Text);

            // Get the selected room ID
            int roomId = (int)cb_roomnumber.SelectedValue;

            // Get the price of the selected room
            decimal roomPrice = reservationController.GetRoomPrice(roomId);

            // Calculate the total price for the reservation
            decimal total = roomPrice * nights;

            // Parse the payment amount received from the textbox
            decimal received = 0;
            decimal.TryParse(txt_payment.Text, out received);

            // Calculate the balance (total - received amount)
            decimal balance = total - received;

            // Check if balance is zero or negative, set the payment status accordingly
            string status = balance <= 0 ? "Paid" : "Partial";

            // Display the balance in the label
            lbl_balance.Text = balance.ToString("0.00");

            // Optionally, show the payment status if needed
            // lbl_paymentStatus.Text = status;
        }

        private void txt_payment_TextChanged(object sender, EventArgs e)
        {
            CalculateBalance();
        }
    }
}
