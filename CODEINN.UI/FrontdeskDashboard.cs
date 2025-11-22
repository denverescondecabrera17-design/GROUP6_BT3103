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
using CODEINN.Repository;

namespace CODEINN.UI
{
    public partial class FrontdeskDashboard : Form
    {
        private readonly RoomController roomController;

        public FrontdeskDashboard()
        {
            InitializeComponent();
            roomController = new RoomController();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void UpdateAvailableRoomCount()
        {
            int totalAvailable = roomController.GetAvailableRoomsCount();
            lbl_availrooms.Text = totalAvailable.ToString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            UpdateAvailableRoomCount();
            UpdateOccupiedRoomCount();

        }

        private void UpdateOccupiedRoomCount()
        {
            int occupied = roomController.GetOccupiedRoomsCount();
            lblRoomsoccupied.Text = occupied.ToString();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblRoomAvailable_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();

            this.Hide();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            FrontDeskGuestInfo back = new FrontDeskGuestInfo();
            back.Show();

            this.Hide();
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            FrontdeskRoomManagement dashboard = new FrontdeskRoomManagement();
            dashboard.Show();

            this.Hide();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            FrontdeskReservation reservation = new FrontdeskReservation();
            reservation.Show();

            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            FrontdeskPayment payment = new FrontdeskPayment();
            payment.Show();
            this.Hide();
        }
    }
}
