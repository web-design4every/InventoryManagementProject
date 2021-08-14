
namespace SE1421_Project
{
    partial class QuanLyPhieuChi
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNguoiChi = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.rtLyDo = new System.Windows.Forms.RichTextBox();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.btnTao = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phiếu Chi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Người Chi Tiền :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa Chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lý Do :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số Tiền :";
            // 
            // txtNguoiChi
            // 
            this.txtNguoiChi.Location = new System.Drawing.Point(174, 125);
            this.txtNguoiChi.Name = "txtNguoiChi";
            this.txtNguoiChi.Size = new System.Drawing.Size(286, 22);
            this.txtNguoiChi.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(174, 184);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(286, 22);
            this.txtDiaChi.TabIndex = 8;
            // 
            // rtLyDo
            // 
            this.rtLyDo.Location = new System.Drawing.Point(174, 249);
            this.rtLyDo.Name = "rtLyDo";
            this.rtLyDo.Size = new System.Drawing.Size(286, 126);
            this.rtLyDo.TabIndex = 9;
            this.rtLyDo.Text = "";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(174, 395);
            this.txtTien.Name = "txtTien";
            this.txtTien.Size = new System.Drawing.Size(286, 22);
            this.txtTien.TabIndex = 10;
            this.txtTien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTien_KeyPress);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.Lime;
            this.btnTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTao.Location = new System.Drawing.Point(91, 438);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(107, 31);
            this.btnTao.TabIndex = 12;
            this.btnTao.Text = "Tạo mới";
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.Color.Red;
            this.btnQuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuayLai.Location = new System.Drawing.Point(351, 438);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(109, 31);
            this.btnQuayLai.TabIndex = 13;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.Magenta;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIn.Location = new System.Drawing.Point(222, 438);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(107, 31);
            this.btnIn.TabIndex = 14;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // QuanLyPhieuChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(522, 493);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnTao);
            this.Controls.Add(this.txtTien);
            this.Controls.Add(this.rtLyDo);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtNguoiChi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyPhieuChi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyPhieuChi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNguoiChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.RichTextBox rtLyDo;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnIn;
    }
}