namespace CODEINN.UI
{
    partial class FrontdeskReservation
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
            btnview = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            dtgInfo = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label9 = new Label();
            txt_payment = new TextBox();
            label2 = new Label();
            dtpBirtdateadmin = new DateTimePicker();
            txtInitialadmin = new TextBox();
            txtFirstnameadmin = new TextBox();
            txtLastnameadmin = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            btnSearch1 = new Button();
            txtSearchadmin = new TextBox();
            btnBack1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            txt_num = new TextBox();
            panel2 = new Panel();
            label17 = new Label();
            lbl_balance = new Label();
            label15 = new Label();
            lbl_guestid = new Label();
            textBox1 = new TextBox();
            label14 = new Label();
            label11 = new Label();
            cm_roomtype = new ComboBox();
            cb_roomnumber = new ComboBox();
            dataGridView1 = new DataGridView();
            label12 = new Label();
            label13 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnview
            // 
            btnview.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnview.Location = new Point(913, 378);
            btnview.Name = "btnview";
            btnview.Size = new Size(94, 29);
            btnview.TabIndex = 98;
            btnview.Text = "View";
            btnview.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(829, 259);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 97;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(710, 259);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 96;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(593, 259);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 95;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtgInfo
            // 
            dtgInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfo.Location = new Point(589, 351);
            dtgInfo.Name = "dtgInfo";
            dtgInfo.RowHeadersWidth = 51;
            dtgInfo.Size = new Size(1323, 242);
            dtgInfo.TabIndex = 94;
            dtgInfo.CellContentClick += dtgInfo_CellContentClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Arial", 12F);
            dateTimePicker1.Location = new Point(197, 450);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(319, 30);
            dateTimePicker1.TabIndex = 93;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F);
            label9.Location = new Point(23, 450);
            label9.Name = "label9";
            label9.Size = new Size(153, 23);
            label9.TabIndex = 92;
            label9.Text = "Check-out Date:";
            // 
            // txt_payment
            // 
            txt_payment.Font = new Font("Arial", 12F);
            txt_payment.Location = new Point(198, 565);
            txt_payment.Name = "txt_payment";
            txt_payment.Size = new Size(319, 30);
            txt_payment.TabIndex = 91;
            txt_payment.TextChanged += txt_payment_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(26, 569);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 90;
            label2.Text = "Payment:";
            // 
            // dtpBirtdateadmin
            // 
            dtpBirtdateadmin.Font = new Font("Arial", 12F);
            dtpBirtdateadmin.Location = new Point(197, 390);
            dtpBirtdateadmin.Name = "dtpBirtdateadmin";
            dtpBirtdateadmin.Size = new Size(319, 30);
            dtpBirtdateadmin.TabIndex = 89;
            // 
            // txtInitialadmin
            // 
            txtInitialadmin.Font = new Font("Arial", 12F);
            txtInitialadmin.Location = new Point(192, 232);
            txtInitialadmin.Name = "txtInitialadmin";
            txtInitialadmin.Size = new Size(88, 30);
            txtInitialadmin.TabIndex = 88;
            // 
            // txtFirstnameadmin
            // 
            txtFirstnameadmin.Font = new Font("Arial", 12F);
            txtFirstnameadmin.Location = new Point(193, 176);
            txtFirstnameadmin.Name = "txtFirstnameadmin";
            txtFirstnameadmin.Size = new Size(319, 30);
            txtFirstnameadmin.TabIndex = 87;
            // 
            // txtLastnameadmin
            // 
            txtLastnameadmin.Font = new Font("Arial", 12F);
            txtLastnameadmin.Location = new Point(193, 118);
            txtLastnameadmin.Name = "txtLastnameadmin";
            txtLastnameadmin.Size = new Size(319, 30);
            txtLastnameadmin.TabIndex = 85;
            // 
            // label8
            // 
            label8.AllowDrop = true;
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(23, 397);
            label8.Name = "label8";
            label8.Size = new Size(140, 23);
            label8.TabIndex = 83;
            label8.Text = "Check-in Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(20, 289);
            label7.Name = "label7";
            label7.Size = new Size(117, 23);
            label7.TabIndex = 82;
            label7.Text = "Room Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(20, 239);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 81;
            label6.Text = "Middle Initial:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(20, 183);
            label5.Name = "label5";
            label5.Size = new Size(112, 23);
            label5.TabIndex = 80;
            label5.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(21, 121);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 79;
            label3.Text = "Last Name:";
            label3.Click += label3_Click;
            // 
            // btnSearch1
            // 
            btnSearch1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch1.Location = new Point(1355, 177);
            btnSearch1.Name = "btnSearch1";
            btnSearch1.Size = new Size(98, 39);
            btnSearch1.TabIndex = 77;
            btnSearch1.Text = "Search";
            btnSearch1.UseVisualStyleBackColor = true;
            // 
            // txtSearchadmin
            // 
            txtSearchadmin.BackColor = SystemColors.ControlLightLight;
            txtSearchadmin.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchadmin.ForeColor = Color.Gray;
            txtSearchadmin.Location = new Point(589, 180);
            txtSearchadmin.Name = "txtSearchadmin";
            txtSearchadmin.Size = new Size(764, 34);
            txtSearchadmin.TabIndex = 76;
            txtSearchadmin.Text = "Search Guest";
            txtSearchadmin.TextChanged += txtSearchadmin_TextChanged;
            txtSearchadmin.Enter += txtSearch_Enter;
            txtSearchadmin.Leave += txtSearch_Leave;
            // 
            // btnBack1
            // 
            btnBack1.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack1.Location = new Point(1705, 45);
            btnBack1.Name = "btnBack1";
            btnBack1.Size = new Size(162, 56);
            btnBack1.TabIndex = 28;
            btnBack1.Text = "Back";
            btnBack1.UseVisualStyleBackColor = true;
            btnBack1.Click += btnBack1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(21, 67);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 78;
            label1.Text = "Guest ID:";
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
            panel1.TabIndex = 75;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(175, 45);
            label4.Name = "label4";
            label4.Size = new Size(534, 44);
            label4.TabIndex = 2;
            label4.Text = "Guest Reservation / Payment";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n_removebg_preview2;
            pictureBox1.Location = new Point(-107, -24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F);
            label10.Location = new Point(23, 512);
            label10.Name = "label10";
            label10.Size = new Size(181, 23);
            label10.TabIndex = 99;
            label10.Text = "Number of Night(s):";
            // 
            // txt_num
            // 
            txt_num.Font = new Font("Arial", 12F);
            txt_num.Location = new Point(198, 512);
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(319, 30);
            txt_num.TabIndex = 100;
            txt_num.TextChanged += txt_num_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label17);
            panel2.Controls.Add(lbl_balance);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(lbl_guestid);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(cm_roomtype);
            panel2.Controls.Add(cb_roomnumber);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_num);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtLastnameadmin);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtFirstnameadmin);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtInitialadmin);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(dtpBirtdateadmin);
            panel2.Controls.Add(txt_payment);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-1, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 989);
            panel2.TabIndex = 101;
            panel2.Paint += panel2_Paint;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 12F);
            label17.Location = new Point(361, 640);
            label17.Name = "label17";
            label17.Size = new Size(49, 23);
            label17.TabIndex = 109;
            label17.Text = "PHP";
            // 
            // lbl_balance
            // 
            lbl_balance.AutoSize = true;
            lbl_balance.Font = new Font("Arial", 12F);
            lbl_balance.Location = new Point(430, 640);
            lbl_balance.Name = "lbl_balance";
            lbl_balance.Size = new Size(17, 23);
            lbl_balance.TabIndex = 108;
            lbl_balance.Text = "-";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F);
            label15.Location = new Point(26, 622);
            label15.Name = "label15";
            label15.Size = new Size(86, 23);
            label15.TabIndex = 107;
            label15.Text = "Balance:";
            // 
            // lbl_guestid
            // 
            lbl_guestid.AutoSize = true;
            lbl_guestid.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_guestid.Location = new Point(193, 67);
            lbl_guestid.Name = "lbl_guestid";
            lbl_guestid.Size = new Size(17, 23);
            lbl_guestid.TabIndex = 106;
            lbl_guestid.Text = "-";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 12F);
            textBox1.Location = new Point(419, 228);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(88, 30);
            textBox1.TabIndex = 105;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F);
            label14.Location = new Point(346, 232);
            label14.Name = "label14";
            label14.Size = new Size(64, 23);
            label14.TabIndex = 104;
            label14.Text = "Suffix:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F);
            label11.Location = new Point(21, 337);
            label11.Name = "label11";
            label11.Size = new Size(142, 23);
            label11.TabIndex = 103;
            label11.Text = "Room Number:";
            // 
            // cm_roomtype
            // 
            cm_roomtype.FormattingEnabled = true;
            cm_roomtype.Location = new Point(192, 284);
            cm_roomtype.Name = "cm_roomtype";
            cm_roomtype.Size = new Size(318, 28);
            cm_roomtype.TabIndex = 102;
            cm_roomtype.SelectedIndexChanged += cm_roomtype_SelectedIndexChanged;
            // 
            // cb_roomnumber
            // 
            cb_roomnumber.FormattingEnabled = true;
            cb_roomnumber.Location = new Point(195, 337);
            cb_roomnumber.Name = "cb_roomnumber";
            cb_roomnumber.Size = new Size(318, 28);
            cb_roomnumber.TabIndex = 101;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(593, 704);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1319, 254);
            dataGridView1.TabIndex = 102;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label12
            // 
            label12.AllowDrop = true;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F);
            label12.Location = new Point(589, 322);
            label12.Name = "label12";
            label12.Size = new Size(167, 23);
            label12.TabIndex = 104;
            label12.Text = "Guest Information";
            // 
            // label13
            // 
            label13.AllowDrop = true;
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F);
            label13.Location = new Point(593, 666);
            label13.Name = "label13";
            label13.Size = new Size(218, 23);
            label13.TabIndex = 105;
            label13.Text = "Reservation Information";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(948, 259);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 106;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrontdeskReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 987);
            Controls.Add(button1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(dtgInfo);
            Controls.Add(btnSearch1);
            Controls.Add(txtSearchadmin);
            Controls.Add(panel1);
            Controls.Add(btnview);
            Name = "FrontdeskReservation";
            Text = "FrontdeskReservation";
            WindowState = FormWindowState.Maximized;
            Load += FrontdeskReservation_Load;
            ((System.ComponentModel.ISupportInitialize)dtgInfo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnview;
        private Button btnEdit;
        private Button btnSave;
        private Button btnAdd;
        private DataGridView dtgInfo;
        private DateTimePicker dateTimePicker1;
        private Label label9;
        private TextBox txt_payment;
        private Label label2;
        private DateTimePicker dtpBirtdateadmin;
        private TextBox txtInitialadmin;
        private TextBox txtFirstnameadmin;
        private TextBox txtLastnameadmin;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Button btnSearch1;
        private TextBox txtSearchadmin;
        private Button btnBack1;
        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label label10;
        private TextBox txt_num;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label11;
        private ComboBox cm_roomtype;
        private ComboBox cb_roomnumber;
        private DataGridView dataGridView1;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox1;
        private Label lbl_guestid;
        private Label label15;
        private Button button1;
        private Label label17;
        private Label lbl_balance;
    }
}