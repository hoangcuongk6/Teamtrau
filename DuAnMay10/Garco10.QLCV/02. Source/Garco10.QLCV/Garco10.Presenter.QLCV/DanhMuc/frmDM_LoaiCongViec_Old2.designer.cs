namespace Garco10.Presenter.QLCV.DanhMuc
{
    partial class frmDM_LoaiCongViec_Old2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_LoaiCongViec_Old2));
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.txtTimKiem = new VSCM.Base.Controls.ucTextBox();
            this.btnThoat = new VSCM.Base.Controls.ucButton();
            this.btnHuy = new VSCM.Base.Controls.ucButton();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            this.btnCapNhat = new VSCM.Base.Controls.ucButton();
            this.lblHuongDan = new VSCM.Base.Controls.ucLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_ThemMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ThemMoiCon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.ucLabel4 = new VSCM.Base.Controls.ucLabel();
            this.cmbDonVi = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucLabel2 = new VSCM.Base.Controls.ucLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // fg
            // 
            this.fg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fg.ColumnInfo = resources.GetString("fg.ColumnInfo");
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fg.ForeColor = System.Drawing.Color.Blue;
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(2, 36);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 18;
            this.fg.Rows.MinSize = 21;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fg.Size = new System.Drawing.Size(714, 555);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 1;
            this.fg.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fg_AfterEdit);
            this.fg.AfterCollapse += new C1.Win.C1FlexGrid.RowColEventHandler(this.fg_AfterCollapse);
            this.fg.DoubleClick += new System.EventHandler(this.fg_DoubleClick);
            this.fg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fg_KeyDown);
            this.fg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fg_KeyUp);
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.Appearance.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Search;
            this.ucLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(539, 9);
            this.ucLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(23, 23);
            this.ucLabel1.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.FieldGroup = "";
            this.txtTimKiem.FieldName = "";
            this.txtTimKiem.Location = new System.Drawing.Point(325, 7);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.AutoHeight = false;
            this.txtTimKiem.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtTimKiem.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtTimKiem.Properties.Name = "fProperties";
            this.txtTimKiem.Properties.NullValuePrompt = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTimKiem.Size = new System.Drawing.Size(207, 23);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.EditValueChanged += new System.EventHandler(this.txtTimKiem_EditValueChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.btnThoat.Location = new System.Drawing.Point(618, 599);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(98, 26);
            this.btnThoat.TabIndex = 19;
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
            this.btnHuy.Location = new System.Drawing.Point(104, 599);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 27);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Tag = "0";
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Save;
            this.btnLuu.Location = new System.Drawing.Point(2, 599);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 27);
            this.btnLuu.TabIndex = 20;
            this.btnLuu.Tag = "0";
            this.btnLuu.Text = "&Lưu lại";
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Edit;
            this.btnCapNhat.Location = new System.Drawing.Point(2, 599);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(98, 27);
            this.btnCapNhat.TabIndex = 22;
            this.btnCapNhat.Tag = "0";
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHuongDan.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuongDan.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblHuongDan.FieldGroup = "";
            this.lblHuongDan.FieldName = "";
            this.lblHuongDan.Location = new System.Drawing.Point(265, 605);
            this.lblHuongDan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(211, 13);
            this.lblHuongDan.TabIndex = 23;
            this.lblHuongDan.Text = "(Bấm \"Insert\" để thêm mới, \"Delete\" để xóa)";
            this.lblHuongDan.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ThemMoi,
            this.mnu_ThemMoiCon,
            this.mnu_Xoa,
            this.mnu_ExpandAll,
            this.mnu_CollapseAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 114);
            // 
            // mnu_ThemMoi
            // 
            this.mnu_ThemMoi.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Add;
            this.mnu_ThemMoi.Name = "mnu_ThemMoi";
            this.mnu_ThemMoi.Size = new System.Drawing.Size(152, 22);
            this.mnu_ThemMoi.Text = "Thêm mới";
            this.mnu_ThemMoi.Click += new System.EventHandler(this.mnu_ThemMoi_Click);
            // 
            // mnu_ThemMoiCon
            // 
            this.mnu_ThemMoiCon.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Add;
            this.mnu_ThemMoiCon.Name = "mnu_ThemMoiCon";
            this.mnu_ThemMoiCon.Size = new System.Drawing.Size(152, 22);
            this.mnu_ThemMoiCon.Text = "Thêm mới con";
            this.mnu_ThemMoiCon.Click += new System.EventHandler(this.mnu_ThemMoiCon_Click);
            // 
            // mnu_Xoa
            // 
            this.mnu_Xoa.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Delete;
            this.mnu_Xoa.Name = "mnu_Xoa";
            this.mnu_Xoa.Size = new System.Drawing.Size(152, 22);
            this.mnu_Xoa.Text = "Xóa";
            this.mnu_Xoa.Click += new System.EventHandler(this.mnu_Xoa_Click);
            // 
            // mnu_ExpandAll
            // 
            this.mnu_ExpandAll.Image = global::Garco10.Presenter.QLCV.Properties.Resources.expand;
            this.mnu_ExpandAll.Name = "mnu_ExpandAll";
            this.mnu_ExpandAll.Size = new System.Drawing.Size(152, 22);
            this.mnu_ExpandAll.Text = "Hiển thị tất cả";
            this.mnu_ExpandAll.Click += new System.EventHandler(this.mnu_ExpandAll_Click);
            // 
            // mnu_CollapseAll
            // 
            this.mnu_CollapseAll.Image = global::Garco10.Presenter.QLCV.Properties.Resources.collapse;
            this.mnu_CollapseAll.Name = "mnu_CollapseAll";
            this.mnu_CollapseAll.Size = new System.Drawing.Size(152, 22);
            this.mnu_CollapseAll.Text = "Thu nhỏ tất cả";
            this.mnu_CollapseAll.Click += new System.EventHandler(this.mnu_CollapseAll_Click);
            // 
            // ucLabel4
            // 
            this.ucLabel4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel4.FieldGroup = "";
            this.ucLabel4.FieldName = "";
            this.ucLabel4.Location = new System.Drawing.Point(3, 11);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(35, 13);
            this.ucLabel4.TabIndex = 739;
            this.ucLabel4.Text = "Đơn vị:";
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.FieldGroup = "";
            this.cmbDonVi.FieldName = "";
            this.cmbDonVi.Location = new System.Drawing.Point(52, 8);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Properties.AutoHeight = false;
            this.cmbDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDonVi.Properties.DisplayMember = "Ten_DonVi";
            this.cmbDonVi.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbDonVi.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbDonVi.Properties.NullText = "";
            this.cmbDonVi.Properties.ValueMember = "ID_DonVi";
            this.cmbDonVi.Properties.View = this.ucSearchLookupEdit1View;
            this.cmbDonVi.Size = new System.Drawing.Size(207, 21);
            this.cmbDonVi.TabIndex = 738;
            this.cmbDonVi.EditValueChanged += new System.EventHandler(this.cmbDonVi_EditValueChanged);
            // 
            // ucSearchLookupEdit1View
            // 
            this.ucSearchLookupEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.ucSearchLookupEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ucSearchLookupEdit1View.Name = "ucSearchLookupEdit1View";
            this.ucSearchLookupEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.ucSearchLookupEdit1View.OptionsView.ShowColumnHeaders = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "ID_DonVi";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "Ten_DonVi";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // ucLabel2
            // 
            this.ucLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel2.FieldGroup = "";
            this.ucLabel2.FieldName = "";
            this.ucLabel2.Location = new System.Drawing.Point(276, 11);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(44, 13);
            this.ucLabel2.TabIndex = 739;
            this.ucLabel2.Text = "Tìm kiếm:";
            // 
            // frmDM_LoaiCongViec_Old2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 632);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.ucLabel2);
            this.Controls.Add(this.ucLabel4);
            this.Controls.Add(this.cmbDonVi);
            this.Controls.Add(this.lblHuongDan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.ucLabel1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.fg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDM_LoaiCongViec_Old2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH MỤC LOẠI CÔNG VIỆC";
            this.Load += new System.EventHandler(this.frmDM_LoaiCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucTextBox txtTimKiem;
        private VSCM.Base.Controls.ucButton btnThoat;
        private VSCM.Base.Controls.ucButton btnHuy;
        private VSCM.Base.Controls.ucButton btnLuu;
        private VSCM.Base.Controls.ucButton btnCapNhat;
        private VSCM.Base.Controls.ucLabel lblHuongDan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThemMoi;
        private System.Windows.Forms.ToolStripMenuItem mnu_Xoa;
        private System.Windows.Forms.ToolStripMenuItem mnu_ExpandAll;
        private System.Windows.Forms.ToolStripMenuItem mnu_CollapseAll;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThemMoiCon;
        private VSCM.Base.Controls.ucLabel ucLabel4;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private VSCM.Base.Controls.ucLabel ucLabel2;
    }
}
