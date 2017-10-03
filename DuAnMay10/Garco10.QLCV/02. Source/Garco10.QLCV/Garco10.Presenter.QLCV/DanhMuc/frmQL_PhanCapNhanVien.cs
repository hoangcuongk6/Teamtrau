using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Garco10.SystemModule.Forms;
using Garco10.SystemModule.HeThong;
using M10_QLCV;
using VSCM.Base.Utils;

namespace Garco10.Presenter.QLCV
{
    public partial class frmQL_PhanCapNhanVien : FormBaseGarco10
    {
        private bool m_bFlag = true;

        public frmQL_PhanCapNhanVien()
        {
            InitializeComponent();
        }

        private void frmQL_PhanCapNhanVien_Load(object sender, EventArgs e)
        {
            LoadcmbNguoiQuanLy();
            LockEdit(true);
            Loadfg();
        }

        private void LoadcmbNguoiQuanLy()
        {
            var cmb = cmbNguoiQuanLy;
            cmb.Tag = 0;
            var cls = new clsNhanSu();
            var dt = cls.GetNhanSu(GlobalVariables.uID_DonVi, 0);
            dt.DefaultView.RowFilter = "TrangThai_DiLam = 'Đang đi làm'";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Tag = 1;
        }

        private void LoadcmbNhanVien()
        {
            if ((cmbNguoiQuanLy.EditValue ?? "").ToString() == "")
            {
                cmbNhanVien.Properties.DataSource = null;
                cmbNhanVien.EditValue = null;
                return;
            }
            var cmb = cmbNhanVien;
            cmb.Tag = 0;
            var cls = new clsNhanSu();
            var dt = cls.GetNhanSu(GlobalVariables.uID_DonVi, 0);
            dt.DefaultView.RowFilter = "ID_NhanSu <>" + cmbNguoiQuanLy.EditValue +
                                       " AND TrangThai_DiLam = 'Đang đi làm'";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Tag = 1;
        }

        private void ResetComboboxs()
        {
            cmbNguoiQuanLy.EditValue = null;
            //cmbNhanVien.SetEditValue(null);
        }

        private void LockEdit(bool p)
        {
            btnThemMoi.Visible = p;
            btnSua.Visible = p;
            btnXoa.Visible = p;

            fg.Enabled = p;

            btnLuu.Visible = !p;
            btnHuy.Visible = !p;

            gbThongTin.Enabled = !p;
        }

        private void Loadfg()
        {
            fg.Tag = 0;
            fg.BeginUpdate();
            var cls = new clsPhanCapNhanVien();
            var dt = cls.SelectAll_With_Ten(GlobalVariables.uID_DonVi);
            fg.ClearRows();
            fg.SetDataSource(dt);
            LoadTree();
            var iSTT = 0;
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.Rows[i].IsNode)
                    iSTT = 0;
                else
                    fg[i, "STT"] = iSTT;
                iSTT++;
            }
            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void LoadTree()
        {
            var colTenNhanVienIndex = fg.Cols["Ten_NhanVien"].Index;
            GroupBy("Ten_NguoiQuanLy", colTenNhanVienIndex, 0, "Người quản lý:");
            fg.Cols["Ten_NguoiQuanLy"].Width = 0;
            fg.AllowMerging = AllowMergingEnum.None;
            fg.Tree.Column = colTenNhanVienIndex;
            fg.Tree.Style = TreeStyleFlags.Symbols;
            fg.AutoSizeCol(fg.Tree.Column);
            fg.Tree.Show(0);
        }

        private void GroupBy(string columnName, int groupCol, int level, string caption)
        {
            var cs = fg.Styles[CellStyleEnum.Search];
            cs.Font = new Font(fg.Font, FontStyle.Bold);

            object current = null;
            for (var r = fg.Rows.Fixed; r < fg.Rows.Count; r++)
                if (!fg.Rows[r].IsNode)
                {
                    var value = fg[r, columnName];
                    if (!Equals(value, current))
                    {
                        // value changed: insert node, apply style
                        fg.Rows.InsertNode(r, level);
                        fg.Rows[r].Style = cs;
                        // show group name in first scrollable column
                        fg[r, groupCol] = caption + " " + value;
                        // update current value
                        current = value;
                    }
                }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbNguoiQuanLy_EditValueChanged(object sender, EventArgs e)
        {
            if ((cmbNguoiQuanLy.EditValue ?? "").ToString() == "")
            {
                //cmbNhanVien.Properties.DataSource = null;
                cmbNhanVien.SetEditValue(null);
                return;
            }
            LoadcmbNhanVien();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            m_bFlag = true;
            LockEdit(false);
            ResetComboboxs();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowUndoQuestionMessage() == DialogResult.No) return;
            LockEdit(true);
            Loadfg();
            ResetComboboxs();
        }

