using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace Gym_Management
{
    public partial class SanPham : Form
    {
        BindingSource splist = new BindingSource();
        SanPhamBUS spBUS = new SanPhamBUS();
        public SANPHAM currensp;
        public SanPham()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dtg_SP.DataSource = splist;
            LoadSanPhamList();
            AddSanPhamBinding();
        }

        void AddSanPhamBinding()
        {
            tb_tensp.DataBindings.Add(new Binding("Texts", dtg_SP.DataSource, "tensp", true, DataSourceUpdateMode.Never));
            tb_loaisp.DataBindings.Add(new Binding("Texts", dtg_SP.DataSource, "malsp", true, DataSourceUpdateMode.Never));
            tb_soluongsp.DataBindings.Add(new Binding("Texts", dtg_SP.DataSource, "soluong", true, DataSourceUpdateMode.Never));
            tb_hang.DataBindings.Add(new Binding("Texts", dtg_SP.DataSource, "dongia", true, DataSourceUpdateMode.Never));

        }

        void LoadSanPhamList()
        {
            splist.DataSource = spBUS.GetSanPhamList();
            
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemSp f = new ThemSp();
            f.ShowDialog();
            LoadSanPhamList();
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (dtg_SP.SelectedRows.Count > 0)
            {
                currensp = spBUS.getSanPhamByID(dtg_SP.SelectedRows[0].Cells["masp"].Value.ToString());
                SuaSp f = new SuaSp(currensp);
                f.ShowDialog();
                LoadSanPhamList();
            }
            else
                MessageBox.Show("Chọn một sản phẩm để sửa");
            
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_SP.SelectedRows.Count > 0)
                {
                    if (spBUS.deleteSanPham(dtg_SP.SelectedRows[0].Cells["masp"].Value.ToString()))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        this.Show();
                        LoadSanPhamList();
                    }
                }
                else
                    MessageBox.Show("Chọn một sản phẩm để xóa");


            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Xóa THẤT BẠI!");
            }
        }

        private void SanPhamSearch_Enter(object sender, EventArgs e)
        {
            if (tb_Search.Text == "Search...")
            {
                tb_Search.Text = "";
                tb_Search.ForeColor = Color.Black;
            }
        }

        private void SanPhamSearch_Leave(object sender, EventArgs e)
        {
            if (tb_Search.Text == "")
            {
                tb_Search.Text = "Search...";
                tb_Search.ForeColor = Color.Gray;
            }
        }
        List<SANPHAM> SearchSanPhamByName(string tensp)
        {
            List<SANPHAM> listsp = spBUS.SearchSanPhamByName(tensp);

            return listsp;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            splist.DataSource = SearchSanPhamByName(tb_Search.Texts);
        }
    }
}
