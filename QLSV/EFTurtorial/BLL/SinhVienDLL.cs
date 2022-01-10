using EFTurtorial.DAL;
using EFTurtorial.ViewModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTurtorial.BLL
{
    internal class SinhVienBLL
    {
        public static List<SinhVien> GetList(long idLop)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            return model.SinhViens.Where(e => e.IDLop == idLop).ToList();

        }

        public static List<SinhVienVM> GetAllList()
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var rs = model.SinhViens.Select(e => new SinhVienVM
            {
                ID = e.ID,
                IDStudent = e.IDStudent,
                FirstName = e.FirstName,
                LastName = e.LastName,
                DOB = e.DOB,
                POB = e.POB,
                IDLop = e.IDLop

            }).ToList();

            return rs;
        }

        public enum KetQua
        {
            ThanhCong, MaTrung
        }

        public static KetQua Add(SinhVienVM sinhVienVM)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var ls = model.SinhViens.Where(e => e.IDStudent == sinhVienVM.IDStudent).FirstOrDefault();
            if (ls != null)
            {
                return KetQua.MaTrung;
            }
            else
            {
                ls = new SinhVien
                {
                    IDStudent = sinhVienVM.IDStudent,
                    FirstName = sinhVienVM.FirstName,
                    LastName = sinhVienVM.LastName,
                    DOB = sinhVienVM.DOB,
                    POB = sinhVienVM.POB,
                    IDLop = sinhVienVM.IDLop
                };
                model.SinhViens.Add(ls);
                model.SaveChanges();
                return KetQua.ThanhCong;
            }
        }

        public static void Delete(long id)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var ls = model.SinhViens.Where(e => e.ID == id).FirstOrDefault();
            if (ls != null)
                model.SinhViens.Remove(ls);
            else
                throw new Exception("Sinh viên không tồn tại");
            model.SaveChanges();
        }

        public static KetQua Update(SinhVienVM sinhVienVM)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var check = model.SinhViens.Where(e => e.IDStudent == sinhVienVM.IDStudent && e.ID != sinhVienVM.ID).FirstOrDefault();

            var ls = model.SinhViens.Where(e => e.ID == sinhVienVM.ID).FirstOrDefault();
            if (ls != null && check ==null)
            {
                ls.IDStudent = sinhVienVM.IDStudent;
                ls.FirstName = sinhVienVM.FirstName;
                ls.LastName = sinhVienVM.LastName;
                ls.DOB = sinhVienVM.DOB;
                ls.POB = sinhVienVM.POB;
                ls.IDLop = sinhVienVM.IDLop;

                model.SaveChanges();
                return KetQua.ThanhCong;
            }
            else
            {
                return KetQua.MaTrung;
            }
        }
    }
}