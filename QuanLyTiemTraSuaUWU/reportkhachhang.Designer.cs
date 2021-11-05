
namespace QuanLyTiemTraSuaUWU
{
    partial class reportkhachhang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnintatca = new Guna.UI2.WinForms.Guna2Button();
            this.btnintheoma = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbmakhachhang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnintatca);
            this.groupBox1.Controls.Add(this.btnintheoma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbmakhachhang);
            this.groupBox1.Location = new System.Drawing.Point(74, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 121);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chức năng";
            // 
            // btnintatca
            // 
            this.btnintatca.Animated = true;
            this.btnintatca.BorderRadius = 4;
            this.btnintatca.BorderThickness = 2;
            this.btnintatca.CheckedState.Parent = this.btnintatca;
            this.btnintatca.CustomImages.Parent = this.btnintatca;
            this.btnintatca.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnintatca.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnintatca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnintatca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnintatca.DisabledState.Parent = this.btnintatca;
            this.btnintatca.FillColor = System.Drawing.Color.Aqua;
            this.btnintatca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnintatca.ForeColor = System.Drawing.Color.Black;
            this.btnintatca.HoverState.Parent = this.btnintatca;
            this.btnintatca.Location = new System.Drawing.Point(398, 79);
            this.btnintatca.Name = "btnintatca";
            this.btnintatca.ShadowDecoration.Parent = this.btnintatca;
            this.btnintatca.Size = new System.Drawing.Size(228, 36);
            this.btnintatca.TabIndex = 9;
            this.btnintatca.Text = "In tất cả";
            this.btnintatca.Click += new System.EventHandler(this.btnintatca_Click);
            // 
            // btnintheoma
            // 
            this.btnintheoma.Animated = true;
            this.btnintheoma.BorderRadius = 4;
            this.btnintheoma.BorderThickness = 2;
            this.btnintheoma.CheckedState.Parent = this.btnintheoma;
            this.btnintheoma.CustomImages.Parent = this.btnintheoma;
            this.btnintheoma.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnintheoma.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnintheoma.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnintheoma.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnintheoma.DisabledState.Parent = this.btnintheoma;
            this.btnintheoma.FillColor = System.Drawing.Color.Aqua;
            this.btnintheoma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnintheoma.ForeColor = System.Drawing.Color.Black;
            this.btnintheoma.HoverState.Parent = this.btnintheoma;
            this.btnintheoma.Location = new System.Drawing.Point(398, 37);
            this.btnintheoma.Name = "btnintheoma";
            this.btnintheoma.ShadowDecoration.Parent = this.btnintheoma;
            this.btnintheoma.Size = new System.Drawing.Size(228, 36);
            this.btnintheoma.TabIndex = 8;
            this.btnintheoma.Text = "In theo mã khách hàng";
            this.btnintheoma.Click += new System.EventHandler(this.btnintheoma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã khách hàng";
            // 
            // cbbmakhachhang
            // 
            this.cbbmakhachhang.BackColor = System.Drawing.Color.Transparent;
            this.cbbmakhachhang.BorderColor = System.Drawing.Color.Black;
            this.cbbmakhachhang.BorderRadius = 4;
            this.cbbmakhachhang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbmakhachhang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmakhachhang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbmakhachhang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbmakhachhang.FocusedState.Parent = this.cbbmakhachhang;
            this.cbbmakhachhang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbmakhachhang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbmakhachhang.HoverState.Parent = this.cbbmakhachhang;
            this.cbbmakhachhang.ItemHeight = 30;
            this.cbbmakhachhang.ItemsAppearance.Parent = this.cbbmakhachhang;
            this.cbbmakhachhang.Location = new System.Drawing.Point(156, 37);
            this.cbbmakhachhang.Name = "cbbmakhachhang";
            this.cbbmakhachhang.ShadowDecoration.Parent = this.cbbmakhachhang;
            this.cbbmakhachhang.Size = new System.Drawing.Size(222, 36);
            this.cbbmakhachhang.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(74, 158);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(653, 280);
            this.reportViewer1.TabIndex = 2;
            // 
            // reportkhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportkhachhang";
            this.Text = "reportkhachhang";
            this.Load += new System.EventHandler(this.reportkhachhang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnintatca;
        private Guna.UI2.WinForms.Guna2Button btnintheoma;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbmakhachhang;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}