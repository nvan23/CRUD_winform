using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLclass
{
    public partial class ThemHocPhan : Form
    {
        public static int Saved = 0;
        public ThemHocPhan()
        {
            InitializeComponent();
        }

        private void ThemHocPhan_Load(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("Select * from Course_State", clsDatabase.con);
                SqlDataReader dr = com.ExecuteReader();

                //Create Data Table To Show All Member Values At Commbo Box
                DataTable dt = new DataTable();
                //State_Id and State_name are two rows in Course_State table
                DataColumn dc_state_id = new DataColumn("State_Id");
                DataColumn dc_state_name = new DataColumn("State_name");
                dt.Columns.Add(dc_state_id);
                dt.Columns.Add(dc_state_name);

                while (dr.Read())
                {
                    dt.Rows.Add(Convert.ToInt32(dr[0]), dr[1].ToString());
                }

                //Get Data To Show All Member Values At Commbo Box
                cboTrangThaiHocPhan.DataSource = dt;
                cboTrangThaiHocPhan.ValueMember = "State_Id";
                cboTrangThaiHocPhan.DisplayMember = "State_name";

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void refesh()
        {
            txtMaLopHoc.Clear();
            txtTenLopHoc.Clear();
            txtGiaHocPhan.Clear();
            cboTrangThaiHocPhan.SelectedIndex = -1;
            dtpStartDay.Value = DateTime.Now;
            checkCo.Checked = false;
            checkKhong.Checked = false;
        }

        private void btnNewHocPham_Click(object sender, EventArgs e)
        {
            refesh();
        }

        private void btnLuuHocPhan_Click(object sender, EventArgs e)
        {
            try
            {
                //@Course_Id ... @Course_Create_At are all rows at Course Table
                string strInsert = "Insert into Course values(@Course_Id, @Course_name, @Is_Base_Course, @State_Id, @Course_Price,@Course_Start_Day)";
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand(strInsert, clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@Course_Id", SqlDbType.Char);
                p1.Value = txtMaLopHoc.Text.Trim();
                SqlParameter p2 = new SqlParameter("@Course_name", SqlDbType.NVarChar);
                p2.Value = txtTenLopHoc.Text.Trim();
                SqlParameter p3 = new SqlParameter("@Is_Base_Course", SqlDbType.Bit);
                if (checkCo.Checked)
                {
                    p3.Value = true;
                }
                else if (checkKhong.Checked)
                {
                    p3.Value = false;
                }
                SqlParameter p4 = new SqlParameter("@State_Id", SqlDbType.Int);
                p4.Value = cboTrangThaiHocPhan.SelectedValue;
                SqlParameter p5 = new SqlParameter("@Course_Price", SqlDbType.Int);
                p5.Value = txtGiaHocPhan.Text.Trim();
                SqlParameter p6 = new SqlParameter("@Course_Start_Day", SqlDbType.DateTime);
                p6.Value = dtpStartDay.Value.ToShortDateString();

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.Parameters.Add(p6);
                com.ExecuteNonQuery();

                MessageBox.Show("Creating Course Successfully!!!");
                clsDatabase.CloseConnection();
                Saved = 1;
                refesh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
