using Garco10.SystemModule.Forms;
using M10_QLCV;
using System;
using System.Data;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using VSCM.Base.Utils;

namespace Garco10.Presenter.QLCV.DanhMuc
{
    public partial class frmNhom_Ban : FormBaseGarco10
    {
        public int m_iID_NhanSu;

        public frmNhom_Ban()
        {
            InitializeComponent();
        }

        public frmNhom_Ban(int ID_NhanSu)
        {
            InitializeComponent();
            m_iID_NhanSu = ID_NhanSu;
        }

        private void frmNhom_Ban_Load(object sender, EventArgs e)
        {
            LockEdit(true);
            LoadfgBan_Nhom();
            Load_dtmap_Nhom_ChucVu();
        }

        public void LoadfgBan_Nhom()
        {
            var fg = fgBan_Nhom;
            fg.Tag = 0;
            fg.BeginUpdate();
            clsNhom cls = new clsNhom();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            fg.ClearRows();
            fg.SetDataSource(dt);

            //Add Node 0 công việc con
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
            //chỉ số cột hiển thị cây
            fg.Tree.Column = 4;

            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (!fg.Rows[r].Visible)
                {
                    fg.Rows.Remove(r);
                    --r;
                }
            }
            SetSTT();
            fg.Row = -1;
            fg.EndUpdate();
            fg.Tag = 1;
            fgBan_Nhom.Tree.Show(0);
        }

