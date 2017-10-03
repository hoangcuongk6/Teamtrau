using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Garco10.SystemModule.Forms;
using C1.Win.C1FlexGrid;
using M10_CTL;
using Garco10.SystemModule.HeThong;
using C1.Win.C1List;
using VSCM.Base.Utils;
using M10_System;

namespace Garco10.Presenter.QLCV.DanhMuc
{
    public partial class frmDM_NgayNghiLe : FormBaseGarco10
    {
        bool bEdit = false, m_bQuyenCapNhat = false;
        
        public frmDM_NgayNghiLe()
        {
            InitializeComponent();
        }       
        
        private void frmDM_NgayNghiLe_Load(object sender, EventArgs e)
        {
            CellStyle cs1 = fg.Styles.Add("Le");
            CellStyle cs2 = fg.Styles.Add("Thuong");
            CellStyle cs3 = fg.Styles.Add("Thang");
            CellStyle cs4 = fg.Styles.Add("NghiBu");
            //CellStyle cs4 = fg.Styles.Add("Ngay");
            cs1.BackColor = Color.Yellow;
            cs2.BackColor = Color.White;
            cs3.BackColor = Color.SkyBlue;
            cs4.BackColor = Color.Orange;

            //cs4.BackColor = Color.Tomato;
            Format_Fg();
            Lock_Control(true);
            Load_cmbNam(cmbNam, false);
            Load_cmbDonVi();
        }

        public void Load_cmbDonVi()
        {
            clsDM_DonVi cls = new clsDM_DonVi();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "SuDung = 1 AND TonTai = 1";
            dt.DefaultView.Sort = "STT_DonVi ASC";
            cmbDonVi.Properties.DataSource = dt.DefaultView.ToTable();
            cmbDonVi.Properties.ValueMember = "ID_DonVi";
            cmbDonVi.Properties.DisplayMember = "Ten_DonVi";

            if (dt.DefaultView.ToTable().Rows.Count == 1) cmbDonVi.EditValue = dt.DefaultView.ToTable().Rows[0]["ID_DonVi"];
        }

        private void Load_Fg(int Nam)
        {
            Format_Fg();
            fg.BeginUpdate();
            clsDM_NgayLeTet cls = new clsDM_NgayLeTet();
            DataTable dt = cls.SelectAll();

            foreach (DataRow dr in dt.Select("Ngay >= '01/01/" + Nam.ToString() + "' And Ngay < '01/01/" + (Nam+1).ToString()+"'"))
            {
                DateTime daNgay = (DateTime)dr["Ngay"];
                fg.SetCellStyle(daNgay.Month, daNgay.Day, "Le");
                fg[daNgay.Month,daNgay.Day.ToString()] = "L";
            }

            clsDM_NgayNghiBu o = new clsDM_NgayNghiBu();
            dt = o.SelectAll();
            foreach (DataRow dr in dt.Select("Ngay >= '01/01/" + Nam.ToString() + "' And Ngay < '01/01/" + (Nam + 1).ToString() + "'"))
            {
                DateTime daNgay = (DateTime)dr["Ngay"];
                fg.SetCellStyle(daNgay.Month, daNgay.Day, "NghiBu");
                fg[daNgay.Month, daNgay.Day.ToString()] = "NB";
            }
            if (cmbDonVi.EditValue != null && cmbDonVi.EditValue.ToString() != "" && cmbDonVi.EditValue.ToString() != "0")
            {
                clsDM_NgayNghiBu_DonVi dt_dv = new clsDM_NgayNghiBu_DonVi();
                dt = dt_dv.SelectAll();
                foreach (DataRow dr in dt.Select("ID_DonVi =" + Int16.Parse(cmbDonVi.EditValue.ToString()) + " AND Ngay >= '01/01/" + Nam.ToString() + "' And Ngay < '01/01/" + (Nam + 1).ToString() + "'"))
                {
                    DateTime daNgay = (DateTime)dr["Ngay"];
                    fg.SetCellStyle(daNgay.Month, daNgay.Day, "NghiBu");
                    fg[daNgay.Month, daNgay.Day.ToString()] = "NB";
                }
            }
            fg.EndUpdate();

        }

