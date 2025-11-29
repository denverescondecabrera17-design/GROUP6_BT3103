using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CODEINN.Repository;
using CODEINN.Model;

namespace CODEINN.UI
{
    public partial class AdminRoomManagement : Form
    {
        private readonly RoomRepository roomRepo = new RoomRepository();

        public AdminRoomManagement()
        {
            InitializeComponent();
        }

        private void txtGuestIdadmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgInfo1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminRoomManagement_Load(object sender, EventArgs e)
        {
            LoadRoomData();

            LoadRoomTypes();

        }

        private void LoadRoomData()
        {
            var rooms = roomRepo.GetAllRooms();
            dtgInfo1.DataSource = rooms;

            dtgInfo1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgInfo1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }

        private void LoadRoomTypes()
        {
            var rooms = roomRepo.GetAllRooms();

            if (rooms.Count == 0)
            {
                MessageBox.Show("No rooms found in the database.");
                return;
            }

            var roomTypes = rooms
                .Select(r => r.RoomType)
                .Distinct()
                .ToList();

            cb_roomtype.DataSource = roomTypes; // ← change this to your actual ComboBox name
        }

        private void LoadRoomNumbers(string roomType)
        {
            var rooms = roomRepo.GetAllRooms()
                                .Where(r => r.RoomType == roomType)
                                .ToList();

            room_number.DataSource = rooms;
            room_number.DisplayMember = "RoomNumber";  // what user sees
            room_number.ValueMember = "RoomID";        // internal value (optional)
        }


        private void btnBack1_Click(object sender, EventArgs e)
        {
            AdminDashboard dashboard = new AdminDashboard();
            dashboard.Show();

            this.Hide();
        }

        private void txtSearchadmin_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_roomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cb_roomtype.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedType)) return;

            // Load room numbers for that room type
            LoadRoomNumbers(selectedType);

            // Auto-fill price
            decimal price = roomRepo.GetPriceByRoomType(selectedType);
            txt_price.Text = price.ToString("N2");

            // Reset status combo
            cb_status.SelectedIndex = -1;

        }

        private void room_number_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (room_number.SelectedItem is Rooms selectedRoom)
            {
                txt_price.Text = selectedRoom.Price.ToString("N2");
                cb_status.SelectedItem = selectedRoom.IsAvailable ? "Available" : "Under Maintenance";
            }
        }

        private void btnSaveadmin_Click(object sender, EventArgs e)
        {
            if (room_number.SelectedItem is not Rooms selectedRoom)
            {
                MessageBox.Show("Please select a room first.");
                return;
            }

            // Update status based on combo box
            selectedRoom.Status = cb_status.SelectedItem?.ToString() ?? "Available";
            selectedRoom.IsAvailable = selectedRoom.Status == "Available";

            roomRepo.EditRoom(selectedRoom);
            MessageBox.Show("Room status updated successfully!");
            LoadRoomData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnview1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