        public bool IsNode0(int row)
        {
            var fg = fgBan_Nhom;
            if (fg.GetDataDisplay(row, "ID_Nhom_Cha") == "") return true;
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (fg.GetDataDisplay(row, "ID_Nhom_Cha") == fg.GetDataDisplay(r, "ID_Nhom")) return false;
            }
            return true;
        }

        private void GetDataTwoRow(int row1, int row2)
        {
            var fg = fgBan_Nhom;
            for (int c = fg.Cols.Fixed; c < fg.Cols.Count; ++c)
            {
                fg.Rows[row1][c] = fg.Rows[row2][c];
            }
        }

        private bool TonTaiCongViecGoc(int level)
        {
            var fg = fgBan_Nhom;
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; r++)
            {
                if (!fg.Rows[r].Visible) continue;
                if (fg.Rows[r].Node.Level == 0 && fg.GetDataDisplay(r, "ID_Nhom_Cha").ToString() != "")
                {
                    for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                    {
                        if (!fg.Rows[i].Visible) continue;
                        if (fg.GetDataDisplay(r, "ID_Nhom_Cha").ToString() == fg.GetDataDisplay(i, "ID_Nhom").ToString() && fg.Rows[i].Node.Level == level && i != r)
                            return true;
                    }
                }
            }
            return false;
        }

        public int TimCongViecGoc(int row, int NodeLevel)
        {
            var fg = fgBan_Nhom;
            int ID_Nhom = int.Parse(fg.Rows[row]["ID_Nhom"].ToString());
            int r = fg.Rows.Fixed;
            for (r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (!fg.Rows[r].Visible || r == row || fg.GetDataDisplay(r, "ID_Nhom_Cha").ToString() == "") continue;
                if (ID_Nhom == int.Parse(fg.Rows[r]["ID_Nhom_Cha"].ToString()) && fg.Rows[r].Visible && fg.Rows[r].Node.Level == 0)
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

        private void SetSTT()
        {
            var fg = fgBan_Nhom;
            bool trangThai = true;
            int level = 0;
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
                                sttCha = fg.Rows[j]["STT"] + ".";
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

        private void fgBan_Nhom_DoubleClick(object sender, EventArgs e)
        {
            if (fgBan_Nhom.Row < fgBan_Nhom.Rows.Fixed || fgBan_Nhom.Row > fgBan_Nhom.Rows.Count)
            {
                return;
            }
            else
            {
                frmNhom frm;
                int iID_Nhom = int.Parse(fgBan_Nhom.Rows[fgBan_Nhom.Row]["ID_Nhom"].ToString());
                frm = new frmNhom(iID_Nhom, true);
                frm.frmQLTD = this;
                frm.ShowDialog();
            }
        }

        private void mnu_ExpandAll_Click(object sender, EventArgs e)
        {
            fgBan_Nhom.Tree.Show(10);
        }

        private void mnu_CollapseAll_Click(object sender, EventArgs e)
        {
            fgBan_Nhom.Tree.Show(0);
        }

        private void mnu_ThemMoi_Click(object sender, EventArgs e)
        {
            var fg = fgBan_Nhom;
            frmNhom frm;
            if (fgBan_Nhom.Row < fgBan_Nhom.Rows.Fixed || fgBan_Nhom.Row > fgBan_Nhom.Rows.Count)
            {
                frm = new frmNhom();
                frm.frmQLTD = this;
                frm.ShowDialog();
            }
            else
            {
                int iID_Nhom = int.Parse(fgBan_Nhom.Rows[fgBan_Nhom.Row]["ID_Nhom"].ToString());
                frm = new frmNhom(iID_Nhom);
                frm.frmQLTD = this;
                frm.ShowDialog();
            }
        }

        private void mnu_Xoa_Click(object sender, EventArgs e)
        {
            var fg = fgBan_Nhom;
            if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn nhóm.");
                return;
            }
            if (fg.GetDataDisplay(fg.Row, "ID_Nhom") == "")
            {
                fg.Rows.Remove(fg.Row);
            }
            else
            {
                if (fg.Row < fg.Rows.Count - 1 && fg.Rows[fg.Row + 1].Node.Level > fg.Rows[fg.Row].Node.Level)
                {
                    BaseMessages.ShowWarningMessage("Không được xóa nhóm cha");
                    return;
                }
                if (BaseMessages.ShowDeleteQuestionMessage() == DialogResult.Yes)
                {
                    clsNhom cls = new clsNhom();
                    cls.ID_Nhom = fg.GetIntValue(fg.Row, "ID_Nhom");
                    cls.SelectOne();
                    cls.TonTai = false;
                    cls.Update();
                    BaseMessages.ShowInformationMessage("Xóa thành công !!!");
                }
            }
        }

        private void Load_dtmap_Nhom_ChucVu()
        {
            clsDM_Nhom_ChucVu cls = new clsDM_Nhom_ChucVu();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt = dt.DefaultView.ToTable();
            var drow = dt.NewRow();
            drow["ID_Nhom_ChucVu"] = 0;
            drow["Ten_Nhom_ChucVu"] = "";
            dt.Rows.Add(drow);
            dt.DefaultView.Sort = "Ten_Nhom_ChucVu ASC";
            fgNS_Nhom.LoadDataMap("ID_Nhom_ChucVu", dt.DefaultView.ToTable(), "ID_Nhom_ChucVu", "Ten_Nhom_ChucVu", false);
        }

        private void btnChonNS_Click(object sender, EventArgs e)
        {
            if (fgBan_Nhom.Row < fgBan_Nhom.Rows.Fixed || fgBan_Nhom.Row < fgBan_Nhom.Rows.Fixed)
            {
                return;
            }
            else
            {
                frmChonNhanSu frm = new frmChonNhanSu();
                frm.ShowDialog();
                if (frm != null)
                {
                    fgNS_Nhom.Rows.Add();
                    
                    fgNS_Nhom.Rows[fgNS_Nhom.Rows.Count - 1]["IsEdit"] = "1";
                    fgNS_Nhom.Rows[fgNS_Nhom.Rows.Count - 1]["ID_NhanSu"] = frm.iID_NhanSu;
                    fgNS_Nhom.Rows[fgNS_Nhom.Rows.Count - 1]["ID_Nhom"] = fgBan_Nhom.GetIntValue(fgBan_Nhom.Row, "ID_Nhom");
                    fgNS_Nhom.Rows[fgNS_Nhom.Rows.Count - 1]["LaQuanLy"] = true;
                    fgNS_Nhom.Rows[fgNS_Nhom.Rows.Count - 1]["MaNS"] = frm.sMaNS;
                    fgNS_Nhom.Rows[fgNS_Nhom.Rows.Count - 1]["HoTen"] = frm.sHoTen;
                    fgNS_Nhom.SetSTT();
                    IsValid();
                }
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            var fg = fgBan_Nhom;
            frmNhom frm;
            if (fgBan_Nhom.Row < fgBan_Nhom.Rows.Fixed || fgBan_Nhom.Row > fgBan_Nhom.Rows.Count)
            {
                frm = new frmNhom();
                frm.frmQLTD = this;
                frm.ShowDialog();
            }
            else
            {
                int iID_Nhom = int.Parse(fgBan_Nhom.Rows[fgBan_Nhom.Row]["ID_Nhom"].ToString());
                frm = new frmNhom(iID_Nhom);
                frm.frmQLTD = this;
                frm.ShowDialog();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            frmNhom frm;
            if (fgBan_Nhom.Row < fgBan_Nhom.Rows.Fixed || fgBan_Nhom.Row > fgBan_Nhom.Rows.Count) return;
            int iID_Nhom = int.Parse(fgBan_Nhom.Rows[fgBan_Nhom.Row]["ID_Nhom"].ToString());
            frm = new frmNhom(iID_Nhom, true);
            frm.frmQLTD = this;
            frm.ShowDialog();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var fg = fgBan_Nhom;
            if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn nhóm.");
                return;
            }
            if (fg.GetDataDisplay(fg.Row, "ID_Nhom") == "")
            {
                fg.Rows.Remove(fg.Row);
            }
            else
            {
                if (fg.Row < fg.Rows.Count - 1 && fg.Rows[fg.Row + 1].Node.Level > fg.Rows[fg.Row].Node.Level)
                {
                    BaseMessages.ShowWarningMessage("Không được xóa nhóm cha");
                    return;
                }
                if (BaseMessages.ShowDeleteQuestionMessage() == DialogResult.Yes)
                {
                    clsNhom cls = new clsNhom();
                    cls.ID_Nhom = fg.GetIntValue(fg.Row, "ID_Nhom");
                    cls.SelectOne();
                    cls.TonTai = false;
                    cls.Update();
                    BaseMessages.ShowInformationMessage("Xóa thành công !!!");
                    LoadfgBan_Nhom();
                }
            }
        }

        private void fgBan_Nhom_AfterRowChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
        {
            if (fgBan_Nhom.Tag.ToString() == "0" || fgBan_Nhom.Row < fgBan_Nhom.Rows.Fixed || fgBan_Nhom.GetDataDisplay(fgBan_Nhom.Row, "ID_Nhom") == "") return;
            fgNS_Nhom.Rows.Count = fgNS_Nhom.Rows.Fixed;
            Load_fgNS_Nhom();
        }

        private void Load_fgNS_Nhom()
        {
            var fg = fgNS_Nhom;
            if (fgBan_Nhom.Tag.ToString() == "0" || fgBan_Nhom.Row < fgBan_Nhom.Rows.Fixed || fgBan_Nhom.GetDataDisplay(fgBan_Nhom.Row, "ID_Nhom") == "") return;
            fg.Tag = 0;
            clsNhom_NhanSu cls = new clsNhom_NhanSu();
            DataTable dt = cls.Nhom_NhanSu_SelectAll_By_ID_Nhom(int.Parse(fgBan_Nhom.GetDataDisplay(fgBan_Nhom.Row, "ID_Nhom")));
            fgNS_Nhom.SetDataSource(dt);
            fg.Row = -1;
            fg.AutoSizeRows();
            fg.Tag = 1;
        }

        private void fgNS_Nhom_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnCapNhat.Visible) return;
            if (fgNS_Nhom.Row < fgNS_Nhom.Rows.Fixed || fgNS_Nhom.Row > fgNS_Nhom.Rows.Count)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn nhân sự !!!");
                return;
            }
            else
            {
                if (e.KeyCode == Keys.Delete)
                {
                    if (fgNS_Nhom.GetDataDisplay(fgNS_Nhom.Row, "ID_NhanSu") == "") fgNS_Nhom.Rows.Remove(fgNS_Nhom.Row);
                    else
                    {
                        fgNS_Nhom.Rows[fgNS_Nhom.Row].Visible = false;
                        fgNS_Nhom.Rows[fgNS_Nhom.Row]["IsEdit"] = "0";
                        fgNS_Nhom.SetSTT();
                    }
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LockEdit(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            clsNhom_NhanSu cls = new clsNhom_NhanSu();
            for (int i = fgNS_Nhom.Rows.Fixed; i < fgNS_Nhom.Rows.Count; i++)
            {
                if (fgNS_Nhom.GetDataDisplay(i, "IsEdit") == "") continue;
                cls.ID_Nhom = fgBan_Nhom.GetIntValue(fgBan_Nhom.Row, "ID_Nhom");
                cls.ID_NhanSu = fgNS_Nhom.GetIntValue(i, "ID_NhanSu");
                string strNhomCV = fgNS_Nhom.GetDataDisplay(i,"ID_Nhom_ChucVu");
                if (strNhomCV=="")
                {
                    BaseMessages.ShowInformationMessage("Chưa chọn chức vụ trong nhóm cho nhân viên dòng thứ "+ i + " !");
                    return;
                }
                else
                {
                    cls.ID_Nhom_ChucVu = int.Parse(fgNS_Nhom[i, "ID_Nhom_ChucVu"].ToString());
                }
                if (int.Parse(fgNS_Nhom[i, "ID_Nhom_ChucVu"].ToString()) == 1)
                {
                    cls.LaQuanLy = true;
                }
                else
                {
                    cls.LaQuanLy = false;
                }
                cls.InsertOrUpdate();
                if (fgNS_Nhom.GetDataDisplay(i, "IsEdit") == "0")
                {
                    cls.Delete();}
            }
            BaseMessages.ShowInformationMessage("Cập nhật thành công!");
            LockEdit(true);
            Load_fgNS_Nhom();
        }

        private void IsValid()
        {
            var fg = fgNS_Nhom;
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (!fg.Rows[i].Visible) continue;
                for (var j = i + 1; j < fg.Rows.Count; j++)
                {
                    if (!fg.Rows[j].Visible) continue;
                    if (fg.GetDataDisplay(i, "ID_NhanSu").ToLower().Trim() != fg.GetDataDisplay(j, "ID_NhanSu").ToLower().Trim()) continue;
                    BaseMessages.ShowErrorMessage("Nhân sự dòng thứ " + i + " và dòng thứ " + j + " trùng nhau!");
                    fg.Rows.Remove(j);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowUndoQuestionMessage() == DialogResult.No) return;
            LockEdit(true);
            Load_fgNS_Nhom();
        }

        private void LockEdit(bool p)
        {
            btnCapNhat.Visible = p;
            btnHuy.Visible = !p;
            btnLuu.Visible = !p;
            btnChonNS.Visible = !p;
            fgNS_Nhom.AllowEditing = !p;
        }

        private void fgNS_Nhom_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            fgNS_Nhom.Rows[e.Row]["IsEdit"] = "1";
        }
    }
}