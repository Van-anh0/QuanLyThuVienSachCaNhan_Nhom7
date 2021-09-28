
namespace QuayLySachCaNhan_Nhom7
{
    partial class FrmQuanLy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMTra = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTTMT = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDSVP = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QuayLyTuSach_Nhom7.Properties.Resources.book3;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 529);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(8, 419);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 110);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"Cuốn sách tốt nhất cho bạn là cuốn sách nói nhiều nhất với bạn vào lúc bạn đọc n" +
    "ó\"";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSach,
            this.tsmiMTra,
            this.tsmiTTMT,
            this.tsmiDSVP});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // tsmiSach
            // 
            this.tsmiSach.Name = "tsmiSach";
            this.tsmiSach.Size = new System.Drawing.Size(230, 26);
            this.tsmiSach.Text = "Quản lý sách";
            this.tsmiSach.Click += new System.EventHandler(this.tsmiSach_Click);
            // 
            // tsmiMTra
            // 
            this.tsmiMTra.Name = "tsmiMTra";
            this.tsmiMTra.Size = new System.Drawing.Size(230, 26);
            this.tsmiMTra.Text = "Quản lý mượn - trả";
            this.tsmiMTra.Click += new System.EventHandler(this.tsmiMTra_Click);
            // 
            // tsmiTTMT
            // 
            this.tsmiTTMT.Name = "tsmiTTMT";
            this.tsmiTTMT.Size = new System.Drawing.Size(230, 26);
            this.tsmiTTMT.Text = "Thông tin mượn - trả";
            this.tsmiTTMT.Click += new System.EventHandler(this.tsmiTTMT_Click);
            // 
            // tsmiDSVP
            // 
            this.tsmiDSVP.Name = "tsmiDSVP";
            this.tsmiDSVP.Size = new System.Drawing.Size(230, 26);
            this.tsmiDSVP.Text = "Danh sách vi phạm";
            this.tsmiDSVP.Click += new System.EventHandler(this.tsmiDSVP_Click);
            // 
            // FrmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmQuanLy";
            this.Text = "Quản lý";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSach;
        private System.Windows.Forms.ToolStripMenuItem tsmiMTra;
        private System.Windows.Forms.ToolStripMenuItem tsmiTTMT;
        private System.Windows.Forms.ToolStripMenuItem tsmiDSVP;
    }
}