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
            this.menuSoTietKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMoSoTietKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongTinKH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhieuGui = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPhieuRut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThoat = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuSoTietKiem,
            this.menuPhieuGui,
            this.menuPhieuRut,
            this.menuThongKe,
            this.menuThoat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 47);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuSoTietKiem
            // 
            this.menuSoTietKiem.BackColor = System.Drawing.Color.SandyBrown;
            this.menuSoTietKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMoSoTietKiem,
            this.menuThongTinKH});
            this.menuSoTietKiem.Name = "menuSoTietKiem";
            this.menuSoTietKiem.Size = new System.Drawing.Size(81, 43);
            this.menuSoTietKiem.Text = "Sổ tiết kiệm";
            // 
            // menuMoSoTietKiem
            // 
            this.menuMoSoTietKiem.BackColor = System.Drawing.Color.Orange;
            this.menuMoSoTietKiem.Name = "menuMoSoTietKiem";
            this.menuMoSoTietKiem.Size = new System.Drawing.Size(197, 22);
            this.menuMoSoTietKiem.Text = "Mở sổ tiết kiệm";
            this.menuMoSoTietKiem.Click += new System.EventHandler(this.menuMoSoTietKiem_Click);
            // 
            // menuThongTinKH
            // 
            this.menuThongTinKH.BackColor = System.Drawing.Color.Orange;
            this.menuThongTinKH.Name = "menuThongTinKH";
            this.menuThongTinKH.Size = new System.Drawing.Size(197, 22);
            this.menuThongTinKH.Text = "Thông Tin Khách Hàng";
            this.menuThongTinKH.Click += new System.EventHandler(this.menuThongTinKH_Click_1);
            // 
            // menuPhieuGui
            // 
            this.menuPhieuGui.Name = "menuPhieuGui";
            this.menuPhieuGui.Size = new System.Drawing.Size(92, 43);
            this.menuPhieuGui.Text = "Phiếu gửi tiền";
            this.menuPhieuGui.Click += new System.EventHandler(this.menuPhieuGui_Click);
            // 
            // menuPhieuRut
            // 
            this.menuPhieuRut.Name = "menuPhieuRut";
            this.menuPhieuRut.Size = new System.Drawing.Size(90, 43);
            this.menuPhieuRut.Text = "Phiếu rút tiền";
            this.menuPhieuRut.Click += new System.EventHandler(this.menuPhieuRut_Click);
            // 
            // menuThongKe
            // 
            this.menuThongKe.Name = "menuThongKe";
            this.menuThongKe.Size = new System.Drawing.Size(69, 43);
            this.menuThongKe.Text = "Thống kê";
            this.menuThongKe.Click += new System.EventHandler(this.menuThongKe_Click);
            // 
            // menuThoat
            // 
            this.menuThoat.Name = "menuThoat";
            this.menuThoat.Size = new System.Drawing.Size(50, 43);
            this.menuThoat.Text = "Thoát";
            this.menuThoat.Click += new System.EventHandler(this.menuThoat_Click_1);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.ToolStripMenuItem menuSoTietKiem;
        private System.Windows.Forms.ToolStripMenuItem menuMoSoTietKiem;
        private System.Windows.Forms.ToolStripMenuItem menuPhieuGui;
        private System.Windows.Forms.ToolStripMenuItem menuThongKe;
        private System.Windows.Forms.ToolStripMenuItem menuThoat;
        private System.Windows.Forms.ToolStripMenuItem menuThongTinKH;
        private System.Windows.Forms.ToolStripMenuItem menuPhieuRut;
    }
}

