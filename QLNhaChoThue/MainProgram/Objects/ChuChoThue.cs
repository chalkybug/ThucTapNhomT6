using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Objects
{
    class ChuChoThue            //Đối tượng class biểu diễn thực thể Chủ cho thuê
    {
        private string machu;   //Mã chủ cho thuê
        private string hoten;   //Họ và tên chủ cho thuê
        private string sdt;     //Số điện thoại của chủ cho thuê
        private string cmnd;    //Số CMND của chủ cho thuê

        public ChuChoThue(string machu, string hoten, string sdt, string cmnd)
        {
            this.machu = machu;
            this.hoten = hoten;
            this.sdt = sdt;
            this.cmnd = cmnd;
        }

        public ChuChoThue(DataRow row)
        {
          
        }
        public string Machu
        {
            get
            {
                return machu;
            }
            set
            {
                machu = value;
            }
        }
        public string Hoten
        {
            get
            {
                return hoten;
            }
            set
            {
                hoten = value;
            }
        }
        public string Sdt
        {
            get
            {
                return sdt;
            }
            set
            {
                sdt = value;
            }
        }
        public string Cmnd
        {
            get
            {
                return cmnd;
            }
            set
            {
                cmnd = value;
            }
        }
    }
}
