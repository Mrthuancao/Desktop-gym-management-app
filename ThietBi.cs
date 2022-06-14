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

    public partial class ThietBi : Form
    {
        BindingSource tblist = new BindingSource();
        ThietBiBUS tbBUS = new ThietBiBUS();
        public THIETBI currentb;

        public ThietBi()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dtg_TB.DataSource = tblist;
            LoadThietBiList();
            AddThietBiBinding();
        }
        void LoadThietBiList()
        {
            tblist.DataSource = tbBUS.GetTb();
            dtg_TB.Columns["ngsd"].Visible = false;
            dtg_TB.Columns["hanbaotri"].Visible = false;
        }

        void AddThietBiBinding()
        {
            tb_tentb.DataBindings.Add(new Binding("Texts", dtg_TB.DataSource, "tenthietbi", true, DataSourceUpdateMode.Never));
            tb_loaitb.DataBindings.Add(new Binding("Texts", dtg_TB.DataSource, "tenltb", true, DataSourceUpdateMode.Never));
            tb_soluongtb.DataBindings.Add(new Binding("Texts", dtg_TB.DataSource, "soluong", true, DataSourceUpdateMode.Never));
            tb_giatb.DataBindings.Add(new Binding("Texts", dtg_TB.DataSource, "gia", true, DataSourceUpdateMode.Never));
        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemTb f = new ThemTb();
            f.ShowDialog();
            LoadThietBiList();

        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            if (dtg_TB.SelectedRows.Count > 0)
            {
                currentb = tbBUS.getEquipmentByID(dtg_TB.SelectedRows[0].Cells["matb"].Value.ToString());
                SuaTb f = new SuaTb(currentb);
                f.ShowDialog();
                LoadThietBiList();
            }
            else
                MessageBox.Show("Chọn một thiết bị để sửa");
            
        }

        private void ThietBiSearch_Enter(object sender, EventArgs e)
        {
            if (tb_Search.Text == "Search...")
            {
                tb_Search.Text = "";
                tb_Search.ForeColor = Color.Black;
            }
        }

        private void ThietBiSearch_Leave(object sender, EventArgs e)
        {
            if (tb_Search.Text == "")
            {
                tb_Search.Text = "Search...";
                tb_Search.ForeColor = Color.Gray;
            }
        } 
        //emyeuanh hehehe :> ta la hacker mu den day ta da xam nhap chiec may tinh nay neu muon duoc go hack hay chuoc bang 500 ty 

        List<THIETBI> SearchThietBiByName(string tenthietbi)
        {
            List<THIETBI> listtb = tbBUS.SearchThietBiByName(tenthietbi);

            return listtb;
        }

        private void bt_search_Click(object sender, EventArgs e)
        {
            tblist.DataSource = SearchThietBiByName(tb_Search.Texts);
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtg_TB.SelectedRows.Count > 0)
                {
                    if (tbBUS.deleteEquipment(dtg_TB.SelectedRows[0].Cells["matb"].Value.ToString()))
                    {
                        MessageBox.Show("Đã xóa thành công");
                        this.Show();
                        LoadThietBiList();
                    }
                }
                else
                    MessageBox.Show("Chọn một thiết bị để xóa");


            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Xóa THẤT BẠI!");
            }
        }
    }
}
