namespace CODEINN.UI
{
    partial class AdminRoomManagement
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txt_price = new TextBox();
            dtgInfo1 = new DataGridView();
            btnview1 = new Button();
            btnDelete = new Button();
            btnEditadmin = new Button();
            btnSaveadmin = new Button();
            btnAddadmin = new Button();
            btnSearch1 = new Button();
            txtSearchadmin = new TextBox();
            panel2 = new Panel();
            cb_status = new ComboBox();
            cb_roomtype = new ComboBox();
            room_number = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBack1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1926, 140);
            panel1.TabIndex = 29;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(150, 51);
            label4.Name = "label4";
            label4.Size = new Size(364, 44);
            label4.TabIndex = 2;
            label4.Text = "Room Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n_removebg_preview2;
            pictureBox1.Location = new Point(-129, -23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // btnBack1
            // 
            btnBack1.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack1.Location = new Point(1714, 41);
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
            label1.Location = new Point(26, 150);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 41;
            label1.Text = "Room Number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(27, 92);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 42;
            label2.Text = "Room Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(22, 224);
            label3.Name = "label3";
            label3.Size = new Size(132, 23);
            label3.TabIndex = 43;
            label3.Text = "Price (Peso) :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(23, 290);
            label5.Name = "label5";
            label5.Size = new Size(72, 23);
            label5.TabIndex = 45;
            label5.Text = "Status:";
            // 
            // txt_price
            // 
            txt_price.Font = new Font("Arial", 12F);
            txt_price.Location = new Point(178, 223);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(319, 30);
            txt_price.TabIndex = 46;
            // 
            // dtgInfo1
            // 
            dtgInfo1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfo1.Location = new Point(604, 357);
            dtgInfo1.Name = "dtgInfo1";
            dtgInfo1.RowHeadersWidth = 51;
            dtgInfo1.Size = new Size(1291, 621);
            dtgInfo1.TabIndex = 50;
            dtgInfo1.CellContentClick += dtgInfo1_CellContentClick;
            // 
            // btnview1
            // 
            btnview1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnview1.Location = new Point(931, 260);
            btnview1.Name = "btnview1";
            btnview1.Size = new Size(94, 37);
            btnview1.TabIndex = 59;
            btnview1.Text = "View";
            btnview1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(1037, 260);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 37);
            btnDelete.TabIndex = 58;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEditadmin
            // 
            btnEditadmin.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditadmin.Location = new Point(825, 260);
            btnEditadmin.Name = "btnEditadmin";
            btnEditadmin.Size = new Size(94, 37);
            btnEditadmin.TabIndex = 57;
            btnEditadmin.Text = "Edit";
            btnEditadmin.UseVisualStyleBackColor = true;
            // 
            // btnSaveadmin
            // 
            btnSaveadmin.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveadmin.Location = new Point(716, 260);
            btnSaveadmin.Name = "btnSaveadmin";
            btnSaveadmin.Size = new Size(94, 37);
            btnSaveadmin.TabIndex = 56;
            btnSaveadmin.Text = "Save";
            btnSaveadmin.UseVisualStyleBackColor = true;
            btnSaveadmin.Click += btnSaveadmin_Click;
            // 
            // btnAddadmin
            // 
            btnAddadmin.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddadmin.Location = new Point(603, 260);
            btnAddadmin.Name = "btnAddadmin";
            btnAddadmin.Size = new Size(94, 37);
            btnAddadmin.TabIndex = 55;
            btnAddadmin.Text = "Add";
            btnAddadmin.UseVisualStyleBackColor = true;
            // 
            // btnSearch1
            // 
            btnSearch1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch1.Location = new Point(1381, 174);
            btnSearch1.Name = "btnSearch1";
            btnSearch1.Size = new Size(98, 39);
            btnSearch1.TabIndex = 66;
            btnSearch1.Text = "Search";
            btnSearch1.UseVisualStyleBackColor = true;
            // 
            // txtSearchadmin
            // 
            txtSearchadmin.BackColor = SystemColors.ControlLightLight;
            txtSearchadmin.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchadmin.Location = new Point(605, 177);
            txtSearchadmin.Name = "txtSearchadmin";
            txtSearchadmin.Size = new Size(764, 34);
            txtSearchadmin.TabIndex = 65;
            txtSearchadmin.TextChanged += txtSearchadmin_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(cb_status);
            panel2.Controls.Add(cb_roomtype);
            panel2.Controls.Add(room_number);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_price);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(-1, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 989);
            panel2.TabIndex = 67;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "Available", "Under Maintenance" });
            cb_status.Location = new Point(178, 290);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(319, 28);
            cb_status.TabIndex = 67;
            // 
            // cb_roomtype
            // 
            cb_roomtype.FormattingEnabled = true;
            cb_roomtype.Location = new Point(174, 92);
            cb_roomtype.Name = "cb_roomtype";
            cb_roomtype.Size = new Size(323, 28);
            cb_roomtype.TabIndex = 66;
            cb_roomtype.SelectedIndexChanged += cb_roomtype_SelectedIndexChanged;
            // 
            // room_number
            // 
            room_number.FormattingEnabled = true;
            room_number.Location = new Point(174, 145);
            room_number.Name = "room_number";
            room_number.Size = new Size(323, 28);
            room_number.TabIndex = 65;
            room_number.SelectedIndexChanged += room_number_SelectedIndexChanged;
            // 
            // AdminRoomManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1924, 987);
            Controls.Add(btnSearch1);
            Controls.Add(txtSearchadmin);
            Controls.Add(btnview1);
            Controls.Add(btnDelete);
            Controls.Add(btnEditadmin);
            Controls.Add(btnSaveadmin);
            Controls.Add(btnAddadmin);
            Controls.Add(dtgInfo1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminRoomManagement";
            Text = "AdminRoomManagement";
            WindowState = FormWindowState.Maximized;
            Load += AdminRoomManagement_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnBack1;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txt_price;
        private DataGridView dtgInfo1;
        private Button btnview1;
        private Button btnDelete;
        private Button btnEditadmin;
        private Button btnSaveadmin;
        private Button btnAddadmin;
        private Button btnSearch1;
        private TextBox txtSearchadmin;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox cb_roomtype;
        private ComboBox room_number;
        private ComboBox cb_status;
    }
}