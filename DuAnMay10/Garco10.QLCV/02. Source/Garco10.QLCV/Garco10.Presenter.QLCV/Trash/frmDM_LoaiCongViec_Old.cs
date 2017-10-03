using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Garco10.SystemModule.Forms;
using VSCM.Base.Forms;
using C1.Win.C1FlexGrid;
using VSCM.Base.Utils;
using System.Data.SqlTypes;
using System.Collections.Specialized;
using M10_QLCV;

namespace Garco10.Presenter.QLCV.DanhMuc
{
    public partial class frmDM_LoaiCongViec_Old : FormBaseGarco10
    {
        public frmDM_LoaiCongViec_Old()
        {
            InitializeComponent();
        }

        private void frmDM_LoaiCongViec_Load(object sender, EventArgs e)
        {
            LockEdit(true);
            Loadfg();
        }
        private void LockEdit(bool p)
        {
            btnCapNhat.Visible = p;
            btnHuy.Visible = !p;
            btnLuu.Visible = !p;
            lblHuongDan.Visible = !p;
            fg.Cols["ID_LoaiCV_Cha"].Visible = !p;
            fg.AllowEditing = !p;
        }

        private void Loadfg()
        {
            fg.Tag = 0;
            fg.BeginUpdate();
            clsDM_LoaiCV cls = new clsDM_LoaiCV();
            DataTable dt = cls.SelectAll_Sorted();
            dt.DefaultView.RowFilter = "TonTai = 1";
            fg.Rows.Count = fg.Rows.Fixed;
            fg.SetDataSource(dt.DefaultView.ToTable());

            //create treeview
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                int level = 0;
                if ((fg[i, "ID_LoaiCV_Cha"] ?? "").ToString() == "")
                {
                    fg.Rows[i].IsNode = true;
                    fg.Rows[i].Node.Level = level;
                    GroupBy(i, level + 1);
                }
            }

            //add combobox column
            clsDM_LoaiCV clsCha = new clsDM_LoaiCV();
            dt = clsCha.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt = dt.DefaultView.ToTable();
            DataRow dr = dt.NewRow();
            dr["ID_LoaiCV"] = 0;
            dr["Ten_LoaiCV"] = "";
            dt.Rows.Add(dr);
            dt.DefaultView.Sort = "Ten_LoaiCV ASC";
            ListDictionary datamap = new ListDictionary();
            for (int i = 0; i <= dt.DefaultView.ToTable().Rows.Count - 1; i++)
            {
                datamap.Add(dt.DefaultView.ToTable().Rows[i][0], dt.DefaultView.ToTable().Rows[i][1]);
            }
            fg.Cols["ID_LoaiCV_Cha"].DataMap = datamap;

            fg.Tree.Column = 1;
            fg.Tree.Style = TreeStyleFlags.Symbols;
            fg.Tree.Show(0);

