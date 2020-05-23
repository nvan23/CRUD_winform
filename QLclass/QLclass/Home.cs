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
    public partial class Home : Form
    {

        public static string Course_Id = "";
        public static string Coure_name = "";
        public static bool Is_Base_Course = false;
        public static int State_Id = 0;
        public static int Course_Price = 0;
        public static DateTime Course_Start_Day;
        public static string get_state_open = "";
        public static string get_state_close = "";

        public Home()
        {
            InitializeComponent();
            if (ThemHocPhan.Saved == 1)
            {
                dgvHocPhan.Columns.Clear();
                dgvHocPhan.Refresh();
            }
        }
        
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void load_data()
        {
            try
            {
                dgvHocPhan.Columns.Clear();
                dgvHocPhan.Refresh();

                clsDatabase.OpenConnection();
                string strSelect = "Select Course_Id as Ma_HP, Course_name as Ten_HP, Is_Base_Course as HP_Tien_Quyet, State_name as Trang_Thai, Course_Price as Hoc_Phi, Course_Start_Day as Start_Day from Course inner join Course_State on Course.State_Id = Course_State.State_Id";
                SqlCommand com = new SqlCommand(strSelect, clsDatabase.con);
                com.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(com);
                da.Fill(dt);
                dgvHocPhan.DataSource = dt;

                //Create button to delete a row
                DataGridViewButtonColumn delete = new DataGridViewButtonColumn();
                delete.Text = "Delete";
                delete.UseColumnTextForButtonValue = true;
                dgvHocPhan.Columns.Add(delete);

                //Create button to update row
                DataGridViewButtonColumn update = new DataGridViewButtonColumn();
                update.Text = "Update";
                update.UseColumnTextForButtonValue = true;
                dgvHocPhan.Columns.Add(update);

                clsDatabase.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            load_data();
            
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            load_data();
        }

        private void dgvHocPhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Get Course_ID
                string _Course_Id = "";
                _Course_Id = dgvHocPhan.SelectedCells[0].Value.ToString();

                if (e.ColumnIndex == 6)
                {
                    //Delete a Course Via Course ID
                    clsDatabase.OpenConnection();
                    string strSelect = "Delete from Course where Course_Id = '" + _Course_Id + "'";
                    SqlCommand com = new SqlCommand(strSelect, clsDatabase.con);
                    com.ExecuteNonQuery();
                    load_data();
                    clsDatabase.CloseConnection();
                    MessageBox.Show("Deleted Successfully Course ID has" + Course_Id);
                }
                else if (e.ColumnIndex == 7)
                {
                    clsDatabase.OpenConnection();
                    string strSelect = "Select * from Course where Course_Id = '" + _Course_Id + "'";
                    SqlCommand com = new SqlCommand(strSelect, clsDatabase.con);
                    com.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(com);
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        Course_Id = dr["Course_Id"].ToString().Trim();
                        Coure_name = dr["Course_name"].ToString();
                        Is_Base_Course = Convert.ToBoolean(dr["Is_Base_Course"]);
                        State_Id = Convert.ToInt32(dr["State_Id"].ToString());
                        Course_Price = Convert.ToInt32(dr["Course_Price"].ToString());
                        Course_Start_Day = Convert.ToDateTime(dr["Course_Start_Day"]);
                    }
                    clsDatabase.CloseConnection();
                    CapNhatHocPhan _CapNhatHocPhan = new CapNhatHocPhan();
                    _CapNhatHocPhan.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void redirect_ThemHocPhan(object sender, EventArgs e)
        {
            ThemHocPhan qllh = new ThemHocPhan();
            qllh.Show();
        }
    }
}
