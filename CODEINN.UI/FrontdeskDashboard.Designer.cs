namespace CODEINN.UI
{
    partial class FrontdeskDashboard
    {
      
        private System.ComponentModel.IContainer components = null;

      
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            label4 = new Label();
            btnLogout = new Button();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            btnPayment = new Button();
            btnBooking = new Button();
            btnRoom = new Button();
            btnGuest = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            grbRAvailable = new GroupBox();
            lbl_availrooms = new Label();
            grbRoomsoccupied = new GroupBox();
            lblRoomsoccupied = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            grbRAvailable.SuspendLayout();
            grbRoomsoccupied.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(pictureBox6);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1926, 140);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1588, 223);
            button1.Name = "button1";
            button1.Size = new Size(126, 54);
            button1.TabIndex = 32;
            button1.Text = "History";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(199, 43);
            label4.Name = "label4";
            label4.Size = new Size(215, 44);
            label4.TabIndex = 2;
            label4.Text = "Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1736, 43);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(126, 54);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n_removebg_preview2;
            pictureBox6.Location = new Point(-102, -23);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(413, 183);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnPayment);
            panel2.Controls.Add(btnBooking);
            panel2.Controls.Add(btnRoom);
            panel2.Controls.Add(btnGuest);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(-8, 61);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 923);
            panel2.TabIndex = 1;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(64, 761);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(243, 121);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "History";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnBooking
            // 
            btnBooking.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking.Location = new Point(64, 564);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(243, 121);
            btnBooking.TabIndex = 2;
            btnBooking.Text = "Guest Reservation";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnRoom
            // 
            btnRoom.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoom.Location = new Point(64, 164);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(243, 121);
            btnRoom.TabIndex = 1;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            btnRoom.Click += btnRoom_Click;
            // 
            // btnGuest
            // 
            btnGuest.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuest.Location = new Point(64, 363);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(243, 121);
            btnGuest.TabIndex = 0;
            btnGuest.Text = "Guest Information";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Gemini_Generated_Image_y39n9hy39n9hy39n__1__removebg_preview;
            pictureBox2.Location = new Point(77, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(218, 157);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Gemini_Generated_Image_y39n9hy39n9hy39n_removebg_preview;
            pictureBox3.Location = new Point(85, 261);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(204, 154);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 17;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Gemini_Generated_Image_y39n9hy39n9hy39n__2__removebg_preview;
            pictureBox4.Location = new Point(69, 465);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(234, 147);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 18;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Gemini_Generated_Image_y39n9hy39n9hy39n__3__removebg_preview;
            pictureBox5.Location = new Point(88, 666);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(191, 142);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 19;
            pictureBox5.TabStop = false;
            // 
            // grbRAvailable
            // 
            grbRAvailable.BackColor = SystemColors.ButtonHighlight;
            grbRAvailable.Controls.Add(lbl_availrooms);
            grbRAvailable.Cursor = Cursors.SizeNS;
            grbRAvailable.Location = new Point(442, 225);
            grbRAvailable.Name = "grbRAvailable";
            grbRAvailable.Size = new Size(289, 163);
            grbRAvailable.TabIndex = 2;
            grbRAvailable.TabStop = false;
            grbRAvailable.Text = "Rooms Available";
            // 
            // lbl_availrooms
            // 
            lbl_availrooms.AutoSize = true;
            lbl_availrooms.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_availrooms.Location = new Point(117, 66);
            lbl_availrooms.Name = "lbl_availrooms";
            lbl_availrooms.Size = new Size(55, 39);
            lbl_availrooms.TabIndex = 0;
            lbl_availrooms.Text = "00";
            lbl_availrooms.Click += label1_Click;
            // 
            // grbRoomsoccupied
            // 
            grbRoomsoccupied.BackColor = SystemColors.ButtonHighlight;
            grbRoomsoccupied.Controls.Add(lblRoomsoccupied);
            grbRoomsoccupied.Cursor = Cursors.SizeNS;
            grbRoomsoccupied.Location = new Point(442, 450);
            grbRoomsoccupied.Name = "grbRoomsoccupied";
            grbRoomsoccupied.Size = new Size(289, 163);
            grbRoomsoccupied.TabIndex = 3;
            grbRoomsoccupied.TabStop = false;
            grbRoomsoccupied.Text = "Rooms Occupied";
            grbRoomsoccupied.Enter += groupBox1_Enter;
            // 
            // lblRoomsoccupied
            // 
            lblRoomsoccupied.AutoSize = true;
            lblRoomsoccupied.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomsoccupied.Location = new Point(117, 64);
            lblRoomsoccupied.Name = "lblRoomsoccupied";
            lblRoomsoccupied.Size = new Size(55, 39);
            lblRoomsoccupied.TabIndex = 1;
            lblRoomsoccupied.Text = "00";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n__1_1;
            pictureBox1.Location = new Point(805, 184);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1036, 760);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(label1);
            groupBox1.Cursor = Cursors.SizeNS;
            groupBox1.Location = new Point(442, 673);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(289, 163);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Unavailable Room";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(117, 64);
            label1.Name = "label1";
            label1.Size = new Size(55, 39);
            label1.TabIndex = 1;
            label1.Text = "00";
            // 
            // FrontdeskDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1924, 987);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(grbRoomsoccupied);
            Controls.Add(grbRAvailable);
            Controls.Add(panel2);
            Controls.Add(button1);
            Name = "FrontdeskDashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            grbRAvailable.ResumeLayout(false);
            grbRAvailable.PerformLayout();
            grbRoomsoccupied.ResumeLayout(false);
            grbRoomsoccupied.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnPayment;
        private Button btnBooking;
        private Button btnRoom;
        private Button btnGuest;
        private GroupBox grbRAvailable;
        private GroupBox grbRoomsoccupied;
        private Label lbl_availrooms;
        private PictureBox pictureBox1;
        private Label lblRoomsoccupied;
        private Label label4;
        private Button btnLogout;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private GroupBox groupBox1;
        private Label label1;
        private Button button1;
    }
}