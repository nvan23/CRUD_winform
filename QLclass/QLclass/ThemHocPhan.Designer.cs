namespace QLclass
{
    partial class ThemHocPhan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLopHoc = new System.Windows.Forms.TextBox();
            this.txtTenLopHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkCo = new System.Windows.Forms.RadioButton();
            this.checkKhong = new System.Windows.Forms.RadioButton();
            this.cboTrangThaiHocPhan = new System.Windows.Forms.ComboBox();
            this.btnNewHocPham = new System.Windows.Forms.Button();
            this.btnLuuHocPhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtGiaHocPhan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStartDay = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã học phần";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên học phần";
            // 
            // txtMaLopHoc
            // 
            this.txtMaLopHoc.Location = new System.Drawing.Point(179, 39);
            this.txtMaLopHoc.Name = "txtMaLopHoc";
            this.txtMaLopHoc.Size = new System.Drawing.Size(200, 20);
            this.txtMaLopHoc.TabIndex = 2;
            // 
            // txtTenLopHoc
            // 
            this.txtTenLopHoc.Location = new System.Drawing.Point(179, 70);
            this.txtTenLopHoc.Name = "txtTenLopHoc";
            this.txtTenLopHoc.Size = new System.Drawing.Size(200, 20);
            this.txtTenLopHoc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Học phần tiên quyết";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Trạng thái";
            // 
            // checkCo
            // 
            this.checkCo.AutoSize = true;
            this.checkCo.Location = new System.Drawing.Point(179, 129);
            this.checkCo.Name = "checkCo";
            this.checkCo.Size = new System.Drawing.Size(38, 17);
            this.checkCo.TabIndex = 6;
            this.checkCo.TabStop = true;
            this.checkCo.Text = "Có";
            this.checkCo.UseVisualStyleBackColor = true;
            // 
            // checkKhong
            // 
            this.checkKhong.AutoSize = true;
            this.checkKhong.Location = new System.Drawing.Point(179, 151);
            this.checkKhong.Name = "checkKhong";
            this.checkKhong.Size = new System.Drawing.Size(56, 17);
            this.checkKhong.TabIndex = 7;
            this.checkKhong.TabStop = true;
            this.checkKhong.Text = "Không";
            this.checkKhong.UseVisualStyleBackColor = true;
            // 
            // cboTrangThaiHocPhan
            // 
            this.cboTrangThaiHocPhan.FormattingEnabled = true;
            this.cboTrangThaiHocPhan.Location = new System.Drawing.Point(179, 179);
            this.cboTrangThaiHocPhan.Name = "cboTrangThaiHocPhan";
            this.cboTrangThaiHocPhan.Size = new System.Drawing.Size(200, 21);
            this.cboTrangThaiHocPhan.TabIndex = 8;
            // 
            // btnNewHocPham
            // 
            this.btnNewHocPham.Location = new System.Drawing.Point(142, 267);
            this.btnNewHocPham.Name = "btnNewHocPham";
            this.btnNewHocPham.Size = new System.Drawing.Size(75, 23);
            this.btnNewHocPham.TabIndex = 9;
            this.btnNewHocPham.Text = "Thêm mới";
            this.btnNewHocPham.UseVisualStyleBackColor = true;
            this.btnNewHocPham.Click += new System.EventHandler(this.btnNewHocPham_Click);
            // 
            // btnLuuHocPhan
            // 
            this.btnLuuHocPhan.Location = new System.Drawing.Point(223, 267);
            this.btnLuuHocPhan.Name = "btnLuuHocPhan";
            this.btnLuuHocPhan.Size = new System.Drawing.Size(75, 23);
            this.btnLuuHocPhan.TabIndex = 10;
            this.btnLuuHocPhan.Text = "Lưu";
            this.btnLuuHocPhan.UseVisualStyleBackColor = true;
            this.btnLuuHocPhan.Click += new System.EventHandler(this.btnLuuHocPhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(304, 267);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtGiaHocPhan
            // 
            this.txtGiaHocPhan.Location = new System.Drawing.Point(179, 96);
            this.txtGiaHocPhan.Name = "txtGiaHocPhan";
            this.txtGiaHocPhan.Size = new System.Drawing.Size(200, 20);
            this.txtGiaHocPhan.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Giá";
            // 
            // dtpStartDay
            // 
            this.dtpStartDay.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStartDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDay.Location = new System.Drawing.Point(179, 223);
            this.dtpStartDay.Name = "dtpStartDay";
            this.dtpStartDay.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDay.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ngày Bắt Đầu";
            // 
            // ThemHocPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 343);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpStartDay);
            this.Controls.Add(this.txtGiaHocPhan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuuHocPhan);
            this.Controls.Add(this.btnNewHocPham);
            this.Controls.Add(this.cboTrangThaiHocPhan);
            this.Controls.Add(this.checkKhong);
            this.Controls.Add(this.checkCo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTenLopHoc);
            this.Controls.Add(this.txtMaLopHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemHocPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm lớp học";
            this.Load += new System.EventHandler(this.ThemHocPhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLopHoc;
        private System.Windows.Forms.TextBox txtTenLopHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton checkCo;
        private System.Windows.Forms.RadioButton checkKhong;
        private System.Windows.Forms.ComboBox cboTrangThaiHocPhan;
        private System.Windows.Forms.Button btnNewHocPham;
        private System.Windows.Forms.Button btnLuuHocPhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtGiaHocPhan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpStartDay;
        private System.Windows.Forms.Label label6;
    }
}