namespace Garco10.Presenter.QLCV.DanhMuc
{
    partial class frmPhanCap_DonVi
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
            this.ucGroupBox1 = new VSCM.Base.Controls.ucGroupBox();
            this.ucGroupBox2 = new VSCM.Base.Controls.ucGroupBox();
            this.cmbDonViTrucThuoc = new VSCM.Base.Controls.ucCheckedComboBox();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            this.cmbDonVi = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ucGroupBox1.SuspendLayout();
            this.ucGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonViTrucThuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGroupBox1
            // 
            this.ucGroupBox1.Controls.Add(this.cmbDonVi);
            this.ucGroupBox1.Location = new System.Drawing.Point(0, 1);
            this.ucGroupBox1.Name = "ucGroupBox1";
            this.ucGroupBox1.Size = new System.Drawing.Size(254, 63);
            this.ucGroupBox1.TabIndex = 0;
            this.ucGroupBox1.TabStop = false;
            this.ucGroupBox1.Text = "Chọn đơn vị";
            // 
            // ucGroupBox2
            // 
            this.ucGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucGroupBox2.Controls.Add(this.cmbDonViTrucThuoc);
            this.ucGroupBox2.Location = new System.Drawing.Point(255, 1);
            this.ucGroupBox2.Name = "ucGroupBox2";
            this.ucGroupBox2.Size = new System.Drawing.Size(254, 63);
            this.ucGroupBox2.TabIndex = 1;
            this.ucGroupBox2.TabStop = false;
            this.ucGroupBox2.Text = "Chọn đơn vị trực thuộc";
            // 
            // cmbDonViTrucThuoc
            // 
            this.cmbDonViTrucThuoc.FieldGroup = "";
            this.cmbDonViTrucThuoc.FieldName = "";
            this.cmbDonViTrucThuoc.Location = new System.Drawing.Point(0, 19);
            this.cmbDonViTrucThuoc.Name = "cmbDonViTrucThuoc";
            this.cmbDonViTrucThuoc.Properties.AutoHeight = false;
            this.cmbDonViTrucThuoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDonViTrucThuoc.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbDonViTrucThuoc.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbDonViTrucThuoc.Size = new System.Drawing.Size(250, 21);
            this.cmbDonViTrucThuoc.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Save;
            this.btnLuu.Location = new System.Drawing.Point(204, 70);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 26);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cmbDonVi
            // 
            this.cmbDonVi.FieldGroup = "";
            this.cmbDonVi.FieldName = "";
            this.cmbDonVi.Location = new System.Drawing.Point(0, 19);
            this.cmbDonVi.Name = "cmbDonVi";
            this.cmbDonVi.Properties.AutoHeight = false;
            this.cmbDonVi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDonVi.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbDonVi.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbDonVi.Properties.NullText = "";
            this.cmbDonVi.Properties.View = this.ucSearchLookupEdit1View;
            this.cmbDonVi.Size = new System.Drawing.Size(250, 21);
            this.cmbDonVi.TabIndex = 0;
            this.cmbDonVi.EditValueChanged += new System.EventHandler(this.cmbDonVi_EditValueChanged);
            // 
            // ucSearchLookupEdit1View
            // 
            this.ucSearchLookupEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ucSearchLookupEdit1View.Name = "ucSearchLookupEdit1View";
            this.ucSearchLookupEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // frmPhanCap_DonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(510, 101);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.ucGroupBox2);
            this.Controls.Add(this.ucGroupBox1);
            this.Name = "frmPhanCap_DonVi";
            this.ShowIcon = false;
            this.Text = "Phân cấp đơn vị";
            this.Load += new System.EventHandler(this.frmPhanCap_DonVi_Load);
            this.ucGroupBox1.ResumeLayout(false);
            this.ucGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonViTrucThuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDonVi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucGroupBox ucGroupBox1;
        private VSCM.Base.Controls.ucGroupBox ucGroupBox2;
        private VSCM.Base.Controls.ucCheckedComboBox cmbDonViTrucThuoc;
        private VSCM.Base.Controls.ucButton btnLuu;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbDonVi;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
    }
}