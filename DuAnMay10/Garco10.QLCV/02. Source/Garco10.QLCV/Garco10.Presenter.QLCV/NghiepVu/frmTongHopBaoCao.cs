using C1.Win.C1FlexGrid;
using Garco10.DataAccess.QLCV.Global;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using VSCM.Base.Utils;
using GlobalVariables = Garco10.SystemModule.HeThong.GlobalVariables;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmTongHopBaoCao : FormBaseGarco10
    {
        private CellStyle csChuaThucHien, csDangThucHien, csHuy, csDaXong, csMucDoThap, csMucDoTB, csMucDoCao;
        private string ds_ID_CongViec;
        private int m_iID_nhanSu;
        private string m_sds_NhanVien = "";
        private DateTime m_dtD1, m_dtD2, m_dtDtNow, m_dtD3, m_dtD4;
        private frmCongViec m_fFrmCv;

        public frmTongHopBaoCao()
        {
            InitializeComponent();
            InitCellStyles();
        }

         protected override void OnLoad(EventArgs e)
         {
             Opacity = 0;
             //VSCM.Base.Forms.WaitForm.ShowSplashScreen();
             base.OnLoad(e);
            fg.Rows.DefaultSize = 35;
            fg.AllowFiltering = true;
            m_dtDtNow = DateTime.Now;
            m_dtD1 = new DateTime(m_dtDtNow.Year, m_dtDtNow.Month, 1);
            dtmTuNgay.Value = m_dtD1;
            m_dtD2 = new DateTime(m_dtDtNow.Year, m_dtDtNow.Month, DateTime.DaysInMonth(m_dtDtNow.Year, m_dtDtNow.Month));
            dtmDenNgay.Value = m_dtD2;

            m_dtD3 = m_dtDtNow;
            dtpTuNgay.Value = m_dtD3;
            m_dtD4 = m_dtDtNow;
            dtpDenNgay.Value = m_dtD4;
            LoadcmbNhanVien();
            Loadfg();
             //VSCM.Base.Forms.WaitForm.CloseForm();
             Opacity = 1;
         }

        private void LoadcmbNguoiThucHien()
        {
            var cmb = cmbNguoiThucHien;
            cmb.Tag = 0;
            var cls = new clsNhanSu();
            var dt = cls.GetNhanSu(GlobalVariables.uID_DonVi, 0);
            dt.DefaultView.RowFilter = "TrangThai_DiLam = 'Đang đi làm'";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Properties.SeparatorChar = ',';
            var editValues = new List<string>();
            foreach (DataRow dr in dt.Rows)
                editValues.Add(dr["ID_NhanSu"].ToString());
            var s = string.Join(",", editValues.ToArray());
            cmbNguoiThucHien.SetEditValue(s);
            cmb.Tag = 1;
        }

        private void InitCellStyles()
        {
            csChuaThucHien = fg.Styles.Add("Chưa thực hiện");
            csChuaThucHien.BackColor = Color.White;
            csDangThucHien = fg.Styles.Add("Đang thực hiện");
            csDangThucHien.BackColor = Color.LightSkyBlue;
            csDaXong = fg.Styles.Add("Đã xong");
            csDaXong.BackColor = Color.LawnGreen;
            csHuy = fg.Styles.Add("Hủy");
            csHuy.BackColor = Color.Crimson;
            csHuy.ForeColor = Color.White;

            csMucDoCao = fg.Styles.Add("Cao");
            csMucDoCao.ForeColor = Color.Red;
            csMucDoTB = fg.Styles.Add("Trung bình");
            csMucDoTB.ForeColor = Color.MediumBlue;
            csMucDoThap = fg.Styles.Add("Thấp");
            csMucDoThap.ForeColor = Color.Maroon;
        }

        private void LoadcmbNhanVien()
        {
            var cmb = cmbNhanVien;
            cmb.Tag = 0;
            var cls = new clsNhanSu();
            var dt = cls.GetNhanSu(GlobalVariables.uID_DonVi, 0);
            dt.DefaultView.RowFilter = "TrangThai_DiLam = 'Đang đi làm'";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Properties.SeparatorChar = ',';
            var editValues = new List<string>();
            foreach (DataRow dr in dt.Rows)
                editValues.Add(dr["ID_NhanSu"].ToString());
            var s = string.Join(",", editValues.ToArray());
            cmbNhanVien.SetEditValue(s);

            cmb.Tag = 1;
        }

        private void cbShowAll_CheckedChanged(object sender, EventArgs e)
        {
            var p = cbShowAll.Checked;
            fg.Cols["Ten_LoaiCV"].Visible = p;
            fg.Cols["Ngay_YeuCau"].Visible = p;
            fg.Cols["ThoiGian_DuKien"].Visible = p;
            fg.AutoSizeRows();
        }

        private void cbToggleView_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbToggleView.Checked)
                for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                {
                    var ID_TrangThai = Convert.ToInt32(fg[i, "ID_TrangThai"]);
                    if (ID_TrangThai == (int)TrangThai.ChuaThucHien)
                        fg.Rows[i].Style = csChuaThucHien;
                    else if (ID_TrangThai == (int)TrangThai.DangThucHien)
                        fg.Rows[i].Style = csDangThucHien;
                    else if (ID_TrangThai == (int)TrangThai.Huy)
                        fg.Rows[i].Style = csHuy;
                    else if (ID_TrangThai == (int)TrangThai.DaXong)
                        fg.Rows[i].Style = csDaXong;
                }
            else
                for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                    fg.Rows[i].Style = null;
            fg.AutoSizeRows();
        }

        private void fg_AfterFilter(object sender, EventArgs e)
        {
            applySearchFilter();
            applyNhanVienFilter();
            fg.EndUpdate();
        }

        private void applySearchFilter()
        {
            //var searchString = txtTimKiem.Text.Trim().ToLower();
            //for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            //{
            //    if (fg.Rows[i].IsVisible)
            //    {
            //        if ((fg.GetDataDisplay(i, "MoTa").Trim().ToLower().Contains(searchString))
            //            || (fg.GetDataDisplay(i, "Ten_NguoiYeuCau").Trim().ToLower().Contains(searchString)))
            //        {
            //            fg.Rows[i].Visible = true;
            //        }
            //        else
            //        {
            //            fg.Rows[i].Visible = false;
            //        }
            //    }
            //}
            //fg.SetSTT();
        }

        private void applyNhanVienFilter()
        {
            var cmbSelectedValues = cmbNhanVien.Properties.GetDisplayText(cmbNhanVien.EditValue)
                .Split(cmbNhanVien.Properties.SeparatorChar)
                .Select(item => item.Trim())
                .ToList();
            List<string> nhanVienNames;
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                if (fg.Rows[i].IsVisible)
                {
                    nhanVienNames = GetNhanVienNames(i);
                    if (nhanVienNames.Any(item => cmbSelectedValues.Contains(item)))
                        fg.Rows[i].Visible = true;
                    else if (nhanVienNames.Count == 0)
                        fg.Rows[i].Visible = true;
                    else
                        fg.Rows[i].Visible = false;
                }
            fg.SetSTT();
        }

        private List<string> GetNhanVienNames(int fgRow)
        {
            var tenNhanVien = new List<string>();
            if ((fg[fgRow, "DS_Ten_NhanVien"] ?? "").ToString() != "")
            {
                var arr = fg[fgRow, "DS_Ten_NhanVien"].ToString().Trim().Split('\n');
                for (var j = 0; j < arr.Length; j++)
                    if (arr[j] != "")
                        tenNhanVien.Add(arr[j]);
            }
            return tenNhanVien;
        }

        private void fg_BeforeFilter(object sender, CancelEventArgs e)
        {
            fg.BeginUpdate();
        }

        private void Loadfg()
        {
            fg.Tag = 0;
            fg.BeginUpdate();
            var cls = new clsCongViec();
            m_dtD1 = (DateTime)dtmTuNgay.Value;
            m_dtD2 = (DateTime)dtmDenNgay.Value;
            if (m_dtD1.Date > m_dtD2.Date)
            {
                BaseMessages.ShowWarningMessage("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                return;
            }
            if ((int)(m_dtD2.Date - m_dtD1.Date).TotalDays > 365)
            {
                BaseMessages.ShowWarningMessage("Khoảng thời gian quá dài");
                return;
            }

            DataTable dt;

            dt = cls.SelectAll_CongViec(m_dtD1, m_dtD2, m_sds_NhanVien);
            fg.ClearRows();
            fg.SetDataSource(dt);
            var ID_NhanVien = m_sds_NhanVien.ToString().Split(',');
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                var ID_TrangThai = Convert.ToInt32(fg[i, "ID_TrangThai"]);

                if (ID_TrangThai == (int)TrangThai.ChuaThucHien)
                    fg.Rows[i].Style = csChuaThucHien;
                else if (ID_TrangThai == (int)TrangThai.DangThucHien)
                    fg.Rows[i].Style = csDangThucHien;
                else if (ID_TrangThai == (int)TrangThai.Huy)
                    fg.Rows[i].Style = csHuy;
                else if (ID_TrangThai == (int)TrangThai.DaXong)
                    fg.Rows[i].Style = csDaXong;
                if ((fg[i, "DS_Ten_NhanVien"] ?? "").ToString() != "")
                {
                    string[] tenNhanVien = fg[i, "DS_Ten_NhanVien"].ToString().Split(',');
                    fg[i, "DS_Ten_NhanVien"] = "";
                    foreach (var name in tenNhanVien)
                    {
                        fg[i, "DS_Ten_NhanVien"] += name.Trim() + "\n";
                    }
                }

                if ((fg[i, "ThoiGian_DuKien"] ?? "").ToString() != "")
                {
                    fg[i, "ThoiGian_DuKien"] += " " + fg[i, "Ten_ThoiGian"];
                }
            }
            LoadTree(fg);
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
            LocTheoNhanVien(fg);
            fg.Cols.Frozen = fg.Cols["TieuDe"].Index + 1;
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void LoadfgBaoCaoNgay()
        {
            var fg = fgBaoCaoNgay;
            fg.Tag = 0;
            fg.BeginUpdate();
            var cls = new clsCongViec();
            m_dtD3 = (DateTime)dtmTuNgay.Value;
            m_dtD4 = (DateTime)dtmDenNgay.Value;
            if (m_dtD3.Date > m_dtD4.Date)
            {
                BaseMessages.ShowWarningMessage("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
                return;
            }
            if ((int)(m_dtD4.Date - m_dtD3.Date).TotalDays > 365)
            {
                BaseMessages.ShowWarningMessage("Khoảng thời gian quá dài");
                return;
            }

            DataTable dt;

            dt = cls.SelectAll_CongViec_BaoCaoNgay(m_dtD3, m_dtD4, m_sds_NhanVien);
            fg.ClearRows();
            fg.SetDataSource(dt);
            var ID_NhanVien = m_sds_NhanVien.ToString().Split(',');
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                var ID_TrangThai = Convert.ToInt32(fg[i, "ID_TrangThai"]);

                if (ID_TrangThai == (int)TrangThai.ChuaThucHien)
                    fg.Rows[i].Style = csChuaThucHien;
                else if (ID_TrangThai == (int)TrangThai.DangThucHien)
                    fg.Rows[i].Style = csDangThucHien;
                else if (ID_TrangThai == (int)TrangThai.Huy)
                    fg.Rows[i].Style = csHuy;
                else if (ID_TrangThai == (int)TrangThai.DaXong)
                    fg.Rows[i].Style = csDaXong;
                if ((fg[i, "DS_Ten_NhanVien"] ?? "").ToString() != "")
                {
                    string[] tenNhanVien = fg[i, "DS_Ten_NhanVien"].ToString().Split(',');
                    fg[i, "DS_Ten_NhanVien"] = "";
                    foreach (var name in tenNhanVien)
                    {
                        fg[i, "DS_Ten_NhanVien"] += name.Trim() + "\n";
                    }
                }

                if ((fg[i, "ThoiGian_DuKien"] ?? "").ToString() != "")
                {
                    fg[i, "ThoiGian_DuKien"] += " " + fg[i, "Ten_ThoiGian"];
                }
            }
            LoadTree(fgBaoCaoNgay);
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
            LocTheoNhanVien(fgBaoCaoNgay);
            fg.Cols.Frozen = fg.Cols["TieuDe"].Index + 1;
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void LoadTree(C1FlexGrid fg)
        {
            int col_Ten_TrangThai_Index = fg.Cols["Ten_TrangThai"].Index;
            GroupBy("Ten_NguoiThucHien", col_Ten_TrangThai_Index, 0, "Người thực hiện:",fg);
            fg.Cols["Ten_NguoiThucHien"].Width = 0;
            fg.AllowMerging = AllowMergingEnum.Nodes;
            fg.Tree.Column = col_Ten_TrangThai_Index;
            fg.Tree.Style = TreeStyleFlags.SimpleLeaf;
            fg.AutoSizeCol(fg.Tree.Column);
            fg.Tree.Show(0);
        }

        private void GroupBy(string columnName, int groupCol, int level, string caption, C1FlexGrid fg)
        {
            var cs = fg.Styles[CellStyleEnum.Subtotal0];
            //cs.BackColor = Color.FromArgb(0xd0, 0xd0, 0xd0);
            cs.BackColor = Color.WhiteSmoke;
            cs.ForeColor = Color.Black;
            cs.Font = new Font(fg.Font, FontStyle.Bold);

            object current = null;
            for (int r = fg.Rows.Fixed; r < fg.Rows.Count; r++)
            {
                if (!fg.Rows[r].IsNode)
                {
                    var value = fg[r, columnName];
                    var value2 = fg[r, "ID_NhanVien"];
                    if (!object.Equals(value, current))
                    {
                        // value changed: insert node, apply style
                        fg.Rows.InsertNode(r, level);
                        fg.Rows[r].Style = cs;

                        // show group name in first scrollable column
                        fg[r, groupCol] = caption + " " + value;
                        fg[r, "ID_NhanVien"] = value2;

                        // update current value
                        current = value;
                    }
                }
            }
        }

        private void cmbNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbNhanVien.Tag + "" != "1") return;
            //fg.ApplyFilters();
            m_sds_NhanVien = cmbNhanVien.Properties.GetCheckedItems().ToString();
            Loadfg();
            
        }
        private void LocTheoNhanVien(C1FlexGrid fg)
        {
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                fg.Rows[i].Visible = true;
            }
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.Rows[i].Node.Level == 0)
                {
                    if (!NamTrongDS(fg.GetDataDisplay(i, "ID_NhanVien")))
                    {
                        fg.Rows[i].Visible = false;
                    }
                    else
                    {
                        fg.Rows[i].Visible = true;
                    }
                }
            }
        }


        private bool NamTrongDS(string ID_NhanVien)
        {
            if (m_sds_NhanVien == "") return true;
            string[] A = m_sds_NhanVien.Split(',');
            for (int i = 0; i < A.Length; i++)
            {
                if (ID_NhanVien.Trim() == A[i].Trim())
                {
                    return true;
                }
            }
            return false;
        }

        private void fg_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            if (cbToggleView.Checked)
            {
                if (e.Row >= fg.Rows.Fixed)
                {
                    //fg.SetCellStyle(e.Row, e.Col, csCellBorder);
                    decimal value;
                    if (fg.Cols[e.Col].Name == "PhanTramHoanThanh")
                    {
                        if (decimal.TryParse((fg[e.Row, e.Col] ?? "").ToString(), out value))
                        {
                            e.Text = e.Text + " %";
                            Rectangle rc = e.Bounds;
                            decimal max = 100;
                            rc.Width = (int)(fg.Cols["PhanTramHoanThanh"].WidthDisplay * value / max);

                            // draw background
                            e.DrawCell(DrawCellFlags.Background | DrawCellFlags.Border);

                            // draw bar
                            if (value < 25)
                            {
                                rc.Inflate(-3, -3);
                                e.Graphics.FillRectangle(Brushes.Firebrick, rc);
                                rc.Inflate(-2, -2);
                                e.Graphics.FillRectangle(Brushes.Crimson, rc);
                            }
                            else if (value >= 25 && value < 50)
                            {
                                rc.Inflate(-3, -3);
                                e.Graphics.FillRectangle(Brushes.MediumTurquoise, rc);
                                rc.Inflate(-2, -2);
                                e.Graphics.FillRectangle(Brushes.DarkTurquoise, rc);
                            }
                            else if (value >= 50 && value < 75)
                            {
                                rc.Inflate(-3, -3);
                                e.Graphics.FillRectangle(Brushes.SandyBrown, rc);
                                rc.Inflate(-2, -2);
                                e.Graphics.FillRectangle(Brushes.Orange, rc);
                            }
                            else if (value >= 75)
                            {
                                rc.Inflate(-3, -3);
                                e.Graphics.FillRectangle(Brushes.LightGreen, rc);
                                rc.Inflate(-2, -2);
                                e.Graphics.FillRectangle(Brushes.LightGreen, rc);
                            }

                            // draw cell content
                            e.DrawCell(DrawCellFlags.Content);
                        }
                    }
                    if (fg.Cols[e.Col].Name == "MoTa" || fg.Cols[e.Col].Name == "DS_Ten_NhanVien")
                    {
                        if (e.Text.Length > 100)
                            e.Text = HelperMethods.TruncateString(e.Text, 100) + " ...";
                    }
                    if (fg.Cols[e.Col].Name == "Ten_TrangThai")
                    {
                        if (e.Text.Trim() == "Chưa thực hiện")
                        {
                            e.Style = csChuaThucHien;
                        }
                        if (e.Text.Trim() == "Đang thực hiện")
                        {
                            e.Style = csDangThucHien;
                        }
                        else if (e.Text.Trim() == "Hủy")
                        {
                            e.Style = csHuy;
                        }
                        else if (e.Text.Trim() == "Đã xong")
                        {
                            e.Style = csDaXong;
                        }
                    }
                    if (fg.Cols[e.Col].Name == "Ten_MucDo")
                    {
                        if (e.Text.Trim() == "Thấp")
                        {
                            e.Style = csMucDoThap;
                        }
                        else if (e.Text.Trim() == "Trung bình")
                        {
                            e.Style = csMucDoTB;
                        }
                        else if (e.Text.Trim() == "Cao")
                        {
                            e.Style = csMucDoCao;
                        }
                    }
                }
            } //end if
            else
            {
                if (e.Row >= fg.Rows.Fixed)
                {
                    //fg.SetCellStyle(e.Row, e.Col, csCellBorder);
                    decimal value;
                    if (fg.Cols[e.Col].Name == "PhanTramHoanThanh")
                    {
                        if (decimal.TryParse((fg[e.Row, e.Col] ?? "").ToString(), out value))
                        {
                            e.Text = e.Text + " %";
                        }
                    }
                    if (fg.Cols[e.Col].Name == "MoTa" || fg.Cols[e.Col].Name == "DS_Ten_NhanVien")
                    {
                        if (e.Text.Length > 100)
                            e.Text = HelperMethods.TruncateString(e.Text, 100) + " ...";
                    }
                    if (fg.Cols[e.Col].Name == "Ten_MucDo")
                    {
                        if (e.Text.Trim() == "Thấp")
                        {
                            e.Style = csMucDoThap;
                        }
                        else if (e.Text.Trim() == "Trung bình")
                        {
                            e.Style = csMucDoTB;
                        }
                        else if (e.Text.Trim() == "Cao")
                        {
                            e.Style = csMucDoCao;
                        }
                    }
                }
            } //end else
        }

        private void mnu_Expand_Click(object sender, EventArgs e)
        {
            fg.Tree.Show(10);
        }

        private void mnu_Collapse_Click(object sender, EventArgs e)
        {
            fg.Tree.Show(0);
        }

        private void dtmTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (fg.Tag + "" != "1") return;
            if (dtmTuNgay.Text != "" && dtmTuNgay.Text.Length != dtmTuNgay.CustomFormat.Length) return;
            Loadfg();
        }

        private void dtmDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (fg.Tag + "" != "1") return;
            if (dtmDenNgay.Text != "" && dtmDenNgay.Text.Length != dtmDenNgay.CustomFormat.Length) return;
            Loadfg();
        }

        private void fg_DoubleClick(object sender, EventArgs e)
        {
            EditCongViec();
        }

        private void EditCongViec()
        {
            if (fg.Row < fg.Rows.Fixed || fg.Row > fg.Rows.Count)
            {
                return;
            }
            if (int.Parse(fg.GetDataDisplay(fg.Row, "ID_CongViec")) < 0) return;
            SendDataToFormThongTinCV();
        }

        private void SendDataToFormThongTinCV()
        {
            int ID_CongViec = Convert.ToInt32(fg[fg.Row, "ID_CongViec"]);
            m_fFrmCv = new frmCongViec(ID_CongViec, true);
            m_fFrmCv.Show();
        }

        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            if (xtraTabControl1.SelectedTabPage == tpTongHopBaoCao)
            {
                LoadcmbNhanVien();
                Loadfg();
            }
            else if (xtraTabControl1.SelectedTabPage == tpBaoCaoNgay)
            {
                LoadcmbNguoiThucHien();
                //Format_fg();
                LoadfgBaoCaoNgay();
            }
        }

        private void dtpTuNgay_ValueChanged(object sender, EventArgs e)
        {
            if (fgBaoCaoNgay.Tag + "" != "1") return;
            if (dtpTuNgay.Text != "" && dtpTuNgay.Text.Length != dtpTuNgay.CustomFormat.Length) return;
            LoadfgBaoCaoNgay();
        }

        private void dtpDenNgay_ValueChanged(object sender, EventArgs e)
        {
            if (fgBaoCaoNgay.Tag + "" != "1") return;
            if (dtpDenNgay.Text != "" && dtpDenNgay.Text.Length != dtpDenNgay.CustomFormat.Length) return;
            LoadfgBaoCaoNgay();
        }

        private void Format_fg()
        {
            // AllowMerging các cột gộp
            var fg = fgBaoCaoNgay;
            //fg.AllowMerging = AllowMergingEnum.FixedOnly;
            //fg.Rows[0].AllowMerging = true;
            //fg.Rows[1].AllowMerging = true;
            //for (int i = fg.Cols["STT"].Index; i < fg.Cols.Count; i++)
            //{
            //    fg[1, i] = fg[0, i];
            //    if (i >= fg.Cols["ChuaTH"].Index && i <= fg.Cols["DaHT"].Index)
            //    {
            //        fg[0, i] = "Tổng số công việc";
            //    }
            //}
            //fg.AutoSizeRows();
            fg.AllowMerging = AllowMergingEnum.Custom;
            CellRange cr1 = fg.GetCellRange(0, fg.Cols["STT"].Index, fg.Rows.Fixed-1, fg.Cols["STT"].Index);
            cr1.Data = "STT";
            fg.MergedRanges.Add(cr1);
        }

    }
}