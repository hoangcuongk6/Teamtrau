namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmCanhBao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCanhBao));
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.cmdThoat = new VSCM.Base.Controls.ucButton();
            this.cmdLuu = new VSCM.Base.Controls.ucButton();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            this.SuspendLayout();
            // 
            // fg
            // 
            this.fg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fg.ColumnInfo = resources.GetString("fg.ColumnInfo");
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(-2, 0);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 18;
            this.fg.Rows.MinSize = 21;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fg.Size = new System.Drawing.Size(398, 188);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 0;
            // 
            // cmdThoat
            // 
            this.cmdThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdThoat.Appearance.Options.UseFont = true;
            this.cmdThoat.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Exit;
            this.cmdThoat.Location = new System.Drawing.Point(194, 194);
            this.cmdThoat.Name = "cmdThoat";
            this.cmdThoat.Size = new System.Drawing.Size(80, 23);
            this.cmdThoat.TabIndex = 799;
            this.cmdThoat.Tag = "0";
            this.cmdThoat.Text = "Thoát";
            this.cmdThoat.Click += new System.EventHandler(this.cmdThoat_Click);
            // 
            // cmdLuu
            // 
            this.cmdLuu.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cmdLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLuu.Appearance.Options.UseFont = true;
            this.cmdLuu.Image = global::Garco10.Presenter.QLCV.Properties.Resources.ico_Upload;
            this.cmdLuu.Location = new System.Drawing.Point(108, 194);
            this.cmdLuu.Name = "cmdLuu";
            this.cmdLuu.Size = new System.Drawing.Size(80, 23);
            this.cmdLuu.TabIndex = 798;
            this.cmdLuu.Tag = "0";
            this.cmdLuu.Text = "Lưu";
            this.cmdLuu.Click += new System.EventHandler(this.cmdLuu_Click);
            // 
            // frmCanhBao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(395, 220);
            this.ControlBox = false;
            this.Controls.Add(this.cmdThoat);
            this.Controls.Add(this.cmdLuu);
            this.Controls.Add(this.fg);
            this.Name = "frmCanhBao";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách cảnh báo";
            this.Load += new System.EventHandler(this.frmCanhBao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucButton cmdThoat;
        private VSCM.Base.Controls.ucButton cmdLuu;
    }
}