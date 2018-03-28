﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MainProgram.Forms;
using MainProgram.Objects;
using MainProgram.DAO;

namespace MainProgram.UCs
{
    public partial class ucAdmin : UserControl
    {
        public ucAdmin()
        {
            InitializeComponent();

        }

        private void tsbtnThanhToan_Click(object sender, EventArgs e)
        {
            //  string _mahd = dataGridView3.SelectedRows[0].Cells["Mahdphong"].Value.ToString();
            // string _maphong = dataGridView3.SelectedRows[0].Cells["Maphong2"].Value.ToString();
            //   ThanhtoanThang frmTTThang = new ThanhtoanThang(_mahd, _maphong);
            // frmTTThang.ShowDialog();
        }

        private void ucAdmin_Load(object sender, EventArgs e)
        {
            LoadData(dataGridView1, "Khach");

            LoadData(dataGridView2, "Phong");
            LoadData(dataGridView3, "DangKyPhong");
        }

        private static void LoadData(DataGridView dgv, string tenbang)
        {

            string query = "SELECT * FROM " + tenbang;
            DataTable khach = new DataTable();

            khach = DataProvider.Instance.ExecuteQuery(query);

            List<Phong> listRoom = new List<Phong>();

            listRoom = PhongDAO.Instance.GetListRoom();


            dgv.DataSource = khach;


        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DangKyKhach f = new DangKyKhach();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmThemPhong f = new frmThemPhong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (tabControlAdmin.SelectedIndex == 0)
            {
                tab1("edit");
                LoadData(dataGridView1, "Khach");
            }
            else if (tabControlAdmin.SelectedIndex == 1)
            {
                tab2("edit");
                LoadData(dataGridView2, "Phong");
            }
            else if (tabControlAdmin.SelectedIndex == 2)
            {
                tab3("edit");
                LoadData(dataGridView3, "DangKyPhong");
            }




        }

        void tab1(string index)
        {
            if (index.Equals("edit"))
            {

                try
                {
                    string makhach = dataGridView1.SelectedCells[0].Value.ToString();
                    string hoten = dataGridView1.SelectedCells[1].Value.ToString();
                    int namsinh = int.Parse(dataGridView1.SelectedCells[2].Value.ToString());

                    int gioitinh = 0;
                    if ((bool)dataGridView1.SelectedCells[3].Value)
                    {
                        gioitinh = 1;
                    }

                    string sdt = dataGridView1.SelectedCells[4].Value.ToString();
                    string quequan = dataGridView1.SelectedCells[5].Value.ToString();
                    string cmnd = dataGridView1.SelectedCells[6].Value.ToString();

                    KhachDAO.Instance.UpdateCustomer(makhach, hoten, namsinh, gioitinh, sdt, quequan, cmnd);
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                }
                catch
                {

                    MessageBox.Show("Cập nhật thất bại");
                }
            }//end if
            else
            {
                try
                {
                    string makhach = dataGridView1.SelectedCells[0].Value.ToString();
                    KhachDAO.Instance.DeleteCutomer(makhach);
                    MessageBox.Show("Xóa khách hàng thành công");
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại");

                }

            }
        }

        void tab2(string index)
        {
            if (index.Equals("edit"))
            {

                try
                {
                    string maphong = dataGridView2.SelectedCells[0].Value.ToString();

                    int dientich = int.Parse(dataGridView2.SelectedCells[1].Value.ToString());
                    string loaiphong = dataGridView2.SelectedCells[2].Value.ToString();

                    string tinhtrang = dataGridView2.SelectedCells[3].Value.ToString();
                    int giaphong = int.Parse(dataGridView2.SelectedCells[4].Value.ToString());

                    string dodac = dataGridView2.SelectedCells[5].Value.ToString();

                    PhongDAO.Instance.UpdateRoom(maphong, dientich, loaiphong, tinhtrang, giaphong, dodac);
                    MessageBox.Show("Cập nhật thông tin phòng thành công");
                }
                catch
                {

                    MessageBox.Show("Cập nhật thất bại");
                }
            }//end if
            else
            {
                try
                {
                    string maphong = dataGridView2.SelectedCells[0].Value.ToString();
                    PhongDAO.Instance.DeletePhong(maphong);
                    MessageBox.Show("Xóa phòng thành công");
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại");

                }
            }
        }

        void tab3(string index)
        {
            if (index.Equals("edit"))
            {

                try
                {
                    int mahdp = int.Parse(dataGridView3.SelectedCells[0].Value.ToString());
                    string makhach = dataGridView3.SelectedCells[1].Value.ToString();
                    string maphong = dataGridView3.SelectedCells[2].Value.ToString();

                    int songuoi = int.Parse(dataGridView3.SelectedCells[3].Value.ToString());
                    string ngaythue = dataGridView3.SelectedCells[4].Value.ToString();
                    int datcoc = int.Parse(dataGridView3.SelectedCells[5].Value.ToString());
                    string ngaytra = dataGridView3.SelectedCells[6].Value.ToString();

                    string htthanhtoan = dataGridView3.SelectedCells[7].Value.ToString();

                    DKyPhongDAO.Instance.UpdateDangKyPhong(mahdp, makhach, maphong, songuoi, ngaythue, ngaytra, datcoc, htthanhtoan);


                    MessageBox.Show("Cập nhật thông tin đăng ký phòng thành công");
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại");

                }
            }//end if
            else
            {
                try
                {
                    int mahdp = int.Parse(dataGridView3.SelectedCells[0].Value.ToString());
                    DKyPhongDAO.Instance.DeleteDangKyPhong(mahdp);
                    MessageBox.Show("Xóa đăng ký phòng thành công");
                }
                catch
                {
                    MessageBox.Show("Cập nhật thất bại");

                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (tabControlAdmin.SelectedIndex == 0)
            {
                tab1("delete");
                LoadData(dataGridView1, "Khach");
            }
            else if (tabControlAdmin.SelectedIndex == 1)
            {
                tab2("delete");
                LoadData(dataGridView2, "Phong");
            }
            else if (tabControlAdmin.SelectedIndex == 2)
            {
                tab3("delete");
                LoadData(dataGridView3, "DangKyPhong");

            }

        }
    }
}
