using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProgram.Forms
{
    public partial class ThanhtoanThang : Form
    {
        private string mahdp;
        private string maphong;
        public ThanhtoanThang()
        {
            InitializeComponent();
        }
        public ThanhtoanThang(string _mahdp, string _maphong)
        {
            this.mahdp = _mahdp;
            this.maphong = _maphong;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = maphong;
            int giaphong = int.Parse(textBox2.Text);
            int sodien = int.Parse(textBox3.Text);
            int sonuoc = int.Parse(textBox4.Text);
            int mang = int.Parse(textBox5.Text);
            int phikhac = int.Parse(textBox6.Text);

            //Thêm vào CSDL
            SQLconnect query = new SQLconnect();
            string lenh = "INSERT INTO GiaDV VALUES('" + mahdp + "'," + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + "," + textBox6.Text + ")";
            try
            {
                query.ExeNoneQuery(lenh);
                //Giả sử rằng tiền điện là 50k/tháng
                //tiền nước là 20k/tháng
                //tiền internet là 10k/tháng
                int sum = giaphong + sodien * 50000 + sonuoc * 20000 + mang * 10000 + phikhac;
                MessageBox.Show("Tổng số tiền thanh toán là : " + sum + " VNĐ! \n Bấm OK để xác nhận thanh toán!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            this.Close();
        }

        private void ThanhtoanThang_Load(object sender, EventArgs e)
        {
            SQLconnect query = new SQLconnect();
            textBox1.Text = maphong;
            string gia = query.ExeScalarQuery("SELECT GiaPhong FROM Phong WHERE MaPhong='" + maphong + "'");
            textBox2.Text = gia;
        }
    }
}
