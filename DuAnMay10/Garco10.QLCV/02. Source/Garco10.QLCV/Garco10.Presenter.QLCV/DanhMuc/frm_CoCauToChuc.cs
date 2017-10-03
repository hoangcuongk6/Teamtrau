using Garco10.SystemModule.Forms;
using Garco10.SystemModule.HeThong;
using M10_HRM;
using System;
using System.Data;
using M10_System;

namespace Garco10.Presenter.QLCV
{
    public partial class frmCoCauToChuc : FormBaseGarco10
    {
        public frmCoCauToChuc()
        {
            InitializeComponent();
        }

        private void frmQuyetDinh_Load(object sender, EventArgs e)
        {
            fgNhanSu.AutoSetColumnFilter();
            //NhanSuMethod.Load_cmbDonVi_TheoQuyen(cmbDonVi);
            LoadcmbDonVi();
        }

        private void LoadcmbDonVi()
        {
            var cmb = cmbDonVi;
            cmb.Tag = 0;
            var cls = new clsDM_DonVi();
            var dt = cls.SelectAll();
            dt.DefaultView.Sort = "STT_DonVi ASC";
            dt.DefaultView.RowFilter = "TonTai = 1 AND SuDung = 1";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_DonVi";
            cmb.Properties.ValueMember = "ID_DonVi";
            if (dt.DefaultView.ToTable().Rows.Count == 1) cmb.EditValue = dt.DefaultView.ToTable().Rows[0]["ID_DonVi"];
            else cmb.EditValue = null;
            cmb.Tag = 1;
        }

        private void cmbDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if ("" + cmbDonVi.EditValue == "") cmbBoPhan.Properties.DataSource = null;
            else GlobalMethod.Load_cmbBoPhan(cmbBoPhan, cmbDonVi.EditValue.ToString());
            fgNhanSu.ClearRows();
        }

        private void Load_fgNhanSu()
        {
            var fg = fgNhanSu;
            fg.Tag = 0;
            fg.BeginUpdate();

            clsNS_ThongTinNS cls = new clsNS_ThongTinNS();
            DataTable dt = cls.Select_DanhSachNhanSu_wDonVi_And_PhongBan(Int16.Parse(cmbDonVi.EditValue.ToString()),
                                                                         Int16.Parse(cmbBoPhan.EditValue.ToString()),
                                                                         GlobalVariables.GetCurrentDateTime(),
                                                                         HRM_Enumerations.NS_TrangThai_HopDong.DangDiLam,
                                                                         HRM_Enumerations.NS_TrangThai_DiLam.TatCa);
            fg.SetDataSource(dt, true);
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void cmbBoPhan_EditValueChanged(object sender, EventArgs e)
        {
            if ("" + cmbBoPhan.EditValue == "")
            {
                fgNhanSu.ClearRows();
            }
            else
            {
                Load_fgNhanSu();
            }
        }

        private void txtSearch_NhanSu_EditValueChanged(object sender, EventArgs e)
        {
            fgNhanSu.Filter("HoTen", "MaNS", txtSearch_NhanSu.Text);
        }

        private void fgNhanSu_AfterRowChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
        {
            if (fgNhanSu.Tag.ToString() == "0") return;
        }

        private void cmdTimkiem1_Click(object sender, EventArgs e)
        {
            fgNhanSu.Filter("HoTen", "MaNS", txtSearch_NhanSu.Text);
        }

        public override void RefreshForm()
        {
            if ("" + cmbBoPhan.EditValue == "")
            {
                fgNhanSu.ClearRows();
            }
            else
            {
                Load_fgNhanSu();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}