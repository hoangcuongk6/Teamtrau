namespace Garco10.Presenter.QLCV.DanhMuc
{
    partial class frmNhom_Ban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhom_Ban));
            this.grbBan_Nhom = new VSCM.Base.Controls.ucGroupBox();
            this.fgBan_Nhom = new VSCM.Base.Controls.ucFlexGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_ThemMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ExpandAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CollapseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.btnThemMoi = new VSCM.Base.Controls.ucButton();
            this.btnXoa = new VSCM.Base.Controls.ucButton();
            this.btnSua = new VSCM.Base.Controls.ucButton();
            this.grbNhanSu_Nhom = new VSCM.Base.Controls.ucGroupBox();
            this.fgNS_Nhom = new VSCM.Base.Controls.ucFlexGrid();
            this.btnChonNS = new VSCM.Base.Controls.ucButton();
            this.btnCapNhat = new VSCM.Base.Controls.ucButton();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            this.btnHuy = new VSCM.Base.Controls.ucButton();
            this.grbBan_Nhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgBan_Nhom)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.grbNhanSu_Nhom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgNS_Nhom)).BeginInit();
            this.SuspendLayout();
            // 
            // grbBan_Nhom
            // 
            this.grbBan_Nhom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbBan_Nhom.Controls.Add(this.fgBan_Nhom);
            this.grbBan_Nhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBan_Nhom.Location = new System.Drawing.Point(0, 0);
            this.grbBan_Nhom.Name = "grbBan_Nhom";
            this.grbBan_Nhom.Size = new System.Drawing.Size(433, 470);
            this.grbBan_Nhom.TabIndex = 0;
            this.grbBan_Nhom.TabStop = false;
            this.grbBan_Nhom.Text = "Danh sách Ban - Nhóm";
            // 
            // fgBan_Nhom
            // 
            this.fgBan_Nhom.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgBan_Nhom.ColumnInfo = resources.GetString("fgBan_Nhom.ColumnInfo");
            this.fgBan_Nhom.ContextMenuStrip = this.contextMenuStrip1;
            this.fgBan_Nhom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgBan_Nhom.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgBan_Nhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgBan_Nhom.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgBan_Nhom.Location = new System.Drawing.Point(3, 16);
            this.fgBan_Nhom.Name = "fgBan_Nhom";
            this.fgBan_Nhom.Rows.Count = 1;
            this.fgBan_Nhom.Rows.DefaultSize = 18;
            this.fgBan_Nhom.Rows.MinSize = 21;
            this.fgBan_Nhom.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgBan_Nhom.Size = new System.Drawing.Size(427, 451);
            this.fgBan_Nhom.StyleInfo = resources.GetString("fgBan_Nhom.StyleInfo");
            this.fgBan_Nhom.TabIndex = 0;
            this.fgBan_Nhom.AfterRowChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgBan_Nhom_AfterRowChange);
            this.fgBan_Nhom.DoubleClick += new System.EventHandler(this.fgBan_Nhom_DoubleClick);
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
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Add;
            this.btnThemMoi.Location = new System.Drawing.Point(6, 476);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(100, 26);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Delete;
            this.btnXoa.Location = new System.Drawing.Point(218, 476);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 26);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Edit;
            this.btnSua.Location = new System.Drawing.Point(112, 476);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 26);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grbNhanSu_Nhom
            // 
            this.grbNhanSu_Nhom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbNhanSu_Nhom.Controls.Add(this.fgNS_Nhom);
            this.grbNhanSu_Nhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNhanSu_Nhom.Location = new System.Drawing.Point(439, 0);
            this.grbNhanSu_Nhom.Name = "grbNhanSu_Nhom";
            this.grbNhanSu_Nhom.Size = new System.Drawing.Size(559, 470);
            this.grbNhanSu_Nhom.TabIndex = 6;
            this.grbNhanSu_Nhom.TabStop = false;
            this.grbNhanSu_Nhom.Text = "Danh sách nhân sự trong Ban - Nhóm";
            // 
            // fgNS_Nhom
            // 
            this.fgNS_Nhom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgNS_Nhom.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgNS_Nhom.ColumnInfo = resources.GetString("fgNS_Nhom.ColumnInfo");
            this.fgNS_Nhom.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgNS_Nhom.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgNS_Nhom.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgNS_Nhom.Location = new System.Drawing.Point(6, 20);
            this.fgNS_Nhom.Name = "fgNS_Nhom";
            this.fgNS_Nhom.Rows.Count = 1;
            this.fgNS_Nhom.Rows.DefaultSize = 18;
            this.fgNS_Nhom.Rows.MinSize = 21;
            this.fgNS_Nhom.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgNS_Nhom.Size = new System.Drawing.Size(547, 441);
            this.fgNS_Nhom.StyleInfo = resources.GetString("fgNS_Nhom.StyleInfo");
            this.fgNS_Nhom.TabIndex = 0;
            this.fgNS_Nhom.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgNS_Nhom_AfterEdit);
            this.fgNS_Nhom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgNS_Nhom_KeyUp);
            // 
            // btnChonNS
            // 
            this.btnChonNS.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonNS.Appearance.Options.UseFont = true;
            this.btnChonNS.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Check;
            this.btnChonNS.Location = new System.Drawing.Point(324, 476);
            this.btnChonNS.Name = "btnChonNS";
            this.btnChonNS.Size = new System.Drawing.Size(100, 26);
            this.btnChonNS.TabIndex = 5;
            this.btnChonNS.Text = "Chọn nhân sự";
            this.btnChonNS.Click += new System.EventHandler(this.btnChonNS_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Edit;
            this.btnCapNhat.Location = new System.Drawing.Point(445, 476);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 26);
            this.btnCapNhat.TabIndex = 7;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Save;
            this.btnLuu.Location = new System.Drawing.Point(445, 476);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 26);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Back;
            this.btnHuy.Location = new System.Drawing.Point(551, 476);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 26);
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmNhom_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1002, 508);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.grbNhanSu_Nhom);
            this.Controls.Add(this.btnChonNS);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.grbBan_Nhom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmNhom_Ban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAN - NHÓM";
            this.Load += new System.EventHandler(this.frmNhom_Ban_Load);
            this.grbBan_Nhom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgBan_Nhom)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.grbNhanSu_Nhom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgNS_Nhom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucGroupBox grbBan_Nhom;
        private VSCM.Base.Controls.ucFlexGrid fgBan_Nhom;
        private VSCM.Base.Controls.ucButton btnThemMoi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_ExpandAll;
        private System.Windows.Forms.ToolStripMenuItem mnu_CollapseAll;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThemMoi;
        private VSCM.Base.Controls.ucButton btnXoa;
        private VSCM.Base.Controls.ucButton btnSua;
        private System.Windows.Forms.ToolStripMenuItem mnu_Xoa;
        private VSCM.Base.Controls.ucGroupBox grbNhanSu_Nhom;
        private VSCM.Base.Controls.ucFlexGrid fgNS_Nhom;
        private VSCM.Base.Controls.ucButton btnChonNS;
        private VSCM.Base.Controls.ucButton btnCapNhat;
        private VSCM.Base.Controls.ucButton btnLuu;
        private VSCM.Base.Controls.ucButton btnHuy;
    }
}