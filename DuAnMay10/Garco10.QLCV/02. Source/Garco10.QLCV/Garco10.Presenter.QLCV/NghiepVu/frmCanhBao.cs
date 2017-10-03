using System;
using System.Data;
using C1.Win.C1FlexGrid;
using Garco10.SystemModule.Forms;
using M10_QLCV;
using VSCM.Base.Utils;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmCanhBao : FormBaseGarco10
    {
        private CellStyle csLoaiThongBao, csDonViThoiGian;
        public int id_CongViec;
        public int[] id_ThoiGian, id_LoaiThongBao;
        public bool themMoi = true;
        public decimal[] thoigian;

        public frmCanhBao(int id_CongViec)
        {
            InitializeComponent();

            this.id_CongViec = id_CongViec;
            id_LoaiThongBao = new int[5];
            id_ThoiGian = new int[5];
            thoigian = new decimal[5];
        }

        private void frmCanhBao_Load(object sender, EventArgs e)
        {
            LoadCombolist();
            for (var i = fg.Rows.Fixed; i < 6; i++)
            {
                var row = fg.Rows.Add();
                var rg = fg.GetCellRange(i, 0);
                rg.Style = csDonViThoiGian;
                var rg2 = fg.GetCellRange(i, 2);
                rg2.Style = csLoaiThongBao;
            }
            var cls = new clsCongViec_ThongBao();
            cls.ID_CongViec = id_CongViec;
            var dt = cls.Select_ID_CongViec(id_CongViec);
            if (dt.Rows.Count >0)
            {
                var tt = 0;
                foreach (DataRow dr in dt.Rows)
                {
                    id_LoaiThongBao[tt] = int.Parse(dr["ID_LoaiThongBao"].ToString());
                    id_ThoiGian[tt] = int.Parse(dr["ID_ThoiGian"].ToString());
                    thoigian[tt] = decimal.Parse(dr["ThoiGian_BaoTruoc"].ToString());
                    ++tt;
                }
                var tenloaithongbao = GetTenLoaiThongBao(id_LoaiThongBao);
                var tendonvithoigian = GetDonViThoiGian(id_ThoiGian);
                for (var i = 0; i < id_ThoiGian.Length; ++i)
                {
                    if (tendonvithoigian[i] == null) break;
                    fg.Rows[i + 1]["DonVi"] = tendonvithoigian[i];
                    fg.Rows[i + 1]["LoaiThongBao"] = tenloaithongbao[i];
                    fg.Rows[i + 1]["ThoiGian"] = thoigian[i];
                }
            }
        }

        private string[] GetTenLoaiThongBao(int[] id_loaithongbao)
        {
            var mangtenloaithongbao = new string[id_loaithongbao.Length];

            for (var i = 0; i < id_loaithongbao.Length; ++i)
            {
                if (id_loaithongbao[i] == 0) break;
                var cls = new clsDM_LoaiThongBao();
                cls.ID_LoaiThongBao = id_loaithongbao[i];
                var dt = cls.SelectOne();
                mangtenloaithongbao[i] = dt.Rows[0]["Ten_LoaiThongBao"].ToString();
            }
            return mangtenloaithongbao;
        }

        private string[] GetDonViThoiGian(int[] id_donvithoigian)
        {
            var mangtendonvithoigian = new string[id_donvithoigian.Length];
            for (var i = 0; i < id_donvithoigian.Length; ++i)
            {
                if (id_donvithoigian[i] == 0) break;
                var cls = new clsDM_ThoiGian();
                cls.ID_ThoiGian = id_donvithoigian[i];
                var dt = cls.SelectOne();
                mangtendonvithoigian[i] = dt.Rows[0]["Ten_ThoiGian"].ToString();
            }
            return mangtendonvithoigian;
        }

        private decimal[] GetThoiGian()
        {
            thoigian = new decimal[fg.Rows.Count];
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
            {
                decimal tgian = 0;
                decimal.TryParse(fg.GetDataDisplay(i, "ThoiGian"), out tgian);
                thoigian[i - 1] = tgian;
            }
            return thoigian;
        }

        private int[] getID_LoaiThongBao()
        {
            id_LoaiThongBao = new int[5];
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
            {
                if (fg.GetDataDisplay(i, "LoaiThongBao") == "") break;
                var cls = new clsDM_LoaiThongBao();
                var tenloaithongbao = fg.Rows[i]["LoaiThongBao"].ToString();
                var dt = cls.SelectOne_TenThongBao(tenloaithongbao);
                id_LoaiThongBao[i - 1] = int.Parse(dt.Rows[0]["ID_LoaiThongBao"].ToString());
            }
            return id_LoaiThongBao;
        }

        private int[] getID_DonViThoiGian()
        {
            id_ThoiGian = new int[5];
            for (var i = fg.Rows.Fixed; i < fg.Rows.Count; ++i)
            {
                if (fg.GetDataDisplay(i, "DonVi") == "") break;
                var cls = new clsDM_ThoiGian();

                var tendonvithoigian = fg.Rows[i]["DonVi"].ToString();
                var dt = cls.SelectOne_TenThoiGian(tendonvithoigian);
                id_ThoiGian[i - 1] = int.Parse(dt.Rows[0]["ID_ThoiGian"].ToString());
            }
            return id_ThoiGian;
        }

        private void LoadCombolist()
        {
            csLoaiThongBao = fg.Styles.Add("Node 2 Nhân viên");
            csDonViThoiGian = fg.Styles.Add("Node2 phân hệ");
            var cls_LoaiThongBao = new clsDM_LoaiThongBao();
            var dt_NV = cls_LoaiThongBao.SelectAll();
            var s_Combolist = "";
            for (var i = 0; i < dt_NV.Rows.Count - 1; i++)
                s_Combolist += dt_NV.Rows[i]["Ten_LoaiThongBao"] + "|";
            s_Combolist += dt_NV.Rows[dt_NV.Rows.Count - 1]["Ten_LoaiThongBao"].ToString();
            csLoaiThongBao.ComboList = s_Combolist;

            //
            var cls_NYC = new clsDM_ThoiGian();
            var dt_NYC = cls_NYC.SelectAll();
            dt_NYC.DefaultView.RowFilter = "TonTai = 1";
            s_Combolist = "";
            for (var i = 0; i < dt_NYC.Rows.Count - 1; i++)
                s_Combolist += dt_NYC.Rows[i]["Ten_ThoiGian"] + "|";
            s_Combolist += dt_NYC.Rows[dt_NYC.Rows.Count - 1]["Ten_ThoiGian"].ToString();
            csDonViThoiGian.ComboList = s_Combolist;
        }

        private void cmdLuu_Click(object sender, EventArgs e)
        {
            getID_DonViThoiGian();
            getID_LoaiThongBao();
            GetThoiGian();
            BaseMessages.ShowWarningMessage("Lưu thành công");
            Visible = false;
        }

        private void cmdThoat_Click(object sender, EventArgs e)
        {
            id_ThoiGian = new int[1];
            id_LoaiThongBao = new int[1];
            thoigian = new decimal[1];
            Visible = false;
        }

        
    }
}