using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using Garco10.DataAccess.QLCV.Global;
using Garco10.SystemModule.Forms;
using M10_QLCV;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmThongBao : FormBaseGarco10
    {

        private CellStyle csThongBao;

        public frmThongBao()
        {
            InitializeComponent();
        }

        private void frmThongBao_Load(object sender, EventArgs e)
        {
            InitCellStyles();
            Load_fgThongBao();

            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(fgThongBao, "Click đúp để xem chi tiết nội dung thông báo");
        }

        private void Load_fgThongBao()
        {
            var fg = fgThongBao;
            fg.Tag = 0;
            fg.BeginUpdate();
            clsThongBao thongBao = new clsThongBao();
            DataTable dt = thongBao.Select_ID_NhanSu(GlobalVariables.GetID_NhanSu().ToString());
            fg.ClearRows();
            fg.SetDataSource(dt);
            fg.Row = -1;
            fg.AutoSizeRows();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg[i,"Ten_TrangThai"].ToString().Trim() != "Đã xem")
                {
                    fg.Rows[i].Style = csThongBao;
                }
                fg[i, "NoiDung"] = fg.GetDataDisplay(i, "NoiDung").Replace(GlobalVariables.Get_HoTen_NhanSu(), "Bạn");
                fg[i, "Ten_NgayGui"] = GlobalVariables.TimeAgo(DateTime.Parse(fg.Rows[i]["Ngay_Gui"].ToString()));
            }
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fgThongBao_DoubleClick(object sender, EventArgs e)
        {
            int ID_CongViec = fgThongBao.GetIntValue(fgThongBao.Row,"ID_CongViec");
            frmCongViec congViec = new frmCongViec(ID_CongViec,true);
            congViec.ShowDialog();
            clsThongBao thongBao = new clsThongBao();
            thongBao.ID_ThongBao = fgThongBao.GetIntValue(fgThongBao.Row, "ID_ThongBao");
            thongBao.SelectOne();
            thongBao.TrangThai = 2;
            thongBao.Update();
            Load_fgThongBao();
        }

        private void InitCellStyles()
        {
            csThongBao = fgThongBao.Styles.Add("Thông báo");
            csThongBao.Font = new Font("Tahoma", 9, FontStyle.Bold);
            csThongBao.BackColor = Color.LightBlue;
        }

        private void btnDaXem_Click(object sender, EventArgs e)
        {
            var fg = fgThongBao;
            clsThongBao cls = new clsThongBao();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.GetIntValue(i, "TrangThai") != 2)
                {
                    int ID_ThongBao = fg.GetIntValue(i, "ID_ThongBao");
                    cls.ID_ThongBao = ID_ThongBao;
                    cls.SelectOne();
                    cls.TrangThai = 2;
                    cls.Update();
                }
            }
            Load_fgThongBao();
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            frmTaoThongBao frm = new frmTaoThongBao();
            frm.Show();
        }

        
    }
}
