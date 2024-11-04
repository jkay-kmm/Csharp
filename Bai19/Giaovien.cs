using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai19
{
    internal class Giaovien : Sinhvien
    {
        public string MonHoc { get; set; }
        public string DiaChi { get; set; }
        public new double ChieuCao()
        {
            return base.Chieucao() + 189;
        }
        
      
    }
}
