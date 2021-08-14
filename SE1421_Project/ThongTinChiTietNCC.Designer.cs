
namespace SE1421_Project
{
    partial class ThongTinChiTietNCC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grdNoNCC = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblTienNo = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.lblTraTien = new System.Windows.Forms.Label();
            this.txtTraNo = new System.Windows.Forms.TextBox();
            this.btnTraNo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdNoNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhà Cung Cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhà Cung Cấp :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhà Cung Cấp :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa Chỉ :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(451, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Điện Thoại :";
            // 
            // grdNoNCC
            // 
            this.grdNoNCC.AllowUserToAddRows = false;
            this.grdNoNCC.AllowUserToResizeColumns = false;
            this.grdNoNCC.AllowUserToResizeRows = false;
            this.grdNoNCC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdNoNCC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(210)))), ((int)(((byte)(245)))));
            this.grdNoNCC.ColumnHeadersHeight = 29;
            this.grdNoNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdNoNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdNoNCC.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdNoNCC.Location = new System.Drawing.Point(38, 218);
            this.grdNoNCC.Name = "grdNoNCC";
            this.grdNoNCC.ReadOnly = true;
            this.grdNoNCC.RowHeadersVisible = false;
            this.grdNoNCC.RowHeadersWidth = 10;
            this.grdNoNCC.RowTemplate.Height = 24;
            this.grdNoNCC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdNoNCC.Size = new System.Drawing.Size(750, 222);
            this.grdNoNCC.TabIndex = 42;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaPhieuNhap";
            this.Column1.HeaderText = "MaPhieuNhap";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TienCo";
            this.Column2.HeaderText = "TienCo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TienNo";
            this.Column3.HeaderText = "TienNo";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "NgayTao";
            this.Column6.HeaderText = "NgayTao";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.BackColor = System.Drawing.Color.Magenta;
            this.btnQuayVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayVe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnQuayVe.Location = new System.Drawing.Point(607, 457);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(181, 33);
            this.btnQuayVe.TabIndex = 53;
            this.btnQuayVe.Text = "Quay về";
            this.btnQuayVe.UseVisualStyleBackColor = false;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(216, 66);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.Size = new System.Drawing.Size(218, 22);
            this.txtMaNCC.TabIndex = 54;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(216, 113);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.ReadOnly = true;
            this.txtTenNCC.Size = new System.Drawing.Size(218, 22);
            this.txtTenNCC.TabIndex = 55;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(587, 64);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(201, 22);
            this.txtDiaChi.TabIndex = 56;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(587, 113);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(201, 22);
            this.txtSDT.TabIndex = 57;
            // 
            // lblTienNo
            // 
            this.lblTienNo.AutoSize = true;
            this.lblTienNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTienNo.Location = new System.Drawing.Point(35, 168);
            this.lblTienNo.Name = "lblTienNo";
            this.lblTienNo.Size = new System.Drawing.Size(69, 18);
            this.lblTienNo.TabIndex = 63;
            this.lblTienNo.Text = "Tiền nợ:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(216, 168);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(218, 22);
            this.txtTongTien.TabIndex = 64;
            // 
            // lblTraTien
            // 
            this.lblTraTien.AutoSize = true;
            this.lblTraTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraTien.Location = new System.Drawing.Point(451, 172);
            this.lblTraTien.Name = "lblTraTien";
            this.lblTraTien.Size = new System.Drawing.Size(80, 18);
            this.lblTraTien.TabIndex = 65;
            this.lblTraTien.Text = "Trả Tiền: ";
            // 
            // txtTraNo
            // 
            this.txtTraNo.Location = new System.Drawing.Point(587, 171);
            this.txtTraNo.Name = "txtTraNo";
            this.txtTraNo.Size = new System.Drawing.Size(201, 22);
            this.txtTraNo.TabIndex = 66;
            this.txtTraNo.TextChanged += new System.EventHandler(this.txtTraNo_TextChanged);
            this.txtTraNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTraNo_KeyPress);
            // 
            // btnTraNo
            // 
            this.btnTraNo.BackColor = System.Drawing.Color.Lime;
            this.btnTraNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraNo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTraNo.Location = new System.Drawing.Point(380, 457);
            this.btnTraNo.Name = "btnTraNo";
            this.btnTraNo.Size = new System.Drawing.Size(181, 33);
            this.btnTraNo.TabIndex = 67;
            this.btnTraNo.Text = "Trả nợ";
            this.btnTraNo.UseVisualStyleBackColor = false;
            this.btnTraNo.Click += new System.EventHandler(this.btnTraNo_Click);
            // 
            // ThongTinChiTietNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.btnTraNo);
            this.Controls.Add(this.txtTraNo);
            this.Controls.Add(this.lblTraTien);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTienNo);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNCC);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.grdNoNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThongTinChiTietNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinChiTietNCC";
            ((System.ComponentModel.ISupportInitialize)(this.grdNoNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView grdNoNCC;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lblTienNo;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label lblTraTien;
        private System.Windows.Forms.TextBox txtTraNo;
        private System.Windows.Forms.Button btnTraNo;
    }
}