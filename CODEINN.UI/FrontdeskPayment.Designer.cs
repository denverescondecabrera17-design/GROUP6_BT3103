namespace CODEINN.UI
{
    partial class FrontdeskPayment
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
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtSearchadmin = new TextBox();
            panel2 = new Panel();
            label11 = new Label();
            txt_amount = new TextBox();
            txt_roomnumber = new TextBox();
            label15 = new Label();
            lbl_guestid = new Label();
            checkindate = new DateTimePicker();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            txt_change = new TextBox();
            txt_balance = new TextBox();
            label3 = new Label();
            txt_num = new TextBox();
            txtLastnameadmin = new TextBox();
            label10 = new Label();
            label5 = new Label();
            txtFirstnameadmin = new TextBox();
            label8 = new Label();
            checkoutdate = new DateTimePicker();
            label6 = new Label();
            label9 = new Label();
            txtInitialadmin = new TextBox();
            label7 = new Label();
            txt_roomtype = new TextBox();
            txt_status = new TextBox();
            btnAdd = new Button();
            label4 = new Label();
            btnBack1 = new Button();
            btnview = new Button();
            dtgInfo = new DataGridView();
            btnEdit = new Button();
            btnSave = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n_removebg_preview2;
            pictureBox1.Location = new Point(-122, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(183, 121);
            button2.Name = "button2";
            button2.Size = new Size(183, 37);
            button2.TabIndex = 140;
            button2.Text = "Generate Receipt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(633, 371);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 101;
            label1.Text = "Payment ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1105, 381);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 133;
            // 
            // txtSearchadmin
            // 
            txtSearchadmin.BackColor = SystemColors.ControlLightLight;
            txtSearchadmin.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchadmin.ForeColor = Color.Gray;
            txtSearchadmin.Location = new Point(29, 53);
            txtSearchadmin.Name = "txtSearchadmin";
            txtSearchadmin.Size = new Size(764, 34);
            txtSearchadmin.TabIndex = 131;
            txtSearchadmin.Text = "Search Guest";
            txtSearchadmin.TextChanged += txtSearchadmin_TextChanged;
            txtSearchadmin.Enter += enter;
            txtSearchadmin.Leave += exit;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(txtSearchadmin);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnSave);
            panel2.Location = new Point(0, 139);
            panel2.Name = "panel2";
            panel2.Size = new Size(939, 989);
            panel2.TabIndex = 141;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F);
            label11.Location = new Point(634, 879);
            label11.Name = "label11";
            label11.Size = new Size(169, 23);
            label11.TabIndex = 141;
            label11.Text = "Amount Received:";
            // 
            // txt_amount
            // 
            txt_amount.Font = new Font("Arial", 12F);
            txt_amount.Location = new Point(816, 876);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(319, 30);
            txt_amount.TabIndex = 140;
            txt_amount.TextChanged += txt_amount_TextChanged_1;
            // 
            // txt_roomnumber
            // 
            txt_roomnumber.Font = new Font("Arial", 12F);
            txt_roomnumber.Location = new Point(800, 826);
            txt_roomnumber.Name = "txt_roomnumber";
            txt_roomnumber.Size = new Size(319, 30);
            txt_roomnumber.TabIndex = 139;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F);
            label15.Location = new Point(625, 829);
            label15.Name = "label15";
            label15.Size = new Size(142, 23);
            label15.TabIndex = 138;
            label15.Text = "Room Number:";
            // 
            // lbl_guestid
            // 
            lbl_guestid.AutoSize = true;
            lbl_guestid.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_guestid.Location = new Point(814, 368);
            lbl_guestid.Name = "lbl_guestid";
            lbl_guestid.Size = new Size(17, 23);
            lbl_guestid.TabIndex = 137;
            lbl_guestid.Text = "-";
            // 
            // checkindate
            // 
            checkindate.Font = new Font("Arial", 12F);
            checkindate.Location = new Point(815, 708);
            checkindate.Name = "checkindate";
            checkindate.Size = new Size(319, 30);
            checkindate.TabIndex = 133;
            // 
            // label14
            // 
            label14.AllowDrop = true;
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F);
            label14.Location = new Point(640, 713);
            label14.Name = "label14";
            label14.Size = new Size(142, 23);
            label14.TabIndex = 132;
            label14.Text = "Check-In Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F);
            label13.Location = new Point(635, 866);
            label13.Name = "label13";
            label13.Size = new Size(83, 23);
            label13.TabIndex = 131;
            label13.Text = "Change:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F);
            label12.Location = new Point(635, 826);
            label12.Name = "label12";
            label12.Size = new Size(86, 23);
            label12.TabIndex = 130;
            label12.Text = "Balance:";
            // 
            // txt_change
            // 
            txt_change.Font = new Font("Arial", 12F);
            txt_change.Location = new Point(817, 859);
            txt_change.Name = "txt_change";
            txt_change.Size = new Size(319, 30);
            txt_change.TabIndex = 129;
            // 
            // txt_balance
            // 
            txt_balance.Font = new Font("Arial", 12F);
            txt_balance.Location = new Point(817, 823);
            txt_balance.Name = "txt_balance";
            txt_balance.Size = new Size(319, 30);
            txt_balance.TabIndex = 128;
            txt_balance.TextChanged += txt_amount_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(633, 426);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 102;
            label3.Text = "Last Name:";
            // 
            // txt_num
            // 
            txt_num.Font = new Font("Arial", 12F);
            txt_num.Location = new Point(816, 661);
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(319, 30);
            txt_num.TabIndex = 125;
            // 
            // txtLastnameadmin
            // 
            txtLastnameadmin.Font = new Font("Arial", 12F);
            txtLastnameadmin.Location = new Point(815, 419);
            txtLastnameadmin.Name = "txtLastnameadmin";
            txtLastnameadmin.Size = new Size(319, 30);
            txtLastnameadmin.TabIndex = 108;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F);
            label10.Location = new Point(639, 664);
            label10.Name = "label10";
            label10.Size = new Size(181, 23);
            label10.TabIndex = 124;
            label10.Text = "Number of Night(s):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(633, 475);
            label5.Name = "label5";
            label5.Size = new Size(112, 23);
            label5.TabIndex = 103;
            label5.Text = "First Name:";
            // 
            // txtFirstnameadmin
            // 
            txtFirstnameadmin.Font = new Font("Arial", 12F);
            txtFirstnameadmin.Location = new Point(815, 475);
            txtFirstnameadmin.Name = "txtFirstnameadmin";
            txtFirstnameadmin.Size = new Size(319, 30);
            txtFirstnameadmin.TabIndex = 110;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(640, 621);
            label8.Name = "label8";
            label8.Size = new Size(72, 23);
            label8.TabIndex = 122;
            label8.Text = "Status:";
            // 
            // checkoutdate
            // 
            checkoutdate.Font = new Font("Arial", 12F);
            checkoutdate.Location = new Point(817, 764);
            checkoutdate.Name = "checkoutdate";
            checkoutdate.Size = new Size(319, 30);
            checkoutdate.TabIndex = 116;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(633, 524);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 104;
            label6.Text = "Middle Initial:";
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F);
            label9.Location = new Point(642, 769);
            label9.Name = "label9";
            label9.Size = new Size(153, 23);
            label9.TabIndex = 115;
            label9.Text = "Check-out Date:";
            // 
            // txtInitialadmin
            // 
            txtInitialadmin.Font = new Font("Arial", 12F);
            txtInitialadmin.Location = new Point(817, 525);
            txtInitialadmin.Name = "txtInitialadmin";
            txtInitialadmin.Size = new Size(70, 30);
            txtInitialadmin.TabIndex = 111;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(639, 571);
            label7.Name = "label7";
            label7.Size = new Size(117, 23);
            label7.TabIndex = 105;
            label7.Text = "Room Type:";
            // 
            // txt_roomtype
            // 
            txt_roomtype.Font = new Font("Arial", 12F);
            txt_roomtype.Location = new Point(817, 568);
            txt_roomtype.Name = "txt_roomtype";
            txt_roomtype.Size = new Size(319, 30);
            txt_roomtype.TabIndex = 109;
            // 
            // txt_status
            // 
            txt_status.Font = new Font("Arial", 12F);
            txt_status.Location = new Point(817, 614);
            txt_status.Name = "txt_status";
            txt_status.Size = new Size(319, 30);
            txt_status.TabIndex = 114;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(691, 420);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 37);
            btnAdd.TabIndex = 135;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(165, 53);
            label4.Name = "label4";
            label4.Size = new Size(146, 44);
            label4.TabIndex = 2;
            label4.Text = "History";
            // 
            // btnBack1
            // 
            btnBack1.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack1.Location = new Point(1705, 41);
            btnBack1.Name = "btnBack1";
            btnBack1.Size = new Size(162, 56);
            btnBack1.TabIndex = 28;
            btnBack1.Text = "Back";
            btnBack1.UseVisualStyleBackColor = true;
            btnBack1.Click += btnBack1_Click;
            // 
            // btnview
            // 
            btnview.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnview.Location = new Point(872, 426);
            btnview.Name = "btnview";
            btnview.Size = new Size(94, 37);
            btnview.TabIndex = 138;
            btnview.Text = "View";
            btnview.UseVisualStyleBackColor = true;
            // 
            // dtgInfo
            // 
            dtgInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfo.Location = new Point(29, 332);
            dtgInfo.Name = "dtgInfo";
            dtgInfo.RowHeadersWidth = 51;
            dtgInfo.Size = new Size(1869, 617);
            dtgInfo.TabIndex = 134;
            dtgInfo.CellContentClick += dtgInfo_CellContentClick;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(872, 377);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 37);
            btnEdit.TabIndex = 137;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(29, 121);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(138, 37);
            btnSave.TabIndex = 136;
            btnSave.Text = "Check-Out";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBack1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1926, 140);
            panel1.TabIndex = 130;
            // 
            // FrontdeskPayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 987);
            Controls.Add(dtgInfo);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label14);
            Controls.Add(btnEdit);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(panel1);
            Controls.Add(txt_change);
            Controls.Add(btnAdd);
            Controls.Add(txt_balance);
            Controls.Add(btnview);
            Controls.Add(label1);
            Controls.Add(txt_status);
            Controls.Add(label3);
            Controls.Add(txt_roomtype);
            Controls.Add(txt_num);
            Controls.Add(label7);
            Controls.Add(txtLastnameadmin);
            Controls.Add(txtInitialadmin);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(txtFirstnameadmin);
            Controls.Add(checkoutdate);
            Controls.Add(label8);
            Controls.Add(lbl_guestid);
            Controls.Add(checkindate);
            Controls.Add(label11);
            Controls.Add(txt_amount);
            Controls.Add(txt_roomnumber);
            Controls.Add(label15);
            Name = "FrontdeskPayment";
            Text = "FrontdeskPayment";
            Load += FrontdeskPayment_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox txtSearchadmin;
        private Panel panel2;
        private Label label3;
        private TextBox txt_num;
        private TextBox txtLastnameadmin;
        private Label label10;
        private Label label5;
        private TextBox txtFirstnameadmin;
        private Label label8;
        private DateTimePicker checkoutdate;
        private Label label6;
        private Label label9;
        private TextBox txtInitialadmin;
        private Label label7;
        private TextBox txt_roomtype;
        private TextBox txt_status;
        private Button btnAdd;
        private Label label4;
        private Button btnBack1;
        private Button btnview;
        private DataGridView dtgInfo;
        private Button btnEdit;
        private Button btnSave;
        private Panel panel1;
        private Label label13;
        private Label label12;
        private TextBox txt_change;
        private TextBox txt_balance;
        private DateTimePicker checkindate;
        private Label label14;
        private Label lbl_guestid;
        private TextBox txt_roomnumber;
        private Label label15;
        private Label label11;
        private TextBox txt_amount;
    }
}