using EFTurtorial.ViewModal;
using EFTurtorial.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static EFTurtorial.BLL.LopHocDLL;

namespace EFTurtorial
{
    public partial class frmChiTiet : Form
    {
        LopHocVM lopHocVM;
        public frmChiTiet(LopHocVM lopHocVM=null)
        {
            InitializeComponent();
            this.lopHocVM = lopHocVM;
            if (lopHocVM == null)
            {
                this.Text = "Thêm Mới Lớp Học";
    //            txtTenLop.Text = lopHocVM.Name;
            }
            else
            {
                this.Text = "Chỉnh Sửa Lớp Học";
                txtTenLop.Text = lopHocVM.Name;
            }
        }

        private void btnDongY_Click(object sender, EventArgs e)
        { 
            errorProvider1.Clear();
            var tenLop = txtTenLop.Text;
            if (String.IsNullOrEmpty(tenLop))
            {
                errorProvider1.SetError(txtTenLop, "Lớp học không được để trống");
                return;
            }
            // gio m lam chi ? sinh vien hay lop hoc,lop hoc
            if (lopHocVM == null)
            {
                //themmoidulieu
                var rs = LopHocDLL.Add(new LopHocVM { Name = tenLop });
                    //LopHocBLL.Add(new LopHocVM { Name = tenLop });
                if (rs == KETQUA.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else if (rs == KETQUA.TenTrung)
                {
                    MessageBox.Show("Tên Lớp Không Được Trùng Nhau", "Thông Báo");
                }

            }
            else
            {
                //capnhatdulieu
                lopHocVM.Name = tenLop;
                var rs = LopHocDLL.Update(lopHocVM);
                
                if (rs == KETQUA.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else if (rs == KETQUA.TenTrung)
                {
                    MessageBox.Show("Tên Lớp Không Được Trùng Nhau", "Thông Báo");
                }
            }


        }
    }
}
