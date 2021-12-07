
namespace CRUD_Student.GUI
{
    partial class NhanVienManagement
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_NV = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SearchNV = new System.Windows.Forms.Button();
            this.btn_DSNV = new System.Windows.Forms.Button();
            this.tbx_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_SuaNV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_NhanVien = new System.Windows.Forms.DataGridView();
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.grb_info = new System.Windows.Forms.GroupBox();
            this.cmB_Type = new System.Windows.Forms.ComboBox();
            this.tbx_DisplName = new System.Windows.Forms.TextBox();
            this.tbx_Repass = new System.Windows.Forms.TextBox();
            this.tbx_Pass = new System.Windows.Forms.TextBox();
            this.tbx_User = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_UName = new System.Windows.Forms.Label();
            this.tab_PC = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmbBanPC = new System.Windows.Forms.ComboBox();
            this.cmb_capc = new System.Windows.Forms.ComboBox();
            this.cmbNhanVienpc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_xoaPC = new System.Windows.Forms.Button();
            this.btn_themPC = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSPhanCong = new System.Windows.Forms.DataGridView();
            this.btn_signout = new System.Windows.Forms.Button();
            this.lbl_tenDangnhap = new System.Windows.Forms.Label();
            this.TenDN = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.hoTen = new System.Windows.Forms.Label();
            this.quyen = new System.Windows.Forms.Label();
            this.lbl_quyen = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tab_NV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).BeginInit();
            this.grb_info.SuspendLayout();
            this.tab_PC.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhanCong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_NV);
            this.tabControl.Controls.Add(this.tab_PC);
            this.tabControl.Location = new System.Drawing.Point(0, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1157, 604);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tab_NV
            // 
            this.tab_NV.BackColor = System.Drawing.Color.SteelBlue;
            this.tab_NV.Controls.Add(this.groupBox2);
            this.tab_NV.Controls.Add(this.btn_ThemNV);
            this.tab_NV.Controls.Add(this.btn_SuaNV);
            this.tab_NV.Controls.Add(this.groupBox1);
            this.tab_NV.Controls.Add(this.btn_XoaNV);
            this.tab_NV.Controls.Add(this.grb_info);
            this.tab_NV.Location = new System.Drawing.Point(4, 25);
            this.tab_NV.Name = "tab_NV";
            this.tab_NV.Padding = new System.Windows.Forms.Padding(3);
            this.tab_NV.Size = new System.Drawing.Size(1149, 575);
            this.tab_NV.TabIndex = 0;
            this.tab_NV.Text = "Nhân Viên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SearchNV);
            this.groupBox2.Controls.Add(this.btn_DSNV);
            this.groupBox2.Controls.Add(this.tbx_Search);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(788, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 192);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra Cứu Thông Tin:";
            // 
            // btn_SearchNV
            // 
            this.btn_SearchNV.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btn_SearchNV.Location = new System.Drawing.Point(191, 113);
            this.btn_SearchNV.Name = "btn_SearchNV";
            this.btn_SearchNV.Size = new System.Drawing.Size(108, 34);
            this.btn_SearchNV.TabIndex = 3;
            this.btn_SearchNV.Text = "Search";
            this.btn_SearchNV.UseVisualStyleBackColor = false;
            this.btn_SearchNV.Click += new System.EventHandler(this.btn_SearchNV_Click);
            // 
            // btn_DSNV
            // 
            this.btn_DSNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_DSNV.Location = new System.Drawing.Point(32, 113);
            this.btn_DSNV.Name = "btn_DSNV";
            this.btn_DSNV.Size = new System.Drawing.Size(127, 34);
            this.btn_DSNV.TabIndex = 2;
            this.btn_DSNV.Text = "DS Nhân Viên";
            this.btn_DSNV.UseVisualStyleBackColor = false;
            this.btn_DSNV.Click += new System.EventHandler(this.btn_DSNV_Click);
            // 
            // tbx_Search
            // 
            this.tbx_Search.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Search.Location = new System.Drawing.Point(127, 43);
            this.tbx_Search.Name = "tbx_Search";
            this.tbx_Search.Size = new System.Drawing.Size(172, 27);
            this.tbx_Search.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên NV:";
            // 
            // btn_ThemNV
            // 
            this.btn_ThemNV.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_ThemNV.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_ThemNV.Location = new System.Drawing.Point(1037, 268);
            this.btn_ThemNV.Name = "btn_ThemNV";
            this.btn_ThemNV.Size = new System.Drawing.Size(88, 41);
            this.btn_ThemNV.TabIndex = 2;
            this.btn_ThemNV.Text = "Thêm";
            this.btn_ThemNV.UseVisualStyleBackColor = false;
            this.btn_ThemNV.Click += new System.EventHandler(this.btn_ThemNV_Click);
            // 
            // btn_SuaNV
            // 
            this.btn_SuaNV.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_SuaNV.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaNV.Location = new System.Drawing.Point(1037, 453);
            this.btn_SuaNV.Name = "btn_SuaNV";
            this.btn_SuaNV.Size = new System.Drawing.Size(88, 42);
            this.btn_SuaNV.TabIndex = 2;
            this.btn_SuaNV.Text = "Sửa TT";
            this.btn_SuaNV.UseVisualStyleBackColor = false;
            this.btn_SuaNV.Click += new System.EventHandler(this.btn_SuaNV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_NhanVien);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên:";
            // 
            // dgv_NhanVien
            // 
            this.dgv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NhanVien.Location = new System.Drawing.Point(6, 26);
            this.dgv_NhanVien.Name = "dgv_NhanVien";
            this.dgv_NhanVien.RowHeadersWidth = 51;
            this.dgv_NhanVien.RowTemplate.Height = 24;
            this.dgv_NhanVien.Size = new System.Drawing.Size(981, 285);
            this.dgv_NhanVien.TabIndex = 0;
            this.dgv_NhanVien.Click += new System.EventHandler(this.dgv_NhanVien_Click);
            // 
            // btn_XoaNV
            // 
            this.btn_XoaNV.BackColor = System.Drawing.Color.IndianRed;
            this.btn_XoaNV.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaNV.Location = new System.Drawing.Point(1037, 360);
            this.btn_XoaNV.Name = "btn_XoaNV";
            this.btn_XoaNV.Size = new System.Drawing.Size(88, 44);
            this.btn_XoaNV.TabIndex = 2;
            this.btn_XoaNV.Text = "Xóa";
            this.btn_XoaNV.UseVisualStyleBackColor = false;
            this.btn_XoaNV.Click += new System.EventHandler(this.btn_XoaNV_Click);
            // 
            // grb_info
            // 
            this.grb_info.Controls.Add(this.cmB_Type);
            this.grb_info.Controls.Add(this.tbx_DisplName);
            this.grb_info.Controls.Add(this.tbx_Repass);
            this.grb_info.Controls.Add(this.tbx_Pass);
            this.grb_info.Controls.Add(this.tbx_User);
            this.grb_info.Controls.Add(this.label4);
            this.grb_info.Controls.Add(this.label3);
            this.grb_info.Controls.Add(this.label2);
            this.grb_info.Controls.Add(this.label1);
            this.grb_info.Controls.Add(this.label_UName);
            this.grb_info.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_info.Location = new System.Drawing.Point(21, 23);
            this.grb_info.Name = "grb_info";
            this.grb_info.Size = new System.Drawing.Size(733, 192);
            this.grb_info.TabIndex = 0;
            this.grb_info.TabStop = false;
            this.grb_info.Text = "Thông Tin Nhân Viên:";
            // 
            // cmB_Type
            // 
            this.cmB_Type.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmB_Type.FormattingEnabled = true;
            this.cmB_Type.Items.AddRange(new object[] {
            "Thu Ngan",
            "Tiep Tan"});
            this.cmB_Type.Location = new System.Drawing.Point(520, 92);
            this.cmB_Type.Name = "cmB_Type";
            this.cmB_Type.Size = new System.Drawing.Size(132, 31);
            this.cmB_Type.TabIndex = 2;
            // 
            // tbx_DisplName
            // 
            this.tbx_DisplName.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_DisplName.Location = new System.Drawing.Point(520, 43);
            this.tbx_DisplName.Multiline = true;
            this.tbx_DisplName.Name = "tbx_DisplName";
            this.tbx_DisplName.Size = new System.Drawing.Size(197, 27);
            this.tbx_DisplName.TabIndex = 1;
            // 
            // tbx_Repass
            // 
            this.tbx_Repass.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Repass.Location = new System.Drawing.Point(199, 138);
            this.tbx_Repass.Multiline = true;
            this.tbx_Repass.Name = "tbx_Repass";
            this.tbx_Repass.PasswordChar = '*';
            this.tbx_Repass.Size = new System.Drawing.Size(197, 27);
            this.tbx_Repass.TabIndex = 1;
            // 
            // tbx_Pass
            // 
            this.tbx_Pass.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_Pass.Location = new System.Drawing.Point(199, 91);
            this.tbx_Pass.Multiline = true;
            this.tbx_Pass.Name = "tbx_Pass";
            this.tbx_Pass.PasswordChar = '*';
            this.tbx_Pass.Size = new System.Drawing.Size(197, 27);
            this.tbx_Pass.TabIndex = 1;
            // 
            // tbx_User
            // 
            this.tbx_User.Font = new System.Drawing.Font("Arial Unicode MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_User.Location = new System.Drawing.Point(199, 43);
            this.tbx_User.Multiline = true;
            this.tbx_User.Name = "tbx_User";
            this.tbx_User.Size = new System.Drawing.Size(197, 27);
            this.tbx_User.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập Lại Mật Khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quyền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(418, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Và Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mật Khẩu:";
            // 
            // label_UName
            // 
            this.label_UName.AutoSize = true;
            this.label_UName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UName.Location = new System.Drawing.Point(30, 46);
            this.label_UName.Name = "label_UName";
            this.label_UName.Size = new System.Drawing.Size(136, 19);
            this.label_UName.TabIndex = 0;
            this.label_UName.Text = "Tên Đăng Nhập:";
            // 
            // tab_PC
            // 
            this.tab_PC.BackColor = System.Drawing.Color.SteelBlue;
            this.tab_PC.Controls.Add(this.groupBox5);
            this.tab_PC.Controls.Add(this.groupBox4);
            this.tab_PC.Controls.Add(this.groupBox3);
            this.tab_PC.Location = new System.Drawing.Point(4, 25);
            this.tab_PC.Name = "tab_PC";
            this.tab_PC.Padding = new System.Windows.Forms.Padding(3);
            this.tab_PC.Size = new System.Drawing.Size(1149, 575);
            this.tab_PC.TabIndex = 1;
            this.tab_PC.Text = "Phân Công";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cmbBanPC);
            this.groupBox5.Controls.Add(this.cmb_capc);
            this.groupBox5.Controls.Add(this.cmbNhanVienpc);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(21, 29);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1104, 118);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông Tin:";
            // 
            // cmbBanPC
            // 
            this.cmbBanPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBanPC.FormattingEnabled = true;
            this.cmbBanPC.Location = new System.Drawing.Point(810, 44);
            this.cmbBanPC.Name = "cmbBanPC";
            this.cmbBanPC.Size = new System.Drawing.Size(88, 28);
            this.cmbBanPC.TabIndex = 1;
            // 
            // cmb_capc
            // 
            this.cmb_capc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_capc.FormattingEnabled = true;
            this.cmb_capc.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmb_capc.Location = new System.Drawing.Point(613, 44);
            this.cmb_capc.Name = "cmb_capc";
            this.cmb_capc.Size = new System.Drawing.Size(69, 28);
            this.cmb_capc.TabIndex = 1;
            this.cmb_capc.Text = "1";
            // 
            // cmbNhanVienpc
            // 
            this.cmbNhanVienpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNhanVienpc.FormattingEnabled = true;
            this.cmbNhanVienpc.Location = new System.Drawing.Point(286, 44);
            this.cmbNhanVienpc.Name = "cmbNhanVienpc";
            this.cmbNhanVienpc.Size = new System.Drawing.Size(233, 28);
            this.cmbNhanVienpc.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(748, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Bàn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(549, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(184, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhân Viên:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_xoaPC);
            this.groupBox4.Controls.Add(this.btn_themPC);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(962, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(163, 387);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Xử Lý:";
            // 
            // btn_xoaPC
            // 
            this.btn_xoaPC.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_xoaPC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoaPC.Location = new System.Drawing.Point(30, 157);
            this.btn_xoaPC.Name = "btn_xoaPC";
            this.btn_xoaPC.Size = new System.Drawing.Size(108, 44);
            this.btn_xoaPC.TabIndex = 1;
            this.btn_xoaPC.Text = "Xóa PC";
            this.btn_xoaPC.UseVisualStyleBackColor = false;
            // 
            // btn_themPC
            // 
            this.btn_themPC.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn_themPC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themPC.Location = new System.Drawing.Point(30, 81);
            this.btn_themPC.Name = "btn_themPC";
            this.btn_themPC.Size = new System.Drawing.Size(108, 47);
            this.btn_themPC.TabIndex = 0;
            this.btn_themPC.Text = "Thêm PC";
            this.btn_themPC.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSPhanCong);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(904, 387);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phân Công:";
            // 
            // dgvDSPhanCong
            // 
            this.dgvDSPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhanCong.Location = new System.Drawing.Point(6, 35);
            this.dgvDSPhanCong.Name = "dgvDSPhanCong";
            this.dgvDSPhanCong.RowHeadersWidth = 51;
            this.dgvDSPhanCong.RowTemplate.Height = 24;
            this.dgvDSPhanCong.Size = new System.Drawing.Size(892, 346);
            this.dgvDSPhanCong.TabIndex = 0;
            // 
            // btn_signout
            // 
            this.btn_signout.BackColor = System.Drawing.Color.Red;
            this.btn_signout.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_signout.Location = new System.Drawing.Point(1050, 601);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(103, 36);
            this.btn_signout.TabIndex = 1;
            this.btn_signout.Text = "Sign Out";
            this.btn_signout.UseVisualStyleBackColor = false;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // lbl_tenDangnhap
            // 
            this.lbl_tenDangnhap.AutoSize = true;
            this.lbl_tenDangnhap.Location = new System.Drawing.Point(45, 611);
            this.lbl_tenDangnhap.Name = "lbl_tenDangnhap";
            this.lbl_tenDangnhap.Size = new System.Drawing.Size(113, 17);
            this.lbl_tenDangnhap.TabIndex = 2;
            this.lbl_tenDangnhap.Text = "Tên Đăng Nhập:";
            // 
            // TenDN
            // 
            this.TenDN.AutoSize = true;
            this.TenDN.Location = new System.Drawing.Point(164, 611);
            this.TenDN.Name = "TenDN";
            this.TenDN.Size = new System.Drawing.Size(53, 17);
            this.TenDN.TabIndex = 2;
            this.TenDN.Text = "TenDN";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Location = new System.Drawing.Point(362, 609);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(59, 17);
            this.lbl_HoTen.TabIndex = 2;
            this.lbl_HoTen.Text = "Họ Tên:";
            // 
            // hoTen
            // 
            this.hoTen.AutoSize = true;
            this.hoTen.Location = new System.Drawing.Point(444, 609);
            this.hoTen.Name = "hoTen";
            this.hoTen.Size = new System.Drawing.Size(51, 17);
            this.hoTen.TabIndex = 2;
            this.hoTen.Text = "HoTen";
            // 
            // quyen
            // 
            this.quyen.AutoSize = true;
            this.quyen.Location = new System.Drawing.Point(767, 611);
            this.quyen.Name = "quyen";
            this.quyen.Size = new System.Drawing.Size(50, 17);
            this.quyen.TabIndex = 2;
            this.quyen.Text = "Quyền";
            // 
            // lbl_quyen
            // 
            this.lbl_quyen.AutoSize = true;
            this.lbl_quyen.Location = new System.Drawing.Point(683, 611);
            this.lbl_quyen.Name = "lbl_quyen";
            this.lbl_quyen.Size = new System.Drawing.Size(54, 17);
            this.lbl_quyen.TabIndex = 2;
            this.lbl_quyen.Text = "Quyền:";
            // 
            // NhanVienManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1156, 635);
            this.Controls.Add(this.lbl_quyen);
            this.Controls.Add(this.quyen);
            this.Controls.Add(this.hoTen);
            this.Controls.Add(this.lbl_HoTen);
            this.Controls.Add(this.TenDN);
            this.Controls.Add(this.lbl_tenDangnhap);
            this.Controls.Add(this.btn_signout);
            this.Controls.Add(this.tabControl);
            this.Name = "NhanVienManagement";
            this.Text = "NhanVienManagement";
            this.Load += new System.EventHandler(this.NhanVienManagement_Load);
            this.tabControl.ResumeLayout(false);
            this.tab_NV.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhanVien)).EndInit();
            this.grb_info.ResumeLayout(false);
            this.grb_info.PerformLayout();
            this.tab_PC.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhanCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_NV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_NhanVien;
        private System.Windows.Forms.GroupBox grb_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_UName;
        private System.Windows.Forms.TabPage tab_PC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_ThemNV;
        private System.Windows.Forms.Button btn_SuaNV;
        private System.Windows.Forms.Button btn_XoaNV;
        private System.Windows.Forms.Button btn_SearchNV;
        private System.Windows.Forms.Button btn_DSNV;
        private System.Windows.Forms.TextBox tbx_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_DisplName;
        private System.Windows.Forms.TextBox tbx_Repass;
        private System.Windows.Forms.TextBox tbx_Pass;
        private System.Windows.Forms.TextBox tbx_User;
        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSPhanCong;
        private System.Windows.Forms.ComboBox cmbBanPC;
        private System.Windows.Forms.ComboBox cmb_capc;
        private System.Windows.Forms.ComboBox cmbNhanVienpc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_xoaPC;
        private System.Windows.Forms.Button btn_themPC;
        private System.Windows.Forms.ComboBox cmB_Type;
        private System.Windows.Forms.Label lbl_tenDangnhap;
        private System.Windows.Forms.Label TenDN;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Label hoTen;
        private System.Windows.Forms.Label quyen;
        private System.Windows.Forms.Label lbl_quyen;
    }
}