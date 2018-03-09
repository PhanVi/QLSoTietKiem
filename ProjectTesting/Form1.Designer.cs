namespace ProjectTesting
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblHeader = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sổTiếtKiệmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởSổTiếtKiệmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuGửiTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuRútTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.PeachPuff;
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblHeader.Location = new System.Drawing.Point(0, 47);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(546, 65);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "QUẢN LÝ SỔ TIẾT KIỆM";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProjectTesting.Properties.Resources.gui_tiet_kiem;
            this.pictureBox1.Location = new System.Drawing.Point(0, 112);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(546, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sổTiếtKiệmToolStripMenuItem,
            this.phiếuGửiTiềnToolStripMenuItem,
            this.phiếuRútTiềnToolStripMenuItem,
            this.thốngKêToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 47);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sổTiếtKiệmToolStripMenuItem
            // 
            this.sổTiếtKiệmToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.sổTiếtKiệmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mởSổTiếtKiệmToolStripMenuItem});
            this.sổTiếtKiệmToolStripMenuItem.Name = "sổTiếtKiệmToolStripMenuItem";
            this.sổTiếtKiệmToolStripMenuItem.Size = new System.Drawing.Size(81, 43);
            this.sổTiếtKiệmToolStripMenuItem.Text = "Sổ tiết kiệm";
            // 
            // mởSổTiếtKiệmToolStripMenuItem
            // 
            this.mởSổTiếtKiệmToolStripMenuItem.Name = "mởSổTiếtKiệmToolStripMenuItem";
            this.mởSổTiếtKiệmToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.mởSổTiếtKiệmToolStripMenuItem.Text = "Mở sổ tiết kiệm";
            this.mởSổTiếtKiệmToolStripMenuItem.Click += new System.EventHandler(this.mởSổTiếtKiệmToolStripMenuItem_Click);
            // 
            // phiếuGửiTiềnToolStripMenuItem
            // 
            this.phiếuGửiTiềnToolStripMenuItem.Name = "phiếuGửiTiềnToolStripMenuItem";
            this.phiếuGửiTiềnToolStripMenuItem.Size = new System.Drawing.Size(92, 43);
            this.phiếuGửiTiềnToolStripMenuItem.Text = "Phiếu gửi tiền";
            // 
            // phiếuRútTiềnToolStripMenuItem
            // 
            this.phiếuRútTiềnToolStripMenuItem.Name = "phiếuRútTiềnToolStripMenuItem";
            this.phiếuRútTiềnToolStripMenuItem.Size = new System.Drawing.Size(90, 43);
            this.phiếuRútTiềnToolStripMenuItem.Text = "Phiếu rút tiền";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(69, 43);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(50, 43);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 375);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý sổ tiết kiệm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sổTiếtKiệmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mởSổTiếtKiệmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuGửiTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuRútTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

