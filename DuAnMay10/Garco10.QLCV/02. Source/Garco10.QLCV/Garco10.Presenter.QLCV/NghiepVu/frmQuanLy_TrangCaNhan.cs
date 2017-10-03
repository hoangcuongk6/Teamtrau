using C1.Win.C1FlexGrid;
using Garco10.SystemModule.Forms;
using Garco10.SystemModule.HeThong;
using M10_QLCV;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using VSCM.Base.Utils;
using DevExpress.XtraEditors.Controls;
using Garco10.Presenter.QLCV.DanhMuc;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmQuanLy_TrangCaNhan : FormBaseGarco10
    {
        public frmQuanLy_TrangCaNhan(int m_iID_TaiKhoanDangNhap)
        {
            InitializeComponent();
            this.m_iID_TaiKhoanDangNhap = m_iID_TaiKhoanDangNhap;
            m_sds_NhanVien = m_iID_TaiKhoanDangNhap.ToString();
            //if (m_sds_NhanVien == "5400" || m_sds_NhanVien == "5409") cmbNhanVien.Enabled = false;
            InitCellStyles();
        }

        private CellStyle cs,
            csChoXuLy,
            csDaNhan,
            csDangLam,
            csHuy,
            csDaXong,
            csMucDoThap,
            csMucDoTB,
            csMucDoCao,
            csQuaHan,
            csNow,
            csChuNhat,
            csLoaiCV,
            csChuaDocComment,
            csChuaDocComment_QuaHan,
            csCongViecCaNhan,
            csQuaHan_CaNhan;

        private string m_sds_NhanVien = "",
            m_sds_LoaiCV = "",
            m_sds_TrangThai = "",
            m_sds_MucDoUuTien = "",
            m_sds_NguoiYeuCau = "";

        private DateTime m_dtD1, m_dtD2, m_dtDtNow;
        private DataTable dt, dt_NhanSu;
        private int m_irowDateOfTimeline = 24;
        private int m_iID_TaiKhoanDangNhap;
        private bool m_bIsLoadForm = true;
        private frmCongViec m_fFrmCv;
        private int m_iID_DonVi;
        private int m_iSelectedRow;
        private int m_iIDLoaiCV;

        //private void frmQuanLyTienDo_Load(object sender, EventArgs e)
        //{
        //    LoadCombobox();
        //    m_bIsLoadForm = true;
        //    //m_dtDtNow = GlobalVariables.GetCurrentDateTime();
        //    m_dtDtNow = DateTime.Now;
        //    m_dtD1 = new DateTime(m_dtDtNow.Year, m_dtDtNow.Month, 1);
        //    dteNgayBatDau.Value = m_dtD1;
        //    m_dtD2 = new DateTime(m_dtDtNow.Year, m_dtDtNow.Month,
        //        DateTime.DaysInMonth(m_dtDtNow.Year, m_dtDtNow.Month));

        //    dteNgayKetThuc.Value = m_dtD2;

        //    fg.SelectionMode = SelectionModeEnum.ListBox;
        //    fg.Styles["Focus"].BackColor = fg.Styles["Highlight"].BackColor;
        //    fg.Styles.Normal.ImageAlign = ImageAlignEnum.Stretch;
        //    LoadData();
        //    chkHienThiKhiCoCV.Checked = true;
        //    m_bIsLoadForm = false;
        //    AutoAlignScreen();
        //}

        protected override void OnLoad(EventArgs e)
        {
            this.Opacity = 0;
            m_bIsLoadForm = true;
            LoadCombobox();
            m_dtDtNow = DateTime.Now;
            m_dtD1 = new DateTime(m_dtDtNow.Year, m_dtDtNow.Month, 1);
            dteNgayBatDau.Value = m_dtD1;
            m_dtD2 = new DateTime(m_dtDtNow.Year, m_dtDtNow.Month,
                DateTime.DaysInMonth(m_dtDtNow.Year, m_dtDtNow.Month));

            dteNgayKetThuc.Value = m_dtD2;

            fg.SelectionMode = SelectionModeEnum.ListBox;
            fg.Styles["Focus"].BackColor = fg.Styles["Highlight"].BackColor;
            fg.Styles.Normal.ImageAlign = ImageAlignEnum.Stretch;
            LoadData();
            chkHienThiKhiCoCV.Checked = true;
            base.OnLoad(e);
            m_bIsLoadForm = false;
            AutoAlignScreen();
            this.Opacity = 1;
        }

        private void SetSTT()
        {
            bool trangThai = true;
            int level = 0;
            // fg.Rows[fg.Rows.Fixed]["STT"] = 1;
            while (trangThai)
            {
                int stt = 1;
                trangThai = false;
                for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                {
                    if (fg.Rows[i].Node.Level == level && fg.Rows[i].Visible)
                    {
                        string sttCha = "";
                        for (int j = i - 1; j >= fg.Rows.Fixed; --j)
                        {
                            if (fg.Rows[j].Node.Level < fg.Rows[i].Node.Level)
                            {
                                sttCha = fg.Rows[j]["STT"].ToString() + ".";
                                break;
                            }
                        }
                        if (i != fg.Rows.Fixed && fg.Rows[i].Node.Level > fg.Rows[i - 1].Node.Level) stt = 1;
                        fg.Rows[i]["STT"] = sttCha + stt;
                        ++stt;
                        trangThai = true;
                        if (i != fg.Rows.Count - 1 && fg.Rows[i].Node.Level > fg.Rows[i + 1].Node.Level) stt = 1;
                    }
                }
                ++level;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            SendDataToFormThongTinCV(true);
        }

        public void LoadData()
        {
            fg.Tag = 0;
            //m_iSelectedRow = fg.Row;
            for (int i = 2; i < cmbTuyChonHienThi.Properties.Items.Count; i++)
            {
                if (cmbTuyChonHienThi.Properties.Items[i].CheckState == CheckState.Checked)
                {
                    string nameCol = cmbTuyChonHienThi.Properties.Items[i].Value.ToString();
                    fg.Cols[nameCol].Visible = true;
                }
                else
                {
                    string nameCol = cmbTuyChonHienThi.Properties.Items[i].Value.ToString();
                    fg.Cols[nameCol].Visible = false;
                }
            }
            m_irowDateOfTimeline = 30;
            fg.Cols.RemoveRange(m_irowDateOfTimeline, (fg.Cols.Count - m_irowDateOfTimeline));
            m_dtD1 = (DateTime) dteNgayBatDau.Value;
            m_dtD2 = (DateTime) dteNgayKetThuc.Value;
            if (m_dtD1.Date > m_dtD2.Date)
            {
                BaseMessages.ShowWarningMessage("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                return;
            }
            if ((int) (m_dtD2.Date - m_dtD1.Date).TotalDays > 365)
            {
                BaseMessages.ShowWarningMessage("Khoảng thời gian quá dài");
                return;
            }
            //
            clsCongViec cls = new clsCongViec();
            dt = new DataTable();
            dt = cls.CongViec_SelecAll_List_IDNhanVien_IDTrangThai(m_dtD1, m_dtD2, m_sds_NhanVien, m_sds_TrangThai,
                m_sds_LoaiCV, m_sds_MucDoUuTien, m_sds_NguoiYeuCau);

            //
            fg.BeginUpdate();
            fg.ClearRows();
            clsDM_LoaiCV cls_LoaiCV = new clsDM_LoaiCV();
            //DataTable dt_LoaiCV = cls_LoaiCV.SelectAll(); // Lay tat ca loai cong viec
            DataTable dt_LoaiCV = new DataTable();
            cls_LoaiCV.ID_DonVi = GlobalVariables.uID_DonVi; // lay don vi cua nguoi dang nhap
            dt_LoaiCV = cls_LoaiCV.SelectAll_TheoDonVi(); // Lay tat ca loai cong viec theo don vi
            foreach (DataRow dr in dt_LoaiCV.Rows)
            {
                Row fgRow = fg.Rows.Add();

                fgRow["ID_CongViec"] = "-" + dr["ID_LoaiCV"];
                fgRow["TieuDe"] = dr["Ten_LoaiCV"];
                fgRow["ID_LoaiCV"] = dr["ID_LoaiCV"];
                if (dr["ID_LoaiCV_Cha"].ToString() == "")
                {
                }
                else
                {
                    fgRow["ID_CongViec_Goc"] = "-" + dr["ID_LoaiCV_Cha"];
                }
            }
            decimal giaTri = 0;
            foreach (DataRow dr in dt.Rows)
            {
                DateTime d = m_dtD1;
                if (fg.Rows.Count > 1)
                {
                    if (fg.GetDataDisplay(fg.Rows.Count - 1, "Ma_CongViec").ToString() ==
                        dr["Ma_CongViec"].ToString() &&
                        fg.GetDataDisplay(fg.Rows.Count - 1, "Ma_CongViec").ToString() != "")
                    {
                        decimal giaTri_Sau = 0;
                        decimal.TryParse(dr["GiaTri"].ToString(), out giaTri_Sau);
                        giaTri = giaTri + giaTri_Sau;
                        fg.Rows[fg.Rows.Count - 1]["GiaTri"] = giaTri;
                        continue;
                    }
                    decimal.TryParse(dr["GiaTri"].ToString(), out giaTri);
                }

                Row fgRow = fg.Rows.Add();
                //


                fgRow["ID_CongViec"] = dr["ID_CongViec"];
                fgRow["Ma_CongViec"] = dr["Ma_CongViec"];
                fgRow["GiaTri"] = giaTri;

                fgRow["DS_ID_NhanVien"] = dr["DS_ID_NhanVien"];
                fgRow["ID_MucDoUuTien"] = dr["ID_MucDoUuTien"];
                fgRow["TieuDe"] = dr["TieuDe"];
                fgRow["MoTa"] = dr["MoTa"];
                fgRow["Ngay_YeuCau"] = dr["Ngay_YeuCau"];
                fgRow["Ngay_DenHan"] = dr["Ngay_DenHan"];
                fgRow["ThoiGian_DuKien"] = dr["ThoiGian_DuKien"];
                fgRow["ID_ThoiGian"] = dr["ID_ThoiGian"];
                if (dr["PhanTramHoanThanh"].ToString() == "") dr["PhanTramHoanThanh"] = 0;
                fgRow["PhanTramHoanThanh"] = dr["PhanTramHoanThanh"] + " %";
                fgRow["Ngay_BatDau"] = dr["Ngay_BatDau"];
                fgRow["ID_TrangThai"] = dr["ID_TrangThai"];
                fgRow["ID_LoaiCV"] = dr["ID_LoaiCV"];
                fgRow["ID_CongViec_Goc"] = dr["ID_CongViec_Goc"];
                fgRow["Ngay_HoanThanh"] = dr["Ngay_HoanThanh"];
                fgRow["Ngay_Lap"] = dr["Ngay_Lap"];
                fgRow["ID_NguoiLap"] = dr["ID_NguoiLap"];
                fgRow["Ngay_SuaCuoi"] = dr["Ngay_SuaCuoi"];
                fgRow["ID_NguoiSuaCuoi"] = dr["ID_NguoiSuaCuoi"];
                fgRow["ID_NguoiYeuCau"] = dr["ID_NguoiYeuCau"];
                fgRow["Ten_TrangThai"] = dr["Ten_TrangThai"];
                fgRow["Ten_MucDo"] = dr["Ten_MucDo"];
                fgRow["ID_NGuoiYeuCau"] = dr["ID_NGuoiYeuCau"];

                fgRow["Ten_KetQua_DonVi"] = dr["Ten_KetQua_DonVi"];
                fgRow["SoLuong_KeHoach"] = dr["SoLuong_KeHoach"];

                for (int j = 0; j < dt_NhanSu.Rows.Count; ++j)
                {
                    if (dr["ID_NGuoiYeuCau"].ToString() == dt_NhanSu.Rows[j]["ID_NhanSu"].ToString().Trim())
                    {
                        fgRow["NGuoi_YeuCau"] = dt_NhanSu.Rows[j]["HoTen"].ToString().Trim();
                    }
                }
                //Lấy tên nhân viên
                string ds_Ten_NhanVien = "";
                string[] ds_ID_NhanVien = dr["DS_ID_NhanVien"].ToString().Split(',');
                if (ds_ID_NhanVien.Length > 1)
                {
                    for (int i = 0; i < ds_ID_NhanVien.Length; ++i)
                    {
                        foreach (DataRow drNV in dt_NhanSu.Select("ID_NhanSu = " + ds_ID_NhanVien[i].Trim()))
                        {
                            ds_Ten_NhanVien += drNV["HoTen"].ToString().Trim() + ", ";
                            break;
                        }
                    }
                }


                if (ds_Ten_NhanVien.Length > 2)
                    fgRow["ds_NhanVien"] = ds_Ten_NhanVien.Remove(ds_Ten_NhanVien.Length - 2, 1); // Xoa  2 ky tu o cuoi
            }
            //insert loaiCV

            //Add ID_COngViec_Goc bằng ID_LoaiCV
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (fg.GetDataDisplay(r, "ID_CongViec_Goc").ToString() == "" &&
                    int.Parse(fg.GetDataDisplay(r, "ID_CongViec").ToString()) > 0)
                {
                    if (fg.GetDataDisplay(r, "ID_LoaiCV").ToString() == "")
                    {
                    }
                    else
                    {
                        fg.Rows[r]["ID_CongViec_Goc"] = "-" + fg.Rows[r]["ID_LoaiCV"];
                    }
                }
            }
            //Add Node công việc con
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                fg.Rows[r].Visible = false;
                fg.Rows.InsertNode(r + 1, 0);
                GetDataTwoRow(r + 1, r);
                ++r;
            }
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; r++)
            {
                if (!fg.Rows[r].Visible)
                {
                    fg.Rows.Remove(r);
                    r = r - 1;
                }
            }
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (fg.Rows[r].Node.Level == 0 && fg.Rows[r].Visible && IsNode0(r))
                    r = TimCongViecGoc(r, 1);
            }
            int level = 1;
            while (TonTaiCongViecGoc(level))
            {
                for (int r1 = fg.Rows.Fixed; r1 < fg.Rows.Count; ++r1)
                {
                    if (fg.Rows[r1].Node.Level == level && fg.Rows[r1].Visible)
                        r1 = TimCongViecGoc(r1, level + 1);
                }
                ++level;
            }
            fg.Tree.Column = 1;
            //Add STT

            ////////
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                int trangThaiRow = 11;
                if (fg.GetDataDisplay(r, "ID_MucDoUuTien").ToString().Trim() == "3")
                {
                    CellRange rg = fg.GetCellRange(r, trangThaiRow);
                    rg.Style = csMucDoCao;
                }
                if (fg.GetDataDisplay(r, "ID_MucDoUuTien").ToString().Trim() == "2")
                {
                    CellRange rg = fg.GetCellRange(r, trangThaiRow);
                    rg.Style = csMucDoTB;
                }
                if (fg.GetDataDisplay(r, "ID_MucDoUuTien").ToString().Trim() == "1")
                {
                    CellRange rg = fg.GetCellRange(r, trangThaiRow);
                    rg.Style = csMucDoThap;
                }
                if (fg.GetDataDisplay(r, "ID_TrangThai").ToString().Trim() == "4")
                {
                    CellRange rg = fg.GetCellRange(r, trangThaiRow + 1);
                    rg.Style = csHuy;
                }
                if (fg.GetDataDisplay(r, "ID_TrangThai").ToString().Trim() == "3")
                {
                    CellRange rg = fg.GetCellRange(r, trangThaiRow + 1);
                    rg.Style = csDaXong;
                }
                if (fg.GetDataDisplay(r, "ID_TrangThai").ToString().Trim() == "2")
                {
                    CellRange rg = fg.GetCellRange(r, trangThaiRow + 1);
                    rg.Style = csDangLam;
                }
                if (fg.GetDataDisplay(r, "ID_TrangThai").ToString().Trim() == "1")
                {
                    CellRange rg = fg.GetCellRange(r, trangThaiRow + 1);
                    rg.Style = csChoXuLy;
                }
                if (fg.GetDataDisplay(r, "ID_NguoiYeuCau").ToString().Trim() == m_iID_TaiKhoanDangNhap.ToString())
                {
                    CellRange rg = fg.GetCellRange(r, 1);
                    rg.Style = csCongViecCaNhan;
                }
                if (!fg.Rows[r].Visible)
                {
                    fg.Rows.Remove(r);
                    --r;
                }
            }

            ShowTimeline(m_dtDtNow);
            SetSTT();
            ChiHienThiCoCongViec(chkHienThiKhiCoCV.Checked);
            HienThi_ChuaDoc_Comment();
            fg.Row = -1;
            fg.EndUpdate();
            fg.Tag = 1;
            //fg.Row = m_iSelectedRow;
        }

        private void SendDataToFormThongTinCV(bool themMoi)
        {
            if (themMoi)
            {
                int ID_CongViec = 0;
                if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
                {
                    m_fFrmCv = new frmCongViec();
                    m_fFrmCv.frmQLTD = this;
                    m_fFrmCv.Show();
                }
                else
                {
                    if (int.Parse(fg.GetDataDisplay(fg.Row, "ID_CongViec").ToString()) < 0)
                    {
                        int id_loaiCV = 0;
                        int.TryParse((fg[fg.Row, "ID_CongViec"].ToString()), out id_loaiCV);

                        if (id_loaiCV == 0)
                        {
                            m_fFrmCv = new frmCongViec();
                            m_fFrmCv.frmQLTD = this;
                            m_fFrmCv.Show();
                        }
                        else
                        {
                            m_fFrmCv = new frmCongViec(id_loaiCV);
                            m_fFrmCv.frmQLTD = this;
                            m_fFrmCv.Show();
                        }
                    }
                    else
                    {
                        int.TryParse(fg[fg.Row, "ID_CongViec"].ToString(), out ID_CongViec);
                        if (ID_CongViec == 0)
                        {
                            m_fFrmCv = new frmCongViec();
                            m_fFrmCv.frmQLTD = this;
                            m_fFrmCv.Show();
                        }
                        else
                        {
                            m_fFrmCv = new frmCongViec(ID_CongViec);
                            m_fFrmCv.frmQLTD = this;
                            m_fFrmCv.Show();
                        }
                    }
                }
            }
            else
            {
                int ID_CongViec = Convert.ToInt32(fg[fg.Row, "ID_CongViec"]);
                m_fFrmCv = new frmCongViec(ID_CongViec, true);
                m_fFrmCv.frmQLTD = this;
                m_fFrmCv.Show();
            }
        }

        public string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999))
                throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900); //EDIT: i've typed 400 instead 900
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }

        public bool IsNode0(int row)
        {
            if (fg.GetDataDisplay(row, "ID_CongViec_Goc") == "") return true;
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (fg.GetDataDisplay(row, "ID_CongViec_Goc") == fg.GetDataDisplay(r, "ID_CongViec")) return false;
            }
            return true;
        }

        private bool TonTaiCongViecGoc(int level)
        {
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; r++)
            {
                if (!fg.Rows[r].Visible) continue;
                if (fg.Rows[r].Node.Level == 0 && fg.GetDataDisplay(r, "ID_CongViec_Goc").ToString() != "")
                {
                    for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                    {
                        if (!fg.Rows[i].Visible) continue;
                        if (fg.GetDataDisplay(r, "ID_CongViec_Goc").ToString() ==
                            fg.GetDataDisplay(i, "ID_CongViec").ToString() && fg.Rows[i].Node.Level == level && i != r)
                            return true;
                    }
                }
            }
            return false;
        }

        private void GetDataTwoRow(int row1, int row2)
        {
            for (int c = fg.Cols.Fixed; c < fg.Cols.Count; ++c)
            {
                fg.Rows[row1][c] = fg.Rows[row2][c];
            }
        }

        private CellStyle csChuDoQUaHan;

        private void InitCellStyles()
        {
            cs = fg.Styles.Add("Nền");
            cs.ForeColor = Color.White;
            //
            csLoaiCV = fg.Styles.Add("LoaiCongViec");
            csLoaiCV.ForeColor = Color.Blue;
            //
            csCongViecCaNhan = fg.Styles.Add("Công việc cá nhân");
            csCongViecCaNhan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            //
            csChuaDocComment_QuaHan = fg.Styles.Add("chua doc qua han");
            csChuaDocComment_QuaHan.ForeColor = Color.Red;
            csChuaDocComment_QuaHan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            //
            csChuaDocComment = fg.Styles.Add("chua doc");
            csChuaDocComment.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            //
            csChuDoQUaHan = fg.Styles.Add("Chữ đỏ quá hạn");
            csChuDoQUaHan.ForeColor = Color.Red;
            //
            csQuaHan_CaNhan = fg.Styles.Add("Chữ đỏ quá hạn được giao");
            csQuaHan_CaNhan.ForeColor = Color.Red;
            csQuaHan_CaNhan.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));

            //
            csChoXuLy = fg.Styles.Add("Chờ tiếp nhận");
            csChoXuLy.BackColor = Color.White;
            csChoXuLy.ForeColor = Color.DeepPink;
            csDaNhan = fg.Styles.Add("Đã nhận");
            csDaNhan.BackColor = Color.LightSkyBlue;
            csDaNhan.ForeColor = Color.DeepPink;
            csDangLam = fg.Styles.Add("Đang làm");
            csDangLam.BackColor = Color.Khaki;
            csDangLam.ForeColor = Color.DeepPink;
            csHuy = fg.Styles.Add("Hủy");
            csHuy.BackColor = Color.Crimson;
            csHuy.ForeColor = Color.White;
            csDaXong = fg.Styles.Add("Đã xong");
            csDaXong.BackColor = Color.LightGreen;
            csDaXong.ForeColor = Color.DeepPink;
            csQuaHan = fg.Styles.Add("Quá hạn");
            csQuaHan.BackColor = Color.Red;
            csQuaHan.ForeColor = Color.White;
            csMucDoCao = fg.Styles.Add("Cao");
            csMucDoCao.ForeColor = Color.Red;

            csMucDoTB = fg.Styles.Add("Trung bình");
            csMucDoTB.ForeColor = Color.MediumBlue;
            csMucDoThap = fg.Styles.Add("Thấp");
            csMucDoThap.ForeColor = Color.Maroon;
            csNow = fg.Styles.Add("Now");
            csNow.ForeColor = Color.DarkMagenta;
            csChuNhat = fg.Styles.Add("Ngày nghỉ");
            csChuNhat.ForeColor = Color.Red;
            csChuNhat.TextAlign = TextAlignEnum.CenterCenter;
        }

        public bool KhongCoCongViecGoc(int row)
        {
            if (fg.GetDataDisplay(row, "ID_CongViec_Goc") == "") return true;
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (fg.GetDataDisplay(row, "ID_CongViec_Goc") == fg.GetDataDisplay(r, "ID_CongViec") &&
                    r != row) return false;
            }
            return true;
        }

        public int TimCongViecGoc(int row, int NodeLevel)
        {
            int ID_CongViec = int.Parse(fg.Rows[row]["ID_CongViec"].ToString());
            int r = fg.Rows.Fixed;
            for (r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (!fg.Rows[r].Visible || r == row ||
                    fg.GetDataDisplay(r, "ID_CongViec_Goc").ToString() == "") continue;
                if (ID_CongViec == int.Parse(fg.Rows[r]["ID_CongViec_Goc"].ToString()) && fg.Rows[r].Visible &&
                    fg.Rows[r].Node.Level == 0)
                {
                    if (row < r)
                    {
                        fg.Rows[r].Visible = false;
                        fg.Rows.InsertNode(row + 1, NodeLevel);
                        GetDataTwoRow(row + 1, r + 1);
                    }
                    else
                    {
                        fg.Rows[r].Visible = false;
                        fg.Rows.InsertNode(row + 1, NodeLevel);
                        GetDataTwoRow(row + 1, r);
                    }
                    ++row;
                }
            }
            return row;
        }

        private void ShowTimeline(DateTime m_dtDtNow)
        {
            clsCongViec cls = new clsCongViec();
            DataTable dt_DsNgayNghi = cls.DS_NgayNghi(m_dtD1, m_dtD2);
            int stt = 0;
            for (DateTime d = m_dtD1.Date; d.Date <= m_dtD2.Date; d = d.AddDays(1))
            {
                C1.Win.C1FlexGrid.Column col = fg.Cols.Add();
                col.Width = 30;
                col.Caption = d.Day.ToString() ;
                col.Name = stt.ToString();
                col.TextAlign = TextAlignEnum.CenterCenter;
            }
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (int.Parse(fg.GetDataDisplay(r, "ID_CongViec").ToString()) < 0)
                {
                    CellRange rg = fg.GetCellRange(r, 1);
                    rg.Style = csLoaiCV;
                }
                if (fg.GetDataDisplay(r, "Ngay_BatDau").ToString() == "" ||
                    fg.GetDataDisplay(r, "Ngay_DenHan").ToString() == "") continue;
                if (fg.Rows[r].Visible)
                {
                    DateTime ngayBatDau = (DateTime) fg.Rows[r]["Ngay_BatDau"];
                    DateTime Ngay_DenHan = m_dtD2.AddDays(-1);
                    DateTime.TryParse(fg.Rows[r]["Ngay_DenHan"].ToString(), out Ngay_DenHan);
                    DateTime d = m_dtD1.AddDays(-1);
                    DateTime ngayHoanThanh;

                    for (int c = m_irowDateOfTimeline; c < fg.Cols.Count; c++)
                    {
                        d = d.AddDays(1);
                        // chu nhat and now
                        if (fg.GetDataDisplay(r, c) == "")
                        {
                            if (Trong_DsNgayNghi(dt_DsNgayNghi, d))
                            {
                                CellRange rg = fg.GetCellRange(r, c);
                                rg.Style = csChuNhat;
                                fg.Rows[r][c] = "Nghỉ";
                            }
                            if (d.Date == m_dtDtNow.Date)
                            {
                                CellRange rg = fg.GetCellRange(r, c);
                                rg.Style = csChuNhat;
                                fg.Rows[r][c] = "Now";
                            }
                        }
                        //CellRange rgr = fg.GetCellRange(r, c);
                        //rgr.Style = cs;
                        if (fg.Rows[r]["ID_TrangThai"].ToString().Trim() != "4".Trim() &&
                            fg.Rows[r]["ID_TrangThai"].ToString().Trim() != "1".Trim())
                        {
                            if (d.Date.Date > m_dtDtNow.Date) continue;
                            ngayHoanThanh = m_dtD2.AddDays(1);
                            if (fg.Rows[r]["Ngay_HoanThanh"].ToString().Trim() != "")
                            {
                                ngayHoanThanh = (DateTime) fg.Rows[r]["Ngay_HoanThanh"];
                            }
                            if (fg.Rows[r]["Ngay_HoanThanh"].ToString() == "" &&
                                fg.Rows[r]["ID_TrangThai"].ToString() == "3")
                            {
                                ngayHoanThanh = Ngay_DenHan;
                            }
                            if (ngayBatDau.Date > ngayHoanThanh.Date || ngayBatDau.Date > m_dtDtNow.Date) continue;
                            if (ngayBatDau.Date > Ngay_DenHan.Date)
                            {
                                if (d.Date >= Ngay_DenHan.Date && (d.Date <= ngayHoanThanh.Date) &&
                                    d.Date <= m_dtDtNow.Date)
                                {
                                    fg.SetCellImage(r, c, Garco10.Presenter.QLCV.Properties.Resources.ico_Red_Arrow);
                                    int ngayQuaHan =
                                        int.Parse((m_dtDtNow.Date - Ngay_DenHan.Date).TotalDays.ToString());
                                    if (int.Parse((m_dtDtNow.Date - Ngay_DenHan.Date).TotalDays.ToString()) >
                                        int.Parse((ngayHoanThanh.Date - Ngay_DenHan.Date).TotalDays.ToString()))
                                    {
                                        ngayQuaHan =
                                            int.Parse((ngayHoanThanh.Date - Ngay_DenHan.Date).TotalDays.ToString());
                                    }
                                    CellRange rgr = fg.GetCellRange(r, c);
                                    rgr.Style = csQuaHan;
                                    fg.Rows[r][c] = "(" + fg.Rows[r]["PhanTramHoanThanh"] + ") " + ngayQuaHan +
                                                    " ngày quá hạn";
                                    fg.Rows[r]["Ten_TrangThai"] = "Quá hạn";
                                    CellRange temp = fg.GetCellRange(r, 1);
                                    if (fg.GetDataDisplay(r, "ID_NguoiYeuCau").ToString().Trim() ==
                                        m_iID_TaiKhoanDangNhap.ToString())
                                    {
                                        temp.Style = csQuaHan_CaNhan;
                                    }
                                    else
                                    {
                                        temp.Style = csChuDoQUaHan;
                                    }

                                    CellRange temp2 = fg.GetCellRange(r, 12);
                                    temp2.Style = csQuaHan;
                                }
                            }
                            else
                            {
                                if (ngayHoanThanh.Date <= Ngay_DenHan.Date)
                                {
                                    if (d.Date >= ngayBatDau.Date && d.Date <= ngayHoanThanh.Date)
                                    {
                                        CellRange rgr = fg.GetCellRange(r, c);
                                        rgr.Style = cs;
                                        fg.SetCellImage(r, c,
                                            Garco10.Presenter.QLCV.Properties.Resources.ico_Blue_Arrow);
                                        fg.Rows[r][c] = fg.Rows[r]["PhanTramHoanThanh"];
                                        if (fg.GetDataDisplay(r, "GiaTri").ToString() != "" &&
                                            fg.GetDataDisplay(r, "GiaTri").ToString() != "0")
                                        {
                                            if (fg.GetDataDisplay(r, "SoLuong_KeHoach").ToString() != "")
                                            {
                                                fg.Rows[r][c] =
                                                    fg.GetDataDisplay(r, "GiaTri").ToString() + "/" +
                                                    fg.GetDataDisplay(r, "SoLuong_KeHoach").ToString() + " " +
                                                    fg.GetDataDisplay(r, "Ten_KetQua_DonVi").ToString();
                                            }
                                            else
                                            {
                                                fg.Rows[r][c] =
                                                    fg.GetDataDisplay(r, "GiaTri").ToString() + " " +
                                                    fg.GetDataDisplay(r, "Ten_KetQua_DonVi").ToString();
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    int ngayDaLam = (int) ((ngayHoanThanh.Date - ngayBatDau.Date).TotalDays);
                                    int ngayQuaHan = (int) ((ngayHoanThanh.Date - Ngay_DenHan.Date).TotalDays);
                                    if (ngayHoanThanh.Date == m_dtD2.AddDays(1))
                                    {
                                        ngayDaLam = (int) ((m_dtDtNow.Date - ngayBatDau.Date).TotalDays);
                                        ngayQuaHan = (int) ((m_dtDtNow.Date - Ngay_DenHan.Date).TotalDays);
                                    }
                                    if (d.Date >= ngayBatDau.Date && d.Date <= Ngay_DenHan.Date)
                                    {
                                        CellRange rgr = fg.GetCellRange(r, c);
                                        rgr.Style = cs;
                                        fg.SetCellImage(r, c,
                                            Garco10.Presenter.QLCV.Properties.Resources.ico_Blue_Arrow);

                                        fg.Rows[r][c] = fg.Rows[r]["PhanTramHoanThanh"];
                                        if (fg.GetDataDisplay(r, "GiaTri").ToString() != "" &&
                                            fg.GetDataDisplay(r, "GiaTri").ToString() != "0")
                                        {
                                            if (fg.GetDataDisplay(r, "SoLuong_KeHoach").ToString() != "")
                                            {
                                                fg.Rows[r][c] =
                                                    fg.GetDataDisplay(r, "GiaTri").ToString() + "/" +
                                                    fg.GetDataDisplay(r, "SoLuong_KeHoach").ToString() + " " +
                                                    fg.GetDataDisplay(r, "Ten_KetQua_DonVi").ToString();
                                            }
                                            else
                                            {
                                                fg.Rows[r][c] =
                                                    fg.GetDataDisplay(r, "GiaTri").ToString() + " " +
                                                    fg.GetDataDisplay(r, "Ten_KetQua_DonVi").ToString();
                                            }
                                        }
                                    }
                                    if (d.Date > Ngay_DenHan.Date && d.Date <= ngayHoanThanh.Date)
                                    {
                                        CellRange rgr = fg.GetCellRange(r, c);
                                        rgr.Style = csQuaHan;
                                        fg.SetCellImage(r, c,
                                            Garco10.Presenter.QLCV.Properties.Resources.ico_Red_Arrow);
                                        fg.Rows[r][c] = ngayQuaHan + " ngày quá hạn";
                                        fg.Rows[r]["Ten_TrangThai"] = "Quá hạn";
                                        CellRange temp = fg.GetCellRange(r, 1);
                                        if (fg.GetDataDisplay(r, "ID_NguoiYeuCau").ToString().Trim() ==
                                            m_iID_TaiKhoanDangNhap.ToString())
                                        {
                                            temp.Style = csQuaHan_CaNhan;
                                        }
                                        else
                                        {
                                            temp.Style = csChuDoQUaHan;
                                        }
                                        CellRange temp2 = fg.GetCellRange(r, 12);
                                        temp2.Style = csQuaHan;
                                    }
                                }
                            }
                        }
                    }
                    fg.AllowMerging = AllowMergingEnum.Custom;
                    for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                    {
                        fg.Rows[i].AllowMerging = true;
                    }
                    int trangThaiRow = 5;
                    if (Ngay_DenHan.Date < m_dtDtNow.Date && (fg.Rows[r]["ID_TrangThai"].ToString() == "2"))
                    {
                        fg.Rows[r]["ID_TrangThai"] = "Quá hạn";
                        CellRange rg3 = fg.GetCellRange(r, trangThaiRow);
                        rg3.Style = csQuaHan;
                    }
                    else
                    {
                        if (fg.Rows[r]["ID_TrangThai"].ToString() == "2")
                        {
                            CellRange rg = fg.GetCellRange(r, trangThaiRow);
                            rg.Style = csDangLam;
                        }
                        if (fg.Rows[r]["ID_TrangThai"].ToString() == "3")
                        {
                            CellRange rg = fg.GetCellRange(r, trangThaiRow);
                            rg.Style = csDaXong;
                        }
                        if (fg.Rows[r]["ID_TrangThai"].ToString().ToLower().Trim() == "1".ToLower().Trim())
                        {
                            CellRange rg = fg.GetCellRange(r, trangThaiRow);
                            rg.Style = csChoXuLy;
                            ;
                        }
                        if (fg.Rows[r]["ID_TrangThai"].ToString().ToLower().Trim() == "4".ToLower().Trim())
                        {
                            CellRange rg = fg.GetCellRange(r, trangThaiRow);
                            rg.Style = csHuy;
                        }
                    }

                    //
                    if (fg.Rows[r]["ID_MucDoUuTien"].ToString().Trim() == "3")
                    {
                        CellRange rg = fg.GetCellRange(r, trangThaiRow + 1);
                        rg.Style = csMucDoCao;
                    }
                    if (fg.Rows[r]["ID_MucDoUuTien"].ToString().Trim() == "2")
                    {
                        CellRange rg = fg.GetCellRange(r, trangThaiRow + 1);
                        rg.Style = csMucDoTB;
                    }
                    if (fg.Rows[r]["ID_MucDoUuTien"].ToString().Trim() == "1")
                    {
                        CellRange rg = fg.GetCellRange(r, trangThaiRow + 1);
                        rg.Style = csMucDoThap;
                    }
                }
            }
            fg.AllowMerging = AllowMergingEnum.Free;
        }


        private void LoadcmbTrangThai()
        {
            var cmb = cmbTrangThai;
            cmb.Tag = 0;
            clsDM_TrangThai clsTrangThai = new clsDM_TrangThai();
            DataTable dt = clsTrangThai.SelectAll();
            dt.DefaultView.Sort = "STT_TrangThai ASC";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_TrangThai";
            cmb.Properties.ValueMember = "ID_TrangThai";

            List<String> editValues = new List<String>();
            foreach (DataRow dr in dt.Rows)
            {
                editValues.Add(dr["ID_TrangThai"].ToString());
            }
            string s = String.Join(",", editValues.ToArray());
            cmb.SetEditValue(s);
            cmb.Tag = 1;
            //
           var  cmb2 = cmbTrangThai2;
            cmb2.Tag = 0;
            cmb2.Properties.DataSource = dt;
            cmb2.Properties.DisplayMember = "Ten_TrangThai";
            cmb2.Properties.ValueMember = "ID_TrangThai";
            cmb2.Tag = 1;
        }

        private void LoadcmbLoaiCV()
        {

            var cmb = cmbLoaiCV;
            cmb.Tag = 0;
            clsDM_LoaiCV clsLoaiCV = new clsDM_LoaiCV();
            dt = clsLoaiCV.SelectAll();
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

        private void LoadNhanVien()
        {
            var cmb = cmbNhanVien;
            cmb.Tag = 0;
            cmbNguoiYeuCau.Tag = 0;
            clsNhanSu cls = new clsNhanSu();

            //dt_NhanSu = cls.GetNhanSu(SystemModule.HeThong.GlobalVariables.uID_DonVi, 0);
            dt_NhanSu = cls.SelectW_ID_NguoiQuanLy(DataAccess.QLCV.Global.GlobalVariables.GetID_NhanSu(),GlobalVariables.uID_DonVi);
            //dt_NhanSu.DefaultView.RowFilter = "TrangThai_DiLam = 'Đang đi làm'";
            dt_NhanSu = dt_NhanSu.DefaultView.ToTable();
            cmb.Properties.DataSource = dt_NhanSu;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmbNguoiYeuCau.Properties.DataSource = dt_NhanSu;
            cmbNguoiYeuCau.Properties.DisplayMember = "HoTen";
            cmbNguoiYeuCau.Properties.ValueMember = "ID_NhanSu";
            List<String> editValues = new List<String>();
            foreach (DataRow dr in dt_NhanSu.Rows)
            {
                editValues.Add(dr["ID_NhanSu"].ToString());
            }
            string s = String.Join(",", editValues.ToArray());
            cmb.SetEditValue(s);
            cmbNguoiYeuCau.SetEditValue(s);
            cmb.Tag = 1;
            cmbNguoiYeuCau.Tag = 1;
        }

        private void LoadDoUuTien()
        {
            var cmb = cmbUuTien;
            cmb.Tag = 0;
            clsDM_MucDoUuTien clsUuTien = new clsDM_MucDoUuTien();
            dt = clsUuTien.SelectAll();
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_MucDo";
            cmb.Properties.ValueMember = "ID_MucDoUuTien";
            List<String> editValues = new List<String>();
            foreach (DataRow dr in dt.Rows)
            {
                editValues.Add(dr["ID_MucDoUuTien"].ToString());
            }
            string s = String.Join(",", editValues.ToArray());
            cmb.SetEditValue(s);
            cmb.Tag = 1;
        }

        private void LoadCombobox()
        {
            LoadcmbTrangThai();
            LoadNhanVien();
            LoadcmbLoaiCV();
            LoadDoUuTien();
        }

        private void ChiHienThiCoCongViec(bool trangThai)
        {
            fg.BeginUpdate();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
            {
                fg.Rows[i].Visible = !trangThai;
            }
            if (trangThai)
            {
                for (int row = fg.Rows.Fixed; row < fg.Rows.Count; ++row)
                {
                    if (int.Parse(fg.GetDataDisplay(row, "ID_CongViec").ToString()) > 0)
                    {
                        fg.Rows[row].Visible = true;
                        int level = fg.Rows[row].Node.Level - 1;
                        for (int i = row - 1; i >= fg.Rows.Fixed; --i)
                        {
                            if (fg.Rows[i].Node.Level == level)
                            {
                                fg.Rows[i].Visible = true;
                                --level;
                            }
                        }
                    }
                }
            }
            
            //SetSTT();
            fg.EndUpdate();
        }

        private void HienThi_ChuaDoc_Comment()
        {
            string ds_idCongViec_ChuaDoc_Comment = "";
            clsCongViec_Comment cls = new clsCongViec_Comment();
            DataTable dt = cls.SelectAll_ChuaDoc();
            foreach (DataRow dr in dt.Rows)
            {
                ds_idCongViec_ChuaDoc_Comment += "," + dr["ID_CongViec"].ToString();
            }
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
            {
                if (int.Parse(fg.GetDataDisplay(i, "ID_CongViec").ToString()) < 0) continue;
                //if (TrongDsCongViec(ds_idCongViec_ChuaDoc_Comment, fg.GetDataDisplay(i, "ID_CongViec").ToString()))
                //{
                //    if (fg.GetDataDisplay(i, "Ten_TrangThai").ToString() == "Quá hạn")
                //    {
                //        CellRange rg = fg.GetCellRange(i, 1);
                //        rg.Style = csChuaDocComment_QuaHan;
                //    }
                //    else
                //    {
                //        CellRange rg = fg.GetCellRange(i, 1);
                //        rg.Style = csChuaDocComment;
                //    }
                //}
                //for (int r = 0; r < dt.Rows.Count; ++r)
                //{
                //    if(fg.GetDataDisplay)
                //}
            }
        }

        private void AutoAlignScreen()
        {
            Size s = new Size();
            s = SystemInformation.WorkingArea.Size;

            double x = (double)s.Width / (double)1600;
            double y = (double)s.Height / (double)860;

            foreach (Control c in ucGroupBox2.Controls)
            {
                c.Size = new Size((int)(x * c.Size.Width), (int)(y * c.Size.Height));
                c.Location = new Point((int)(x * c.Location.X), (int)(y * c.Location.Y));
            }
        }

        private void cmbTuyChonHienThi_EditValueChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void fg_DoubleClick(object sender, EventArgs e)
        {
            EditCongViec();
        }

        private void EditCongViec()
        {
            if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
            {
                return;
            }
            if (int.Parse(fg.GetDataDisplay(fg.Row, "ID_CongViec").ToString()) < 0) return;
            SendDataToFormThongTinCV(false);
            LoadData();
        }

        private void ucTextBox3_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void cmbTrangThai_EditValueChanged(object sender, EventArgs e)
        {
            if (m_bIsLoadForm || cmbTrangThai.Tag + "" == "0") return;
            m_sds_TrangThai = cmbTrangThai.Properties.GetCheckedItems().ToString();
            LoadData();
        }

        private bool Trong_DsNgayNghi(DataTable dt, DateTime date)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (((DateTime)dr["Ngay"]).Date == date.Date) return true;
            }
            return false;
        }

        private void cmbUuTien_EditValueChanged(object sender, EventArgs e)
        {
            if (m_bIsLoadForm || cmbUuTien.Tag + "" == "0") return;
            m_sds_MucDoUuTien = cmbUuTien.Properties.GetCheckedItems().ToString();
            LoadData();
        }

        private void applySearchFilter()
        {
            var searchString = txtTimKiem.Text.Trim().ToLower();
            if (searchString.ToString() == "")
            {
                for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                {
                    fg.Rows[i].Visible = true;
                }
                ChiHienThiCoCongViec(chkHienThiKhiCoCV.Checked);
            }
            else
            {
                for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                {
                    if ((int.Parse(fg.GetDataDisplay(i, "ID_CongViec").ToString()) > 0)
                        && ((fg.GetDataDisplay(i, "TieuDe").Trim().ToLower().Contains(searchString))
                        || (fg.GetDataDisplay(i, "Ma_CongViec").Trim().ToLower().Contains(searchString))))
                    {
                        fg.Rows[i].Visible = true;
                    }
                    else
                    {
                        fg.Rows[i].Visible = false;
                    }
                }
                //ChiHienThiCoCongViec(chkHienThiKhiCoCV.Checked);
            }

            //SetSTT();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (fg.Row < fg.Rows.Fixed)
            {
                BaseMessages.ShowWarningMessage("Chưa chọn công việc!");
                return;
            }
            if (int.Parse(fg.GetDataDisplay(fg.Row, "ID_CongViec").ToString()) < 0) return;
            SendDataToFormThongTinCV(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DeleteCongViec();
        }

        private void DeleteCongViec()
        {
            if (fg.Row < fg.Rows.Fixed)
            {
                BaseMessages.ShowWarningMessage("Chưa chọn công việc!");
                return;
            }
            if (int.Parse(fg.GetDataDisplay(fg.Row, "ID_CongViec")) < 0) return;
            if (BaseMessages.ShowDeleteQuestionMessage() == DialogResult.No) return;
            clsCongViec cls = new clsCongViec();
            foreach (Row row in fg.Rows.Selected)
            {
                //cls.ID_CongViec = Convert.ToInt32(fg[fg.Row, "ID_CongViec"]);
                cls.ID_CongViec = Convert.ToInt32(row["ID_CongViec"]);
                DataTable dt = cls.Select_ID_CongViecGoc(Convert.ToInt32(row["ID_CongViec"]));
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        clsCongViec cls2 = new clsCongViec();
                        int ID_Congviec = int.Parse(dt.Rows[i]["ID_CongViec"].ToString());
                        cls2.ID_CongViec = ID_Congviec;
                        cls2.SelectOne();
                        cls2.TonTai = false;
                        cls2.Update();
                    }
                }
                cls.SelectOne();
                cls.TonTai = false;
                cls.Update();
            }
            
            
            BaseMessages.ShowInformationMessage("Xóa thành công!");
            LoadData();
        }

        private void cmbLoaiCV_EditValueChanged(object sender, EventArgs e)
        {
            if (m_bIsLoadForm || cmbLoaiCV.Tag + "" == "0") return;
            m_sds_LoaiCV = cmbLoaiCV.Properties.GetCheckedItems().ToString();
            LoadData();
        }

        private void cmbNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            if (m_bIsLoadForm || cmbNhanVien.Tag + "" == "0") return;
            m_sds_NhanVien = cmbNhanVien.Properties.GetCheckedItems().ToString();
            LoadData();
        }

        private void dteNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            if (dteNgayKetThuc.Value.ToString() == "" || m_bIsLoadForm)
            {
                return;
            }
            LoadCombobox();
            LoadData();
        }

        private void dteNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            if (dteNgayBatDau.Value.ToString() == "" || m_bIsLoadForm)
            {
                return;
            }
            LoadCombobox();
            LoadData();
        }

        private void chkHienThiKhiCoCV_CheckedChanged(object sender, EventArgs e)
        {
            ChiHienThiCoCongViec(chkHienThiKhiCoCV.Checked);
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            applySearchFilter();
        }

        private void cmbNguoiGiaoViec_EditValueChanged(object sender, EventArgs e)
        {
            if (m_bIsLoadForm || cmbNguoiYeuCau.Tag + "" == "0") return;
            m_sds_NguoiYeuCau = cmbNguoiYeuCau.Properties.GetCheckedItems().ToString();
            LoadData();
        }

        private void fg_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DeleteCongViec();
            }
        }

        private void btnThemMoi_ViecGoc_Click(object sender, EventArgs e)
        {
            m_fFrmCv = new frmCongViec();
            m_fFrmCv.frmQLTD = this;
            m_fFrmCv.Show();
        }

        private void mnu_Expand_Click(object sender, EventArgs e)
        {
            fg.Tree.Show(10);
        }

        private void mnu_Collapse_Click(object sender, EventArgs e)
        {
            fg.Tree.Show(0);
        }

        private void mnu_ThemMoi_Click(object sender, EventArgs e)
        {
            m_fFrmCv = new frmCongViec();
            m_fFrmCv.frmQLTD = this;
            m_fFrmCv.Show();
        }

        private void mnu_ThemMoiCon_Click(object sender, EventArgs e)
        {
            SendDataToFormThongTinCV(true);
        }

        private void mnu_Xoa_Click(object sender, EventArgs e)
        {
            DeleteCongViec();
        }

        private void mnu_Sua_Click(object sender, EventArgs e)
        {
            if (fg.Row < fg.Rows.Fixed)
            {
                BaseMessages.ShowWarningMessage("Chưa chọn công việc!");
                return;
            }
            if (int.Parse(fg.GetDataDisplay(fg.Row, "ID_CongViec").ToString()) < 0) return;
            SendDataToFormThongTinCV(false);
        }

        private void mnu_ThemCVLap_Click(object sender, EventArgs e)
        {
            //frmCongViec frm = new frmCongViec();
            //frm.ShowDialog();
            //frmLapLich frm2 = new frmLapLich();
            //frm2.ShowDialog();
        }

        private void cbChiHienThiViecQuaHan_CheckedChanged(object sender, EventArgs e)
        {
            LocViecQuaHan();
        }
        void LocViecQuaHan()
        {

            if (cbChiHienThiViecQuaHan.Checked == true)
            {
                for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                {
                    if (fg.Rows[i].Visible == true)
                    {
                        if (fg.GetDataDisplay(i, "Ten_TrangThai").ToString() != "Quá hạn")
                        {
                            fg.Rows[i].Visible = false;
                        }
                    }
                }
            }
            else
            {
                for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                {
                    if (fg.Rows[i].Visible == false)
                    {
                        fg.Rows[i].Visible = true;
                    }
                }
                ChiHienThiCoCongViec(chkHienThiKhiCoCV.Checked);
            }
            
        }

        

        private void fg_AfterRowChange(object sender, RangeEventArgs e)
        {
            clearGroupBox();
            txtTieuDe.Text = fg.Row.ToString();
            int idCongViec = 0;
            int row = fg.Row;
            if (row < 0) return;
            int.TryParse(fg.GetDataDisplay(row, "ID_CongViec").ToString(), out idCongViec);
            if (idCongViec <= 0) return;
            var cls = new clsCongViec();
            cls.ID_CongViec = idCongViec;
            DataTable dt = cls.SelectOne();
            txtTieuDe.Text = dt.Rows[0]["TieuDe"].ToString() ;
            txtKhoiLuong.EditValue = dt.Rows[0]["SoLuong_KeHoach"].ToString();
            dtNgayYeuCau.Value = dt.Rows[0]["Ngay_YeuCau"];
            dtNgayDenHan.Value = dt.Rows[0]["Ngay_DenHan"];
            dtNgayBatDau.Value = dt.Rows[0]["Ngay_BatDau"];
            dtNgayHT.Value = dt.Rows[0]["Ngay_HoanThanh"];
            Load_fgKetQua(idCongViec);
        }
        // Công việc
        void LoadCongViec(int id_CongViec,int row)
        {
            dtNgayBatDau.Value = fg.GetDataDisplay(row,"Ngay_BatDau");
            dtNgayDenHan.Value = fg.Rows[row]["Ngay_KetThuc"];
        }
        private void Load_fgKetQua(int idCongViec)
        {
            var fg = fgKetQua;
            fg.Tag = 0;
            fg.BeginUpdate();
            var cls = new clsCongViec_KetQua();
            var dt = cls.Select_W_ID_CongViec(idCongViec);
            fg.ClearRows();
            fg.SetDataSource(dt);
            fg.SetSTT();
            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }
        private void clearGroupBox()
        {
            txtTieuDe.Text = "";
            txtKhoiLuong.Text = "";
            //dtNgayBatDau.Clear();
            //dtNgayDenHan.Clear();
            //dtNgayHT.Clear();
            //dtNgayYeuCau.Clear();
            //fgKetQua.ClearRows();
            dtNgayBatDau.Value = null;
            dtNgayDenHan.Value = null;
            dtNgayHT.Value = null;
            dtNgayYeuCau.Value = null;
            fgKetQua.ClearRows();
        }

        private void fgKetQua_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    fgKetQua.Rows.Add();
                    fgKetQua.Rows[fgKetQua.Rows.Count - 1]["IsEdit"] = "1";
                   // fgKetQua.Rows[fgKetQua.Rows.Count - 1]["TenDayDu"] = GlobalVariables.Get_HoTen_NhanSu();
                    fgKetQua.Rows[fgKetQua.Rows.Count - 1]["Ngay_Lap"] = GlobalVariables.GetCurrentDateTime();
                    fgKetQua.Rows[fgKetQua.Rows.Count - 1]["Ngay_BatDau"] = GlobalVariables.GetCurrentDateTime();
                    fgKetQua.Rows[fgKetQua.Rows.Count - 1]["Ngay_HoanThanh"] = GlobalVariables.GetCurrentDateTime();
                    fgKetQua.SetSTT();
                    break;

                case Keys.Delete:
                    if (fgKetQua.Row < fgKetQua.Rows.Fixed)
                    {
                        BaseMessages.ShowInformationMessage("Chưa chọn kết quả công việc!");
                        return;
                    }
                    if (fgKetQua.GetDataDisplay(fgKetQua.Row, "ID_CongViec_KetQua") == "")
                    {
                        fgKetQua.Rows.Remove(fgKetQua.Row);
                    }
                    else
                    {
                        fgKetQua.Rows[fgKetQua.Row]["IsEdit"] = "0";
                        fgKetQua.Rows[fgKetQua.Row].Visible = false;
                    }
                    fgKetQua.SetSTT();
                    break;
            }
        }
    }
}