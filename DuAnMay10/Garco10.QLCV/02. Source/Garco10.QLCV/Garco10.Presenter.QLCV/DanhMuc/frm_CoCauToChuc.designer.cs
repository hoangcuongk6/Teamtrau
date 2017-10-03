namespace Garco10.Presenter.QLCV
{
    partial class frmCoCauToChuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCoCauToChuc));
            this.cmbBoPhan = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbDonVi = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGroupBox1 = new VSCM.Base.Controls.ucGroupBox();
            this.fgNhanSu = new VSCM.Base.Controls.ucFlexGrid();
            this.cmdTimkiem1 = new VSCM.Base.Controls.ucButton();
            this.txtSearch_NhanSu = new VSCM.Base.Controls.ucTextBox();
            this.ucLabel3 = new VSCM.Base.Controls.ucLabel();
            this.ucLabel2 = new VSCM.Base.Controls.ucLabel();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.btnThoat = new VSCM.Base.Controls.ucButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            this.ucGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgNhanSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch_NhanSu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBoPhan
            // 
            this.cmbBoPhan.FieldGroup = "";
            this.cmbBoPhan.FieldName = "";
            this.cmbBoPhan.Location = new System.Drawing.Point(58, 48);
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
            this.cmbBoPhan.Size = new System.Drawing.Size(316, 21);
            this.cmbBoPhan.TabIndex = 732;
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
            this.cmbDonVi.Location = new System.Drawing.Point(58, 21);
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
            this.cmbDonVi.Size = new System.Drawing.Size(316, 21);
            this.cmbDonVi.TabIndex = 731;
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
            // ucGroupBox1
            // 
            this.ucGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGroupBox1.Controls.Add(this.fgNhanSu);
            this.ucGroupBox1.Controls.Add(this.cmdTimkiem1);
            this.ucGroupBox1.Controls.Add(this.txtSearch_NhanSu);
            this.ucGroupBox1.Controls.Add(this.ucLabel3);
            this.ucGroupBox1.Controls.Add(this.ucLabel2);
            this.ucGroupBox1.Controls.Add(this.ucLabel1);
            this.ucGroupBox1.Controls.Add(this.cmbBoPhan);
            this.ucGroupBox1.Controls.Add(this.cmbDonVi);
            this.ucGroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucGroupBox1.Location = new System.Drawing.Point(3, 5);
            this.ucGroupBox1.Name = "ucGroupBox1";
            this.ucGroupBox1.Size = new System.Drawing.Size(530, 526);
            this.ucGroupBox1.TabIndex = 733;
            this.ucGroupBox1.TabStop = false;
            this.ucGroupBox1.Text = "Danh sách nhân viên";
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
            this.fgNhanSu.Location = new System.Drawing.Point(6, 101);
            this.fgNhanSu.Name = "fgNhanSu";
            this.fgNhanSu.Rows.Count = 1;
            this.fgNhanSu.Rows.DefaultSize = 18;
            this.fgNhanSu.Rows.MinSize = 21;
            this.fgNhanSu.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.RowRange;
            this.fgNhanSu.Size = new System.Drawing.Size(518, 416);
            this.fgNhanSu.StyleInfo = resources.GetString("fgNhanSu.StyleInfo");
            this.fgNhanSu.TabIndex = 735;
            this.fgNhanSu.Tag = "0";
            this.fgNhanSu.VisualStyle = C1.Win.C1FlexGrid.VisualStyle.Office2007Blue;
            this.fgNhanSu.AfterRowChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgNhanSu_AfterRowChange);
            // 
            // cmdTimkiem1
            // 
            this.cmdTimkiem1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdTimkiem1.Appearance.Options.UseFont = true;
            this.cmdTimkiem1.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Search;
            this.cmdTimkiem1.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.cmdTimkiem1.Location = new System.Drawing.Point(378, 75);
            this.cmdTimkiem1.Name = "cmdTimkiem1";
            this.cmdTimkiem1.Size = new System.Drawing.Size(30, 20);
            this.cmdTimkiem1.TabIndex = 736;
            this.cmdTimkiem1.Click += new System.EventHandler(this.cmdTimkiem1_Click);
            // 
            // txtSearch_NhanSu
            // 
            this.txtSearch_NhanSu.FieldGroup = "";
            this.txtSearch_NhanSu.FieldName = "";
            this.txtSearch_NhanSu.Location = new System.Drawing.Point(59, 75);
            this.txtSearch_NhanSu.Name = "txtSearch_NhanSu";
            this.txtSearch_NhanSu.Properties.AutoHeight = false;
            this.txtSearch_NhanSu.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtSearch_NhanSu.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtSearch_NhanSu.Properties.Name = "fProperties";
            this.txtSearch_NhanSu.Properties.NullValuePrompt = "Nhập thông tin tìm kiếm";
            this.txtSearch_NhanSu.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtSearch_NhanSu.Size = new System.Drawing.Size(315, 20);
            this.txtSearch_NhanSu.TabIndex = 735;
            this.txtSearch_NhanSu.EditValueChanged += new System.EventHandler(this.txtSearch_NhanSu_EditValueChanged);
            // 
            // ucLabel3
            // 
            this.ucLabel3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel3.FieldGroup = "";
            this.ucLabel3.FieldName = "";
            this.ucLabel3.Location = new System.Drawing.Point(9, 78);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(44, 13);
            this.ucLabel3.TabIndex = 734;
            this.ucLabel3.Text = "Tìm kiếm:";
            // 
            // ucLabel2
            // 
            this.ucLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel2.FieldGroup = "";
            this.ucLabel2.FieldName = "";
            this.ucLabel2.Location = new System.Drawing.Point(9, 51);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(43, 13);
            this.ucLabel2.TabIndex = 734;
            this.ucLabel2.Text = "Bộ phận:";
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(9, 24);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(35, 13);
            this.ucLabel1.TabIndex = 733;
            this.ucLabel1.Text = "Đơn vị:";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.btnThoat.Location = new System.Drawing.Point(427, 534);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 26);
            this.btnThoat.TabIndex = 734;
            this.btnThoat.Text = "&Đóng";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmCoCauToChuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 562);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.ucGroupBox1);
            this.Name = "frmCoCauToChuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CƠ CẤU TỔ CHỨC";
            this.Load += new System.EventHandler(this.frmQuyetDinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            this.ucGroupBox1.ResumeLayout(false);
            this.ucGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgNhanSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch_NhanSu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucSearchLookupEdit cmbBoPhan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private VSCM.Base.Controls.ucGroupBox ucGroupBox1;
        private VSCM.Base.Controls.ucLabel ucLabel2;
        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucFlexGrid fgNhanSu;
        private VSCM.Base.Controls.ucButton cmdTimkiem1;
        private VSCM.Base.Controls.ucTextBox txtSearch_NhanSu;
        private VSCM.Base.Controls.ucButton btnThoat;
        private VSCM.Base.Controls.ucLabel ucLabel3;
    }
}