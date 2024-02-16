namespace M_T
{
    partial class admin_dasboard
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
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            addmovie = new Button();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            panel3 = new Panel();
            changepanel = new Panel();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            changepanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(906, 92);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(377, 33);
            label2.Name = "label2";
            label2.Size = new Size(187, 34);
            label2.TabIndex = 5;
            label2.Text = "Movie Ticketing";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(803, 51);
            label3.Name = "label3";
            label3.Size = new Size(91, 34);
            label3.TabIndex = 4;
            label3.Text = "Logout";
            label3.Click += label3_Click;
            // 
            // addmovie
            // 
            addmovie.BackColor = Color.Black;
            addmovie.FlatStyle = FlatStyle.Flat;
            addmovie.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addmovie.ForeColor = SystemColors.Control;
            addmovie.Location = new Point(12, 1);
            addmovie.Name = "addmovie";
            addmovie.Size = new Size(120, 35);
            addmovie.TabIndex = 0;
            addmovie.Text = "Add Movie";
            addmovie.UseVisualStyleBackColor = false;
            addmovie.Click += addmovie_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(156, 1);
            button1.Name = "button1";
            button1.Size = new Size(100, 35);
            button1.TabIndex = 1;
            button1.Text = "Trailer";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Location = new Point(284, 1);
            button2.Name = "button2";
            button2.Size = new Size(75, 35);
            button2.TabIndex = 2;
            button2.Text = "Chat";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(272, 193);
            label1.Name = "label1";
            label1.Size = new Size(314, 34);
            label1.TabIndex = 6;
            label1.Text = "Welcome Admin Dashboard";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(changepanel);
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Fill;
            panel3.ForeColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(0, 92);
            panel3.Name = "panel3";
            panel3.Size = new Size(906, 471);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // changepanel
            // 
            changepanel.Controls.Add(label1);
            changepanel.Dock = DockStyle.Fill;
            changepanel.Location = new Point(0, 36);
            changepanel.Name = "changepanel";
            changepanel.Size = new Size(906, 435);
            changepanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(addmovie);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(906, 36);
            panel1.TabIndex = 0;
            // 
            // admin_dasboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(906, 563);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_dasboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_dasboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            changepanel.ResumeLayout(false);
            changepanel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button2;
        private Button button1;
        private Button addmovie;
        private Panel panel3;
        private Panel panel1;
        private Panel changepanel;
    }
}