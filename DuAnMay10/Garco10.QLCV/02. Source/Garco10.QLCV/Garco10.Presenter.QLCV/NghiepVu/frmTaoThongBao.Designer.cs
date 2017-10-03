namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmTaoThongBao
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
            this.txtNoiDung = new VSCM.Base.Controls.ucMemoEdit();
            this.ucLabel2 = new VSCM.Base.Controls.ucLabel();
            this.btnThoat = new VSCM.Base.Controls.ucButton();
            this.btnGui = new VSCM.Base.Controls.ucButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbNguoiNhan = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.ucLabel3 = new VSCM.Base.Controls.ucLabel();
            this.cmbDonVi = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNguoiNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(14, 74);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(49, 13);
            this.ucLabel1.TabIndex = 4;
            this.ucLabel1.Text = "Nội dung :";
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.EditValue = "";
            this.txtNoiDung.FieldGroup = "";
            this.txtNoiDung.FieldName = "";
            this.txtNoiDung.Location = new System.Drawing.Point(123, 71);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtNoiDung.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtNoiDung.Properties.Name = "fProperties";
            this.txtNoiDung.Size = new System.Drawing.Size(385, 125);
            this.txtNoiDung.TabIndex = 5;
            // 
            // ucLabel2
            // 
            this.ucLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel2.FieldGroup = "";
            this.ucLabel2.FieldName = "";
            this.ucLabel2.Location = new System.Drawing.Point(14, 48);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(62, 13);
            this.ucLabel2.TabIndex = 2;
            this.ucLabel2.Text = "Người nhận :";
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.btnThoat.Location = new System.Drawing.Point(408, 202);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 26);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnGui
            // 
            this.btnGui.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.Appearance.Options.UseFont = true;
            this.btnGui.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Forward;
            this.btnGui.Location = new System.Drawing.Point(302, 202);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(100, 26);
            this.btnGui.TabIndex = 6;
            this.btnGui.Text = "&Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID_NhanSu";
            this.gridColumn1.FieldName = "ID_NhanSu";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nhân viên";
            this.gridColumn2.FieldName = "HoTen";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // cmbNguoiNhan
            // 
            this.cmbNguoiNhan.Location = new System.Drawing.Point(123, 43);
            this.cmbNguoiNhan.Name = "cmbNguoiNhan";
            this.cmbNguoiNhan.Properties.AutoHeight = false;
            this.cmbNguoiNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNguoiNhan.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbNguoiNhan.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbNguoiNhan.Size = new System.Drawing.Size(385, 21);
            this.cmbNguoiNhan.TabIndex = 3;
            // 
            // ucLabel3
            // 
            this.ucLabel3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel3.FieldGroup = "";
            this.ucLabel3.FieldName = "";
            this.ucLabel3.Location = new System.Drawing.Point(14, 15);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(38, 13);
            this.ucLabel3.TabIndex = 0;
            this.ucLabel3.Text = "Đơn vị :";
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.FieldGroup = "";
            this.cmbDonVi.FieldName = "";
            this.cmbDonVi.Location = new System.Drawing.Point(123, 12);
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
            this.cmbDonVi.Size = new System.Drawing.Size(385, 21);
            this.cmbDonVi.TabIndex = 1;
            this.cmbDonVi.EditValueChanged += new System.EventHandler(this.cmbDonVi_EditValueChanged);
            // 
            // ucSearchLookupEdit1View
            // 
            this.ucSearchLookupEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.ucSearchLookupEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ucSearchLookupEdit1View.Name = "ucSearchLookupEdit1View";
            this.ucSearchLookupEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowAutoFilterRow = true;
            this.ucSearchLookupEdit1View.OptionsView.ShowColumnHeaders = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowGroupPanel = false;
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
            // frmTaoThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 233);
            this.Controls.Add(this.cmbDonVi);
            this.Controls.Add(this.btnGui);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.ucLabel3);
            this.Controls.Add(this.ucLabel2);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.ucLabel1);
            this.Controls.Add(this.cmbNguoiNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTaoThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gửi thông báo";
            this.Load += new System.EventHandler(this.frmTaoThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNoiDung.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNguoiNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucMemoEdit txtNoiDung;
        private VSCM.Base.Controls.ucLabel ucLabel2;
        private VSCM.Base.Controls.ucButton btnThoat;
        private VSCM.Base.Controls.ucButton btnGui;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.CheckedComboBoxEdit cmbNguoiNhan;
        private VSCM.Base.Controls.ucLabel ucLabel3;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
    }
}