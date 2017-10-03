using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Garco10.DataAccess.QLCV.Global;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using M10_System;
using VSCM.Base.Utils;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmTaoThongBao : FormBaseGarco10
    {
        public frmTaoThongBao()
        {
            InitializeComponent();
        }

        private void frmTaoThongBao_Load(object sender, EventArgs e)
        {
            LoadcmbDonVi();
            //LoadcmbNguoiNhan();
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

        private void btnGui_Click(object sender, EventArgs e)
        {
            if(!IsValid()) return;
            SaveData();
        }

        private void SaveData()
        {
            clsThongBao thongBao = new clsThongBao();
            thongBao.Ngay_Gui = GlobalVariables.GetCurrentDateTime();
            thongBao.TaiKhoan_Gui = Int16.Parse(GlobalVariables.GetID_NhanSu().ToString(CultureInfo.InvariantCulture));
            thongBao.TaiKhoan_Nhan = cmbNguoiNhan.Properties.GetCheckedItems().ToString();
            thongBao.Ten_ChucNang_ThongBao = "frmTaoThongBao";
            thongBao.NoiDung = GlobalVariables.Get_HoTen_NhanSu() + " " + txtNoiDung.Text.Trim();
            thongBao.TrangThai = 1;
            thongBao.Insert();
        }

        private bool IsValid()
        {
            string nguoiNhan = cmbNguoiNhan.Properties.GetCheckedItems().ToString();
            if (nguoiNhan == "")
            {
                BaseMessages.ShowWarningMessage("Chưa chọn người nhận thông báo !!!");
                return false;
            }
            if (txtNoiDung.Text =="")
            {
                BaseMessages.ShowWarningMessage("Chưa nhập nội dung thông báo !!!");
                return false;
            }
            
            return true;
        }

        private void LoadcmbNguoiNhan(int iID_DonVi)
        {
            var cmb = cmbNguoiNhan;
            cmb.Tag = 0;
            clsNhanSu cls = new clsNhanSu();
            DataTable dt = cls.GetNhanSu(iID_DonVi, 0);
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "HoTen";
            cmb.Properties.ValueMember = "ID_NhanSu";
            cmb.Tag = 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbDonVi_EditValueChanged(object sender, EventArgs e)
        {
            if ("" + cmbDonVi.EditValue == "") cmbNguoiNhan.Properties.DataSource = null;
            else LoadcmbNguoiNhan(int.Parse(cmbDonVi.EditValue.ToString()));
        }

    }
}
