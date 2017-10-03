namespace Garco10.Presenter.QLCV.TienIch
{
    partial class frmUploadFileShow_ChiTiet
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
            this.ucLabel2 = new VSCM.Base.Controls.ucLabel();
            this.txtGhiChu = new VSCM.Base.Controls.ucMemoEdit();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.cmbFiletype = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtFileName = new VSCM.Base.Controls.ucTextBox();
            this.cmdThoat = new VSCM.Base.Controls.ucButton();
            this.cmdUpload = new VSCM.Base.Controls.ucButton();
            this.lblTen = new VSCM.Base.Controls.ucLabel();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiletype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ucLabel2
            // 
            this.ucLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel2.FieldGroup = "";
            this.ucLabel2.FieldName = "";
            this.ucLabel2.Location = new System.Drawing.Point(7, 69);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(31, 13);
            this.ucLabel2.TabIndex = 802;
            this.ucLabel2.Text = "Mô tả:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGhiChu.FieldGroup = "";
            this.txtGhiChu.FieldName = "";
            this.txtGhiChu.Location = new System.Drawing.Point(56, 66);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtGhiChu.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtGhiChu.Properties.Name = "fProperties";
            this.txtGhiChu.Size = new System.Drawing.Size(322, 162);
            this.txtGhiChu.TabIndex = 801;
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(7, 15);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(40, 13);
            this.ucLabel1.TabIndex = 800;
            this.ucLabel1.Text = "Loại file:";
            // 
            // cmbFiletype
            // 
            this.cmbFiletype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiletype.FieldGroup = "";
            this.cmbFiletype.FieldName = "";
            this.cmbFiletype.Location = new System.Drawing.Point(56, 12);
            this.cmbFiletype.Name = "cmbFiletype";
            this.cmbFiletype.Properties.AutoHeight = false;
            this.cmbFiletype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFiletype.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbFiletype.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbFiletype.Properties.NullText = "";
            this.cmbFiletype.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbFiletype.Properties.View = this.ucSearchLookupEdit1View;
            this.cmbFiletype.Size = new System.Drawing.Size(322, 21);
            this.cmbFiletype.TabIndex = 799;
            // 
            // ucSearchLookupEdit1View
            // 
            this.ucSearchLookupEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.ucSearchLookupEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ucSearchLookupEdit1View.Name = "ucSearchLookupEdit1View";
            this.ucSearchLookupEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // txtFileName
            // 
            this.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileName.FieldGroup = "";
            this.txtFileName.FieldName = "";
            this.txtFileName.Location = new System.Drawing.Point(56, 39);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.txtFileName.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtFileName.Properties.Appearance.Options.UseBackColor = true;
            this.txtFileName.Properties.AutoHeight = false;
            this.txtFileName.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtFileName.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtFileName.Properties.Name = "fProperties";
            this.txtFileName.Properties.NullValuePrompt = "Click double chuột để tải file";
            this.txtFileName.Properties.ReadOnly = true;
            this.txtFileName.ShowToolTips = false;
            this.txtFileName.Size = new System.Drawing.Size(322, 21);
            this.txtFileName.TabIndex = 798;
            // 
            // cmdThoat
            // 
            this.cmdThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdThoat.Appearance.Options.UseFont = true;
            this.cmdThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.cmdThoat.Location = new System.Drawing.Point(194, 234);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(80, 23);
            this.cmdThoat.TabIndex = 797;
            this.cmdThoat.Tag = "0";
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // cmdUpload
            // 
            this.cmdUpload.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdUpload.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpload.Appearance.Options.UseFont = true;
            this.cmdUpload.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Save;
            this.cmdUpload.Location = new System.Drawing.Point(108, 234);
            this.cmdUpload.Name = "cmdUpload";
            this.cmdUpload.Size = new System.Drawing.Size(80, 23);
            this.cmdUpload.TabIndex = 797;
            this.cmdUpload.Tag = "0";
            this.cmdUpload.Text = "Lưu lại";
            this.cmdUpload.Click += new System.EventHandler(this.cmdGhi_Click);
            // 
            // lblTen
            // 
            this.lblTen.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.FieldGroup = "";
            this.lblTen.FieldName = "";
            this.lblTen.Location = new System.Drawing.Point(7, 42);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(20, 13);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "File:";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
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
            this.gridColumn2.Width = 130;
            // 
            // frmUploadFileShow_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 260);
            this.Controls.Add(this.ucLabel2);
            this.Controls.Add(this.txtGhiChu);
            this.Controls.Add(this.ucLabel1);
            this.Controls.Add(this.cmbFiletype);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdUpload);
            this.Controls.Add(this.lblTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmUploadFileShow_ChiTiet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi thông tin";
            this.Load += new System.EventHandler(this.frmUploadFileShow_ChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFiletype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFileName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucLabel lblTen;
        private VSCM.Base.Controls.ucButton cmdUpload;
        private VSCM.Base.Controls.ucButton cmdThoat;
        private VSCM.Base.Controls.ucTextBox txtFileName;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbFiletype;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucMemoEdit txtGhiChu;
        private VSCM.Base.Controls.ucLabel ucLabel2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}