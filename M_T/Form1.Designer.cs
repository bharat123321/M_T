namespace M_T
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            rememberbox = new CheckBox();
            reg = new Button();
            log = new Button();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(5, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(513, 72);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(231, 24);
            label1.Name = "label1";
            label1.Size = new Size(75, 34);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe MDL2 Assets", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(490, 8);
            label2.Name = "label2";
            label2.Size = new Size(23, 24);
            label2.TabIndex = 2;
            label2.Text = "X";
            label2.Click += label2_Click;
            label2.MouseClick += label2_MouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(rememberbox);
            panel2.Controls.Add(reg);
            panel2.Controls.Add(log);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(5, 79);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 237);
            panel2.TabIndex = 1;
            // 
            // rememberbox
            // 
            rememberbox.AutoSize = true;
            rememberbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rememberbox.ForeColor = SystemColors.ButtonFace;
            rememberbox.Location = new Point(246, 125);
            rememberbox.Name = "rememberbox";
            rememberbox.Size = new Size(168, 34);
            rememberbox.TabIndex = 10;
            rememberbox.Text = "Remember Me";
            rememberbox.UseVisualStyleBackColor = true;
            // 
            // reg
            // 
            reg.Location = new Point(339, 187);
            reg.Name = "reg";
            reg.Size = new Size(75, 28);
            reg.TabIndex = 9;
            reg.Text = "Register";
            reg.UseVisualStyleBackColor = true;
            reg.Click += reg_Click_1;
            // 
            // log
            // 
            log.Location = new Point(198, 187);
            log.Name = "log";
            log.Size = new Size(75, 23);
            log.TabIndex = 8;
            log.Text = "Login";
            log.UseVisualStyleBackColor = true;
            log.Click += log_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(231, 86);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(266, 33);
            textBox2.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(50, 83);
            label4.Name = "label4";
            label4.Size = new Size(111, 32);
            label4.TabIndex = 6;
            label4.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(231, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(266, 33);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(50, 18);
            label3.Name = "label3";
            label3.Size = new Size(71, 32);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.movieticketing;
            pictureBox1.Location = new Point(21, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 316);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Label label3;
        private Button reg;
        private Button log;
        private TextBox textBox2;
        private Label label4;
        private CheckBox rememberbox;
        private PictureBox pictureBox1;
    }
}
