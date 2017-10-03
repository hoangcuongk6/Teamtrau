using C1.Win.C1FlexGrid;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlTypes;
using System.Windows.Forms;
using Garco10.SystemModule.HeThong;
using VSCM.Base.Utils;

namespace Garco10.Presenter.QLCV.DanhMuc
{
    public partial class frmDM_LoaiCongViec_Old2 : FormBaseGarco10
    {
        public frmDM_LoaiCongViec_Old2(int id_DonVi)
        {
            InitializeComponent();
            //m_iID_DonVi = id_DonVi;
        }

        private int m_iID_DonVi;

        private void frmDM_LoaiCongViec_Load(object sender, EventArgs e)
        {
            LockEdit(true);
            GlobalMethod.Load_cmbDonVi_TheoQuyen(cmbDonVi); // Load cmbDonVi theo đơn vị của người đăng nhập
            //LoadData();
            cmbDonVi.EditValue = GlobalVariables.uID_DonVi;
        }

        private void LockEdit(bool p)
        {
            btnCapNhat.Visible = p;
            btnHuy.Visible = !p;
            btnLuu.Visible = !p;
            lblHuongDan.Visible = !p;
            fg.Cols["ID_LoaiCV_Cha"].Visible = !p;
            fg.AllowEditing = !p;
            if (p)
            {
                fg.Cols["Ten_LoaiCV"].Width = 600;
                // fg.Cols["ID_LoaiCV_Cha"].Width = 300;
            }
            else
            {
                fg.Cols["Ten_LoaiCV"].Width = 300;
                fg.Cols["ID_LoaiCV_Cha"].Width = 300;
            }
        }

        private void GroupBy(int index, int level)
        {
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                if ((fg[i, "ID_LoaiCV_Cha"] ?? "").ToString() == fg.GetDataDisplay(index, "ID_LoaiCV"))
                {
                    if (fg.Rows[i].IsNode) continue;
                    fg.Rows[i].IsNode = true;
                    fg.Rows[i].Node.Level = level;
                    GroupBy(i, level + 1);
                }
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
                if (!fg.Rows[i].Visible) continue;
                var ten_LoaiCV = fg.GetDataDisplay(i, "Ten_LoaiCV").ToLower().Trim();
                //if (ten_LoaiCV == "")
                //{
                //    BaseMessages.ShowErrorMessage("Chưa nhập loại công việc dòng có STT là " + fg.GetDataDisplay(i, "STT").ToLower().Trim().ToString() + "!");
                //    return false;
                //}
                if (fg.GetIntValue(i, "ID_LoaiCV") == fg.GetIntValue(i, "ID_LoaiCV_Cha") &&
                    fg.GetIntValue(i, "ID_LoaiCV_Cha") != 0)
                {
                    BaseMessages.ShowErrorMessage("Không được phép thực hiện thao tác này!");
                    return false;
                }
                //if (fg.GetIntValue(i, "ID_LoaiCV") == fg.GetIntValue(i+1, "ID_LoaiCV_Cha") && fg.GetIntValue(i, "ID_LoaiCV_Cha") == fg.GetIntValue(i+1, "ID_LoaiCV"))
                //{
                //    BaseMessages.ShowErrorMessage("Không được tạo loại công việc vòng tròn");
                //    return false;
                //}
                for (var j = i + 1; j < fg.Rows.Count; j++)
                {
                    if (!fg.Rows[j].Visible) continue;
                    if (fg.GetDataDisplay(j, "Ten_LoaiCV").ToLower().Trim() != ten_LoaiCV || fg.GetDataDisplay(j, "Ten_LoaiCV").ToLower().Trim().ToString() == "" || ten_LoaiCV.ToString() != "") continue;
                    BaseMessages.ShowErrorMessage("Tên loại công việc dòng thứ " + fg.GetDataDisplay(i, "STT").ToLower().Trim().ToString() + " và dòng thứ " + fg.GetDataDisplay(j, "STT").ToLower().Trim().ToString() +
                                                  " trùng nhau!");
                    return false;
                }
                var row = 0;
                if (!ThoaManCongViecGoc(i, out row))
                {
                    BaseMessages.ShowErrorMessage("Loại CV " + fg.GetDataDisplay(i, "Ten_LoaiCV") + " và " +
                                                  fg.GetDataDisplay(row, "Ten_LoaiCV") + " là cha con của nhau");
                    return false;
                }
            }
            return true;
        }

