using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using DevExpress.XtraEditors.Controls;
using Garco10.DataAccess.QLCV.Global;
using Garco10.Presenter.QLCV.DanhMuc;
using Garco10.Presenter.QLCV.TienIch;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using VSCM.Base.Controls;
using VSCM.Base.Forms;
using VSCM.Base.Utils;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmCongViec : FormBaseGarco10
    {
        public enum DonViTG
        {
            Ngay = 1,
            Gio = 2,
            Tuan = 3,
            Thang = 4
        }

        public enum DoUuTien
        {
            Thap = 1,
            TrungBinh = 2,
            Cao = 3
        }

        public enum TrangThai
        {
            ChuaThucHien = 1,
            DangThucHien = 2,
            DaHoanThanh = 3,
            Huy = 4
        }

        public List<object> congViec = new List<object>();
        private frmQuanLyTienDo m_frmQLTD;

        private int m_iIDLoaiCV;

        // private int m_iIDloaiCV;
        public frmQuanLyTienDo frmQLTD
        {
            set { m_frmQLTD = value; }
        }

        private void GetData()
        {
            var cls = new clsCongViec();
            cls.ID_CongViec = Convert.ToInt32(m_iID_CongViec);
            var dt = cls.SelectOne();
            if (dt.Rows.Count > 0)
            {
                txtMaCV.EditValue = dt.Rows[0]["Ma_CongViec"];
                txtTieuDe.EditValue = dt.Rows[0]["TieuDe"];
                txtMoTa.EditValue = dt.Rows[0]["MoTa"];
                cmbLoaiCongViec.EditValue = dt.Rows[0]["ID_LoaiCV"];
                txtLoaiCV.Text = cmbLoaiCongViec.Text;
                if (dt.Rows[0]["ID_MucDoUuTien"].ToString() != "")
                    cmbDoUuTien.EditValue = int.Parse(dt.Rows[0]["ID_MucDoUuTien"].ToString());

                cmbCongViecGoc.EditValue = dt.Rows[0]["ID_CongViec_Goc"].ToString();
                cmbNguoiGiaoViec.EditValue = dt.Rows[0]["ID_NguoiYeuCau"].ToString();
                dtNgayDenHan.Value = dt.Rows[0]["Ngay_DenHan"];
                dtNgayYeuCau.Value = dt.Rows[0]["Ngay_YeuCau"];
                txtThoiGianDuKien.EditValue = dt.Rows[0]["ThoiGian_DuKien"];
                if (dt.Rows[0]["ID_ThoiGian"].ToString() != "")
                    cmbDonViTG.SelectedValue = short.Parse(dt.Rows[0]["ID_ThoiGian"].ToString());
                dtNgayBatDau.Value = dt.Rows[0]["Ngay_BatDau"];

                if (dt.Rows[0]["ID_TrangThai"].ToString() != "")
                    cmbTrangThai.EditValue = int.Parse(dt.Rows[0]["ID_TrangThai"].ToString());

                if (dt.Rows[0]["PhanTramHoanThanh"] != DBNull.Value)
                    if (Convert.ToInt32(dt.Rows[0]["PhanTramHoanThanh"]) >= 0 &&
                        Convert.ToInt32(dt.Rows[0]["PhanTramHoanThanh"]) < 100)
                        currentPhanTramHoanThanh = Convert.ToInt32(dt.Rows[0]["PhanTramHoanThanh"]);
                txtPhanTramHT.EditValue = dt.Rows[0]["PhanTramHoanThanh"];
                var nhanvien = dt.Rows[0]["DS_ID_NhanVien"].ToString().Split(',');
                if (nhanvien != null && nhanvien.Length > 0 && nhanvien[0] != null)
                    cmbNhanVien.EditValue = nhanvien[0];
                if (dt.Rows[0]["LapLai"].ToString() != "")
                    chkLapLai.Checked = bool.Parse(dt.Rows[0]["LapLai"].ToString());

                cmbNguoiThucHien.SetEditValue(dt.Rows[0]["DS_ID_NhanVien"].ToString());
                if (dt.Rows[0]["Ngay_YeuCau"].ToString() != "")
                    m_daNgay_YeuCau = Convert.ToDateTime(dt.Rows[0]["Ngay_YeuCau"]);
                if (dt.Rows[0]["Ngay_Lap"].ToString() != "")
                    m_daNgay_Lap = Convert.ToDateTime(dt.Rows[0]["Ngay_Lap"]);

                if (dt.Rows[0]["ID_NguoiLap"].ToString() != "")
                    m_ID_Nguoi_Lap = int.Parse(dt.Rows[0]["ID_NguoiLap"].ToString());
                if (dt.Rows[0]["ID_TrangThai"].ToString() != "")
                    m_iID_TrangThaiCu = int.Parse(dt.Rows[0]["ID_TrangThai"].ToString());
                dtNgayHT.Value = dt.Rows[0]["Ngay_HoanThanh"];
                if (dt.Rows[0]["HienThiTrenLich"].ToString() != "")
                    chkLich.Checked = bool.Parse(dt.Rows[0]["HienThiTrenLich"].ToString());
                // dtNgayHT.Value = dt.Rows[0]["SoLuong_KeHoach"];
                if (dt.Rows[0]["SoLuong_KeHoach"].ToString() != "")
                    txtKhoiLuong.EditValue = dt.Rows[0]["SoLuong_KeHoach"].ToString();
                if (dt.Rows[0]["ID_NguoiLap"].ToString() != GlobalVariables.GetID_NhanSu().ToString())
                {
                    dtNgayYeuCau.Enabled = dtNgayDenHan.Enabled = false;
                }
            }
            else
            {
                BaseMessages.ShowInformationMessage("Công việc này đã bị xóa!");
            }
        }

        private void frmCongViec_Load(object sender, EventArgs e)
        {
            Load_dtmap_DonVi_KetQua();
            if (m_bCapNhat)
                GetData();
            
            if (dtNgayDenHan.Value != DBNull.Value || dtNgayDenHan.Value.ToString() != "")
            {
                m_dNgayDenHan = Convert.ToDateTime(dtNgayDenHan.Value);
            }
            if (dtNgayYeuCau.Value != DBNull.Value || dtNgayYeuCau.Value.ToString() != "")
            {
                m_dNgay_YeuCau = Convert.ToDateTime(dtNgayYeuCau.Value);
            }
            Load_fgComment();
            Load_fgLichSu();
            Load_fgKetQua();
        }

        private void lblXemLai_Click(object sender, EventArgs e)
        {
            isChinhSua = false;
            if (isChinhSuaLapLai)
            {
                if (!chkLapLai.Checked)
                {
                    frm = new frmLapLich();
                    frm.ShowDialog();
                }
                else
                {
                    if (!m_bCapNhat) //Thêm mới
                    {
                        str_thu = frm.thongSo[0].ToString();
                        str_ngay = frm.thongSo[1].ToString();
                        str_thang = frm.thongSo[2].ToString();
                        gioBatDau = DateTime.Parse(frm.thongSo[3].ToString());
                        gioKetThuc = DateTime.Parse(frm.thongSo[4].ToString());
                        var lapLich = new frmLapLich(str_thu, str_thang, str_ngay, gioBatDau, gioKetThuc);
                        lapLich.ShowDialog();
                    }
                    else //Sửa
                    {
                        var cls = new clsCongViec_ThongSo();
                        var dt = cls.Select_ID_CongViec(m_iID_CongViec);
                        cls.Gio_BatDau = DateTime.Parse(dt.Rows[0]["Gio_BatDau"].ToString());
                        cls.Gio_KetThuc = DateTime.Parse(dt.Rows[0]["Gio_KetThuc"].ToString());
                        cls.DS_Thu = dt.Rows[0]["DS_Thu"].ToString();
                        if (str_thu == "")
                            chkLapLai.Checked = false;
                        var bd = DateTime.Parse(dt.Rows[0]["Gio_BatDau"].ToString());
                        var kt = DateTime.Parse(dt.Rows[0]["Gio_KetThuc"].ToString());
                        var thu = dt.Rows[0]["DS_Thu"].ToString();
                        var ngay = dt.Rows[0]["DS_Ngay"].ToString();
                        var thang = dt.Rows[0]["DS_Thang"].ToString();
                        frm = new frmLapLich(thu, ngay, thang, bd, kt);
                        frm.ShowDialog();
                    }
                }
                isChinhSuaLapLai = false;
                chkLapLai.Checked = true;
            }
            else
            {
                frm.Visible = true;
            }
        }

        private void Update_PhanTramHoanThanh_CongViecCha(int id)
        {
            //clsCongViec cls = new clsCongViec();
            //cls.Update_PHanTramHoanThanh_CongViecCha(id);
        }

        private bool KiemTraCongViecConDaHoanThanhHetChua(int id)
        {
            var cls = new clsCongViec();
            return cls.CongViecCon_HoanThanh_Chua(id);
        }

        private void lbChinhSuaCanhBao_Click(object sender, EventArgs e)
        {
            if (isChinhSuaCanhBao)
            {
                frmCanhBao = new frmCanhBao(m_iID_CongViec);
                frmCanhBao.Show();
                isChinhSuaCanhBao = false;
            }
            else
            {
                frmCanhBao.Visible = true;
            }
        }

        private void InitCellStyles()
        {
            csThayDoi = fgLichSu.Styles.Add("Thay đổi");
            csThayDoi.BackColor = Color.Chartreuse;
        }

        private void dtNgayYeuCau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                dtNgayYeuCau.Value = DBNull.Value;
        }

        private void dtNgayDenHan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                dtNgayDenHan.Value = DBNull.Value;
        }

        private void dtNgayBatDau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                dtNgayBatDau.Value = DBNull.Value;
        }

        private void dtNgayHT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                dtNgayBatDau.Value = DBNull.Value;
        }

        private void lblLichSu_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = tpLichSu;
            lblLichSu.Font = new Font(lblLichSu.Font, FontStyle.Bold);
            lblComment.Font = new Font(lblComment.Font, FontStyle.Regular);
            lblTaiLieu.Font = new Font(lblTaiLieu.Font, FontStyle.Regular);
        }

        private void lblComment_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = tpComment;
            lblLichSu.Font = new Font(lblLichSu.Font, FontStyle.Regular);
            lblComment.Font = new Font(lblComment.Font, FontStyle.Bold);
            lblTaiLieu.Font = new Font(lblTaiLieu.Font, FontStyle.Regular);
        }

        private void lblTaiLieu_Click(object sender, EventArgs e)
        {
            xtraTabControl1.SelectedTabPage = tpAttachment;
            lblLichSu.Font = new Font(lblLichSu.Font, FontStyle.Regular);
            lblComment.Font = new Font(lblComment.Font, FontStyle.Regular);
            lblTaiLieu.Font = new Font(lblTaiLieu.Font, FontStyle.Bold);
        }

        private void cmbTrangThai_EditValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbTrangThai.EditValue) == 3)
            {
                //if(txtPhanTramHT.EditValue.ToString() =="")
                txtPhanTramHT.EditValue = 100;
                if (dtNgayHT.Value.ToString() == "")
                    dtNgayHT.Value = GlobalVariables.GetCurrentDateTime();
            }
            //else if (Convert.ToInt32(cmbTrangThai.EditValue) == 3)
            //{
            //    txtPhanTramHT.EditValue = currentPhanTramHoanThanh;
            //    dtNgayHT.Value = DBNull.Value;
            //}
            else if (Convert.ToInt32(cmbTrangThai.EditValue) == 2)
            {
                txtPhanTramHT.EditValue = currentPhanTramHoanThanh;
                dtNgayHT.Value = DBNull.Value;
            }
            else if (Convert.ToInt32(cmbTrangThai.EditValue) == 1)
            {
                txtPhanTramHT.EditValue = null;
                dtNgayHT.Value = DBNull.Value;
            }
            else if (Convert.ToInt32(cmbTrangThai.EditValue) == 4)
            {
                dtNgayHT.Value = DBNull.Value;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearView();
            txtTieuDe.Text = "";
            if (frmCanhBao != null)
                frmCanhBao.Close();
            if (frm != null)
                frm.Close();
        }

        private void cmbLoaiCongViec_EditValueChanged(object sender, EventArgs e)
        {
            //if (cmbLoaiCongViec.EditValue == null)
            //{
            //    cmbCongViecGoc.EditValue = null;
            //}
            //else
            //{
            //    LoadcmbCongViecGoc(int.Parse(cmbLoaiCongViec.EditValue.ToString()));
            //}
            if (cmbLoaiCongViec.EditValue == null || cmbCongViecGoc.EditValue == null ||
                cmbLoaiCongViec.EditValue.ToString() == "") return;
            cmbCongViecGoc.EditValue = null;
        }

        private void cmbCongViecGoc_EditValueChanged(object sender, EventArgs e)
        {
            //if (cmbCongViecGoc.EditValue == null)
            //{
            //    cmbLoaiCongViec.EditValue = null;
            //}
            //else
            //{
            //    cmbLoaiCongViec.EditValue = GetIDLoaiCV(int.Parse(cmbCongViecGoc.EditValue.ToString()));
            //}
            if (txtLoaiCV.Text == "" || cmbCongViecGoc.EditValue == null || cmbLoaiCongViec.EditValue == null ||
                cmbCongViecGoc.EditValue.ToString() == "") return;
            txtLoaiCV.EditValue = null;
        }

        private void lblThongTinChung_Click(object sender, EventArgs e)
        {
            xtraTabControl2.SelectedTabPage = tpMoTa;
            lblThongTinChung.Font = new Font(lblThongTinChung.Font, FontStyle.Bold);
            lblKetQua.Font = new Font(lblKetQua.Font, FontStyle.Regular);
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {
            xtraTabControl2.SelectedTabPage = tpKetQua;
            lblKetQua.Font = new Font(lblKetQua.Font, FontStyle.Bold);
            lblThongTinChung.Font = new Font(lblThongTinChung.Font, FontStyle.Regular);
        }

        #region fgLichSu

        private void fgLichSu_DoubleClick(object sender, EventArgs e)
        {
            var ID_CongViec_LichSu = int.Parse(fgLichSu.GetDataDisplay(fgLichSu.Row, "ID_CongViec_LichSu"));
            var chiTiet = new frmCongViec_LichSu_ChiTiet(m_iID_CongViec, ID_CongViec_LichSu);
            chiTiet.ShowDialog();
        }

        #endregion fgLichSu

        private void mnu_ThemMoi_Click(object sender, EventArgs e)
        {
            fgKetQua.Rows.Add();
            fgKetQua.Rows[fgKetQua.Rows.Count - 1]["IsEdit"] = "1";
            fgKetQua.Rows[fgKetQua.Rows.Count - 1]["TenDayDu"] = GlobalVariables.Get_HoTen_NhanSu();
            fgKetQua.Rows[fgKetQua.Rows.Count - 1]["Ngay_Lap"] = GlobalVariables.GetCurrentDateTime();
            fgKetQua.Rows[fgKetQua.Rows.Count - 1]["Ngay_BatDau"] = GlobalVariables.GetCurrentDateTime();
            fgKetQua.Rows[fgKetQua.Rows.Count - 1]["Ngay_HoanThanh"] = GlobalVariables.GetCurrentDateTime();
            fgKetQua.SetSTT();
        }

        private void mnu_Xoa_Click(object sender, EventArgs e)
        {
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
        }

        private decimal TinhTongKQ()
        {
            decimal tong = 0;
            for (var i = fgKetQua.Rows.Fixed; i < fgKetQua.Rows.Count; i++)
            {
                var sGiaTri = fgKetQua.GetDataDisplay(i, "GiaTri");

                if (sGiaTri == "") continue;
                tong += decimal.Parse(sGiaTri);
            }
            return tong;
        }

        private void fgKetQua_StartEdit(object sender, RowColEventArgs e)
        {
            if (fgKetQua.Cols[e.Col].Name == "NoiDung")
            {
                fgKetQua.Cols[e.Col].TextAlign = TextAlignEnum.LeftTop;
                fgKetQua.Rows[e.Row].Height = 60;
            }
        }

        private void fgKetQua_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            var fg = fgKetQua;
            if (e.Row >= fg.Rows.Fixed)
                if (fg.Cols[e.Col].Name == "NoiDung")
                    if (e.Text.Length > 100)
                        e.Text = HelperMethods.TruncateString(e.Text, 100) + " ...";
        }

        private void dtNgayHT_ValueChanged(object sender, EventArgs e)
        {
            if (dtNgayHT.Value.ToString() == "")
            {
                cmbTrangThai.EditValue = 2;
            }
            else
            {
                if (cmbTrangThai.EditValue.ToString() == "3") return;
                cmbTrangThai.EditValue = 3;
            }
        }

        private void dtNgayYeuCau_ValueChanged(object sender, EventArgs e)
        {
            if (dtNgayYeuCau.Value.ToString() != "")
                dtNgayBatDau.Value = dtNgayYeuCau.Value;
        }

        private void cmbLoaiCongViec_MouseClick(object sender, MouseEventArgs e)
        {
            //DanhMuc.frmDM_LoaiCongViec frm = new DanhMuc.frmDM_LoaiCongViec(true);
            //frm.ShowDialog();
            //m_iIDLoaiCV = frm.m_iID_LoaiCV;
            //frm.Close();
            //cmbLoaiCongViec.EditValue = m_iIDLoaiCV;
        }

        private void txtLoaiCV_MouseClick(object sender, MouseEventArgs e)
        {
            var frm = new frmDM_LoaiCongViec(true);
            frm.ShowDialog();
            m_iIDLoaiCV = frm.m_iID_LoaiCV;
            txtLoaiCV.EditValue = frm.m_sTen_LoaiCV;
            frm.Close();
        }

        private void txtLoaiCV_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtLoaiCV_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    txtLoaiCV.Text = "";

                    break;

                case Keys.Back:
                    txtLoaiCV.Text = "";
                    if (txtLoaiCV.Text == "" || cmbCongViecGoc.EditValue == null ||
                        cmbLoaiCongViec.EditValue.ToString() == "") return;
                    cmbCongViecGoc.EditValue = null;
                    break;
            }
        }

        private void btnLoadLoaiCV_Click(object sender, EventArgs e)
        {
            var frm = new frmDM_LoaiCongViec(true);
            frm.ShowDialog();
            m_iIDLoaiCV = frm.m_iID_LoaiCV;
            txtLoaiCV.Text = frm.m_sTen_LoaiCV;
            frm.Close();
            if (txtLoaiCV.Text == "" || cmbCongViecGoc.EditValue == null) return;
            cmbCongViecGoc.EditValue = null;
        }

        #region Global Variables

        private short m_iFileType_Group = 0;
        private short m_iFileType = 0;
        private string m_sFileIdentity = "0";
        private string m_sFilterView_FileType = "", m_sFilterEdit_FileType = "";
        private FTP_FilesManager.FTP_PhanMem m_phanmem;
        private readonly bool m_bQuyenCapNhat = true;
        private int m_ID_Nguoi_Lap;

        public bool IsSaved { get; private set; }

        private readonly int m_iID_CongViec;
        private int m_iID_NhanSu;
        private DateTime m_daNgay_YeuCau;
        private DateTime m_daNgay_Lap;
        private decimal currentPhanTramHoanThanh;
        private readonly bool m_bCapNhat;
        private DateTime m_dNgay_YeuCau;
        private bool isLoadForm = true;
        private bool isChinhSuaLapLai = true;
        private frmCanhBao frmCanhBao;
        private bool isChinhSuaCanhBao = true;
        private bool isChinhSua = true;
        private int m_iID_TrangThaiCu;
        private CellStyle csThayDoi;
        public DateTime m_NgayBatDau;
        public DateTime m_dNgayDenHan;

        public string str_thu = string.Empty;
        public string str_ngay = string.Empty;
        public string str_thang = string.Empty;
        public DateTime gioBatDau;
        public DateTime gioKetThuc;
        public frmLapLich frm;
        private decimal m_dThoiGian;
        private string m_strNguoiNhan = "";
        private string m_strMa_CongViec = "";

        #endregion Global Variables

        #region Constructor

        public frmCongViec()
        {
            IsSaved = false;
            InitializeComponent();
            InitCellStyles();
            Loadcmbs();
            cmbDonViTG.SelectedIndex = (int) DonViTG.Ngay;
            cmbDoUuTien.EditValue = (int) DoUuTien.TrungBinh;
            cmbTrangThai.EditValue = (int) TrangThai.ChuaThucHien;
            chkLich.Checked = false;
            txtMaCV.Visible = false;
            cmbNguoiGiaoViec.EditValue = GlobalVariables.GetID_NhanSu();
            cmbNhanVien.EditValue = GlobalVariables.GetID_NhanSu();
            lblComment.Font = new Font(lblComment.Font, FontStyle.Bold);
            lblThongTinChung.Font = new Font(lblComment.Font, FontStyle.Bold);
        }

        public frmCongViec(int ID_CongViec)
        {
            IsSaved = false;
            InitializeComponent();
            InitCellStyles();

            lblComment.Font = new Font(lblComment.Font, FontStyle.Bold);
            lblThongTinChung.Font = new Font(lblComment.Font, FontStyle.Bold);
            if (ID_CongViec > 0)
            {
                Loadcmbs();
                cmbDonViTG.SelectedIndex = (int) DonViTG.Ngay;
                cmbDoUuTien.EditValue = (int) DoUuTien.TrungBinh;
                cmbTrangThai.EditValue = (int) TrangThai.ChuaThucHien;
                cmbCongViecGoc.EditValue = ID_CongViec;
                m_iID_CongViec = ID_CongViec;
                chkLich.Checked = false;
                cmbNguoiGiaoViec.EditValue = GlobalVariables.GetID_NhanSu();
                cmbNhanVien.EditValue = GlobalVariables.GetID_NhanSu();

                //LoadcmbLoaiCV(ID_CongViec);
                //cmbCongViecGoc.EditValue = dt.Rows[0]["ID_LoaiCV"];
            }
            else
            {
                Loadcmbs();
                cmbDonViTG.SelectedIndex = (int) DonViTG.Ngay;
                cmbDoUuTien.EditValue = (int) DoUuTien.TrungBinh;
                cmbTrangThai.EditValue = (int) TrangThai.ChuaThucHien;
                cmbLoaiCongViec.EditValue = -ID_CongViec;
                txtLoaiCV.Text = cmbCongViecGoc.SelectedText;
                m_iID_CongViec = ID_CongViec;
                chkLich.Checked = false;
                cmbNguoiGiaoViec.EditValue = GlobalVariables.GetID_NhanSu();
                cmbNhanVien.EditValue = GlobalVariables.GetID_NhanSu();
            }
        }

        public frmCongViec(int ID_CongViec, int ID_NhanSu, DateTime Ngay_YeuCau)
        {
            IsSaved = false;
            InitializeComponent();
            InitCellStyles();
            lblComment.Font = new Font(lblComment.Font, FontStyle.Bold);
            lblThongTinChung.Font = new Font(lblComment.Font, FontStyle.Bold);
            Loadcmbs();
            cmbDonViTG.SelectedIndex = (int) DonViTG.Ngay;
            cmbDoUuTien.EditValue = (int) DoUuTien.TrungBinh;
            cmbTrangThai.EditValue = (int) TrangThai.ChuaThucHien;
            cmbCongViecGoc.EditValue = ID_CongViec;
            m_iID_CongViec = ID_CongViec;
            m_dNgay_YeuCau = Ngay_YeuCau;
            m_iID_NhanSu = ID_NhanSu;
            cmbNhanVien.EditValue = ID_NhanSu;
            chkLich.Checked = false;
        }

        public frmCongViec(int ID_CongViec, bool capNhat)
        {
            IsSaved = false;
            InitializeComponent();
            InitCellStyles();
            Loadcmbs();
            m_iID_CongViec = ID_CongViec;
            m_bCapNhat = capNhat;
            lblComment.Font = new Font(lblComment.Font, FontStyle.Bold);
            lblThongTinChung.Font = new Font(lblComment.Font, FontStyle.Bold);
            lblLapLai.Visible = false;
            //chkLapLai.Visible = false;
            //lblXemLai.Visible = false;
        }

        //public frmCongViec(int ID_CongViec, bool capNhat,bool lap)
        //{
        //    IsSaved = false;
        //    InitializeComponent();
        //    InitCellStyles();
        //    Loadcmbs();
        //    m_iID_CongViec = ID_CongViec;
        //    m_bCapNhat = capNhat;
        //    lblComment.Font = new Font(lblComment.Font, FontStyle.Bold);
        //    lblThongTinChung.Font = new Font(lblComment.Font, FontStyle.Bold);
        //    lblLapLai.Visible = false;
        //    chkLapLai.Visible = false;
        //    lblXemLai.Visible = false;
        //}

        public frmCongViec(int ID_CongViec, bool capNhat, bool thongBao)
        {
            IsSaved = false;
            InitializeComponent();
            InitCellStyles();
            Loadcmbs();
            m_iID_CongViec = ID_CongViec;
            m_bCapNhat = capNhat;
            btnLuu.Visible = false;
            btnLuuVaThoat.Visible = false;
            lblComment.Font = new Font(lblComment.Font, FontStyle.Bold);
            lblThongTinChung.Font = new Font(lblComment.Font, FontStyle.Bold);
            lblLapLai.Visible = false;
            chkLapLai.Visible = false;
            lblXemLai.Visible = false;
        }

        #endregion Constructor

        #region Form upload file

        protected override void OnLoad(EventArgs e)
        {
            var frm = new frmUploadFileShow(m_bQuyenCapNhat, FTP_FilesManager.FTP_PhanMem.QuanLyCongViec,
                FTP_FilesManager.FTP_FileType_Group.QLCV, FTP_FilesManager.FTP_FileType.All, m_iID_CongViec.ToString());
            frm.sFilterEdit_FileType = ((int) FTP_FilesManager.FTP_FileType.TaiLieuChung).ToString();
            OpenForm(grbTaiLieu, frm);
            base.OnLoad(e);
        }

        private void OpenForm(ucGroupBox gb, FormBase frm)
        {
            gb.Controls.Clear();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            gb.Controls.Add(frm);
        }

        #endregion Form upload file

        #region Button Events

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (frm != null)
                frm.Close();
            if (frmCanhBao != null) frmCanhBao.Close();
            Close();
        }

        private void btnLuuVaThoat_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            SaveData();
            Close();
            if (frm != null)
                frm.Close();
            if (frmCanhBao != null) frmCanhBao.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            SaveData();
        }

        private void btnLichSu_Click(object sender, EventArgs e)
        {
            var iD_CongViec = m_iID_CongViec;
            var strMa_CongViec = txtMaCV.Text;
            var lichSu = new frmCongViec_LichSu(iD_CongViec, strMa_CongViec);
            lichSu.ShowDialog();
        }

        #endregion Button Events

        #region Validate and save data

        private bool IsValid()
        {
            if (txtTieuDe.Text.Trim() == "")
            {
                BaseMessages.ShowWarningMessage("Chưa nhập tiêu đề công việc.");
                txtTieuDe.Focus();
                return false;
            }
            return true;
        }

        private void SaveData()
        {
            var nhanvien = string.Empty;
            var ds_thongbao = string.Empty;
            var cls = new clsCongViec();
            //cls.ID_LoaiCV = (cmbLoaiCongViec.EditValue ?? "").ToString() == ""
            //    ? SqlInt32.Null
            //    : Convert.ToInt32(cmbLoaiCongViec.EditValue);
            if (m_iIDLoaiCV == 0 && txtLoaiCV.Text != "")
            {
                var clsLoaiCV = new clsDM_LoaiCV();

                m_iIDLoaiCV = clsLoaiCV.Select_LoaiCongViec_By_Ten_Loai_CongViec(txtLoaiCV.Text);
            }
            cls.ID_LoaiCV = m_iIDLoaiCV;
            if (m_iIDLoaiCV == 0) cls.ID_LoaiCV = SqlInt32.Null;
            cls.ID_CongViec_Goc = (cmbCongViecGoc.EditValue ?? "").ToString() == ""
                ? SqlInt32.Null
                : Convert.ToInt32(cmbCongViecGoc.EditValue);
            cls.ID_MucDoUuTien = (cmbDoUuTien.EditValue ?? "").ToString() == ""
                ? SqlInt32.Null
                : Convert.ToInt32(cmbDoUuTien.EditValue);
            var ID_NhanVien = (cmbNhanVien.EditValue ?? "").ToString() == ""
                ? SqlInt32.Null
                : Convert.ToInt32(cmbNhanVien.EditValue);

            nhanvien = cmbNguoiThucHien.Properties.GetCheckedItems().ToString();

            if (ID_NhanVien.ToString() == "")
            {
                cls.DS_ID_NhanVien = "";
            }
            else
            {
                if (ID_NhanVien.ToString() == "Null" && nhanvien != "")
                    cls.DS_ID_NhanVien = nhanvien;
                else if (ID_NhanVien.ToString() != "Null" && nhanvien != "")
                    cls.DS_ID_NhanVien = ID_NhanVien + "," + nhanvien;
                else if (ID_NhanVien.ToString() != "Null" && nhanvien == "")
                    cls.DS_ID_NhanVien = ID_NhanVien.ToString();
                else
                    cls.DS_ID_NhanVien = "";
            }

            cls.MoTa = txtMoTa.Text.Trim();
            cls.TieuDe = txtTieuDe.Text.Trim() == "" ? SqlString.Null : txtTieuDe.Text.Trim();
            cls.ID_NguoiYeuCau = (cmbNguoiGiaoViec.EditValue ?? "").ToString() == ""
                ? SqlInt32.Null
                : Convert.ToInt32(cmbNguoiGiaoViec.EditValue);

            cls.Ngay_BatDau = dtNgayBatDau.Value == DBNull.Value || dtNgayBatDau.Value.ToString() == ""
                ? SqlDateTime.Null
                : Convert.ToDateTime(dtNgayBatDau.Value);
            cls.Ngay_HoanThanh = dtNgayHT.Value == DBNull.Value || dtNgayHT.Value.ToString() == ""
                ? SqlDateTime.Null
                : Convert.ToDateTime(dtNgayHT.Value);
            cls.Ngay_DenHan = dtNgayDenHan.Value == DBNull.Value || dtNgayDenHan.Value.ToString() == ""
                ? SqlDateTime.Null
                : Convert.ToDateTime(dtNgayDenHan.Value);
            cls.Ngay_YeuCau = dtNgayYeuCau.Value == DBNull.Value || dtNgayYeuCau.Value.ToString() == ""
                ? SqlDateTime.Null
                : Convert.ToDateTime(dtNgayYeuCau.Value);
            cls.ID_ThoiGian = short.Parse(cmbDonViTG.SelectedValue.ToString());
            cls.ThoiGian_DuKien = (txtThoiGianDuKien.EditValue ?? "").ToString() == ""
                ? SqlDecimal.Null
                : Math.Round(Convert.ToDecimal(txtThoiGianDuKien.EditValue), 2);
            cls.PhanTramHoanThanh = (txtPhanTramHT.EditValue ?? "").ToString() == ""
                ? SqlDecimal.Null
                : Math.Round(Convert.ToDecimal(txtPhanTramHT.EditValue), 2);
            cls.ID_TrangThai = Convert.ToInt32(cmbTrangThai.EditValue);
            cls.DiaDiem = txtDiaDiem.Text.Trim();
            m_strNguoiNhan = cls.DS_ID_NhanVien.ToString();
            cls.HienThiTrenLich = chkLich.Checked ? true : false;
            cls.LoaiThongBao = ds_thongbao;
            cls.SoLuong_KeHoach = decimal.Parse(txtKhoiLuong.Text);
            if (txtKhoiLuong.Text != "0")
            {
                txtPhanTramHT.Properties.ReadOnly = true;
                var TT = TinhTongKQ();
                cls.PhanTramHoanThanh = Math.Round(TT / decimal.Parse(txtKhoiLuong.Text) * 100, 2);
            }
            if (m_bCapNhat == false) //Insert
            {
                cls.TonTai = true;
                cls.Ngay_Lap = GlobalVariables.GetCurrentDateTime();
                cls.ID_NguoiLap = GlobalVariables.GetID_NhanSu();
                if (frm != null && frm.thongSo[0].ToString() == "" && frm.thongSo[1].ToString() == "" &&
                    frm.thongSo[2].ToString() == "")
                    chkLapLai.Checked = false;
                if (chkLapLai.Checked)
                    cls.LapLai = true;
                else
                    cls.LapLai = false;
                cls.Insert();
                cls.Ma_CongViec = "M10_" + cls.ID_CongViec;
                cls.Update();
                m_strMa_CongViec = cls.Ma_CongViec.ToString();
                SaveDataLichSu(int.Parse(cls.ID_CongViec.ToString()));
                SaveDataComment(int.Parse(cls.ID_CongViec.ToString()));
                SaveCongViec_KetQua(int.Parse(cls.ID_CongViec.ToString()));
                Update_FileUpload(cls.ID_CongViec.ToString()); //comment ftp
                if (chkLapLai.Checked)
                {
                    SaveCongViec_ThongSo(int.Parse(cls.ID_CongViec.ToString()));
                    SaveDataCongViecCon(int.Parse(cls.ID_CongViec.ToString()));
                }
                else
                {
                    var clsThongSo = new clsCongViec_ThongSo();
                    clsThongSo.DeleteByID_CongViec(m_iID_CongViec);
                }
                if (isChinhSuaCanhBao)
                {
                }
                else
                {
                    var cls_ThongBao = new clsCongViec_ThongBao();
                    cls_ThongBao.ID_CongViec = m_iID_CongViec;
                    for (var i = 0; i < frmCanhBao.id_LoaiThongBao.Length; ++i)
                    {
                        if (frmCanhBao.id_LoaiThongBao[i].ToString() == "0") break;
                        cls_ThongBao.ID_LoaiThongBao = frmCanhBao.id_LoaiThongBao[i];
                        cls_ThongBao.ID_ThoiGian = frmCanhBao.id_ThoiGian[i];
                        cls_ThongBao.ThoiGian_BaoTruoc = frmCanhBao.thoigian[i];
                        cls_ThongBao.Insert();
                    }
                }
                BaseMessages.ShowInformationMessage("Thêm mới thành công!");
                ResetTextBoxs();
            }
            else //update
            {
                cls.TonTai = true;
                cls.ID_NguoiLap = m_ID_Nguoi_Lap;
                cls.Ngay_Lap = m_daNgay_Lap;
                cls.Ngay_SuaCuoi = GlobalVariables.GetCurrentDateTime();
                cls.ID_NguoiSuaCuoi = GlobalVariables.GetID_NhanSu();
                cls.ID_CongViec = m_iID_CongViec;
                cls.Ma_CongViec = "M10_" + cls.ID_CongViec;
                if (cmbTrangThai.Text == "Đã xong")
                    if (!KiemTraCongViecConDaHoanThanhHetChua(int.Parse(cls.ID_CongViec.ToString())))
                    {
                        BaseMessages.ShowWarningMessage("Công việc con chưa hoàn thành xong!");
                        return;
                    }
                if (frm != null && frm.thongSo[0].ToString() == "" && frm.thongSo[1].ToString() == "" &&
                    frm.thongSo[2].ToString() == "")
                    chkLapLai.Checked = false;
                if (chkLapLai.Checked)
                {
                    cls.LapLai = true;
                    SaveCongViec_ThongSo(int.Parse(cls.ID_CongViec.ToString()));
                    //cls.DeleteAll_CongViec_By_ID_CongViecGoc(int.Parse(cls.ID_CongViec.ToString()));
                    //SaveDataCongViecCon(int.Parse(cls.ID_CongViec.ToString()));
                }
                else
                {
                    cls.LapLai = false;
                    var clsThongSo = new clsCongViec_ThongSo();
                    clsThongSo.DeleteByID_CongViec(m_iID_CongViec);
                }
                cls.Update();
                m_strMa_CongViec = cls.Ma_CongViec.ToString();
                SaveDataLichSu(int.Parse(cls.ID_CongViec.ToString()));
                SaveDataComment(int.Parse(cls.ID_CongViec.ToString()));
                SaveCongViec_KetQua(int.Parse(cls.ID_CongViec.ToString()));
                Update_FileUpload(cls.ID_CongViec.ToString());
                if (isChinhSuaCanhBao)
                {
                }
                else
                {
                    var cls_ThongBao = new clsCongViec_ThongBao();
                    cls_ThongBao.ID_CongViec = m_iID_CongViec;
                    var temp = cls_ThongBao.Select_ID_CongViec(m_iID_CongViec);
                    if (temp.Rows.Count == 0)
                    {
                        for (var i = 0; i < frmCanhBao.id_LoaiThongBao.Length; ++i)
                        {
                            if (frmCanhBao.id_LoaiThongBao[i].ToString() == "0") break;
                            cls_ThongBao.ID_LoaiThongBao = frmCanhBao.id_LoaiThongBao[i];
                            cls_ThongBao.ID_ThoiGian = frmCanhBao.id_ThoiGian[i];
                            cls_ThongBao.ThoiGian_BaoTruoc = frmCanhBao.thoigian[i];
                            cls_ThongBao.Insert();
                        }
                    }
                    else
                    {
                        var id_CongViecThongBao = int.Parse(temp.Rows[0]["ID_CongViec_ThongBao"].ToString());
                        //Xoa CongViec_ThongBao cũ
                        foreach (DataRow dr in temp.Rows)
                        {
                            var id_CV_TBao = int.Parse(dr["ID_CongViec_ThongBao"].ToString());
                            cls_ThongBao.ID_CongViec_ThongBao = id_CV_TBao;
                            cls_ThongBao.Delete();
                        }
                        for (var i = 0; i < frmCanhBao.id_LoaiThongBao.Length; ++i)
                        {
                            if (frmCanhBao.id_LoaiThongBao[i].ToString() == "0") break;
                            cls_ThongBao.ID_LoaiThongBao = frmCanhBao.id_LoaiThongBao[i];
                            cls_ThongBao.ID_ThoiGian = frmCanhBao.id_ThoiGian[i];
                            cls_ThongBao.ThoiGian_BaoTruoc = frmCanhBao.thoigian[i];
                            cls_ThongBao.Insert();
                        }
                    }
                }
                BaseMessages.ShowInformationMessage("Cập nhật thành công!");
            }
            SaveNotification(int.Parse(cls.ID_CongViec.ToString()), cls.TieuDe.ToString(),
                cls.DS_ID_NhanVien.ToString(), m_bCapNhat, m_iID_TrangThaiCu, int.Parse(cls.ID_TrangThai.ToString()));
            IsSaved = true;
            Update_PhanTramHoanThanh_CongViecCha(int.Parse(cls.ID_CongViec.ToString()));

            if (m_frmQLTD != null) m_frmQLTD.LoadData();
            //return true;
        }

        /// <summary>
        ///     Lưu thông báo công việc con theo cấu hình của công việc cha
        /// </summary>
        /// <param name="iID_CongViec">ID_CongViec</param>
        private void SaveCongViec_ThongBao(int iID_CongViec)
        {
            var cls = new clsCongViec_ThongBao();
            cls.ID_CongViec = iID_CongViec;
            var dt = cls.Select_ID_CongViec(iID_CongViec);
            if (dt.Rows.Count > 0)
                for (var i = 0; i < frmCanhBao.id_LoaiThongBao.Length; ++i)
                {
                    if (frmCanhBao.id_LoaiThongBao[i].ToString() == "0") break;
                    cls.ID_LoaiThongBao = frmCanhBao.id_LoaiThongBao[i];
                    cls.ID_ThoiGian = frmCanhBao.id_ThoiGian[i];
                    cls.ThoiGian_BaoTruoc = frmCanhBao.thoigian[i];
                    cls.Insert();
                }
        }

        private void SaveNotification(int ID_CongViec, string TieuDe, string nguoiNhan, bool bCapNhat,
            int ID_TrangThaiCu, int ID_TrangThai)
        {
            bCapNhat = m_bCapNhat;
            var thongBao = new clsThongBao();
            thongBao.Ngay_Gui = GlobalVariables.GetCurrentDateTime();
            thongBao.TaiKhoan_Gui = short.Parse(GlobalVariables.GetID_NhanSu().ToString(CultureInfo.InvariantCulture));
            thongBao.TaiKhoan_Nhan = nguoiNhan;
            thongBao.Ten_ChucNang_ThongBao = "frmCongViec";
            thongBao.ID_CongViec = ID_CongViec;
            thongBao.TrangThai = 1;
            if (bCapNhat == false)
            {
                thongBao.NoiDung = GlobalVariables.Get_HoTen_NhanSu() + " đã thêm mới công việc : " + TieuDe;
            }
            else
            {
                if (ID_TrangThaiCu != 3 && ID_TrangThai == 3)
                    thongBao.NoiDung = GlobalVariables.Get_HoTen_NhanSu() + " đã hoàn thành công việc : " + TieuDe;
                else
                    thongBao.NoiDung = GlobalVariables.Get_HoTen_NhanSu() + " đã cập nhật công việc : " + TieuDe;
            }
            thongBao.Insert();
        }

        private void SaveCommentNotification(int ID_CongViec, string Ma_CongViec, string nguoiNhan, string IsEdit)
        {
            var thongBao = new clsThongBao();
            thongBao.Ngay_Gui = GlobalVariables.GetCurrentDateTime();
            thongBao.TaiKhoan_Gui = short.Parse(GlobalVariables.GetID_NhanSu().ToString(CultureInfo.InvariantCulture));
            thongBao.TaiKhoan_Nhan = nguoiNhan;
            thongBao.Ten_ChucNang_ThongBao = "frmCongViec_Comment";
            thongBao.ID_CongViec = ID_CongViec;
            thongBao.TrangThai = 1;

            if (IsEdit == "0")
                thongBao.NoiDung = GlobalVariables.Get_HoTen_NhanSu() + " đã xóa bình luận ở công việc có mã là: " +
                                   Ma_CongViec;
            else if (IsEdit == "1")
                thongBao.NoiDung = GlobalVariables.Get_HoTen_NhanSu() + " đã bình luận ở công việc có mã là: " +
                                   Ma_CongViec;
            else if (IsEdit == "2")
                thongBao.NoiDung = GlobalVariables.Get_HoTen_NhanSu() +
                                   " đã thay đổi bình luận ở công việc có mã là: " + Ma_CongViec;

            thongBao.Insert();
        }

        private bool IsValidComment()
        {
            for (var i = fgComment.Rows.Fixed; i < fgComment.Rows.Count; i++)
                if (fgComment.GetDataDisplay(i, "NoiDung").ToLower().Trim() == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập nội dung comment");
                    return false;
                }
            return true;
        }

        private bool IsValidKetQua()
        {
            for (var i = fgKetQua.Rows.Fixed; i < fgKetQua.Rows.Count; i++)
            {
                if (fgKetQua.GetDataDisplay(i, "NoiDung").ToLower().Trim() == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập nội dung !!!");
                    return false;
                }

                if (fgKetQua.GetDataDisplay(i, "GiaTri") == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập giá trị dòng " + i + " !");
                    return false;
                }
                if (fgKetQua.GetDataDisplay(i, "Ngay_BatDau") == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập ngày bắt đầu dòng " + i + " !");
                    return false;
                }
                if (fgKetQua.GetDataDisplay(i, "Ngay_HoanThanh") == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập ngày hoàn thành dòng " + i + " !");
                    return false;
                }
            }
            return true;
        }

        private void SaveDataComment(int ID_CongViec)
        {
            //if (!IsValidComment()) return;

            var cls = new clsCongViec_Comment();
            cls.ID_CongViec = ID_CongViec;
            cls.TonTai = true;
            for (var i = fgComment.Rows.Fixed; i < fgComment.Rows.Count; i++)
            {
                if (fgComment.GetDataDisplay(i, "IsEdit") == "") continue;
                cls.ID_CongViec = ID_CongViec;
                cls.Ngay_Lap = GlobalVariables.GetCurrentDateTime();
                cls.ID_TaiKhoan = GlobalVariables.GetID_NhanSu();
                cls.NoiDung = fgComment.GetDataDisplay(i, "NoiDung");
                cls.DaDoc = false;
                if (fgComment.GetDataDisplay(i, "IsEdit") == "0")
                {
                    cls.ID_CongViec = Convert.ToInt32(fgComment[i, "ID_CongViec"]);
                    cls.SelectOne();
                    cls.TonTai = false;
                    cls.Update();
                    SaveCommentNotification(ID_CongViec, m_strMa_CongViec, m_strNguoiNhan,
                        fgComment.GetDataDisplay(i, "IsEdit"));
                }
                else if (fgComment.GetDataDisplay(i, "IsEdit") == "1")
                {
                    if (fgComment.GetDataDisplay(i, "ID_CongViec") == "")
                    {
                        cls.Insert();
                        SaveCommentNotification(ID_CongViec, m_strMa_CongViec, m_strNguoiNhan, "1");
                    }
                    else
                    {
                        cls.ID_Comment = Convert.ToInt32(fgComment[i, "ID_Comment"]);
                        cls.Update();
                        SaveCommentNotification(ID_CongViec, m_strMa_CongViec, m_strNguoiNhan, "2");
                    }
                }
            }
        }

        private void SaveCongViec_KetQua(int ID_CongViec)
        {
            //if (!IsValidKetQua()) return;

            var cls = new clsCongViec_KetQua();
            cls.ID_CongViec = ID_CongViec;

            for (var i = fgKetQua.Rows.Fixed; i < fgKetQua.Rows.Count; i++)
            {
                if (fgKetQua.GetDataDisplay(i, "IsEdit") == "") continue;
                cls.ID_CongViec = ID_CongViec;
                cls.Ngay_Lap = GlobalVariables.GetCurrentDateTime();
                cls.ID_NguoiLap = GlobalVariables.GetID_NhanSu();
                cls.NoiDung = fgKetQua.GetDataDisplay(i, "NoiDung");
                cls.Ngay_BatDau = DateTime.Parse(fgKetQua.GetDataDisplay(i, "Ngay_BatDau"));
                cls.Ngay_HoanThanh = DateTime.Parse(fgKetQua.GetDataDisplay(i, "Ngay_HoanThanh"));
                var strGiaTri = fgKetQua.GetDataDisplay(i, "GiaTri");
                if (fgKetQua.GetDataDisplay(i, "IsEdit") == "0")
                {
                    cls.ID_CongViec_KetQua = Convert.ToInt32(fgKetQua[i, "ID_CongViec_KetQua"]);
                    cls.Delete();
                }
                else if (fgKetQua.GetDataDisplay(i, "IsEdit") == "1")
                {
                    if (fgKetQua.GetDataDisplay(i, "ID_CongViec_KetQua") == "")
                    {
                        if (strGiaTri != "")
                            cls.GiaTri = decimal.Parse(strGiaTri);
                        else
                            cls.GiaTri = SqlDecimal.Null;
                        cls.ID_DonVi_KetQua = int.Parse("0" + fgKetQua[i, "ID_DonVi_KetQua"]);
                        cls.Insert();
                    }
                    else
                    {
                        cls.ID_CongViec_KetQua = Convert.ToInt32(fgKetQua[i, "ID_CongViec_KetQua"]);
                        //cls.GiaTri = decimal.Parse(strGiaTri);
                        if (strGiaTri != "")
                            cls.GiaTri = decimal.Parse(strGiaTri);
                        else
                            cls.GiaTri = SqlDecimal.Null;
                        cls.ID_DonVi_KetQua = int.Parse("0" + fgKetQua[i, "ID_DonVi_KetQua"]);
                        cls.Update();
                    }
                }
            }
        }

        private void SaveDataLichSu(int ID_CongViec)
        {
            var cls = new clsCongViec();
            cls.ID_CongViec = ID_CongViec;
            var dt = cls.SelectOne();
            var lichSu = new clsCongViec_LichSu();

            lichSu.ID_CongViec = int.Parse(dt.Rows[0]["ID_CongViec"].ToString());
            lichSu.Ma_CongViec = dt.Rows[0]["Ma_CongViec"].ToString();
            lichSu.DS_ID_NhanVien = dt.Rows[0]["DS_ID_NhanVien"].ToString();
            if (dt.Rows[0]["ID_MucDoUuTien"].ToString() != "")
                lichSu.ID_MucDoUuTien = int.Parse(dt.Rows[0]["ID_MucDoUuTien"].ToString());

            lichSu.TieuDe = dt.Rows[0]["TieuDe"].ToString();
            lichSu.MoTa = dt.Rows[0]["MoTa"].ToString();
            if (dt.Rows[0]["Ngay_YeuCau"].ToString() != "")
                lichSu.Ngay_YeuCau = DateTime.Parse(dt.Rows[0]["Ngay_YeuCau"].ToString());
            if (dt.Rows[0]["Ngay_DenHan"].ToString() != "")
                lichSu.Ngay_DenHan = DateTime.Parse(dt.Rows[0]["Ngay_DenHan"].ToString());
            if (dt.Rows[0]["ThoiGian_DuKien"].ToString() != "")
                lichSu.ThoiGian_DuKien = decimal.Parse(dt.Rows[0]["ThoiGian_DuKien"].ToString());
            if (dt.Rows[0]["ID_ThoiGian"].ToString() != "")
                lichSu.ID_ThoiGian = short.Parse(dt.Rows[0]["ID_ThoiGian"].ToString());

            if (dt.Rows[0]["Ngay_BatDau"].ToString() != "")
                lichSu.Ngay_BatDau = DateTime.Parse(dt.Rows[0]["Ngay_BatDau"].ToString());
            if (dt.Rows[0]["Ngay_HoanThanh"].ToString() != "")
                lichSu.Ngay_HoanThanh = DateTime.Parse(dt.Rows[0]["Ngay_HoanThanh"].ToString());
            if (dt.Rows[0]["PhanTramHoanThanh"].ToString() != "")
                lichSu.PhanTramHoanThanh = decimal.Parse(dt.Rows[0]["PhanTramHoanThanh"] + "0");
            if (dt.Rows[0]["ID_TrangThai"].ToString() != "")
                lichSu.ID_TrangThai = int.Parse(dt.Rows[0]["ID_TrangThai"].ToString());
            if (dt.Rows[0]["ID_LoaiCV"].ToString() != "")
                lichSu.ID_LoaiCV = int.Parse(dt.Rows[0]["ID_LoaiCV"].ToString());

            if (dt.Rows[0]["ID_CongViec_Goc"].ToString() != "")
                lichSu.ID_CongViec_Goc = int.Parse(dt.Rows[0]["ID_CongViec_Goc"].ToString());

            if (dt.Rows[0]["Ngay_Lap"].ToString() != "")
                lichSu.Ngay_Lap = DateTime.Parse(dt.Rows[0]["Ngay_Lap"].ToString());
            if (dt.Rows[0]["ID_NguoiLap"].ToString() != "")
                lichSu.ID_NguoiLap = int.Parse(dt.Rows[0]["ID_NguoiLap"].ToString());

            if (dt.Rows[0]["Ngay_SuaCuoi"].ToString() != "")
                lichSu.Ngay_SuaCuoi = DateTime.Parse(dt.Rows[0]["Ngay_SuaCuoi"].ToString());
            if (dt.Rows[0]["ID_NguoiSuaCuoi"].ToString() != "")
                lichSu.ID_NguoiSuaCuoi = int.Parse(dt.Rows[0]["ID_NguoiSuaCuoi"].ToString());

            if (dt.Rows[0]["TonTai"].ToString() != "")
                lichSu.TonTai = bool.Parse(dt.Rows[0]["TonTai"].ToString());
            if (dt.Rows[0]["ID_NguoiYeuCau"].ToString() != "")
                lichSu.ID_NguoiYeuCau = int.Parse(dt.Rows[0]["ID_NguoiYeuCau"].ToString());

            lichSu.Insert();
        }

        private void SaveDataCongViecCon(int ID_CongViec)
        {
            var thu = "";
            var ngay = "";
            var thang = "";
            var tuNgay = "";
            var denNgay = "";

            int tuThang;
            int denThang;

            var thongSo = new clsCongViec_ThongSo();
            var dtts = thongSo.Select_ID_CongViec(ID_CongViec);
            var cls = new clsCongViec();
            if (dtts.Rows.Count > 0)
            {
                thu = dtts.Rows[0]["DS_Thu"].ToString();
                ngay = dtts.Rows[0]["DS_Ngay"].ToString();
                thang = dtts.Rows[0]["DS_Thang"].ToString();
            }
            if (thang != "" && ngay != "")
            {
                var ngayA = ngay.Split(',');
                tuNgay = ngayA[0];
                denNgay = ngayA[ngayA.Length - 1];
                var nam = DateTime.Now.Year.ToString();

                var thangA = thang.Split(',');
                tuThang = int.Parse(thangA[0]);
                denThang = int.Parse(thangA[thangA.Length - 1]);
                var IsLeapYear = DateTime.IsLeapYear(DateTime.Now.Year);
                for (var i = tuThang; i <= denThang; i++)
                {
                    cls.ID_CongViec = ID_CongViec;
                    var dt = cls.SelectOne();
                    var tuNgay2 = tuNgay;
                    var denNgay2 = denNgay;

                    switch (i)
                    {
                        case 2:
                            if (!IsLeapYear)
                            {
                                if (int.Parse(tuNgay) > 28)
                                    tuNgay2 = "28";
                                if (int.Parse(denNgay) > 28)
                                    denNgay2 = "28";

                                cls.Ngay_YeuCau = DateTime.Parse(tuNgay2 + "-" + i + "-" + nam);

                                cls.Ngay_DenHan = DateTime.Parse(denNgay2 + "-" + i + "-" + nam);
                            }
                            else
                            {
                                if (int.Parse(tuNgay) > 29)
                                    tuNgay2 = "29";
                                if (int.Parse(denNgay) > 29)
                                    denNgay2 = "29";

                                cls.Ngay_YeuCau = DateTime.Parse(tuNgay2 + "-" + i + "-" + nam);

                                cls.Ngay_DenHan = DateTime.Parse(denNgay2 + "-" + i + "-" + nam);
                            }
                            break;
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            if (int.Parse(tuNgay) > 31)
                                tuNgay2 = "31";
                            if (int.Parse(denNgay) > 31)
                                denNgay2 = "31";

                            cls.Ngay_YeuCau = DateTime.Parse(tuNgay2 + "-" + i + "-" + nam);

                            cls.Ngay_DenHan = DateTime.Parse(denNgay2 + "-" + i + "-" + nam);
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (int.Parse(tuNgay) > 30)
                                tuNgay2 = "30";
                            if (int.Parse(denNgay) > 30)
                                denNgay2 = "30";

                            cls.Ngay_YeuCau = DateTime.Parse(tuNgay2 + "-" + i + "-" + nam);

                            cls.Ngay_DenHan = DateTime.Parse(denNgay2 + "-" + i + "-" + nam);
                            break;
                    }

                    cls.ID_CongViec = int.Parse(dt.Rows[0]["ID_CongViec"].ToString());
                    cls.DS_ID_NhanVien = dt.Rows[0]["DS_ID_NhanVien"].ToString();
                    if (dt.Rows[0]["ID_MucDoUuTien"].ToString() != "")
                        cls.ID_MucDoUuTien = int.Parse(dt.Rows[0]["ID_MucDoUuTien"].ToString());

                    cls.TieuDe = dt.Rows[0]["TieuDe"] + " (" + "tháng " + i + ")";

                    cls.MoTa = dt.Rows[0]["MoTa"].ToString();

                    cls.ID_CongViec_Goc = ID_CongViec;
                    cls.LapLai = false;
                    cls.HienThiTrenLich = false;

                    if (dt.Rows[0]["Ngay_Lap"].ToString() != "")
                        cls.Ngay_Lap = DateTime.Parse(dt.Rows[0]["Ngay_Lap"].ToString());
                    if (dt.Rows[0]["ID_NguoiLap"].ToString() != "")
                        cls.ID_NguoiLap = int.Parse(dt.Rows[0]["ID_NguoiLap"].ToString());

                    if (dt.Rows[0]["Ngay_SuaCuoi"].ToString() != "")
                        cls.Ngay_SuaCuoi = DateTime.Parse(dt.Rows[0]["Ngay_SuaCuoi"].ToString());
                    if (dt.Rows[0]["ID_NguoiSuaCuoi"].ToString() != "")
                        cls.ID_NguoiSuaCuoi = int.Parse(dt.Rows[0]["ID_NguoiSuaCuoi"].ToString());

                    if (dt.Rows[0]["TonTai"].ToString() != "")
                        cls.TonTai = bool.Parse(dt.Rows[0]["TonTai"].ToString());
                    if (dt.Rows[0]["ID_NguoiYeuCau"].ToString() != "")
                        cls.ID_NguoiYeuCau = int.Parse(dt.Rows[0]["ID_NguoiYeuCau"].ToString());
                    cls.Insert();
                    cls.Ma_CongViec = "M10_" + cls.ID_CongViec;
                    cls.Update();
                }
            }
            if (thu != "")
            {
            }
        }

        private void SaveCV_Notification(int ID_CongViec, decimal thoiGian)
        {
            if (!m_bCapNhat)
            {
                var cls = new clsCongViec_ThongBao();
                cls.ID_CongViec = ID_CongViec;
                cls.ID_LoaiThongBao = 2;
                cls.ID_ThoiGian = 1;
                cls.ThoiGian_BaoTruoc = thoiGian;
                cls.Insert();
            }
            else
            {
                var cls = new clsCongViec_ThongBao();
                cls.ID_CongViec = ID_CongViec;
                var dt2 = cls.Select_ID_CongViec(ID_CongViec);
                if (dt2.Rows.Count > 0)
                {
                    cls.ID_CongViec_ThongBao = int.Parse(dt2.Rows[0]["ID_CongViec_ThongBao"].ToString());
                    cls.SelectOne();
                    cls.ID_CongViec = ID_CongViec;
                    cls.ID_LoaiThongBao = 2;
                    cls.ID_ThoiGian = 1;
                    cls.ThoiGian_BaoTruoc = thoiGian;
                    cls.Update();
                }
                else
                {
                    cls.ID_CongViec = ID_CongViec;
                    cls.ID_LoaiThongBao = 2;
                    cls.ID_ThoiGian = 1;
                    cls.ThoiGian_BaoTruoc = thoiGian;
                    cls.Insert();
                }
            }
        }

        private void Update_FileUpload(string ID_CongViec)
        {
            var cls = new clsFTP_Files();
            var dt = cls.Select_Files_JustUpload();
            if (dt.Rows.Count > 0)
                for (var i = 0; i < dt.Rows.Count; i++)
                {
                    cls.ID_Files = int.Parse(dt.Rows[i]["ID_Files"].ToString());
                    cls.SelectOne();
                    cls.FileIdentity = ID_CongViec;
                    cls.Update();
                }
        }

        private void SaveCongViec_ThongSo(int ID_CongViec)
        {
            if (isChinhSua)
                return;
            if (!m_bCapNhat)
            {
                //thêm
                InsertCongViec_ThongSo(ID_CongViec);
            }
            else
            {
                var congviec = new clsCongViec();
                congviec.ID_CongViec = ID_CongViec;
                var dt1 = congviec.SelectOne();

                if (dt1.Rows[0]["LapLai"].ToString() == "True")
                    UpdateCongViec_ThongSo(ID_CongViec);
                else
                    InsertCongViec_ThongSo(ID_CongViec);
            }
        }

        private void InsertCongViec_ThongSo(int iID_CongViec)
        {
            var cls = new clsCongViec_ThongSo();
            cls.ID_CongViec = iID_CongViec;
            var DS_Thu = frm.thongSo[0].ToString();
            var DS_Ngay = frm.thongSo[1].ToString();
            var DS_Thang = frm.thongSo[2].ToString();
            var thu = "";
            var ngay = "";
            var thang = "";
            if (DS_Ngay != "")
                if (DS_Ngay.Contains(":"))
                {
                    var ngayA = DS_Ngay.Split(':');

                    for (var i = int.Parse(ngayA[0]); i <= int.Parse(ngayA[1]); i++)
                        ngay += i + ",";
                    ngay = ngay.Remove(ngay.Length - 1);
                }
                else
                {
                    ngay = DS_Ngay;
                }
            else
                ngay = DS_Ngay;
            if (DS_Thang != "")
                if (DS_Thang.Contains(":"))
                {
                    var thangA = DS_Thang.Split(':');

                    for (var i = int.Parse(thangA[0]); i <= int.Parse(thangA[1]); i++)
                        thang += i + ",";
                    thang = thang.Remove(thang.Length - 1);
                }
                else
                {
                    thang = DS_Thang;
                }
            else
                thang = DS_Thang;
            if (DS_Thu != "")
                thu = DS_Thu.Remove(DS_Thu.Length - 1);
            else
                thu = DS_Thu;

            cls.ID_CongViec = iID_CongViec;
            cls.DS_Thu = thu;
            cls.DS_Ngay = ngay;
            cls.DS_Thang = thang;
            cls.Gio_BatDau = DateTime.Parse(frm.thongSo[3].ToString());
            cls.Gio_KetThuc = DateTime.Parse(frm.thongSo[4].ToString());
            cls.Insert();
        }

        private void UpdateCongViec_ThongSo(int iID_CongViec)
        {
            var cls = new clsCongViec_ThongSo();
            cls.ID_CongViec = iID_CongViec;
            var dt2 = cls.Select_ID_CongViec(iID_CongViec);
            cls.ID_CongViec_ThongSo = int.Parse(dt2.Rows[0]["ID_CongViec_ThongSo"].ToString());
            cls.SelectOne();
            var DS_Thu = frm.thongSo[0].ToString();
            var DS_Ngay = frm.thongSo[1].ToString();
            var DS_Thang = frm.thongSo[2].ToString();
            var thu = "";
            var ngay = "";
            var thang = "";
            if (DS_Ngay != "")
                if (DS_Ngay.Contains(":"))
                {
                    var ngayA = DS_Ngay.Split(':');

                    for (var i = int.Parse(ngayA[0]); i <= int.Parse(ngayA[1]); i++)
                        ngay += i + ",";
                    ngay = ngay.Remove(ngay.Length - 1);
                }
                else
                {
                    ngay = DS_Ngay;
                }
            else
                ngay = DS_Ngay;
            if (DS_Thang != "")
                if (DS_Thang.Contains(":"))
                {
                    var thangA = DS_Thang.Split(':');

                    for (var i = int.Parse(thangA[0]); i <= int.Parse(thangA[1]); i++)
                        thang += i + ",";
                    thang = thang.Remove(thang.Length - 1);
                }
                else
                {
                    thang = DS_Thang;
                }
            else
                thang = DS_Thang;
            if (DS_Thu != "")
                thu = thu.Remove(thu.Length - 1);
            else
                thu = DS_Thu;
            cls.ID_CongViec = iID_CongViec;
            cls.DS_Thu = thu;
            cls.DS_Ngay = ngay;
            cls.DS_Thang = thang;
            cls.Gio_BatDau = DateTime.Parse(frm.thongSo[3].ToString());
            cls.Gio_KetThuc = DateTime.Parse(frm.thongSo[4].ToString());
            cls.Update();
        }

        #endregion Validate and save data

        #region Load Combobox

        private void LoadcmbLoaiCV()
        {
            var cmb = cmbLoaiCongViec;
            cmb.Tag = 0;
            var cls = new clsDM_LoaiCV();
            var dt = cls.SelectAll();
            dt.DefaultView.Sort = "ID_LoaiCV ASC";
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_LoaiCV";
            cmb.Properties.ValueMember = "ID_LoaiCV";
            if (dt.DefaultView.ToTable().Rows.Count == 1) cmb.EditValue = dt.DefaultView.ToTable().Rows[0]["ID_LoaiCV"];
            else cmb.EditValue = null;
            cmb.Tag = 1;
        }
        
        private void LoadcmbNguoiGiaoViec()
        {
            var cmb = cmbNguoiGiaoViec;
            cmb.Tag = 0;
            var cls = new clsNhanSu();
            var dt = cls.GetNhanSu(SystemModule.HeThong.GlobalVariables.uID_DonVi, 0);
            dt.DefaultView.RowFilter = "TrangThai_DiLam = 'Đang đi làm'";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Tag = 1;
        }

        private void LoadcmbNhanVien()
        {
            var cmb = cmbNhanVien;
            cmb.Tag = 0;
            var cls = new clsNhanSu();
            var dt = cls.GetNhanSu(SystemModule.HeThong.GlobalVariables.uID_DonVi, 0);
            dt.DefaultView.RowFilter = "TrangThai_DiLam = 'Đang đi làm'";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Tag = 1;
        }

        private void LoadcmbCungThucHien()
        {
            if ((cmbNhanVien.EditValue ?? "").ToString() == "")
            {
                cmbNguoiThucHien.Properties.DataSource = null;
                cmbNguoiThucHien.EditValue = null;
                return;
            }
            var cmb = cmbNguoiThucHien;
            cmb.Tag = 0;
            var cls = new clsNhanSu();
            var dt = cls.GetNhanSu(SystemModule.HeThong.GlobalVariables.uID_DonVi, 0);
            dt.DefaultView.RowFilter = "ID_NhanSu <>" + cmbNhanVien.EditValue + " AND TrangThai_DiLam = 'Đang đi làm'";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Properties.SeparatorChar = ',';
            cmb.Tag = 1;
        }

        private void LoadcmbMucDo()
        {
            var cmb = cmbDoUuTien;
            cmb.Tag = 0;
            var cls = new clsDM_MucDoUuTien();
            var dt = cls.SelectAll();
            dt.DefaultView.Sort = "STT_MucDo ASC";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_MucDo";
            cmb.Properties.ValueMember = "ID_MucDoUuTien";
            cmb.Tag = 1;
        }

        private void LoadcmbTrangThai()
        {
            var cmb = cmbTrangThai;
            cmb.Tag = 0;
            var cls = new clsDM_TrangThai();
            var dt = cls.SelectAll();
            dt.DefaultView.Sort = "ID_TrangThai ASC";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_TrangThai";
            cmb.Properties.ValueMember = "ID_TrangThai";
            cmb.Tag = 1;
        }

        private void LoadcmbCongViecGoc()
        {
            var cmb = cmbCongViecGoc;
            cmb.Tag = 0;
            var cls = new clsCongViec();
            var dt = cls.SelectAll();
            cmb.Properties.DataSource = dt.DefaultView.ToTable();
            cmb.Properties.DisplayMember = "TieuDe";
            cmb.Properties.ValueMember = "ID_CongViec";
            cmb.Properties.BestFitMode = BestFitMode.BestFitResizePopup;
            cmb.Tag = 1;
        }
        
        private void LoadcmbThoiGian()
        {
            var cmb = cmbDonViTG;
            cmb.Tag = 0;
            cmb.ClearItems();
            var cls = new clsDM_ThoiGian();
            var dt = cls.SelectAll();
            cmb.SetDataSource(dt, "ID_ThoiGian", "Ten_ThoiGian");
            cmb.ColumnWidth = 0;
            cmb.Tag = 1;
        }

        private void Loadcmbs()
        {
            LoadcmbLoaiCV();
            LoadcmbMucDo();
            LoadcmbTrangThai();
            LoadcmbThoiGian();
            LoadcmbCongViecGoc();
            LoadcmbNguoiGiaoViec();
            LoadcmbNhanVien();
        }

        #endregion Load Combobox

        #region MyRegion

        private void ResetTextBoxs()
        {
            cmbLoaiCongViec.EditValue = null;
            txtLoaiCV.Text = "";
            cmbCongViecGoc.EditValue = null;
            txtMoTa.Text = "";
            txtPhanTramHT.EditValue = null;
            txtThoiGianDuKien.EditValue = null;
            txtTieuDe.Text = "";
            dtNgayBatDau.Value = GlobalVariables.GetCurrentDateTime();
            dtNgayHT.Value = DBNull.Value;
            dtNgayDenHan.Value = DBNull.Value;
            cmbDoUuTien.EditValue = (int) DoUuTien.TrungBinh;
        }

        private void txtPhanTramHT_EditValueChanged(object sender, EventArgs e)
        {
            var phantramhoanthanh = 0;
            int.TryParse(txtPhanTramHT.Text, out phantramhoanthanh);
            if (phantramhoanthanh > 100) txtPhanTramHT.EditValue = 100;
            if ((txtPhanTramHT.EditValue ?? "").ToString() != "")
            {
                if (Convert.ToInt32(txtPhanTramHT.EditValue) == 100)
                {
                    cmbTrangThai.EditValue = (int) TrangThai.DaHoanThanh;
                    //if (dtNgayHT.Value == DBNull.Value || dtNgayHT.Value.ToString() == "")
                    //{
                    //    dtNgayHT.Value = GlobalVariables.GetCurrentDateTime();
                    //}
                    if (dtNgayHT.Value.ToString() == "")
                        dtNgayHT.Value = GlobalVariables.GetCurrentDateTime();
                }
                else if (Convert.ToInt32(txtPhanTramHT.EditValue) >= 0 &&
                         Convert.ToInt32(txtPhanTramHT.EditValue) < 100)
                {
                    cmbTrangThai.EditValue = (int) TrangThai.DangThucHien;
                    dtNgayHT.Value = DBNull.Value;
                }
            }
            else
            {
                dtNgayHT.Value = DBNull.Value;
            }
            //

            // rang buoc

            if (phantramhoanthanh > 0 && phantramhoanthanh < 100)
                cmbTrangThai.EditValue = 2;
            if (phantramhoanthanh == 100)
                cmbTrangThai.EditValue = 3;
        }

        private void txtPhanTramHT_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                txtPhanTramHT.EditValue = null;
        }

        private void txtThoiGianDuKien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                txtThoiGianDuKien.EditValue = null;
        }

        private void Load_fgComment()
        {
            var fg = fgComment;
            if (m_iID_CongViec == 0)
            {
                fg.Rows.Add(1);
                fg.Rows[1]["TenDayDu"] = GlobalVariables.Get_HoTen_NhanSu();
                fg.Rows[1]["Ngay_Lap"] = GlobalVariables.GetCurrentDateTime();
                fg.SetSTT();
                return;
            }
            fg.Tag = 0;
            fg.BeginUpdate();
            var cls = new clsCongViec_Comment();
            var dt = cls.Select_W_ID_CongViec(m_iID_CongViec);
            fg.ClearRows();
            fg.SetDataSource(dt);
            fg.SetSTT();
            fg.Row = -1;
            fg.AutoSizeRows();
            //if (dt.Rows.Count>0)
            //{
            //    for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            //    {
            //        fg[i, "Ten_NgayGui"] = GlobalVariables.TimeAgo(DateTime.Parse(fg.Rows[i]["Ngay_Gui"].ToString()));
            //    }
            //}
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void Load_fgKetQua()
        {
            var fg = fgKetQua;
            if (m_iID_CongViec == 0)
            {
                fg.Rows.Add(1);
                fg.Rows[1]["TenDayDu"] = GlobalVariables.Get_HoTen_NhanSu();
                fg.Rows[1]["Ngay_Lap"] = GlobalVariables.GetCurrentDateTime();
                fg.Rows[1]["Ngay_BatDau"] = GlobalVariables.GetCurrentDateTime();
                fg.Rows[1]["Ngay_HoanThanh"] = GlobalVariables.GetCurrentDateTime();
                fg.SetSTT();
                return;
            }
            fg.Tag = 0;
            fg.BeginUpdate();
            var cls = new clsCongViec_KetQua();
            var dt = cls.Select_W_ID_CongViec(m_iID_CongViec);
            fg.ClearRows();
            fg.SetDataSource(dt);
            fg.SetSTT();
            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void Load_fgLichSu()
        {
            var fg = fgLichSu;
            fg.Tag = 0;
            fg.BeginUpdate();
            var lichSu = new clsCongViec_LichSu();
            var dt = lichSu.Select_ID_CongViec(m_iID_CongViec);
            fg.ClearRows();
            fg.SetDataSource(dt);
            for (var i = 1; i < dt.Rows.Count; i++)
            {
                if (dt.Rows.Count == 1)
                    if (dt.Rows[i]["MoTa"].ToString().Trim().Length > 100)
                        fg[i, "MoTa"] = HelperMethods.TruncateString(fg.GetDataDisplay(i, "MoTa"), 100) + " ...";
                if (i < dt.Rows.Count - 1)
                {
                    if (dt.Rows[i]["MoTa"].ToString().Length > 100)
                    {
                        fg[i, "MoTa"] = HelperMethods.TruncateString(fg.GetDataDisplay(i, "MoTa"), 100) + " ...";
                        fg[i + 1, "MoTa"] = HelperMethods.TruncateString(fg.GetDataDisplay(i, "MoTa"), 100) + " ...";
                        fg[i + 2, "MoTa"] = HelperMethods.TruncateString(fg.GetDataDisplay(i, "MoTa"), 100) + " ...";
                    }
                    if (dt.Rows[i]["TieuDe"].ToString().ToLower() != dt.Rows[i - 1]["TieuDe"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["TieuDe"].Index, csThayDoi);
                    if (dt.Rows[i]["MoTa"].ToString().ToLower() != dt.Rows[i - 1]["MoTa"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["MoTa"].Index, csThayDoi);
                    if (dt.Rows[i]["Ngay_YeuCau"].ToString().ToLower() !=
                        dt.Rows[i - 1]["Ngay_YeuCau"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_YeuCau"].Index, csThayDoi);
                    if (dt.Rows[i]["Ngay_DenHan"].ToString().ToLower() !=
                        dt.Rows[i - 1]["Ngay_DenHan"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_DenHan"].Index, csThayDoi);
                    if (dt.Rows[i]["ThoiGian_DuKien"].ToString().ToLower() !=
                        dt.Rows[i - 1]["ThoiGian_DuKien"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["ThoiGian_DuKien"].Index, csThayDoi);
                    if (dt.Rows[i]["Ngay_BatDau"].ToString().ToLower() !=
                        dt.Rows[i - 1]["Ngay_BatDau"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_BatDau"].Index, csThayDoi);
                    if (dt.Rows[i]["Ngay_HoanThanh"].ToString().ToLower() !=
                        dt.Rows[i - 1]["Ngay_HoanThanh"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_HoanThanh"].Index, csThayDoi);
                    if (dt.Rows[i]["PhanTramHoanThanh"].ToString().ToLower() !=
                        dt.Rows[i - 1]["PhanTramHoanThanh"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["PhanTramHoanThanh"].Index, csThayDoi);
                    if (dt.Rows[i]["TenNguoiLap"].ToString().ToLower() !=
                        dt.Rows[i - 1]["TenNguoiLap"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["TenNguoiLap"].Index, csThayDoi);
                    if (dt.Rows[i]["Ngay_Lap"].ToString().ToLower() != dt.Rows[i - 1]["Ngay_Lap"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_Lap"].Index, csThayDoi);
                    if (dt.Rows[i]["TenNguoiSuaCuoi"].ToString().ToLower() !=
                        dt.Rows[i - 1]["TenNguoiSuaCuoi"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["TenNguoiSuaCuoi"].Index, csThayDoi);
                    if (dt.Rows[i]["Ngay_SuaCuoi"].ToString().ToLower() !=
                        dt.Rows[i - 1]["Ngay_SuaCuoi"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_SuaCuoi"].Index, csThayDoi);
                    if (dt.Rows[i]["Ten_CongViecGoc"].ToString().ToLower() !=
                        dt.Rows[i - 1]["Ten_CongViecGoc"].ToString().ToLower())
                        fg.SetCellStyle(i + 1, fg.Cols["Ten_CongViecGoc"].Index, csThayDoi);
                }
            }

            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void cmbNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            LoadcmbCungThucHien();
        }

        #endregion MyRegion

        #region Combobox keypress

        private void cmbLoaiCongViec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                cmbLoaiCongViec.ShowPopup();
        }

        private void cmbDoUuTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                cmbDoUuTien.ShowPopup();
        }

        private void cmbCongViecGoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                cmbCongViecGoc.ShowPopup();
        }

        private void cmbNguoiGiaoViec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                cmbNguoiGiaoViec.ShowPopup();
        }

        private void cmbNguoiThucHien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                cmbNguoiThucHien.ShowPopup();
        }

        private void cmbTrangThai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                cmbTrangThai.ShowPopup();
        }

        private void cmbNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                cmbNhanVien.ShowPopup();
        }

        private void cmbDonViTG_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                cmbDonViTG.OpenCombo();
        }

        #endregion Combobox keypress

        #region fgComment

        private void fgComment_AfterEdit(object sender, RowColEventArgs e)
        {
            var fg = fgComment;
            fg[e.Row, "IsEdit"] = "1";

            if (fg.Cols[e.Col].Name == "NoiDung")
                fg.Cols[e.Col].TextAlign = TextAlignEnum.LeftCenter;
            fg.AutoSizeRow(e.Row);
        }

        private void fgComment_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            var fg = fgComment;
            if (e.Row >= fg.Rows.Fixed)
                if (fg.Cols[e.Col].Name == "NoiDung")
                    if (e.Text.Length > 100)
                        e.Text = HelperMethods.TruncateString(e.Text, 100) + " ...";
        }

        private void fgComment_StartEdit(object sender, RowColEventArgs e)
        {
            if (fgComment.Cols[e.Col].Name == "NoiDung")
            {
                fgComment.Cols[e.Col].TextAlign = TextAlignEnum.LeftTop;
                fgComment.Rows[e.Row].Height = 60;
            }
        }

        private void fgComment_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    fgComment.Rows.Add();
                    fgComment.Rows[fgComment.Rows.Count - 1]["IsEdit"] = "1";
                    fgComment.Rows[fgComment.Rows.Count - 1]["TenDayDu"] = GlobalVariables.Get_HoTen_NhanSu();
                    fgComment.Rows[fgComment.Rows.Count - 1]["Ngay_Lap"] = GlobalVariables.GetCurrentDateTime();
                    fgComment.SetSTT();
                    break;

                case Keys.Delete:
                    if (fgComment.Row < fgComment.Rows.Fixed)
                    {
                        BaseMessages.ShowInformationMessage("Chưa chọn comment.");
                        return;
                    }
                    if (fgComment.GetDataDisplay(fgComment.Row, "ID_Comment") == "")
                    {
                        fgComment.Rows.Remove(fgComment.Row);
                    }
                    else
                    {
                        fgComment.Rows[fgComment.Row]["IsEdit"] = "0";
                        fgComment.Rows[fgComment.Row].Visible = false;
                    }
                    fgComment.SetSTT();
                    break;
            }
        }

        #endregion fgComment

        #region fgKetQua

        private void fgKetQua_AfterEdit(object sender, RowColEventArgs e)
        {
            var fg = fgKetQua;
            fg[e.Row, "IsEdit"] = "1";

            if (fg.Cols[e.Col].Name == "NoiDung")
                fg.Cols[e.Col].TextAlign = TextAlignEnum.LeftCenter;
            fg.AutoSizeRow(e.Row);
        }

        private void fgKetQua_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    fgKetQua.Rows.Add();
                    fgKetQua.Rows[fgKetQua.Rows.Count - 1]["IsEdit"] = "1";
                    fgKetQua.Rows[fgKetQua.Rows.Count - 1]["TenDayDu"] = GlobalVariables.Get_HoTen_NhanSu();
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

        private void Load_dtmap_DonVi_KetQua()
        {
            var cls = new clsDM_DonVi_KetQua();
            var dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt = dt.DefaultView.ToTable();
            dt.DefaultView.Sort = "ID_DonVi_KetQua ASC";
            fgKetQua.LoadDataMap("ID_DonVi_KetQua", dt.DefaultView.ToTable(), "ID_DonVi_KetQua", "Ten_KetQua_DonVi",
                false);
        }

        #endregion fgKetQua

        private void btnDeNghi_Click(object sender, EventArgs e)
        {
            frmDoiKeHoach frm = new frmDoiKeHoach(m_dNgay_YeuCau,m_dNgayDenHan);
            frm.ShowDialog();
        }
    }
}