namespace M_T
{
    partial class dashboard
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            search_box = new TextBox();
            panel3 = new Panel();
            About = new Button();
            Buy_ticket = new Button();
            movie_trailer = new Button();
            buypanel = new Panel();
            trailer = new Panel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            buypanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 64, 0);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 94);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(752, 37);
            label3.Name = "label3";
            label3.Size = new Size(91, 34);
            label3.TabIndex = 3;
            label3.Text = "Logout";
            label3.Click += label3_Click;
            label3.MouseClick += label3_MouseClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(291, 37);
            label2.Name = "label2";
            label2.Size = new Size(187, 34);
            label2.TabIndex = 2;
            label2.Text = "Movie Ticketing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(185, 34);
            label1.TabIndex = 1;
            label1.Text = "User Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(buypanel);
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 373);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(search_box);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(658, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 373);
            panel5.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(61, 78);
            button1.Name = "button1";
            button1.Size = new Size(86, 35);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // search_box
            // 
            search_box.BackColor = Color.FromArgb(0, 64, 0);
            search_box.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_box.ForeColor = SystemColors.Menu;
            search_box.Location = new Point(6, 28);
            search_box.Name = "search_box";
            search_box.Size = new Size(188, 33);
            search_box.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(About);
            panel3.Controls.Add(Buy_ticket);
            panel3.Controls.Add(movie_trailer);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(144, 373);
            panel3.TabIndex = 1;
            // 
            // About
            // 
            About.BackColor = Color.FromArgb(0, 64, 0);
            About.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            About.ForeColor = Color.White;
            About.Location = new Point(12, 325);
            About.Name = "About";
            About.Size = new Size(100, 36);
            About.TabIndex = 4;
            About.Text = "About";
            About.UseVisualStyleBackColor = false;
            // 
            // Buy_ticket
            // 
            Buy_ticket.BackColor = Color.FromArgb(0, 64, 0);
            Buy_ticket.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buy_ticket.ForeColor = SystemColors.ButtonFace;
            Buy_ticket.Location = new Point(6, 15);
            Buy_ticket.Name = "Buy_ticket";
            Buy_ticket.Size = new Size(129, 36);
            Buy_ticket.TabIndex = 2;
            Buy_ticket.Text = "Buy Ticket";
            Buy_ticket.UseVisualStyleBackColor = false;
            Buy_ticket.Click += Buy_ticket_Click;
            // 
            // movie_trailer
            // 
            movie_trailer.BackColor = Color.FromArgb(0, 64, 0);
            movie_trailer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movie_trailer.ForeColor = SystemColors.ButtonFace;
            movie_trailer.Location = new Point(6, 57);
            movie_trailer.Name = "movie_trailer";
            movie_trailer.Size = new Size(129, 35);
            movie_trailer.TabIndex = 3;
            movie_trailer.Text = " Trailer";
            movie_trailer.UseVisualStyleBackColor = false;
            // 
            // buypanel
            // 
            buypanel.BackColor = Color.Gray;
            buypanel.Controls.Add(trailer);
            buypanel.Dock = DockStyle.Fill;
            buypanel.Location = new Point(0, 0);
            buypanel.Name = "buypanel";
            buypanel.Size = new Size(855, 373);
            buypanel.TabIndex = 2;
            buypanel.Paint += buypanel_Paint;
            // 
            // trailer
            // 
            trailer.BackColor = Color.Gray;
            trailer.Dock = DockStyle.Fill;
            trailer.Location = new Point(0, 0);
            trailer.Name = "trailer";
            trailer.Size = new Size(855, 373);
            trailer.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(855, 373);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(855, 467);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            Load += dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            buypanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Button About;
        private Button Buy_ticket;
        private Button movie_trailer;
        private Panel trailer;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox search_box;
        private Panel buypanel;
    }
}