            fg.Row = -1;
            //fg.AutoSizeRows();
            //Add STT
            int stt1 = 1;
            int stt2 = 1;
            int stt3 = 1;
            int stt4 = 1;
            int stt5 = 1;
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
            {
                if (fg.Rows[i].Node.Level == 0)
                {
                    fg[i, "STT"] = stt1;
                    ++stt1;
                    stt2 = 1;
                }
                if (fg.Rows[i].Node.Level == 1)
                {
                    fg[i, "STT"] = "    " + (stt1 - 1) + "." + stt2;
                    ++stt2;
                    stt3 = 1;
                }
                if (fg.Rows[i].Node.Level == 2)
                {
                    fg[i, "STT"] = "        " + (stt1 - 1) + "." + (stt2 - 1) + "." + stt3;
                    ++stt3;
                    stt4 = 1;
                }
                if (fg.Rows[i].Node.Level == 3)
                {
                    fg[i, "STT"] = "            " + (stt1 - 1) + "." + (stt2 - 1) + "." + (stt3 - 1) + "." + stt4;
                    ++stt4;
                    stt5 = 1;
                }
                if (fg.Rows[i].Node.Level == 4)
                {
                    fg[i, "STT"] = "                " + (stt1 - 1) + "." + (stt2 - 1) + "." + (stt3 - 1) + "." + (stt4 - 1) + "." + stt5;
                    ++stt5;
                }
            }
            //fg.AutoSizeCols(fg.Cols["STT"].Index);
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void GroupBy(int index, int level)
        {
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if ((fg[i, "ID_LoaiCV_Cha"] ?? "").ToString() == fg.GetDataDisplay(index, "ID_LoaiCV"))
                {
                    if (fg.Rows[i].IsNode) continue;
                    fg.Rows[i].IsNode = true;
                    fg.Rows[i].Node.Level = level;
                    GroupBy(i, level + 1);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowUndoQuestionMessage() == DialogResult.No) return;
            LockEdit(true);
            Loadfg();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValid()
        {
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (!fg.Rows[i].Visible) continue;
                String ten_LoaiCV = fg.GetDataDisplay(i, "Ten_LoaiCV").ToLower().Trim();
                if (ten_LoaiCV == "")
                {
                    BaseMessages.ShowErrorMessage("Chưa nhập loại công việc dòng thứ " + i + "!");
                    return false;
                }
                if (fg.GetIntValue(i, "ID_LoaiCV") == fg.GetIntValue(i, "ID_LoaiCV_Cha") && fg.GetIntValue(i, "ID_LoaiCV_Cha") != 0)
                {
                    BaseMessages.ShowErrorMessage("Không được phép thực hiện thao tác này!");
                    return false;
                }
                //if (fg.GetIntValue(i, "ID_LoaiCV") == fg.GetIntValue(i+1, "ID_LoaiCV_Cha") && fg.GetIntValue(i, "ID_LoaiCV_Cha") == fg.GetIntValue(i+1, "ID_LoaiCV"))
                //{
                //    BaseMessages.ShowErrorMessage("Không được tạo loại công việc vòng tròn");
                //    return false;
                //}
                for (int j = i + 1; j < fg.Rows.Count; j++)
                {
                    if (!fg.Rows[j].Visible) continue;
                    if (fg.GetDataDisplay(j, "Ten_LoaiCV").ToLower().Trim() != ten_LoaiCV) continue;
                    BaseMessages.ShowErrorMessage("Tên loại công việc dòng thứ " + i + " và dòng thứ " + j + " trùng nhau!");

                    return false;
                }
                int row = 0;
                if (!ThoaManCongViecGoc(i,out row))
                {
                    BaseMessages.ShowErrorMessage("Loại CV " + fg.GetDataDisplay(i, "Ten_LoaiCV").ToString() + " và " + fg.GetDataDisplay(row, "Ten_LoaiCV").ToString() + " là cha con của nhau");
                    return false;
                }
            }
            return true;
        }

