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
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            addmovie = new Button();
            panel4 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 321);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 90);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(760, 100);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(239, 55);
            label2.Name = "label2";
            label2.Size = new Size(185, 32);
            label2.TabIndex = 5;
            label2.Text = "Movie Ticketing";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(671, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 32);
            label3.TabIndex = 4;
            label3.Text = "Logout";
            label3.Click += label3_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(addmovie);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(760, 47);
            panel3.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(219, 9);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Chat";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(138, 10);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Review";
            button1.UseVisualStyleBackColor = true;
            // 
            // addmovie
            // 
            addmovie.Location = new Point(57, 11);
            addmovie.Name = "addmovie";
            addmovie.Size = new Size(75, 23);
            addmovie.TabIndex = 0;
            addmovie.Text = "Add Movie";
            addmovie.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(0, 0, 64);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 147);
            panel4.Name = "panel4";
            panel4.Size = new Size(760, 174);
            panel4.TabIndex = 2;
            // 
            // admin_dasboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 411);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "admin_dasboard";
            Text = "admin_dasboard";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Button addmovie;
        private Button button2;
    }
}