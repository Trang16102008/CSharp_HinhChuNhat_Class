using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HinhChuNhat_Class
{
    internal class hình_chữ_nhật
    {
        public double chieudai;
        public double chieurong;

        public double tinhdientich() 
        {
            return chieudai * chieurong;
        }
        public double tinhchuvi()
        {
            return (chieudai+chieurong)*2;
        }
    }
}
