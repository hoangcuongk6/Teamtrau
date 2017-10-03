using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VSCM.Base.Forms;
using C1.Win.C1FlexGrid;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using System.Data.SqlTypes;
using Garco10.DataAccess.QLCV.Global;
using Garco10.SystemModule.Forms;
using M10_QLCV;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmQL_TrangCaNhan : FormBaseGarco10
    {
        public frmQL_TrangCaNhan()
        {
            InitializeComponent();

          
        }
        
        int iID_User = GlobalVariables.iCurrentUser;
        int iID_CongViec = 0;
        clsCongViec cls = new clsCongViec();
        private CellStyle cs1, cs3, cs5;

        private void Add_Cellstyle()
        {

            cs1 = fgDaNhan.Styles.Add("Đã nhận");
            cs1.BackColor = Color.LightSkyBlue;
            cs3 = fgDangLam.Styles.Add("Đang làm");
            cs3.BackColor = Color.Khaki;
            cs5 = fgDaXong.Styles.Add("Đã xong");
            cs5.BackColor = Color.LightGreen;
        }

        private void frmQL_TrangCaNhan_Load(object sender, EventArgs e)
        {
            //DateTime date = GlobalVariables.GetCurrentDateTime();
            //date = new DateTime(date.Year, date.Month-1, 1);
            //dtmTuNgay.Value = date;
            //dtmDenNgay.Value = date.AddMonths(2).AddDays(-1);

            //Load_fgDaNhan();
            //Load_fgDangLam();
            //Load_fgDaXong();
            //fgDaNhan.AllowEditing = false;
            //fgDangLam.AllowEditing = false;
            //fgDaXong.AllowEditing = false;
            //txtDangLam.Enabled = false;
            //txtDaNhan.Enabled= false;
            //txtHoanThanh.Enabled = false;
        }

        private void Load_fgDaNhan()
        {
            //fgDaNhan.Tag = 0;
            //fgDaNhan.BeginUpdate();
            //Add_Cellstyle();
            //DataTable dt = cls.SelectDS_CongViec_CaNhan(iID_User);
            //fgDaNhan.SetDataSource(dt);
            //for (int i = fgDaNhan.Rows.Fixed; i < fgDaNhan.Rows.Count; i++)
            //{
            //    if (int.Parse(fgDaNhan[i,"ID_TrangThai"].ToString()) == 1) continue;
            //    fgDaNhan.Rows[i].Style = cs1;
            //}
            //fgDaNhan.Row = -1;
            //fgDaNhan.SetSTT();
            //fgDaNhan.AutoSizeRows();
            //fgDaNhan.EndUpdate();
            //fgDaNhan.Tag = 1;
        }
        
        private void Load_fgDangLam()
        {
            //fgDangLam.Tag = 0;
            //fgDangLam.BeginUpdate();
            //Add_Cellstyle();
            //DataTable dt = cls.SelectDS_CongViec_CaNhan_TheoNgay(DateTime.Parse(dtmTuNgay.Value.ToString()), DateTime.Parse(dtmDenNgay.Value.ToString()), iID_User, 3);
            //fgDangLam.SetDataSource(dt);
            //for (int i = fgDangLam.Rows.Fixed; i < fgDangLam.Rows.Count; i++)
            //{
            //    fgDangLam.Rows[i].Style = cs3;
            //}
            //fgDangLam.Row = -1;
            //fgDangLam.SetSTT();
            //fgDangLam.AutoSizeRows();
            //fgDangLam.EndUpdate();
            //fgDangLam.Tag = 1;
        }

        private void Load_fgDaXong()
        {

            //fgDaXong.Tag = 0;
            //fgDaXong.BeginUpdate();
            //Add_Cellstyle();
            //DataTable dt = cls.SelectDS_CongViec_CaNhan_TheoNgay(DateTime.Parse(dtmTuNgay.Value.ToString()),DateTime.Parse(dtmDenNgay.Value.ToString()), iID_User,6);
            //fgDaXong.SetDataSource(dt);
            //for (int i = fgDaXong.Rows.Fixed; i < fgDaXong.Rows.Count; i++)
            //{
            //    fgDaXong.Rows[i].Style = cs5;
            //}

            //fgDaXong.Row = -1;
            //fgDaXong.SetSTT();
            //fgDaXong.AutoSizeRows();
            //fgDaXong.EndUpdate();
            //fgDaXong.Tag = 1;

        }

        private void mnuDangThuHien_Click(object sender, EventArgs e)
        {
            if (fgDaNhan.Row < fgDaNhan.Rows.Fixed && fgDaXong.Row < fgDaXong.Rows.Fixed)
            {
                return;
            }
            if (fgDaNhan.Row >= fgDaNhan.Rows.Fixed)
            {
                cls.ID_CongViec = fgDaNhan.GetIntValue(fgDaNhan.Row, "ID_CongViec");
                cls.SelectOne();
                cls.ID_TrangThai = 3;
                cls.Ngay_BatDau = GlobalVariables.GetCurrentDateTime();
                cls.Update();
            }
            else
            {
                iID_CongViec = fgDaXong.GetIntValue(fgDaXong.Row, "ID_CongViec");
                //cls.UpdateTrangThai(iID_CongViec, 3);

            }

            Load_fgDaNhan();
            Load_fgDangLam();
            Load_fgDaXong();
        }

        private void mnuDaXong_Click(object sender, EventArgs e)
        {
            if (fgDangLam.Row < 0) return;
            iID_CongViec = fgDangLam.GetIntValue(fgDangLam.Row, "ID_CongViec");
            //cls.UpdateTrangThai(iID_CongViec,6);
            Load_fgDaNhan();
            Load_fgDaXong();
            Load_fgDangLam();
        }

        private void mnuDaNhan_Click(object sender, EventArgs e)
        {
            if (fgDangLam.Row < 0) return;
            iID_CongViec = fgDangLam.GetIntValue(fgDangLam.Row, "ID_CongViec");
            //cls.UpdateTrangThai(iID_CongViec, 2);
            Load_fgDaNhan();
            Load_fgDaXong();
            Load_fgDangLam();
        }

        private void dtmDenNgay_TextChanged(object sender, EventArgs e)
        {
            if (fgDaNhan.Tag + "" != "1" || fgDangLam.Tag + "" != "1" || fgDaXong.Tag + "" != "1") return;
            Load_fgDaNhan();
            Load_fgDaXong();
            Load_fgDangLam();
        }

        private void dtmTuNgay_TextChanged(object sender, EventArgs e)
        {
            if (fgDaNhan.Tag + "" != "1" || fgDangLam.Tag + "" != "1" || fgDaXong.Tag + "" != "1") return;
            Load_fgDaNhan();
            Load_fgDaXong();
            Load_fgDangLam();
        }

        private void fgDaNhan_DoubleClick(object sender, EventArgs e)
        {
            //if (fgDaNhan.Row < fgDaNhan.Rows.Fixed) return;
            //int iID_Cv = fgDaNhan.GetIntValue(fgDaNhan.Row, "ID_CongViec");
            //int iID_KhachHang = fgDaNhan.GetIntValue(fgDaNhan.Row, "ID_KhachHang");
            //frmCongViec_ChiTiet frm = new frmCongViec_ChiTiet(iID_Cv, iID_KhachHang, AccessType.FullAccess);
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.ShowDialog();
            //Load_fgDangLam();
            //Load_fgDaNhan();
            //Load_fgDaXong();

        }

        private void fgDangLam_DoubleClick(object sender, EventArgs e)
        {
            //if (fgDangLam.Row < fgDangLam.Rows.Fixed) return;
            //int iID_Cv = fgDangLam.GetIntValue(fgDangLam.Row, "ID_CongViec");
            //int iID_KhachHang = fgDangLam.GetIntValue(fgDangLam.Row, "ID_KhachHang");
            //frmCongViec_ChiTiet frm = new frmCongViec_ChiTiet(iID_Cv, iID_KhachHang, AccessType.FullAccess);
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.ShowDialog();
            //Load_fgDangLam();
            //Load_fgDaNhan();
            //Load_fgDaXong();
        }

        private void fgDaXong_DoubleClick(object sender, EventArgs e)
        {
            //if (fgDaXong.Row < fgDaXong.Rows.Fixed) return;
            //int iID_Cv = fgDaXong.GetIntValue(fgDaXong.Row, "ID_CongViec");
            //int iID_KhachHang = fgDaXong.GetIntValue(fgDaXong.Row, "ID_KhachHang");
            //frmCongViec_ChiTiet frm = new frmCongViec_ChiTiet(iID_Cv, iID_KhachHang, AccessType.FullAccess);
            //frm.StartPosition = FormStartPosition.CenterScreen;
            //frm.ShowDialog();
            //Load_fgDangLam();
            //Load_fgDaNhan();
            //Load_fgDaXong();

        }   
    }
}
