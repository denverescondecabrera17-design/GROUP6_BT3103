namespace CODEINN.UI
{
    partial class AdminDashboard
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
            btnLogout = new Button();
            label4 = new Label();
            panel2 = new Panel();
            btnadminroom = new Button();
            btnPayment = new Button();
            btnBooking = new Button();
            btnGuest = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            grbRAvailable = new GroupBox();
            lbl_roomsavail = new Label();
            grbRoomsoccupied = new GroupBox();
            lblRoomsoccupied = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            grbRAvailable.SuspendLayout();
            grbRoomsoccupied.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-40, -22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1967, 140);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(1760, 57);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(162, 56);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // label4
            // 
            label4.AccessibleRole = AccessibleRole.SplitButton;
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(80, 54);
            label4.Name = "label4";
            label4.Size = new Size(215, 44);
            label4.TabIndex = 2;
            label4.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(btnadminroom);
            panel2.Controls.Add(btnPayment);
            panel2.Controls.Add(btnBooking);
            panel2.Controls.Add(btnGuest);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(-39, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(354, 988);
            panel2.TabIndex = 11;
            // 
            // btnadminroom
            // 
            btnadminroom.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadminroom.Location = new Point(64, 165);
            btnadminroom.Name = "btnadminroom";
            btnadminroom.Size = new Size(243, 121);
            btnadminroom.TabIndex = 19;
            btnadminroom.Text = "Room";
            btnadminroom.UseVisualStyleBackColor = true;
            btnadminroom.Click += btnadminroom_Click;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(65, 775);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(243, 121);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnBooking
            // 
            btnBooking.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBooking.Location = new Point(65, 572);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(243, 121);
            btnBooking.TabIndex = 2;
            btnBooking.Text = "Guest Reservation";
            btnBooking.UseVisualStyleBackColor = true;
            btnBooking.Click += btnBooking_Click;
            // 
            // btnGuest
            // 
            btnGuest.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuest.Location = new Point(65, 370);
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
            pictureBox2.Location = new Point(82, 59);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(218, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Gemini_Generated_Image_y39n9hy39n9hy39n_removebg_preview;
            pictureBox3.Location = new Point(91, 266);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(204, 154);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 16;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Gemini_Generated_Image_y39n9hy39n9hy39n__2__removebg_preview;
            pictureBox4.Location = new Point(73, 474);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(234, 147);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.Gemini_Generated_Image_y39n9hy39n9hy39n__3__removebg_preview;
            pictureBox5.Location = new Point(95, 681);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(191, 142);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // grbRAvailable
            // 
            grbRAvailable.BackColor = SystemColors.ButtonHighlight;
            grbRAvailable.Controls.Add(lbl_roomsavail);
            grbRAvailable.Cursor = Cursors.SizeNS;
            grbRAvailable.Location = new Point(408, 317);
            grbRAvailable.Name = "grbRAvailable";
            grbRAvailable.Size = new Size(289, 163);
            grbRAvailable.TabIndex = 12;
            grbRAvailable.TabStop = false;
            grbRAvailable.Text = "Rooms Available";
            // 
            // lbl_roomsavail
            // 
            lbl_roomsavail.AutoSize = true;
            lbl_roomsavail.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_roomsavail.Location = new Point(112, 55);
            lbl_roomsavail.Name = "lbl_roomsavail";
            lbl_roomsavail.Size = new Size(55, 39);
            lbl_roomsavail.TabIndex = 1;
            lbl_roomsavail.Text = "00";
            // 
            // grbRoomsoccupied
            // 
            grbRoomsoccupied.BackColor = SystemColors.ButtonHighlight;
            grbRoomsoccupied.Controls.Add(lblRoomsoccupied);
            grbRoomsoccupied.Cursor = Cursors.SizeNS;
            grbRoomsoccupied.Location = new Point(411, 581);
            grbRoomsoccupied.Name = "grbRoomsoccupied";
            grbRoomsoccupied.Size = new Size(289, 163);
            grbRoomsoccupied.TabIndex = 13;
            grbRoomsoccupied.TabStop = false;
            grbRoomsoccupied.Text = "Rooms Occupied";
            // 
            // lblRoomsoccupied
            // 
            lblRoomsoccupied.AutoSize = true;
            lblRoomsoccupied.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomsoccupied.Location = new Point(112, 62);
            lblRoomsoccupied.Name = "lblRoomsoccupied";
            lblRoomsoccupied.Size = new Size(55, 39);
            lblRoomsoccupied.TabIndex = 1;
            lblRoomsoccupied.Text = "00";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n__1_1;
            pictureBox1.Location = new Point(780, 180);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1036, 760);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1924, 987);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(grbRAvailable);
            Controls.Add(grbRoomsoccupied);
            Controls.Add(pictureBox1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            WindowState = FormWindowState.Maximized;
            Load += AdminDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLogout;
        private Label label4;
        private Panel panel2;
        private Button btnPayment;
        private Button btnBooking;
        private Button btnGuest;
        private GroupBox grbRAvailable;
        private Label lbl_roomsavail;
        private GroupBox grbRoomsoccupied;
        private Label lblRoomsoccupied;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Button btnadminroom;
    }
}