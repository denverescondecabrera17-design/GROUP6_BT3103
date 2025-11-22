using CODEINN.Controller;

namespace CODEINN.UI
{
    public partial class AdminDashboard : Form
    {
        private readonly RoomController roomController;
        public AdminDashboard()
        {
            InitializeComponent();
            roomController = new RoomController();
        }

        private void UpdateAvailableRoomCount()
        {
            int totalAvailable = roomController.GetAvailableRoomsCount();
            lbl_roomsavail.Text = totalAvailable.ToString();
        }

        private void UpdateOccupiedRoomCount()
        {
            int occupied = roomController.GetOccupiedRoomsCount();
            lblRoomsoccupied.Text = occupied.ToString();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {

            AdminReservation reservation = new AdminReservation();
            reservation.Show();

            this.Hide();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            AdminGuestInfo reservation = new AdminGuestInfo();
            reservation.Show();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            UpdateAvailableRoomCount();
            UpdateOccupiedRoomCount();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();

            this.Hide();
        }

        private void btnadminroom_Click(object sender, EventArgs e)
        {
            AdminRoomManagement rm = new AdminRoomManagement();
            rm.Show();

            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Adminpayment pay = new Adminpayment();
            pay.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