        private bool ThoaManCongViecGoc(int row,out int rowLap)
        {
            rowLap = 0;
            int ID_LoaiCV = 0;
            int ID_LoaiCV_Cha = 0;
            int.TryParse(fg.GetDataDisplay(row, "ID_LoaiCV"), out ID_LoaiCV);
            if (fg.Rows[row]["ID_LoaiCV_Cha"] ==null) return true;
            int.TryParse(fg.Rows[row][ "ID_LoaiCV_Cha"].ToString(), out ID_LoaiCV_Cha);
            if (ID_LoaiCV == 105)
            {
                int sad = 0;
            }
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
            {
                if (i == 47)
                {
                    int asd = 0;
                }
                if (i == row) continue;
                int ID_LoaiCV_Moi = 0;
                int ID_LoaiCV_Cha_Moi = 0;
                int.TryParse(fg.GetDataDisplay(i, "ID_LoaiCV"), out ID_LoaiCV_Moi);
                if (fg.Rows[i]["ID_LoaiCV_Cha"] == null) continue;
                int.TryParse(fg.Rows[i]["ID_LoaiCV_Cha"].ToString(), out ID_LoaiCV_Cha_Moi);
                
                if (ID_LoaiCV == ID_LoaiCV_Cha_Moi)
                {
                    ID_LoaiCV = ID_LoaiCV_Moi;
                    if (ID_LoaiCV_Cha == ID_LoaiCV_Moi)
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
            clsDM_LoaiCV cls = new clsDM_LoaiCV();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.GetDataDisplay(i, "IsEdit").ToLower() == "") continue;
                cls.ID_LoaiCV_Cha = ((fg[i, "ID_LoaiCV_Cha"] ?? "").ToString() == "") ? SqlInt32.Null : Convert.ToInt32(fg[i, "ID_LoaiCV_Cha"]);
                cls.Ten_LoaiCV = fg.GetDataDisplay(i, "Ten_LoaiCV").Trim();
                cls.SuDung = fg.GetBoolValue(i, "SuDung");
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
            Loadfg();
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
            if (btnCapNhat.Visible)
            {
                BaseMessages.ShowInformationMessage("Bạn chưa ấn nút cập nhật nên không thể thực hiện chức năng "+e.KeyCode.ToString()+"");    
                return; 
            }
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    for (int i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
                    {
                        if (fg.GetDataDisplay(i, "Ten_LoaiCV").ToString() == "")
                        {
                            BaseMessages.ShowWarningMessage("Dòng thứ " + i + " chưa nhập");
                            return;
                        }
                    }
                    if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
                    {
                        fg.Rows.InsertNode(fg.Rows.Count, 0);
                        fg.Rows[fg.Rows.Count - 1]["IsEdit"] = "1";
                        fg.Rows[fg.Rows.Count - 1]["SuDung"] = true;


                    }
                    else
                    {
                        int level = fg.Rows[fg.Row].Node.Level;
                        if (fg.Row < fg.Rows.Count - 1)
                        {
                            if (fg.Rows[fg.Row].Node.Level < fg.Rows[fg.Row + 1].Node.Level)
                            {
                                ++level;
                            }
                        }
                        fg.Rows.InsertNode(fg.Row + 1, level);
                        if (level == fg.Rows[fg.Row].Node.Level)
                        {
                            fg.Rows[fg.Row + 1]["ID_LoaiCV_Cha"] = fg.Rows[fg.Row]["ID_LoaiCV_Cha"];
                        }
                        else 
                        {
                            fg.Rows[fg.Row + 1]["ID_LoaiCV_Cha"] = fg.Rows[fg.Row+2]["ID_LoaiCV_Cha"];
                        }
                        fg.Rows[fg.Row + 1]["IsEdit"] = "1";
                        fg.Rows[fg.Row + 1]["SuDung"] = true;
                    }
                    //fg.SetSTT();
                    break;
                case Keys.Delete:
                    if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
                    {
                        BaseMessages.ShowInformationMessage("Chưa chọn loại công việc.");
                        return;
                    }
                    if (fg.GetDataDisplay(fg.Row, "ID_LoaiCV") == "")
                        fg.Rows.Remove(fg.Row);
                    else
                    {
                        if (BaseMessages.ShowDeleteQuestionMessage() == System.Windows.Forms.DialogResult.Yes)
                        {
                            fg.Rows[fg.Row]["IsEdit"] = "0";
                            fg.Rows[fg.Row].Visible = false;
                        }
                    }
                    //fg.SetSTT();
                    break;
            }
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            var searchString = txtTimKiem.Text.Trim().ToLower();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if ((fg.GetDataDisplay(i, "IsEdit") != "0") && (fg.GetDataDisplay(i, "Ten_LoaiCV").Trim().ToLower().Contains(searchString)))
                {
                    fg.Rows[i].Visible = true;
                }
                else
                {
                    fg.Rows[i].Visible = false;
                }
            }
        }

        private void fg_AfterCollapse(object sender, RowColEventArgs e)
        {
           // fg.AutoSizeCols(fg.Cols["STT"].Index);
        }
    }
}
