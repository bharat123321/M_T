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
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            button1 = new Button();
            search_box = new TextBox();
            panel3 = new Panel();
            About = new Button();
            Buy_ticket = new Button();
            movie_trailer = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
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
            label3.Cursor = Cursors.Hand;
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(766, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 3;
            label3.Text = "Logout";
            label3.Click += label3_Click;
            label3.MouseClick += label3_MouseClick;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(291, 37);
            label2.Name = "label2";
            label2.Size = new Size(185, 32);
            label2.TabIndex = 2;
            label2.Text = "Movie Ticketing";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 32);
            label1.TabIndex = 1;
            label1.Text = "Dashboard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 64);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 373);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(144, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(514, 373);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(64, 0, 0);
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
            button1.Location = new Point(61, 44);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // search_box
            // 
            search_box.Location = new Point(6, 6);
            search_box.Name = "search_box";
            search_box.Size = new Size(188, 23);
            search_box.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 0, 0);
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
            About.Location = new Point(12, 338);
            About.Name = "About";
            About.Size = new Size(100, 23);
            About.TabIndex = 4;
            About.Text = "About";
            About.UseVisualStyleBackColor = true;
            // 
            // Buy_ticket
            // 
            Buy_ticket.Location = new Point(12, 15);
            Buy_ticket.Name = "Buy_ticket";
            Buy_ticket.Size = new Size(100, 23);
            Buy_ticket.TabIndex = 2;
            Buy_ticket.Text = "Buy Ticket";
            Buy_ticket.UseVisualStyleBackColor = true;
            // 
            // movie_trailer
            // 
            movie_trailer.Location = new Point(12, 57);
            movie_trailer.Name = "movie_trailer";
            movie_trailer.Size = new Size(100, 23);
            movie_trailer.TabIndex = 3;
            movie_trailer.Text = "Movie Trailer";
            movie_trailer.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
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
        private Panel panel4;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Button button1;
        private TextBox search_box;
    }
}