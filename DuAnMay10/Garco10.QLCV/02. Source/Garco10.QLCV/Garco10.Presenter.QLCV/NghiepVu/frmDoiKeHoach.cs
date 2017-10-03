using Garco10.SystemModule.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using VSCM.Base.Utils;
using GlobalVariables = Garco10.SystemModule.HeThong.GlobalVariables;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmDoiKeHoach : FormBaseGarco10
    {
        private bool m_bCapNhat;
        private DateTime m_dNgayBatDau;
        private DateTime m_dNgayKetThuc;

        public List<object> thongSo = new List<object>();

        public frmDoiKeHoach(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            InitializeComponent();
            m_dNgayBatDau = ngaybatdau;
            m_dNgayKetThuc = ngayketthuc;
            m_bCapNhat = true;
        }

        private void frmLapLich_Load(object sender, EventArgs e)
        {
            dtNgayDenHan.Value = m_dNgayKetThuc;
            dtNgayYeuCau.Value = m_dNgayBatDau;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            Close();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            if (!IsValid()) return;
            BaseMessages.ShowInformationMessage("Lưu thành công");
            Close();
        }

        private bool IsValid()
        {
            if (dtNgayYeuCau.Value.ToString() == "")
            {
                BaseMessages.ShowWarningMessage("Ngày bắt đầu kế hoạch không được để trống !");
                return false;
            }
            if (dtNgayDenHan.Value.ToString() == "")
            {
                BaseMessages.ShowWarningMessage("Ngày hết hạn kế hoạch không được để trống !");
                return false;
            }
            if (dtNgayYeuCau.Value.ToString() != "" && dtNgayDenHan.Value.ToString() != "")
            {
                //int result = DateTime.Compare(DateTime.Parse(dtTuGio.Value.ToString()), DateTime.Parse(dtDenGio.Value.ToString()));
                //if (result > 0)
                //{
                //    BaseMessages.ShowWarningMessage("Ngày bắt đầu phải nhỏ hơn giờ kết thúc");
                //    return false;
                //}
            }
            return true;
        }

    }
}