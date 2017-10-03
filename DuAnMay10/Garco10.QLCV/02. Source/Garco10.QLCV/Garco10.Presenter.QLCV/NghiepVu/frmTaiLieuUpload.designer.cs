namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmTaiLieuUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiLieuUpload));
            this.cmdXoa = new VSCM.Base.Controls.ucButton();
            this.cmdDownload = new VSCM.Base.Controls.ucButton();
            this.cmdUpload = new VSCM.Base.Controls.ucButton();
            this.ucGroupBox4 = new VSCM.Base.Controls.ucGroupBox();
            this.fgFile = new VSCM.Base.Controls.ucFlexGrid();
            this.cmdSua = new VSCM.Base.Controls.ucButton();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.cmbFileType = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFileType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdXoa
            // 
            this.cmdXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdXoa.Appearance.Options.UseFont = true;
            this.cmdXoa.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Delete;
            this.cmdXoa.Location = new System.Drawing.Point(258, 425);
            this.cmdXoa.Name = "cmdXoa";
            this.cmdXoa.Size = new System.Drawing.Size(120, 26);
            this.cmdXoa.TabIndex = 801;
            this.cmdXoa.Text = "Xóa tài liệu";
            this.cmdXoa.Click += new System.EventHandler(this.cmdXoa_Click);
            // 
            // cmdDownload
            // 
            this.cmdDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdDownload.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDownload.Appearance.Options.UseFont = true;
            this.cmdDownload.Image = ((System.Drawing.Image)(resources.GetObject("cmdDownload.Image")));
            this.cmdDownload.Location = new System.Drawing.Point(384, 425);
            this.cmdDownload.Name = "cmdDownload";
            this.cmdDownload.Size = new System.Drawing.Size(120, 26);
            this.cmdDownload.TabIndex = 800;
            this.cmdDownload.Text = "Download tài liệu";
            this.cmdDownload.Click += new System.EventHandler(this.cmdDownload_Click);
            // 
            // cmdUpload
            // 
            this.cmdUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdUpload.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpload.Appearance.Options.UseFont = true;
            this.cmdUpload.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Upload;
            this.cmdUpload.Location = new System.Drawing.Point(6, 425);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(120, 26);
            this.cmdUpload.TabIndex = 799;
            this.cmdUpload.Text = "Upload tài liệu";
            this.cmdUpload.Click += new System.EventHandler(this.cmdUpload_Click);
            // 
            // ucGroupBox4
            // 
            this.ucGroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGroupBox4.Controls.Add(this.fgFile);
            this.ucGroupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucGroupBox4.Location = new System.Drawing.Point(3, 35);
            this.ucGroupBox4.Name = "ucGroupBox4";
            this.ucGroupBox4.Size = new System.Drawing.Size(778, 387);
            this.ucGroupBox4.TabIndex = 798;
            this.ucGroupBox4.TabStop = false;
            this.ucGroupBox4.Text = "Danh sách";
            // 
            // fgFile
            // 
            this.fgFile.AllowEditing = false;
            this.fgFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgFile.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgFile.ColumnInfo = resources.GetString("fgFile.ColumnInfo");
            this.fgFile.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgFile.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgFile.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgFile.Location = new System.Drawing.Point(3, 17);
            this.fgFile.Name = "fgFile";
            this.fgFile.Rows.Count = 10;
            this.fgFile.Rows.DefaultSize = 18;
            this.fgFile.Rows.MinSize = 21;
            this.fgFile.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgFile.Size = new System.Drawing.Size(772, 367);
            this.fgFile.StyleInfo = resources.GetString("fgFile.StyleInfo");
            this.fgFile.TabIndex = 0;
            this.fgFile.DoubleClick += new System.EventHandler(this.fgFile_DoubleClick);
            // 
            // cmdSua
            // 
            this.cmdSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSua.Appearance.Options.UseFont = true;
            this.cmdSua.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Edit;
            this.cmdSua.Location = new System.Drawing.Point(132, 425);
            this.cmdSua.Name = "cmdSua";
            this.cmdSua.Size = new System.Drawing.Size(120, 26);
            this.cmdSua.TabIndex = 802;
            this.cmdSua.Text = "Thay đổi thông tin";
            this.cmdSua.Click += new System.EventHandler(this.cmdSua_Click);
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(6, 12);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(60, 13);
            this.ucLabel1.TabIndex = 803;
            this.ucLabel1.Text = "Loại tài liệu :";
            // 
            // cmbFileType
            // 
            this.cmbFileType.FieldGroup = "";
            this.cmbFileType.FieldName = "";
            this.cmbFileType.Location = new System.Drawing.Point(72, 8);
            this.cmbFileType.Name = "cmbFileType";
            this.cmbFileType.Properties.AutoHeight = false;
            this.cmbFileType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFileType.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbFileType.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbFileType.Properties.NullText = "";
            this.cmbFileType.Properties.View = this.ucSearchLookupEdit1View;
            this.cmbFileType.Size = new System.Drawing.Size(150, 21);
            this.cmbFileType.TabIndex = 804;
            this.cmbFileType.EditValueChanged += new System.EventHandler(this.cmbFileType_EditValueChanged);
            // 
            // ucSearchLookupEdit1View
            // 
            this.ucSearchLookupEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.ucSearchLookupEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ucSearchLookupEdit1View.Name = "ucSearchLookupEdit1View";
            this.ucSearchLookupEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID_FileType";
            this.gridColumn3.FieldName = "ID_FileType";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Loại tài liệu";
            this.gridColumn4.FieldName = "FileType_Name";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID_FileType";
            this.gridColumn1.FieldName = "ID_FileType";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "FileType_Name";
            this.gridColumn2.FieldName = "FileType_Name";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // frmTaiLieuUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 455);
            this.Controls.Add(this.cmbFileType);
            this.Controls.Add(this.ucLabel1);
            this.Controls.Add(this.cmdSua);
            this.Controls.Add(this.cmdXoa);
            this.Controls.Add(this.cmdDownload);
            this.Controls.Add(this.cmdUpload);
            this.Controls.Add(this.ucGroupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmTaiLieuUpload";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tài liệu";
            this.Load += new System.EventHandler(this.frmUploadFileShow_Load);
            this.ucGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFileType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucGroupBox ucGroupBox4;
        private VSCM.Base.Controls.ucFlexGrid fgFile;
        private VSCM.Base.Controls.ucButton cmdXoa;
        private VSCM.Base.Controls.ucButton cmdDownload;
        private VSCM.Base.Controls.ucButton cmdUpload;
        private VSCM.Base.Controls.ucButton cmdSua;
        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbFileType;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;

    }
}