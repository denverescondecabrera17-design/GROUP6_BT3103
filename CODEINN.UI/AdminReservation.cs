using CODEINN.Controller;
using CODEINN.Model;
using CODEINN.Model.CODEINN.Model;

namespace CODEINN.UI
{
    public partial class AdminReservation : Form
    {
        private readonly ReservationController reservationController;
        private readonly GuestInfoController guestController;
        private List<Rooms> availableRooms;
        private int selectedReservationId = 0; // ✅ Added
        private int? currentRoomId = null;

        public AdminReservation()
        {
            InitializeComponent();
            reservationController = new ReservationController();
            guestController = new GuestInfoController();



        }

        private void AdminReservation_Load(object sender, EventArgs e)
        {
            // Load room types
            combo_roomtype.Items.AddRange(new string[] { "Standard", "Deluxe", "Suite", "Family", "Presidential" });
            combo_roomtype.SelectedIndexChanged += ComboRoomType_SelectedIndexChanged;

            // Load guests into guest grid
            LoadGuestInfo();

            // Load reservations into reservation grid
            LoadReservationList();
        }

        private void LoadReservationList()
        {
            dtgInfo.DataSource = null;
            dtgInfo.DataSource = reservationController.GetReservationDetails(); // must exist in your controller
            dtgInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadGuestInfo()
        {
            dtg_guestinfo.DataSource = null;
            dtg_guestinfo.DataSource = guestController.GetAllGuests();
            dtg_guestinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void RefreshAvailableRooms()
        {
            if (combo_roomtype.SelectedIndex == -1)
            {
                combo_room.DataSource = null;
                availableRooms = new List<Rooms>();
                return;
            }

            string selectedType = combo_roomtype.SelectedItem.ToString();
            availableRooms = reservationController.GetAvailableRoomsByType(selectedType);

            // ✅ Include current room even if unavailable
            if (currentRoomId.HasValue && !availableRooms.Any(r => r.RoomID == currentRoomId.Value))
            {
                var currentRoom = reservationController.GetRoomById(currentRoomId.Value);
                if (currentRoom != null)
                    availableRooms.Insert(0, currentRoom);
            }

            combo_room.DataSource = availableRooms;
            combo_room.DisplayMember = "RoomNumber";
            combo_room.ValueMember = "RoomID";
            combo_room.SelectedIndex = -1;
        }


        private void ComboRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAvailableRooms();
        }


        private void LoadGuestList()
        {
            dtg_guestinfo.DataSource = null;
            dtg_guestinfo.DataSource = guestController.GetAllGuests();
            dtg_guestinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {// 1) Validate guest and room
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
            txt_numnights.Text = nights.ToString();  // This will display the number of nights in the txt_numnights textbox

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
            txt_numnights.Clear();  // Reset the nights textbox after the reservation is added
            combo_roomtype.SelectedIndex = -1;
            combo_room.SelectedIndex = -1;

            // Optionally reset any labels or additional UI elements
            lbl_balance.Text = "0.00";

            // 12) Reload data
            LoadReservationList();
            RefreshAvailableRooms();
        }




        private void dtpCheckOut_ValueChanged(object sender, EventArgs e)
        {
            TimeSpan stay = dateTimePicker1.Value - dtpBirtdateadmin.Value;
            txt_numnights.Text = stay.Days > 0 ? stay.Days.ToString() : "0";
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
                MessageBox.Show("Reservation updated successfully!");
                LoadReservationList();
                RefreshAvailableRooms();
            }
            else
            {
                MessageBox.Show("Failed to update reservation.");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dtgInfo.SelectedRows.Count == 0) return;

            var row = dtgInfo.SelectedRows[0];

            lbl_guestid.Text = row.Cells["GuestID"].Value.ToString();
            combo_roomtype.SelectedItem = row.Cells["RoomType"].Value.ToString();

            // ✅ Refresh available rooms before setting the room
            RefreshAvailableRooms();

            // Now select the correct room by RoomNumber
            string roomNumber = row.Cells["RoomNumber"].Value.ToString();
            combo_room.SelectedItem = availableRooms.FirstOrDefault(r => r.RoomNumber == roomNumber)?.RoomNumber;

            dtpBirtdateadmin.Value = Convert.ToDateTime(row.Cells["CheckInDate"].Value);
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells["CheckOutDate"].Value);
            txt_numnights.Text = row.Cells["NumberOfNights"].Value.ToString();


            txtFirstnameadmin.Text = row.Cells["FirstName"].Value.ToString();
            txtLastnameadmin.Text = row.Cells["LastName"].Value.ToString();
            txtInitialadmin.Text = row.Cells["MiddleInitial"].Value.ToString();
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

            if (combo_roomtype.SelectedIndex == -1 || combo_room.SelectedIndex == -1)
            {
                MessageBox.Show("Select room type and number.");
                return false;
            }

            if (combo_room.SelectedValue == null)
            {
                MessageBox.Show("Select a valid room.");
                return false;
            }

            int roomId = (int)combo_room.SelectedValue;
            selectedRoom = availableRooms.FirstOrDefault(r => r.RoomID == roomId);

            if (selectedRoom == null)
            {
                MessageBox.Show("Invalid room selection.");
                return false;
            }

            return true;
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


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dtgInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                if (combo_roomtype.Items.Contains(roomType))
                {
                    combo_roomtype.SelectedItem = roomType;
                }
                else
                {
                    combo_roomtype.SelectedIndex = -1;
                }

                // ✅ Refresh available rooms after selecting type
                RefreshAvailableRooms();

                // ✅ Ensure current room appears even if unavailable
                if (availableRooms != null && availableRooms.Any(r => r.RoomID == currentRoomId))
                {
                    combo_room.SelectedValue = currentRoomId;
                }
                else
                {
                    combo_room.Text = roomNumber; // fallback display
                }

                // ✅ Hide RoomID column from user
                if (dtgInfo.Columns.Contains("RoomID"))
                    dtgInfo.Columns["RoomID"].Visible = false;

                // Dates & Time
                dtpBirtdateadmin.Value = Convert.ToDateTime(row.Cells["CheckInDate"].Value);
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["CheckOutDate"].Value);

