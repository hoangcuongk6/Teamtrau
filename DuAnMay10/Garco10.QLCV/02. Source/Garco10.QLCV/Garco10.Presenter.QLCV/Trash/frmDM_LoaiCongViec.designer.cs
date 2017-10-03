namespace Garco10.Presenter.QLCV.DanhMuc
{
    partial class frmDM_LoaiCongViec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_LoaiCongViec));
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.txtTimKiem = new VSCM.Base.Controls.ucTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_ThemMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoa = new VSCM.Base.Controls.ucButton();
            this.btnSua = new VSCM.Base.Controls.ucButton();
            this.btnThemMoi = new VSCM.Base.Controls.ucButton();
            this.btnThoat = new VSCM.Base.Controls.ucButton();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
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
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(2, 37);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 18;
            this.fg.Rows.MinSize = 21;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fg.Size = new System.Drawing.Size(714, 554);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 1;
            this.fg.DoubleClick += new System.EventHandler(this.fg_DoubleClick);
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.Appearance.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Search;
            this.ucLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(160, 6);
            this.ucLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(23, 23);
            this.ucLabel1.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.FieldGroup = "";
            this.txtTimKiem.FieldName = "";
            this.txtTimKiem.Location = new System.Drawing.Point(4, 7);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.AutoHeight = false;
            this.txtTimKiem.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtTimKiem.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtTimKiem.Properties.Name = "fProperties";
            this.txtTimKiem.Properties.NullValuePrompt = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTimKiem.Size = new System.Drawing.Size(150, 23);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.EditValueChanged += new System.EventHandler(this.txtTimKiem_EditValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ThemMoi,
            this.mnu_Xoa,
            this.mnu_ExpandAll,
            this.mnu_CollapseAll});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 92);
            // 
            // mnu_ThemMoi
            // 
            this.mnu_ThemMoi.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Add;
            this.mnu_ThemMoi.Name = "mnu_ThemMoi";
            this.mnu_ThemMoi.Size = new System.Drawing.Size(151, 22);
            this.mnu_ThemMoi.Text = "Thêm mới";
            this.mnu_ThemMoi.Click += new System.EventHandler(this.mnu_ThemMoi_Click);
            // 
            // mnu_Xoa
            // 
            this.mnu_Xoa.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Delete;
            this.mnu_Xoa.Name = "mnu_Xoa";
            this.mnu_Xoa.Size = new System.Drawing.Size(151, 22);
            this.mnu_Xoa.Text = "Xóa";
            this.mnu_Xoa.Click += new System.EventHandler(this.mnu_Xoa_Click);
            // 
            // mnu_ExpandAll
            // 
            this.mnu_ExpandAll.Image = global::Garco10.Presenter.QLCV.Properties.Resources.expand;
            this.mnu_ExpandAll.Name = "mnu_ExpandAll";
            this.mnu_ExpandAll.Size = new System.Drawing.Size(151, 22);
            this.mnu_ExpandAll.Text = "Hiển thị tất cả";
            this.mnu_ExpandAll.Click += new System.EventHandler(this.mnu_ExpandAll_Click);
            // 
            // mnu_CollapseAll
            // 
            this.mnu_CollapseAll.Image = global::Garco10.Presenter.QLCV.Properties.Resources.collapse;
            this.mnu_CollapseAll.Name = "mnu_CollapseAll";
            this.mnu_CollapseAll.Size = new System.Drawing.Size(151, 22);
            this.mnu_CollapseAll.Text = "Thu nhỏ tất cả";
            this.mnu_CollapseAll.Click += new System.EventHandler(this.mnu_CollapseAll_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Delete;
            this.btnXoa.Location = new System.Drawing.Point(214, 599);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 27);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Tag = "0";
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Edit;
            this.btnSua.Location = new System.Drawing.Point(108, 599);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 27);
            this.btnSua.TabIndex = 20;
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
            this.btnThemMoi.Location = new System.Drawing.Point(2, 599);
            this.btnThemMoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(98, 27);
            this.btnThemMoi.TabIndex = 22;
            this.btnThemMoi.Tag = "0";
            this.btnThemMoi.Text = "&Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
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
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmDM_LoaiCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 632);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.ucLabel1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.fg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDM_LoaiCongViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục loại công việc";
            this.Load += new System.EventHandler(this.frmDM_LoaiCongViec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucTextBox txtTimKiem;
        private VSCM.Base.Controls.ucButton btnThoat;
        private VSCM.Base.Controls.ucButton btnSua;
        private VSCM.Base.Controls.ucButton btnThemMoi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThemMoi;
        private System.Windows.Forms.ToolStripMenuItem mnu_Xoa;
        private System.Windows.Forms.ToolStripMenuItem mnu_ExpandAll;
        private System.Windows.Forms.ToolStripMenuItem mnu_CollapseAll;
        private VSCM.Base.Controls.ucButton btnXoa;
    }
}
