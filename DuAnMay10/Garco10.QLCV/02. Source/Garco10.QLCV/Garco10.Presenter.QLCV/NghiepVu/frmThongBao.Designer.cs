namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmThongBao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongBao));
            this.fgThongBao = new VSCM.Base.Controls.ucFlexGrid();
            this.btnDaXem = new VSCM.Base.Controls.ucButton();
            this.btnThoat = new VSCM.Base.Controls.ucButton();
            this.btnThongBao = new VSCM.Base.Controls.ucButton();
            ((System.ComponentModel.ISupportInitialize)(this.fgThongBao)).BeginInit();
            this.SuspendLayout();
            // 
            // fgThongBao
            // 
            this.fgThongBao.AllowEditing = false;
            this.fgThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fgThongBao.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgThongBao.ColumnInfo = resources.GetString("fgThongBao.ColumnInfo");
            this.fgThongBao.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgThongBao.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgThongBao.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgThongBao.Location = new System.Drawing.Point(2, 6);
            this.fgThongBao.Name = "fgThongBao";
            this.fgThongBao.Rows.Count = 1;
            this.fgThongBao.Rows.DefaultSize = 18;
            this.fgThongBao.Rows.MinSize = 21;
            this.fgThongBao.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgThongBao.Size = new System.Drawing.Size(676, 333);
            this.fgThongBao.StyleInfo = resources.GetString("fgThongBao.StyleInfo");
            this.fgThongBao.TabIndex = 0;
            this.fgThongBao.DoubleClick += new System.EventHandler(this.fgThongBao_DoubleClick);
            // 
            // btnDaXem
            // 
            this.btnDaXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDaXem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaXem.Appearance.Options.UseFont = true;
            this.btnDaXem.Image = global::Garco10.Presenter.QLCV.Properties.Resources.read;
            this.btnDaXem.Location = new System.Drawing.Point(447, 345);
            this.btnDaXem.Name = "btnDaXem";
            this.btnDaXem.Size = new System.Drawing.Size(125, 26);
            this.btnDaXem.TabIndex = 2;
            this.btnDaXem.Text = "&Đánh dấu đã đọc";
            this.btnDaXem.Click += new System.EventHandler(this.btnDaXem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.btnThoat.Location = new System.Drawing.Point(578, 345);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 26);
            this.btnThoat.TabIndex = 1;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThongBao.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongBao.Appearance.Options.UseFont = true;
            this.btnThongBao.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Add;
            this.btnThongBao.Location = new System.Drawing.Point(316, 345);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(125, 26);
            this.btnThongBao.TabIndex = 2;
            this.btnThongBao.Text = "Tạo thông &báo";
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // frmThongBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 374);
            this.Controls.Add(this.btnThongBao);
            this.Controls.Add(this.btnDaXem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.fgThongBao);
            this.MaximizeBox = false;
            this.Name = "frmThongBao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông báo";
            this.Load += new System.EventHandler(this.frmThongBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fgThongBao)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucFlexGrid fgThongBao;
        private VSCM.Base.Controls.ucButton btnThoat;
        private VSCM.Base.Controls.ucButton btnDaXem;
        private VSCM.Base.Controls.ucButton btnThongBao;
    }
}