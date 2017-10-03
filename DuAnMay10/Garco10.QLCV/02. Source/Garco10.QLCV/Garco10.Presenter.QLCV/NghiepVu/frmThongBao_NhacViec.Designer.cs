namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmThongBao_NhacViec
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
            this.btnThoat = new VSCM.Base.Controls.ucButton();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            this.ucButton3 = new VSCM.Base.Controls.ucButton();
            this.ucGroupBox1 = new VSCM.Base.Controls.ucGroupBox();
            this.chkTatCa = new VSCM.Base.Controls.ucCheckBox();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.btnThoat.Location = new System.Drawing.Point(637, 394);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 26);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "&Đóng";
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Save;
            this.btnLuu.Location = new System.Drawing.Point(533, 394);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 26);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "&Lưu";
            // 
            // ucButton3
            // 
            this.ucButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucButton3.Appearance.Options.UseFont = true;
            this.ucButton3.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Save;
            this.ucButton3.Location = new System.Drawing.Point(429, 394);
            this.ucButton3.Name = "ucButton3";
            this.ucButton3.Size = new System.Drawing.Size(100, 26);
            this.ucButton3.TabIndex = 2;
            this.ucButton3.Text = "Lưu &và đóng";
            // 
            // ucGroupBox1
            // 
            this.ucGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucGroupBox1.Location = new System.Drawing.Point(1, 27);
            this.ucGroupBox1.Name = "ucGroupBox1";
            this.ucGroupBox1.Size = new System.Drawing.Size(736, 361);
            this.ucGroupBox1.TabIndex = 3;
            this.ucGroupBox1.TabStop = false;
            this.ucGroupBox1.Text = "DANH SÁCH CÔNG VIỆC";
            // 
            // chkTatCa
            // 
            this.chkTatCa.AutoSize = true;
            this.chkTatCa.FieldGroup = "";
            this.chkTatCa.FieldName = "";
            this.chkTatCa.Location = new System.Drawing.Point(718, 7);
            this.chkTatCa.Name = "chkTatCa";
            this.chkTatCa.Size = new System.Drawing.Size(15, 14);
            this.chkTatCa.TabIndex = 4;
            this.chkTatCa.UseVisualStyleBackColor = true;
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(635, 8);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(77, 13);
            this.ucLabel1.TabIndex = 5;
            this.ucLabel1.Text = "Chọn hủy tất cả";
            // 
            // frmThongBao_NhacViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 422);
            this.Controls.Add(this.ucLabel1);
            this.Controls.Add(this.chkTatCa);
            this.Controls.Add(this.ucGroupBox1);
            this.Controls.Add(this.ucButton3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmThongBao_NhacViec";
            this.Text = "THÔNG BÁO NHẮC VIỆC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucButton btnThoat;
        private VSCM.Base.Controls.ucButton btnLuu;
        private VSCM.Base.Controls.ucButton ucButton3;
        private VSCM.Base.Controls.ucGroupBox ucGroupBox1;
        private VSCM.Base.Controls.ucCheckBox chkTatCa;
        private VSCM.Base.Controls.ucLabel ucLabel1;
    }
}