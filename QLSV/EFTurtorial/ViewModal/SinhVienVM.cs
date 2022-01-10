using EFTurtorial.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTurtorial.ViewModal
{
    public class SinhVienVM
    {
        public long ID { get; set; }

        public string IDStudent { get; set; }


        public string FirstName { get; set; }


        public string LastName { get; set; }


        public DateTime? DOB { get; set; }

        public string POB { get; set; }

        public long? IDLop { get; set; }

        public virtual LopHoc LopHoc { get; set; }
    }
}
