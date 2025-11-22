namespace CODEINN.UI
{
    partial class AdminReservation
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
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnBack1 = new Button();
            txtSearchadmin = new TextBox();
            dtpBirtdateadmin = new DateTimePicker();
            txtFirstnameadmin = new TextBox();
            txtLastnameadmin = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label1 = new Label();
            label6 = new Label();
            txtInitialadmin = new TextBox();
            label2 = new Label();
            txt_time = new TextBox();
            label9 = new Label();
            dateTimePicker1 = new DateTimePicker();
            btnview = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            dtgInfo = new DataGridView();
            button1 = new Button();
            label10 = new Label();
            txt_numnights = new TextBox();
            label12 = new Label();
            combo_room = new ComboBox();
            combo_roomtype = new ComboBox();
            lbl_guestid = new Label();
            panel2 = new Panel();
            dtg_guestinfo = new DataGridView();
            label11 = new Label();
            label13 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_guestinfo).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(153, 52);
            label4.Name = "label4";
            label4.Size = new Size(349, 44);
            label4.TabIndex = 2;
            label4.Text = "Guest Reservation";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBack1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1926, 140);
            panel1.TabIndex = 29;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n_removebg_preview2;
            pictureBox1.Location = new Point(-120, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // btnBack1
            // 
            btnBack1.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack1.Location = new Point(1728, 49);
            btnBack1.Name = "btnBack1";
            btnBack1.Size = new Size(162, 56);
            btnBack1.TabIndex = 28;
            btnBack1.Text = "Back";
            btnBack1.UseVisualStyleBackColor = true;
            btnBack1.Click += btnBack1_Click;
            // 
            // txtSearchadmin
            // 
            txtSearchadmin.BackColor = SystemColors.ControlLightLight;
            txtSearchadmin.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchadmin.ForeColor = Color.Gray;
            txtSearchadmin.Location = new Point(595, 190);
            txtSearchadmin.Name = "txtSearchadmin";
            txtSearchadmin.Size = new Size(601, 34);
            txtSearchadmin.TabIndex = 44;
            txtSearchadmin.Text = "Search Guest";
            txtSearchadmin.TextChanged += txtSearchadmin_TextChanged;
            txtSearchadmin.Enter += txtSearchadmin_Enter;
            txtSearchadmin.Leave += txtSearchadmin_Leave;
            // 
            // dtpBirtdateadmin
            // 
            dtpBirtdateadmin.Font = new Font("Arial", 12F);
            dtpBirtdateadmin.Location = new Point(192, 448);
            dtpBirtdateadmin.Name = "dtpBirtdateadmin";
            dtpBirtdateadmin.Size = new Size(319, 30);
            dtpBirtdateadmin.TabIndex = 65;
            // 
            // txtFirstnameadmin
            // 
            txtFirstnameadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstnameadmin.Location = new Point(191, 180);
            txtFirstnameadmin.Name = "txtFirstnameadmin";
            txtFirstnameadmin.Size = new Size(319, 30);
            txtFirstnameadmin.TabIndex = 62;
            // 
            // txtLastnameadmin
            // 
            txtLastnameadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastnameadmin.Location = new Point(192, 116);
            txtLastnameadmin.Name = "txtLastnameadmin";
            txtLastnameadmin.Size = new Size(319, 30);
            txtLastnameadmin.TabIndex = 59;
            // 
            // label8
            // 
            label8.AllowDrop = true;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(13, 454);
            label8.Name = "label8";
            label8.Size = new Size(140, 23);
            label8.TabIndex = 54;
            label8.Text = "Check-in Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(13, 294);
            label7.Name = "label7";
            label7.Size = new Size(117, 23);
            label7.TabIndex = 53;
            label7.Text = "Room Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(13, 187);
            label5.Name = "label5";
            label5.Size = new Size(112, 23);
            label5.TabIndex = 51;
            label5.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(14, 123);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 50;
            label3.Text = "Last Name:";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(13, 71);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 49;
            label1.Text = "Guest ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(13, 244);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 52;
            label6.Text = "Middle Initial:";
            // 
            // txtInitialadmin
            // 
            txtInitialadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInitialadmin.Location = new Point(192, 239);
            txtInitialadmin.Name = "txtInitialadmin";
            txtInitialadmin.Size = new Size(70, 30);
            txtInitialadmin.TabIndex = 64;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(13, 395);
            label2.Name = "label2";
            label2.Size = new Size(58, 23);
            label2.TabIndex = 66;
            label2.Text = "Time:";
            // 
            // txt_time
            // 
            txt_time.Font = new Font("Arial", 12F);
            txt_time.Location = new Point(192, 392);
            txt_time.Name = "txt_time";
            txt_time.Size = new Size(319, 30);
            txt_time.TabIndex = 67;
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F);
            label9.Location = new Point(13, 505);
            label9.Name = "label9";
            label9.Size = new Size(153, 23);
            label9.TabIndex = 68;
            label9.Text = "Check-out Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial", 12F);
            dateTimePicker1.Location = new Point(192, 499);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 30);
            dateTimePicker1.TabIndex = 69;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnview
            // 
            btnview.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnview.Location = new Point(939, 258);
            btnview.Name = "btnview";
            btnview.Size = new Size(94, 37);
            btnview.TabIndex = 74;
            btnview.Text = "View";
            btnview.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(835, 258);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 37);
            btnEdit.TabIndex = 73;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(716, 258);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 37);
            btnSave.TabIndex = 72;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(595, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 37);
            btnAdd.TabIndex = 71;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtgInfo
            // 
            dtgInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfo.Location = new Point(575, 713);
            dtgInfo.Name = "dtgInfo";
            dtgInfo.RowHeadersWidth = 51;
            dtgInfo.Size = new Size(1291, 277);
            dtgInfo.TabIndex = 70;
            dtgInfo.CellContentClick += dtgInfo_CellContentClick;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1047, 258);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 75;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F);
            label10.Location = new Point(13, 554);
            label10.Name = "label10";
            label10.Size = new Size(182, 23);
            label10.TabIndex = 76;
            label10.Text = "Number Of Stay(s):";
            // 
            // txt_numnights
            // 
            txt_numnights.Font = new Font("Arial", 12F);
            txt_numnights.Location = new Point(192, 554);
            txt_numnights.Name = "txt_numnights";
            txt_numnights.Size = new Size(319, 30);
            txt_numnights.TabIndex = 77;
            txt_numnights.TextChanged += txt_numnights_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F);
            label12.Location = new Point(13, 343);
            label12.Name = "label12";
            label12.Size = new Size(85, 23);
            label12.TabIndex = 79;
            label12.Text = "Room #:";
            // 
            // combo_room
            // 
            combo_room.Font = new Font("Arial Narrow", 12F);
            combo_room.FormattingEnabled = true;
            combo_room.Location = new Point(192, 336);
            combo_room.Name = "combo_room";
            combo_room.Size = new Size(319, 32);
            combo_room.TabIndex = 80;
            // 
            // combo_roomtype
            // 
            combo_roomtype.Font = new Font("Arial Narrow", 12F);
            combo_roomtype.FormattingEnabled = true;
            combo_roomtype.Location = new Point(192, 287);
            combo_roomtype.Name = "combo_roomtype";
            combo_roomtype.Size = new Size(319, 32);
            combo_roomtype.TabIndex = 82;
            combo_roomtype.SelectedIndexChanged += combo_roomtype_SelectedIndexChanged;
            // 
            // lbl_guestid
            // 
            lbl_guestid.AutoSize = true;
            lbl_guestid.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_guestid.Location = new Point(191, 71);
            lbl_guestid.Name = "lbl_guestid";
            lbl_guestid.Size = new Size(103, 23);
            lbl_guestid.TabIndex = 83;
            lbl_guestid.Text = "lbl_guestid";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_numnights);
            panel2.Controls.Add(combo_room);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(combo_roomtype);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(lbl_guestid);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtLastnameadmin);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtFirstnameadmin);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtInitialadmin);
            panel2.Controls.Add(dtpBirtdateadmin);
            panel2.Controls.Add(txt_time);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-1, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 989);
            panel2.TabIndex = 84;
            panel2.Paint += panel2_Paint;
            // 
            // dtg_guestinfo
            // 
            dtg_guestinfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_guestinfo.Location = new Point(575, 351);
            dtg_guestinfo.Name = "dtg_guestinfo";
            dtg_guestinfo.RowHeadersWidth = 51;
            dtg_guestinfo.Size = new Size(1291, 277);
            dtg_guestinfo.TabIndex = 85;
            dtg_guestinfo.CellContentClick += dtg_guestinfo_CellContentClick;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F);
            label11.Location = new Point(575, 314);
            label11.Name = "label11";
            label11.Size = new Size(167, 23);
            label11.TabIndex = 84;
            label11.Text = "Guest Information";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F);
            label13.Location = new Point(575, 675);
            label13.Name = "label13";
            label13.Size = new Size(218, 23);
            label13.TabIndex = 86;
            label13.Text = "Reservation Information";
            // 
            // AdminReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1924, 987);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(dtg_guestinfo);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(btnview);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(dtgInfo);
            Controls.Add(txtSearchadmin);
            Controls.Add(panel1);
            Name = "AdminReservation";
            Text = "AdminReservation";
            Load += AdminReservation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_guestinfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Panel panel1;
        private Button btnBack1;
        private TextBox txtSearchadmin;
        private DateTimePicker dtpBirtdateadmin;
        private TextBox txtFirstnameadmin;
        private TextBox txtLastnameadmin;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label3;
        private Label label1;
        private Label label6;
        private TextBox txtInitialadmin;
        private Label label2;
        private TextBox txt_time;
        private Label label9;
        private DateTimePicker dateTimePicker1;
        private Button btnview;
        private Button btnEdit;
        private Button btnSave;
        private Button btnAdd;
        private DataGridView dtgInfo;
        private Button button1;
        private Label label10;
        private TextBox txt_numnights;
        private Label label12;
        private ComboBox combo_room;
        private ComboBox combo_roomtype;
        private Label lbl_guestid;
        private Panel panel2;
        private PictureBox pictureBox1;
        private DataGridView dtg_guestinfo;
        private Label label11;
        private Label label13;
    }
}