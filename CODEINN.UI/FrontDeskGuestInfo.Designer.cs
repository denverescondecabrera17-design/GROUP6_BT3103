namespace CODEINN.UI
{
    partial class FrontDeskGuestInfo
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnBack = new Button();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            txtSearch = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtLastname = new TextBox();
            txtAge = new TextBox();
            txtEmail = new TextBox();
            btnSearch = new Button();
            txtFirstname = new TextBox();
            txtPhone = new TextBox();
            txtInitial = new TextBox();
            dtpBirtdate = new DateTimePicker();
            cbGender = new ComboBox();
            dtgInfo = new DataGridView();
            btnAdd = new Button();
            btnSave = new Button();
            btnEdit = new Button();
            btnview = new Button();
            panel2 = new Panel();
            lbl_guestid = new Label();
            txt_suffix = new TextBox();
            label13 = new Label();
            cb_idtype = new ComboBox();
            label12 = new Label();
            txtadress = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBack);
            panel1.Location = new Point(-6, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1926, 140);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(163, 56);
            label4.Name = "label4";
            label4.Size = new Size(338, 44);
            label4.TabIndex = 2;
            label4.Text = "Guest Information";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n_removebg_preview2;
            pictureBox1.Location = new Point(-122, -22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 30;
            pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1718, 42);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(162, 56);
            btnBack.TabIndex = 28;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 73);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 2;
            label1.Text = "Guest ID:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ControlLightLight;
            txtSearch.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.Gray;
            txtSearch.Location = new Point(603, 174);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(764, 34);
            txtSearch.TabIndex = 3;
            txtSearch.Text = "Search Guest";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.Enter += txtSearch_Enter;
            txtSearch.Leave += txtSearch_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 138);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 5;
            label3.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(33, 197);
            label5.Name = "label5";
            label5.Size = new Size(112, 23);
            label5.TabIndex = 6;
            label5.Text = "First Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(34, 251);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 7;
            label6.Text = "Middle Initial:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 373);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 8;
            label7.Text = "Age:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 317);
            label8.Name = "label8";
            label8.Size = new Size(104, 23);
            label8.TabIndex = 9;
            label8.Text = "Birth Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(34, 439);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 10;
            label9.Text = "Gender:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(34, 504);
            label10.Name = "label10";
            label10.Size = new Size(64, 23);
            label10.TabIndex = 11;
            label10.Text = "Email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(34, 573);
            label11.Name = "label11";
            label11.Size = new Size(145, 23);
            label11.TabIndex = 12;
            label11.Text = "Phone Number:";
            label11.Click += label11_Click;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(200, 138);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(319, 30);
            txtLastname.TabIndex = 14;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(198, 372);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(79, 30);
            txtAge.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(195, 500);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(324, 30);
            txtEmail.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(1378, 172);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 39);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(200, 195);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(319, 30);
            txtFirstname.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(195, 566);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(324, 30);
            txtPhone.TabIndex = 20;
            // 
            // txtInitial
            // 
            txtInitial.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInitial.Location = new Point(200, 251);
            txtInitial.Name = "txtInitial";
            txtInitial.Size = new Size(77, 30);
            txtInitial.TabIndex = 21;
            // 
            // dtpBirtdate
            // 
            dtpBirtdate.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirtdate.Location = new Point(198, 311);
            dtpBirtdate.Name = "dtpBirtdate";
            dtpBirtdate.Size = new Size(321, 30);
            dtpBirtdate.TabIndex = 22;
            dtpBirtdate.ValueChanged += dtpBirtdate_ValueChanged;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(195, 436);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(82, 32);
            cbGender.TabIndex = 23;
            // 
            // dtgInfo
            // 
            dtgInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfo.Location = new Point(604, 352);
            dtgInfo.Name = "dtgInfo";
            dtgInfo.RowHeadersWidth = 51;
            dtgInfo.Size = new Size(1291, 621);
            dtgInfo.TabIndex = 24;
            dtgInfo.CellContentClick += dtgInfo_CellContentClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(601, 254);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 37);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(722, 254);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 37);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(841, 254);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 37);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnview
            // 
            btnview.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnview.Location = new Point(956, 254);
            btnview.Name = "btnview";
            btnview.Size = new Size(94, 37);
            btnview.TabIndex = 28;
            btnview.Text = "View";
            btnview.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(lbl_guestid);
            panel2.Controls.Add(txt_suffix);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(cb_idtype);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtadress);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtLastname);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(cbGender);
            panel2.Controls.Add(txtFirstname);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(dtpBirtdate);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtInitial);
            panel2.Controls.Add(txtAge);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(0, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 989);
            panel2.TabIndex = 29;
            panel2.Paint += panel2_Paint;
            // 
            // lbl_guestid
            // 
            lbl_guestid.AutoSize = true;
            lbl_guestid.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_guestid.Location = new Point(198, 73);
            lbl_guestid.Name = "lbl_guestid";
            lbl_guestid.Size = new Size(17, 23);
            lbl_guestid.TabIndex = 136;
            lbl_guestid.Text = "-";
            // 
            // txt_suffix
            // 
            txt_suffix.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt_suffix.Location = new Point(432, 251);
            txt_suffix.Name = "txt_suffix";
            txt_suffix.Size = new Size(77, 30);
            txt_suffix.TabIndex = 56;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(352, 254);
            label13.Name = "label13";
            label13.Size = new Size(64, 23);
            label13.TabIndex = 55;
            label13.Text = "Suffix:";
            // 
            // cb_idtype
            // 
            cb_idtype.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_idtype.FormattingEnabled = true;
            cb_idtype.Items.AddRange(new object[] { "Passport", "Driver License", "National ID", "Student ID" });
            cb_idtype.Location = new Point(195, 680);
            cb_idtype.Name = "cb_idtype";
            cb_idtype.Size = new Size(201, 32);
            cb_idtype.TabIndex = 54;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(36, 689);
            label12.Name = "label12";
            label12.Size = new Size(85, 23);
            label12.TabIndex = 53;
            label12.Text = "ID Type:";
            // 
            // txtadress
            // 
            txtadress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadress.Location = new Point(195, 623);
            txtadress.Name = "txtadress";
            txtadress.Size = new Size(324, 30);
            txtadress.TabIndex = 52;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(37, 630);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 51;
            label2.Text = "Address:";
            // 
            // FrontDeskGuestInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1924, 987);
            Controls.Add(btnview);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(dtgInfo);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FrontDeskGuestInfo";
            Text = "FrontDeskGuestInfo";
            WindowState = FormWindowState.Maximized;
            Load += FrontDeskGuestInfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label1;
        private BindingSource bindingSource1;
        private TextBox txtSearch;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtLastname;
        private TextBox txtAge;
        private TextBox txtEmail;
        private Button btnSearch;
        private TextBox txtFirstname;
        private TextBox txtPhone;
        private TextBox txtInitial;
        private DateTimePicker dtpBirtdate;
        private ComboBox cbGender;
        private Button btnBack;
        private DataGridView dtgInfo;
        private Button btnAdd;
        private Button btnSave;
        private Button btnEdit;
        private Button btnview;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox txtadress;
        private Label label2;
        private TextBox txt_suffix;
        private Label label13;
        private ComboBox cb_idtype;
        private Label label12;
        private Label lbl_guestid;
    }
}