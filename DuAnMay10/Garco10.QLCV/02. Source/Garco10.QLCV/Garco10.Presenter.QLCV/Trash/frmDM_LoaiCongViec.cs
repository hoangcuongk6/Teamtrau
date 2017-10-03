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
    public partial class frmDM_LoaiCongViec : FormBaseGarco10
    {
        bool m_bIsLoadFromCV = false;
        public int m_iID_LoaiCV;
        public string m_sTen_LoaiCV;
        public frmDM_LoaiCongViec()
        {
            InitializeComponent();
        }
        public frmDM_LoaiCongViec(bool isCV)
        {
            InitializeComponent();
            m_bIsLoadFromCV = isCV;
        }
        private void frmDM_LoaiCongViec_Load(object sender, EventArgs e)
        {
            LoadData();
            if (m_bIsLoadFromCV)
            {
                btnThoat.Visible = false;
                btnSua.Visible = false;
                btnThemMoi.Visible = false;
                btnXoa.Visible = false;

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            var searchString = txtTimKiem.Text.Trim().ToLower();
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                if (
                    fg.GetDataDisplay(i, "Ten_LoaiCV").Trim().ToLower().Contains(searchString))
                    fg.Rows[i].Visible = true;
                else
                    fg.Rows[i].Visible = false;
        }

        public void LoadData()
        {
            fg.Tag = 0;
            fg.BeginUpdate();
            clsDM_LoaiCV cls = new clsDM_LoaiCV();
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
           // fg.Tree.Show(0);
            fg.Tag = 1;
        }


        public bool IsNode0(int row)
        {
            if (fg.GetDataDisplay(row, "ID_LoaiCV_Cha") == "") return true;
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (fg.GetDataDisplay(row, "ID_LoaiCV_Cha") == fg.GetDataDisplay(r, "ID_LoaiCV")) return false;
            }
            return true;
        }

        void GetDataTwoRow(int row1, int row2)
        {
            for (int c = fg.Cols.Fixed; c < fg.Cols.Count; ++c)
            {
                fg.Rows[row1][c] = fg.Rows[row2][c];
            }
        }

        bool TonTaiCongViecGoc(int level)
        {
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; r++)
            {
                if (!fg.Rows[r].Visible) continue;
                if (fg.Rows[r].Node.Level == 0 && fg.GetDataDisplay(r, "ID_LoaiCV_Cha").ToString() != "")
                {
                    for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                    {
                        if (!fg.Rows[i].Visible) continue;
                        if (fg.GetDataDisplay(r, "ID_LoaiCV_Cha").ToString() == fg.GetDataDisplay(i, "ID_LoaiCV").ToString() && fg.Rows[i].Node.Level == level && i != r)
                            return true;
                    }
                }
            }
            return false;
        }

        public int TimCongViecGoc(int row, int NodeLevel)
        {
            int ID_LoaiCV = int.Parse(fg.Rows[row]["ID_LoaiCV"].ToString());
            int r = fg.Rows.Fixed;
            for (r = fg.Rows.Fixed; r < fg.Rows.Count; ++r)
            {
                if (!fg.Rows[r].Visible || r == row || fg.GetDataDisplay(r, "ID_LoaiCV_Cha") == "") continue;
                if (ID_LoaiCV == int.Parse(fg.Rows[r]["ID_LoaiCV_Cha"].ToString()) && fg.Rows[r].Visible && fg.Rows[r].Node.Level == 0)
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

        void SetSTT()
        {
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

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Insert_LoaiCongViec();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
            {
                return;
            }
            else
            {
                frmLoaiCongViec frm;
                if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count) return;
                int iID_LoaiCV = int.Parse(fg.Rows[fg.Row]["ID_LoaiCV"].ToString());
                frm = new frmLoaiCongViec(iID_LoaiCV, true);
                frm.frmDM_LoaiCongViec = this;
                frm.ShowDialog();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Delete_LoaiCongViec();
        }

        private void fg_DoubleClick(object sender, EventArgs e)
        {
            if (m_bIsLoadFromCV)
            { 
                m_iID_LoaiCV=0;
                int.TryParse(fg.GetDataDisplay(fg.Row, "ID_LoaiCV").ToString(), out m_iID_LoaiCV);
                m_sTen_LoaiCV = fg.GetDataDisplay(fg.Row, "Ten_LoaiCV").ToString();
                Visible = false;
            }
            else
            {
                if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
                {
                    return;
                }
                else
                {
                    frmLoaiCongViec frm;
                    if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count) return;
                    int iID_LoaiCV = int.Parse(fg.Rows[fg.Row]["ID_LoaiCV"].ToString());
                    frm = new frmLoaiCongViec(iID_LoaiCV, true);
                    frm.frmDM_LoaiCongViec = this;
                    frm.ShowDialog();
                }
            }
        }

        private void Delete_LoaiCongViec()
        {
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
                    clsDM_LoaiCV cls = new clsDM_LoaiCV();
                    cls.ID_LoaiCV = fg.GetIntValue(fg.Row, "ID_LoaiCV");
                    cls.SelectOne();
                    cls.TonTai = false;
                    cls.Update();
                    BaseMessages.ShowInformationMessage("Xóa thành công !!!");
                }
            }
        }

        private void Insert_LoaiCongViec()
        {
            frmLoaiCongViec frm;
            if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
            {
                frm = new frmLoaiCongViec();
                frm.frmDM_LoaiCongViec = this;
                frm.ShowDialog();
            }
            else
            {
                int iID_Nhom = int.Parse(fg.Rows[fg.Row]["ID_LoaiCV"].ToString());
                frm = new frmLoaiCongViec(iID_Nhom);
                frm.frmDM_LoaiCongViec = this;
                frm.ShowDialog();
            }
        }
    }
}