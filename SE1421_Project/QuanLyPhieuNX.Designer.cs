
namespace SE1421_Project
{
    partial class QuanLyPhieuNX
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdPhieuNhap = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdPhieuXuat = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTimKiemPN = new System.Windows.Forms.TextBox();
            this.btnChiTietPN = new System.Windows.Forms.Button();
            this.cbxPN = new System.Windows.Forms.ComboBox();
            this.cbxPX = new System.Windows.Forms.ComboBox();
            this.txtTimKiemPX = new System.Windows.Forms.TextBox();
            this.btnChiTietPX = new System.Windows.Forms.Button();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1316, 155);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(476, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(350, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "PHIẾU NHẬP / XUẤT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(391, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHO VẬT LIỆU";
            // 
            // grdPhieuNhap
            // 
            this.grdPhieuNhap.AllowUserToAddRows = false;
            this.grdPhieuNhap.AllowUserToResizeColumns = false;
            this.grdPhieuNhap.AllowUserToResizeRows = false;
            this.grdPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPhieuNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.grdPhieuNhap.ColumnHeadersHeight = 29;
            this.grdPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column6,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPhieuNhap.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdPhieuNhap.Location = new System.Drawing.Point(31, 275);
            this.grdPhieuNhap.Name = "grdPhieuNhap";
            this.grdPhieuNhap.ReadOnly = true;
            this.grdPhieuNhap.RowHeadersVisible = false;
            this.grdPhieuNhap.RowHeadersWidth = 10;
            this.grdPhieuNhap.RowTemplate.Height = 24;
            this.grdPhieuNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPhieuNhap.Size = new System.Drawing.Size(586, 503);
            this.grdPhieuNhap.TabIndex = 42;
            this.grdPhieuNhap.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPhieuNhap_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ma";
            this.Column1.HeaderText = "MaNhap";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Ten";
            this.Column6.HeaderText = "NhaCungCap";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TongTien";
            this.Column2.HeaderText = "TongTien";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayTao";
            this.Column3.HeaderText = "NgayTao";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // grdPhieuXuat
            // 
            this.grdPhieuXuat.AllowUserToAddRows = false;
            this.grdPhieuXuat.AllowUserToResizeColumns = false;
            this.grdPhieuXuat.AllowUserToResizeRows = false;
            this.grdPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdPhieuXuat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.grdPhieuXuat.ColumnHeadersHeight = 29;
            this.grdPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdPhieuXuat.DefaultCellStyle = dataGridViewCellStyle6;
            this.grdPhieuXuat.Location = new System.Drawing.Point(684, 275);
            this.grdPhieuXuat.Name = "grdPhieuXuat";
            this.grdPhieuXuat.ReadOnly = true;
            this.grdPhieuXuat.RowHeadersVisible = false;
            this.grdPhieuXuat.RowHeadersWidth = 10;
            this.grdPhieuXuat.RowTemplate.Height = 24;
            this.grdPhieuXuat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPhieuXuat.Size = new System.Drawing.Size(612, 503);
            this.grdPhieuXuat.TabIndex = 43;
            this.grdPhieuXuat.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPhieuXuat_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Ma";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaXuat";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ten";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenKhachHang";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TongTien";
            this.dataGridViewTextBoxColumn3.HeaderText = "TongTien";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "NgayTao";
            this.dataGridViewTextBoxColumn4.HeaderText = "NgayTao";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // txtTimKiemPN
            // 
            this.txtTimKiemPN.Location = new System.Drawing.Point(158, 217);
            this.txtTimKiemPN.Name = "txtTimKiemPN";
            this.txtTimKiemPN.Size = new System.Drawing.Size(355, 22);
            this.txtTimKiemPN.TabIndex = 48;
            this.txtTimKiemPN.TextChanged += new System.EventHandler(this.txtTimKiemPN_TextChanged);
            // 
            // btnChiTietPN
            // 
            this.btnChiTietPN.Location = new System.Drawing.Point(520, 217);
            this.btnChiTietPN.Name = "btnChiTietPN";
            this.btnChiTietPN.Size = new System.Drawing.Size(97, 23);
            this.btnChiTietPN.TabIndex = 50;
            this.btnChiTietPN.Text = "Chi Tiết";
            this.btnChiTietPN.UseVisualStyleBackColor = true;
            this.btnChiTietPN.Click += new System.EventHandler(this.btnChiTietPN_Click);
            // 
            // cbxPN
            // 
            this.cbxPN.FormattingEnabled = true;
            this.cbxPN.Location = new System.Drawing.Point(31, 217);
            this.cbxPN.Name = "cbxPN";
            this.cbxPN.Size = new System.Drawing.Size(121, 24);
            this.cbxPN.TabIndex = 51;
            this.cbxPN.SelectedIndexChanged += new System.EventHandler(this.cbxPN_SelectedIndexChanged);
            // 
            // cbxPX
            // 
            this.cbxPX.FormattingEnabled = true;
            this.cbxPX.Location = new System.Drawing.Point(684, 217);
            this.cbxPX.Name = "cbxPX";
            this.cbxPX.Size = new System.Drawing.Size(121, 24);
            this.cbxPX.TabIndex = 52;
            this.cbxPX.SelectedIndexChanged += new System.EventHandler(this.cbxPX_SelectedIndexChanged);
            // 
            // txtTimKiemPX
            // 
            this.txtTimKiemPX.Location = new System.Drawing.Point(811, 217);
            this.txtTimKiemPX.Name = "txtTimKiemPX";
            this.txtTimKiemPX.Size = new System.Drawing.Size(382, 22);
            this.txtTimKiemPX.TabIndex = 53;
            this.txtTimKiemPX.TextChanged += new System.EventHandler(this.txtTimKiemPX_TextChanged);
            // 
            // btnChiTietPX
            // 
            this.btnChiTietPX.Location = new System.Drawing.Point(1199, 218);
            this.btnChiTietPX.Name = "btnChiTietPX";
            this.btnChiTietPX.Size = new System.Drawing.Size(97, 23);
            this.btnChiTietPX.TabIndex = 54;
            this.btnChiTietPX.Text = "Chi Tiết";
            this.btnChiTietPX.UseVisualStyleBackColor = true;
            this.btnChiTietPX.Click += new System.EventHandler(this.btnChiTietPX_Click);
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.Magenta;
            this.btnQuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuayVe.Location = new System.Drawing.Point(1115, 798);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(181, 33);
            this.btnQuayVe.TabIndex = 56;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(242, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "Phiếu Nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(926, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Phiếu Xuất";
            // 
            // QuanLyPhieuNX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 880);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.btnChiTietPX);
            this.Controls.Add(this.txtTimKiemPX);
            this.Controls.Add(this.cbxPX);
            this.Controls.Add(this.cbxPN);
            this.Controls.Add(this.btnChiTietPN);
            this.Controls.Add(this.txtTimKiemPN);
            this.Controls.Add(this.grdPhieuXuat);
            this.Controls.Add(this.grdPhieuNhap);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyPhieuNX";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyBaoGia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdPhieuNhap;
        private System.Windows.Forms.DataGridView grdPhieuXuat;
        private System.Windows.Forms.TextBox txtTimKiemPN;
        private System.Windows.Forms.Button btnChiTietPN;
        private System.Windows.Forms.ComboBox cbxPN;
        private System.Windows.Forms.ComboBox cbxPX;
        private System.Windows.Forms.TextBox txtTimKiemPX;
        private System.Windows.Forms.Button btnChiTietPX;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
    }
}