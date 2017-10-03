namespace Garco10.Presenter.QLCV.DanhMuc
{
    partial class frmChonNhanSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChonNhanSu));
            this.ucGroupBox1 = new VSCM.Base.Controls.ucGroupBox();
            this.txtSearch_NhanSu = new VSCM.Base.Controls.ucTextBox();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.ucLabel3 = new VSCM.Base.Controls.ucLabel();
            this.ucLabel4 = new VSCM.Base.Controls.ucLabel();
            this.cmbBoPhan = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbDonVi = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fgNhanSu = new VSCM.Base.Controls.ucFlexGrid();
            this.cmdThoat = new VSCM.Base.Controls.ucButton();
            this.cmdChon = new VSCM.Base.Controls.ucButton();
            this.ucGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch_NhanSu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgNhanSu)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGroupBox1
            // 
            this.ucGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGroupBox1.Controls.Add(this.txtSearch_NhanSu);
            this.ucGroupBox1.Controls.Add(this.ucLabel1);
            this.ucGroupBox1.Controls.Add(this.ucLabel3);
            this.ucGroupBox1.Controls.Add(this.ucLabel4);
            this.ucGroupBox1.Controls.Add(this.cmbBoPhan);
            this.ucGroupBox1.Controls.Add(this.cmbDonVi);
            this.ucGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucGroupBox1.Location = new System.Drawing.Point(3, 1);
            this.ucGroupBox1.Name = "ucGroupBox1";
            this.ucGroupBox1.Size = new System.Drawing.Size(800, 72);
            this.ucGroupBox1.TabIndex = 0;
            this.ucGroupBox1.TabStop = false;
            this.ucGroupBox1.Text = "Chọn thông tin";
            // 
            // txtSearch_NhanSu
            // 
            this.txtSearch_NhanSu.FieldGroup = "";
            this.txtSearch_NhanSu.FieldName = "";
            this.txtSearch_NhanSu.Location = new System.Drawing.Point(59, 44);
            this.txtSearch_NhanSu.Name = "txtSearch_NhanSu";
            this.txtSearch_NhanSu.Properties.AutoHeight = false;
            this.txtSearch_NhanSu.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtSearch_NhanSu.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtSearch_NhanSu.Properties.Name = "fProperties";
            this.txtSearch_NhanSu.Properties.NullValuePrompt = "Nhập họ tên, Mã nhân sự, Số CMND...";
            this.txtSearch_NhanSu.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearch_NhanSu.Size = new System.Drawing.Size(509, 20);
            this.txtSearch_NhanSu.TabIndex = 739;
            this.txtSearch_NhanSu.EditValueChanged += new System.EventHandler(this.txtSearch_NhanSu_EditValueChanged);
            this.txtSearch_NhanSu.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_NhanSu_KeyUp);
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(9, 47);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(44, 13);
            this.ucLabel1.TabIndex = 738;
            this.ucLabel1.Text = "Tìm kiếm:";
            // 
            // ucLabel3
            // 
            this.ucLabel3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel3.FieldGroup = "";
            this.ucLabel3.FieldName = "";
            this.ucLabel3.Location = new System.Drawing.Point(269, 20);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(43, 13);
            this.ucLabel3.TabIndex = 738;
            this.ucLabel3.Text = "Bộ phận:";
            // 
            // ucLabel4
            // 
            this.ucLabel4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel4.FieldGroup = "";
            this.ucLabel4.FieldName = "";
            this.ucLabel4.Location = new System.Drawing.Point(9, 20);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(35, 13);
            this.ucLabel4.TabIndex = 737;
            this.ucLabel4.Text = "Đơn vị:";
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.FieldGroup = "";
            this.cmbBoPhan.FieldName = "";
            this.cmbBoPhan.Location = new System.Drawing.Point(318, 17);
            this.cmbBoPhan.Name = "cmbBoPhan";
            this.cmbBoPhan.Properties.AutoHeight = false;
            this.cmbBoPhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBoPhan.Properties.DisplayMember = "Ten_BoPhan";
            this.cmbBoPhan.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbBoPhan.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbBoPhan.Properties.NullText = "";
            this.cmbBoPhan.Properties.ValueMember = "ID_BoPhan";
            this.cmbBoPhan.Properties.View = this.gridView1;
            this.cmbBoPhan.Size = new System.Drawing.Size(250, 21);
            this.cmbBoPhan.TabIndex = 736;
            this.cmbBoPhan.EditValueChanged += new System.EventHandler(this.cmbBoPhan_EditValueChanged);
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
            this.gridColumn3.Caption = "gridColumn3";
            this.gridColumn3.FieldName = "ID_BoPhan";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "gridColumn4";
            this.gridColumn4.FieldName = "Ten_BoPhan";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.FieldGroup = "";
            this.cmbDonVi.FieldName = "";
            this.cmbDonVi.Location = new System.Drawing.Point(58, 17);
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
            this.cmbDonVi.TabIndex = 735;
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
            // fgNhanSu
            // 
            this.fgNhanSu.AllowEditing = false;
            this.fgNhanSu.AllowFiltering = true;
            this.fgNhanSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgNhanSu.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgNhanSu.ColumnInfo = resources.GetString("fgNhanSu.ColumnInfo");
            this.fgNhanSu.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgNhanSu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgNhanSu.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgNhanSu.Location = new System.Drawing.Point(3, 76);
            this.fgNhanSu.Name = "fgNhanSu";
            this.fgNhanSu.Rows.Count = 1;
            this.fgNhanSu.Rows.DefaultSize = 18;
            this.fgNhanSu.Rows.MinSize = 21;
            this.fgNhanSu.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgNhanSu.Size = new System.Drawing.Size(800, 383);
            this.fgNhanSu.StyleInfo = resources.GetString("fgNhanSu.StyleInfo");
            this.fgNhanSu.TabIndex = 2;
            this.fgNhanSu.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            this.fgNhanSu.DoubleClick += new System.EventHandler(this.fgNhanSu_DoubleClick);
            // 
            // cmdThoat
            // 
            this.cmdThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdThoat.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdThoat.Appearance.Options.UseFont = true;
            this.cmdThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.cmdThoat.Location = new System.Drawing.Point(713, 463);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(90, 24);
            this.cmdThoat.TabIndex = 37;
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // cmdChon
            // 
            this.cmdChon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdChon.Appearance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdChon.Appearance.Options.UseFont = true;
            this.cmdChon.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Check;
            this.cmdChon.Location = new System.Drawing.Point(3, 463);
            this.cmdChon.Name = "cmdChon";
            this.cmdChon.Size = new System.Drawing.Size(90, 24);
            this.cmdChon.TabIndex = 38;
            this.cmdChon.Text = "Chọn";
            this.cmdChon.Click += new System.EventHandler(this.cmdChon_Click);
            // 
            // frmChonNhanSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 490);
            this.Controls.Add(this.cmdChon);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.fgNhanSu);
            this.Controls.Add(this.ucGroupBox1);
            this.Name = "frmChonNhanSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHỌN NHÂN SỰ";
            this.Load += new System.EventHandler(this.frmChonNhanSu_Load);
            this.ucGroupBox1.ResumeLayout(false);
            this.ucGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch_NhanSu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgNhanSu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucGroupBox ucGroupBox1;
        private VSCM.Base.Controls.ucLabel ucLabel3;
        private VSCM.Base.Controls.ucLabel ucLabel4;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbBoPhan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private VSCM.Base.Controls.ucTextBox txtSearch_NhanSu;
        private VSCM.Base.Controls.ucFlexGrid fgNhanSu;
        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucButton cmdThoat;
        private VSCM.Base.Controls.ucButton cmdChon;
    }
}