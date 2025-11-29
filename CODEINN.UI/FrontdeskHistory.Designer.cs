namespace CODEINN.UI
{
    partial class FrontdeskHistory
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
            txtSearchadmin = new TextBox();
            btnSearch1 = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            btnBack1 = new Button();
            dtgInfo1 = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearchadmin
            // 
            txtSearchadmin.BackColor = SystemColors.ControlLightLight;
            txtSearchadmin.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchadmin.Location = new Point(12, 193);
            txtSearchadmin.Name = "txtSearchadmin";
            txtSearchadmin.Size = new Size(764, 34);
            txtSearchadmin.TabIndex = 74;
            // 
            // btnSearch1
            // 
            btnSearch1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch1.Location = new Point(821, 193);
            btnSearch1.Name = "btnSearch1";
            btnSearch1.Size = new Size(98, 39);
            btnSearch1.TabIndex = 75;
            btnSearch1.Text = "Search";
            btnSearch1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(150, 51);
            label4.Name = "label4";
            label4.Size = new Size(262, 44);
            label4.TabIndex = 2;
            label4.Text = "Guest History";
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
            // 
            // dtgInfo1
            // 
            dtgInfo1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInfo1.Location = new Point(11, 274);
            dtgInfo1.Name = "dtgInfo1";
            dtgInfo1.RowHeadersWidth = 51;
            dtgInfo1.Size = new Size(1883, 708);
            dtgInfo1.TabIndex = 73;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnBack1);
            panel1.Location = new Point(-1, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1926, 140);
            panel1.TabIndex = 72;
            // 
            // FrontdeskHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 987);
            Controls.Add(txtSearchadmin);
            Controls.Add(btnSearch1);
            Controls.Add(dtgInfo1);
            Controls.Add(panel1);
            Name = "FrontdeskHistory";
            Text = "FrontdeskHistory";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgInfo1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSearchadmin;
        private Button btnSearch1;
        private Label label4;
        private PictureBox pictureBox1;
        private Button btnBack1;
        private DataGridView dtgInfo1;
        private Panel panel1;
    }
}