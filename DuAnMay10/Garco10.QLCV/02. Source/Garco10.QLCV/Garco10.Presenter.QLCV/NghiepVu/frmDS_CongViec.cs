using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VSCM.Base.Forms;
using VSCM.Base.Utils;
using System.Data.SqlTypes;
using System.Globalization;
using C1.Win.C1FlexGrid;
using DevExpress.XtraBars;
using Garco10.DataAccess.QLCV.Global;
using M10_QLCV;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public enum TrangThai : int
    {
        ChuaThucHien = 1,
        DangThucHien = 2,
        DaXong = 3,
        Huy = 4
    }
    
    public partial class frmDS_CongViec : FormBase
    {
        int id_NhanSu;
        int m_iThongBao;
        string ds_ID_CongViec;
        private CellStyle csChuaThucHien, csDangThucHien, csHuy, csDaXong, csMucDoThap, csMucDoTB, csMucDoCao;
        public frmDS_CongViec(int id_NhanSu)
        {
            InitializeComponent();
            InitCellStyles();
            this.id_NhanSu = id_NhanSu;
        }
        public frmDS_CongViec(string str,DateTime dt)
        {
            InitializeComponent();
            InitCellStyles();
            ds_ID_CongViec = str;
            grbChonThongTin.Visible = false;
            grbOptions.Visible = false;
            btnSua.Visible = false;
            btnThemMoi.Visible = false;
            btnXoa.Visible = false;
            fg.Dock = DockStyle.None;
            grbDSCongViec.Location = new Point(0, 0);
            grbDSCongViec.Dock = DockStyle.Fill;
            fg.Dock = DockStyle.Fill;
            this.Text += " trong ngày " + dt.Date.ToShortDateString();
         
            isView = true;
        }
        public frmDS_CongViec(int id_NhanSu, int iThongBao)
        {
            InitializeComponent();
            InitCellStyles();
            this.id_NhanSu = id_NhanSu;
            m_iThongBao = iThongBao;
        }
        DateTime ngayLuaChon;
        public frmDS_CongViec(DateTime dt,int id_NhanSu)
        {
            InitializeComponent();
            InitCellStyles();
            dtmBatDauDenNgay.Value = dt.Date;
            dtmBatDauTuNgay.Value = dt.Date;
            cmbNhanVien.SetEditValue(id_NhanSu);
            grbChonThongTin.Visible = false;
            grbOptions.Visible = false;
            btnSua.Visible = false;
            btnThemMoi.Visible = false;
            btnXoa.Visible = false;
            fg.Dock = DockStyle.None;
            grbDSCongViec.Location = new Point(0, 0);
            grbDSCongViec.Dock = DockStyle.Fill;
            fg.Dock = DockStyle.Fill;
            this.Text += " trong ngày " + dt.Date.ToShortDateString();
            ngayLuaChon = dt;
            isView = true;
        }
        private void InitCellStyles()
        {
            csChuaThucHien = fg.Styles.Add("Chưa thực hiện");
            csChuaThucHien.BackColor = Color.White;
            csDangThucHien = fg.Styles.Add("Đang thực hiện");
            csDangThucHien.BackColor = Color.LightSkyBlue;
            csDaXong = fg.Styles.Add("Đã xong");
            csDaXong.BackColor = Color.LawnGreen;
            csHuy = fg.Styles.Add("Hủy");
            csHuy.BackColor = Color.Crimson;
            csHuy.ForeColor = Color.White;

            csMucDoCao = fg.Styles.Add("Cao");
            csMucDoCao.ForeColor = Color.Red;
            csMucDoTB = fg.Styles.Add("Trung bình");
            csMucDoTB.ForeColor = Color.MediumBlue;
            csMucDoThap = fg.Styles.Add("Thấp");
            csMucDoThap.ForeColor = Color.Maroon;
        }
        
        #region Load&Lock
        private void dtmTuNgay_TextChanged(object sender, EventArgs e)
        {
            if (fg.Tag + "" != "1") return;
            if (dtmTuNgay.Text != "" && dtmTuNgay.Text.Length != dtmTuNgay.CustomFormat.Length) return;
            fg.ApplyFilters();
        }

        private void dtmDenNgay_TextChanged(object sender, EventArgs e)
        {
            if (fg.Tag + "" != "1") return;
            if (dtmDenNgay.Text != "" && dtmDenNgay.Text.Length != dtmDenNgay.CustomFormat.Length) return;
            Loadfg();
            fg.ApplyFilters();
        }
        private void dtmBatDauTuNgay_TextChanged(object sender, EventArgs e)
        {
            if (fg.Tag + "" != "1") return;
            if (dtmBatDauTuNgay.Text != "" && dtmBatDauTuNgay.Text.Length != dtmBatDauTuNgay.CustomFormat.Length) return;
            Loadfg();
            fg.ApplyFilters();
        }

        private void dtmBatDauDenNgay_TextChanged(object sender, EventArgs e)
        {
            if (fg.Tag + "" != "1") return;
            if (dtmBatDauDenNgay.Text != "" && dtmBatDauDenNgay.Text.Length != dtmBatDauDenNgay.CustomFormat.Length) return;
            Loadfg();
            fg.ApplyFilters();
        }

        private void frmDM_CongViec_Load(object sender, EventArgs e)
        {
            SetUpColumnsFilter();
            if (m_iThongBao == 1)
                SetUpColumnsFilter2();

            fg.Rows.DefaultSize = 35;
            fg.AllowFiltering = true;
            fg.Cols.Frozen = fg.Cols["TieuDe"].Index + 1;
            toolTipNoiDung.ShowAlways = false;
            toolTipNoiDung.AutoPopDelay = 3000;
            toolTipNoiDung.InitialDelay = 0;
            toolTipTimer.Interval = 500;

            DateTime date = DateTime.Now;
            date = new DateTime(date.Year, date.Month, 1);
            dtmTuNgay.Tag = dtmDenNgay.Tag = dtmBatDauTuNgay.Tag = dtmBatDauDenNgay.Tag = 0;
            dtmTuNgay.Value = dtmBatDauTuNgay.Value = date.AddMonths(-1);
            dtmDenNgay.Value = dtmBatDauDenNgay.Value = date.AddMonths(1).AddDays(-1);
            dtmTuNgay.Tag = dtmDenNgay.Tag = dtmBatDauTuNgay.Tag = dtmBatDauDenNgay.Tag = 1;

            LoadcmbNhanVien();
            Loadfg();

            fg.ApplyFilters();
        }

        private void LoadcmbNhanVien()
        {
            var cmb = cmbNhanVien;
            cmb.Tag = 0;
            clsNhanSu cls = new clsNhanSu();
            DataTable dt = cls.GetNhanSu(17, 0);
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Properties.SeparatorChar = ',';
            List<String> editValues = new List<String>();
            foreach (DataRow dr in dt.Rows)
            {
                editValues.Add(dr["ID_NhanSu"].ToString());
            }
            string s = String.Join(",", editValues.ToArray());
            cmbNhanVien.SetEditValue(s);

            cmb.Tag = 1;
        }

        private void SetUpColumnsFilter()
        {
            ConditionFilter _searchFilter = new ConditionFilter();
            _searchFilter.Condition1.Operator = ConditionOperator.Contains;
            fg.Cols["MoTa"].Filter = _searchFilter;
            fg.Cols["DS_Ten_NhanVien"].AllowFiltering = AllowFiltering.None;
        }

        private void SetUpColumnsFilter2()
        {
            ConditionFilter _searchFilter = new ConditionFilter();
            _searchFilter.Condition1.Operator = ConditionOperator.Contains;
            _searchFilter.Condition1.Parameter = DateTime.Today.ToString("dd/MM/yyyy");
            fg.Cols["Ngay_DenHan"].Filter = _searchFilter;
        }
        bool isView = false;
        private void Loadfg()
        {
            fg.Tag = 0;
            fg.BeginUpdate();
            clsCongViec cls = new clsCongViec();

            SqlDateTime TuNgay = SqlDateTime.Null;
            SqlDateTime DenNgay = SqlDateTime.Null;

            SqlDateTime BatDauTuNgay = SqlDateTime.Null;
            SqlDateTime BatDauDenNgay = SqlDateTime.Null;

            if (dtmTuNgay.Text.Length == dtmTuNgay.CustomFormat.Length) TuNgay = DateTime.Parse(dtmTuNgay.Text);
            if (dtmDenNgay.Text.Length == dtmDenNgay.CustomFormat.Length) DenNgay = DateTime.Parse(dtmDenNgay.Text).AddDays(1);


            if (dtmBatDauTuNgay.Text.Length == dtmBatDauTuNgay.CustomFormat.Length) BatDauTuNgay = DateTime.Parse(dtmBatDauTuNgay.Text);
            if (dtmBatDauDenNgay.Text.Length == dtmBatDauDenNgay.CustomFormat.Length) BatDauDenNgay = DateTime.Parse(dtmBatDauDenNgay.Text).AddDays(1);
            DataTable dt;
            //if (!isView)
            //{ 
            //    dt = cls.SelectDS_CongViec(TuNgay, DenNgay, BatDauTuNgay, BatDauDenNgay, id_NhanSu);
            //}
            //else 
            //{ 
            //    dt = cls.SelectDS_CongViec_Trong1Ngay(ngayLuaChon, id_NhanSu);
            //}
           
            
            //dt = cls.SelectDS_CongViec(TuNgay, DenNgay, BatDauTuNgay, BatDauDenNgay, id_NhanSu);

            dt = cls.SelectDS_CongViec_Trong1Ngay(ds_ID_CongViec);
            fg.ClearRows();
            fg.SetDataSource(dt);

            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                int ID_TrangThai = Convert.ToInt32(fg[i, "ID_TrangThai"]);

                if (ID_TrangThai == (int)TrangThai.ChuaThucHien)
                {
                    fg.Rows[i].Style = csChuaThucHien;
                }
                else if (ID_TrangThai == (int)TrangThai.DangThucHien)
                {
                    fg.Rows[i].Style = csDangThucHien;
                }
                else if (ID_TrangThai == (int)TrangThai.Huy)
                {
                    fg.Rows[i].Style = csHuy;
                }
                else if (ID_TrangThai == (int)TrangThai.DaXong)
                {
                    fg.Rows[i].Style = csDaXong;
                }

                if ((fg[i, "DS_Ten_NhanVien"] ?? "").ToString() != "")
                {
                    string[] tenNhanVien = fg[i, "DS_Ten_NhanVien"].ToString().Split(',');
                    fg[i, "DS_Ten_NhanVien"] = "";
                    foreach (var name in tenNhanVien)
                    {
                        fg[i, "DS_Ten_NhanVien"] += name.Trim() + "\n";
                    }
                }

                if ((fg[i, "ThoiGian_DuKien"] ?? "").ToString() != "")
                {
                    fg[i, "ThoiGian_DuKien"] += " " + fg[i, "Ten_ThoiGian"];
                }
            }
            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }
        #endregion Load&Lock

        #region Edit
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //frmCongViec_Old frm = new frmCongViec_Old();
            frmCongViec frm = new frmCongViec();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.IsSaved)
            {
                Loadfg();
                fg.ApplyFilters();
            }
        }

        private void SendDataToFormThongTinCV()
        {
            int ID_CongViec = Convert.ToInt32(fg[fg.Row, "ID_CongViec"]);
            //frmCongViec_Old frm = new frmCongViec_Old(ID_CongViec, true);
            frmCongViec frm = new frmCongViec(ID_CongViec,true);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            if (frm.IsSaved)
            {
                Loadfg();
                fg.ApplyFilters();
            }
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (fg.Row < fg.Rows.Fixed)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn công việc.");
                return;
            }
            SendDataToFormThongTinCV();
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (fg.Row < fg.Rows.Fixed)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn công việc!");
                return;
            }
            if (BaseMessages.ShowDeleteQuestionMessage() == DialogResult.No) return;
            clsCongViec cls = new clsCongViec();
            cls.ID_CongViec = Convert.ToInt32(fg[fg.Row, "ID_CongViec"]);
            cls.TonTai = false;
            cls.Update();

            BaseMessages.ShowInformationMessage("Xóa thành công!");
            Loadfg();
            fg.ApplyFilters();
        }
        #endregion Edit


        private void cbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            bool p = cbShowAll.Checked;
            fg.Cols["Ten_LoaiCV"].Visible = p;
            fg.Cols["Ngay_YeuCau"].Visible = p;
            fg.Cols["ThoiGian_DuKien"].Visible = p;
            fg.AutoSizeRows();
        }

        private void fg_DoubleClick(object sender, EventArgs e)
        {
            if (fg.Row <fg.Rows.Fixed)
            {
                return;
            }
            SendDataToFormThongTinCV();
        }

        private void fg_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            if (cbToggleView.Checked)
            {
                if (e.Row >= fg.Rows.Fixed)
                {
                    //fg.SetCellStyle(e.Row, e.Col, csCellBorder);
                    decimal value;
                    if (fg.Cols[e.Col].Name == "PhanTramHoanThanh")
                    {
                        if (decimal.TryParse((fg[e.Row, e.Col] ?? "").ToString(), out value))
                        {
                            e.Text = e.Text + " %";
                            Rectangle rc = e.Bounds;
                            decimal max = 100;
                            rc.Width = (int)(fg.Cols["PhanTramHoanThanh"].WidthDisplay * value / max);

                            // draw background
                            e.DrawCell(DrawCellFlags.Background | DrawCellFlags.Border);

                            // draw bar
                            if (value < 25)
                            {
                                rc.Inflate(-3, -3);
                                e.Graphics.FillRectangle(Brushes.Firebrick, rc);
                                rc.Inflate(-2, -2);
                                e.Graphics.FillRectangle(Brushes.Crimson, rc);
                            }
                            else if (value >= 25 && value < 50)
                            {
                                rc.Inflate(-3, -3);
                                e.Graphics.FillRectangle(Brushes.MediumTurquoise, rc);
                                rc.Inflate(-2, -2);
                                e.Graphics.FillRectangle(Brushes.DarkTurquoise, rc);
                            }
                            else if (value >= 50 && value < 75)
                            {
                                rc.Inflate(-3, -3);
                                e.Graphics.FillRectangle(Brushes.SandyBrown, rc);
                                rc.Inflate(-2, -2);
                                e.Graphics.FillRectangle(Brushes.Orange, rc);
                            }
                            else if (value >= 75)
                            {
                                rc.Inflate(-3, -3);
                                e.Graphics.FillRectangle(Brushes.LightGreen, rc);
                                rc.Inflate(-2, -2);
                                e.Graphics.FillRectangle(Brushes.LightGreen, rc);
                            }

                            // draw cell content
                            e.DrawCell(DrawCellFlags.Content);
                        }
                    }
                    if (fg.Cols[e.Col].Name == "MoTa" || fg.Cols[e.Col].Name == "DS_Ten_NhanVien")
                    {
                        if (e.Text.Length > 100)
                            e.Text = HelperMethods.TruncateString(e.Text, 100) + " ...";
                    }
                    if (fg.Cols[e.Col].Name == "Ten_TrangThai")
                    {
                        if (e.Text.Trim() == "Chưa thực hiện")
                        {
                            e.Style = csChuaThucHien;
                        }
                        if (e.Text.Trim() == "Đang thực hiện")
                        {
                            e.Style = csDangThucHien;
                        }
                        else if (e.Text.Trim() == "Hủy")
                        {
                            e.Style = csHuy;
                        }
                        else if (e.Text.Trim() == "Đã xong")
                        {
                            e.Style = csDaXong;
                        }
                    }
                    if (fg.Cols[e.Col].Name == "Ten_MucDo")
                    {
                        if (e.Text.Trim() == "Thấp")
                        {
                            e.Style = csMucDoThap;
                        }
                        else if (e.Text.Trim() == "Trung bình")
                        {
                            e.Style = csMucDoTB;
                        }
                        else if (e.Text.Trim() == "Cao")
                        {
                            e.Style = csMucDoCao;
                        }
                    }
                }
            } //end if
            else
            {
                if (e.Row >= fg.Rows.Fixed)
                {
                    //fg.SetCellStyle(e.Row, e.Col, csCellBorder);
                    decimal value;
                    if (fg.Cols[e.Col].Name == "PhanTramHoanThanh")
                    {
                        if (decimal.TryParse((fg[e.Row, e.Col] ?? "").ToString(), out value))
                        {
                            e.Text = e.Text + " %";
                        }
                    }
                    if (fg.Cols[e.Col].Name == "MoTa" || fg.Cols[e.Col].Name == "DS_Ten_NhanVien")
                    {
                        if (e.Text.Length > 100)
                            e.Text = HelperMethods.TruncateString(e.Text, 100) + " ...";
                    }
                    if (fg.Cols[e.Col].Name == "Ten_MucDo")
                    {
                        if (e.Text.Trim() == "Thấp")
                        {
                            e.Style = csMucDoThap;
                        }
                        else if (e.Text.Trim() == "Trung bình")
                        {
                            e.Style = csMucDoTB;
                        }
                        else if (e.Text.Trim() == "Cao")
                        {
                            e.Style = csMucDoCao;
                        }
                    }
                }
            } //end else 
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            fg.ApplyFilters();
        }

        private void cmbNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbNhanVien.Tag + "" != "1") return;
            fg.ApplyFilters();
        }

        private void applySearchFilter()
        {
            var searchString = txtTimKiem.Text.Trim().ToLower();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.Rows[i].IsVisible)
                {
                    if ((fg.GetDataDisplay(i, "MoTa").Trim().ToLower().Contains(searchString))
                        || (fg.GetDataDisplay(i, "Ten_NguoiYeuCau").Trim().ToLower().Contains(searchString)))
                    {

                        fg.Rows[i].Visible = true;
                    }
                    else
                    {
                        fg.Rows[i].Visible = false;
                    }
                }
            }
            fg.SetSTT();
        }

        private void applyNhanVienFilter() 
        {
            List<String> cmbSelectedValues = cmbNhanVien.Properties.GetDisplayText(cmbNhanVien.EditValue)
                                                                   .Split(cmbNhanVien.Properties.SeparatorChar)
                                                                   .Select(item => item.Trim())
                                                                   .ToList();
            List<String> nhanVienNames;
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.Rows[i].IsVisible)
                {
                    nhanVienNames = GetNhanVienNames(i);
                    if (nhanVienNames.Any(item => cmbSelectedValues.Contains(item)))
                    {
                        fg.Rows[i].Visible = true;
                    }
                    else if (nhanVienNames.Count == 0)
                    {
                        fg.Rows[i].Visible = true;
                    }
                    else
                    {
                        fg.Rows[i].Visible = false;
                    }
                }
            }
            fg.SetSTT();
        }

        private List<String> GetNhanVienNames(int fgRow)
        {
            List<String> tenNhanVien = new List<String>();
            if ((fg[fgRow, "DS_Ten_NhanVien"] ?? "").ToString() != "")
            {
                String[] arr = fg[fgRow, "DS_Ten_NhanVien"].ToString().Trim().Split('\n');
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] != "")
                    {
                        tenNhanVien.Add(arr[j]);
                    }
                }
            }
            return tenNhanVien;
        }

        private void fg_AfterFilter(object sender, EventArgs e)
        {
            applySearchFilter();
            applyNhanVienFilter();
            fg.EndUpdate();
        }

        private void cbToggleView_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbToggleView.Checked)
            {
                for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                {
                    int ID_TrangThai = Convert.ToInt32(fg[i, "ID_TrangThai"]);
                    if (ID_TrangThai == (int)TrangThai.ChuaThucHien)
                    {
                        fg.Rows[i].Style = csChuaThucHien;
                    }
                    else if (ID_TrangThai == (int)TrangThai.DangThucHien)
                    {
                        fg.Rows[i].Style = csDangThucHien;
                    }
                    else if (ID_TrangThai == (int)TrangThai.Huy)
                    {
                        fg.Rows[i].Style = csHuy;
                    }
                    else if (ID_TrangThai == (int)TrangThai.DaXong)
                    {
                        fg.Rows[i].Style = csDaXong;
                    }
                }
            }
            else
            {
                for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                {
                    fg.Rows[i].Style = null;
                }
            }
            fg.AutoSizeRows();
        }

        private void fg_BeforeFilter(object sender, CancelEventArgs e)
        {
            fg.BeginUpdate();
        }

        private void fg_MouseEnterCell(object sender, RowColEventArgs e)
        {
            if (e.Row < fg.Rows.Fixed) return;
            if (e.Col == fg.Cols.IndexOf("MoTa") || fg.Cols[e.Col].Name == "DS_Ten_NhanVien")
            {
                if (fg.GetDataDisplay(e.Row, e.Col).Length > 100)
                    toolTipTimer.Start();
            }
        }

        private void fg_MouseLeaveCell(object sender, RowColEventArgs e)
        {
            toolTipNoiDung.RemoveAll();
        }

        private void toolTipTimer_Tick(object sender, EventArgs e)
        {
            toolTipNoiDung.SetToolTip(fg, "Click đúp để xem chi tiết.");
            toolTipTimer.Stop();
        }
    }
}
