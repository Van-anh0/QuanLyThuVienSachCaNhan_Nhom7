
namespace QuanLyThuVienCaNhan
{
    partial class test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(test));
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiMuonSach = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTraSach = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CategoryList = new System.Windows.Forms.Panel();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmThem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.rdSach = new System.Windows.Forms.RadioButton();
            this.rdTacGia = new System.Windows.Forms.RadioButton();
            this.rdNXB = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.rdNXB);
            this.panel1.Controls.Add(this.rdTacGia);
            this.panel1.Controls.Add(this.rdSach);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtTimKiem);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(17, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1174, 709);
            this.panel1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.lsvDanhSach);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(371, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 621);
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
            this.columnHeader9});
            this.lsvDanhSach.ContextMenuStrip = this.contextMenuStrip1;
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(13, 21);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(777, 594);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
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
            // 
            // tsmiTraSach
            // 
            this.tsmiTraSach.Name = "tsmiTraSach";
            this.tsmiTraSach.Size = new System.Drawing.Size(150, 24);
            this.tsmiTraSach.Text = "Trả sách";
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.xoaToolStripMenuItem.Text = "Xóa";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Snow;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(1010, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 41);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.CategoryList);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 621);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thể loại";
            // 
            // CategoryList
            // 
            this.CategoryList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CategoryList.BackgroundImage")));
            this.CategoryList.Location = new System.Drawing.Point(0, 21);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(334, 600);
            this.CategoryList.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(688, 19);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(316, 33);
            this.txtTimKiem.TabIndex = 7;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmThem,
            this.tsmThongKe});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmThem
            // 
            this.tsmThem.Name = "tsmThem";
            this.tsmThem.Size = new System.Drawing.Size(90, 24);
            this.tsmThem.Text = "Thêm mới";
            // 
            // tsmThongKe
            // 
            this.tsmThongKe.Name = "tsmThongKe";
            this.tsmThongKe.Size = new System.Drawing.Size(84, 24);
            this.tsmThongKe.Text = "Thống kê";
            // 
            // rdSach
            // 
            this.rdSach.AutoSize = true;
            this.rdSach.BackColor = System.Drawing.Color.DarkOrchid;
            this.rdSach.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdSach.Location = new System.Drawing.Point(559, 16);
            this.rdSach.Name = "rdSach";
            this.rdSach.Size = new System.Drawing.Size(123, 30);
            this.rdSach.TabIndex = 13;
            this.rdSach.TabStop = true;
            this.rdSach.Text = "Tên sách";
            this.rdSach.UseVisualStyleBackColor = false;
            // 
            // rdTacGia
            // 
            this.rdTacGia.AutoSize = true;
            this.rdTacGia.Location = new System.Drawing.Point(346, 27);
            this.rdTacGia.Name = "rdTacGia";
            this.rdTacGia.Size = new System.Drawing.Size(100, 21);
            this.rdTacGia.TabIndex = 13;
            this.rdTacGia.TabStop = true;
            this.rdTacGia.Text = "Tên tác giả";
            this.rdTacGia.UseVisualStyleBackColor = true;
            // 
            // rdNXB
            // 
            this.rdNXB.AutoSize = true;
            this.rdNXB.Location = new System.Drawing.Point(468, 27);
            this.rdNXB.Name = "rdNXB";
            this.rdNXB.Size = new System.Drawing.Size(140, 21);
            this.rdNXB.TabIndex = 13;
            this.rdNXB.TabStop = true;
            this.rdNXB.Text = "Tên nhà xuất bản";
            this.rdNXB.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 772);
            this.Controls.Add(this.panel1);
            this.Name = "test";
            this.Text = "test";
            this.Load += new System.EventHandler(this.test_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiMuonSach;
        private System.Windows.Forms.ToolStripMenuItem tsmiTraSach;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel CategoryList;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmThem;
        private System.Windows.Forms.ToolStripMenuItem tsmThongKe;
        private System.Windows.Forms.RadioButton rdNXB;
        private System.Windows.Forms.RadioButton rdTacGia;
        private System.Windows.Forms.RadioButton rdSach;
    }
}