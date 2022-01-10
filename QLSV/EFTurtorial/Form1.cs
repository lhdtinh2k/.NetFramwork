using EFTurtorial.BLL;
using EFTurtorial.DAL;
using EFTurtorial.ViewModal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFTurtorial
{
    public partial class Form1 : Form
    {
        SinhVienVM sinhVienVM;
        public Form1()
        {
            InitializeComponent();
            NapSinhVien();
            GetList();
            GetList2();
            AddListStudent();

        }

        void GetList()
        {
            var ls = LopHocDLL.GetList();
            comboBox1.DataSource = ls;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "ID";
        }
        void GetList2()
        {
            var ls = LopHocDLL.GetList();
            numIDLop1.DataSource = ls;
            numIDLop1.DisplayMember = "ID";
            numIDLop1.ValueMember = "ID";
        }


        public SinhVienVM selectSinhVien
        {
            get
            {
                return sinhVienBindingSource1.Current as SinhVienVM;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lop = comboBox1.SelectedItem as LopHoc;
            if (lop != null)
            {
                var ls = SinhVienBLL.GetList(lop.ID);
                sinhVienBindingSource1.DataSource = ls;
                dataGridView1.DataSource = sinhVienBindingSource1;

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var ls = SinhVienBLL.GetAllList();
            sinhVienBindingSource1.DataSource = ls;
            dataGridView1.DataSource = sinhVienBindingSource1;
        }

        void NapSinhVien()
        {
            var ls = SinhVienBLL.GetAllList();
            sinhVienBindingSource1.DataSource = ls;
            dataGridView1.DataSource = sinhVienBindingSource1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            var masv = txbMsv.Text;
            var ten = txbTen.Text;
            var ho = txbHo.Text;
            var ngaysinh = dtbDOB.Value;
            var noisinh = txbPOB.Text;
            var idlop = numIDLop1.SelectedValue;
            //

            if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(ho) || ngaysinh == null
                || string.IsNullOrEmpty(noisinh) || idlop == null)
            {
                MessageBox.Show("Thông tin không được để trống", "Thông báo");
            }
            else if (sinhVienVM == null)
            {
                var ls = SinhVienBLL.Add(new SinhVienVM
                {
                    IDStudent = masv,
                    FirstName = ten,
                    LastName = ho,
                    DOB = ngaysinh,
                    POB = noisinh,
                    IDLop = Convert.ToInt64(idlop)
                });
                if (ls == SinhVienBLL.KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                    if (DialogResult == DialogResult.OK)
                    {
                        NapSinhVien();
                    }
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }
                else if (ls == SinhVienBLL.KetQua.MaTrung)
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo");
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (selectSinhVien != null)
            {
                if (MessageBox.Show("Bạn có thực sự muốn xóa?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    SinhVienBLL.Delete(selectSinhVien.ID);
                    sinhVienBindingSource1.RemoveCurrent();
                    MessageBox.Show("Đã xóa thành công!");
                }
            }
        }

        void AddListStudent()
        {
            txbMsv.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IDStudent", true, DataSourceUpdateMode.Never));
            txbTen.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "FirstName", true, DataSourceUpdateMode.Never));
            txbHo.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "LastName", true, DataSourceUpdateMode.Never));
            dtbDOB.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "DOB", true, DataSourceUpdateMode.Never));
            txbPOB.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "POB", true, DataSourceUpdateMode.Never));
            numIDLop1.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IDLop", true, DataSourceUpdateMode.Never));
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var masv = txbMsv.Text;
            var ten = txbTen.Text;
            var ho = txbHo.Text;
            var ngaysinh = dtbDOB.Value;
            var noisinh = txbPOB.Text;
            var idlop = numIDLop1.SelectedValue;


            if (string.IsNullOrEmpty(masv) || string.IsNullOrEmpty(ten) || string.IsNullOrEmpty(ho) || ngaysinh == null
                || string.IsNullOrEmpty(noisinh) || idlop == null)
            {
                MessageBox.Show("Thông tin không được để trống", "Thông báo");
            }
            else
            {
                var ls = SinhVienBLL.Update(new SinhVienVM
                {
                    ID = selectSinhVien.ID,
                    IDStudent = masv,
                    FirstName = ten,
                    LastName = ho,
                    DOB = ngaysinh,
                    POB = noisinh,
                    IDLop = Convert.ToInt64(idlop)
                });
                if (ls == SinhVienBLL.KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                    if (DialogResult == DialogResult.OK)
                    {
                        NapSinhVien();
                    }
                    MessageBox.Show("Sửa thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại!", "Thông báo");
                }
            }
        }

        private void numIDLop_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numIDLop1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var lop = numIDLop1.SelectedItem as LopHoc;
            if (lop != null)
            {
                var ls = SinhVienBLL.GetList(lop.ID); 

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
