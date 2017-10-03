namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmTrangCaNhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrangCaNhan));
            this.panel2 = new System.Windows.Forms.Panel();
            this.xtcCongViec = new DevExpress.XtraTab.XtraTabControl();
            this.xtpLoadGrid = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.fgDaNhan = new VSCM.Base.Controls.ucFlexGrid();
            this.txtDaNhan = new VSCM.Base.Controls.ucTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.fgDangLam = new VSCM.Base.Controls.ucFlexGrid();
            this.txtDangLam = new VSCM.Base.Controls.ucTextBox();
            this.fgDaXong = new VSCM.Base.Controls.ucFlexGrid();
            this.txtHoanThanh = new VSCM.Base.Controls.ucTextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtcCongViec)).BeginInit();
            this.xtcCongViec.SuspendLayout();
            this.xtpLoadGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgDaNhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgDangLam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDangLam.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgDaXong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoanThanh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.xtcCongViec);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1028, 612);
            this.panel2.TabIndex = 58;
            // 
            // xtcCongViec
            // 
            this.xtcCongViec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtcCongViec.Location = new System.Drawing.Point(0, 0);
            this.xtcCongViec.Name = "xtcCongViec";
            this.xtcCongViec.SelectedTabPage = this.xtpLoadGrid;
            this.xtcCongViec.Size = new System.Drawing.Size(1028, 612);
            this.xtcCongViec.TabIndex = 51;
            this.xtcCongViec.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtpLoadGrid});
            // 
            // xtpLoadGrid
            // 
            this.xtpLoadGrid.Controls.Add(this.splitContainer1);
            this.xtpLoadGrid.Name = "xtpLoadGrid";
            this.xtpLoadGrid.Size = new System.Drawing.Size(1022, 584);
            this.xtpLoadGrid.Text = "Grid Công việc";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.fgDaNhan);
            this.splitContainer1.Panel1.Controls.Add(this.txtDaNhan);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1022, 584);
            this.splitContainer1.SplitterDistance = 340;
            this.splitContainer1.TabIndex = 0;
            // 
            // fgDaNhan
            // 
            this.fgDaNhan.AllowEditing = false;
            this.fgDaNhan.AllowFiltering = true;
            this.fgDaNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgDaNhan.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgDaNhan.ColumnInfo = resources.GetString("fgDaNhan.ColumnInfo");
            this.fgDaNhan.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgDaNhan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgDaNhan.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgDaNhan.Location = new System.Drawing.Point(0, 24);
            this.fgDaNhan.Name = "fgDaNhan";
            this.fgDaNhan.Rows.Count = 1;
            this.fgDaNhan.Rows.DefaultSize = 18;
            this.fgDaNhan.Rows.MinSize = 21;
            this.fgDaNhan.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgDaNhan.Size = new System.Drawing.Size(340, 557);
            this.fgDaNhan.StyleInfo = resources.GetString("fgDaNhan.StyleInfo");
            this.fgDaNhan.TabIndex = 45;
            this.fgDaNhan.DoubleClick += new System.EventHandler(this.fgDaNhan_DoubleClick);
            // 
            // txtDaNhan
            // 
            this.txtDaNhan.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDaNhan.EditValue = "Chưa thực hiện";
            this.txtDaNhan.FieldGroup = "";
            this.txtDaNhan.FieldName = "";
            this.txtDaNhan.Location = new System.Drawing.Point(0, 0);
            this.txtDaNhan.Name = "txtDaNhan";
            this.txtDaNhan.Properties.Appearance.BackColor = System.Drawing.Color.SkyBlue;
            this.txtDaNhan.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDaNhan.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDaNhan.Properties.Appearance.Options.UseBackColor = true;
            this.txtDaNhan.Properties.Appearance.Options.UseFont = true;
            this.txtDaNhan.Properties.Appearance.Options.UseForeColor = true;
            this.txtDaNhan.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDaNhan.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtDaNhan.Properties.AutoHeight = false;
            this.txtDaNhan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDaNhan.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtDaNhan.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtDaNhan.Properties.Name = "fProperties";
            this.txtDaNhan.Size = new System.Drawing.Size(340, 25);
            this.txtDaNhan.TabIndex = 44;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.fgDangLam);
            this.splitContainer2.Panel1.Controls.Add(this.txtDangLam);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.fgDaXong);
            this.splitContainer2.Panel2.Controls.Add(this.txtHoanThanh);
            this.splitContainer2.Size = new System.Drawing.Size(678, 584);
            this.splitContainer2.SplitterDistance = 333;
            this.splitContainer2.TabIndex = 0;
            // 
            // fgDangLam
            // 
            this.fgDangLam.AllowEditing = false;
            this.fgDangLam.AllowFiltering = true;
            this.fgDangLam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgDangLam.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgDangLam.ColumnInfo = resources.GetString("fgDangLam.ColumnInfo");
            this.fgDangLam.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgDangLam.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgDangLam.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgDangLam.Location = new System.Drawing.Point(0, 23);
            this.fgDangLam.Name = "fgDangLam";
            this.fgDangLam.Rows.Count = 1;
            this.fgDangLam.Rows.DefaultSize = 18;
            this.fgDangLam.Rows.MinSize = 21;
            this.fgDangLam.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgDangLam.Size = new System.Drawing.Size(333, 558);
            this.fgDangLam.StyleInfo = resources.GetString("fgDangLam.StyleInfo");
            this.fgDangLam.TabIndex = 49;
            this.fgDangLam.DoubleClick += new System.EventHandler(this.fgDangLam_DoubleClick);
            // 
            // txtDangLam
            // 
            this.txtDangLam.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDangLam.EditValue = "Đang  thực hiện";
            this.txtDangLam.FieldGroup = "";
            this.txtDangLam.FieldName = "";
            this.txtDangLam.Location = new System.Drawing.Point(0, 0);
            this.txtDangLam.Name = "txtDangLam";
            this.txtDangLam.Properties.Appearance.BackColor = System.Drawing.Color.Khaki;
            this.txtDangLam.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtDangLam.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtDangLam.Properties.Appearance.Options.UseBackColor = true;
            this.txtDangLam.Properties.Appearance.Options.UseFont = true;
            this.txtDangLam.Properties.Appearance.Options.UseForeColor = true;
            this.txtDangLam.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDangLam.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtDangLam.Properties.AutoHeight = false;
            this.txtDangLam.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDangLam.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtDangLam.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtDangLam.Properties.Name = "fProperties";
            this.txtDangLam.Size = new System.Drawing.Size(333, 23);
            this.txtDangLam.TabIndex = 48;
            // 
            // fgDaXong
            // 
            this.fgDaXong.AllowEditing = false;
            this.fgDaXong.AllowFiltering = true;
            this.fgDaXong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgDaXong.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgDaXong.ColumnInfo = resources.GetString("fgDaXong.ColumnInfo");
            this.fgDaXong.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgDaXong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgDaXong.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgDaXong.Location = new System.Drawing.Point(0, 22);
            this.fgDaXong.Name = "fgDaXong";
            this.fgDaXong.Rows.Count = 1;
            this.fgDaXong.Rows.DefaultSize = 18;
            this.fgDaXong.Rows.MinSize = 21;
            this.fgDaXong.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgDaXong.Size = new System.Drawing.Size(341, 559);
            this.fgDaXong.StyleInfo = resources.GetString("fgDaXong.StyleInfo");
            this.fgDaXong.TabIndex = 50;
            this.fgDaXong.DoubleClick += new System.EventHandler(this.fgDaXong_DoubleClick);
            // 
            // txtHoanThanh
            // 
            this.txtHoanThanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHoanThanh.EditValue = "Đã hoàn thành";
            this.txtHoanThanh.FieldGroup = "";
            this.txtHoanThanh.FieldName = "";
            this.txtHoanThanh.Location = new System.Drawing.Point(0, 0);
            this.txtHoanThanh.Name = "txtHoanThanh";
            this.txtHoanThanh.Properties.Appearance.BackColor = System.Drawing.Color.YellowGreen;
            this.txtHoanThanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtHoanThanh.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.txtHoanThanh.Properties.Appearance.Options.UseBackColor = true;
            this.txtHoanThanh.Properties.Appearance.Options.UseFont = true;
            this.txtHoanThanh.Properties.Appearance.Options.UseForeColor = true;
            this.txtHoanThanh.Properties.Appearance.Options.UseTextOptions = true;
            this.txtHoanThanh.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtHoanThanh.Properties.AutoHeight = false;
            this.txtHoanThanh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtHoanThanh.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtHoanThanh.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtHoanThanh.Properties.Name = "fProperties";
            this.txtHoanThanh.Size = new System.Drawing.Size(341, 23);
            this.txtHoanThanh.TabIndex = 49;
            // 
            // frmTrangCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 612);
            this.Controls.Add(this.panel2);
            this.Name = "frmTrangCaNhan";
            this.Text = "Công việc cá nhân";
            //this.Load += new System.EventHandler(this.frmQL_TrangCaNhan_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtcCongViec)).EndInit();
            this.xtcCongViec.ResumeLayout(false);
            this.xtpLoadGrid.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgDaNhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaNhan.Properties)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgDangLam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDangLam.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgDaXong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHoanThanh.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraTab.XtraTabControl xtcCongViec;
        private DevExpress.XtraTab.XtraTabPage xtpLoadGrid;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private VSCM.Base.Controls.ucTextBox txtDaNhan;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private VSCM.Base.Controls.ucTextBox txtDangLam;
        private VSCM.Base.Controls.ucTextBox txtHoanThanh;
        private VSCM.Base.Controls.ucFlexGrid fgDaNhan;
        private VSCM.Base.Controls.ucFlexGrid fgDangLam;
        private VSCM.Base.Controls.ucFlexGrid fgDaXong;
    }
}