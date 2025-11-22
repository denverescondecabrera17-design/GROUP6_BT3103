using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CODEINN.UI
{
    public partial class Connect : Form
    {
        public Connect()
        {
            InitializeComponent();
        }

        private void btnadmin_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.Show();

            this.Hide();
        }

        private void btnfrontdesk_Click(object sender, EventArgs e)
        {
            FrontdeskDashboard fr = new FrontdeskDashboard();
            fr.Show();

            this.Hide();
        }
    }
}
