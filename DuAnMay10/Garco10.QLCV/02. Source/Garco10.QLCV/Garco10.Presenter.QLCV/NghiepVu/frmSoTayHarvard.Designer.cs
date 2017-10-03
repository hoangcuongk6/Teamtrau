namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmSoTayHarvard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSoTayHarvard));
            this.fgHarvard = new VSCM.Base.Controls.ucFlexGrid();
            this.lblHuongDan = new VSCM.Base.Controls.ucLabel();
            this.txtTimKiem = new VSCM.Base.Controls.ucTextBox();
            this.btnHuy = new VSCM.Base.Controls.ucButton();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            this.btnCapNhat = new VSCM.Base.Controls.ucButton();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fgHarvard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // fgHarvard
            // 
            this.fgHarvard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgHarvard.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgHarvard.ColumnInfo = resources.GetString("fgHarvard.ColumnInfo");
            this.fgHarvard.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgHarvard.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgHarvard.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgHarvard.Location = new System.Drawing.Point(3, 44);
            this.fgHarvard.Name = "fgHarvard";
            this.fgHarvard.Rows.Count = 1;
            this.fgHarvard.Rows.DefaultSize = 18;
            this.fgHarvard.Rows.MinSize = 21;
            this.fgHarvard.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgHarvard.Size = new System.Drawing.Size(1134, 642);
            this.fgHarvard.StyleInfo = resources.GetString("fgHarvard.StyleInfo");
            this.fgHarvard.TabIndex = 0;
            this.fgHarvard.StartEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgHarvard_StartEdit);
            this.fgHarvard.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgHarvard_AfterEdit);
            this.fgHarvard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fgHarvard_KeyUp);
            // 
            // lblHuongDan
            // 
            this.lblHuongDan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblHuongDan.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuongDan.Appearance.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblHuongDan.FieldGroup = "";
            this.lblHuongDan.FieldName = "";
            this.lblHuongDan.Location = new System.Drawing.Point(500, 698);
            this.lblHuongDan.Name = "lblHuongDan";
            this.lblHuongDan.Size = new System.Drawing.Size(203, 13);
            this.lblHuongDan.TabIndex = 2;
            this.lblHuongDan.Text = "Bấm \"Insert\" để thêm mới, \"Delete\" để xóa";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.FieldGroup = "";
            this.txtTimKiem.FieldName = "";
            this.txtTimKiem.Location = new System.Drawing.Point(3, 12);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.AutoHeight = false;
            this.txtTimKiem.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtTimKiem.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtTimKiem.Properties.Name = "fProperties";
            this.txtTimKiem.Properties.NullValuePrompt = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTimKiem.Size = new System.Drawing.Size(206, 21);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.EditValueChanged += new System.EventHandler(this.txtTimKiem_EditValueChanged);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Back;
            this.btnHuy.Location = new System.Drawing.Point(109, 692);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 26);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Save;
            this.btnLuu.Location = new System.Drawing.Point(3, 692);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 26);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "&Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.Appearance.Options.UseFont = true;
            this.btnCapNhat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Edit;
            this.btnCapNhat.Location = new System.Drawing.Point(3, 692);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(100, 26);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // ucLabel1
            // 
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.Appearance.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Search;
            this.ucLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(216, 10);
            this.ucLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(23, 23);
            this.ucLabel1.TabIndex = 4;
            // 
            // frmSoTayHarvard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 721);
            this.Controls.Add(this.ucLabel1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lblHuongDan);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.fgHarvard);
            this.MaximizeBox = false;
            this.Name = "frmSoTayHarvard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sổ tay Harvard";
            this.Load += new System.EventHandler(this.frmSoTayHarvard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fgHarvard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VSCM.Base.Controls.ucFlexGrid fgHarvard;
        private VSCM.Base.Controls.ucButton btnCapNhat;
        private VSCM.Base.Controls.ucButton btnLuu;
        private VSCM.Base.Controls.ucButton btnHuy;
        private VSCM.Base.Controls.ucLabel lblHuongDan;
        private VSCM.Base.Controls.ucTextBox txtTimKiem;
        private VSCM.Base.Controls.ucLabel ucLabel1;
    }
}