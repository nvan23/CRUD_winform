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
using System.Data.SqlClient;

namespace QLclass
{
    public partial class CapNhatHocPhan : Form
    {
        bool _checked = false;

        public CapNhatHocPhan()
        {
            InitializeComponent();
        }

        public void get_all_states()
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

        public void getCheck()
        {
            try
            {
                if (Home.Is_Base_Course)
                {
                    checkCo.Checked = true;
                }
                else
                {
                    checkKhong.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        public void binding_data()
        {
            try
            {
                txtTenLopHoc.Focus();
                txtMaLopHoc.Text = Home.Course_Id.ToString();
                txtTenLopHoc.Text = Home.Coure_name.ToString();
                txtGiaHocPhan.Text = Home.Course_Price.ToString();
                dtpStartDay.Value = Convert.ToDateTime(Home.Course_Start_Day.ToString());
                get_all_states();
                cboTrangThaiHocPhan.SelectedValue = Home.State_Id;
                getCheck();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                binding_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CapNhatHocPhan_Load(object sender, EventArgs e)
        {
            try
            {
                binding_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLuuHocPhan_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkCo.Checked)
                {
                    _checked = true;
                }
                else if (checkKhong.Checked)
                {
                    _checked = false;
                }
                clsDatabase.OpenConnection();
                string strUpdate = "Update Course set Course_name = '" + txtTenLopHoc.Text + "', Is_Base_Course = '" + _checked + "', State_Id = '" + cboTrangThaiHocPhan.SelectedValue + "', Course_Price = '" + txtGiaHocPhan.Text + "', Course_Start_Day = '"+ dtpStartDay.Value.ToString() +"' where Course_Id = '"+ Home.Course_Id +"'";
                SqlCommand com = new SqlCommand(strUpdate, clsDatabase.con);
                com.ExecuteNonQuery();
                clsDatabase.CloseConnection();
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
