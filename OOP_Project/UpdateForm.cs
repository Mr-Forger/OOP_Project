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

namespace OOP_Project
{
    public partial class UpdateForm : Form
    {
        private string selectedName;

        public UpdateForm()
        {
            InitializeComponent();
        }

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=projectDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void tb_name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selectedName = tb_name.Text;
                LoadWorkerData();
            }
        }

        private void LoadWorkerData()
        {
            cmd.CommandText = "SELECT phone, email, CONVERT(varchar, birth, 23) AS birth, workingHours FROM worker WHERE name = @name";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", selectedName);
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string phone = reader.GetString(0);
                string email = reader.GetString(1);
                string birth = reader.GetString(2);
                int workingHours = reader.GetInt32(3);

                tb_phone.Text = phone;
                tb_email.Text = email;
                tb_birth.Text = birth;
                tb_workingHours.Text = workingHours.ToString();
            }
            else
            {
                // 이름에 해당하는 정보가 없는 경우 처리
                tb_phone.Text = string.Empty;
                tb_email.Text = string.Empty;
                tb_birth.Text = string.Empty;
                tb_workingHours.Text = string.Empty;
            }

            reader.Close();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string phone = tb_phone.Text;
            string email = tb_email.Text;
            string birth = tb_birth.Text;
            int workingHours = int.Parse(tb_workingHours.Text);

            cmd.CommandText = "UPDATE worker SET phone = @phone, email = @email, birth = @birth, workingHours = @workingHours WHERE name = @name";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@birth", birth);
            cmd.Parameters.AddWithValue("@workingHours", workingHours);
            cmd.Parameters.AddWithValue("@name", selectedName);
            cmd.ExecuteNonQuery();

            MessageBox.Show("회원 정보가 수정되었습니다.");

            // 필요한 추가 작업 수행

            // 현재 폼 닫기
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
