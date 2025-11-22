namespace CODEINN.UI
{
    partial class FrontdeskRoomManagement
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
            btnSearch1 = new Button();
            txtSearchadmin = new TextBox();
            btnview1 = new Button();
            btnEditadmin = new Button();
            btnSaveadmin = new Button();
            btnAddadmin = new Button();
            dtgInfo1 = new DataGridView();
            txt_price = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBack1 = new Button();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            cb_roomtype = new ComboBox();
            cb_roomnum = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dtgInfo1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnSearch1
            // 
            btnSearch1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch1.Location = new Point(1370, 172);
            btnSearch1.Name = "btnSearch1";
            btnSearch1.Size = new Size(98, 39);
            btnSearch1.TabIndex = 87;
            btnSearch1.Text = "Search";
            btnSearch1.UseVisualStyleBackColor = true;
            // 
            // txtSearchadmin
            // 
            txtSearchadmin.BackColor = SystemColors.ControlLightLight;
            txtSearchadmin.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchadmin.Location = new Point(601, 172);
            txtSearchadmin.Name = "txtSearchadmin";
            txtSearchadmin.Size = new Size(764, 34);
            txtSearchadmin.TabIndex = 86;
            // 
            // btnview1
            // 
            btnview1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnview1.Location = new Point(929, 252);
            btnview1.Name = "btnview1";
            btnview1.Size = new Size(94, 37);
            btnview1.TabIndex = 81;
            btnview1.Text = "View";
            btnview1.UseVisualStyleBackColor = true;
            btnview1.Click += btnview1_Click;
            // 
            // btnEditadmin
            // 
            btnEditadmin.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditadmin.Location = new Point(823, 252);
            btnEditadmin.Name = "btnEditadmin";
            btnEditadmin.Size = new Size(94, 37);
            btnEditadmin.TabIndex = 79;
            btnEditadmin.Text = "Edit";
            btnEditadmin.UseVisualStyleBackColor = true;
            // 
            // btnSaveadmin
            // 
            btnSaveadmin.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveadmin.Location = new Point(714, 252);
            btnSaveadmin.Name = "btnSaveadmin";
            btnSaveadmin.Size = new Size(94, 37);
            btnSaveadmin.TabIndex = 78;
            btnSaveadmin.Text = "Save";
            btnSaveadmin.UseVisualStyleBackColor = true;
            // 
            // btnAddadmin
            // 
            btnAddadmin.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddadmin.Location = new Point(601, 252);
            btnAddadmin.Name = "btnAddadmin";
            btnAddadmin.Size = new Size(94, 37);
            btnAddadmin.TabIndex = 77;
            btnAddadmin.Text = "Add";
            btnAddadmin.UseVisualStyleBackColor = true;
            // 
            // dtgInfo1
            // 
            dtgInfo1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfo1.Location = new Point(601, 348);
            dtgInfo1.Name = "dtgInfo1";
            dtgInfo1.RowHeadersWidth = 51;
            dtgInfo1.Size = new Size(1291, 621);
            dtgInfo1.TabIndex = 76;
            dtgInfo1.CellContentClick += dtgInfo1_CellContentClick;
            // 
            // txt_price
            // 
            txt_price.Font = new Font("Arial", 12F);
            txt_price.Location = new Point(186, 213);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(319, 30);
            txt_price.TabIndex = 74;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F);
            label3.Location = new Point(20, 220);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 71;
            label3.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F);
            label2.Location = new Point(25, 113);
            label2.Name = "label2";
            label2.Size = new Size(117, 23);
            label2.TabIndex = 70;
            label2.Text = "Room Type:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F);
            label1.Location = new Point(25, 160);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 69;
            label1.Text = "Room Number:";
            // 
            // btnBack1
            // 
            btnBack1.Font = new Font("Arial", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBack1.Location = new Point(1722, 45);
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
            label4.Location = new Point(160, 51);
            label4.Name = "label4";
            label4.Size = new Size(364, 44);
            label4.TabIndex = 2;
            label4.Text = "Room Management";
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
            panel1.TabIndex = 67;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n_removebg_preview2;
            pictureBox1.Location = new Point(-114, -19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(413, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(cb_roomtype);
            panel2.Controls.Add(cb_roomnum);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txt_price);
            panel2.Location = new Point(0, 133);
            panel2.Name = "panel2";
            panel2.Size = new Size(570, 989);
            panel2.TabIndex = 88;
            // 
            // cb_roomtype
            // 
            cb_roomtype.FormattingEnabled = true;
            cb_roomtype.Location = new Point(186, 108);
            cb_roomtype.Name = "cb_roomtype";
            cb_roomtype.Size = new Size(319, 28);
            cb_roomtype.TabIndex = 76;
            cb_roomtype.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // cb_roomnum
            // 
            cb_roomnum.FormattingEnabled = true;
            cb_roomnum.Location = new Point(186, 160);
            cb_roomnum.Name = "cb_roomnum";
            cb_roomnum.Size = new Size(319, 28);
            cb_roomnum.TabIndex = 75;
            cb_roomnum.SelectedIndexChanged += cb_roomnum_SelectedIndexChanged;
            // 
            // FrontdeskRoomManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1924, 987);
            Controls.Add(btnSearch1);
            Controls.Add(txtSearchadmin);
            Controls.Add(btnview1);
            Controls.Add(btnEditadmin);
            Controls.Add(btnSaveadmin);
            Controls.Add(btnAddadmin);
            Controls.Add(dtgInfo1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FrontdeskRoomManagement";
            Text = "FrontdeskRoomManagement";
            WindowState = FormWindowState.Maximized;
            Load += FrontdeskRoomManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dtgInfo1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch1;
        private TextBox txtSearchadmin;
        private Button btnview1;
        private Button btnEditadmin;
        private Button btnSaveadmin;
        private Button btnAddadmin;
        private DataGridView dtgInfo1;
        private TextBox txt_price;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBack1;
        private Label label4;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private ComboBox cb_roomtype;
        private ComboBox cb_roomnum;
    }
}