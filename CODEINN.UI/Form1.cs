using System.Data;

namespace CODEINN.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = Username.Text;
            user_password = Password.Text;

            try
            {
                //String querry = "SELECT * FROM Login_new WHERE username = '" + Username.Text + "' AND password = '" + Password.Text + "'";
                //SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                // sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    username = Username.Text;
                    user_password = Password.Text;

                    Dashboard form2 = new Dashboard();
                    form2.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Username.Clear();
                    Password.Clear();
                    Username.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                // conn.Close();
            }
        }
    }
}