        private bool ThoaManCongViecGoc(int row, out int rowLap)
        {
            rowLap = 0;
            var ID_LoaiCV = 0;
            var ID_LoaiCV_Cha = 0;
            int.TryParse(fg.GetDataDisplay(row, "ID_LoaiCV"), out ID_LoaiCV);
            if (fg.Rows[row]["ID_LoaiCV_Cha"] == null) return true;
            int.TryParse(fg.Rows[row]["ID_LoaiCV_Cha"].ToString(), out ID_LoaiCV_Cha);
            if (ID_LoaiCV == 105)
            {
                var sad = 0;
            }
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
            {
                if (i == 47)
                {
                    var asd = 0;
                }
                if (i == row) continue;
                var ID_LoaiCV_Moi = 0;
                var ID_LoaiCV_Cha_Moi = 0;
                int.TryParse(fg.GetDataDisplay(i, "ID_LoaiCV"), out ID_LoaiCV_Moi);
                if (fg.Rows[i]["ID_LoaiCV_Cha"] == null) continue;
                int.TryParse(fg.Rows[i]["ID_LoaiCV_Cha"].ToString(), out ID_LoaiCV_Cha_Moi);

                if (ID_LoaiCV == ID_LoaiCV_Cha_Moi)
                {
                    ID_LoaiCV = ID_LoaiCV_Moi;
                    if (ID_LoaiCV_Cha == ID_LoaiCV_Moi && ID_LoaiCV_Cha != 0)
                    {
                        rowLap = i;
                        return false;
                    }
                    if (ID_LoaiCV_Cha == 0) return true;
                }
            }
            return true;
        }

        private void SaveData()
        {
            var cls = new clsDM_LoaiCV();
            //cls.ID_DonVi = m_iID_DonVi;
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.GetDataDisplay(i, "Ten_LoaiCV").Trim().ToString() == "") continue;
                if (fg.GetDataDisplay(i, "IsEdit").ToLower() == "") continue;
                cls.ID_LoaiCV_Cha = (fg[i, "ID_LoaiCV_Cha"] ?? "").ToString() == "" ? SqlInt32.Null : Convert.ToInt32(fg[i, "ID_LoaiCV_Cha"]);
                cls.Ten_LoaiCV = fg.GetDataDisplay(i, "Ten_LoaiCV").Trim();
                cls.SuDung = fg.GetBoolValue(i, "SuDung");
                cls.ID_DonVi = (cmbDonVi.EditValue ?? "").ToString() == "" ? SqlInt32.Null : Convert.ToInt32(cmbDonVi.EditValue);
                cls.STT_LoaiCV = fg[i, "STT"].ToString();
                //delete
                if (fg.GetDataDisplay(i, "IsEdit") == "0")
                {
                    cls.ID_LoaiCV = Convert.ToInt32(fg[i, "ID_LoaiCV"]);
                    cls.TonTai = false;
                    cls.Update();
                }
                else if (fg.GetDataDisplay(i, "IsEdit") == "1")
                {
                    cls.TonTai = true;
                    if (fg.GetDataDisplay(i, "ID_LoaiCV") == "")
                    {
                        cls.Insert();
                    }
                    else
                    {
                        cls.ID_LoaiCV = Convert.ToInt32(fg[i, "ID_LoaiCV"]);
                        cls.Update();
                    }
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            SaveData();
            BaseMessages.ShowInformationMessage("Cập nhật thành công!");
            LockEdit(true);
            LoadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LockEdit(false);
            //fg.Row = fg.Rows.Count - 1;
        }

        private void fg_AfterEdit(object sender, RowColEventArgs e)
        {
            fg[e.Row, "IsEdit"] = "1";
        }

