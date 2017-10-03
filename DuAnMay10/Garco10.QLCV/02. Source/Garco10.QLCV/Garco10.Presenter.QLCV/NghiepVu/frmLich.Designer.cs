namespace Garco10.Presenter.QLCV.NghiepVu
{
    partial class frmLich
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLich));
            this.fg = new VSCM.Base.Controls.ucFlexGrid();
            this.ucLabel8 = new VSCM.Base.Controls.ucLabel();
            this.ucLabel4 = new VSCM.Base.Controls.ucLabel();
            this.ucLabel9 = new VSCM.Base.Controls.ucLabel();
            this.ucLabel2 = new VSCM.Base.Controls.ucLabel();
            this.ucLabel3 = new VSCM.Base.Controls.ucLabel();
            this.btnHomNay = new VSCM.Base.Controls.ucButton();
            this.ucTextBox1 = new VSCM.Base.Controls.ucTextBox();
            this.cmbLoaiCV = new VSCM.Base.Controls.ucCheckedComboBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucLabel1 = new VSCM.Base.Controls.ucLabel();
            ((System.ComponentModel.ISupportInitialize)(this.fg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucTextBox1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiCV.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fg
            // 
            this.fg.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.fg.AllowEditing = false;
            this.fg.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.None;
            this.fg.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.fg.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.fg.AutoGenerateColumns = false;
            this.fg.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fg.ColumnInfo = "1,0,0,0,0,90,Columns:";
            this.fg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fg.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            this.fg.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fg.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fg.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fg.Location = new System.Drawing.Point(237, 0);
            this.fg.Name = "fg";
            this.fg.Rows.Count = 1;
            this.fg.Rows.DefaultSize = 18;
            this.fg.Rows.MinSize = 21;
            this.fg.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Cell;
            this.fg.Size = new System.Drawing.Size(936, 636);
            this.fg.StyleInfo = resources.GetString("fg.StyleInfo");
            this.fg.TabIndex = 3;
            this.fg.OwnerDrawCell += new C1.Win.C1FlexGrid.OwnerDrawCellEventHandler(this.fg_OwnerDrawCell_1);
            this.fg.DoubleClick += new System.EventHandler(this.fg_DoubleClick);
            // 
            // ucLabel8
            // 
            this.ucLabel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucLabel8.Appearance.BackColor = System.Drawing.Color.DarkCyan;
            this.ucLabel8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel8.Appearance.ForeColor = System.Drawing.Color.White;
            this.ucLabel8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ucLabel8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ucLabel8.FieldGroup = "";
            this.ucLabel8.FieldName = "";
            this.ucLabel8.Location = new System.Drawing.Point(104, 611);
            this.ucLabel8.Name = "ucLabel8";
            this.ucLabel8.Size = new System.Drawing.Size(120, 15);
            this.ucLabel8.TabIndex = 63;
            this.ucLabel8.Text = "             Công tác";
            // 
            // ucLabel4
            // 
            this.ucLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucLabel4.Appearance.BackColor = System.Drawing.Color.Wheat;
            this.ucLabel4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ucLabel4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ucLabel4.FieldGroup = "";
            this.ucLabel4.FieldName = "";
            this.ucLabel4.Location = new System.Drawing.Point(15, 569);
            this.ucLabel4.Name = "ucLabel4";
            this.ucLabel4.Size = new System.Drawing.Size(69, 27);
            this.ucLabel4.TabIndex = 62;
            this.ucLabel4.Text = "   Hôm nay";
            // 
            // ucLabel9
            // 
            this.ucLabel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucLabel9.Appearance.BackColor = System.Drawing.Color.Lime;
            this.ucLabel9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ucLabel9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ucLabel9.FieldGroup = "";
            this.ucLabel9.FieldName = "";
            this.ucLabel9.Location = new System.Drawing.Point(104, 590);
            this.ucLabel9.Name = "ucLabel9";
            this.ucLabel9.Size = new System.Drawing.Size(120, 15);
            this.ucLabel9.TabIndex = 64;
            this.ucLabel9.Text = "                 Họp";
            // 
            // ucLabel2
            // 
            this.ucLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ucLabel2.Appearance.BackColor = System.Drawing.Color.Tomato;
            this.ucLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ucLabel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ucLabel2.FieldGroup = "";
            this.ucLabel2.FieldName = "";
            this.ucLabel2.Location = new System.Drawing.Point(15, 595);
            this.ucLabel2.Name = "ucLabel2";
            this.ucLabel2.Size = new System.Drawing.Size(69, 31);
            this.ucLabel2.TabIndex = 60;
            this.ucLabel2.Text = "  Ngày nghỉ";
            // 
            // ucLabel3
            // 
            this.ucLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ucLabel3.Appearance.BackColor = System.Drawing.Color.Blue;
            this.ucLabel3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel3.Appearance.ForeColor = System.Drawing.Color.White;
            this.ucLabel3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.ucLabel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
            this.ucLabel3.FieldGroup = "";
            this.ucLabel3.FieldName = "";
            this.ucLabel3.Location = new System.Drawing.Point(104, 569);
            this.ucLabel3.Name = "ucLabel3";
            this.ucLabel3.Size = new System.Drawing.Size(120, 15);
            this.ucLabel3.TabIndex = 61;
            this.ucLabel3.Text = "            Công việc";
            // 
            // btnHomNay
            // 
            this.btnHomNay.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHomNay.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomNay.Appearance.Options.UseFont = true;
            this.btnHomNay.Location = new System.Drawing.Point(62, 179);
            this.btnHomNay.Name = "btnHomNay";
            this.btnHomNay.Size = new System.Drawing.Size(105, 41);
            this.btnHomNay.TabIndex = 59;
            this.btnHomNay.Text = "Hôm nay";
            this.btnHomNay.Click += new System.EventHandler(this.btnHomNay_Click_1);
            // 
            // ucTextBox1
            // 
            this.ucTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ucTextBox1.EditValue = "Tùy chọn hiển thị";
            this.ucTextBox1.FieldGroup = "";
            this.ucTextBox1.FieldName = "";
            this.ucTextBox1.Location = new System.Drawing.Point(40, 226);
            this.ucTextBox1.Name = "ucTextBox1";
            this.ucTextBox1.Properties.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ucTextBox1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTextBox1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.ucTextBox1.Properties.Appearance.Options.UseBackColor = true;
            this.ucTextBox1.Properties.Appearance.Options.UseFont = true;
            this.ucTextBox1.Properties.Appearance.Options.UseForeColor = true;
            this.ucTextBox1.Properties.Appearance.Options.UseTextOptions = true;
            this.ucTextBox1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ucTextBox1.Properties.AutoHeight = false;
            this.ucTextBox1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.ucTextBox1.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.ucTextBox1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.ucTextBox1.Properties.Name = "fProperties";
            this.ucTextBox1.Size = new System.Drawing.Size(149, 27);
            this.ucTextBox1.TabIndex = 65;
            this.ucTextBox1.EditValueChanged += new System.EventHandler(this.ucTextBox1_EditValueChanged);
            // 
            // cmbLoaiCV
            // 
            this.cmbLoaiCV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbLoaiCV.FieldGroup = "";
            this.cmbLoaiCV.FieldName = "";
            this.cmbLoaiCV.Location = new System.Drawing.Point(40, 254);
            this.cmbLoaiCV.Name = "cmbLoaiCV";
            this.cmbLoaiCV.Properties.AutoHeight = false;
            this.cmbLoaiCV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbLoaiCV.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbLoaiCV.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbLoaiCV.Size = new System.Drawing.Size(149, 24);
            this.cmbLoaiCV.TabIndex = 66;
            this.cmbLoaiCV.EditValueChanged += new System.EventHandler(this.cmbLoaiCV_EditValueChanged_1);
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar.Location = new System.Drawing.Point(5, 5);
            this.monthCalendar.Margin = new System.Windows.Forms.Padding(0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.ShowTodayCircle = false;
            this.monthCalendar.TabIndex = 11;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnHomNay);
            this.panel1.Controls.Add(this.ucLabel1);
            this.panel1.Controls.Add(this.monthCalendar);
            this.panel1.Controls.Add(this.cmbLoaiCV);
            this.panel1.Controls.Add(this.ucLabel8);
            this.panel1.Controls.Add(this.ucTextBox1);
            this.panel1.Controls.Add(this.ucLabel4);
            this.panel1.Controls.Add(this.ucLabel9);
            this.panel1.Controls.Add(this.ucLabel3);
            this.panel1.Controls.Add(this.ucLabel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 636);
            this.panel1.TabIndex = 4;
            // 
            // ucLabel1
            // 
            this.ucLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ucLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucLabel1.Appearance.ForeColor = System.Drawing.Color.White;
            this.ucLabel1.FieldGroup = "";
            this.ucLabel1.FieldName = "";
            this.ucLabel1.Location = new System.Drawing.Point(154, 178);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(42, 13);
            this.ucLabel1.TabIndex = 67;
            this.ucLabel1.Text = "ucLabel1";
            // 
            // frmLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1173, 636);
            this.Controls.Add(this.fg);
            this.Controls.Add(this.panel1);
            this.Name = "frmLich";
            this.ShowIcon = false;
            this.Text = "Lịch";
            this.Load += new System.EventHandler(this.frmLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucTextBox1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbLoaiCV.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucFlexGrid fg;
        private VSCM.Base.Controls.ucButton btnHomNay;
        private VSCM.Base.Controls.ucLabel ucLabel3;
        private VSCM.Base.Controls.ucLabel ucLabel4;
        private VSCM.Base.Controls.ucLabel ucLabel8;
        private VSCM.Base.Controls.ucLabel ucLabel9;
        private VSCM.Base.Controls.ucLabel ucLabel2;
        private VSCM.Base.Controls.ucCheckedComboBox cmbLoaiCV;
        private VSCM.Base.Controls.ucTextBox ucTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Panel panel1;
        private VSCM.Base.Controls.ucLabel ucLabel1;
    }
}