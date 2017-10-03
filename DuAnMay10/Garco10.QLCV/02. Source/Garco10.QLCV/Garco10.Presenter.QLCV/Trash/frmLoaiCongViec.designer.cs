namespace Garco10.Presenter.QLCV.DanhMuc
{
    partial class frmLoaiCongViec
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
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.ucLabel2 = new VSCM.Base.Controls.ucLabel();
            this.txtLoaiCV = new VSCM.Base.Controls.ucTextBox();
            this.cmbLoaiCVCha = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            this.btnThoat = new VSCM.Base.Controls.ucButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ucLabel3 = new VSCM.Base.Controls.ucLabel();
            this.chkSuDung = new VSCM.Base.Controls.ucCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiCV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiCVCha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(4, 14);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(92, 13);
            this.ucLabel1.TabIndex = 0;
            this.ucLabel1.Text = "Tên loại công việc :";
            // 
            // ucLabel2
            // 
            this.ucLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel2.FieldGroup = "";
            this.ucLabel2.FieldName = "";
            this.ucLabel2.Location = new System.Drawing.Point(4, 55);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(97, 13);
            this.ucLabel2.TabIndex = 0;
            this.ucLabel2.Text = "Loại công việc cha  :";
            // 
            // txtLoaiCV
            // 
            this.txtLoaiCV.FieldGroup = "";
            this.txtLoaiCV.FieldName = "";
            this.txtLoaiCV.Location = new System.Drawing.Point(126, 8);
            this.txtLoaiCV.Name = "txtLoaiCV";
            this.txtLoaiCV.Properties.AutoHeight = false;
            this.txtLoaiCV.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtLoaiCV.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtLoaiCV.Properties.Name = "fProperties";
            this.txtLoaiCV.Size = new System.Drawing.Size(183, 21);
            this.txtLoaiCV.TabIndex = 1;
            // 
            // cmbLoaiCVCha
            // 
            this.cmbLoaiCVCha.FieldGroup = "";
            this.cmbLoaiCVCha.FieldName = "";
            this.cmbLoaiCVCha.Location = new System.Drawing.Point(126, 52);
            this.cmbLoaiCVCha.Name = "cmbLoaiCVCha";
            this.cmbLoaiCVCha.Properties.AutoHeight = false;
            this.cmbLoaiCVCha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLoaiCVCha.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbLoaiCVCha.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbLoaiCVCha.Properties.NullText = "";
            this.cmbLoaiCVCha.Properties.View = this.ucSearchLookupEdit1View;
            this.cmbLoaiCVCha.Size = new System.Drawing.Size(183, 21);
            this.cmbLoaiCVCha.TabIndex = 2;
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
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Save;
            this.btnLuu.Location = new System.Drawing.Point(126, 109);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(77, 26);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.btnThoat.Location = new System.Drawing.Point(228, 109);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 26);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID_Nhom";
            this.gridColumn1.FieldName = "ID_Nhom";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Tên nhóm";
            this.gridColumn2.FieldName = "Ten_Nhom";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "ID_LoaiCV";
            this.gridColumn3.FieldName = "ID_LoaiCV";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Loại công việc";
            this.gridColumn4.FieldName = "Ten_LoaiCV";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            // 
            // ucLabel3
            // 
            this.ucLabel3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel3.FieldGroup = "";
            this.ucLabel3.FieldName = "";
            this.ucLabel3.Location = new System.Drawing.Point(4, 81);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(44, 13);
            this.ucLabel3.TabIndex = 4;
            this.ucLabel3.Text = "Sử dụng:";
            // 
            // chkSuDung
            // 
            this.chkSuDung.AutoSize = true;
            this.chkSuDung.FieldGroup = "";
            this.chkSuDung.FieldName = "";
            this.chkSuDung.Location = new System.Drawing.Point(126, 79);
            this.chkSuDung.Name = "chkSuDung";
            this.chkSuDung.Size = new System.Drawing.Size(15, 14);
            this.chkSuDung.TabIndex = 5;
            this.chkSuDung.UseVisualStyleBackColor = true;
            // 
            // frmLoaiCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 144);
            this.Controls.Add(this.chkSuDung);
            this.Controls.Add(this.ucLabel3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cmbLoaiCVCha);
            this.Controls.Add(this.txtLoaiCV);
            this.Controls.Add(this.ucLabel2);
            this.Controls.Add(this.ucLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoaiCongViec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại công việc";
            this.Load += new System.EventHandler(this.frmNhom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtLoaiCV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiCVCha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucLabel ucLabel2;
        private VSCM.Base.Controls.ucTextBox txtLoaiCV;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbLoaiCVCha;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private VSCM.Base.Controls.ucButton btnLuu;
        private VSCM.Base.Controls.ucButton btnThoat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private VSCM.Base.Controls.ucLabel ucLabel3;
        private VSCM.Base.Controls.ucCheckBox chkSuDung;
    }
}