        private void Format_Fg()
        {
            fg.Tag = 0;
            fg.BeginUpdate();
            fg.FocusRect = FocusRectEnum.Heavy;
            fg.HighLight = HighLightEnum.Never;

            fg.Rows.Count = 1;
            fg.Rows.Fixed = 1;
            
            fg.AllowMerging = AllowMergingEnum.Free;
            fg.Cols.Frozen = fg.Cols["Thang"].Index + 1;
            fg.Rows[0].AllowMerging = true;
            fg.Cols.Count = fg.Cols["Thang"].Index + 1;

            Column cl;
            for (int i = 1; i <= 31; i++)
            {
                cl = fg.Cols.Add();
                cl.Name = i.ToString();
                cl.Caption = i.ToString();
                cl.DataType = typeof(String);
                cl.TextAlign = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
                cl.TextAlignFixed = C1.Win.C1FlexGrid.TextAlignEnum.CenterCenter;
                cl.Width = (fg.Size.Width - 100)/31;
                cl.AllowMerging = false;
                //fg.SetCellStyle(0,i,"Ngay");
            }
            //fg.SetCellStyle(0, 0, "Ngay");
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
            for (int i = 1; i <= 12; i++)
            {
                fg.Rows.Add();
                fg[i, "Thang"] = "Tháng " + i.ToString();
                fg.SetCellStyle(i, 0 , "Thang");
            }
        }

        private void Lock_Control(bool b)
        {
            btnCapNhat.Visible = !b;
            btnLuuLai.Visible = !b;
            btnHuy.Visible = !b;
            cmbNam.Enabled = b;
        }

        private void cmbNam_TextChanged(object sender, EventArgs e)
        {
            if (cmbNam.Tag.ToString() == "0") return;
            if (cmbNam.Text == "") return;
            Load_Fg(int.Parse(cmbNam.Text));
        }

        private void Load_cmbNam(C1Combo cmb, bool wAll)
        {
            cmb.Tag = 0;
            cmb.AddItemSeparator = '|';
            cmb.ClearItems();
            //if (wAll) cmb.AddItem(string.Format("{0}|{1}", "0", "Tất cả"));
            for (int i = GlobalVariables.GetCurrentDateTime().Year + 1; i > 2005; i--)
            {
                cmb.AddItem(string.Format("{0}|{1}", i, i));
            }
            cmb.ColumnWidth = 0;
            if (wAll) cmb.SelectedIndex = 0;
            else cmb.SelectedIndex = cmb.FindStringExact(GlobalVariables.GetCurrentDateTime().Year.ToString(), 0, 0);
            cmb.Tag = 1;
        }

