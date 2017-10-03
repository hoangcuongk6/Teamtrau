using C1.Win.C1FlexGrid;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmLich : FormBaseGarco10
    {
        public frmLich(int id_nhanSu)
        {
            InitializeComponent();
            id_NhanVien_DangNhap = id_nhanSu;
        }

        private string ds_LoaiCV = "";
        private CellStyle csNghi, csNgayThuong, csNgayHomNay, csCongViec, csDenHan, csHop, csCongTac, csBorder;
        private int id_NhanVien_DangNhap;
        private int[] cell_IDLich;
        private int cheDoXem;
        private DateTime lastDayCalendar, firstDayCalendar, dtNow;
        private int width, height;
        private int[] DanhSachSoCongViecMoiNgay = new int[42];
        private string[] ds_IDCongViec_MoiNgay = new string[42];

        private void frmLich_Load(object sender, EventArgs e)
        {
            height = (Screen.PrimaryScreen.WorkingArea.Height - 300);
            width = (Screen.PrimaryScreen.WorkingArea.Width - 400) / 7;
            dtNow = DateTime.Now;
            cheDoXem = 3;
            fg.Cols[0].Caption = "Chủ nhật";
            fg.Cols[0].Width = width;

            fg.Cols[0].Style = csNghi;
            for (int c = 0; c < 6; ++c)
            {
                C1.Win.C1FlexGrid.Column col = fg.Cols.Add();
                col.Width = width;
                col.Caption = "Thứ " + (c + 2);
                col.Name = c.ToString();
            }
            fg.Styles.Normal.ImageAlign = ImageAlignEnum.Stretch;
            LoadCombobox();
            LoadView(cheDoXem);
        }

        private void LoadView(int cheDo)
        {
            InstalCsStyle();

            fg.BeginUpdate();

            fg.ClearRows();
            if (cheDo == 1)
            {
            }
            if (cheDo == 2)
            {
                fg.Cols[1].Caption = "Chủ nhật";
                fg.Cols[1].Width = 205;
                fg.Cols[1].Style = csNghi;
                for (int c = 0; c < 7; ++c)
                {
                    C1.Win.C1FlexGrid.Column col = fg.Cols.Add();
                    col.Width = 200;
                    col.Caption = "Thứ " + (c + 2);
                    col.Name = c.ToString();
                }
                for (int r = 1; r <= 30; ++r)
                {
                    C1.Win.C1FlexGrid.Row row = fg.Rows.Add();
                    for (int c = fg.Cols.Fixed; c < fg.Cols.Count; ++c)
                    {
                        if (r % 6 == 0)
                        {
                            this.fg.SetCellStyle(r, c, "b");
                        }
                    }
                }
                for (int c = fg.Cols.Fixed + 1; c < fg.Cols.Count; ++c)
                {
                    fg.Cols[c].Style = csNgayThuong;
                }
                fg.Cols[fg.Cols.Fixed].Style = csNghi;
                DateTime d = firstDayCalendar;
                for (int r = fg.Rows.Fixed; r < fg.Rows.Count; r += 6)
                {
                    for (int c = fg.Cols.Fixed; c < fg.Cols.Count; ++c)
                    {
                        if (d.Day == 1)
                        {
                            fg[r, c] = d.Day + " tháng " + d.Month;
                        }
                        else
                        {
                            fg[r, c] = d.Day;
                        }
                        d = d.AddDays(1);
                    }
                }
            }
            if (cheDo == 3)
            {
                DateTime date = monthCalendar.SelectionRange.Start;
                int totalCalendarDays = 42; // matrix 7 x 5

                // set the first month day
                DateTime firstDayMonth = new DateTime(date.Year, date.Month, 1);

                // set the lastmonth day
                DateTime lastDayMonth = new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));

                // now get the first day week of the first day month (0-6 Sun-Sat)
                byte firstDayWeek = (byte)firstDayMonth.DayOfWeek;

                // now get the first day week of the last day month (0-6 Sun-Sat)
                byte lastDayWeek = (byte)lastDayMonth.DayOfWeek;

                // now the first day show in calendar is the first day month minus the days to 0 (sunday)
                firstDayCalendar = firstDayMonth.Subtract(TimeSpan.FromDays(firstDayWeek));
                int tempDays = (lastDayMonth - firstDayCalendar).Days;

                lastDayCalendar = lastDayMonth.Add(TimeSpan.FromDays(totalCalendarDays - tempDays - 1));

                for (int r = 1; r <= 36; ++r)
                {
                    C1.Win.C1FlexGrid.Row row = fg.Rows.Add();
                    for (int c = fg.Cols.Fixed; c < fg.Cols.Count; ++c)
                    {
                        if (r % 6 == 0)
                        {
                            this.fg.SetCellStyle(r, c, "b");
                        }
                    }
                }
                for (int c = fg.Cols.Fixed + 1; c < fg.Cols.Count; ++c)
                {
                    fg.Cols[c].Style = csNgayThuong;
                }
                DateTime d = firstDayCalendar;
                clsCongViec cls = new clsCongViec();
                DataTable dt_DsNgayNghi = cls.DS_NgayNghi(firstDayCalendar, lastDayCalendar);

                for (int r = fg.Rows.Fixed; r < fg.Rows.Count; r += 6)
                {
                    for (int c = fg.Cols.Fixed; c < fg.Cols.Count; ++c)
                    {
                        if (d.Day == 1)
                        {
                            fg[r, c] = d.Day + "/" + d.Month;
                        }
                        else
                        {
                            fg[r, c] = d.Day + "/" + d.Month;
                        }
                        if (d.Date == dtNow.Date)
                        {
                            for (int i = 0; i < 1; ++i)
                            {
                                CellRange range = fg.GetCellRange(r + i, c);
                                range.Style = csNgayHomNay;
                            }
                        }
                        if (Trong_DsNgayNghi(dt_DsNgayNghi, d))
                        {
                            for (int i = 0; i < 1; ++i)
                            {
                                CellRange range = fg.GetCellRange(r + i, c);
                                range.Style = csNghi;
                            }
                        }
                        d = d.AddDays(1);
                    }
                }

                LoadCalendar(cheDo, firstDayCalendar);

                fg.AllowMerging = AllowMergingEnum.Custom;
                for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                {
                    fg.Rows[i].AllowMerging = true;
                }
            }

            fg.EndUpdate();
            fg.AllowMerging = AllowMergingEnum.Free;
        }

        private bool Trong_DsNgayNghi(DataTable dt, DateTime date)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (((DateTime)dr["Ngay"]).Date == date.Date) return true;
            }
            return false;
        }

        private void LoadCalendar(int cheDo, DateTime ngayBatDau)
        {
            if (cheDo == 1)
            {
            }
            if (cheDo == 2)
            {
            }
            if (cheDo == 3)
            {
                cell_IDLich = new int[252];
                DateTime ngayCuoi = ngayBatDau.AddDays(35);
                clsCongViec cls = new clsCongViec();
                DataTable dt_Lich = cls.CongViec_Lich(ngayBatDau, ngayCuoi, id_NhanVien_DangNhap, ds_LoaiCV);
                //
                TinhSoCongViecTrongMoiNgay(dt_Lich);
                foreach (DataRow dr in dt_Lich.Rows)
                {
                    DateTime thoiGian_BatDau, thoiGian_KetThuc;
                    if (dr["Ngay_DenHan"].ToString() == "")
                    {
                        thoiGian_KetThuc = lastDayCalendar;
                    }
                    else
                    {
                        thoiGian_KetThuc = (DateTime)(dr["Ngay_DenHan"]);
                    }
                    if (dr["Ngay_YeuCau"].ToString() != "")
                    {
                        thoiGian_BatDau = (DateTime)(dr["Ngay_YeuCau"]);
                    }
                    else
                    {
                        thoiGian_BatDau = firstDayCalendar;
                    }
                    if (thoiGian_BatDau > thoiGian_KetThuc)
                    {
                        thoiGian_KetThuc = dtNow;
                    }
                    if (thoiGian_BatDau.Date > lastDayCalendar.Date || thoiGian_KetThuc.Date < firstDayCalendar.Date) continue;
                    if (thoiGian_BatDau < firstDayCalendar) thoiGian_BatDau = firstDayCalendar;
                    while ((thoiGian_BatDau) <= thoiGian_KetThuc)
                    {
                        if (thoiGian_BatDau.Date < firstDayCalendar || thoiGian_BatDau.Date > lastDayCalendar)
                        {
                            thoiGian_BatDau = thoiGian_BatDau.AddDays(1);
                            continue;
                        }
                        if (dr["DS_Thu"].ToString() == "" && dr["DS_Ngay"].ToString() == "" && dr["DS_Thang"].ToString() == "")
                        { }
                        else
                        {
                            if (!TrongDSNgay(dr["DS_Thu"].ToString(), dr["DS_Ngay"].ToString(), dr["DS_Thang"].ToString(), thoiGian_BatDau))
                            {
                                thoiGian_BatDau = thoiGian_BatDau.AddDays(1);
                                continue;
                            }
                        }
                        if (dr["ID_TrangThai"].ToString() == "3" || dr["ID_TrangThai"].ToString() == "4")
                        {
                            thoiGian_BatDau = thoiGian_BatDau.AddDays(1);
                            continue;
                        }
                        int[] rc = DateToInt(thoiGian_BatDau);
                        bool thoaManHienThiThanhMotHangNgang = true;
                        int r = rc[0];
                        int soNgayCuaCongViecTrongHang = 0;
                        int soNgay = (int)(thoiGian_KetThuc - thoiGian_BatDau).TotalDays;
                        for (r = rc[0] + 1; r <= rc[0] + 5; ++r)
                        {
                            thoaManHienThiThanhMotHangNgang = true;
                            int c = rc[1];
                            while (c <= (rc[1] + soNgay) && c < fg.Cols.Count)
                            {
                                if (fg.GetDataDisplay(r, c) != "")
                                {
                                    thoaManHienThiThanhMotHangNgang = false;
                                    break;
                                }
                                ++c;
                            }
                            if (thoaManHienThiThanhMotHangNgang && (c == (rc[1] + soNgay + 1) || c == fg.Cols.Count))
                            {
                                soNgayCuaCongViecTrongHang = c - rc[1];
                                break;
                            }
                        }
                        if (r <= rc[0] + 5)
                        {
                            DateTime d;
                            for (d = thoiGian_BatDau.Date; d <= thoiGian_BatDau.Date.AddDays(soNgayCuaCongViecTrongHang - 1); d = d.AddDays(1))
                            {
                                //
                                if (dr["DS_Thu"].ToString() == "" && dr["DS_Ngay"].ToString() == "" && dr["DS_Thang"].ToString() == "")
                                { }
                                else
                                {
                                    if (!TrongDSNgay(dr["DS_Thu"].ToString(), dr["DS_Ngay"].ToString(), dr["DS_Thang"].ToString(), d))
                                    {
                                        //thoiGian_BatDau = thoiGian_BatDau.AddDays(1);
                                        continue;
                                    }
                                }
                                //
                                int[] row_col = DateToInt(d);
                                int index = (r - 1) * 7 + row_col[1];
                                cell_IDLich[index] = int.Parse(dr["ID_CongViec"].ToString());

                                fg[r, row_col[1]] = dr["TieuDe"];
                                string[] loaiCV_Array = ds_LoaiCV.Split(',');
                                if (dr["ID_LoaiCV"].ToString() == "1")
                                {
                                    CellRange range = fg.GetCellRange(r, row_col[1]);
                                    range.Style = csHop;
                                    //fg.SetCellImage(r, row_col[1], ProjectManagements.Properties.Resources.ico_Blue_Rec_img);
                                }
                                if (dr["ID_LoaiCV"].ToString() == "2")
                                {
                                    CellRange range = fg.GetCellRange(r, row_col[1]);
                                    range.Style = csCongTac;
                                    //fg.SetCellImage(r, row_col[1], ProjectManagements.Properties.Resources.ico_Purple_Rec_img);
                                }
                                if (dr["ID_LoaiCV"].ToString() != "2" && dr["ID_LoaiCV"].ToString() != "1")
                                {
                                    CellRange range = fg.GetCellRange(r, row_col[1]);
                                    range.Style = csCongViec;
                                    //fg.SetCellImage(r, row_col[1], ProjectManagements.Properties.Resources.ico_Purple_Rec_img);
                                }
                                //
                            }
                            thoiGian_BatDau = d;
                            continue;
                        }
                        thoiGian_BatDau = thoiGian_BatDau.AddDays(1);
                    }
                }
            }
        }

        private bool TrongDSThu(string dsThu, DateTime date)
        {
            string[] thuArray = dsThu.Split(',');
            for (int i = 0; i < thuArray.Length; ++i)
            {
                int thu = (int)date.DayOfWeek + 1;
                if (thu == 1) thu = 8;
                if (thu.ToString() == thuArray[i].ToString()) return true;
            }
            return false;
        }

        private bool TrongDSNgay(string dsThu, string dsNgay, string dsThang, DateTime date)
        {
            if (dsThu != "") return TrongDSThu(dsThu, date);
            string[] ngay_Array = dsNgay.Split(',');
            string[] thang_Array = dsThang.Split(',');
            int length = ngay_Array.Length;
            if (thang_Array.Length != 1) length = length * thang_Array.Length;
            DateTime[] date_Array = new DateTime[length];
            //if (thang_Array.Length != 0)
            //{
            for (int n = 0; n < ngay_Array.Length; ++n)
            {
                for (int t = 0; t < thang_Array.Length; ++t)
                {
                    if (date.Day.ToString() == ngay_Array[n] && (date.Month.ToString() == thang_Array[t] || thang_Array[t] == "")) return true;
                }
            }
            //}
            //else
            //{
            //    for (int i = 0; i < length; ++i)
            //    {
            //        if (date.Day.ToString() == ngay_Array[i])
            //        {
            //            return true;
            //        }
            //    }
            //}
            return false;
        }

        public DateTime FirstDay(DateTime Date)
        {
            var date = new DateTime(Date.Year, Date.Month, 1);
            while (true)
            {
                if (date.DayOfWeek == DayOfWeek.Monday)
                    return date;
                date = date.AddDays(-1);
            }
            return date;
        }

        public DateTime LastDay(DateTime Date)
        {
            var date = new DateTime(Date.Year, Date.Month,
                                    DateTime.DaysInMonth(Date.Year, Date.Month));
            while (true)
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                    return date;
                date = date.AddDays(1);
            }
            return date;
        }

        public void InstalCsStyle()
        {
            csBorder = this.fg.Styles.Add("b");
            csBorder.Border.Style = C1.Win.C1FlexGrid.BorderStyleEnum.Flat;
            csBorder.Border.Direction = C1.Win.C1FlexGrid.BorderDirEnum.Horizontal;
            csBorder.Border.Color = Color.Black;
            csBorder.Border.Width = 1;
            //
            csNghi = this.fg.Styles.Add("ChuNhat");
            csNghi.BackColor = Color.Yellow;
            csNghi.TextAlign = TextAlignEnum.LeftCenter;
            csNghi.Border.Color = Color.Yellow;
            //
            csNgayThuong = this.fg.Styles.Add("NgayThuong");
            csNgayThuong.TextAlign = TextAlignEnum.LeftCenter;
            //
            csNgayHomNay = this.fg.Styles.Add("Hom nay");
            csNgayHomNay.TextAlign = TextAlignEnum.LeftCenter;
            csNgayHomNay.BackColor = Color.Wheat;
            csNgayHomNay.Border.Color = Color.Wheat;
            //
            csCongViec = this.fg.Styles.Add("Hien Thi Viec");
            csCongViec.TextAlign = TextAlignEnum.LeftCenter;
            csCongViec.BackColor = Color.Blue;
            csCongViec.ForeColor = Color.White;
            //
            csDenHan = this.fg.Styles.Add("Den Han");
            csDenHan.TextAlign = TextAlignEnum.LeftCenter;
            csDenHan.BackColor = Color.Red;

            //
            csHop = this.fg.Styles.Add("Họp");
            csHop.TextAlign = TextAlignEnum.LeftCenter;
            csHop.BackColor = Color.Lime;
            //
            csCongTac = this.fg.Styles.Add("Công tác");
            csCongTac.TextAlign = TextAlignEnum.LeftCenter;
            csCongTac.BackColor = Color.DarkCyan;
        }

        public int[] DateToInt(DateTime d)
        {
            // if (d.Date < firstDayCalendar || d.Date > lastDayCalendar) return null;
            int soNgay = (int)(d.Date - firstDayCalendar.Date).TotalDays;
            int[] rc = new int[2];
            rc[1] = soNgay % 7;
            rc[0] = (soNgay / 7) * 6 + 1;
            return rc;
        }

        public DateTime IntToDate(int r, int c)
        {
            int soNgay = ((r - 1) / 6) * 7 + c;
            return firstDayCalendar.AddDays(soNgay);
        }

        private void fg_OwnerDrawCell_1(object sender, OwnerDrawCellEventArgs e)
        {
            fg.DrawMode = C1.Win.C1FlexGrid.DrawModeEnum.OwnerDraw;
            e.DrawCell();
            var rc = e.Bounds;
            //e.Graphics.DrawLine(Pens.Black, rc.Right - 1, rc.Top, rc.Right - 1, rc.Bottom);
            e.Graphics.DrawLine(Pens.Black, rc.Right - 1, rc.Top - 1, rc.Right - 1, rc.Bottom - 1);
        }

        private void fg_DoubleClick(object sender, EventArgs e)
        {
            if (fg.Row < fg.Rows.Fixed || fg.Row >= fg.Rows.Count) return;
            int id_CongViec = 0;
            DateTime dt = IntToDate(fg.Row, fg.Col);
            if (fg.GetDataDisplay(fg.Row, fg.Col) != "")
            {
                if (fg.GetDataDisplay(fg.Row, fg.Col) == "More" || fg.Row % 6 == 1)
                {
                    int index = ((fg.Row - 1) / 6) * 7 + fg.Col;
                    frmDS_CongViec frm = new frmDS_CongViec(ds_IDCongViec_MoiNgay[index], dt);
                    frm.ShowDialog();
                }
                else
                {
                    int index = (fg.Row - 1) * 7 + fg.Col;
                    id_CongViec = cell_IDLich[index];
                    SendDataToFormThongTinCV(id_CongViec, false, dt);
                }
            }
            else
            {
                SendDataToFormThongTinCV(id_CongViec, true, dt);
            }
            LoadView(3);
        }

        private void SendDataToFormThongTinCV(int id_CongViec, bool isThemMoi, DateTime dt)
        {
            if (isThemMoi)
            {
                //frmCongViec_Old frm = new frmCongViec_Old(id_CongViec,id_NhanVien_DangNhap, dt);
                frmCongViec frm = new frmCongViec(id_CongViec, id_NhanVien_DangNhap, dt);
                frm.ShowDialog();
            }
            else
            {
                //frmCongViec_Old frm = new frmCongViec_Old(id_CongViec, true);
                frmCongViec frm = new frmCongViec(id_CongViec, true);
                frm.ShowDialog();
            }
            LoadView(3);
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (firstDayCalendar.Date != FirstDay(monthCalendar.SelectionRange.Start.Date))
            {
                LoadView(3);
            }
        }

        private void btnHomNay_Click(object sender, EventArgs e)
        {
            monthCalendar.SelectionStart = (dtNow);
            monthCalendar.SelectionEnd = (dtNow);
        }

        private void LoadCombobox()
        {
            var cmb = cmbLoaiCV;
            cmb.Tag = 0;
            clsDM_LoaiCV cls = new clsDM_LoaiCV();
            DataTable dt = cls.SelectAll();
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_LoaiCV";
            cmb.Properties.ValueMember = "ID_LoaiCV";

            List<String> editValues = new List<String>();
            foreach (DataRow dr in dt.Rows)
            {
                editValues.Add(dr["ID_LoaiCV"].ToString());
            }
            string s = String.Join(",", editValues.ToArray());
            cmb.SetEditValue(s);
            cmb.Tag = 1;
        }

        private void cmbLoaiCV_EditValueChanged(object sender, EventArgs e)
        {
            ds_LoaiCV = cmbLoaiCV.Properties.GetCheckedItems().ToString();
            LoadView(cheDoXem);
        }

        private void cmbLoaiCV_EditValueChanged_1(object sender, EventArgs e)
        {
            if (cmbLoaiCV.Tag + "" == "0") return;
            ds_LoaiCV = cmbLoaiCV.Properties.GetCheckedItems().ToString();
            LoadView(cheDoXem);
        }

        private void ucTextBox1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void btnHomNay_Click_1(object sender, EventArgs e)
        {
        }

        private void TinhSoCongViecTrongMoiNgay(DataTable dt_lich)
        {
            for (int i = 0; i < DanhSachSoCongViecMoiNgay.Length; ++i)
            {
                DateTime d = firstDayCalendar.AddDays(i);
                int soCongViec = 0;
                for (int row = 0; row < dt_lich.Rows.Count; ++row)
                {
                    string dsThu = dt_lich.Rows[row]["DS_Thu"].ToString();
                    string dsNgay = dt_lich.Rows[row]["DS_Ngay"].ToString();
                    string dsThang = dt_lich.Rows[row]["DS_Thang"].ToString();
                    int id_CongViec = int.Parse(dt_lich.Rows[row]["ID_CongViec"].ToString());
                    if (dsThu == "" && dsNgay == "" && dsThang == "")
                    {
                        DateTime ngay_YeuCau, ngay_DenHan;
                        if (dt_lich.Rows[row]["Ngay_YeuCau"].ToString() != "")
                        {
                            ngay_YeuCau = DateTime.Parse(dt_lich.Rows[row]["Ngay_YeuCau"].ToString());
                        }
                        else
                        {
                            ngay_YeuCau = firstDayCalendar;
                        }
                        if (dt_lich.Rows[row]["Ngay_DenHan"].ToString() != "")
                        {
                            ngay_DenHan = DateTime.Parse(dt_lich.Rows[row]["Ngay_DenHan"].ToString());
                        }
                        else
                        {
                            ngay_DenHan = lastDayCalendar;
                        }
                        if (d.Date >= ngay_YeuCau.Date && d.Date <= ngay_DenHan.Date)
                        {
                            ++soCongViec;
                            ds_IDCongViec_MoiNgay[i] += id_CongViec.ToString() + ",";
                        }
                    }
                    else
                    {
                        if (TrongDSNgay(dsThu, dsNgay, dsThang, d))
                        {
                            ++soCongViec;
                            ds_IDCongViec_MoiNgay[i] += id_CongViec.ToString() + ",";
                        }
                    }
                }
                DanhSachSoCongViecMoiNgay[i] = soCongViec;
            }
            //hien thi tren lich
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; r += 6)
            {
                for (int c = fg.Cols.Fixed; c < fg.Cols.Count; ++c)
                {
                    int index = ((r - 1) / 6) * 7 + c;
                    if (DanhSachSoCongViecMoiNgay[index].ToString() != "0")
                        fg[r, c] += "  : (có " + DanhSachSoCongViecMoiNgay[index].ToString() + " việc)";
                }
            }
        }
    }
}