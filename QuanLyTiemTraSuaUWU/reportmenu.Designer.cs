
namespace QuanLyTiemTraSuaUWU
{
    partial class reportmenu
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
            this.cbbmamonan = new Guna.UI2.WinForms.Guna2ComboBox();
            this.rpvmenu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnintatca);
            this.groupBox1.Controls.Add(this.btnintheoma);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbmamonan);
            this.groupBox1.Location = new System.Drawing.Point(46, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(704, 121);
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
            this.btnintatca.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnintatca.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnintatca.ForeColor = System.Drawing.Color.Black;
            this.btnintatca.HoverState.Parent = this.btnintatca;
            this.btnintatca.Location = new System.Drawing.Point(410, 85);
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
            this.btnintheoma.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnintheoma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnintheoma.ForeColor = System.Drawing.Color.Black;
            this.btnintheoma.HoverState.Parent = this.btnintheoma;
            this.btnintheoma.Location = new System.Drawing.Point(410, 37);
            this.btnintheoma.Name = "btnintheoma";
            this.btnintheoma.ShadowDecoration.Parent = this.btnintheoma;
            this.btnintheoma.Size = new System.Drawing.Size(228, 36);
            this.btnintheoma.TabIndex = 8;
            this.btnintheoma.Text = "In theo loại món";
            this.btnintheoma.Click += new System.EventHandler(this.btnintheoma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Loại món";
            // 
            // cbbmamonan
            // 
            this.cbbmamonan.BackColor = System.Drawing.Color.Transparent;
            this.cbbmamonan.BorderColor = System.Drawing.Color.Black;
            this.cbbmamonan.BorderRadius = 4;
            this.cbbmamonan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbmamonan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmamonan.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbmamonan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbmamonan.FocusedState.Parent = this.cbbmamonan;
            this.cbbmamonan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbmamonan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbmamonan.HoverState.Parent = this.cbbmamonan;
            this.cbbmamonan.ItemHeight = 30;
            this.cbbmamonan.Items.AddRange(new object[] {
            "cafe",
            "nuocngot",
            "thucanvat",
            "traicayep",
            "trasua"});
            this.cbbmamonan.ItemsAppearance.Parent = this.cbbmamonan;
            this.cbbmamonan.Location = new System.Drawing.Point(142, 37);
            this.cbbmamonan.Name = "cbbmamonan";
            this.cbbmamonan.ShadowDecoration.Parent = this.cbbmamonan;
            this.cbbmamonan.Size = new System.Drawing.Size(222, 36);
            this.cbbmamonan.TabIndex = 0;
            // 
            // rpvmenu
            // 
            this.rpvmenu.Location = new System.Drawing.Point(46, 166);
            this.rpvmenu.Name = "rpvmenu";
            this.rpvmenu.ServerReport.BearerToken = null;
            this.rpvmenu.Size = new System.Drawing.Size(704, 341);
            this.rpvmenu.TabIndex = 4;
            // 
            // reportmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.rpvmenu);
            this.Controls.Add(this.groupBox1);
            this.Name = "reportmenu";
            this.Text = "reportmenu";
            this.Load += new System.EventHandler(this.reportmenu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnintatca;
        private Guna.UI2.WinForms.Guna2Button btnintheoma;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbmamonan;
        private Microsoft.Reporting.WinForms.ReportViewer rpvmenu;
    }
}