using System;
using System.Data;
using System.Drawing;
using System.Linq;
using C1.Win.C1FlexGrid;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using Garco10.DataAccess.QLCV.Global;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmCongViec_LichSu : FormBaseGarco10
    {
        private int m_iID_CongViec;
        private string m_sMa_CV;
        private CellStyle csThayDoi;

        public frmCongViec_LichSu()
        {
            InitializeComponent();
            InitCellStyles();
        }

        public frmCongViec_LichSu(int ID_CongViec, string Ma_CV)
        {
            InitializeComponent();
            InitCellStyles();
            m_iID_CongViec = ID_CongViec;
            m_sMa_CV = Ma_CV;
        }

        private void frmCongViec_LichSu_Load(object sender, EventArgs e)
        {
            txtMaCV.Text = m_sMa_CV;
            InitCellStyles();
            Load_fgLichSu();
        }

        private void Load_fgLichSu()
        {
            var fg = fgLichSu;
            fg.Tag = 0;
            fg.BeginUpdate();
            clsCongViec_LichSu lichSu = new clsCongViec_LichSu();
            DataTable dt = lichSu.Select_ID_CongViec(m_iID_CongViec);
            fg.ClearRows();
            fg.SetDataSource(dt);

            //for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            //{
            //    if (fg.GetDataDisplay(i, "MoTa").Length > 100)
            //    {
            //        fg[i, "MoTa"] = HelperMethods.TruncateString(fg.GetDataDisplay(i, "MoTa"), 100) + " ...";
            //    }
            //    for (int j = i + 1; j < fg.Rows.Count; j++)
            //    {
            //        if (fg.GetDataDisplay(i, "TieuDe").ToLower().Trim() != fg.GetDataDisplay(j, "TieuDe").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["TieuDe"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "MoTa").ToLower().Trim() != fg.GetDataDisplay(j, "MoTa").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["MoTa"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "Ngay_YeuCau").ToLower().Trim() != fg.GetDataDisplay(j, "Ngay_YeuCau").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["Ngay_YeuCau"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "Ngay_DenHan").ToLower().Trim() != fg.GetDataDisplay(j, "Ngay_DenHan").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["Ngay_DenHan"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "ThoiGian_DuKien").ToLower().Trim() != fg.GetDataDisplay(j, "ThoiGian_DuKien").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["ThoiGian_DuKien"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "Ngay_BatDau").ToLower().Trim() != fg.GetDataDisplay(j, "Ngay_BatDau").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["Ngay_BatDau"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "Ngay_HoanThanh").ToLower().Trim() != fg.GetDataDisplay(j, "Ngay_HoanThanh").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["Ngay_HoanThanh"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "PhanTramHoanThanh").ToLower().Trim() != fg.GetDataDisplay(j, "PhanTramHoanThanh").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["PhanTramHoanThanh"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "TenNguoiLap").ToLower().Trim() != fg.GetDataDisplay(j, "TenNguoiLap").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["TenNguoiLap"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "Ngay_Lap").ToLower().Trim() != fg.GetDataDisplay(j, "Ngay_Lap").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["Ngay_Lap"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "TenNguoiSuaCuoi").ToLower().Trim() != fg.GetDataDisplay(j, "TenNguoiSuaCuoi").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["TenNguoiSuaCuoi"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "Ngay_SuaCuoi").ToLower().Trim() != fg.GetDataDisplay(j, "Ngay_SuaCuoi").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["Ngay_SuaCuoi"].Index, csThayDoi);
            //        }
            //        if (fg.GetDataDisplay(i, "Ten_CongViecGoc").ToLower().Trim() != fg.GetDataDisplay(j, "Ten_CongViecGoc").ToLower().Trim())
            //        {
            //            fg.SetCellStyle(j, fg.Cols["Ten_CongViecGoc"].Index, csThayDoi);
            //        }
            //    }
            //}

            for (int i = 1; i < dt.Rows.Count; i++)
            {
                if (dt.Rows.Count == 1)
                {
                    if (dt.Rows[i]["MoTa"].ToString().Trim().Length > 100)
                    {
                        fg[i, "MoTa"] = HelperMethods.TruncateString(fg.GetDataDisplay(i, "MoTa"), 100) + " ...";
                    }
                }
                if (i < dt.Rows.Count - 1)
                {
                    if (dt.Rows[i]["MoTa"].ToString().Length > 100)
                    {
                        fg[i, "MoTa"] = HelperMethods.TruncateString(fg.GetDataDisplay(i, "MoTa"), 100) + " ...";
                        fg[i+1, "MoTa"] = HelperMethods.TruncateString(fg.GetDataDisplay(i, "MoTa"), 100) + " ...";
                        fg[i+2, "MoTa"] = HelperMethods.TruncateString(fg.GetDataDisplay(i, "MoTa"), 100) + " ...";
                    }
                    if (dt.Rows[i]["TieuDe"].ToString().ToLower() != dt.Rows[i - 1]["TieuDe"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["TieuDe"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["MoTa"].ToString().ToLower() != dt.Rows[i - 1]["MoTa"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["MoTa"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["Ngay_YeuCau"].ToString().ToLower() != dt.Rows[i - 1]["Ngay_YeuCau"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_YeuCau"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["Ngay_DenHan"].ToString().ToLower() != dt.Rows[i - 1]["Ngay_DenHan"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_DenHan"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["ThoiGian_DuKien"].ToString().ToLower() != dt.Rows[i - 1]["ThoiGian_DuKien"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["ThoiGian_DuKien"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["Ngay_BatDau"].ToString().ToLower() != dt.Rows[i - 1]["Ngay_BatDau"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_BatDau"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["Ngay_HoanThanh"].ToString().ToLower() != dt.Rows[i - 1]["Ngay_HoanThanh"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_HoanThanh"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["PhanTramHoanThanh"].ToString().ToLower() != dt.Rows[i - 1]["PhanTramHoanThanh"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["PhanTramHoanThanh"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["TenNguoiLap"].ToString().ToLower() != dt.Rows[i - 1]["TenNguoiLap"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["TenNguoiLap"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["Ngay_Lap"].ToString().ToLower() != dt.Rows[i - 1]["Ngay_Lap"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_Lap"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["TenNguoiSuaCuoi"].ToString().ToLower() != dt.Rows[i - 1]["TenNguoiSuaCuoi"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["TenNguoiSuaCuoi"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["Ngay_SuaCuoi"].ToString().ToLower() != dt.Rows[i - 1]["Ngay_SuaCuoi"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["Ngay_SuaCuoi"].Index, csThayDoi);
                    }
                    if (dt.Rows[i]["Ten_CongViecGoc"].ToString().ToLower() != dt.Rows[i - 1]["Ten_CongViecGoc"].ToString().ToLower())
                    {
                        fg.SetCellStyle(i + 1, fg.Cols["Ten_CongViecGoc"].Index, csThayDoi);
                    }
                }
            }


            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fgLichSu_DoubleClick(object sender, EventArgs e)
        {
            int ID_CongViec_LichSu = int.Parse(fgLichSu.GetDataDisplay(fgLichSu.Row, "ID_CongViec_LichSu"));
            frmCongViec_LichSu_ChiTiet chiTiet = new frmCongViec_LichSu_ChiTiet(m_iID_CongViec, ID_CongViec_LichSu);
            chiTiet.ShowDialog();
        }

        private void InitCellStyles()
        {
            csThayDoi = fgLichSu.Styles.Add("Thay đổi");
            csThayDoi.BackColor = Color.Chartreuse;
        }

        private void fgLichSu_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            var fg = fgLichSu;
            if (e.Row >= fgLichSu.Rows.Fixed)
            {
                if (fg.Cols[e.Col].Name == "MoTa")
                {
                    if (e.Text.Length > 100)
                        e.Text = HelperMethods.TruncateString(e.Text, 100) + " ...";
                }
            }
        }
    }
}
