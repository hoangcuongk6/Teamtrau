using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraNavBar;
using Garco10.DataAccess.QLCV.Global;
using Garco10.Presenter.QLCV.DanhMuc;
using Garco10.Presenter.QLCV.NghiepVu;
using M10_QLCV;

namespace Garco10.Presenter.QLCV
{
    public partial class frmMain_QLCV : Form
    {
        private int m_iID_DonVi;

        public frmMain_QLCV()
        {
            InitializeComponent();
            tabForms.BackgroundImage = BackgroundImage;
            Text = "Quản lý công việc - User: " + GlobalVariables.Get_HoTen_NhanSu();
        }

        //private void frmMain_Load(object sender, EventArgs e)
        //{
        //    Reload_Menu();
        //    dpMenu.Focus();
        //    timer1.Interval = 30000; // 30s
        //    timer1.Start();
        //    id_NhanSu_DangNhap = GlobalVariables.GetID_NhanSu();
        //    m_iID_DonVi = SystemModule.HeThong.GlobalVariables.uID_DonVi;
        //    //if (id_NhanSu_DangNhap == 5400 || id_NhanSu_DangNhap == 5407 || id_NhanSu_DangNhap == 5409)
        //    //    id_NhanSu_DangNhap = 0;
        //    CB_ThongBao_DenHan_VaoForm();
        //    CB_ThongBao_KhiCoThayDoi_VaoForm();
        //    timer2.Start();
        //    timer2.Enabled = true;
        //    var frm = new frmQuanLyTienDo(id_NhanSu_DangNhap);
        //    tabForms.OpenForm(frm, "Quản lý tiến độ thực hiện");
            
        //}

        protected override void OnLoad(EventArgs e)
        {
            Opacity = 0;
            VSCM.Base.Forms.WaitForm.ShowSplashScreen();
            base.OnLoad(e);
            Reload_Menu();
            dpMenu.Focus();
            //timer1.Interval = 30000; // 30s
            //timer1.Start();
            id_NhanSu_DangNhap = GlobalVariables.GetID_NhanSu();
            m_iID_DonVi = SystemModule.HeThong.GlobalVariables.uID_DonVi;
            CB_ThongBao_DenHan_VaoForm();
            CB_ThongBao_KhiCoThayDoi_VaoForm();
            //timer2.Start();
            //timer2.Enabled = true;
            var frm = new frmQuanLyTienDo(id_NhanSu_DangNhap);
            tabForms.OpenForm(frm, "Quản lý tiến độ thực hiện");
            Opacity = 1;
            VSCM.Base.Forms.WaitForm.CloseForm();
        }

        private void CloseAllForm()
        {
            foreach (var f in MdiChildren)
                f.Close();
        }

        private void Reload_Menu()
        {
            foreach (NavBarItem obj in navBarControl_Menu.Items)
                obj.Appearance.ForeColor = Color.Black;
        }

        private void mnuThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void btnTrangCaNhan_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new frmTrangCaNhan();
            tabForms.OpenForm(frm, "Công việc cá nhân");
        }

