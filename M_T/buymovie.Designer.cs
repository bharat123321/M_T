namespace M_T
{
    partial class buymovie
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
            button2 = new Button();
            seat = new Button();
            label5 = new Label();
            comboBox3 = new ComboBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            s_movie = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(seat);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(s_movie);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(57, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(567, 454);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 0, 64);
            button2.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(263, 319);
            button2.Name = "button2";
            button2.Size = new Size(100, 46);
            button2.TabIndex = 23;
            button2.Text = "BUY";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // seat
            // 
            seat.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seat.Location = new Point(223, 245);
            seat.Name = "seat";
            seat.Size = new Size(268, 30);
            seat.TabIndex = 20;
            seat.Text = "Click Here!";
            seat.UseVisualStyleBackColor = true;
            seat.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(26, 245);
            label5.Name = "label5";
            label5.Size = new Size(142, 30);
            label5.TabIndex = 19;
            label5.Text = "Select Seats";
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "8:00AM", "1:00PM", "8:00PM" });
            comboBox3.Location = new Point(223, 192);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(268, 29);
            comboBox3.TabIndex = 18;
            comboBox3.Text = "-----SELECT TIME-----";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(26, 189);
            label4.Name = "label4";
            label4.Size = new Size(141, 30);
            label4.TabIndex = 17;
            label4.Text = "Select Time";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "20Feb,2024", "21Feb,2024" });
            comboBox2.Location = new Point(223, 140);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(268, 29);
            comboBox2.TabIndex = 16;
            comboBox2.Text = "-----SELECT DATE-----";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(26, 137);
            label3.Name = "label3";
            label3.Size = new Size(136, 30);
            label3.TabIndex = 15;
            label3.Text = "Select Date";
            // 
            // s_movie
            // 
            s_movie.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            s_movie.FormattingEnabled = true;
            s_movie.Location = new Point(223, 87);
            s_movie.Name = "s_movie";
            s_movie.Size = new Size(268, 29);
            s_movie.TabIndex = 14;
            s_movie.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(26, 84);
            label2.Name = "label2";
            label2.Size = new Size(151, 30);
            label2.TabIndex = 13;
            label2.Text = "Select Movie";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Cambria", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(193, 13);
            label1.Name = "label1";
            label1.Size = new Size(170, 39);
            label1.TabIndex = 12;
            label1.Text = "Buy Movie";
            // 
            // buymovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(800, 487);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(164, 0);
            Name = "buymovie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "buymovie";
            Load += buymovie_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button seat;
        private Label label5;
        private ComboBox comboBox3;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
        private ComboBox s_movie;
        private Label label2;
        private Label label1;
    }
}