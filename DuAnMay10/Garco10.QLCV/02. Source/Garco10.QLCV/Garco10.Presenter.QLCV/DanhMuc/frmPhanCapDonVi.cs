using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using M10_System;
using VSCM.Base.Utils;
using Garco10.SystemModule.HeThong;

namespace Garco10.Presenter.QLCV
{
    public partial class frmPhanCapDonVi : FormBaseGarco10
    {
        private bool m_bFlag = true;

        public frmPhanCapDonVi()
        {
            InitializeComponent();
        }

        private void frmPhanCapDonVi_Load(object sender, EventArgs e)
        {
            GlobalMethod.Load_cmbDonVi_TheoQuyen(cmbCapTren);
            LockEdit(true);
            Loadfg();
        }

        private void ResetComboboxs()
        {
            cmbCapTren.EditValue = null;
            cmbCapDuoi.EditValue = null;
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
            clsPhanCap_DonVi cls = new clsPhanCap_DonVi();
            DataTable dt = cls.SelectAll_With_Ten();
            fg.ClearRows();
            fg.SetDataSource(dt);
            LoadTree();
            int iSTT = 0;
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
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
            int col_Ten_DonVi_CapDuoi_Index = fg.Cols["Ten_DonVi_CapDuoi"].Index;
            GroupBy("Ten_DonVi_CapTren",col_Ten_DonVi_CapDuoi_Index, 0, "Đơn vị cấp trên:");
            fg.Cols["Ten_DonVi_CapTren"].Width = 0;
            fg.AllowMerging = AllowMergingEnum.Nodes;
            fg.Tree.Column = 0;
            fg.Tree.Style = TreeStyleFlags.SimpleLeaf;
            fg.AutoSizeCol(fg.Tree.Column);
            fg.Tree.Show(0);
        }

        private void GroupBy(string columnName,int groupCol, int level, string caption)
        {
            var cs = fg.Styles[CellStyleEnum.Subtotal0];
            cs.BackColor = Color.FromArgb(0xd0, 0xd0, 0xd0);
            cs.ForeColor = Color.Black;
            cs.Font = new Font(fg.Font, FontStyle.Bold);

            object current = null;
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; r++)
            {
                if (!fg.Rows[r].IsNode)
                {
                    var value = fg[r, columnName];
                    if (!object.Equals(value, current))
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
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
        }

        private bool IsValid()
        {
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if ((!m_bFlag && i == fg.Row) || fg.Rows[i].IsNode) continue;
                if (cmbCapTren.EditValue.ToString() == fg[i, "ID_DonVi_CapDuoi"].ToString() && cmbCapDuoi.EditValue.ToString() == fg[i, "ID_DonVi_CapTren"].ToString())
                {
                    BaseMessages.ShowErrorMessage("Không thể quản lý cấp cao hơn!");
                    return false;
                }
                if (cmbCapTren.EditValue.ToString() == fg[i, "ID_DonVi_CapTren"].ToString() && cmbCapDuoi.EditValue.ToString() == fg[i, "ID_DonVi_CapDuoi"].ToString())
                {
                    BaseMessages.ShowErrorMessage("Dữ liệu trùng với dòng " + i + "!");
                    return false;
                }
            }
            return true;
        }

        private void SaveData()
        {
            clsPhanCap_DonVi cls = new clsPhanCap_DonVi();
            if (m_bFlag)
            {
                cls.ID_DonVi_CapTren = Convert.ToInt32(cmbCapTren.EditValue);
                cls.ID_DonVi_CapDuoi = Convert.ToInt32(cmbCapDuoi.EditValue);
                cls.Insert();
            }
            else
            {
                cls.ID_DonVi_CapTren = Convert.ToInt32(fg[fg.Row, "ID_DonVi_CapTren"]);
                cls.ID_DonVi_CapDuoi = Convert.ToInt32(fg[fg.Row, "ID_DonVi_CapDuoi"]);
                cls.Delete();
                cls.ID_DonVi_CapTren = Convert.ToInt32(cmbCapTren.EditValue);
                cls.ID_DonVi_CapDuoi = Convert.ToInt32(cmbCapDuoi.EditValue);
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
                BaseMessages.ShowInformationMessage("Chọn dòng để sửa.");
                return;
            }
            m_bFlag = false;
            LockEdit(false);
        }

        private void fg_AfterRowChange(object sender, RangeEventArgs e)
        {
            if ((fg.Tag + "" != "1") || (fg.Rows.Count < fg.Rows.Fixed)) 
            {
                return;
            }
            if (fg.Rows[fg.Row].IsNode) return;
            cmbCapTren.EditValue = Convert.ToInt32(fg[fg.Row, "ID_DonVi_CapTren"]);
            cmbCapDuoi.EditValue = Convert.ToInt32(fg[fg.Row, "ID_DonVi_CapDuoi"]);
        }

        private void cmbCapTren_EditValueChanged(object sender, EventArgs e)
        {
            if ((cmbCapTren.EditValue ?? "").ToString() == "")
            {
                cmbCapDuoi.Properties.DataSource = null;
                return;
            }
            LoadcmbCapDuoi();
        }

        private void LoadcmbCapDuoi()
        {
            var cmb = cmbCapDuoi;
            cmb.Tag = 0;
            clsDM_DonVi cls = new clsDM_DonVi();
            //DataTable dt = cls.SelectAllNVCapDuoi(Convert.ToInt32(cmbCapTren.EditValue));
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "ID_DonVi <> " + cmbCapTren.EditValue + " AND TonTai = 1 AND SuDung = 1";
            dt.DefaultView.Sort = "STT_DonVi ASC";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_DonVi";
            cmb.Properties.ValueMember = "ID_DonVi";
            cmb.Tag = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (fg.Row < fg.Rows.Fixed || fg.Rows[fg.Row].IsNode)
            {
                BaseMessages.ShowInformationMessage("Chọn dòng để sửa.");
                return;
            }
            if (BaseMessages.ShowDeleteQuestionMessage() == DialogResult.No) return;

            clsPhanCap_DonVi cls = new clsPhanCap_DonVi();
            cls.ID_DonVi_CapTren = Convert.ToInt32(cmbCapTren.EditValue);
            cls.ID_DonVi_CapDuoi = Convert.ToInt32(cmbCapDuoi.EditValue);
            cls.Delete();
            BaseMessages.ShowInformationMessage("Xóa thành công!");
            LockEdit(true);
            Loadfg();
        }

    }
}
