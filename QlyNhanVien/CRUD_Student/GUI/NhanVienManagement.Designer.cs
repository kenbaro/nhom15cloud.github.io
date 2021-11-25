
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
            this.tbx_searchNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ThemNV = new System.Windows.Forms.Button();
            this.btn_SuaNV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dsnv = new System.Windows.Forms.DataGridView();
            this.btn_XoaNV = new System.Windows.Forms.Button();
            this.grb_info = new System.Windows.Forms.GroupBox();
            this.cmb_quyen = new System.Windows.Forms.ComboBox();
            this.tbx_hoten = new System.Windows.Forms.TextBox();
            this.tbx_mk2 = new System.Windows.Forms.TextBox();
            this.tbx_mk = new System.Windows.Forms.TextBox();
            this.tbx_tendn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_UName = new System.Windows.Forms.Label();
            this.tab_PC = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cmb_banpc = new System.Windows.Forms.ComboBox();
            this.cmb_capc = new System.Windows.Forms.ComboBox();
            this.cmb_nvpc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_xoaPC = new System.Windows.Forms.Button();
            this.btn_themPC = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgv_dspc = new System.Windows.Forms.DataGridView();
            this.btn_signout = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tab_NV.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).BeginInit();
            this.grb_info.SuspendLayout();
            this.tab_PC.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dspc)).BeginInit();
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
            this.groupBox2.Controls.Add(this.tbx_searchNV);
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
            // 
            // tbx_searchNV
            // 
            this.tbx_searchNV.Location = new System.Drawing.Point(127, 43);
            this.tbx_searchNV.Name = "tbx_searchNV";
            this.tbx_searchNV.Size = new System.Drawing.Size(172, 27);
            this.tbx_searchNV.TabIndex = 1;
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsnv);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 317);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên:";
            // 
            // dgv_dsnv
            // 
            this.dgv_dsnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsnv.Location = new System.Drawing.Point(6, 26);
            this.dgv_dsnv.Name = "dgv_dsnv";
            this.dgv_dsnv.RowHeadersWidth = 51;
            this.dgv_dsnv.RowTemplate.Height = 24;
            this.dgv_dsnv.Size = new System.Drawing.Size(981, 285);
            this.dgv_dsnv.TabIndex = 0;
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
            // 
            // grb_info
            // 
            this.grb_info.Controls.Add(this.cmb_quyen);
            this.grb_info.Controls.Add(this.tbx_hoten);
            this.grb_info.Controls.Add(this.tbx_mk2);
            this.grb_info.Controls.Add(this.tbx_mk);
            this.grb_info.Controls.Add(this.tbx_tendn);
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
            // cmb_quyen
            // 
            this.cmb_quyen.FormattingEnabled = true;
            this.cmb_quyen.Location = new System.Drawing.Point(520, 92);
            this.cmb_quyen.Name = "cmb_quyen";
            this.cmb_quyen.Size = new System.Drawing.Size(132, 31);
            this.cmb_quyen.TabIndex = 2;
            // 
            // tbx_hoten
            // 
            this.tbx_hoten.Location = new System.Drawing.Point(520, 43);
            this.tbx_hoten.Multiline = true;
            this.tbx_hoten.Name = "tbx_hoten";
            this.tbx_hoten.Size = new System.Drawing.Size(197, 27);
            this.tbx_hoten.TabIndex = 1;
            // 
            // tbx_mk2
            // 
            this.tbx_mk2.Location = new System.Drawing.Point(199, 138);
            this.tbx_mk2.Multiline = true;
            this.tbx_mk2.Name = "tbx_mk2";
            this.tbx_mk2.PasswordChar = '*';
            this.tbx_mk2.Size = new System.Drawing.Size(197, 27);
            this.tbx_mk2.TabIndex = 1;
            // 
            // tbx_mk
            // 
            this.tbx_mk.Location = new System.Drawing.Point(199, 91);
            this.tbx_mk.Multiline = true;
            this.tbx_mk.Name = "tbx_mk";
            this.tbx_mk.PasswordChar = '*';
            this.tbx_mk.Size = new System.Drawing.Size(197, 27);
            this.tbx_mk.TabIndex = 1;
            // 
            // tbx_tendn
            // 
            this.tbx_tendn.Location = new System.Drawing.Point(199, 43);
            this.tbx_tendn.Multiline = true;
            this.tbx_tendn.Name = "tbx_tendn";
            this.tbx_tendn.Size = new System.Drawing.Size(197, 27);
            this.tbx_tendn.TabIndex = 1;
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
            this.groupBox5.Controls.Add(this.cmb_banpc);
            this.groupBox5.Controls.Add(this.cmb_capc);
            this.groupBox5.Controls.Add(this.cmb_nvpc);
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
            // cmb_banpc
            // 
            this.cmb_banpc.FormattingEnabled = true;
            this.cmb_banpc.Location = new System.Drawing.Point(810, 44);
            this.cmb_banpc.Name = "cmb_banpc";
            this.cmb_banpc.Size = new System.Drawing.Size(88, 33);
            this.cmb_banpc.TabIndex = 1;
            // 
            // cmb_capc
            // 
            this.cmb_capc.FormattingEnabled = true;
            this.cmb_capc.Location = new System.Drawing.Point(613, 44);
            this.cmb_capc.Name = "cmb_capc";
            this.cmb_capc.Size = new System.Drawing.Size(69, 33);
            this.cmb_capc.TabIndex = 1;
            // 
            // cmb_nvpc
            // 
            this.cmb_nvpc.FormattingEnabled = true;
            this.cmb_nvpc.Location = new System.Drawing.Point(286, 44);
            this.cmb_nvpc.Name = "cmb_nvpc";
            this.cmb_nvpc.Size = new System.Drawing.Size(233, 33);
            this.cmb_nvpc.TabIndex = 1;
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
            this.groupBox3.Controls.Add(this.dgv_dspc);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(904, 387);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Phân Công:";
            // 
            // dgv_dspc
            // 
            this.dgv_dspc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dspc.Location = new System.Drawing.Point(6, 35);
            this.dgv_dspc.Name = "dgv_dspc";
            this.dgv_dspc.RowHeadersWidth = 51;
            this.dgv_dspc.RowTemplate.Height = 24;
            this.dgv_dspc.Size = new System.Drawing.Size(892, 346);
            this.dgv_dspc.TabIndex = 0;
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
            // 
            // NhanVienManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1156, 635);
            this.Controls.Add(this.btn_signout);
            this.Controls.Add(this.tabControl);
            this.Name = "NhanVienManagement";
            this.Text = "NhanVienManagement";
            this.tabControl.ResumeLayout(false);
            this.tab_NV.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnv)).EndInit();
            this.grb_info.ResumeLayout(false);
            this.grb_info.PerformLayout();
            this.tab_PC.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dspc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_NV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dsnv;
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
        private System.Windows.Forms.TextBox tbx_searchNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_hoten;
        private System.Windows.Forms.TextBox tbx_mk2;
        private System.Windows.Forms.TextBox tbx_mk;
        private System.Windows.Forms.TextBox tbx_tendn;
        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgv_dspc;
        private System.Windows.Forms.ComboBox cmb_banpc;
        private System.Windows.Forms.ComboBox cmb_capc;
        private System.Windows.Forms.ComboBox cmb_nvpc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_xoaPC;
        private System.Windows.Forms.Button btn_themPC;
        private System.Windows.Forms.ComboBox cmb_quyen;
    }
}