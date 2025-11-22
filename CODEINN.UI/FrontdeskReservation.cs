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
            if (!ValidateGuestAndRoom(out int guestId, out Rooms selectedRoom)) return;

            var existingReservation = reservationController.GetActiveReservationByGuest(guestId);

            if (existingReservation != null)
            {
                MessageBox.Show("This guest already has an active reservation!");
                return;
            }

            DateTime checkIn = dtpBirtdateadmin.Value.Date;
            DateTime checkOut = dateTimePicker1.Value.Date;

            if (!ValidateDates(checkIn, checkOut)) return;

            int nights = (checkOut - checkIn).Days;

            var reservation = new Reservation
            {
                GuestID = guestId,
                RoomID = selectedRoom.RoomID,
                CheckInDate = checkIn,
                CheckOutDate = checkOut,
                CheckInTime = txt_time.Text.Trim(),
                NumberOfNights = nights,
                Status = "Reserved"
            };

            reservationController.AddReservation(reservation);

            reservationController.UpdateRoomAvailability(selectedRoom.RoomID, false);

            MessageBox.Show("Reservation added successfully!");

            ClearFields();
            LoadReservationList();
            RefreshAvailableRooms();
        }
        private void ClearFields()
        {
            txtGuestId.Text = "";
            txtLastnameadmin.Clear();
            txtFirstnameadmin.Clear();
            txtInitialadmin.Clear();
            cm_roomtype.SelectedIndex = -1;
            cb_roomnumber.SelectedIndex = -1;

            dtpBirtdateadmin.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;

            txt_num.Clear();
            txt_time.Clear();
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
                CheckInTime = txt_time.Text.Trim(),
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];

                selectedReservationId = Convert.ToInt32(row.Cells["ReservationID"].Value);
                txtGuestId.Text = row.Cells["GuestID"].Value.ToString();

                txtLastnameadmin.Text = row.Cells["LastName"].Value.ToString();
                txtFirstnameadmin.Text = row.Cells["FirstName"].Value.ToString();
                txtInitialadmin.Text = row.Cells["MiddleInitial"].Value.ToString();

                string roomType = row.Cells["RoomType"].Value.ToString();
                string roomNumber = row.Cells["RoomNumber"].Value.ToString();

                currentRoomId = Convert.ToInt32(row.Cells["RoomID"].Value);

                cm_roomtype.SelectedItem = roomType;
                RefreshAvailableRooms();

                cb_roomnumber.SelectedValue = currentRoomId;

                dtpBirtdateadmin.Value = Convert.ToDateTime(row.Cells["CheckInDate"].Value);
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["CheckOutDate"].Value);

                txt_time.Text = row.Cells["CheckInTime"].Value?.ToString() ?? "";
                txt_num.Text = row.Cells["NumberOfNights"].Value.ToString();
            }
        }

        private void dtgInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtgInfo.Rows[e.RowIndex];

                txtGuestId.Text = row.Cells["GuestID"].Value.ToString();
                txtLastnameadmin.Text = row.Cells["LastName"].Value.ToString();
                txtFirstnameadmin.Text = row.Cells["FirstName"].Value.ToString();
                txtInitialadmin.Text = row.Cells["MiddleInitial"].Value.ToString();
            }
        }

        private bool ValidateGuestAndRoom(out int guestId, out Rooms selectedRoom)
        {
            guestId = 0;
            selectedRoom = null;

            if (!int.TryParse(txtGuestId.Text, out guestId))
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
            TimeSpan stay = dateTimePicker1.Value - dtpBirtdateadmin.Value;
            txt_num.Text = stay.Days > 0 ? stay.Days.ToString() : "0";
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


    }
}
