namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmCongViec_LichSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCongViec_LichSu));
            this.btnThoat = new VSCM.Base.Controls.ucButton();
            this.fgLichSu = new VSCM.Base.Controls.ucFlexGrid();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            this.txtMaCV = new VSCM.Base.Controls.ucTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fgLichSu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.btnThoat.Location = new System.Drawing.Point(665, 375);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 26);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // fgLichSu
            // 
            this.fgLichSu.AllowEditing = false;
            this.fgLichSu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgLichSu.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgLichSu.ColumnInfo = resources.GetString("fgLichSu.ColumnInfo");
            this.fgLichSu.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgLichSu.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgLichSu.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgLichSu.Location = new System.Drawing.Point(2, 41);
            this.fgLichSu.Name = "fgLichSu";
            this.fgLichSu.Rows.Count = 1;
            this.fgLichSu.Rows.DefaultSize = 18;
            this.fgLichSu.Rows.MinSize = 21;
            this.fgLichSu.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgLichSu.Size = new System.Drawing.Size(763, 328);
            this.fgLichSu.StyleInfo = resources.GetString("fgLichSu.StyleInfo");
            this.fgLichSu.TabIndex = 1;
            this.fgLichSu.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.fgLichSu_OwnerDrawCell);
            this.fgLichSu.DoubleClick += new System.EventHandler(this.fgLichSu_DoubleClick);
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(12, 12);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(66, 13);
            this.ucLabel1.TabIndex = 2;
            this.ucLabel1.Text = "Mã công việc:";
            // 
            // txtMaCV
            // 
            this.txtMaCV.FieldGroup = "";
            this.txtMaCV.FieldName = "";
            this.txtMaCV.Location = new System.Drawing.Point(84, 9);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Properties.AutoHeight = false;
            this.txtMaCV.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtMaCV.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtMaCV.Properties.Name = "fProperties";
            this.txtMaCV.Properties.ReadOnly = true;
            this.txtMaCV.Size = new System.Drawing.Size(150, 21);
            this.txtMaCV.TabIndex = 3;
            // 
            // frmCongViec_LichSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 404);
            this.Controls.Add(this.txtMaCV);
            this.Controls.Add(this.ucLabel1);
            this.Controls.Add(this.fgLichSu);
            this.Controls.Add(this.btnThoat);
            this.MaximizeBox = false;
            this.Name = "frmCongViec_LichSu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử thay đổi công việc";
            this.Load += new System.EventHandler(this.frmCongViec_LichSu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fgLichSu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucButton btnThoat;
        private VSCM.Base.Controls.ucFlexGrid fgLichSu;
        private VSCM.Base.Controls.ucLabel ucLabel1;
        private VSCM.Base.Controls.ucTextBox txtMaCV;
    }
}