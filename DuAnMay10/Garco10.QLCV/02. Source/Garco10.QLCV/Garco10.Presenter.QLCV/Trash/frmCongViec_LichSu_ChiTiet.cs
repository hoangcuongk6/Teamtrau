using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Garco10.SystemModule.Forms;
using M10_QLCV;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmCongViec_LichSu_ChiTiet : FormBaseGarco10
    {
        private int m_iID_CongViec;
        private int m_iID_CongViec_LichSu;

        public frmCongViec_LichSu_ChiTiet()
        {
            InitializeComponent();
        }
        public frmCongViec_LichSu_ChiTiet(int ID_CongViec)
        {
            InitializeComponent();
            m_iID_CongViec = ID_CongViec;
            LoadcmbMoi();
            LoadcmbCu();
        }

        public frmCongViec_LichSu_ChiTiet(int ID_CongViec, int ID_CongViec_LichSu)
        {
            InitializeComponent();
            m_iID_CongViec = ID_CongViec;
            m_iID_CongViec_LichSu = ID_CongViec_LichSu;
            LoadcmbMoi();
            LoadcmbCu();
        }

        private void LoadcmbMoi()
        {
            LoadcmbLoaiCV();
            LoadcmbMucDo();
            LoadcmbTrangThai();
            LoadcmbThoiGian();
            LoadcmbCongViecGoc();
            LoadcmbNguoiGiaoViec();
            LoadcmbNhanVien();
            //LoadcmbCungThucHien();
        }

        private void LoadcmbCu()
        {
            LoadcmbLoaiCVCu();
            LoadcmbMucDoCu();
            LoadcmbTrangThaiCu();
            LoadcmbThoiGianCu();
            LoadcmbCongViecGocCu();
            LoadcmbNguoiGiaoViecCu();
            LoadcmbNhanVienCu();
            //LoadcmbCungThucHienCu();
        }

        #region Load ComboboxMoi

        private void LoadcmbLoaiCV()
        {
            var cmb = cmbLoaiCongViec;
            cmb.Tag = 0;
            clsDM_LoaiCV cls = new clsDM_LoaiCV();
            DataTable dt = cls.SelectAll();
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
            clsNhanSu cls = new clsNhanSu();
            DataTable dt = cls.GetNhanSu(17, 0);
            //dt.DefaultView.RowFilter = "Ten_BoPhan = 'Bộ phận Quản lý' AND TrangThai_DiLam = 'Đang đi làm'";
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
            clsNhanSu cls = new clsNhanSu();
            DataTable dt = cls.GetNhanSu(17, 0);
            //dt.DefaultView.RowFilter = "Ten_BoPhan = 'Bộ phận TCKT' AND TrangThai_DiLam = 'Đang đi làm'";
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
            clsNhanSu cls = new clsNhanSu();
            DataTable dt = cls.GetNhanSu(17, 0);
            //dt.DefaultView.RowFilter = "ID_NhanSu <>" + cmbNhanVien.EditValue + " AND Ten_BoPhan = 'Bộ phận TCKT' AND TrangThai_DiLam = 'Đang đi làm'";
            dt.DefaultView.RowFilter = "ID_NhanSu <>" + cmbNhanVien.EditValue;
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
            clsDM_MucDoUuTien cls = new clsDM_MucDoUuTien();
            DataTable dt = cls.SelectAll();
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
            clsDM_TrangThai cls = new clsDM_TrangThai();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.Sort = "STT_TrangThai ASC";
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
            clsCongViec cls = new clsCongViec();
            DataTable dt = cls.SelectAll();
            cmb.Properties.DataSource = dt.DefaultView.ToTable();
            cmb.Properties.DisplayMember = "TieuDe";
            cmb.Properties.ValueMember = "ID_CongViec";
            cmb.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            cmb.Tag = 1;
        }

        private void LoadcmbThoiGian()
        {
            var cmb = cmbDonViTG;
            cmb.Tag = 0;
            cmb.ClearItems();
            clsDM_ThoiGian cls = new clsDM_ThoiGian();
            DataTable dt = cls.SelectAll();
            cmb.SetDataSource(dt, "ID_ThoiGian", "Ten_ThoiGian");
            cmb.ColumnWidth = 0;
            cmb.Tag = 1;
        }

        #endregion

        #region Load ComboboxCu

        private void LoadcmbLoaiCVCu()
        {
            var cmb = cmbLoaiCVCu;
            cmb.Tag = 0;
            clsDM_LoaiCV cls = new clsDM_LoaiCV();
            DataTable dt = cls.SelectAll();
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

        private void LoadcmbNguoiGiaoViecCu()
        {
            var cmb = cmbNguoiYCCu;
            cmb.Tag = 0;
            clsNhanSu cls = new clsNhanSu();
            DataTable dt = cls.GetNhanSu(17, 0);
            //dt.DefaultView.RowFilter = "Ten_BoPhan = 'Bộ phận Quản lý' AND TrangThai_DiLam = 'Đang đi làm'";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Tag = 1;
        }

        private void LoadcmbNhanVienCu()
        {
            var cmb = cmbNhanVienCu;
            cmb.Tag = 0;
            clsNhanSu cls = new clsNhanSu();
            DataTable dt = cls.GetNhanSu(17, 0);
            //dt.DefaultView.RowFilter = "Ten_BoPhan = 'Bộ phận TCKT' AND TrangThai_DiLam = 'Đang đi làm'";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Tag = 1;
        }

        private void LoadcmbCungThucHienCu()
        {
            if ((cmbNhanVienCu.EditValue ?? "").ToString() == "")
            {
                cmbNguoiTHCu.Properties.DataSource = null;
                cmbNguoiTHCu.EditValue = null;
                return;
            }
            var cmb = cmbNguoiTHCu;
            cmb.Tag = 0;
            clsNhanSu cls = new clsNhanSu();
            DataTable dt = cls.GetNhanSu(17, 0);
            //dt.DefaultView.RowFilter = "ID_NhanSu <>" + cmbNhanVienCu.EditValue + " AND Ten_BoPhan = 'Bộ phận TCKT' AND TrangThai_DiLam = 'Đang đi làm'";
            dt.DefaultView.RowFilter = "ID_NhanSu <>" + cmbNhanVienCu.EditValue;
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Properties.SeparatorChar = ',';
            cmb.Tag = 1;
        }

        private void LoadcmbMucDoCu()
        {
            var cmb = cmbDoUuTienCu;
            cmb.Tag = 0;
            clsDM_MucDoUuTien cls = new clsDM_MucDoUuTien();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.Sort = "STT_MucDo ASC";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_MucDo";
            cmb.Properties.ValueMember = "ID_MucDoUuTien";
            cmb.Tag = 1;
        }
        private void LoadcmbTrangThaiCu()
        {
            var cmb = cmbTrangThaiCu;
            cmb.Tag = 0;
            clsDM_TrangThai cls = new clsDM_TrangThai();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.Sort = "STT_TrangThai ASC";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_TrangThai";
            cmb.Properties.ValueMember = "ID_TrangThai";
            cmb.Tag = 1;
        }

        private void LoadcmbCongViecGocCu()
        {
            var cmb = cmbCVGocCu;
            cmb.Tag = 0;
            clsCongViec cls = new clsCongViec();
            DataTable dt = cls.SelectAll();
            cmb.Properties.DataSource = dt.DefaultView.ToTable();
            cmb.Properties.DisplayMember = "TieuDe";
            cmb.Properties.ValueMember = "ID_CongViec";
            cmb.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            cmb.Tag = 1;
        }

        private void LoadcmbThoiGianCu()
        {
            var cmb = cmbDVTGCu;
            cmb.Tag = 0;
            cmb.ClearItems();
            clsDM_ThoiGian cls = new clsDM_ThoiGian();
            DataTable dt = cls.SelectAll();
            cmb.SetDataSource(dt, "ID_ThoiGian", "Ten_ThoiGian");
            cmb.ColumnWidth = 0;
            cmb.Tag = 1;
        }

        #endregion

        private void frmCongViec_LichSu_ChiTiet_Load(object sender, EventArgs e)
        {
            Load_LichSu();
            Load_CongViec();
            Compare2Group();
        }

        private void Load_CongViec()
        {
            clsCongViec cls = new clsCongViec();
            cls.ID_CongViec = Convert.ToInt32(m_iID_CongViec);
            DataTable dt = cls.SelectOne();

            txtMaCV.EditValue = dt.Rows[0]["Ma_CongViec"];
            txtTieuDe.EditValue = dt.Rows[0]["TieuDe"];
            txtMoTa.EditValue = dt.Rows[0]["MoTa"];
            cmbLoaiCongViec.EditValue = dt.Rows[0]["ID_LoaiCV"];
            cmbDoUuTien.EditValue = int.Parse(dt.Rows[0]["ID_MucDoUuTien"].ToString());
            cmbCongViecGoc.EditValue = dt.Rows[0]["ID_CongViec_Goc"].ToString();
            cmbNguoiGiaoViec.EditValue = dt.Rows[0]["ID_NguoiYeuCau"].ToString();
            dtNgayDenHan.Value = dt.Rows[0]["Ngay_DenHan"];
            dtNgayYeuCauMoi.Value = dt.Rows[0]["Ngay_YeuCau"];
            txtThoiGianDuKien.EditValue = dt.Rows[0]["ThoiGian_DuKien"];
            cmbDonViTG.SelectedValue = short.Parse(dt.Rows[0]["ID_ThoiGian"].ToString());
            dtNgayBatDau.Value = dt.Rows[0]["Ngay_BatDau"];
            dtNgayHT.Value = dt.Rows[0]["Ngay_HoanThanh"];
            cmbTrangThai.EditValue = int.Parse(dt.Rows[0]["ID_TrangThai"].ToString());
            txtDiaDiemMoi.EditValue = dt.Rows[0]["DiaDiem"];

            string[] nhanvien = dt.Rows[0]["DS_ID_NhanVien"].ToString().Split(',');
            cmbNhanVien.EditValue = nhanvien[0];

            cmbNguoiThucHien.SetEditValue(dt.Rows[0]["DS_ID_NhanVien"].ToString());
        }

        private void Load_LichSu()
        {
            clsCongViec_LichSu cls = new clsCongViec_LichSu();
            cls.ID_CongViec_LichSu = Convert.ToInt32(m_iID_CongViec_LichSu);
            DataTable dt = cls.SelectOne();

            txtMaCVCu.EditValue = dt.Rows[0]["Ma_CongViec"];
            txtTieuDeCu.EditValue = dt.Rows[0]["TieuDe"];
            txtMoTaCu.EditValue = dt.Rows[0]["MoTa"];
            cmbLoaiCVCu.EditValue = dt.Rows[0]["ID_LoaiCV"];
            cmbDoUuTienCu.EditValue = int.Parse(dt.Rows[0]["ID_MucDoUuTien"].ToString());
            cmbCVGocCu.EditValue = dt.Rows[0]["ID_CongViec_Goc"].ToString();
            cmbNguoiYCCu.EditValue = dt.Rows[0]["ID_NguoiYeuCau"].ToString();
            dtNgayDenHanCu.Value = dt.Rows[0]["Ngay_DenHan"];
            dtNgayYeuCauCu.Value = dt.Rows[0]["Ngay_YeuCau"];
            txtThoiGian_DKCu.EditValue = dt.Rows[0]["ThoiGian_DuKien"];
            cmbDVTGCu.SelectedValue = short.Parse(dt.Rows[0]["ID_ThoiGian"].ToString());
            dtNgayBatDauCu.Value = dt.Rows[0]["Ngay_BatDau"];
            dtNgayHoanThanhCu.Value = dt.Rows[0]["Ngay_HoanThanh"];
            cmbTrangThaiCu.EditValue = int.Parse(dt.Rows[0]["ID_TrangThai"].ToString());
            txtDiaDiemCu.EditValue = dt.Rows[0]["DiaDiem"];
            string[] nhanviencu = dt.Rows[0]["DS_ID_NhanVien"].ToString().Split(',');
            cmbNhanVienCu.EditValue = nhanviencu[0];

            cmbNguoiTHCu.SetEditValue(dt.Rows[0]["DS_ID_NhanVien"].ToString());
        }

        private void cmbNhanVienCu_EditValueChanged(object sender, EventArgs e)
        {
            LoadcmbCungThucHienCu();
        }

        private void cmbNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            LoadcmbCungThucHien();
        }

        private void Compare2Group()
        {
            if (txtTieuDeCu.EditValue.ToString().ToLower().Trim() != txtTieuDe.EditValue.ToString().ToLower().Trim())
            {
                txtTieuDe.BackColor = Color.Chartreuse;
            }
            if (txtMoTaCu.EditValue.ToString().ToLower().Trim() != txtMoTa.EditValue.ToString().ToLower().Trim())
            {
                txtMoTa.BackColor = Color.Chartreuse;
            }
            if (cmbLoaiCVCu.EditValue.ToString() != cmbLoaiCongViec.EditValue.ToString())
            {
                cmbLoaiCongViec.BackColor = Color.Chartreuse;
            }
            if (cmbDoUuTienCu.EditValue.ToString() != cmbDoUuTien.EditValue.ToString())
            {
                cmbDoUuTien.BackColor = Color.Chartreuse;
            }
            if (cmbCongViecGoc.EditValue.ToString() != cmbCVGocCu.EditValue.ToString())
            {
                cmbCongViecGoc.BackColor = Color.Chartreuse;
            }
            if (cmbNguoiGiaoViec.EditValue.ToString() != cmbNguoiYCCu.EditValue.ToString())
            {
                cmbNguoiGiaoViec.BackColor = Color.Chartreuse;
            }
            if (cmbNguoiTHCu.EditValue.ToString() != cmbNguoiThucHien.EditValue.ToString())
            {
                cmbNguoiThucHien.BackColor = Color.Chartreuse;
            }
            if (cmbTrangThaiCu.EditValue.ToString() != cmbTrangThai.EditValue.ToString())
            {
                cmbTrangThai.BackColor = Color.Chartreuse;
            }
            if (cmbNhanVien.EditValue.ToString() != cmbNhanVienCu.EditValue.ToString())
            {
                cmbNhanVien.BackColor = Color.Chartreuse;
            }
            if (dtNgayDenHan.Value.ToString() != dtNgayDenHanCu.Value.ToString())
            {
                dtNgayDenHan.BackColor = Color.Chartreuse;
            }
            if (dtNgayBatDau.Value.ToString() != dtNgayBatDauCu.Value.ToString())
            {
                dtNgayBatDau.BackColor = Color.Chartreuse;
            }
            if (dtNgayHT.Value.ToString() != dtNgayHoanThanhCu.Value.ToString())
            {
                dtNgayHT.BackColor = Color.Chartreuse;
            }
            if (TxtPhanTramHTCu.EditValue != txtPhanTramHT.EditValue)
            {
                txtPhanTramHT.BackColor = Color.Chartreuse;
            }
            if (txtThoiGian_DKCu.EditValue.ToString() != txtThoiGianDuKien.EditValue.ToString())
            {
                txtThoiGianDuKien.BackColor = Color.Chartreuse;
            }
            if (cmbDVTGCu.Value != cmbDVTGCu.Value)
            {
                cmbDVTGCu.BackColor = Color.Chartreuse;
            }
        }
    }
}
