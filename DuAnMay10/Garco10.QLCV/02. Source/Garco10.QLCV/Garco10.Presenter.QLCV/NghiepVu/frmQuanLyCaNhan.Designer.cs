namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmQuanLyCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyCaNhan));
            this.ucGroupBox2 = new VSCM.Base.Controls.ucGroupBox();
            this.cbChiHienThiViecQuaHan = new VSCM.Base.Controls.ucCheckBox();
            this.chkHienThiKhiCoCV = new VSCM.Base.Controls.ucCheckBox();
            this.lblNgayYeuCau = new VSCM.Base.Controls.ucTextBox();
            this.dteNgayBatDau = new VSCM.Base.Controls.ucDateEdit();
            this.dteNgayKetThuc = new VSCM.Base.Controls.ucDateEdit();
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_ThemMoi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ThemMoiCon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ThemCVLap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Sua = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Expand = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Collapse = new System.Windows.Forms.ToolStripMenuItem();
            this.ucGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblNgayYeuCau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayBatDau)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayKetThuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucGroupBox2
            // 
            this.ucGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGroupBox2.Controls.Add(this.cbChiHienThiViecQuaHan);
            this.ucGroupBox2.Controls.Add(this.chkHienThiKhiCoCV);
            this.ucGroupBox2.Controls.Add(this.lblNgayYeuCau);
            this.ucGroupBox2.Controls.Add(this.dteNgayBatDau);
            this.ucGroupBox2.Controls.Add(this.dteNgayKetThuc);
            this.ucGroupBox2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.ucGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.ucGroupBox2.Name = "ucGroupBox2";
            this.ucGroupBox2.Size = new System.Drawing.Size(843, 76);
            this.ucGroupBox2.TabIndex = 13;
            this.ucGroupBox2.TabStop = false;
            this.ucGroupBox2.Text = "Chọn thông tin";
            // 
            // cbChiHienThiViecQuaHan
            // 
            this.cbChiHienThiViecQuaHan.AutoSize = true;
            this.cbChiHienThiViecQuaHan.FieldGroup = "";
            this.cbChiHienThiViecQuaHan.FieldName = "";
            this.cbChiHienThiViecQuaHan.ForeColor = System.Drawing.Color.Red;
            this.cbChiHienThiViecQuaHan.Location = new System.Drawing.Point(274, 19);
            this.cbChiHienThiViecQuaHan.Name = "cbChiHienThiViecQuaHan";
            this.cbChiHienThiViecQuaHan.Size = new System.Drawing.Size(97, 17);
            this.cbChiHienThiViecQuaHan.TabIndex = 61;
            this.cbChiHienThiViecQuaHan.Text = "Việc quá hạn";
            this.cbChiHienThiViecQuaHan.UseVisualStyleBackColor = true;
            this.cbChiHienThiViecQuaHan.CheckedChanged += new System.EventHandler(this.cbChiHienThiViecQuaHan_CheckedChanged);
            // 
            // chkHienThiKhiCoCV
            // 
            this.chkHienThiKhiCoCV.AutoSize = true;
            this.chkHienThiKhiCoCV.FieldGroup = "";
            this.chkHienThiKhiCoCV.FieldName = "";
            this.chkHienThiKhiCoCV.Location = new System.Drawing.Point(274, 45);
            this.chkHienThiKhiCoCV.Name = "chkHienThiKhiCoCV";
            this.chkHienThiKhiCoCV.Size = new System.Drawing.Size(122, 17);
            this.chkHienThiKhiCoCV.TabIndex = 8;
            this.chkHienThiKhiCoCV.Text = "Hiển thị khi có CV";
            this.chkHienThiKhiCoCV.UseVisualStyleBackColor = true;
            this.chkHienThiKhiCoCV.CheckedChanged += new System.EventHandler(this.chkHienThiKhiCoCV_CheckedChanged);
            // 
            // lblNgayYeuCau
            // 
            this.lblNgayYeuCau.EditValue = "* Khoảng thời gian";
            this.lblNgayYeuCau.FieldGroup = "";
            this.lblNgayYeuCau.FieldName = "";
            this.lblNgayYeuCau.Location = new System.Drawing.Point(6, 19);
            this.lblNgayYeuCau.Name = "lblNgayYeuCau";
            this.lblNgayYeuCau.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNgayYeuCau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNgayYeuCau.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNgayYeuCau.Properties.Appearance.Options.UseBackColor = true;
            this.lblNgayYeuCau.Properties.Appearance.Options.UseFont = true;
            this.lblNgayYeuCau.Properties.Appearance.Options.UseForeColor = true;
            this.lblNgayYeuCau.Properties.Appearance.Options.UseTextOptions = true;
            this.lblNgayYeuCau.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblNgayYeuCau.Properties.AutoHeight = false;
            this.lblNgayYeuCau.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.lblNgayYeuCau.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.lblNgayYeuCau.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.lblNgayYeuCau.Properties.Name = "fProperties";
            this.lblNgayYeuCau.Size = new System.Drawing.Size(262, 23);
            this.lblNgayYeuCau.TabIndex = 9;
            // 
            // dteNgayBatDau
            // 
            this.dteNgayBatDau.AutoSize = false;
            this.dteNgayBatDau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dteNgayBatDau.Calendar.BackColor = System.Drawing.SystemColors.Window;
            this.dteNgayBatDau.Calendar.DayNameLength = 1;
            this.dteNgayBatDau.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.dteNgayBatDau.DisplayFormat.EmptyAsNull = true;
            this.dteNgayBatDau.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dteNgayBatDau.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dteNgayBatDau.EditFormat.CustomFormat = "dd/MM/yyyy";
            this.dteNgayBatDau.EditFormat.EmptyAsNull = true;
            this.dteNgayBatDau.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dteNgayBatDau.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dteNgayBatDau.FieldGroup = "";
            this.dteNgayBatDau.FieldName = "";
            this.dteNgayBatDau.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortTime;
            this.dteNgayBatDau.Location = new System.Drawing.Point(6, 43);
            this.dteNgayBatDau.Name = "dteNgayBatDau";
            this.dteNgayBatDau.Size = new System.Drawing.Size(130, 23);
            this.dteNgayBatDau.TabIndex = 0;
            this.dteNgayBatDau.Tag = null;
            this.dteNgayBatDau.Value = new System.DateTime(2017, 5, 4, 0, 0, 0, 0);
            this.dteNgayBatDau.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dteNgayBatDau.ValueChanged += new System.EventHandler(this.dteNgayBatDau_ValueChanged);
            // 
            // dteNgayKetThuc
            // 
            this.dteNgayKetThuc.AutoSize = false;
            this.dteNgayKetThuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dteNgayKetThuc.Calendar.BackColor = System.Drawing.SystemColors.Window;
            this.dteNgayKetThuc.Calendar.DayNameLength = 1;
            this.dteNgayKetThuc.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.dteNgayKetThuc.DisplayFormat.EmptyAsNull = true;
            this.dteNgayKetThuc.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dteNgayKetThuc.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dteNgayKetThuc.EditFormat.CustomFormat = "dd/MM/yyyy";
            this.dteNgayKetThuc.EditFormat.EmptyAsNull = true;
            this.dteNgayKetThuc.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dteNgayKetThuc.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dteNgayKetThuc.FieldGroup = "";
            this.dteNgayKetThuc.FieldName = "";
            this.dteNgayKetThuc.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortTime;
            this.dteNgayKetThuc.Location = new System.Drawing.Point(138, 43);
            this.dteNgayKetThuc.Name = "dteNgayKetThuc";
            this.dteNgayKetThuc.Size = new System.Drawing.Size(130, 23);
            this.dteNgayKetThuc.TabIndex = 1;
            this.dteNgayKetThuc.Tag = null;
            this.dteNgayKetThuc.Value = new System.DateTime(2017, 5, 4, 14, 26, 17, 0);
            this.dteNgayKetThuc.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dteNgayKetThuc.ValueChanged += new System.EventHandler(this.dteNgayKetThuc_ValueChanged);
            // 
            // fg
            // 
            this.fg.AllowEditing = false;
            this.fg.AllowFiltering = true;
            this.fg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fg.ColumnInfo = resources.GetString("fg.ColumnInfo");
            this.fg.ContextMenuStrip = this.contextMenuStrip1;
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(0, 72);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 18;
            this.fg.Rows.MinSize = 21;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fg.Size = new System.Drawing.Size(843, 602);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 14;
            this.fg.DoubleClick += new System.EventHandler(this.fg_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_ThemMoi,
            this.mnu_ThemMoiCon,
            this.mnu_ThemCVLap,
            this.mnu_Sua,
            this.mnu_Xoa,
            this.mnu_Expand,
            this.mnu_Collapse});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 158);
            // 
            // mnu_ThemMoi
            // 
            this.mnu_ThemMoi.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Add;
            this.mnu_ThemMoi.Name = "mnu_ThemMoi";
            this.mnu_ThemMoi.Size = new System.Drawing.Size(178, 22);
            this.mnu_ThemMoi.Text = "Thêm mới";
            // 
            // mnu_ThemMoiCon
            // 
            this.mnu_ThemMoiCon.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Add;
            this.mnu_ThemMoiCon.Name = "mnu_ThemMoiCon";
            this.mnu_ThemMoiCon.Size = new System.Drawing.Size(178, 22);
            this.mnu_ThemMoiCon.Text = "Thêm mới con";
            // 
            // mnu_ThemCVLap
            // 
            this.mnu_ThemCVLap.Image = global::Garco10.Presenter.QLCV.Properties.Resources.LapLai;
            this.mnu_ThemCVLap.Name = "mnu_ThemCVLap";
            this.mnu_ThemCVLap.Size = new System.Drawing.Size(178, 22);
            this.mnu_ThemCVLap.Text = "Thêm công việc lặp";
            // 
            // mnu_Sua
            // 
            this.mnu_Sua.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Edit;
            this.mnu_Sua.Name = "mnu_Sua";
            this.mnu_Sua.Size = new System.Drawing.Size(178, 22);
            this.mnu_Sua.Text = "Sửa";
            this.mnu_Sua.Click += new System.EventHandler(this.mnu_Sua_Click);
            // 
            // mnu_Xoa
            // 
            this.mnu_Xoa.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Delete;
            this.mnu_Xoa.Name = "mnu_Xoa";
            this.mnu_Xoa.Size = new System.Drawing.Size(178, 22);
            this.mnu_Xoa.Text = "Xoá";
            // 
            // mnu_Expand
            // 
            this.mnu_Expand.Image = global::Garco10.Presenter.QLCV.Properties.Resources.expand;
            this.mnu_Expand.Name = "mnu_Expand";
            this.mnu_Expand.Size = new System.Drawing.Size(178, 22);
            this.mnu_Expand.Text = "Hiển thị tất cả";
            this.mnu_Expand.Click += new System.EventHandler(this.mnu_Expand_Click);
            // 
            // mnu_Collapse
            // 
            this.mnu_Collapse.Image = global::Garco10.Presenter.QLCV.Properties.Resources.collapse;
            this.mnu_Collapse.Name = "mnu_Collapse";
            this.mnu_Collapse.Size = new System.Drawing.Size(178, 22);
            this.mnu_Collapse.Text = "Thu gọn tất cả";
            this.mnu_Collapse.Click += new System.EventHandler(this.mnu_Collapse_Click);
            // 
            // frmQuanLyCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(846, 677);
            this.Controls.Add(this.fg);
            this.Controls.Add(this.ucGroupBox2);
            this.Name = "frmQuanLyCaNhan";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tiến độ";
            this.ucGroupBox2.ResumeLayout(false);
            this.ucGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblNgayYeuCau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayBatDau)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteNgayKetThuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucGroupBox ucGroupBox2;
        private VSCM.Base.Controls.ucTextBox lblNgayYeuCau;
        private VSCM.Base.Controls.ucDateEdit dteNgayBatDau;
        private VSCM.Base.Controls.ucDateEdit dteNgayKetThuc;
        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucCheckBox chkHienThiKhiCoCV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Expand;
        private System.Windows.Forms.ToolStripMenuItem mnu_Collapse;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThemMoi;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThemMoiCon;
        private System.Windows.Forms.ToolStripMenuItem mnu_Sua;
        private System.Windows.Forms.ToolStripMenuItem mnu_Xoa;
        private System.Windows.Forms.ToolStripMenuItem mnu_ThemCVLap;
        private VSCM.Base.Controls.ucCheckBox cbChiHienThiViecQuaHan;
    }
}
