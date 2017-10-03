using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using VSCM.Base.Utils;
using GlobalVariables = Garco10.SystemModule.HeThong.GlobalVariables;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmTrangCaNhan : FormBaseGarco10
    {
        public frmTrangCaNhan()
        {
            InitializeComponent();
        }

        public enum TrangThai
        {
            ChuaThucHien =1,
            DangThucHien = 2,
            DaHoanThanh = 3
        }
        
        int m_iID_CongViec = 0;
        clsCongViec cls = new clsCongViec();
        private CellStyle cs1, cs2, cs3;

        private void Add_Cellstyle()
        {

            cs1 = fgDaNhan.Styles.Add("Đã nhận");
            cs1.BackColor = Color.SkyBlue;
            cs2 = fgDangLam.Styles.Add("Đang làm");
            cs2.BackColor = Color.Khaki;
            cs3 = fgDaXong.Styles.Add("Đã xong");
            cs3.BackColor = Color.YellowGreen;
        }

        //private void frmQL_TrangCaNhan_Load(object sender, EventArgs e)
        //{
        //    Load_fgDaNhan();
        //    Load_fgDangLam();
        //    Load_fgDaXong();
        //    fgDaNhan.AllowEditing = false;
        //    fgDangLam.AllowEditing = false;
        //    fgDaXong.AllowEditing = false;
        //    txtDangLam.Enabled = false;
        //    txtDaNhan.Enabled= false;
        //    txtHoanThanh.Enabled = false;
        //}
        protected override void OnLoad(EventArgs e)
        {
            this.Opacity = 0;
            base.OnLoad(e);
            Load_fgDaNhan();
            Load_fgDangLam();
            Load_fgDaXong();
            fgDaNhan.AllowEditing = false;
            fgDangLam.AllowEditing = false;
            fgDaXong.AllowEditing = false;
            txtDangLam.Enabled = false;
            txtDaNhan.Enabled = false;
            txtHoanThanh.Enabled = false;
            this.Opacity = 1;
        }

        private void Load_fgDaNhan()
        {
            fgDaNhan.Tag = 0;
            fgDaNhan.BeginUpdate();
            Add_Cellstyle();
            DataTable dt = cls.SelectDS_CongViec_CaNhan(DataAccess.QLCV.Global.GlobalVariables.GetID_NhanSu().ToString(),(int)TrangThai.ChuaThucHien);
            fgDaNhan.SetDataSource(dt);
            for (int i = fgDaNhan.Rows.Fixed; i < fgDaNhan.Rows.Count; i++)
            {
                fgDaNhan.Rows[i].Style = cs1;
            }
            fgDaNhan.Row = -1;
            fgDaNhan.SetSTT();
            fgDaNhan.AutoSizeRows();
            fgDaNhan.EndUpdate();
            fgDaNhan.Tag = 1;
        }
        
        private void Load_fgDangLam()
        {
            fgDangLam.Tag = 0;
            fgDangLam.BeginUpdate();
            Add_Cellstyle();
            DataTable dt = cls.SelectDS_CongViec_CaNhan(DataAccess.QLCV.Global.GlobalVariables.GetID_NhanSu().ToString(), (int)TrangThai.DangThucHien);
            fgDangLam.SetDataSource(dt);
            for (int i = fgDangLam.Rows.Fixed; i < fgDangLam.Rows.Count; i++)
            {
                fgDangLam.Rows[i].Style = cs2;
            }
            fgDangLam.Row = -1;
            fgDangLam.SetSTT();
            fgDangLam.AutoSizeRows();
            fgDangLam.EndUpdate();
            fgDangLam.Tag = 1;
        }

        private void Load_fgDaXong()
        {

            fgDaXong.Tag = 0;
            fgDaXong.BeginUpdate();
            Add_Cellstyle();
            DataTable dt = cls.SelectDS_CongViec_CaNhan(DataAccess.QLCV.Global.GlobalVariables.GetID_NhanSu().ToString(), (int)TrangThai.DaHoanThanh);
            fgDaXong.SetDataSource(dt);
            for (int i = fgDaXong.Rows.Fixed; i < fgDaXong.Rows.Count; i++)
            {
                fgDaXong.Rows[i].Style = cs3;
            }

            fgDaXong.Row = -1;
            fgDaXong.SetSTT();
            fgDaXong.AutoSizeRows();
            fgDaXong.EndUpdate();
            fgDaXong.Tag = 1;
        }

        private void fgDaNhan_DoubleClick(object sender, EventArgs e)
        {
            if (fgDaNhan.Row < fgDaNhan.Rows.Fixed) return;
            int iID_Cv = fgDaNhan.GetIntValue(fgDaNhan.Row, "ID_CongViec");
            frmCongViec frm = new frmCongViec(iID_Cv,true);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            Load_fgDangLam();
            Load_fgDaNhan();
            Load_fgDaXong();

        }

        private void fgDangLam_DoubleClick(object sender, EventArgs e)
        {
            if (fgDangLam.Row < fgDangLam.Rows.Fixed) return;
            int iID_Cv = fgDangLam.GetIntValue(fgDangLam.Row, "ID_CongViec");
            frmCongViec frm = new frmCongViec(iID_Cv,true);
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
            Load_fgDangLam();
            Load_fgDaNhan();
            Load_fgDaXong();
        }

        private void fgDaXong_DoubleClick(object sender, EventArgs e)
        {
            if (fgDaXong.Row < fgDaXong.Rows.Fixed) return;
            int iID_Cv = fgDaXong.GetIntValue(fgDaXong.Row, "ID_CongViec");
            frmCongViec frm = new frmCongViec(iID_Cv,true);
            frm.ShowDialog();
            Load_fgDangLam();
            Load_fgDaNhan();
            Load_fgDaXong();

        }

    }
}
