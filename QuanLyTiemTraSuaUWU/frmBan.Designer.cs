
namespace QuanLyTiemTraSuaUWU
{
    partial class frmBan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoaBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnDong = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientTileButton1 = new Guna.UI2.WinForms.Guna2GradientTileButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chklsbBanTrong = new System.Windows.Forms.CheckedListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chklsbBanDangSD = new System.Windows.Forms.CheckedListBox();
            this.txtNhapTenBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Tên Bàn:";
            // 
            // btnThemBan
            // 
            this.btnThemBan.BorderRadius = 12;
            this.btnThemBan.CheckedState.Parent = this.btnThemBan;
            this.btnThemBan.CustomImages.Parent = this.btnThemBan;
            this.btnThemBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemBan.DisabledState.Parent = this.btnThemBan;
            this.btnThemBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemBan.ForeColor = System.Drawing.Color.White;
            this.btnThemBan.HoverState.Parent = this.btnThemBan;
            this.btnThemBan.Location = new System.Drawing.Point(557, 72);
            this.btnThemBan.Name = "btnThemBan";
            this.btnThemBan.ShadowDecoration.Parent = this.btnThemBan;
            this.btnThemBan.Size = new System.Drawing.Size(107, 45);
            this.btnThemBan.TabIndex = 2;
            this.btnThemBan.Text = "Thêm Bàn";
            this.btnThemBan.Click += new System.EventHandler(this.btnThemBan_Click);
            // 
            // btnXoaBan
            // 
            this.btnXoaBan.BorderRadius = 12;
            this.btnXoaBan.CheckedState.Parent = this.btnXoaBan;
            this.btnXoaBan.CustomImages.Parent = this.btnXoaBan;
            this.btnXoaBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaBan.DisabledState.Parent = this.btnXoaBan;
            this.btnXoaBan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoaBan.ForeColor = System.Drawing.Color.White;
            this.btnXoaBan.HoverState.Parent = this.btnXoaBan;
            this.btnXoaBan.Location = new System.Drawing.Point(434, 382);
            this.btnXoaBan.Name = "btnXoaBan";
            this.btnXoaBan.ShadowDecoration.Parent = this.btnXoaBan;
            this.btnXoaBan.Size = new System.Drawing.Size(107, 45);
            this.btnXoaBan.TabIndex = 2;
            this.btnXoaBan.Text = "Xóa Bàn";
            this.btnXoaBan.Click += new System.EventHandler(this.btnXoaBan_Click);
            // 
            // btnDong
            // 
            this.btnDong.BorderRadius = 12;
            this.btnDong.CheckedState.Parent = this.btnDong;
            this.btnDong.CustomImages.Parent = this.btnDong;
            this.btnDong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDong.DisabledState.Parent = this.btnDong;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.HoverState.Parent = this.btnDong;
            this.btnDong.Location = new System.Drawing.Point(601, 382);
            this.btnDong.Name = "btnDong";
            this.btnDong.ShadowDecoration.Parent = this.btnDong;
            this.btnDong.Size = new System.Drawing.Size(107, 45);
            this.btnDong.TabIndex = 2;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // guna2GradientTileButton1
            // 
            this.guna2GradientTileButton1.CheckedState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.CustomImages.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientTileButton1.DisabledState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2GradientTileButton1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientTileButton1.ForeColor = System.Drawing.Color.Yellow;
            this.guna2GradientTileButton1.HoverState.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientTileButton1.Name = "guna2GradientTileButton1";
            this.guna2GradientTileButton1.ShadowDecoration.Parent = this.guna2GradientTileButton1;
            this.guna2GradientTileButton1.Size = new System.Drawing.Size(800, 56);
            this.guna2GradientTileButton1.TabIndex = 3;
            this.guna2GradientTileButton1.Text = "Quản Lý Bàn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chklsbBanTrong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 214);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Bàn Trống";
            // 
            // chklsbBanTrong
            // 
            this.chklsbBanTrong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklsbBanTrong.FormattingEnabled = true;
            this.chklsbBanTrong.Location = new System.Drawing.Point(3, 23);
            this.chklsbBanTrong.Name = "chklsbBanTrong";
            this.chklsbBanTrong.Size = new System.Drawing.Size(293, 188);
            this.chklsbBanTrong.TabIndex = 0;
            this.chklsbBanTrong.SelectedIndexChanged += new System.EventHandler(this.chklsbBanTrong_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chklsbBanDangSD);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(409, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 214);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bàn Đang Sử Dụng";
            // 
            // chklsbBanDangSD
            // 
            this.chklsbBanDangSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chklsbBanDangSD.FormattingEnabled = true;
            this.chklsbBanDangSD.Location = new System.Drawing.Point(3, 23);
            this.chklsbBanDangSD.Name = "chklsbBanDangSD";
            this.chklsbBanDangSD.Size = new System.Drawing.Size(293, 188);
            this.chklsbBanDangSD.TabIndex = 0;
            this.chklsbBanDangSD.SelectedIndexChanged += new System.EventHandler(this.chklsbBanDangSD_SelectedIndexChanged);
            // 
            // txtNhapTenBan
            // 
            this.txtNhapTenBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhapTenBan.DefaultText = "";
            this.txtNhapTenBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNhapTenBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNhapTenBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapTenBan.DisabledState.Parent = this.txtNhapTenBan;
            this.txtNhapTenBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNhapTenBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapTenBan.FocusedState.Parent = this.txtNhapTenBan;
            this.txtNhapTenBan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTenBan.ForeColor = System.Drawing.Color.Black;
            this.txtNhapTenBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNhapTenBan.HoverState.Parent = this.txtNhapTenBan;
            this.txtNhapTenBan.Location = new System.Drawing.Point(232, 80);
            this.txtNhapTenBan.Name = "txtNhapTenBan";
            this.txtNhapTenBan.PasswordChar = '\0';
            this.txtNhapTenBan.PlaceholderText = "";
            this.txtNhapTenBan.SelectedText = "";
            this.txtNhapTenBan.ShadowDecoration.Parent = this.txtNhapTenBan;
            this.txtNhapTenBan.Size = new System.Drawing.Size(309, 36);
            this.txtNhapTenBan.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.txtNhapTenBan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.guna2GradientTileButton1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoaBan);
            this.Controls.Add(this.btnThemBan);
            this.Controls.Add(this.label1);
            this.Name = "frmBan";
            this.Text = "frmBan";
            this.Load += new System.EventHandler(this.frmBan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnThemBan;
        private Guna.UI2.WinForms.Guna2Button btnXoaBan;
        private Guna.UI2.WinForms.Guna2Button btnDong;
        private Guna.UI2.WinForms.Guna2GradientTileButton guna2GradientTileButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox chklsbBanTrong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox chklsbBanDangSD;
        private Guna.UI2.WinForms.Guna2TextBox txtNhapTenBan;
        private System.Windows.Forms.Timer timer1;
    }
}