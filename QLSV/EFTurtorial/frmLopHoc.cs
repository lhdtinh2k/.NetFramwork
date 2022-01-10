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
    public partial class frmLopHoc : Form
    {
        public frmLopHoc()
        {
            InitializeComponent();
            Naplophoc();
        }
        void Naplophoc()
        {
            var ls = LopHocDLL.GetListVM();
            lopHocVMBindingSource.DataSource = ls;
            dtgvLopHoc.DataSource = lopHocVMBindingSource;
        }

        public LopHocVM selectLopHoc
        {
            get {
                return lopHocVMBindingSource.Current as LopHocVM;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectLopHoc != null)
            {
                LopHocDLL.delete(selectLopHoc.ID);
                MessageBox.Show("Da xoa thanh cong");
                lopHocVMBindingSource.RemoveCurrent();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

           var window = new frmChiTiet(); // Help being the help window class
        
            var rs = window.ShowDialog();
            if(rs == DialogResult.OK)
            {
                Naplophoc();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectLopHoc != null)
            {
                var window = new frmChiTiet(selectLopHoc); // Help being the help window class

                var rs = window.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    Naplophoc();
                }
            }
        }

       
    }
}
