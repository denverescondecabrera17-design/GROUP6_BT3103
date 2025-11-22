namespace CODEINN.UI
{
    partial class AdminGuestInfo
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
            btnEditadmin = new Button();
            btnSaveadmin = new Button();
            btnAddadmin = new Button();
            dtgInfo1 = new DataGridView();
            cbGenderadmin = new ComboBox();
            dtpBirtdateadmin = new DateTimePicker();
            txtInitialadmin = new TextBox();
            txtPhoneadmin = new TextBox();
            txtFirstnameadmin = new TextBox();
            btnSearch1 = new Button();
            txtEmailadmin = new TextBox();
            txtAgeadmin = new TextBox();
            txtLastnameadmin = new TextBox();
            txtGuestIdadmin = new TextBox();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtSearchadmin = new TextBox();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            btnBack1 = new Button();
            label4 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnDelete = new Button();
            btnview1 = new Button();
            panel2 = new Panel();
            txtadress = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgInfo1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditadmin
            // 
            btnEditadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditadmin.Location = new Point(843, 266);
            btnEditadmin.Name = "btnEditadmin";
            btnEditadmin.Size = new Size(94, 37);
            btnEditadmin.TabIndex = 52;
            btnEditadmin.Text = "Edit";
            btnEditadmin.UseVisualStyleBackColor = true;
            btnEditadmin.Click += btnEditadmin_Click;
            // 
            // btnSaveadmin
            // 
            btnSaveadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveadmin.Location = new Point(734, 266);
            btnSaveadmin.Name = "btnSaveadmin";
            btnSaveadmin.Size = new Size(94, 37);
            btnSaveadmin.TabIndex = 51;
            btnSaveadmin.Text = "Save";
            btnSaveadmin.UseVisualStyleBackColor = true;
            btnSaveadmin.Click += btnSaveadmin_Click;
            // 
            // btnAddadmin
            // 
            btnAddadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddadmin.Location = new Point(614, 266);
            btnAddadmin.Name = "btnAddadmin";
            btnAddadmin.Size = new Size(94, 37);
            btnAddadmin.TabIndex = 50;
            btnAddadmin.Text = "Add";
            btnAddadmin.UseVisualStyleBackColor = true;
            btnAddadmin.Click += btnAddadmin_Click;
            // 
            // dtgInfo1
            // 
            dtgInfo1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfo1.Location = new Point(594, 354);
            dtgInfo1.Name = "dtgInfo1";
            dtgInfo1.RowHeadersWidth = 51;
            dtgInfo1.Size = new Size(1291, 621);
            dtgInfo1.TabIndex = 49;
            dtgInfo1.CellContentClick += dtgInfo1_CellContentClick;
            // 
            // cbGenderadmin
            // 
            cbGenderadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGenderadmin.FormattingEnabled = true;
            cbGenderadmin.Items.AddRange(new object[] { "Male", "Female" });
            cbGenderadmin.Location = new Point(179, 479);
            cbGenderadmin.Name = "cbGenderadmin";
            cbGenderadmin.Size = new Size(79, 31);
            cbGenderadmin.TabIndex = 48;
            // 
            // dtpBirtdateadmin
            // 
            dtpBirtdateadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirtdateadmin.Location = new Point(177, 367);
            dtpBirtdateadmin.Name = "dtpBirtdateadmin";
            dtpBirtdateadmin.Size = new Size(352, 30);
            dtpBirtdateadmin.TabIndex = 47;
            dtpBirtdateadmin.ValueChanged += dtpBirtdateadmin_ValueChanged;
            // 
            // txtInitialadmin
            // 
            txtInitialadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInitialadmin.Location = new Point(178, 313);
            txtInitialadmin.Name = "txtInitialadmin";
            txtInitialadmin.Size = new Size(80, 30);
            txtInitialadmin.TabIndex = 46;
            // 
            // txtPhoneadmin
            // 
            txtPhoneadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneadmin.Location = new Point(179, 604);
            txtPhoneadmin.Name = "txtPhoneadmin";
            txtPhoneadmin.Size = new Size(350, 30);
            txtPhoneadmin.TabIndex = 45;
            // 
            // txtFirstnameadmin
            // 
            txtFirstnameadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstnameadmin.Location = new Point(176, 259);
            txtFirstnameadmin.Name = "txtFirstnameadmin";
            txtFirstnameadmin.Size = new Size(353, 30);
            txtFirstnameadmin.TabIndex = 44;
            // 
            // btnSearch1
            // 
            btnSearch1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch1.Location = new Point(1396, 174);
            btnSearch1.Name = "btnSearch1";
            btnSearch1.Size = new Size(98, 39);
            btnSearch1.TabIndex = 43;
            btnSearch1.Text = "Search";
            btnSearch1.UseVisualStyleBackColor = true;
            btnSearch1.Click += btnSearch1_Click;
            // 
            // txtEmailadmin
            // 
            txtEmailadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailadmin.Location = new Point(179, 538);
            txtEmailadmin.Name = "txtEmailadmin";
            txtEmailadmin.Size = new Size(350, 30);
            txtEmailadmin.TabIndex = 42;
            // 
            // txtAgeadmin
            // 
            txtAgeadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAgeadmin.Location = new Point(179, 425);
            txtAgeadmin.Name = "txtAgeadmin";
            txtAgeadmin.Size = new Size(79, 30);
            txtAgeadmin.TabIndex = 41;
            // 
            // txtLastnameadmin
            // 
            txtLastnameadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastnameadmin.Location = new Point(176, 208);
            txtLastnameadmin.Name = "txtLastnameadmin";
            txtLastnameadmin.Size = new Size(353, 30);
            txtLastnameadmin.TabIndex = 40;
            // 
            // txtGuestIdadmin
            // 
            txtGuestIdadmin.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuestIdadmin.Location = new Point(177, 135);
            txtGuestIdadmin.Name = "txtGuestIdadmin";
            txtGuestIdadmin.Size = new Size(352, 30);
            txtGuestIdadmin.TabIndex = 39;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(23, 607);
            label11.Name = "label11";
            label11.Size = new Size(145, 23);
            label11.TabIndex = 38;
            label11.Text = "Phone Number:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(23, 487);
            label9.Name = "label9";
            label9.Size = new Size(82, 23);
            label9.TabIndex = 36;
            label9.Text = "Gender:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(21, 374);
            label8.Name = "label8";
            label8.Size = new Size(104, 23);
            label8.TabIndex = 35;
            label8.Text = "Birth Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(23, 428);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 34;
            label7.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(20, 320);
            label6.Name = "label6";
            label6.Size = new Size(125, 23);
            label6.TabIndex = 33;
            label6.Text = "Middle Initial:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 266);
            label5.Name = "label5";
            label5.Size = new Size(112, 23);
            label5.TabIndex = 32;
            label5.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 211);
            label3.Name = "label3";
            label3.Size = new Size(111, 23);
            label3.TabIndex = 31;
            label3.Text = "Last Name:";
            // 
            // txtSearchadmin
            // 
            txtSearchadmin.BackColor = SystemColors.ControlLightLight;
            txtSearchadmin.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchadmin.ForeColor = Color.Gray;
            txtSearchadmin.Location = new Point(610, 177);
            txtSearchadmin.Name = "txtSearchadmin";
            txtSearchadmin.Size = new Size(764, 34);
            txtSearchadmin.TabIndex = 30;
            txtSearchadmin.Text = "Search Guest";
            txtSearchadmin.TextChanged += txtSearchadmin_TextChanged;
            txtSearchadmin.Enter += enter;
            txtSearchadmin.Leave += exit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 139);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 29;
            label1.Text = "Guest ID:";
            // 
            // btnBack1
            // 
            btnBack1.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack1.Location = new Point(1733, 42);
            btnBack1.Name = "btnBack1";
            btnBack1.Size = new Size(162, 56);
            btnBack1.TabIndex = 28;
            btnBack1.Text = "Back";
            btnBack1.UseVisualStyleBackColor = true;
            btnBack1.Click += btnBack1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(144, 54);
            label4.Name = "label4";
            label4.Size = new Size(338, 44);
            label4.TabIndex = 2;
            label4.Text = "Guest Information";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(23, 545);
            label10.Name = "label10";
            label10.Size = new Size(64, 23);
            label10.TabIndex = 37;
            label10.Text = "Email:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBack1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1926, 140);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n_removebg_preview2;
            pictureBox1.Location = new Point(-134, -18);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1056, 266);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 37);
            btnDelete.TabIndex = 53;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnview1
            // 
            btnview1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnview1.Location = new Point(951, 266);
            btnview1.Name = "btnview1";
            btnview1.Size = new Size(94, 37);
            btnview1.TabIndex = 54;
            btnview1.Text = "View";
            btnview1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(txtadress);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtPhoneadmin);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtEmailadmin);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(cbGenderadmin);
            panel2.Controls.Add(txtFirstnameadmin);
            panel2.Controls.Add(txtGuestIdadmin);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(txtLastnameadmin);
            panel2.Controls.Add(txtInitialadmin);
            panel2.Controls.Add(dtpBirtdateadmin);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtAgeadmin);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(3, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 898);
            panel2.TabIndex = 55;
            // 
            // txtadress
            // 
            txtadress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtadress.Location = new Point(179, 667);
            txtadress.Name = "txtadress";
            txtadress.Size = new Size(350, 30);
            txtadress.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 674);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 49;
            label2.Text = "Address:";
            // 
            // AdminGuestInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1924, 987);
            Controls.Add(btnview1);
            Controls.Add(btnDelete);
            Controls.Add(btnEditadmin);
            Controls.Add(btnSaveadmin);
            Controls.Add(btnAddadmin);
            Controls.Add(dtgInfo1);
            Controls.Add(btnSearch1);
            Controls.Add(txtSearchadmin);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminGuestInfo";
            Text = "AdminGuestInfo";
            WindowState = FormWindowState.Maximized;
            Load += AdminGuestInfo_Load;
            ((System.ComponentModel.ISupportInitialize)dtgInfo1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditadmin;
        private Button btnSaveadmin;
        private Button btnAddadmin;
        private DataGridView dtgInfo1;
        private ComboBox cbGenderadmin;
        private DateTimePicker dtpBirtdateadmin;
        private TextBox txtInitialadmin;
        private TextBox txtPhoneadmin;
        private TextBox txtFirstnameadmin;
        private Button btnSearch1;
        private TextBox txtEmailadmin;
        private TextBox txtAgeadmin;
        private TextBox txtLastnameadmin;
        private TextBox txtGuestIdadmin;
        private Label label11;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtSearchadmin;
        private BindingSource bindingSource1;
        private Label label1;
        private Button btnBack1;
        private Label label4;
        private Label label10;
        private Panel panel1;
        private Button btnDelete;
        private Button btnview1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private TextBox txtadress;
        private Label label2;
    }
}