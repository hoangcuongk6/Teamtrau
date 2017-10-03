using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using VSCM.Base.Utils;

namespace Garco10.Presenter.QLCV.DanhMuc
{
    public partial class frmDM_DonVi_KetQua : FormBaseGarco10
    {
        public frmDM_DonVi_KetQua()
        {
            InitializeComponent();

        }

        private void LockEdit(bool p)
        {
            btnCapNhat.Visible = p;
            btnHuy.Visible = !p;
            btnLuu.Visible = !p;
            lblHuongDan.Visible = !p;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowUndoQuestionMessage() == DialogResult.No) return;
            LockEdit(true);
            LoadData();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValid()
        {
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                string strTen_KetQua_DonVi = fg.GetDataDisplay(i, "Ten_KetQua_DonVi").ToLower().Trim();
                if (strTen_KetQua_DonVi == "")
                {
                    BaseMessages.ShowWarningMessage("Chưa nhập tên đơn vị kết quả dòng thứ " + i + " !");
                    return false;
                }
            }
            return true;
        }

        private void SaveData()
        {
            clsDM_DonVi_KetQua cls = new clsDM_DonVi_KetQua();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.GetDataDisplay(i, "IsEdit") == "") continue;
                cls.Ten_KetQua_DonVi = fg.GetDataDisplay(i, "Ten_KetQua_DonVi");
                cls.TonTai = bool.Parse(fg.GetDataDisplay(i, "TonTai"));
                if (fg.GetDataDisplay(i, "IsEdit") == "0")
                {
                    cls.TonTai = false;
                    cls.ID_DonVi_KetQua = fg.GetIntValue(i, "ID_DonVi_KetQua");
                    cls.Update();
                }
                else
                {
                    cls.TonTai = true;
                    if (fg.GetDataDisplay(i, "ID_DonVi_KetQua") == "")
                    {
                        cls.Insert();
                    }
                    else
                    {
                        cls.ID_DonVi_KetQua = fg.GetIntValue(i, "ID_DonVi_KetQua");
                        cls.Update();
                    }
                }
            }
            BaseMessages.ShowInformationMessage("Cập nhật thành công !");
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            SaveData();
            LockEdit(true);
            LoadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LockEdit(false);
        }

        private void fg_AfterEdit(object sender, RowColEventArgs e)
        {
            fg[e.Row, "IsEdit"] = "1";
        }

        private void fg_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    Insert_LoaiCongViec();
                    break;
                case Keys.Delete:
                    Delete_LoaiCongViec();
                    break;
            }
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            var searchString = txtTimKiem.Text.Trim().ToLower();
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                if (fg.GetDataDisplay(i, "IsEdit") != "0" &&
                    fg.GetDataDisplay(i, "Ten_KetQua_DonVi").Trim().ToLower().Contains(searchString))
                    fg.Rows[i].Visible = true;
                else
                    fg.Rows[i].Visible = false;
        }

        public void LoadData()
        {
            fg.Tag = 0;
            fg.BeginUpdate();
            clsDM_DonVi_KetQua cls = new clsDM_DonVi_KetQua();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            fg.ClearRows();
            fg.SetDataSource(dt.DefaultView.ToTable());
            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void Delete_LoaiCongViec()
        {
            if (btnCapNhat.Visible)
            {
                BaseMessages.ShowInformationMessage("Bạn chưa ấn nút cập nhật nên không thể thực hiện chức năng này");
                return;
            }
            if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn đơn vị kết quả.");
                return;
            }
            if (fg.GetDataDisplay(fg.Row, "ID_KetQua_DonVi") == "")
            {
                fg.Rows.Remove(fg.Row);
            }
            fg.Rows[fg.Row]["IsEdit"] = "0";
            fg.Rows[fg.Row].Visible = false;
            fg.SetSTT();
        }
        private void Insert_LoaiCongViec()
        {
            if (btnCapNhat.Visible)
            {
                BaseMessages.ShowInformationMessage("Bạn chưa ấn nút cập nhật nên không thể thực hiện chức năng này ");
                return;
            }
            Row fgRow = fg.Rows.Add();
            fgRow["IsEdit"] = "1";
            fgRow["TonTai"] = true;
            fg.SetSTT();
        }

        private void frmDM_DonVi_KetQua_Load(object sender, EventArgs e)
        {
            LockEdit(true);
            LoadData();
        }
    }
}