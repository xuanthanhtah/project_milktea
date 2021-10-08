
namespace QuanLyTiemTraSuaUWU
{
    partial class frmmain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bÀNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.qUẢNLÝToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hÓAĐƠNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem,
            this.bÀNToolStripMenuItem,
            this.qUẢNLÝToolStripMenuItem,
            this.hÓAĐƠNToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 45);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(108, 41);
            this.mENUToolStripMenuItem.Text = "MENU";
            this.mENUToolStripMenuItem.Click += new System.EventHandler(this.mENUToolStripMenuItem_Click);
            // 
            // bÀNToolStripMenuItem
            // 
            this.bÀNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.bÀNToolStripMenuItem.Name = "bÀNToolStripMenuItem";
            this.bÀNToolStripMenuItem.Size = new System.Drawing.Size(83, 41);
            this.bÀNToolStripMenuItem.Text = "BÀN";
            // 
            // qUẢNLÝToolStripMenuItem
            // 
            this.qUẢNLÝToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.qUẢNLÝToolStripMenuItem.Name = "qUẢNLÝToolStripMenuItem";
            this.qUẢNLÝToolStripMenuItem.Size = new System.Drawing.Size(140, 41);
            this.qUẢNLÝToolStripMenuItem.Text = "QUẢN LÝ";
            // 
            // hÓAĐƠNToolStripMenuItem
            // 
            this.hÓAĐƠNToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.hÓAĐƠNToolStripMenuItem.Name = "hÓAĐƠNToolStripMenuItem";
            this.hÓAĐƠNToolStripMenuItem.Size = new System.Drawing.Size(153, 41);
            this.hÓAĐƠNToolStripMenuItem.Text = "HÓA ĐƠN";
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 579);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmmain";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.Click += new System.EventHandler(this.frmmain_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bÀNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem qUẢNLÝToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hÓAĐƠNToolStripMenuItem;
    }
}