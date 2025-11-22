namespace CODEINN.UI
{
    partial class Connect
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
            btnfrontdesk = new Button();
            btnadmin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnfrontdesk
            // 
            btnfrontdesk.BackColor = SystemColors.ActiveCaption;
            btnfrontdesk.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnfrontdesk.ForeColor = SystemColors.ActiveCaptionText;
            btnfrontdesk.Location = new Point(289, 365);
            btnfrontdesk.Name = "btnfrontdesk";
            btnfrontdesk.Size = new Size(225, 51);
            btnfrontdesk.TabIndex = 5;
            btnfrontdesk.Text = "Front desk";
            btnfrontdesk.UseVisualStyleBackColor = false;
            btnfrontdesk.Click += btnfrontdesk_Click;
            // 
            // btnadmin
            // 
            btnadmin.BackColor = SystemColors.ActiveCaption;
            btnadmin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadmin.Location = new Point(289, 288);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(225, 51);
            btnadmin.TabIndex = 4;
            btnadmin.Text = "Admin";
            btnadmin.UseVisualStyleBackColor = false;
            btnadmin.Click += btnadmin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._541242678_782352804536515_6233556420554188928_n_removebg_preview1;
            pictureBox1.Location = new Point(99, -77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(603, 435);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Connect
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnfrontdesk);
            Controls.Add(btnadmin);
            Controls.Add(pictureBox1);
            Name = "Connect";
            Text = "Connect";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnfrontdesk;
        private Button btnadmin;
        private PictureBox pictureBox1;
    }
}