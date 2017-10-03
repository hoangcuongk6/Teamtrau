namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmDoiKeHoach
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
            this.btnLuuLai = new VSCM.Base.Controls.ucButton();
            this.ucLabel2 = new VSCM.Base.Controls.ucLabel();
            this.ucLabel6 = new VSCM.Base.Controls.ucLabel();
            this.dtNgayYeuCau = new VSCM.Base.Controls.ucDateEdit();
            this.dtNgayDenHan = new VSCM.Base.Controls.ucDateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayYeuCau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDenHan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.btnThoat.Location = new System.Drawing.Point(308, 134);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 26);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "&Đóng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuuLai.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLai.Appearance.Options.UseFont = true;
            this.btnLuuLai.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Save;
            this.btnLuuLai.Location = new System.Drawing.Point(223, 134);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(79, 26);
            this.btnLuuLai.TabIndex = 4;
            this.btnLuuLai.Text = "&Lưu lại";
            this.btnLuuLai.Click += new System.EventHandler(this.btnLuuLai_Click);
            // 
            // ucLabel2
            // 
            this.ucLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel2.FieldGroup = "";
            this.ucLabel2.FieldName = "";
            this.ucLabel2.Location = new System.Drawing.Point(17, 27);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(95, 13);
            this.ucLabel2.TabIndex = 0;
            this.ucLabel2.Text = "Ngày bắt đầu KH:";
            // 
            // ucLabel6
            // 
            this.ucLabel6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel6.FieldGroup = "";
            this.ucLabel6.FieldName = "";
            this.ucLabel6.Location = new System.Drawing.Point(17, 91);
            this.ucLabel6.Name = "ucLabel6";
            this.ucLabel6.Size = new System.Drawing.Size(99, 13);
            this.ucLabel6.TabIndex = 2;
            this.ucLabel6.Text = "Ngày kết thúc KH:";
            // 
            // dtNgayYeuCau
            // 
            this.dtNgayYeuCau.AutoSize = false;
            this.dtNgayYeuCau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dtNgayYeuCau.Calendar.BackColor = System.Drawing.SystemColors.Window;
            this.dtNgayYeuCau.Calendar.DayNameLength = 1;
            this.dtNgayYeuCau.DisplayFormat.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtNgayYeuCau.DisplayFormat.EmptyAsNull = true;
            this.dtNgayYeuCau.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtNgayYeuCau.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtNgayYeuCau.EditFormat.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtNgayYeuCau.EditFormat.EmptyAsNull = true;
            this.dtNgayYeuCau.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtNgayYeuCau.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtNgayYeuCau.FieldGroup = "";
            this.dtNgayYeuCau.FieldName = "";
            this.dtNgayYeuCau.Location = new System.Drawing.Point(134, 23);
            this.dtNgayYeuCau.Name = "dtNgayYeuCau";
            this.dtNgayYeuCau.Size = new System.Drawing.Size(252, 21);
            this.dtNgayYeuCau.TabIndex = 1;
            this.dtNgayYeuCau.Tag = null;
            this.dtNgayYeuCau.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            // 
            // dtNgayDenHan
            // 
            this.dtNgayDenHan.AutoSize = false;
            this.dtNgayDenHan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dtNgayDenHan.Calendar.BackColor = System.Drawing.SystemColors.Window;
            this.dtNgayDenHan.Calendar.DayNameLength = 1;
            this.dtNgayDenHan.DisplayFormat.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtNgayDenHan.DisplayFormat.EmptyAsNull = true;
            this.dtNgayDenHan.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtNgayDenHan.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtNgayDenHan.EditFormat.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtNgayDenHan.EditFormat.EmptyAsNull = true;
            this.dtNgayDenHan.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtNgayDenHan.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtNgayDenHan.FieldGroup = "";
            this.dtNgayDenHan.FieldName = "";
            this.dtNgayDenHan.Location = new System.Drawing.Point(134, 87);
            this.dtNgayDenHan.Name = "dtNgayDenHan";
            this.dtNgayDenHan.Size = new System.Drawing.Size(252, 21);
            this.dtNgayDenHan.TabIndex = 3;
            this.dtNgayDenHan.Tag = null;
            this.dtNgayDenHan.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            // 
            // frmDoiKeHoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 167);
            this.Controls.Add(this.dtNgayDenHan);
            this.Controls.Add(this.dtNgayYeuCau);
            this.Controls.Add(this.btnLuuLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.ucLabel6);
            this.Controls.Add(this.ucLabel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoiKeHoach";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi kế hoạch thực hiện";
            this.Load += new System.EventHandler(this.frmLapLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayYeuCau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtNgayDenHan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucButton btnThoat;
        private VSCM.Base.Controls.ucButton btnLuuLai;
        private VSCM.Base.Controls.ucLabel ucLabel2;
        private VSCM.Base.Controls.ucLabel ucLabel6;
        private VSCM.Base.Controls.ucDateEdit dtNgayYeuCau;
        private VSCM.Base.Controls.ucDateEdit dtNgayDenHan;
    }
}