        private void fg_DoubleClick(object sender, EventArgs e)
        {
            if (btnCapNhat.Visible) return;
            if (fg.Col < 1) return;  
            switch (fg.Row)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    if (fg.Col == 31)
                    {
                        BaseMessages.ShowWarningMessage("Ngày này không tồn tại!");
                        return;
                    }
                    break;
                case 2:
                    if (fg.Col > 29 && int.Parse(cmbNam.Text) % 4 == 0)
                    {
                        BaseMessages.ShowWarningMessage("Ngày này không tồn tại!");
                        return;
                    }
                    else if (fg.Col > 28 && int.Parse(cmbNam.Text) % 4 != 0)
                    {
                        BaseMessages.ShowWarningMessage("Ngày này không tồn tại!");
                        return;
                    }
                    break;
            }
            if (fg.GetDataDisplay(fg.Row,fg.Col).Trim() == "")
            {
                fg[fg.Row, fg.Col] = "L";
                fg.SetCellStyle(fg.Row, fg.Col, "Le");
            }
            else if (fg.GetDataDisplay(fg.Row, fg.Col).Trim() == "L")
            {
                fg[fg.Row, fg.Col] = "NB";
                fg.SetCellStyle(fg.Row, fg.Col, "NghiBu");
            }
            else
            {
                fg[fg.Row, fg.Col] = "";
                fg.SetCellStyle(fg.Row, fg.Col, "Thuong");
            }
            bEdit = true;
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            if (bEdit)
            {
                Garco10.ConnectionProviders.clsConnectionProviderCTL oConn = new ConnectionProviders.clsConnectionProviderCTL();
                oConn.OpenConnection();
                oConn.BeginTransaction("Ghi");
                try
                {
                    clsDM_NgayLeTet cls = new clsDM_NgayLeTet();
                    clsDM_NgayNghiBu oNB = new clsDM_NgayNghiBu();
                    clsDM_NgayNghiBu_DonVi oNB_Dv = new clsDM_NgayNghiBu_DonVi();

                    cls.cpMainConnectionProvider = oConn;
                    oNB.cpMainConnectionProvider = oConn;
                    oNB_Dv.cpMainConnectionProvider = oConn;
                    DateTime Ngay = new DateTime();
                    cls.Delete_wNam(int.Parse(cmbNam.Text));
                   
                    if (cmbDonVi.EditValue != null && cmbDonVi.EditValue.ToString() != "" && cmbDonVi.EditValue.ToString() != "0")
                    {
                        oNB_Dv.Delete_wNam_And_wID_DonVi(Int16.Parse(cmbNam.Text), Int16.Parse(cmbDonVi.EditValue.ToString()));
                    }
                    else
                    {
                        oNB.Delete_wNam(Int16.Parse(cmbNam.Text));
                    }

                    for (int i = 1; i <= 12; i++)
                    {
                        for (int j = 1; j <= 31; j++)
                        {
                            if (fg.GetDataDisplay(i, j).ToString() == "") continue;
                            if (fg.GetDataDisplay(i, j).ToString() == "L")
                            {
                                Ngay = new DateTime(int.Parse(cmbNam.Text), i, j);
                                cls.Ngay = Ngay;
                                cls.GhiChu = "";
                                cls.Insert();
                            }                 
                            else if (fg.GetDataDisplay(i, j).ToString() == "NB")
                            {
                                if (cmbDonVi.EditValue != null && cmbDonVi.EditValue.ToString() != "" && cmbDonVi.EditValue.ToString() != "0")
                                {
                                    oNB_Dv.ID_DonVi = Int16.Parse(cmbDonVi.EditValue.ToString());
                                    oNB_Dv.Ngay = new DateTime(int.Parse(cmbNam.Text), i, j);
                                    oNB_Dv.Insert();
                                }
                                else
                                {
                                    oNB.Ngay = new DateTime(int.Parse(cmbNam.Text), i, j);
                                    oNB.GhiChu = "";
                                    oNB.Insert();
                                }
                            }                                 
                        }
                    }
                    oConn.CommitTransaction();
                }
                catch (Exception ex)
                {
                    oConn.RollbackTransaction("Ghi");
                    MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    oConn.CloseConnection(false);
                    oConn.Dispose();
                }
            }
            BaseMessages.ShowInformationMessage("Cập nhật thành công!");
            Lock_Control(true);
            bEdit = false;
            Load_Fg(int.Parse(cmbNam.Text));
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!m_bQuyenCapNhat)
            {
                BaseMessages.ShowNoRolesMessage();
                return;
            }
            Lock_Control(false);
        }

        private void fg_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnCapNhat.Visible) return;
            if (fg.Col < 1) return;
            switch (e.KeyCode)
            {
                case Keys.L:
                    fg[fg.Row, fg.Col] = "L";
                    fg.SetCellStyle(fg.Row, fg.Col, "Le");
                    bEdit = true;
                    break;
                case Keys.N:
                    fg[fg.Row, fg.Col] = "NB";
                    fg.SetCellStyle(fg.Row, fg.Col, "NghiBu");
                    bEdit = true;
                    break;
                case Keys.Delete:
                    fg[fg.Row, fg.Col] = "";
                    fg.SetCellStyle(fg.Row, fg.Col, "Thuong");
                    bEdit = true;
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Lock_Control(true);
            Load_Fg(int.Parse(cmbNam.Text));
            bEdit = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbNam.Text == "") return;
            Load_Fg(int.Parse(cmbNam.Text));
        }
    }
}
