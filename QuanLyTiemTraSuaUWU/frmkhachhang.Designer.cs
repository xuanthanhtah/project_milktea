
namespace QuanLyTiemTraSuaUWU
{
    partial class frmkhachhang
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnreport = new Guna.UI2.WinForms.Guna2Button();
            this.btxthoat = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnthemsua = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbgioitinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtsodienthoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttenkhachhang = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmakhachhang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvkhachhang = new System.Windows.Forms.DataGridView();
            this.dgvmakhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtenkhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnreport);
            this.groupBox2.Controls.Add(this.btxthoat);
            this.groupBox2.Controls.Add(this.btnxoa);
            this.groupBox2.Controls.Add(this.btnthemsua);
            this.groupBox2.Location = new System.Drawing.Point(92, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(832, 75);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "chức năng";
            // 
            // btnreport
            // 
            this.btnreport.Animated = true;
            this.btnreport.BorderRadius = 4;
            this.btnreport.BorderThickness = 2;
            this.btnreport.CheckedState.Parent = this.btnreport;
            this.btnreport.CustomImages.Parent = this.btnreport;
            this.btnreport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnreport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnreport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnreport.DisabledState.Parent = this.btnreport;
            this.btnreport.FillColor = System.Drawing.Color.Aqua;
            this.btnreport.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnreport.ForeColor = System.Drawing.Color.Black;
            this.btnreport.HoverState.Parent = this.btnreport;
            this.btnreport.Location = new System.Drawing.Point(492, 21);
            this.btnreport.Name = "btnreport";
            this.btnreport.ShadowDecoration.Parent = this.btnreport;
            this.btnreport.Size = new System.Drawing.Size(177, 41);
            this.btnreport.TabIndex = 10;
            this.btnreport.Text = "Report";
            this.btnreport.Click += new System.EventHandler(this.btnreport_Click);
            // 
            // btxthoat
            // 
            this.btxthoat.Animated = true;
            this.btxthoat.BorderRadius = 4;
            this.btxthoat.BorderThickness = 2;
            this.btxthoat.CheckedState.Parent = this.btxthoat;
            this.btxthoat.CustomImages.Parent = this.btxthoat;
            this.btxthoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btxthoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btxthoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btxthoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btxthoat.DisabledState.Parent = this.btxthoat;
            this.btxthoat.FillColor = System.Drawing.Color.Aqua;
            this.btxthoat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btxthoat.ForeColor = System.Drawing.Color.Black;
            this.btxthoat.HoverState.Parent = this.btxthoat;
            this.btxthoat.Location = new System.Drawing.Point(708, 21);
            this.btxthoat.Name = "btxthoat";
            this.btxthoat.ShadowDecoration.Parent = this.btxthoat;
            this.btxthoat.Size = new System.Drawing.Size(118, 41);
            this.btxthoat.TabIndex = 7;
            this.btxthoat.Text = "Thoát";
            this.btxthoat.Click += new System.EventHandler(this.btxthoat_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Animated = true;
            this.btnxoa.BorderRadius = 4;
            this.btnxoa.BorderThickness = 2;
            this.btnxoa.CheckedState.Parent = this.btnxoa;
            this.btnxoa.CustomImages.Parent = this.btnxoa;
            this.btnxoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoa.DisabledState.Parent = this.btnxoa;
            this.btnxoa.FillColor = System.Drawing.Color.Aqua;
            this.btnxoa.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.HoverState.Parent = this.btnxoa;
            this.btnxoa.Location = new System.Drawing.Point(283, 21);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.ShadowDecoration.Parent = this.btnxoa;
            this.btnxoa.Size = new System.Drawing.Size(177, 41);
            this.btnxoa.TabIndex = 9;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthemsua
            // 
            this.btnthemsua.Animated = true;
            this.btnthemsua.BorderRadius = 4;
            this.btnthemsua.BorderThickness = 2;
            this.btnthemsua.CheckedState.Parent = this.btnthemsua;
            this.btnthemsua.CustomImages.Parent = this.btnthemsua;
            this.btnthemsua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemsua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemsua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemsua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemsua.DisabledState.Parent = this.btnthemsua;
            this.btnthemsua.FillColor = System.Drawing.Color.Aqua;
            this.btnthemsua.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnthemsua.ForeColor = System.Drawing.Color.Black;
            this.btnthemsua.HoverState.Parent = this.btnthemsua;
            this.btnthemsua.Location = new System.Drawing.Point(79, 21);
            this.btnthemsua.Name = "btnthemsua";
            this.btnthemsua.ShadowDecoration.Parent = this.btnthemsua;
            this.btnthemsua.Size = new System.Drawing.Size(177, 41);
            this.btnthemsua.TabIndex = 7;
            this.btnthemsua.Text = "Thêm / sửa";
            this.btnthemsua.Click += new System.EventHandler(this.btnthemsua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbgioitinh);
            this.groupBox1.Controls.Add(this.txtsodienthoai);
            this.groupBox1.Controls.Add(this.txttenkhachhang);
            this.groupBox1.Controls.Add(this.txtmakhachhang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(90, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 134);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm khách hàng";
            // 
            // cbbgioitinh
            // 
            this.cbbgioitinh.BackColor = System.Drawing.Color.Transparent;
            this.cbbgioitinh.BorderColor = System.Drawing.Color.Black;
            this.cbbgioitinh.BorderRadius = 5;
            this.cbbgioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbgioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbgioitinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbgioitinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbgioitinh.FocusedState.Parent = this.cbbgioitinh;
            this.cbbgioitinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbgioitinh.ForeColor = System.Drawing.Color.Black;
            this.cbbgioitinh.HoverState.Parent = this.cbbgioitinh;
            this.cbbgioitinh.ItemHeight = 30;
            this.cbbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbgioitinh.ItemsAppearance.Parent = this.cbbgioitinh;
            this.cbbgioitinh.Location = new System.Drawing.Point(159, 78);
            this.cbbgioitinh.Name = "cbbgioitinh";
            this.cbbgioitinh.ShadowDecoration.Parent = this.cbbgioitinh;
            this.cbbgioitinh.Size = new System.Drawing.Size(190, 36);
            this.cbbgioitinh.TabIndex = 8;
            this.cbbgioitinh.SelectedIndexChanged += new System.EventHandler(this.cbbgioitinh_SelectedIndexChanged);
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.BorderColor = System.Drawing.Color.Black;
            this.txtsodienthoai.BorderRadius = 5;
            this.txtsodienthoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsodienthoai.DefaultText = "";
            this.txtsodienthoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsodienthoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsodienthoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsodienthoai.DisabledState.Parent = this.txtsodienthoai;
            this.txtsodienthoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsodienthoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsodienthoai.FocusedState.Parent = this.txtsodienthoai;
            this.txtsodienthoai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtsodienthoai.ForeColor = System.Drawing.Color.Black;
            this.txtsodienthoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsodienthoai.HoverState.Parent = this.txtsodienthoai;
            this.txtsodienthoai.Location = new System.Drawing.Point(577, 78);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.PasswordChar = '\0';
            this.txtsodienthoai.PlaceholderText = "";
            this.txtsodienthoai.SelectedText = "";
            this.txtsodienthoai.ShadowDecoration.Parent = this.txtsodienthoai;
            this.txtsodienthoai.Size = new System.Drawing.Size(189, 36);
            this.txtsodienthoai.TabIndex = 7;
            // 
            // txttenkhachhang
            // 
            this.txttenkhachhang.BorderColor = System.Drawing.Color.Black;
            this.txttenkhachhang.BorderRadius = 5;
            this.txttenkhachhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenkhachhang.DefaultText = "";
            this.txttenkhachhang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttenkhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttenkhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenkhachhang.DisabledState.Parent = this.txttenkhachhang;
            this.txttenkhachhang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenkhachhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenkhachhang.FocusedState.Parent = this.txttenkhachhang;
            this.txttenkhachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttenkhachhang.ForeColor = System.Drawing.Color.Black;
            this.txttenkhachhang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenkhachhang.HoverState.Parent = this.txttenkhachhang;
            this.txttenkhachhang.Location = new System.Drawing.Point(577, 21);
            this.txttenkhachhang.Name = "txttenkhachhang";
            this.txttenkhachhang.PasswordChar = '\0';
            this.txttenkhachhang.PlaceholderText = "";
            this.txttenkhachhang.SelectedText = "";
            this.txttenkhachhang.ShadowDecoration.Parent = this.txttenkhachhang;
            this.txttenkhachhang.Size = new System.Drawing.Size(189, 36);
            this.txttenkhachhang.TabIndex = 5;
            // 
            // txtmakhachhang
            // 
            this.txtmakhachhang.BorderColor = System.Drawing.Color.Black;
            this.txtmakhachhang.BorderRadius = 5;
            this.txtmakhachhang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmakhachhang.DefaultText = "";
            this.txtmakhachhang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmakhachhang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmakhachhang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmakhachhang.DisabledState.Parent = this.txtmakhachhang;
            this.txtmakhachhang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmakhachhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmakhachhang.FocusedState.Parent = this.txtmakhachhang;
            this.txtmakhachhang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtmakhachhang.ForeColor = System.Drawing.Color.Black;
            this.txtmakhachhang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmakhachhang.HoverState.Parent = this.txtmakhachhang;
            this.txtmakhachhang.Location = new System.Drawing.Point(159, 30);
            this.txtmakhachhang.Name = "txtmakhachhang";
            this.txtmakhachhang.PasswordChar = '\0';
            this.txtmakhachhang.PlaceholderText = "";
            this.txtmakhachhang.SelectedText = "";
            this.txtmakhachhang.ShadowDecoration.Parent = this.txtmakhachhang;
            this.txtmakhachhang.Size = new System.Drawing.Size(189, 36);
            this.txtmakhachhang.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(448, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // dgvkhachhang
            // 
            this.dgvkhachhang.AllowUserToAddRows = false;
            this.dgvkhachhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvmakhachhang,
            this.dgvtenkhachhang,
            this.dgvgioitinh,
            this.dgvsodienthoai});
            this.dgvkhachhang.Location = new System.Drawing.Point(92, 278);
            this.dgvkhachhang.Name = "dgvkhachhang";
            this.dgvkhachhang.RowHeadersWidth = 51;
            this.dgvkhachhang.RowTemplate.Height = 24;
            this.dgvkhachhang.Size = new System.Drawing.Size(828, 310);
            this.dgvkhachhang.TabIndex = 3;
            this.dgvkhachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkhachhang_CellClick);
            // 
            // dgvmakhachhang
            // 
            this.dgvmakhachhang.HeaderText = "Mã khách hàng";
            this.dgvmakhachhang.MinimumWidth = 6;
            this.dgvmakhachhang.Name = "dgvmakhachhang";
            // 
            // dgvtenkhachhang
            // 
            this.dgvtenkhachhang.HeaderText = "Tên khách hàng";
            this.dgvtenkhachhang.MinimumWidth = 6;
            this.dgvtenkhachhang.Name = "dgvtenkhachhang";
            // 
            // dgvgioitinh
            // 
            this.dgvgioitinh.HeaderText = "giới tính";
            this.dgvgioitinh.MinimumWidth = 6;
            this.dgvgioitinh.Name = "dgvgioitinh";
            // 
            // dgvsodienthoai
            // 
            this.dgvsodienthoai.HeaderText = "Số điện thoại";
            this.dgvsodienthoai.MinimumWidth = 6;
            this.dgvsodienthoai.Name = "dgvsodienthoai";
            // 
            // frmkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1029, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvkhachhang);
            this.Name = "frmkhachhang";
            this.Text = "frmkhachhang";
            this.Load += new System.EventHandler(this.frmkhachhang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button btnreport;
        private Guna.UI2.WinForms.Guna2Button btxthoat;
        private Guna.UI2.WinForms.Guna2Button btnxoa;
        private Guna.UI2.WinForms.Guna2Button btnthemsua;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbgioitinh;
        private Guna.UI2.WinForms.Guna2TextBox txtsodienthoai;
        private Guna.UI2.WinForms.Guna2TextBox txttenkhachhang;
        private Guna.UI2.WinForms.Guna2TextBox txtmakhachhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmakhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtenkhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsodienthoai;
    }
}