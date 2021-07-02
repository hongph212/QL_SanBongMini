using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace QLSANBONG
{
    public partial class Form1 : Form
    {
        XuLy dt = new XuLy();
        DataTable dtb = new DataTable();

        public Form1()
        {
            InitializeComponent();
            dtb.Columns.Add("LDQH");
            dtb.Columns.Add("TT");
            dtb.Columns.Add("PTH");
            dtb.Columns.Add("Khoa");
        }

        private void btn_ThemTT_Click(object sender, EventArgs e)
        {
            string s = "";
            string[] tt = txtTT.Text.Split(',');
            foreach (string item in tt)
            {
                dt.ThemTT(dt.thuoctinh, item);
            }
            DataRow row = dtb.NewRow();
            foreach (string item in dt.thuoctinh)
            {
                if (s == "")
                {
                    s = item;
                }
                else
                {
                    s = s + "," + item;
                }
            }
            try
            {
                dtb.Rows[0]["TT"] = s;
            }
            catch
            {
                row["LDQH"] = "QLSANBONG";
                row["TT"] = s;
                dtb.Rows.Add(row);
            }
            grid_Chinh.DataSource = dtb;

        }

        private void btn_ThemPTH_Click(object sender, EventArgs e)
        {
            string s = "";
            string[] tt = txtPTH.Text.Split(';');
            foreach (string item in tt)
            {
                dt.ThemPTH(dt.PTH, item);
            }
            foreach (string item in dt.PTH)
            {
                if (s == "")
                {
                    s = item;
                }
                else
                {
                    s = s + ";" + item;
                }
            }
            try
            {
                dtb.Rows[0]["PTH"] = s;
                grid_Chinh.DataSource = dtb;
            }
            catch
            {
            }
        }

        private void btn_TimKhoa_Click(object sender, EventArgs e)
        {
            
            dt.SieuKhoa();
            dt.Khoa();
            string s = "";
            foreach (string item in dt.K)
            {
                if (s == "")
                {
                    s = item;
                }
                else
                {
                    s = s + ";" + item;
                }
            }
            try
            {
                dtb.Rows[0]["Khoa"] = s;
                grid_Chinh.DataSource = dtb;
            }
            catch
            {
            }
        }

        private void btn_C2_Click(object sender, EventArgs e)
        {
            dt.Chuan2();
            grid_Chinh.DataSource = dt.dtb2;
        }

        private void btn_C3_Click(object sender, EventArgs e)
        {
            dt.Chuan3();
            grid_Chinh.DataSource = dt.dtb3;
        }

        private void btn_CBC_Click(object sender, EventArgs e)
        {
            dt.ChuanBC();
            grid_Chinh.DataSource = dt.dtbBC;
        }
    }
}
