using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CODEINN.Model;
using CODEINN.Repository;

namespace CODEINN.UI
{
    public partial class FrontdeskRoomManagement : Form
    {
        private readonly RoomRepository roomRepo = new RoomRepository();
        public FrontdeskRoomManagement()
        {
            InitializeComponent();
        }

        private void btnview1_Click(object sender, EventArgs e)
        {

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

            cb_roomtype.DataSource = roomTypes;
        }

        private void LoadRoomNumbers(string roomType)
        {
            var rooms = roomRepo.GetAllRooms()
                                .Where(r => r.RoomType == roomType)
                                .ToList();

            cb_roomnum.DataSource = rooms;
            cb_roomnum.DisplayMember = "RoomNumber";
            cb_roomnum.ValueMember = "RoomID";
        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            FrontdeskDashboard dashboard = new FrontdeskDashboard();
            dashboard.Show();

            this.Hide();
        }

        private void FrontdeskRoomManagement_Load(object sender, EventArgs e)
        {
            LoadRoomData();
            LoadRoomTypes();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cb_roomtype.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedType)) return;

            LoadRoomNumbers(selectedType);

            decimal price = roomRepo.GetPriceByRoomType(selectedType);
            txt_price.Text = price.ToString("N2");

        }

        private void cb_roomnum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_roomnum.SelectedItem is Rooms selectedRoom)
            {
                txt_price.Text = selectedRoom.Price.ToString("N2");

            }
        }

        private void dtgInfo1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtgInfo1.Rows[e.RowIndex];

                string type = row.Cells["RoomType"].Value.ToString();
                string number = row.Cells["RoomNumber"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                bool available = Convert.ToBoolean(row.Cells["IsAvailable"].Value);

                cb_roomtype.SelectedItem = type;
                cb_roomnum.Text = number;
                txt_price.Text = price.ToString("N2");
            }
        }
    }
}
