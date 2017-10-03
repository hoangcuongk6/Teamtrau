using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Garco10.SystemModule.Forms;
using Garco10.SystemModule.HeThong;
using M10_QLCV;
using M10_System;
using VSCM.Base.Utils;
using GlobalVariables = Garco10.DataAccess.QLCV.Global.GlobalVariables;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmSoTayHarvard : FormBaseGarco10
    {
        public frmSoTayHarvard()
        {
            InitializeComponent();
        }

        private void frmSoTayHarvard_Load(object sender, EventArgs e)
        {
            LockEdit(true);
            Load_dtmap_BoPhan();
            LoadData();
            //int a = SystemModule.HeThong.GlobalVariables.uID_DonVi; lay don vi cua nguoi dang nhap
        }

        private void LoadData()
        {
            var fg = fgHarvard;
            fg.Tag = 0;
            fg.BeginUpdate();
            clsSoTayKinhNghiem cls = new clsSoTayKinhNghiem();
            var dt = cls.SelectAll_SoTay();
            fg.ClearRows();
            fg.SetDataSource(dt);
            fg.SetSTT();
            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void LockEdit(bool p)
        {
            btnCapNhat.Visible = p;
            btnLuu.Visible = !p;
            btnHuy.Visible = !p;
            lblHuongDan.Visible = !p;
            fgHarvard.AllowEditing = !p;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LockEdit(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            SaveData();
            LockEdit(true);
            LoadData();
        }

        private void SaveData()
        {
            var fg = fgHarvard;
            clsSoTayKinhNghiem cls = new clsSoTayKinhNghiem();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.GetDataDisplay(i, "IsEdit") == "") continue;
                cls.Ngay_Thang = DateTime.Parse(fg.GetDataDisplay(i, "Ngay_Thang"));
                cls.ID_BoPhan = int.Parse(fg[i, "ID_BoPhan"] + "");
                cls.MoTa = fg.GetDataDisplay(i, "MoTa");
                cls.MucDo_AnhHuong = fg.GetDataDisplay(i, "MucDo_AnhHuong");
                cls.NguyenNhan = fg.GetDataDisplay(i, "NguyenNhan");
                cls.BienPhap = fg.GetDataDisplay(i, "BienPhap");
                cls.GhiChu = fg.GetDataDisplay(i, "GhiChu");
                cls.Ngay_Lap = DateTime.Parse(fg.GetDataDisplay(i, "Ngay_Lap"));
                ///cls.ID_NguoiLap = int.Parse(fg.GetDataDisplay(i, "ID_NguoiLap"));
                cls.ID_NguoiLap = GlobalVariables.GetID_NhanSu();
                //Xóa
                if (fg.GetDataDisplay(i, "IsEdit") == "0")
                {
                    cls.ID_SoTay = int.Parse(fg[i, "ID_SoTay"].ToString());// dòng thứ i, cột ID_SoTay
                    cls.Update();
                }
                else
                {
                    if (fg.GetDataDisplay(i, "ID_SoTay") == "") //Thêm mới
                    {
                        cls.Insert();
                    }
                    else
                    {
                        cls.ID_SoTay = int.Parse(fg[i, "ID_SoTay"].ToString()); // Cập nhật
                        cls.Update();
                    }
                }
            }
            BaseMessages.ShowInformationMessage("Cập nhật thành công!");
        }

        private bool IsValid()
        {
            var fg = fgHarvard;
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                string strNgay_thang = fg.GetDataDisplay(i, "Ngay_Thang").ToLower().Trim();
                if (strNgay_thang == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập ngày tháng dòng thứ " + i);
                    return false;
                }
                string strBoPhan = fg.GetDataDisplay(i, "ID_BoPhan").ToLower().Trim();
                if (strBoPhan == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập nơi, tổ, bộ phận phát sinh dòng thứ " + i);
                    return false;
                }
                if (fg.GetDataDisplay(i, "MoTa").ToLower().Trim() == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập mô tả vấn đề dòng thứ " + i);
                    return false;
                }
                if (fg.GetDataDisplay(i, "MucDo_AnhHuong").ToLower().Trim() == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập mức độ ảnh hưởng, thiệt hại dòng thứ " + i);
                    return false;
                }
                if (fg.GetDataDisplay(i, "NguyenNhan").ToLower().Trim() == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập nguyên nhân dòng thứ " + i);
                    return false;
                }
                if (fg.GetDataDisplay(i, "BienPhap").ToLower().Trim() == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập biện pháp giải quyết và khắc phục dòng thứ " + i);
                    return false;
                }
                //if (fg.GetDataDisplay(i, "GhiChu").ToLower().Trim() == "")
                //{
                //    BaseMessages.ShowWarningMessage("Chưa nhập ghi chú dòng thứ " + i);
                //    return false;
                //}
            }
            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowUndoQuestionMessage() == DialogResult.No) return;
            LockEdit(true);
            LoadData();
        }

        private void fgHarvard_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            var fg = fgHarvard;
            fg[e.Row, "IsEdit"] = "1";

            if (fg.Cols[e.Col].Name == "MoTa")
                fg.Cols[e.Col].TextAlign = TextAlignEnum.LeftCenter;
            if (fg.Cols[e.Col].Name == "MucDo_AnhHuong")
                fg.Cols[e.Col].TextAlign = TextAlignEnum.LeftCenter;
            if (fg.Cols[e.Col].Name == "NguyenNhan")
                fg.Cols[e.Col].TextAlign = TextAlignEnum.LeftCenter;
            if (fg.Cols[e.Col].Name == "BienPhap")
                fg.Cols[e.Col].TextAlign = TextAlignEnum.LeftCenter;
            if (fg.Cols[e.Col].Name == "GhiChu")
                fg.Cols[e.Col].TextAlign = TextAlignEnum.LeftCenter;
            fg.AutoSizeRow(e.Row);
        }

        private void fgHarvard_StartEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            if (fgHarvard.Cols[e.Col].Name == "MoTa")
            {
                fgHarvard.Cols[e.Col].TextAlign = TextAlignEnum.LeftTop;
                fgHarvard.Rows[e.Row].Height = 60;
            }
            if (fgHarvard.Cols[e.Col].Name == "MucDo_AnhHuong")
            {
                fgHarvard.Cols[e.Col].TextAlign = TextAlignEnum.LeftTop;
                fgHarvard.Rows[e.Row].Height = 60;
            }
            if (fgHarvard.Cols[e.Col].Name == "NguyenNhan")
            {
                fgHarvard.Cols[e.Col].TextAlign = TextAlignEnum.LeftTop;
                fgHarvard.Rows[e.Row].Height = 60;
            }
            if (fgHarvard.Cols[e.Col].Name == "BienPhap")
            {
                fgHarvard.Cols[e.Col].TextAlign = TextAlignEnum.LeftTop;
                fgHarvard.Rows[e.Row].Height = 60;
            }
            if (fgHarvard.Cols[e.Col].Name == "GhiChu")
            {
                fgHarvard.Cols[e.Col].TextAlign = TextAlignEnum.LeftTop;
                fgHarvard.Rows[e.Row].Height = 60;
            }
        }

        private void fgHarvard_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnCapNhat.Visible) return;
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    fgHarvard.Rows.Add();
                    fgHarvard.Rows[fgHarvard.Rows.Count - 1]["IsEdit"] = "1";
                    fgHarvard.Rows[fgHarvard.Rows.Count - 1]["TenDayDu"] = GlobalVariables.Get_HoTen_NhanSu();
                    fgHarvard.Rows[fgHarvard.Rows.Count - 1]["Ngay_Lap"] = GlobalVariables.GetCurrentDateTime();
                    fgHarvard.Rows[fgHarvard.Rows.Count - 1]["Ngay_Thang"] = GlobalVariables.GetCurrentDateTime();
                    fgHarvard.SetSTT();
                    break;

                case Keys.Delete:
                    if (fgHarvard.Row < fgHarvard.Rows.Fixed)
                    {
                        BaseMessages.ShowInformationMessage("Chưa chọn dòng để xóa !!!");
                        return;
                    }
                    if (fgHarvard.GetDataDisplay(fgHarvard.Row, "ID_Harvard") == "")
                    {
                        fgHarvard.Rows.Remove(fgHarvard.Row);
                    }
                    else
                    {
                        fgHarvard.Rows[fgHarvard.Row]["IsEdit"] = "0";
                        fgHarvard.Rows[fgHarvard.Row].Visible = false;
                    }
                    fgHarvard.SetSTT();
                    break;
            }
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            var fg = fgHarvard;
            var searchString = txtTimKiem.Text.Trim().ToLower();
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                if (fg.GetDataDisplay(i, "IsEdit") != "0" &&
                    fg.GetDataDisplay(i, "MoTa").Trim().ToLower().Contains(searchString) || fg.GetDataDisplay(i, "MucDo_AnhHuong").Trim().ToLower().Contains(searchString) || fg.GetDataDisplay(i, "NguyenNhan").Trim().ToLower().Contains(searchString) || fg.GetDataDisplay(i, "BienPhap").Trim().ToLower().Contains(searchString) || fg.GetDataDisplay(i, "GhiChu").Trim().ToLower().Contains(searchString))
                    fg.Rows[i].Visible = true;
                else
                    fg.Rows[i].Visible = false;
        }

        private void Load_dtmap_BoPhan()
        {
            clsDM_BoPhan cls = new clsDM_BoPhan();
            DataTable dt = cls.Load_TheoID_DonVi(SystemModule.HeThong.GlobalVariables.uID_DonVi);
            dt.DefaultView.RowFilter = "TonTai = 1";
            fgHarvard.LoadDataMap("ID_BoPhan", dt.DefaultView.ToTable(), "ID_BoPhan", "Ten_BoPhan", false);
        }
    }
}
