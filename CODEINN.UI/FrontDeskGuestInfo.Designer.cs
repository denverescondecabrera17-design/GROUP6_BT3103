namespace CODEINN.UI
{
    partial class FrontDeskGuestInfo
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnBack = new Button();
            label4 = new Label();
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
            txtGuestId = new TextBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(-9, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1323, 63);
            panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1221, 19);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 28;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(26, 13);
            label4.Name = "label4";
            label4.Size = new Size(249, 35);
            label4.TabIndex = 2;
            label4.Text = "Guest Information";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 134);
            label1.Name = "label1";
            label1.Size = new Size(85, 21);
            label1.TabIndex = 2;
            label1.Text = "Guest ID:";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.ControlLightLight;
            txtSearch.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(29, 75);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(462, 34);
            txtSearch.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(26, 175);
            label3.Name = "label3";
            label3.Size = new Size(101, 21);
            label3.TabIndex = 5;
            label3.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(449, 171);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 6;
            label5.Text = "First Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(927, 174);
            label6.Name = "label6";
            label6.Size = new Size(114, 21);
            label6.TabIndex = 7;
            label6.Text = "Middle Initial:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 219);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 8;
            label7.Text = "Age:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(449, 220);
            label8.Name = "label8";
            label8.Size = new Size(95, 21);
            label8.TabIndex = 9;
            label8.Text = "Birth Date:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(927, 213);
            label9.Name = "label9";
            label9.Size = new Size(75, 21);
            label9.TabIndex = 10;
            label9.Text = "Gender:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(26, 270);
            label10.Name = "label10";
            label10.Size = new Size(59, 21);
            label10.TabIndex = 11;
            label10.Text = "Email:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(448, 268);
            label11.Name = "label11";
            label11.Size = new Size(135, 21);
            label11.TabIndex = 12;
            label11.Text = "Phone Number:";
            label11.Click += label11_Click;
            // 
            // txtGuestId
            // 
            txtGuestId.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtGuestId.Location = new Point(139, 131);
            txtGuestId.Name = "txtGuestId";
            txtGuestId.Size = new Size(281, 28);
            txtGuestId.TabIndex = 13;
            // 
            // txtLastname
            // 
            txtLastname.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastname.Location = new Point(139, 171);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(281, 28);
            txtLastname.TabIndex = 14;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAge.Location = new Point(139, 214);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(79, 28);
            txtAge.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(139, 261);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(281, 28);
            txtEmail.TabIndex = 16;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(497, 78);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 17;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtFirstname
            // 
            txtFirstname.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstname.Location = new Point(591, 168);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(289, 28);
            txtFirstname.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.Location = new Point(592, 261);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(288, 28);
            txtPhone.TabIndex = 20;
            // 
            // txtInitial
            // 
            txtInitial.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInitial.Location = new Point(1047, 168);
            txtInitial.Name = "txtInitial";
            txtInitial.Size = new Size(70, 28);
            txtInitial.TabIndex = 21;
            // 
            // dtpBirtdate
            // 
            dtpBirtdate.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpBirtdate.Location = new Point(592, 213);
            dtpBirtdate.Name = "dtpBirtdate";
            dtpBirtdate.Size = new Size(288, 28);
            dtpBirtdate.TabIndex = 22;
            // 
            // cbGender
            // 
            cbGender.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbGender.FormattingEnabled = true;
            cbGender.Location = new Point(1047, 213);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(70, 30);
            cbGender.TabIndex = 23;
            // 
            // dtgInfo
            // 
            dtgInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfo.Location = new Point(29, 371);
            dtgInfo.Name = "dtgInfo";
            dtgInfo.RowHeadersWidth = 51;
            dtgInfo.Size = new Size(1259, 313);
            dtgInfo.TabIndex = 24;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(947, 336);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 25;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(1062, 336);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.Location = new Point(1176, 336);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 27;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // FrontDeskGuestInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1318, 707);
            Controls.Add(btnEdit);
            Controls.Add(btnSave);
            Controls.Add(btnAdd);
            Controls.Add(dtgInfo);
            Controls.Add(cbGender);
            Controls.Add(dtpBirtdate);
            Controls.Add(txtInitial);
            Controls.Add(txtPhone);
            Controls.Add(txtFirstname);
            Controls.Add(btnSearch);
            Controls.Add(txtEmail);
            Controls.Add(txtAge);
            Controls.Add(txtLastname);
            Controls.Add(txtGuestId);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrontDeskGuestInfo";
            Text = "FrontDeskGuestInfo";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo).EndInit();
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
        private TextBox txtGuestId;
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
    }
}