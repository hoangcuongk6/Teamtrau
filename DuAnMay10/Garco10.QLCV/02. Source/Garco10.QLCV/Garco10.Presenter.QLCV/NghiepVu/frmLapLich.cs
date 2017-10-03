using Garco10.SystemModule.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using VSCM.Base.Utils;
using GlobalVariables = Garco10.SystemModule.HeThong.GlobalVariables;

namespace Garco10.Presenter.QLCV.NghiepVu
{
    public partial class frmLapLich : FormBaseGarco10
    {
        public string m_strThu = String.Empty;
        public string m_strThang = string.Empty;
        public string m_strNgay = string.Empty;
        private bool m_bCapNhat;

        public List<object> thongSo = new List<object>();

        public frmLapLich()
        {
            InitializeComponent();
            LoadcmbThoiGian();
            dtTuGio.Value = GlobalVariables.GetCurrentDateTime();
            dtDenGio.Value = GlobalVariables.GetCurrentDateTime();
            cmbDonViTG.SelectedIndex = 0;
        }

        public frmLapLich(string thu, string ngay, string thang, DateTime gioBatDau, DateTime gioDenHan)
        {
            InitializeComponent();
            LoadcmbThoiGian();
            //cmbDonViTG.SelectedIndex = 0;
            m_bCapNhat = true;
            if (thu != "")
            {
                cmbDonViTG.SelectedIndex = 0;
                string[] thuA = thu.Split(',');
                foreach (string t in thuA)
                {
                    switch (t)
                    {
                        case "2":
                            chkT2.Checked = true;
                            break;

                        case "3":
                            chkT3.Checked = true;
                            break;

                        case "4":
                            chkT4.Checked = true;
                            break;

                        case "5":
                            chkT5.Checked = true;
                            break;

                        case "6":
                            chkT6.Checked = true;
                            break;

                        case "7":
                            chkT7.Checked = true;
                            break;

                        case "8":
                            chk8.Checked = true;
                            break;
                    }
                }
            }
            else if (thang != "" || ngay != "")
            {
                cmbDonViTG.SelectedIndex = 1;
            }

            txtNgay.Text = m_strNgay = ngay;
            txtThang.Text = m_strThang = thang;
            dtTuGio.Value = gioBatDau.ToString("HH:mm");
            dtDenGio.Value = gioDenHan.ToString("HH:mm");

            thongSo.Add(m_strThu);
            thongSo.Add(txtNgay.Text);
            thongSo.Add(txtThang.Text);
            thongSo.Add(dtTuGio.Value);
            thongSo.Add(dtDenGio.Value);
        }

        private void frmLapLich_Load(object sender, EventArgs e)
        {
            if (!m_bCapNhat)
            {
                dtTuGio.Value = "07:30";
                dtDenGio.Value = "17:00";
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            if (!IsValid()) return;
            if (cmbDonViTG.SelectedIndex == 0)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox b = (CheckBox)c;
                        if (b.Checked)
                        {
                            m_strThu = b.Text.Split('T')[1] + "," + m_strThu;
                        }
                    }
                }
            }
            thongSo.Clear();
            thongSo.Add(m_strThu);
            thongSo.Add(txtNgay.Text);
            thongSo.Add(txtThang.Text);
            thongSo.Add(dtTuGio.Value);
            thongSo.Add(dtDenGio.Value);
            BaseMessages.ShowInformationMessage("Lưu thành công");
            Visible = false;
        }

        private bool IsValid()
        {
            if (cmbDonViTG.SelectedIndex == 0)
            {
                if (chkT2.Checked == false && chkT3.Checked == false && chkT4.Checked==false && chkT5.Checked==false && chkT6.Checked==false && chkT7.Checked==false && chk8.Checked==false)
                {
                    BaseMessages.ShowWarningMessage("Chưa chọn thứ trong tuần để lặp lại");
                    return false;
                }
            }
            if (cmbDonViTG.SelectedIndex == 1)
            {
                if (txtNgay.Text == "")
                {
                    BaseMessages.ShowWarningMessage("Ngày không được để trống");
                    return false;
                }
                if (txtThang.Text == "")
                {
                    BaseMessages.ShowWarningMessage("Tháng không được để trống");
                    return false;
                }
            }
            if (dtTuGio.Value.ToString() != "" && dtDenGio.Value.ToString() != "")
            {
                int result = DateTime.Compare(DateTime.Parse(dtTuGio.Value.ToString()), DateTime.Parse(dtDenGio.Value.ToString()));
                if (result > 0)
                {
                    BaseMessages.ShowWarningMessage("Giờ bắt đầu phải nhỏ hơn giờ kết thúc");
                    return false;
                }
            }

            return true;
        }

        private void LoadcmbThoiGian()
        {
            var cmb = cmbDonViTG;
            cmb.Tag = 0;
            cmb.AddItemSeparator = '|';
            cmb.ClearItems();
            DataTable dt = new DataTable();
            //Add columns cho dt
            dt.Columns.Add("Loai_ThoiGian", typeof(int));
            dt.Columns.Add("Ten_ThoiGian", typeof(String));
            //Add Row cho dt
            dt.Rows.Add(0, "Tuần");
            dt.Rows.Add(1, "Tháng");
            //Add dt vào combobox
            cmb.SetDataSource(dt, "Loai_ThoiGian", "Ten_ThoiGian");
            cmb.ColumnWidth = 0;
            cmb.Tag = 1;
        }

        private void cmbDonViTG_TextChanged(object sender, EventArgs e)
        {
            switch (cmbDonViTG.SelectedIndex)
            {
                case 0:
                    chkT2.Enabled = true;
                    chkT3.Enabled = true;
                    chkT4.Enabled = true;
                    chkT5.Enabled = true;
                    chkT6.Enabled = true;
                    chkT7.Enabled = true;
                    chk8.Enabled = true;
                    txtNgay.Enabled = false;
                    txtThang.Enabled = false;
                    txtNgay.Text = String.Empty;
                    txtThang.Text = String.Empty;
                    break;

                case 1:
                    chkT2.Enabled = false;
                    chkT3.Enabled = false;
                    chkT4.Enabled = false;
                    chkT5.Enabled = false;
                    chkT6.Enabled = false;
                    chkT7.Enabled = false;
                    chk8.Enabled = false;
                    chkT2.Checked = false;
                    chkT3.Checked = false;
                    chkT4.Checked = false;
                    chkT5.Checked = false;
                    chkT6.Checked = false;
                    chkT7.Checked = false;
                    chk8.Checked = false;
                    txtNgay.Enabled = true;
                    txtThang.Enabled = true;
                    break;
            }
        }

        private void txtNgay_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyInput = e.KeyChar.ToString();

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != ':' && (char)e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void txtThang_KeyPress(object sender, KeyPressEventArgs e)
        {
            string keyInput = e.KeyChar.ToString();

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != ':' && (char)e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}