        private void fg_KeyUp(object sender, KeyEventArgs e)
        {
            //if (btnCapNhat.Visible)
            //{
            //    BaseMessages.ShowInformationMessage("Bạn chưa ấn nút cập nhật nên không thể thực hiện chức năng " +
            //                                        e.KeyCode + "");
            //    return;
            //}
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    Insert_LoaiCongViec();
                    break;

                case Keys.Delete:
                    Delete_LoaiCongViec();
                    break;

                case Keys.PageUp:
                    if (fg.Row >= fg.Rows.Fixed)
                    {
                        fg.Rows[fg.Row]["IsEdit"] = "1";
                        fg.Rows[fg.Row].Move(fg.Row - 1);
                        fg[fg.Row, "STT_LoaiCV"] = Convert.ToInt32(fg[fg.Row, "STT_LoaiCV"]) - 1;
                        fg[fg.Row + 1, "STT_LoaiCV"] = Convert.ToInt32(fg[fg.Row + 1, "STT_LoaiCV"]) + 1;
                        fg.Rows[fg.Row + 1]["IsEdit"] = "1";
                    }
                    break;

                case Keys.PageDown:
                    if (fg.Row >= fg.Rows.Fixed && fg.Row < fg.Rows.Count - 1)
                    {
                        fg.Rows[fg.Row]["IsEdit"] = "1";
                        fg.Rows[fg.Row].Move(fg.Row + 1);
                        fg[fg.Row, "STT_LoaiCV"] = Convert.ToInt32(fg[fg.Row, "STT_LoaiCV"]) + 1;
                        fg[fg.Row - 1, "STT_LoaiCV"] = Convert.ToInt32(fg[fg.Row - 1, "STT_LoaiCV"]) - 1;
                        fg.Rows[fg.Row - 1]["IsEdit"] = "1";
                    }
                    break;
            }
            SetSTT();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            var searchString = txtTimKiem.Text.Trim().ToLower();
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                if (fg.GetDataDisplay(i, "IsEdit") != "0" &&
                    fg.GetDataDisplay(i, "Ten_LoaiCV").Trim().ToLower().Contains(searchString))
                    fg.Rows[i].Visible = true;
                else
                    fg.Rows[i].Visible = false;
        }

        private void fg_AfterCollapse(object sender, RowColEventArgs e)
        {
            // fg.AutoSizeCols(fg.Cols["STT"].Index);
        }

        private void SetSTT()
        {
            var trangThai = true;
            var level = 0;
            // fg.Rows[fg.Rows.Fixed]["STT"] = 1;
            while (trangThai)
            {
                var stt = 1;
                trangThai = false;
                for (var i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                    if (fg.Rows[i].Node.Level == level && fg.Rows[i].Visible)
                    {
                        var sttCha = "";
                        for (var j = i - 1; j >= fg.Rows.Fixed; --j)
                            if (fg.Rows[j].Node.Level < fg.Rows[i].Node.Level)
                            {
                                sttCha = fg.Rows[j]["STT"] + ".";
                                break;
                            }
                        if (i != fg.Rows.Fixed && fg.Rows[i].Node.Level > fg.Rows[i - 1].Node.Level) stt = 1;
                        fg.Rows[i]["STT"] = sttCha + stt;
                        ++stt;
                        trangThai = true;
                        if (i != fg.Rows.Count - 1 && fg.Rows[i].Node.Level > fg.Rows[i + 1].Node.Level) stt = 1;
                    }
                ++level;
            }
        }

        public void LoadData()
        {
            //
            var cls = new clsDM_LoaiCV();
            var dt = new DataTable();
            cls.ID_DonVi = int.Parse(cmbDonVi.EditValue.ToString());
            dt = cls.SelectAll_TheoDonVi();

            //
            fg.BeginUpdate();
            fg.Cols["ID_LoaiCV_Cha"].DataMap = null;
            fg.ClearRows();
            foreach (DataRow dr in dt.Rows)
            {
                var fgRow = fg.Rows.Add();
                fgRow["ID_LoaiCV"] = dr["ID_LoaiCV"];
                fgRow["Ten_LoaiCV"] = dr["Ten_LoaiCV"];
                fgRow["ID_LoaiCV_Cha"] = dr["ID_LoaiCV_Cha"];
                fgRow["TonTai"] = dr["TonTai"];
                fgRow["SuDung"] = dr["SuDung"];
                fgRow["ID_DonVi"] = dr["ID_DonVi"];
                fgRow["STT_LoaiCV"] = dr["STT_LoaiCV"];
            }
            //add combobox column

            //Add Node 0 công việc con
            for (var r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                fg.Rows[r].Visible = false;
                fg.Rows.InsertNode(r + 1, 0);
                GetDataTwoRow(r + 1, r);
                ++r;
            }
            for (var r = fg.Rows.Fixed; r < fg.Rows.Count; r++)
                if (!fg.Rows[r].Visible)
                {
                    fg.Rows.Remove(r);
                    r = r - 1;
                }
            //
            for (var r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
                if (fg.Rows[r].Node.Level == 0 && fg.Rows[r].Visible && IsNode0(r))
                    r = TimCongViecGoc(r, 1);
            var level = 1;
            while (TonTaiCongViecGoc(level))
            {
                for (var r1 = fg.Rows.Fixed; r1 < fg.Rows.Count; ++r1)
                    if (fg.Rows[r1].Node.Level == level && fg.Rows[r1].Visible)
                        r1 = TimCongViecGoc(r1, level + 1);
                ++level;
            }
            fg.Tree.Column = 1;

            ////////
            for (var r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
                if (!fg.Rows[r].Visible)
                {
                    fg.Rows.Remove(r);
                    --r;
                }
            SetSTT();
            fg.Tree.Show(0);
            var clsCha = new clsDM_LoaiCV();
            dt = clsCha.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt = dt.DefaultView.ToTable();
            var drow = dt.NewRow();
            drow["ID_LoaiCV"] = 0;
            drow["Ten_LoaiCV"] = "";
            dt.Rows.Add(drow);
            dt.DefaultView.Sort = "Ten_LoaiCV ASC";
            //add datamap
            var datamap = new ListDictionary();
            for (var i = 0; i <= dt.DefaultView.ToTable().Rows.Count - 1; i++)
                datamap.Add(dt.DefaultView.ToTable().Rows[i][0], dt.DefaultView.ToTable().Rows[i][1]);
            fg.Cols["ID_LoaiCV_Cha"].DataMap = datamap;
            fg.EndUpdate();
        }

        public bool IsNode0(int row)
        {
            if (fg.GetDataDisplay(row, "ID_LoaiCV_Cha") == "") return true;
            for (var r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
                if (fg.GetDataDisplay(row, "ID_LoaiCV_Cha") == fg.GetDataDisplay(r, "ID_LoaiCV")) return false;
            return true;
        }

        private bool TonTaiCongViecGoc(int level)
        {
            for (var r = fg.Rows.Fixed; r < fg.Rows.Count; r++)
            {
                if (!fg.Rows[r].Visible) continue;
                if (fg.Rows[r].Node.Level == 0 && fg.Rows[r]["ID_LoaiCV_Cha"].ToString() != "")
                    for (var i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                    {
                        if (!fg.Rows[i].Visible) continue;
                        if (fg.Rows[r]["ID_LoaiCV_Cha"].ToString() == fg.GetDataDisplay(i, "ID_LoaiCV") &&
                            fg.Rows[i].Node.Level == level && i != r)
                            return true;
                    }
            }
            return false;
        }

        private void GetDataTwoRow(int row1, int row2)
        {
            for (var c = fg.Cols.Fixed; c < fg.Cols.Count; ++c)
                fg.Rows[row1][c] = fg.Rows[row2][c];
        }

        public int TimCongViecGoc(int row, int NodeLevel)
        {
            var ID_LoaiCV = int.Parse(fg.Rows[row]["ID_LoaiCV"].ToString());
            var r = fg.Rows.Fixed;
            for (r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (fg.Rows[r]["ID_LoaiCV_Cha"].ToString() == "142" && fg.Rows[r]["ID_LoaiCV"].ToString() == "143" && ID_LoaiCV == 143)
                {
                }
                if (!fg.Rows[r].Visible || r == row || fg.Rows[r]["ID_LoaiCV_Cha"].ToString() == "") continue;
                if (ID_LoaiCV == int.Parse(fg.Rows[r]["ID_LoaiCV_Cha"].ToString()) && fg.Rows[r].Visible &&
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

        private void mnu_ThemMoi_Click(object sender, EventArgs e)
        {
            Insert_LoaiCongViec();
        }

        private void mnu_Xoa_Click(object sender, EventArgs e)
        {
            Delete_LoaiCongViec();
        }

        private void mnu_ExpandAll_Click(object sender, EventArgs e)
        {
            fg.Tree.Show(10);
        }

        private void mnu_CollapseAll_Click(object sender, EventArgs e)
        {
            fg.Tree.Show(0);
        }

        private void mnu_ThemMoiCon_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Visible)
            {
                BaseMessages.ShowInformationMessage("Bạn chưa ấn nút cập nhật nên không thể thực hiện chức năng này ");
                return;
            }

            if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
            {
                fg.Rows.InsertNode(fg.Rows.Count, 0);
                fg.Rows[fg.Rows.Count - 1]["IsEdit"] = "1";
                fg.Rows[fg.Rows.Count - 1]["SuDung"] = true;
            }
            else
            {
                var level = fg.Rows[fg.Row].Node.Level;
                if (fg.Row < fg.Rows.Count - 1)
                    if (fg.Rows[fg.Row].Node.Level < fg.Rows[fg.Row + 1].Node.Level)
                        ++level;
                fg.Rows.InsertNode(fg.Row + 1, level + 1);
                if (level == fg.Rows[fg.Row].Node.Level)
                    fg.Rows[fg.Row + 1]["ID_LoaiCV_Cha"] = fg.Rows[fg.Row]["ID_LoaiCV"];
                else
                    fg.Rows[fg.Row + 1]["ID_LoaiCV_Cha"] = fg.Rows[fg.Row + 2]["ID_LoaiCV"];
                fg.Rows[fg.Row + 1]["IsEdit"] = "1";
                fg.Rows[fg.Row + 1]["SuDung"] = true;
            }
        }

        private void fg_DoubleClick(object sender, EventArgs e)
        {
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
                BaseMessages.ShowInformationMessage("Chưa chọn loại công việc.");
                return;
            }
            if (fg.GetDataDisplay(fg.Row, "ID_LoaiCV") == "")
            {
                fg.Rows.Remove(fg.Row);
            }
            else
            {
                if (fg.Row < fg.Rows.Count - 1 && fg.Rows[fg.Row + 1].Node.Level > fg.Rows[fg.Row].Node.Level)
                {
                    BaseMessages.ShowWarningMessage("Không được xóa công việc cha");
                    return;
                }
                if (BaseMessages.ShowDeleteQuestionMessage() == DialogResult.Yes)
                {
                    fg.Rows[fg.Row]["IsEdit"] = "0";
                    fg.Rows[fg.Row].Visible = false;
                }
            }
        }

        private void Insert_LoaiCongViec()
        {
            if (btnCapNhat.Visible)
            {
                BaseMessages.ShowInformationMessage("Bạn chưa ấn nút cập nhật nên không thể thực hiện chức năng này ");
                return;
            }

            if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
            {
                fg.Rows.InsertNode(fg.Rows.Count, 0);
                fg.Rows[fg.Rows.Count - 1]["IsEdit"] = "1";
                fg.Rows[fg.Rows.Count - 1]["SuDung"] = true;
            }
            else
            {
                var level = fg.Rows[fg.Row].Node.Level;
                if (fg.Row < fg.Rows.Count - 1)
                    if (fg.Rows[fg.Row].Node.Level < fg.Rows[fg.Row + 1].Node.Level)
                        ++level;
                fg.Rows.InsertNode(fg.Row + 1, level);
                if (level == fg.Rows[fg.Row].Node.Level)
                    fg.Rows[fg.Row + 1]["ID_LoaiCV_Cha"] = fg.Rows[fg.Row]["ID_LoaiCV_Cha"];
                else
                    fg.Rows[fg.Row + 1]["ID_LoaiCV_Cha"] = fg.Rows[fg.Row + 2]["ID_LoaiCV_Cha"];
                fg.Rows[fg.Row + 1]["IsEdit"] = "1";
                fg.Rows[fg.Row + 1]["SuDung"] = true;
            }
        }

        private void cmbDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if ("" + cmbDonVi.EditValue == "") fg.ClearRows();
            else LoadData();
        }

        private void fg_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.PageUp:
                    e.Handled = true;
                    break;

                case Keys.PageDown:
                    e.Handled = true;
                    break;
            }
        }
    }
}