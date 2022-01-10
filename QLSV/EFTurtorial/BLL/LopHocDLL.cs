using EFTurtorial.DAL;
using EFTurtorial.ViewModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTurtorial.BLL
{
    class LopHocDLL
    {   public enum KETQUA{
            ThanhCong,TenTrung
        }
        public static List<LopHoc> GetList()
        {
            QLSinhVienModel model = new QLSinhVienModel();
            //return model.LopHoc.OrderByDescending(e => e.Name).ToList();
            
            return model.LopHocs.OrderByDescending(e => e.Name).ToList();
        }
        public static List<LopHocVM> GetListVM()
          
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var ls = model.LopHocs.Select(e => new LopHocVM
            {
                ID = e.ID,
                Name = e.Name,
                TotalStudent = e.SinhViens.Count()
            }).ToList();
            return ls;

            
           
        }
        public static void delete(long id)
        {
            QLSinhVienModel model = new QLSinhVienModel();
            var lop = model.LopHocs.Where(e1 => e1.ID == id).FirstOrDefault();
            if (lop != null)
                model.LopHocs.Remove(lop);
            else
                throw new Exception("Lớp học không tồn tại");
            model.SaveChanges();

        }
        public static KETQUA Add(LopHocVM lopHocVM)
        {
            DAL.QLSinhVienModel model = new DAL.QLSinhVienModel();
            
            var lop = model.LopHocs.Where(e => e.Name == lopHocVM.Name).FirstOrDefault();
            if (lop != null)
            {
                return KETQUA.TenTrung;
            }
            else
            {
                lop = new LopHoc
                {
                    Name = lopHocVM.Name
                };
                model.LopHocs.Add(lop);
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }
           
        }

        public static KETQUA Update(LopHocVM lopHocVM)
        {
            DAL.QLSinhVienModel model = new DAL.QLSinhVienModel();
            var lop = model.LopHocs.Where(e =>
                 e.ID != lopHocVM.ID && e.Name == lopHocVM.Name).FirstOrDefault();
            if(lop != null)
            {
                return KETQUA.TenTrung;
            }
            else
            {
                lop = model.LopHocs.Where(e => e.ID == lopHocVM.ID).FirstOrDefault();
                lop.Name = lopHocVM.Name;
                model.SaveChanges();
                return KETQUA.ThanhCong;
            }

        }
              
    }
    }