        private bool IsValid()
        {
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (!m_bFlag && i == fg.Row || fg.Rows[i].IsNode) continue;
                if (cmbNguoiQuanLy.EditValue.ToString() == fg[i, "ID_NhanVien"].ToString() &&
                    cmbNhanVien.EditValue.ToString() == fg[i, "ID_NguoiQuanLy"].ToString())
                {
                    BaseMessages.ShowErrorMessage("Không thể quản lý nhân viên cấp cao hơn!");
                    return false;
                }
                if (cmbNguoiQuanLy.EditValue.ToString() == fg[i, "ID_NguoiQuanLy"].ToString() &&
                    cmbNhanVien.EditValue.ToString() == fg[i, "ID_NhanVien"].ToString())
                {
                    BaseMessages.ShowErrorMessage("Dữ liệu trùng với dòng " + i + "!");
                    return false;
                }
            }
            return true;
        }

        private void SaveData()
        {
            var cls = new clsPhanCapNhanVien();
            if (m_bFlag)
            {
                cls.ID_DonVi = GlobalVariables.uID_DonVi;
                cls.ID_NguoiQuanLy = Convert.ToInt32(cmbNguoiQuanLy.EditValue);
                var items = cmbNhanVien.Properties.GetItems().GetCheckedValues();
                foreach (var item in items)
                {
                    cls.ID_NhanVien = Convert.ToInt32(item);
                    cls.Insert();
                }
            }
            else
            {
                cls.ID_DonVi = GlobalVariables.uID_DonVi;
                cls.ID_NguoiQuanLy = Convert.ToInt32(fg[fg.Row, "ID_NguoiQuanLy"]);
                cls.ID_NhanVien = Convert.ToInt32(fg[fg.Row, "ID_NhanVien"]);
                cls.Delete();
                cls.ID_NguoiQuanLy = Convert.ToInt32(cmbNguoiQuanLy.EditValue);
                cls.ID_NhanVien = Convert.ToInt32(cmbNhanVien.EditValue);
                cls.Insert();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            SaveData();
            BaseMessages.ShowInformationMessage("Cập nhật thành công!");
            LockEdit(true);
            Loadfg();
            ResetComboboxs();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (fg.Row < fg.Rows.Fixed || fg.Rows[fg.Row].IsNode)
            {
                BaseMessages.ShowInformationMessage("Chọn dòng để sửa!");
                return;
            }
            m_bFlag = false;
            LockEdit(false);
        }

        private void fg_AfterRowChange(object sender, RangeEventArgs e)
        {
            if (fg.Tag + "" != "1" || fg.Rows.Count < fg.Rows.Fixed)
                return;
            if (fg.Rows[fg.Row].IsNode) return;
            cmbNguoiQuanLy.EditValue = Convert.ToInt32(fg[fg.Row, "ID_NguoiQuanLy"]);
            cmbNhanVien.SetEditValue(fg[fg.Row, "ID_NhanVien"]);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (fg.Row < fg.Rows.Fixed || fg.Rows[fg.Row].IsNode)
            {
                BaseMessages.ShowInformationMessage("Chọn dòng để sửa!");
                return;
            }
            if (BaseMessages.ShowDeleteQuestionMessage() == DialogResult.No) return;

            var cls = new clsPhanCapNhanVien();
            cls.ID_NguoiQuanLy = Convert.ToInt32(cmbNguoiQuanLy.EditValue);
            var items = cmbNhanVien.Properties.GetItems().GetCheckedValues();
            foreach (var item in items)
                cls.ID_NhanVien = Convert.ToInt32(item);
            cls.Delete();
            BaseMessages.ShowInformationMessage("Xóa thành công!");
            LockEdit(true);
            Loadfg();
            ResetComboboxs();
        }
    }
}
