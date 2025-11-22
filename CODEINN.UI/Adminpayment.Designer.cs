namespace CODEINN.UI
{
    partial class Adminpayment
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
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnBack1 = new Button();
            btnview = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            btnAdd = new Button();
            dtgInfo = new DataGridView();
            checkoutdate = new DateTimePicker();
            label9 = new Label();
            txt_status = new TextBox();
            label2 = new Label();
            txtInitialadmin = new TextBox();
            txtFirstnameadmin = new TextBox();
            txt_roomtype = new TextBox();
            txtLastnameadmin = new TextBox();
            txtGuestIdadmin = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            btnSearch1 = new Button();
            txtSearchadmin = new TextBox();
            label1 = new Label();
            label8 = new Label();
            button1 = new Button();
            label10 = new Label();
            txt_num = new TextBox();
            label11 = new Label();
            txt_price = new TextBox();
            button2 = new Button();
            panel2 = new Panel();
            checkindate = new DateTimePicker();
            label12 = new Label();
            label13 = new Label();
            txt_change = new TextBox();
            lbl = new Label();
            txt_amount = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBack1);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1926, 140);
            panel1.TabIndex = 68;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(165, 48);
            label4.Name = "label4";
            label4.Size = new Size(174, 44);
            label4.TabIndex = 2;
            label4.Text = "Payment";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n_removebg_preview2;
            pictureBox1.Location = new Point(-122, -21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // btnBack1
            // 
            btnBack1.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack1.Location = new Point(1701, 48);
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
            btnview.Location = new Point(955, 262);
            btnview.Name = "btnview";
            btnview.Size = new Size(94, 37);
            btnview.TabIndex = 121;
            btnview.Text = "View";
            btnview.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(843, 262);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 37);
            btnEdit.TabIndex = 120;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(724, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 37);
            btnSave.TabIndex = 119;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(603, 262);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 37);
            btnAdd.TabIndex = 118;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dtgInfo
            // 
            dtgInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfo.Location = new Point(607, 356);
            dtgInfo.Name = "dtgInfo";
            dtgInfo.RowHeadersWidth = 51;
            dtgInfo.Size = new Size(1291, 621);
            dtgInfo.TabIndex = 117;
            dtgInfo.CellContentClick += dtgInfo_CellContentClick;
            // 
            // checkoutdate
            // 
            checkoutdate.Font = new Font("Arial", 12F);
            checkoutdate.Location = new Point(200, 478);
            checkoutdate.Name = "checkoutdate";
            checkoutdate.Size = new Size(319, 30);
            checkoutdate.TabIndex = 116;
            // 
            // label9
            // 
            label9.AllowDrop = true;
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F);
            label9.Location = new Point(25, 483);
            label9.Name = "label9";
            label9.Size = new Size(153, 23);
            label9.TabIndex = 115;
            label9.Text = "Check-out Date:";
            // 
            // txt_status
            // 
            txt_status.Font = new Font("Arial", 12F);
            txt_status.Location = new Point(201, 334);
            txt_status.Name = "txt_status";
            txt_status.Size = new Size(319, 30);
            txt_status.TabIndex = 114;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(1105, 383);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 113;
            // 
            // txtInitialadmin
            // 
            txtInitialadmin.Font = new Font("Arial", 12F);
            txtInitialadmin.Location = new Point(201, 245);
            txtInitialadmin.Name = "txtInitialadmin";
            txtInitialadmin.Size = new Size(70, 30);
            txtInitialadmin.TabIndex = 111;
            txtInitialadmin.TextChanged += txtInitialadmin_TextChanged;
            // 
            // txtFirstnameadmin
            // 
            txtFirstnameadmin.Font = new Font("Arial", 12F);
            txtFirstnameadmin.Location = new Point(199, 195);
            txtFirstnameadmin.Name = "txtFirstnameadmin";
            txtFirstnameadmin.Size = new Size(319, 30);
            txtFirstnameadmin.TabIndex = 110;
            // 
            // txt_roomtype
            // 
            txt_roomtype.Font = new Font("Arial", 12F);
            txt_roomtype.Location = new Point(201, 288);
            txt_roomtype.Name = "txt_roomtype";
            txt_roomtype.Size = new Size(319, 30);
            txt_roomtype.TabIndex = 109;
            // 
            // txtLastnameadmin
            // 
            txtLastnameadmin.Font = new Font("Arial", 12F);
            txtLastnameadmin.Location = new Point(199, 139);
            txtLastnameadmin.Name = "txtLastnameadmin";
            txtLastnameadmin.Size = new Size(319, 30);
            txtLastnameadmin.TabIndex = 108;
            // 
            // txtGuestIdadmin
            // 
            txtGuestIdadmin.Font = new Font("Arial", 12F);
            txtGuestIdadmin.Location = new Point(199, 88);
            txtGuestIdadmin.Name = "txtGuestIdadmin";
            txtGuestIdadmin.Size = new Size(319, 30);
            txtGuestIdadmin.TabIndex = 107;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F);
            label7.Location = new Point(23, 291);
            label7.Name = "label7";
            label7.Size = new Size(117, 23);
            label7.TabIndex = 105;
            label7.Text = "Room Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(17, 244);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 104;
            label6.Text = "Middle Initial:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(17, 195);
            label5.Name = "label5";
            label5.Size = new Size(112, 23);
            label5.TabIndex = 103;
            label5.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(17, 146);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 102;
            label3.Text = "Last Name:";
            // 
            // btnSearch1
            // 
            btnSearch1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch1.Location = new Point(1370, 185);
            btnSearch1.Name = "btnSearch1";
            btnSearch1.Size = new Size(98, 39);
            btnSearch1.TabIndex = 100;
            btnSearch1.Text = "Search";
            btnSearch1.UseVisualStyleBackColor = true;
            btnSearch1.Click += btnSearch1_Click;
            // 
            // txtSearchadmin
            // 
            txtSearchadmin.BackColor = SystemColors.ControlLightLight;
            txtSearchadmin.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchadmin.ForeColor = Color.DarkGray;
            txtSearchadmin.Location = new Point(599, 186);
            txtSearchadmin.Name = "txtSearchadmin";
            txtSearchadmin.Size = new Size(764, 34);
            txtSearchadmin.TabIndex = 99;
            txtSearchadmin.Text = "Search Guest";
            txtSearchadmin.TextChanged += txtSearchadmin_TextChanged;
            txtSearchadmin.Enter += txtSearchadmin_Enter;
            txtSearchadmin.Leave += txtSearchadmin_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(17, 91);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 101;
            label1.Text = "Payment ID:";
            label1.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F);
            label8.Location = new Point(24, 341);
            label8.Name = "label8";
            label8.Size = new Size(72, 23);
            label8.TabIndex = 122;
            label8.Text = "Status:";
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(1072, 262);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 123;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F);
            label10.Location = new Point(23, 384);
            label10.Name = "label10";
            label10.Size = new Size(181, 23);
            label10.TabIndex = 124;
            label10.Text = "Number of Night(s):";
            // 
            // txt_num
            // 
            txt_num.Font = new Font("Arial", 12F);
            txt_num.Location = new Point(200, 381);
            txt_num.Name = "txt_num";
            txt_num.Size = new Size(319, 30);
            txt_num.TabIndex = 125;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F);
            label11.Location = new Point(24, 528);
            label11.Name = "label11";
            label11.Size = new Size(61, 23);
            label11.TabIndex = 126;
            label11.Text = "Price:";
            // 
            // txt_price
            // 
            txt_price.Font = new Font("Arial", 12F);
            txt_price.Location = new Point(200, 525);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(319, 30);
            txt_price.TabIndex = 127;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(1175, 262);
            button2.Name = "button2";
            button2.Size = new Size(94, 37);
            button2.TabIndex = 128;
            button2.Text = "Print";
            button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(checkindate);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(txt_change);
            panel2.Controls.Add(lbl);
            panel2.Controls.Add(txt_amount);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txt_price);
            panel2.Controls.Add(txtGuestIdadmin);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_num);
            panel2.Controls.Add(txtLastnameadmin);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtFirstnameadmin);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(checkoutdate);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtInitialadmin);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txt_roomtype);
            panel2.Controls.Add(txt_status);
            panel2.Location = new Point(0, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 989);
            panel2.TabIndex = 129;
            panel2.Paint += panel2_Paint;
            // 
            // checkindate
            // 
            checkindate.Font = new Font("Arial", 12F);
            checkindate.Location = new Point(199, 432);
            checkindate.Name = "checkindate";
            checkindate.Size = new Size(319, 30);
            checkindate.TabIndex = 133;
            // 
            // label12
            // 
            label12.AllowDrop = true;
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F);
            label12.Location = new Point(24, 437);
            label12.Name = "label12";
            label12.Size = new Size(142, 23);
            label12.TabIndex = 132;
            label12.Text = "Check-In Date:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F);
            label13.Location = new Point(24, 629);
            label13.Name = "label13";
            label13.Size = new Size(83, 23);
            label13.TabIndex = 131;
            label13.Text = "Change:";
            // 
            // txt_change
            // 
            txt_change.Font = new Font("Arial", 12F);
            txt_change.Location = new Point(200, 622);
            txt_change.Name = "txt_change";
            txt_change.Size = new Size(319, 30);
            txt_change.TabIndex = 130;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Arial", 12F);
            lbl.Location = new Point(25, 580);
            lbl.Name = "lbl";
            lbl.Size = new Size(169, 23);
            lbl.TabIndex = 129;
            lbl.Text = "Amount Received:";
            // 
            // txt_amount
            // 
            txt_amount.Font = new Font("Arial", 12F);
            txt_amount.Location = new Point(200, 573);
            txt_amount.Name = "txt_amount";
            txt_amount.Size = new Size(319, 30);
            txt_amount.TabIndex = 128;
            txt_amount.TextChanged += textBox4_TextChanged;
            // 
            // Adminpayment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 987);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnview);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(dtgInfo);
            Controls.Add(label2);
            Controls.Add(btnSearch1);
            Controls.Add(txtSearchadmin);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Adminpayment";
            Text = "Payment";
            Load += Adminpayment_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnBack1;
        private Label label4;
        private Button btnview;
        private Button btnEdit;
        private Button btnSave;
        private Button btnAdd;
        private DataGridView dtgInfo;
        private DateTimePicker checkoutdate;
        private Label label9;
        private TextBox txt_status;
        private Label label2;
        private TextBox txtInitialadmin;
        private TextBox txtFirstnameadmin;
        private TextBox txt_roomtype;
        private TextBox txtLastnameadmin;
        private TextBox txtGuestIdadmin;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private Button btnSearch1;
        private TextBox txtSearchadmin;
        private Label label1;
        private Label label8;
        private Button button1;
        private Label label10;
        private TextBox txt_num;
        private Label label11;
        private TextBox txt_price;
        private Button button2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lbl;
        private TextBox txt_amount;
        private Label label13;
        private TextBox txt_change;
        private DateTimePicker checkindate;
        private Label label12;
    }
}