namespace CODEINN.UI
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            panel2 = new Panel();
            btnGuest = new Button();
            btnRoom = new Button();
            btnBooking = new Button();
            btnPayment = new Button();
            grbRAvailable = new GroupBox();
            grbRoomsoccupied = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            lblRoomsoccupied = new Label();
            label3 = new Label();
            label4 = new Label();
            btnLogout = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            grbRAvailable.SuspendLayout();
            grbRoomsoccupied.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(btnLogout);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 63);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(btnPayment);
            panel2.Controls.Add(btnBooking);
            panel2.Controls.Add(btnRoom);
            panel2.Controls.Add(btnGuest);
            panel2.Location = new Point(0, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 535);
            panel2.TabIndex = 1;
            // 
            // btnGuest
            // 
            btnGuest.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuest.Location = new Point(12, 19);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(164, 76);
            btnGuest.TabIndex = 0;
            btnGuest.Text = "Guest Information";
            btnGuest.UseVisualStyleBackColor = true;
            // 
            // btnRoom
            // 
            btnRoom.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRoom.Location = new Point(12, 114);
            btnRoom.Name = "btnRoom";
            btnRoom.Size = new Size(164, 76);
            btnRoom.TabIndex = 1;
            btnRoom.Text = "Room";
            btnRoom.UseVisualStyleBackColor = true;
            // 
            // btnBooking
            // 
            btnBooking.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBooking.Location = new Point(12, 213);
            btnBooking.Name = "btnBooking";
            btnBooking.Size = new Size(164, 76);
            btnBooking.TabIndex = 2;
            btnBooking.Text = "Booking";
            btnBooking.UseVisualStyleBackColor = true;
            // 
            // btnPayment
            // 
            btnPayment.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(12, 314);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(164, 76);
            btnPayment.TabIndex = 3;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            // 
            // grbRAvailable
            // 
            grbRAvailable.BackColor = SystemColors.ActiveBorder;
            grbRAvailable.Controls.Add(label3);
            grbRAvailable.Controls.Add(label1);
            grbRAvailable.Cursor = Cursors.SizeNS;
            grbRAvailable.Location = new Point(246, 157);
            grbRAvailable.Name = "grbRAvailable";
            grbRAvailable.Size = new Size(250, 125);
            grbRAvailable.TabIndex = 2;
            grbRAvailable.TabStop = false;
            grbRAvailable.Text = "Rooms Available";
            // 
            // grbRoomsoccupied
            // 
            grbRoomsoccupied.BackColor = SystemColors.ActiveBorder;
            grbRoomsoccupied.Controls.Add(lblRoomsoccupied);
            grbRoomsoccupied.Cursor = Cursors.SizeNS;
            grbRoomsoccupied.Location = new Point(246, 329);
            grbRoomsoccupied.Name = "grbRoomsoccupied";
            grbRoomsoccupied.Size = new Size(250, 125);
            grbRoomsoccupied.TabIndex = 3;
            grbRoomsoccupied.TabStop = false;
            grbRoomsoccupied.Text = "Rooms Occupied";
            grbRoomsoccupied.Enter += groupBox1_Enter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n__1_1;
            pictureBox1.Location = new Point(642, 121);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(530, 384);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(100, 46);
            label1.Name = "label1";
            label1.Size = new Size(55, 39);
            label1.TabIndex = 0;
            label1.Text = "00";
            label1.Click += label1_Click;
            // 
            // lblRoomsoccupied
            // 
            lblRoomsoccupied.AutoSize = true;
            lblRoomsoccupied.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoomsoccupied.Location = new Point(100, 49);
            lblRoomsoccupied.Name = "lblRoomsoccupied";
            lblRoomsoccupied.Size = new Size(55, 39);
            lblRoomsoccupied.TabIndex = 1;
            lblRoomsoccupied.Text = "00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(98, 43);
            label3.Name = "label3";
            label3.Size = new Size(55, 39);
            label3.TabIndex = 1;
            label3.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 13);
            label4.Name = "label4";
            label4.Size = new Size(161, 35);
            label4.TabIndex = 2;
            label4.Text = "Dashboard";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1178, 10);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(98, 38);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 596);
            Controls.Add(pictureBox1);
            Controls.Add(grbRoomsoccupied);
            Controls.Add(grbRAvailable);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            grbRAvailable.ResumeLayout(false);
            grbRAvailable.PerformLayout();
            grbRoomsoccupied.ResumeLayout(false);
            grbRoomsoccupied.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label1;
        private PictureBox pictureBox1;
        private Label lblRoomsoccupied;
        private Label label4;
        private Label label3;
        private Button btnLogout;
    }
}