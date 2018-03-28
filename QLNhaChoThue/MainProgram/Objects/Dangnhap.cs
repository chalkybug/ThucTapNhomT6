using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProgram.Objects
{
    class Dangnhap             //Đối tượng class biểu diễn cho bảng Đăng nhập
    {
        private string tentk;      //Tên tài khoản đăng nhập
        private string matkhau;    //Mật khẩu
        private string machutk;    //Mã chủ tài khoản đăng nhập
        private string quyen;      //Quyền hạn đăng nhập

        public string Tentk
        {
            get
            {
                return tentk;
            }
            set
            {
                tentk = value;
            }
        }
        public string Matkhau
        {
            get
            {
                return matkhau;
            }
            set
            {
                matkhau = value;
            }
        }
        public string Machutk
        {
            get
            {
                return machutk;
            }
            set
            {
                machutk = value;
            }
        }
        public string Quyen
        {
            get
            {
                return quyen;
            }
            set
            {
                quyen = value;
            }
        }
    }
}
