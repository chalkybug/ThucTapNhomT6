using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Objects
{
    class Khach          //Đối tượng class biểu diễn cho thực thể Khách
    {
        private string makhach;       //Mã khách
        private string hoten;         //Họ và tên khách
        private int namsinh;          //Năm sinh
        private bool gioitinh;        //Giới tính
        private string cmnd;          //Số CMND của khách
        private string quequan;       //Quê quán
        private string sdt;           //Số điện thoại của khách


        public Khach(string makhach, string hoten, int namsinh, bool gioitinh, string cmnd, string quequan, string sdt)
        {
            this.makhach = makhach;
            this.hoten = hoten;
            this.namsinh = namsinh;
            this.gioitinh = gioitinh;
            this.cmnd = cmnd;
            this.quequan = quequan;
            this.sdt = sdt;
        }

        public Khach(DataRow row)
        {

        }

        public string Makhach
        {
            get
            {
                return makhach;
            }
            set
            {
                makhach = value;
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
        public int Namsinh
        {
            get
            {
                return namsinh;
            }
            set
            {
                namsinh = value;
            }
        }
        public bool Gioitinh
        {
            get
            {
                return gioitinh;
            }
            set
            {
                gioitinh = value;
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
        public string Quequan
        {
            get
            {
                return quequan;
            }
            set
            {
                quequan = value;
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
    }
}
