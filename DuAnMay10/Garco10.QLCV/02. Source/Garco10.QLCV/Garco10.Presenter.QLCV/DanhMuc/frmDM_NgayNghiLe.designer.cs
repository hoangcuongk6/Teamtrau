namespace Garco10.Presenter.QLCV.DanhMuc
{
    partial class frmDM_NgayNghiLe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDM_NgayNghiLe));
            this.ucGroupBox1 = new VSCM.Base.Controls.ucGroupBox();
            this.ucLabel4 = new VSCM.Base.Controls.ucLabel();
            this.cmbDonVi = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.cmbNam = new VSCM.Base.Controls.ucComboBox();
            this.ucGroupBox2 = new VSCM.Base.Controls.ucGroupBox();
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.btnCapNhat = new VSCM.Base.Controls.ucButton();
            this.btnThoat = new VSCM.Base.Controls.ucButton();
            this.btnLuuLai = new VSCM.Base.Controls.ucButton();
            this.btnHuy = new VSCM.Base.Controls.ucButton();
            this.ucGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNam)).BeginInit();
            this.ucGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGroupBox1
            // 
            this.ucGroupBox1.Controls.Add(this.ucLabel4);
            this.ucGroupBox1.Controls.Add(this.cmbDonVi);
            this.ucGroupBox1.Controls.Add(this.ucLabel1);
            this.ucGroupBox1.Controls.Add(this.cmbNam);
            this.ucGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ucGroupBox1.Name = "ucGroupBox1";
            this.ucGroupBox1.Size = new System.Drawing.Size(884, 57);
            this.ucGroupBox1.TabIndex = 1;
            this.ucGroupBox1.TabStop = false;
            this.ucGroupBox1.Text = "Chọn thông tin";
            // 
            // ucLabel4
            // 
            this.ucLabel4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel4.FieldGroup = "";
            this.ucLabel4.FieldName = "";
            this.ucLabel4.Location = new System.Drawing.Point(154, 25);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(35, 13);
            this.ucLabel4.TabIndex = 743;
            this.ucLabel4.Text = "Đơn vị:";
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.FieldGroup = "";
            this.cmbDonVi.FieldName = "";
            this.cmbDonVi.Location = new System.Drawing.Point(195, 22);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Properties.AutoHeight = false;
            this.cmbDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDonVi.Properties.DisplayMember = "Ten_DonVi";
            this.cmbDonVi.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbDonVi.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbDonVi.Properties.NullText = "";
            this.cmbDonVi.Properties.ValueMember = "ID_DonVi";
            this.cmbDonVi.Properties.View = this.gridView1;
            this.cmbDonVi.Size = new System.Drawing.Size(250, 21);
            this.cmbDonVi.TabIndex = 742;
            this.cmbDonVi.EditValueChanged += new System.EventHandler(this.cmbDonVi_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowColumnHeaders = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "gridColumn1";
            this.gridColumn3.FieldName = "ID_DonVi";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn2";
            this.gridColumn4.FieldName = "Ten_DonVi";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // ucLabel1
            // 
            this.ucLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(10, 22);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(27, 21);
            this.ucLabel1.TabIndex = 1;
            this.ucLabel1.Text = "Năm";
            // 
            // cmbNam
            // 
            this.cmbNam.AddItemSeparator = ';';
            this.cmbNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbNam.AutoSize = false;
            this.cmbNam.Caption = "";
            this.cmbNam.CaptionHeight = 0;
            this.cmbNam.CaptionVisible = false;
            this.cmbNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cmbNam.ColumnCaptionHeight = 17;
            this.cmbNam.ColumnFooterHeight = 17;
            this.cmbNam.ColumnHeaders = false;
            this.cmbNam.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList;
            this.cmbNam.ContentHeight = 15;
            this.cmbNam.DataMode = C1.Win.C1List.DataModeEnum.AddItem;
            this.cmbNam.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.cmbNam.EditorBackColor = System.Drawing.SystemColors.Window;
            this.cmbNam.EditorFont = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNam.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbNam.EditorHeight = 15;
            this.cmbNam.ExtendRightColumn = true;
            this.cmbNam.FieldGroup = "";
            this.cmbNam.FieldName = "";
            this.cmbNam.Images.Add(((System.Drawing.Image)(resources.GetObject("cmbNam.Images"))));
            this.cmbNam.ItemHeight = 15;
            this.cmbNam.Location = new System.Drawing.Point(43, 22);
            this.cmbNam.MatchEntryTimeout = ((long)(2000));
            this.cmbNam.MaxDropDownItems = ((short)(12));
            this.cmbNam.MaxLength = 32767;
            this.cmbNam.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.cmbNam.Size = new System.Drawing.Size(102, 21);
            this.cmbNam.TabIndex = 0;
            this.cmbNam.Text = "ucComboBox1";
            this.cmbNam.TextChanged += new System.EventHandler(this.cmbNam_TextChanged);
            this.cmbNam.PropBag = resources.GetString("cmbNam.PropBag");
            // 
            // ucGroupBox2
            // 
            this.ucGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGroupBox2.Controls.Add(this.fg);
            this.ucGroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucGroupBox2.Location = new System.Drawing.Point(0, 63);
            this.ucGroupBox2.Name = "ucGroupBox2";
            this.ucGroupBox2.Size = new System.Drawing.Size(881, 367);
            this.ucGroupBox2.TabIndex = 2;
            this.ucGroupBox2.TabStop = false;
            this.ucGroupBox2.Text = "Danh sách ngày nghỉ lễ, tết trong năm";
            // 
            // fg
            // 
            this.fg.AllowEditing = false;
            this.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fg.ColumnInfo = "1,0,0,0,0,90,Columns:0{Width:80;AllowSorting:False;Name:\"Thang\";Caption:\"Tháng\";A" +
    "llowEditing:False;Style:\"TextAlign:CenterCenter;\";}\t";
            this.fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(3, 19);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 18;
            this.fg.Rows.MinSize = 21;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fg.Size = new System.Drawing.Size(875, 345);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 0;
            this.fg.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            this.fg.DoubleClick += new System.EventHandler(this.fg_DoubleClick);
            this.fg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fg_KeyUp);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Edit;
            this.btnCapNhat.Location = new System.Drawing.Point(3, 433);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 26);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Visible = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.btnThoat.Location = new System.Drawing.Point(778, 430);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 26);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "&Đóng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuuLai
            // 
            this.btnLuuLai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuuLai.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuLai.Appearance.Options.UseFont = true;
            this.btnLuuLai.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Save;
            this.btnLuuLai.Location = new System.Drawing.Point(3, 433);
            this.btnLuuLai.Name = "btnLuuLai";
            this.btnLuuLai.Size = new System.Drawing.Size(100, 26);
            this.btnLuuLai.TabIndex = 3;
            this.btnLuuLai.Text = "Lưu lại";
            this.btnLuuLai.Visible = false;
            this.btnLuuLai.Click += new System.EventHandler(this.btnLuuLai_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Back;
            this.btnHuy.Location = new System.Drawing.Point(109, 433);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 26);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmDM_NgayNghiLe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 462);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.ucGroupBox2);
            this.Controls.Add(this.ucGroupBox1);
            this.Controls.Add(this.btnLuuLai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDM_NgayNghiLe";
            this.Text = "Cập nhật ngày nghỉ lễ";
            this.Load += new System.EventHandler(this.frmDM_NgayNghiLe_Load);
            this.ucGroupBox1.ResumeLayout(false);
            this.ucGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNam)).EndInit();
            this.ucGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucGroupBox ucGroupBox1;
        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucComboBox cmbNam;
        private VSCM.Base.Controls.ucGroupBox ucGroupBox2;
        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucButton btnCapNhat;
        private VSCM.Base.Controls.ucButton btnThoat;
        private VSCM.Base.Controls.ucButton btnLuuLai;
        private VSCM.Base.Controls.ucButton btnHuy;
        private VSCM.Base.Controls.ucLabel ucLabel4;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}