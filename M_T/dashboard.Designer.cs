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
            All = new Panel();
            check = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            search_box = new TextBox();
            panel3 = new Panel();
            Movie_list = new Button();
            button2 = new Button();
            About = new Button();
            Buy_ticket = new Button();
            movie_trailer = new Button();
            panel1.SuspendLayout();
            All.SuspendLayout();
            check.SuspendLayout();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 94);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Cursor = Cursors.Hand;
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(957, 0);
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
            label2.Location = new Point(407, 37);
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
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(208, 186);
            label1.Name = "label1";
            label1.Size = new Size(291, 34);
            label1.TabIndex = 1;
            label1.Text = "Welcome User Dashboard";
            label1.Click += label1_Click;
            label1.MouseClick += label1_MouseClick;
            // 
            // All
            // 
            All.BackColor = Color.Gray;
            All.Controls.Add(check);
            All.Controls.Add(panel5);
            All.Controls.Add(panel3);
            All.Dock = DockStyle.Fill;
            All.Location = new Point(0, 94);
            All.Name = "All";
            All.Size = new Size(1048, 530);
            All.TabIndex = 1;
            All.Paint += panel2_Paint;
            // 
            // check
            // 
            check.Controls.Add(label1);
            check.Dock = DockStyle.Fill;
            check.Location = new Point(164, 0);
            check.Name = "check";
            check.Size = new Size(666, 530);
            check.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 64, 64);
            panel5.Controls.Add(button1);
            panel5.Controls.Add(search_box);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(830, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(218, 530);
            panel5.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(10, 57);
            button1.Name = "button1";
            button1.Size = new Size(196, 35);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // search_box
            // 
            search_box.BackColor = Color.Black;
            search_box.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_box.ForeColor = SystemColors.Menu;
            search_box.Location = new Point(10, 6);
            search_box.Name = "search_box";
            search_box.Size = new Size(196, 33);
            search_box.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(Movie_list);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(About);
            panel3.Controls.Add(Buy_ticket);
            panel3.Controls.Add(movie_trailer);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(164, 530);
            panel3.TabIndex = 1;
            // 
            // Movie_list
            // 
            Movie_list.BackColor = Color.Black;
            Movie_list.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Movie_list.ForeColor = SystemColors.ButtonFace;
            Movie_list.Location = new Point(15, 98);
            Movie_list.Name = "Movie_list";
            Movie_list.Size = new Size(132, 35);
            Movie_list.TabIndex = 6;
            Movie_list.Text = "Movie List";
            Movie_list.UseVisualStyleBackColor = false;
            Movie_list.Click += movielist_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(15, 139);
            button2.Name = "button2";
            button2.Size = new Size(132, 35);
            button2.TabIndex = 5;
            button2.Text = "Chat";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // About
            // 
            About.BackColor = Color.Black;
            About.Dock = DockStyle.Bottom;
            About.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            About.ForeColor = Color.White;
            About.Location = new Point(0, 494);
            About.Name = "About";
            About.Size = new Size(164, 36);
            About.TabIndex = 4;
            About.Text = "About";
            About.UseVisualStyleBackColor = false;
            // 
            // Buy_ticket
            // 
            Buy_ticket.BackColor = Color.Black;
            Buy_ticket.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Buy_ticket.ForeColor = SystemColors.ButtonFace;
            Buy_ticket.Location = new Point(15, 15);
            Buy_ticket.Name = "Buy_ticket";
            Buy_ticket.Size = new Size(129, 36);
            Buy_ticket.TabIndex = 2;
            Buy_ticket.Text = "Buy Ticket";
            Buy_ticket.UseVisualStyleBackColor = false;
            Buy_ticket.Click += Buy_ticket_Click;
            // 
            // movie_trailer
            // 
            movie_trailer.BackColor = Color.Black;
            movie_trailer.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movie_trailer.ForeColor = SystemColors.ButtonFace;
            movie_trailer.Location = new Point(15, 57);
            movie_trailer.Name = "movie_trailer";
            movie_trailer.Size = new Size(129, 35);
            movie_trailer.TabIndex = 3;
            movie_trailer.Text = " Trailer";
            movie_trailer.UseVisualStyleBackColor = false;
            movie_trailer.Click += movie_trailer_Click;
            // 
            // dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1048, 624);
            Controls.Add(All);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "dashboard";
            Load += dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            All.ResumeLayout(false);
            check.ResumeLayout(false);
            check.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel All;
        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel3;
        private Button About;
        private Button Buy_ticket;
        private Button movie_trailer;
        private Panel panel5;
        private Button button1;
        private TextBox search_box;
        private Panel buypanel;
        private Button button2;
        private DataGridView dataGridView;
        private Panel buy;
        private Panel check;
        private Button Movie_list;
    }
}