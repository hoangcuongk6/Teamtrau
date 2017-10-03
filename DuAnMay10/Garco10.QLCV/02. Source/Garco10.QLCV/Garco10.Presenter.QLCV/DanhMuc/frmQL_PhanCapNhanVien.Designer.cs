namespace Garco10.Presenter.QLCV
{
    partial class frmQL_PhanCapNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQL_PhanCapNhanVien));
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.cmbNguoiQuanLy = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gbThongTin = new VSCM.Base.Controls.ucGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNhanVien = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.btnSua = new VSCM.Base.Controls.ucButton();
            this.btnThemMoi = new VSCM.Base.Controls.ucButton();
            this.btnXoa = new VSCM.Base.Controls.ucButton();
            this.btnThoat = new VSCM.Base.Controls.ucButton();
            this.btnHuy = new VSCM.Base.Controls.ucButton();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNguoiQuanLy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            this.gbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhanVien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fg
            // 
            this.fg.AllowEditing = false;
            this.fg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fg.ColumnInfo = resources.GetString("fg.ColumnInfo");
            this.fg.ExtendLastCol = true;
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(1, 5);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 18;
            this.fg.Rows.MinSize = 21;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fg.Size = new System.Drawing.Size(606, 442);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 0;
            this.fg.AfterRowChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.fg_AfterRowChange);
            // 
            // cmbNguoiQuanLy
            // 
            this.cmbNguoiQuanLy.FieldGroup = "";
            this.cmbNguoiQuanLy.FieldName = "";
            this.cmbNguoiQuanLy.Location = new System.Drawing.Point(89, 20);
            this.cmbNguoiQuanLy.Name = "cmbNguoiQuanLy";
            this.cmbNguoiQuanLy.Properties.AutoHeight = false;
            this.cmbNguoiQuanLy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNguoiQuanLy.Properties.DisplayMember = "HoTen";
            this.cmbNguoiQuanLy.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbNguoiQuanLy.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbNguoiQuanLy.Properties.NullText = "";
            this.cmbNguoiQuanLy.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbNguoiQuanLy.Properties.ValueMember = "ID_NhanSu";
            this.cmbNguoiQuanLy.Properties.View = this.ucSearchLookupEdit1View;
            this.cmbNguoiQuanLy.Size = new System.Drawing.Size(203, 23);
            this.cmbNguoiQuanLy.TabIndex = 1;
            this.cmbNguoiQuanLy.EditValueChanged += new System.EventHandler(this.cmbNguoiQuanLy_EditValueChanged);
            // 
            // ucSearchLookupEdit1View
            // 
            this.ucSearchLookupEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.ucSearchLookupEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ucSearchLookupEdit1View.Name = "ucSearchLookupEdit1View";
            this.ucSearchLookupEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID_NguoiQuanLy";
            this.gridColumn1.FieldName = "ID_NhanSu";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Người quản lý";
            this.gridColumn2.FieldName = "HoTen";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Người quản lý:";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Controls.Add(this.cmbNguoiQuanLy);
            this.gbThongTin.Controls.Add(this.cmbNhanVien);
            this.gbThongTin.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbThongTin.Location = new System.Drawing.Point(1, 453);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(606, 59);
            this.gbThongTin.TabIndex = 1;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "Thông tin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhân viên :";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.Location = new System.Drawing.Point(378, 20);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Properties.AutoHeight = false;
            this.cmbNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNhanVien.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbNhanVien.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbNhanVien.Size = new System.Drawing.Size(221, 23);
            this.cmbNhanVien.TabIndex = 2;
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Edit;
            this.btnSua.Location = new System.Drawing.Point(105, 518);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 26);
            this.btnSua.TabIndex = 3;
            this.btnSua.Tag = "0";
            this.btnSua.Text = "&Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Add;
            this.btnThemMoi.Location = new System.Drawing.Point(3, 518);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(98, 26);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Tag = "0";
            this.btnThemMoi.Text = "&Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Delete;
            this.btnXoa.Location = new System.Drawing.Point(206, 518);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 26);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Tag = "0";
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.btnThoat.Location = new System.Drawing.Point(508, 518);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 26);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Tag = "0";
            this.btnThoat.Text = "&Đóng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Back;
            this.btnHuy.Location = new System.Drawing.Point(105, 518);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 26);
            this.btnHuy.TabIndex = 13;
            this.btnHuy.Tag = "0";
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Save;
            this.btnLuu.Location = new System.Drawing.Point(3, 518);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 26);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Tag = "0";
            this.btnLuu.Text = "&Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmQL_PhanCapNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 549);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.fg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQL_PhanCapNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÂN CẤP NHÂN VIÊN";
            this.Load += new System.EventHandler(this.frmQL_PhanCapNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNguoiQuanLy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhanVien.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbNguoiQuanLy;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private System.Windows.Forms.Label label1;
        private VSCM.Base.Controls.ucGroupBox gbThongTin;
        private System.Windows.Forms.Label label2;
        private VSCM.Base.Controls.ucButton btnSua;
        private VSCM.Base.Controls.ucButton btnThemMoi;
        private VSCM.Base.Controls.ucButton btnXoa;
        private VSCM.Base.Controls.ucButton btnThoat;
        private VSCM.Base.Controls.ucButton btnHuy;
        private VSCM.Base.Controls.ucButton btnLuu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbNhanVien;
    }
}