        private void btnQuanLyTienDo_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new frmQuanLyTienDo(id_NhanSu_DangNhap);
            tabForms.OpenForm(frm, "Quản lý tiến độ thực hiện");
        }

        private void btnLich_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new frmLich(id_NhanSu_DangNhap);
            tabForms.OpenForm(frm, "Lịch");
        }

        private void mnu_CheckUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void mnu_loaiCongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmDM_LoaiCongViec_Old2(m_iID_DonVi);
            frm.Show();
        }

        private void mnu_CongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmDS_CongViec(GlobalVariables.GetID_NhanSu());
            frm.ShowDialog();
        }

        private void btnThongBao_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frmThongBao = new frmThongBao();
            frmThongBao.Show();
        }

        private void btnNgayNghi_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new frmDM_NgayNghiLe();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void mnu_VanBan_TaiLieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmTaiLieuUpload(true, FTP_FilesManager.FTP_PhanMem.QuanLyCongViec,
                FTP_FilesManager.FTP_FileType_Group.QLCV, FTP_FilesManager.FTP_FileType.All, "0");
            frm.sFilterEdit_FileType = ((int) FTP_FilesManager.FTP_FileType.TaiLieuChung).ToString();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (DateTime.Now.Hour >= 10 && DateTime.Now.Hour <= 11)
            //    CB_CongViecHoanThanhTrongNgay();
            //if (DateTime.Now.Hour > 11 && DateTime.Now.Hour <= 12 && DateTime.Now.Minute >= 50 ||
            //    DateTime.Now.Hour >= 13 && DateTime.Now.Hour < 14 && DateTime.Now.Minute >= 30 &&
            //    DateTime.Now.Minute <= 40 || DateTime.Now.Hour >= 16 && DateTime.Now.Hour < 17 &&
            //    DateTime.Now.Minute >= 50)
            //    alertControl3.Show(ActiveMdiChild, "Thông báo", "Cập nhật tiến độ công việc !!!");
            //CB_ThongBao_DenHan();
            //CB_ThongBao_KhiCoThayDoi();
        }

        private void mnu_ToChuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmCoCauToChuc();
            frm.ShowDialog();
        }

        private void mnu_PhanCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmPhanCapChucVu();
            frm.ShowDialog();
        }

        private void mnu_BanNhom_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmNhom_Ban();
            frm.ShowDialog();
        }

        private void mnu_PhanCap_DonVi_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmPhanCap_DonVi();
            frm.ShowDialog();
        }

        private void tabForms_Click(object sender, EventArgs e)
        {
        }

        private void frmMain_QLCV_FormClosing(object sender, FormClosingEventArgs e)
        
        
        {
            //if (notifyIcon1.Visible) return;
            //// Cho hiện notifyIcon
            //notifyIcon1.Visible = true;
            //// Hiện BaloonTip hoặc không
            //notifyIcon1.ShowBalloonTip(100, "Ẩn phần mềm", "Ấn chuột phải để thao tác", ToolTipIcon.Info);

            //// Chọn ẩn
            //Hide();
            //e.Cancel = true;
            // Hoặc
            // this.ShowInTaskbar = false;
            // WindowState = FormWindowState.Minimized;
            // Hoặc cả 2 để ẩn form
        }

        private void mnu_Thoat_Click(object sender, EventArgs e)
        {
            //Close();
        }

        private void mnu_Open_PhanMem_Click(object sender, EventArgs e)
        {
            //Show();
            //notifyIcon1.Visible = false;
        }

        private void mnu_Open_ThanhHeThong_Click(object sender, EventArgs e)
        {
            //Show();
            //WindowState = FormWindowState.Minimized;
            //notifyIcon1.Visible = false;
        }

        private void mnu_Nhom_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmNhom_Ban();
            frm.ShowDialog();
        }

        private void mnu_PhanCapDonVi_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmPhanCapDonVi();
            frm.ShowDialog();
        }

        private void alertControl1_BeforeFormShow(object sender, AlertFormEventArgs e)
        {
            m_alertform1 = e.AlertForm;
            e.AlertForm.LookAndFeel.UseDefaultLookAndFeel = false;
            e.AlertForm.LookAndFeel.SkinName = "Caramel";
        }

        private void alertControl2_BeforeFormShow(object sender, AlertFormEventArgs e)
        {
            m_alertform2 = e.AlertForm;
            e.AlertForm.LookAndFeel.UseDefaultLookAndFeel = false;
            e.AlertForm.LookAndFeel.SkinName = "Lilian";
        }

        private void alertControl3_BeforeFormShow(object sender, AlertFormEventArgs e)
        {
            m_alertform3 = e.AlertForm;
            e.AlertForm.LookAndFeel.UseDefaultLookAndFeel = false;
            e.AlertForm.LookAndFeel.SkinName = "Springtime";
        }

        private void navBarItem1_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new frmDS_CongViec(0);
            frm.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Show();
        }

        private void SendMaill(string ds_IDnhanvien, string noiDung)
        {
            var clsNs = new clsNhanSu();
            var dt = clsNs.GetNhanSu(SystemModule.HeThong.GlobalVariables.uID_DonVi, 0);
            var EmailName = "";
            //
            var mailFrom = "phongtckt.garco10@gmail.com";
            var password = "phongtckt";
            const string subject = "Nhắc nhở công việc của phòng tài chính kế toán";
            var body = noiDung;
            //
            foreach (DataRow dr in dt.Rows)
            {
                EmailName = dr["Email_CongTy"].ToString();
                if (TrongDS(ds_IDnhanvien, dr["ID_NhanSu"].ToString()))
                {
                    MessageBox.Show("susscess");
                    var fromAddress = new MailAddress(mailFrom, "Phòng tài chính kế toán");
                    var toAddress = new MailAddress(EmailName, "To Name");
                    var smtp = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        Credentials = new NetworkCredential(fromAddress.Address, password),
                        Timeout = 20000
                    };
                    using (var message = new MailMessage(fromAddress, toAddress)
                    {
                        Subject = subject,
                        Body = body
                    })
                    {
                        smtp.Send(message);
                    }
                }
            }
        }

        private bool TrongDS(string ds, string id)
        {
            var array = ds.Split(',');
            for (var i = 0; i < array.Length; ++i)
                if (id == array[i]) return true;
            return false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //var rd = new Random();
            //var A = rd.Next(0, 255);
            //var R = rd.Next(0, 255);
            //var G = rd.Next(0, 255);
            //var B = rd.Next(0, 255);
            //SoThongBaoChuaDoc();
            //if (m_iSoLuongThongBao != 0)
            //{
            //    lblThongBao.Appearance.BackColor = Color.FromArgb(255, 233, 235, 243);
            //    lblThongBao.Appearance.ForeColor = Color.FromArgb(A, R, G, B);
            //    lblThongBao.Text = m_iSoLuongThongBao.ToString();
            //}
            //else
            //{
            //    lblThongBao.Visible = false;
            //}
        }


        private int SoThongBaoChuaDoc()
        {
            var thongBao = new clsThongBao();
            var dt = thongBao.SelectAll_By_ID_NhanSu(GlobalVariables.GetID_NhanSu().ToString());
            m_iSoLuongThongBao = dt.Rows.Count;
            return m_iSoLuongThongBao;
        }

        private void mnu_DonViKQ_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmDM_DonVi_KetQua();
            frm.Show();
        }

        private void btnBaoCao_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new frmTongHopBaoCao();
            tabForms.OpenForm(frm, "Tổng hợp báo cáo");
        }

        private void btnSoTay_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var frm = new frmSoTayHarvard();
            tabForms.OpenForm(frm,"Sổ tay Harvard");
        }

        #region GlobalVariables

        private int m_iCongViecTH;
        private int m_iID_CongViecTH;
        private int m_iCongViecDH;
        private int m_iID_CongViecDH;
        private int m_iSoLuongThongBao;
        private int id_NhanSu_DangNhap;
        private Form m_alertform1;
        private Form m_alertform2;
        private Form m_alertform3;
        private readonly List<int> m_lstID_CongViec_DaThongBao = new List<int>();
        private readonly List<int> m_lstID_DaThongBao = new List<int>();

        #endregion

        #region ThongBao

        private void CB_ThongBao_KhiCoThayDoi()
        {
            var cls = new clsCongViec();
            var dt = cls.Select_CongViec_ThongBao_KhiCoThayDoi(GlobalVariables.GetID_NhanSu()
                .ToString(CultureInfo.InvariantCulture));
            var strMessage = "";

            int iID_ThongBao;

            foreach (DataRow dataRow in dt.Rows)
            {
                iID_ThongBao = int.Parse(dataRow["ID_ThongBao"].ToString());
                if (!m_lstID_DaThongBao.Contains(iID_ThongBao))
                {
                    m_lstID_DaThongBao.Add(iID_ThongBao);
                    strMessage = dataRow["NoiDung"].ToString();
                    alertControl3.Show(ActiveMdiChild, "Thông báo", strMessage);
                }
            }
        }

        private void CB_ThongBao_KhiCoThayDoi_VaoForm()
        {
            //1. Lay cv chua hoan thanh va thoi gian can canh bao
            var cls = new clsCongViec();
            var dt = cls.Select_CongViec_ThongBao_KhiCoThayDoi(GlobalVariables.GetID_NhanSu().ToString());
            var strMessage = "";

            foreach (DataRow dataRow in dt.Rows)
            {
                strMessage = dataRow["NoiDung"].ToString();
                alertControl3.Show(ActiveMdiChild, "Thông báo", strMessage);
            }
        }

        private void CB_ThongBao_DenHan()
        {
            //1. Lay cv chua hoan thanh va thoi gian can canh bao
            var cls = new clsCongViec();
            var dt = cls.Select_CongViec_ThongBaoTruocKhoangThoiGian(GlobalVariables.GetID_NhanSu()
                .ToString(CultureInfo.InvariantCulture));
            var strMessage = "";

            int iID_CongViec;

            foreach (DataRow dataRow in dt.Rows)
            {
                iID_CongViec = int.Parse(dataRow["ID_CongViec_ThongBao"].ToString());
                if (!m_lstID_CongViec_DaThongBao.Contains(iID_CongViec))
                {
                    m_lstID_CongViec_DaThongBao.Add(iID_CongViec);
                    strMessage = string.Format("Công việc '{0}' sắp đến hạn hoàn thành!", dataRow["TieuDe"]);
                    alertControl2.Show(ActiveMdiChild, "Thông báo", strMessage);
                }
            }
        }

        private void CB_ThongBao_DenHan_VaoForm()
        {
            //1. Lay cv chua hoan thanh va thoi gian can canh bao
            var cls = new clsCongViec();
            var dt = cls.Select_CongViec_ThongBaoTruocKhoangThoiGian(GlobalVariables.GetID_NhanSu().ToString());
            var strMessage = "";

            foreach (DataRow dataRow in dt.Rows)
            {
                strMessage = string.Format("Công việc '{0}' sắp đến hạn hoàn thành!", dataRow["TieuDe"]);
                alertControl2.Show(ActiveMdiChild, "Thông báo", strMessage);
            }
        }

        private void CB_CongViecHoanThanhTrongNgay()
        {
            var cls = new clsCongViec();
            var dt = cls.CongViec_HoanThanhTrongNgay(GlobalVariables.GetID_NhanSu()
                .ToString(CultureInfo.InvariantCulture));
            switch (dt.Rows.Count)
            {
                case 0:
                    break;
                case 1:
                    m_iCongViecTH = 1;
                    m_iID_CongViecTH = int.Parse(dt.Rows[0]["ID_CongViec"].ToString());
                    alertControl1.Show(ActiveMdiChild, "Thông báo",
                        "Có " + 1 + " công việc phải hoàn thành trong ngày hôm nay!");
                    break;
                default:
                    if (dt.Rows.Count > 1)
                    {
                        m_iCongViecTH = dt.Rows.Count;
                        alertControl1.Show(ActiveMdiChild, "Thông báo",
                            "Có " + m_iCongViecTH + " công việc phải hoàn thành trong ngày hôm nay!");
                    }
                    break;
            }
        }

        #endregion

        #region AlertControl

        private void alertControl1_AlertClick(object sender, AlertClickEventArgs e)
        {
            switch (m_iCongViecTH)
            {
                case 0:
                    break;
                case 1:
                    var ID_CongViec = m_iID_CongViecTH;
                    var frm = new frmCongViec(ID_CongViec, true);
                    frm.ShowDialog();
                    break;
                default:
                    //var frmDsCongViec = new frmDS_CongViec(GlobalVariables.GetID_NhanSu(), 1);
                    //tabForms.OpenForm(frmDsCongViec, "Danh sách công việc");
                    break;
            }
        }

        private void alertControl2_AlertClick(object sender, AlertClickEventArgs e)
        {
            switch (m_iCongViecTH)
            {
                case 0:
                    break;
                case 1:
                    var ID_CongViec = m_iID_CongViecDH;
                    var frm = new frmCongViec(ID_CongViec, true);
                    frm.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void alertControl3_AlertClick(object sender, AlertClickEventArgs e)
        {
        }

        #endregion

        private void mnu_PhanCapNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmQL_PhanCapNhanVien();
            frm.Show();
        }

        private void mnu_btnCongViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var frm = new frmTrangCaNhan();
            var frm = new frmQuanLyCaNhan(id_NhanSu_DangNhap);
            tabForms.OpenForm(frm, "Công việc cá nhân");
        }

        private void mnu_btnThongBao_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frmThongBao = new frmThongBao();
            frmThongBao.Show();
        }

        private void mnu_btnHarvard_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmSoTayHarvard();
            tabForms.OpenForm(frm, "Sổ tay Harvard");
        }

        private void mnu_btnQuanLyTienDo_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmQuanLyTienDo(id_NhanSu_DangNhap);
            tabForms.OpenForm(frm, "Quản lý tiến độ thực hiện");
        }

        private void mnu_btnLichLamViec_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmLich(id_NhanSu_DangNhap);
            tabForms.OpenForm(frm, "Lịch");
        }

        private void mnu_btnLichNghi_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmDM_NgayNghiLe();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void mnu_btnTongHopBaoCao_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmTongHopBaoCao();
            tabForms.OpenForm(frm, "Tổng hợp báo cáo");
        }


    }
}