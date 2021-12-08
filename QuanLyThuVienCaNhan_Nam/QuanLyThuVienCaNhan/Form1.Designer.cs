
namespace QuanLyThuVienCaNhan
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMuonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTraSach = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.DanhSachTheLoai = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdNXB = new System.Windows.Forms.RadioButton();
            this.rdTacGia = new System.Windows.Forms.RadioButton();
            this.rdSach = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmThem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMuonSach,
            this.tsmiTraSach,
            this.xoaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(151, 76);
            // 
            // tsmiMuonSach
            // 
            this.tsmiMuonSach.Name = "tsmiMuonSach";
            this.tsmiMuonSach.Size = new System.Drawing.Size(150, 24);
            this.tsmiMuonSach.Text = "Mượn sách";
            this.tsmiMuonSach.Click += new System.EventHandler(this.tsmiMuonSach_Click);
            // 
            // tsmiTraSach
            // 
            this.tsmiTraSach.Name = "tsmiTraSach";
            this.tsmiTraSach.Size = new System.Drawing.Size(150, 24);
            this.tsmiTraSach.Text = "Trả sách";
            this.tsmiTraSach.Click += new System.EventHandler(this.tsmiTraSach_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.xoaToolStripMenuItem.Text = "Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(785, 28);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(376, 33);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // DanhSachTheLoai
            // 
            this.DanhSachTheLoai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DanhSachTheLoai.BackgroundImage")));
            this.DanhSachTheLoai.Location = new System.Drawing.Point(0, 21);
            this.DanhSachTheLoai.Name = "DanhSachTheLoai";
            this.DanhSachTheLoai.Size = new System.Drawing.Size(334, 600);
            this.DanhSachTheLoai.TabIndex = 0;
            this.DanhSachTheLoai.Paint += new System.Windows.Forms.PaintEventHandler(this.DanhSachTheLoai_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.DanhSachTheLoai);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(20, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 621);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thể loại";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.rdNXB);
            this.panel1.Controls.Add(this.rdTacGia);
            this.panel1.Controls.Add(this.rdSach);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1374, 709);
            this.panel1.TabIndex = 2;
            // 
            // rdNXB
            // 
            this.rdNXB.AutoSize = true;
            this.rdNXB.BackColor = System.Drawing.Color.DarkOrchid;
            this.rdNXB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdNXB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdNXB.Location = new System.Drawing.Point(634, 31);
            this.rdNXB.Name = "rdNXB";
            this.rdNXB.Size = new System.Drawing.Size(127, 30);
            this.rdNXB.TabIndex = 14;
            this.rdNXB.TabStop = true;
            this.rdNXB.Text = "Tên NXB";
            this.rdNXB.UseVisualStyleBackColor = false;
            // 
            // rdTacGia
            // 
            this.rdTacGia.AutoSize = true;
            this.rdTacGia.BackColor = System.Drawing.Color.DarkOrchid;
            this.rdTacGia.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTacGia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdTacGia.Location = new System.Drawing.Point(457, 31);
            this.rdTacGia.Name = "rdTacGia";
            this.rdTacGia.Size = new System.Drawing.Size(146, 30);
            this.rdTacGia.TabIndex = 14;
            this.rdTacGia.TabStop = true;
            this.rdTacGia.Text = "Tên tác giả";
            this.rdTacGia.UseVisualStyleBackColor = false;
            // 
            // rdSach
            // 
            this.rdSach.AutoSize = true;
            this.rdSach.BackColor = System.Drawing.Color.DarkOrchid;
            this.rdSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdSach.Location = new System.Drawing.Point(300, 31);
            this.rdSach.Name = "rdSach";
            this.rdSach.Size = new System.Drawing.Size(123, 30);
            this.rdSach.TabIndex = 14;
            this.rdSach.TabStop = true;
            this.rdSach.Text = "Tên sách";
            this.rdSach.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.lsvDanhSach);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(371, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1397, 621);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lsvDanhSach.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(0, 0);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(1353, 594);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            this.lsvDanhSach.DoubleClick += new System.EventHandler(this.lsvDanhSach_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sách";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sách";
            this.columnHeader2.Width = 82;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thể loại";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tác giả";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Nhà xuất bản";
            this.columnHeader5.Width = 91;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Năm xuất bản";
            this.columnHeader6.Width = 135;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Kệ sách";
            this.columnHeader7.Width = 109;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Ngăn";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Trạng thái";
            this.columnHeader9.Width = 134;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Hình ảnh";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmThem,
            this.tsmThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1374, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmThem
            // 
            this.tsmThem.Name = "tsmThem";
            this.tsmThem.Size = new System.Drawing.Size(90, 24);
            this.tsmThem.Text = "Thêm mới";
            this.tsmThem.Click += new System.EventHandler(this.tsmThem_Click);
            // 
            // tsmThongKe
            // 
            this.tsmThongKe.Name = "tsmThongKe";
            this.tsmThongKe.Size = new System.Drawing.Size(84, 24);
            this.tsmThongKe.Text = "Thống kê";
            this.tsmThongKe.Click += new System.EventHandler(this.tsmThongKe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1629, 712);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMuonSach;
        private System.Windows.Forms.ToolStripMenuItem tsmiTraSach;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel DanhSachTheLoai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmThem;
        private System.Windows.Forms.ToolStripMenuItem tsmThongKe;
        private System.Windows.Forms.RadioButton rdNXB;
        private System.Windows.Forms.RadioButton rdTacGia;
        private System.Windows.Forms.RadioButton rdSach;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}

