﻿namespace M_T
{
    partial class AddMovie
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            m_n = new TextBox();
            price = new TextBox();
            releasedate = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Cambria", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(362, 30);
            label1.Name = "label1";
            label1.Size = new Size(145, 34);
            label1.TabIndex = 0;
            label1.Text = "Add Movie";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(213, 107);
            label2.Name = "label2";
            label2.Size = new Size(123, 24);
            label2.TabIndex = 1;
            label2.Text = " Movie Name";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(214, 178);
            label3.Name = "label3";
            label3.Size = new Size(58, 24);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.BorderStyle = BorderStyle.Fixed3D;
            label4.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(214, 255);
            label4.Name = "label4";
            label4.Size = new Size(124, 24);
            label4.TabIndex = 3;
            label4.Text = "Release Date";
            // 
            // m_n
            // 
            m_n.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            m_n.Location = new Point(408, 108);
            m_n.Name = "m_n";
            m_n.Size = new Size(333, 35);
            m_n.TabIndex = 4;
            // 
            // price
            // 
            price.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            price.Location = new Point(408, 179);
            price.Name = "price";
            price.Size = new Size(333, 35);
            price.TabIndex = 5;
            // 
            // releasedate
            // 
            releasedate.CustomFormat = "yyyy-MM-dd";
            releasedate.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            releasedate.Format = DateTimePickerFormat.Custom;
            releasedate.Location = new Point(408, 255);
            releasedate.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            releasedate.Name = "releasedate";
            releasedate.Size = new Size(333, 35);
            releasedate.TabIndex = 6;
            releasedate.Value = new DateTime(2024, 2, 12, 8, 14, 4, 0);
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 0, 64);
            button1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(666, 369);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(906, 435);
            Controls.Add(button1);
            Controls.Add(releasedate);
            Controls.Add(price);
            Controls.Add(m_n);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMovie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMovie";
            Load += AddMovie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox m_n;
        private TextBox price;
        private DateTimePicker releasedate;
        private Button button1;
        private PictureBox pictureBox1;
    }
}