                txt_numnights.Text = row.Cells["NumberOfNights"].Value.ToString();

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


        private void txt_numnights_TextChanged(object sender, EventArgs e)
        {
            CalculateBalance();
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
            txt_numnights.Text = nights.ToString();
        }

        private void combo_roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAvailableRooms();

        }

        private void dtg_guestinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtg_guestinfo.Rows[e.RowIndex];

                lbl_guestid.Text = row.Cells["GuestID"].Value.ToString();
                txtLastnameadmin.Text = row.Cells["LastName"].Value.ToString();
                txtFirstnameadmin.Text = row.Cells["FirstName"].Value.ToString();
                txtInitialadmin.Text = row.Cells["MiddleInitial"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dtgInfo.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation to delete.");
                return;
            }

            int reservationId = Convert.ToInt32(dtgInfo.SelectedRows[0].Cells["ReservationID"].Value);

            var confirm = MessageBox.Show("Are you sure you want to delete this reservation?",
                                          "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                bool deleted = reservationController.DeleteReservation(reservationId);
                if (deleted)
                {
                    MessageBox.Show("Reservation deleted successfully!");

                    // Refresh both grids
                    LoadReservationList();
                    RefreshAvailableRooms();
                }
                else
                {
                    MessageBox.Show("Failed to delete reservation.");
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
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

        private void btnBack1_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void txtSearchadmin_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearchadmin.Text.Trim();

            // 🚫 Ignore placeholder text
            if (keyword == "Search Guest")
                return;

            // 🧩 If empty, load everything again
            if (string.IsNullOrEmpty(keyword))
            {
                dtg_guestinfo.DataSource = guestController.GetAllGuests();
                dtgInfo.DataSource = reservationController.GetReservationDetails();
                return;
            }

            // 🧩 Filter guests
            var filteredGuests = guestController.SearchGuests(keyword);
            dtg_guestinfo.DataSource = filteredGuests;

            // 🧩 Filter reservations
            var filteredReservations = reservationController.SearchReservations(keyword);
            dtgInfo.DataSource = filteredReservations;
        }

        private void txt_reservesearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchadmin_Enter(object sender, EventArgs e)
        {
            // When textbox gets focus, clear placeholder
            if (txtSearchadmin.Text == "Search Guest")
            {
                txtSearchadmin.Text = "";
                txtSearchadmin.ForeColor = Color.Black; // Normal typing color
            }
        }

        private void txtSearchadmin_Leave(object sender, EventArgs e)
        {

            // When textbox loses focus and is empty, show placeholder again
            if (string.IsNullOrWhiteSpace(txtSearchadmin.Text))
            {
                txtSearchadmin.Text = "Search Guest";
                txtSearchadmin.ForeColor = Color.Gray;
            }
        }

        private void CalculateBalance()
        {
            // Ensure room is selected, and textboxes for nights and payment are not empty
            if (combo_room.SelectedValue == null || string.IsNullOrWhiteSpace(txt_numnights.Text) || string.IsNullOrWhiteSpace(txt_payment.Text))
                return;

            // Parse the number of nights (from the text box)
            int nights = int.Parse(txt_numnights.Text);

            // Get the selected room ID
            int roomId = (int)combo_room.SelectedValue;

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


