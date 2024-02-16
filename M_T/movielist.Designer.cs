namespace M_T
{
    partial class movielist
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
            movie_list = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)movie_list).BeginInit();
            SuspendLayout();
            // 
            // movie_list
            // 
            movie_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            movie_list.Location = new Point(12, 53);
            movie_list.Name = "movie_list";
            movie_list.Size = new Size(506, 295);
            movie_list.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(238, 14);
            label1.Name = "label1";
            label1.Size = new Size(127, 30);
            label1.TabIndex = 1;
            label1.Text = "Movie List";
            // 
            // movielist
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(611, 450);
            Controls.Add(label1);
            Controls.Add(movie_list);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(164, 0);
            Name = "movielist";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "movielist";
            Load += movielist_Load;
            ((System.ComponentModel.ISupportInitialize)movie_list).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView movie_list;
        private Label label1;
    }
}