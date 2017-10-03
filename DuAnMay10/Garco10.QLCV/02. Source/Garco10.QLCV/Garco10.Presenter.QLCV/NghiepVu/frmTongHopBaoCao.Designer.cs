namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmTongHopBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTongHopBaoCao));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.tpTongHopBaoCao = new DevExpress.XtraTab.XtraTabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnu_Expand = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Collapse = new System.Windows.Forms.ToolStripMenuItem();
            this.grbDSCongViec = new VSCM.Base.Controls.ucGroupBox();
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.grbOptions = new VSCM.Base.Controls.ucGroupBox();
            this.cbShowAll = new VSCM.Base.Controls.ucCheckBox();
            this.cbToggleView = new VSCM.Base.Controls.ucCheckBox();
            this.grbChonThongTin = new VSCM.Base.Controls.ucGroupBox();
            this.dtmTuNgay = new VSCM.Base.Controls.ucDateEdit();
            this.ucTextBox2 = new VSCM.Base.Controls.ucTextBox();
            this.cmbNhanVien = new VSCM.Base.Controls.ucCheckedComboBox();
            this.lblNgayYeuCau = new VSCM.Base.Controls.ucTextBox();
            this.dtmDenNgay = new VSCM.Base.Controls.ucDateEdit();
            this.tpBaoCaoNgay = new DevExpress.XtraTab.XtraTabPage();
            this.grbThongTin = new VSCM.Base.Controls.ucGroupBox();
            this.dtpTuNgay = new VSCM.Base.Controls.ucDateEdit();
            this.ucTextBox1 = new VSCM.Base.Controls.ucTextBox();
            this.cmbNguoiThucHien = new VSCM.Base.Controls.ucCheckedComboBox();
            this.ucTextBox3 = new VSCM.Base.Controls.ucTextBox();
            this.dtpDenNgay = new VSCM.Base.Controls.ucDateEdit();
            this.ucCheckBox1 = new VSCM.Base.Controls.ucCheckBox();
            this.grbOption = new VSCM.Base.Controls.ucGroupBox();
            this.grbCongViec = new VSCM.Base.Controls.ucGroupBox();
            this.fgBaoCaoNgay = new VSCM.Base.Controls.ucFlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.tpTongHopBaoCao.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.grbDSCongViec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            this.grbOptions.SuspendLayout();
            this.grbChonThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtmTuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucTextBox2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNgayYeuCau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDenNgay)).BeginInit();
            this.tpBaoCaoNgay.SuspendLayout();
            this.grbThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNguoiThucHien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucTextBox3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDenNgay)).BeginInit();
            this.grbOption.SuspendLayout();
            this.grbCongViec.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgBaoCaoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.tpTongHopBaoCao;
            this.xtraTabControl1.Size = new System.Drawing.Size(1029, 612);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpTongHopBaoCao,
            this.tpBaoCaoNgay});
            this.xtraTabControl1.SelectedPageChanged += new DevExpress.XtraTab.TabPageChangedEventHandler(this.xtraTabControl1_SelectedPageChanged);
            // 
            // tpTongHopBaoCao
            // 
            this.tpTongHopBaoCao.ContextMenuStrip = this.contextMenuStrip1;
            this.tpTongHopBaoCao.Controls.Add(this.grbDSCongViec);
            this.tpTongHopBaoCao.Controls.Add(this.grbOptions);
            this.tpTongHopBaoCao.Controls.Add(this.grbChonThongTin);
            this.tpTongHopBaoCao.Name = "tpTongHopBaoCao";
            this.tpTongHopBaoCao.Size = new System.Drawing.Size(1023, 584);
            this.tpTongHopBaoCao.Text = "Tổng hợp báo cáo";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_Expand,
            this.mnu_Collapse});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 48);
            // 
            // mnu_Expand
            // 
            this.mnu_Expand.Image = global::Garco10.Presenter.QLCV.Properties.Resources.expand;
            this.mnu_Expand.Name = "mnu_Expand";
            this.mnu_Expand.Size = new System.Drawing.Size(151, 22);
            this.mnu_Expand.Text = "Hiển thị tất cả";
            this.mnu_Expand.Click += new System.EventHandler(this.mnu_Expand_Click);
            // 
            // mnu_Collapse
            // 
            this.mnu_Collapse.Image = global::Garco10.Presenter.QLCV.Properties.Resources.collapse;
            this.mnu_Collapse.Name = "mnu_Collapse";
            this.mnu_Collapse.Size = new System.Drawing.Size(151, 22);
            this.mnu_Collapse.Text = "Thu gọn tất cả";
            this.mnu_Collapse.Click += new System.EventHandler(this.mnu_Collapse_Click);
            // 
            // grbDSCongViec
            // 
            this.grbDSCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbDSCongViec.Controls.Add(this.fg);
            this.grbDSCongViec.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grbDSCongViec.Location = new System.Drawing.Point(6, 81);
            this.grbDSCongViec.Margin = new System.Windows.Forms.Padding(2);
            this.grbDSCongViec.Name = "grbDSCongViec";
            this.grbDSCongViec.Padding = new System.Windows.Forms.Padding(2);
            this.grbDSCongViec.Size = new System.Drawing.Size(1015, 497);
            this.grbDSCongViec.TabIndex = 9;
            this.grbDSCongViec.TabStop = false;
            this.grbDSCongViec.Text = "Danh sách công việc";
            // 
            // fg
            // 
            this.fg.AllowEditing = false;
            this.fg.AutoClipboard = true;
            this.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fg.ColumnInfo = resources.GetString("fg.ColumnInfo");
            this.fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fg.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(2, 15);
            this.fg.Margin = new System.Windows.Forms.Padding(2);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 18;
            this.fg.Rows.MinSize = 21;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fg.Size = new System.Drawing.Size(1011, 480);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 0;
            this.fg.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.fg_OwnerDrawCell);
            this.fg.BeforeFilter += new System.ComponentModel.CancelEventHandler(this.fg_BeforeFilter);
            this.fg.AfterFilter += new System.EventHandler(this.fg_AfterFilter);
            this.fg.DoubleClick += new System.EventHandler(this.fg_DoubleClick);
            // 
            // grbOptions
            // 
            this.grbOptions.Controls.Add(this.cbShowAll);
            this.grbOptions.Controls.Add(this.cbToggleView);
            this.grbOptions.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOptions.Location = new System.Drawing.Point(404, 0);
            this.grbOptions.Name = "grbOptions";
            this.grbOptions.Size = new System.Drawing.Size(150, 76);
            this.grbOptions.TabIndex = 8;
            this.grbOptions.TabStop = false;
            this.grbOptions.Text = "Options";
            // 
            // cbShowAll
            // 
            this.cbShowAll.AutoSize = true;
            this.cbShowAll.FieldGroup = "";
            this.cbShowAll.FieldName = "";
            this.cbShowAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbShowAll.Location = new System.Drawing.Point(8, 21);
            this.cbShowAll.Name = "cbShowAll";
            this.cbShowAll.Size = new System.Drawing.Size(134, 17);
            this.cbShowAll.TabIndex = 5;
            this.cbShowAll.Text = "Xem danh sách đầy đủ";
            this.cbShowAll.UseVisualStyleBackColor = true;
            this.cbShowAll.CheckedChanged += new System.EventHandler(this.cbShowAll_CheckedChanged);
            // 
            // cbToggleView
            // 
            this.cbToggleView.AutoSize = true;
            this.cbToggleView.FieldGroup = "";
            this.cbToggleView.FieldName = "";
            this.cbToggleView.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbToggleView.Location = new System.Drawing.Point(8, 45);
            this.cbToggleView.Name = "cbToggleView";
            this.cbToggleView.Size = new System.Drawing.Size(113, 17);
            this.cbToggleView.TabIndex = 6;
            this.cbToggleView.Text = "Toggle color mode";
            this.cbToggleView.UseVisualStyleBackColor = true;
            this.cbToggleView.Visible = false;
            this.cbToggleView.CheckedChanged += new System.EventHandler(this.cbToggleView_CheckedChanged);
            // 
            // grbChonThongTin
            // 
            this.grbChonThongTin.Controls.Add(this.dtmTuNgay);
            this.grbChonThongTin.Controls.Add(this.ucTextBox2);
            this.grbChonThongTin.Controls.Add(this.cmbNhanVien);
            this.grbChonThongTin.Controls.Add(this.lblNgayYeuCau);
            this.grbChonThongTin.Controls.Add(this.dtmDenNgay);
            this.grbChonThongTin.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grbChonThongTin.Location = new System.Drawing.Point(6, 3);
            this.grbChonThongTin.Name = "grbChonThongTin";
            this.grbChonThongTin.Size = new System.Drawing.Size(395, 73);
            this.grbChonThongTin.TabIndex = 2;
            this.grbChonThongTin.TabStop = false;
            this.grbChonThongTin.Text = "Chọn thông tin";
            // 
            // dtmTuNgay
            // 
            this.dtmTuNgay.AutoSize = false;
            this.dtmTuNgay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dtmTuNgay.Calendar.BackColor = System.Drawing.SystemColors.Window;
            this.dtmTuNgay.Calendar.DayNameLength = 1;
            this.dtmTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtmTuNgay.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.dtmTuNgay.DisplayFormat.EmptyAsNull = false;
            this.dtmTuNgay.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtmTuNgay.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtmTuNgay.EditFormat.CustomFormat = "dd/MM/yyyy";
            this.dtmTuNgay.EditFormat.EmptyAsNull = false;
            this.dtmTuNgay.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtmTuNgay.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtmTuNgay.EmptyAsNull = true;
            this.dtmTuNgay.FieldGroup = "";
            this.dtmTuNgay.FieldName = "";
            this.dtmTuNgay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmTuNgay.Location = new System.Drawing.Point(6, 41);
            this.dtmTuNgay.Name = "dtmTuNgay";
            this.dtmTuNgay.Size = new System.Drawing.Size(120, 23);
            this.dtmTuNgay.TabIndex = 58;
            this.dtmTuNgay.Tag = null;
            this.dtmTuNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtmTuNgay.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtmTuNgay.ValueChanged += new System.EventHandler(this.dtmTuNgay_ValueChanged);
            // 
            // ucTextBox2
            // 
            this.ucTextBox2.EditValue = "Người thực hiện";
            this.ucTextBox2.FieldGroup = "";
            this.ucTextBox2.FieldName = "";
            this.ucTextBox2.Location = new System.Drawing.Point(246, 17);
            this.ucTextBox2.Name = "ucTextBox2";
            this.ucTextBox2.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ucTextBox2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ucTextBox2.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ucTextBox2.Properties.Appearance.Options.UseBackColor = true;
            this.ucTextBox2.Properties.Appearance.Options.UseFont = true;
            this.ucTextBox2.Properties.Appearance.Options.UseForeColor = true;
            this.ucTextBox2.Properties.Appearance.Options.UseTextOptions = true;
            this.ucTextBox2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ucTextBox2.Properties.AutoHeight = false;
            this.ucTextBox2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ucTextBox2.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.ucTextBox2.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ucTextBox2.Properties.Name = "fProperties";
            this.ucTextBox2.Size = new System.Drawing.Size(140, 23);
            this.ucTextBox2.TabIndex = 54;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.EditValue = "";
            this.cmbNhanVien.FieldGroup = "";
            this.cmbNhanVien.FieldName = "";
            this.cmbNhanVien.Location = new System.Drawing.Point(246, 41);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Properties.AutoHeight = false;
            this.cmbNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNhanVien.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbNhanVien.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbNhanVien.Size = new System.Drawing.Size(140, 23);
            this.cmbNhanVien.TabIndex = 53;
            this.cmbNhanVien.EditValueChanged += new System.EventHandler(this.cmbNhanVien_EditValueChanged);
            // 
            // lblNgayYeuCau
            // 
            this.lblNgayYeuCau.EditValue = "Từ ngày - Đến ngày";
            this.lblNgayYeuCau.FieldGroup = "";
            this.lblNgayYeuCau.FieldName = "";
            this.lblNgayYeuCau.Location = new System.Drawing.Point(6, 17);
            this.lblNgayYeuCau.Name = "lblNgayYeuCau";
            this.lblNgayYeuCau.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblNgayYeuCau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblNgayYeuCau.Properties.Appearance.ForeColor = System.Drawing.Color.White;
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
            this.lblNgayYeuCau.Size = new System.Drawing.Size(238, 23);
            this.lblNgayYeuCau.TabIndex = 37;
            // 
            // dtmDenNgay
            // 
            this.dtmDenNgay.AutoSize = false;
            this.dtmDenNgay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dtmDenNgay.Calendar.BackColor = System.Drawing.SystemColors.Window;
            this.dtmDenNgay.Calendar.DayNameLength = 1;
            this.dtmDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtmDenNgay.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.dtmDenNgay.DisplayFormat.EmptyAsNull = false;
            this.dtmDenNgay.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtmDenNgay.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtmDenNgay.EditFormat.CustomFormat = "dd/MM/yyyy";
            this.dtmDenNgay.EditFormat.EmptyAsNull = false;
            this.dtmDenNgay.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtmDenNgay.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtmDenNgay.EmptyAsNull = true;
            this.dtmDenNgay.FieldGroup = "";
            this.dtmDenNgay.FieldName = "";
            this.dtmDenNgay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDenNgay.Location = new System.Drawing.Point(127, 41);
            this.dtmDenNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtmDenNgay.Name = "dtmDenNgay";
            this.dtmDenNgay.Size = new System.Drawing.Size(117, 23);
            this.dtmDenNgay.TabIndex = 2;
            this.dtmDenNgay.Tag = null;
            this.dtmDenNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtmDenNgay.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtmDenNgay.ValueChanged += new System.EventHandler(this.dtmDenNgay_ValueChanged);
            // 
            // tpBaoCaoNgay
            // 
            this.tpBaoCaoNgay.Controls.Add(this.grbCongViec);
            this.tpBaoCaoNgay.Controls.Add(this.grbOption);
            this.tpBaoCaoNgay.Controls.Add(this.grbThongTin);
            this.tpBaoCaoNgay.Name = "tpBaoCaoNgay";
            this.tpBaoCaoNgay.Size = new System.Drawing.Size(1023, 584);
            this.tpBaoCaoNgay.Text = "Báo cáo ngày";
            // 
            // grbThongTin
            // 
            this.grbThongTin.Controls.Add(this.dtpTuNgay);
            this.grbThongTin.Controls.Add(this.ucTextBox1);
            this.grbThongTin.Controls.Add(this.cmbNguoiThucHien);
            this.grbThongTin.Controls.Add(this.ucTextBox3);
            this.grbThongTin.Controls.Add(this.dtpDenNgay);
            this.grbThongTin.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grbThongTin.Location = new System.Drawing.Point(4, 3);
            this.grbThongTin.Name = "grbThongTin";
            this.grbThongTin.Size = new System.Drawing.Size(395, 73);
            this.grbThongTin.TabIndex = 3;
            this.grbThongTin.TabStop = false;
            this.grbThongTin.Text = "Chọn thông tin";
            // 
            // dtpTuNgay
            // 
            this.dtpTuNgay.AutoSize = false;
            this.dtpTuNgay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dtpTuNgay.Calendar.BackColor = System.Drawing.SystemColors.Window;
            this.dtpTuNgay.Calendar.DayNameLength = 1;
            this.dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.DisplayFormat.EmptyAsNull = false;
            this.dtpTuNgay.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpTuNgay.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpTuNgay.EditFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpTuNgay.EditFormat.EmptyAsNull = false;
            this.dtpTuNgay.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpTuNgay.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpTuNgay.EmptyAsNull = true;
            this.dtpTuNgay.FieldGroup = "";
            this.dtpTuNgay.FieldName = "";
            this.dtpTuNgay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTuNgay.Location = new System.Drawing.Point(6, 41);
            this.dtpTuNgay.Name = "dtpTuNgay";
            this.dtpTuNgay.Size = new System.Drawing.Size(120, 23);
            this.dtpTuNgay.TabIndex = 58;
            this.dtpTuNgay.Tag = null;
            this.dtpTuNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpTuNgay.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtpTuNgay.ValueChanged += new System.EventHandler(this.dtpTuNgay_ValueChanged);
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.EditValue = "Người thực hiện";
            this.ucTextBox1.FieldGroup = "";
            this.ucTextBox1.FieldName = "";
            this.ucTextBox1.Location = new System.Drawing.Point(246, 17);
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ucTextBox1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ucTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ucTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.ucTextBox1.Properties.Appearance.Options.UseFont = true;
            this.ucTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.ucTextBox1.Properties.Appearance.Options.UseTextOptions = true;
            this.ucTextBox1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ucTextBox1.Properties.AutoHeight = false;
            this.ucTextBox1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ucTextBox1.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.ucTextBox1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ucTextBox1.Properties.Name = "fProperties";
            this.ucTextBox1.Size = new System.Drawing.Size(140, 23);
            this.ucTextBox1.TabIndex = 54;
            // 
            // cmbNguoiThucHien
            // 
            this.cmbNguoiThucHien.EditValue = "";
            this.cmbNguoiThucHien.FieldGroup = "";
            this.cmbNguoiThucHien.FieldName = "";
            this.cmbNguoiThucHien.Location = new System.Drawing.Point(246, 41);
            this.cmbNguoiThucHien.Name = "cmbNguoiThucHien";
            this.cmbNguoiThucHien.Properties.AutoHeight = false;
            this.cmbNguoiThucHien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNguoiThucHien.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbNguoiThucHien.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbNguoiThucHien.Size = new System.Drawing.Size(140, 23);
            this.cmbNguoiThucHien.TabIndex = 53;
            // 
            // ucTextBox3
            // 
            this.ucTextBox3.EditValue = "Từ ngày - Đến ngày (Kế hoạch)";
            this.ucTextBox3.FieldGroup = "";
            this.ucTextBox3.FieldName = "";
            this.ucTextBox3.Location = new System.Drawing.Point(6, 17);
            this.ucTextBox3.Name = "ucTextBox3";
            this.ucTextBox3.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ucTextBox3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.ucTextBox3.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ucTextBox3.Properties.Appearance.Options.UseBackColor = true;
            this.ucTextBox3.Properties.Appearance.Options.UseFont = true;
            this.ucTextBox3.Properties.Appearance.Options.UseForeColor = true;
            this.ucTextBox3.Properties.Appearance.Options.UseTextOptions = true;
            this.ucTextBox3.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ucTextBox3.Properties.AutoHeight = false;
            this.ucTextBox3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ucTextBox3.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.ucTextBox3.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ucTextBox3.Properties.Name = "fProperties";
            this.ucTextBox3.Size = new System.Drawing.Size(238, 23);
            this.ucTextBox3.TabIndex = 37;
            // 
            // dtpDenNgay
            // 
            this.dtpDenNgay.AutoSize = false;
            this.dtpDenNgay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dtpDenNgay.Calendar.BackColor = System.Drawing.SystemColors.Window;
            this.dtpDenNgay.Calendar.DayNameLength = 1;
            this.dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.DisplayFormat.EmptyAsNull = false;
            this.dtpDenNgay.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpDenNgay.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpDenNgay.EditFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpDenNgay.EditFormat.EmptyAsNull = false;
            this.dtpDenNgay.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpDenNgay.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpDenNgay.EmptyAsNull = true;
            this.dtpDenNgay.FieldGroup = "";
            this.dtpDenNgay.FieldName = "";
            this.dtpDenNgay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDenNgay.Location = new System.Drawing.Point(127, 41);
            this.dtpDenNgay.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDenNgay.Name = "dtpDenNgay";
            this.dtpDenNgay.Size = new System.Drawing.Size(117, 23);
            this.dtpDenNgay.TabIndex = 2;
            this.dtpDenNgay.Tag = null;
            this.dtpDenNgay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtpDenNgay.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            this.dtpDenNgay.ValueChanged += new System.EventHandler(this.dtpDenNgay_ValueChanged);
            // 
            // ucCheckBox1
            // 
            this.ucCheckBox1.AutoSize = true;
            this.ucCheckBox1.FieldGroup = "";
            this.ucCheckBox1.FieldName = "";
            this.ucCheckBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucCheckBox1.Location = new System.Drawing.Point(8, 21);
            this.ucCheckBox1.Name = "ucCheckBox1";
            this.ucCheckBox1.Size = new System.Drawing.Size(134, 17);
            this.ucCheckBox1.TabIndex = 5;
            this.ucCheckBox1.Text = "Xem danh sách đầy đủ";
            this.ucCheckBox1.UseVisualStyleBackColor = true;
            // 
            // grbOption
            // 
            this.grbOption.Controls.Add(this.ucCheckBox1);
            this.grbOption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOption.Location = new System.Drawing.Point(404, 3);
            this.grbOption.Name = "grbOption";
            this.grbOption.Size = new System.Drawing.Size(150, 73);
            this.grbOption.TabIndex = 9;
            this.grbOption.TabStop = false;
            this.grbOption.Text = "Options";
            // 
            // grbCongViec
            // 
            this.grbCongViec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbCongViec.Controls.Add(this.fgBaoCaoNgay);
            this.grbCongViec.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.grbCongViec.Location = new System.Drawing.Point(4, 81);
            this.grbCongViec.Margin = new System.Windows.Forms.Padding(2);
            this.grbCongViec.Name = "grbCongViec";
            this.grbCongViec.Padding = new System.Windows.Forms.Padding(2);
            this.grbCongViec.Size = new System.Drawing.Size(1015, 502);
            this.grbCongViec.TabIndex = 10;
            this.grbCongViec.TabStop = false;
            this.grbCongViec.Text = "Danh sách công việc";
            // 
            // fgBaoCaoNgay
            // 
            this.fgBaoCaoNgay.AllowEditing = false;
            this.fgBaoCaoNgay.AutoClipboard = true;
            this.fgBaoCaoNgay.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgBaoCaoNgay.ColumnInfo = resources.GetString("fgBaoCaoNgay.ColumnInfo");
            this.fgBaoCaoNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgBaoCaoNgay.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.fgBaoCaoNgay.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgBaoCaoNgay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgBaoCaoNgay.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgBaoCaoNgay.Location = new System.Drawing.Point(2, 15);
            this.fgBaoCaoNgay.Margin = new System.Windows.Forms.Padding(2);
            this.fgBaoCaoNgay.Name = "fgBaoCaoNgay";
            this.fgBaoCaoNgay.Rows.Count = 1;
            this.fgBaoCaoNgay.Rows.DefaultSize = 18;
            this.fgBaoCaoNgay.Rows.MinSize = 21;
            this.fgBaoCaoNgay.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fgBaoCaoNgay.Size = new System.Drawing.Size(1011, 485);
            this.fgBaoCaoNgay.StyleInfo = resources.GetString("fgBaoCaoNgay.StyleInfo");
            this.fgBaoCaoNgay.TabIndex = 0;
            // 
            // frmTongHopBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 612);
            this.Controls.Add(this.xtraTabControl1);
            this.MaximizeBox = false;
            this.Name = "frmTongHopBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng hợp báo cáo";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.tpTongHopBaoCao.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grbDSCongViec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.grbOptions.ResumeLayout(false);
            this.grbOptions.PerformLayout();
            this.grbChonThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtmTuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucTextBox2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblNgayYeuCau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmDenNgay)).EndInit();
            this.tpBaoCaoNgay.ResumeLayout(false);
            this.grbThongTin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpTuNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNguoiThucHien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucTextBox3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDenNgay)).EndInit();
            this.grbOption.ResumeLayout(false);
            this.grbOption.PerformLayout();
            this.grbCongViec.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgBaoCaoNgay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage tpTongHopBaoCao;
        private VSCM.Base.Controls.ucGroupBox grbChonThongTin;
        private VSCM.Base.Controls.ucDateEdit dtmTuNgay;
        private VSCM.Base.Controls.ucTextBox ucTextBox2;
        private VSCM.Base.Controls.ucCheckedComboBox cmbNhanVien;
        private VSCM.Base.Controls.ucTextBox lblNgayYeuCau;
        private VSCM.Base.Controls.ucDateEdit dtmDenNgay;
        private VSCM.Base.Controls.ucGroupBox grbOptions;
        private VSCM.Base.Controls.ucCheckBox cbShowAll;
        private VSCM.Base.Controls.ucCheckBox cbToggleView;
        private VSCM.Base.Controls.ucGroupBox grbDSCongViec;
        private VSCM.Base.Controls.ucFlexGrid fg;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnu_Expand;
        private System.Windows.Forms.ToolStripMenuItem mnu_Collapse;
        private DevExpress.XtraTab.XtraTabPage tpBaoCaoNgay;
        private VSCM.Base.Controls.ucGroupBox grbOption;
        private VSCM.Base.Controls.ucCheckBox ucCheckBox1;
        private VSCM.Base.Controls.ucGroupBox grbThongTin;
        private VSCM.Base.Controls.ucDateEdit dtpTuNgay;
        private VSCM.Base.Controls.ucTextBox ucTextBox1;
        private VSCM.Base.Controls.ucCheckedComboBox cmbNguoiThucHien;
        private VSCM.Base.Controls.ucTextBox ucTextBox3;
        private VSCM.Base.Controls.ucDateEdit dtpDenNgay;
        private VSCM.Base.Controls.ucGroupBox grbCongViec;
        private VSCM.Base.Controls.ucFlexGrid fgBaoCaoNgay;


    }
}