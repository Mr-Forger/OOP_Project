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
    public partial class InsertForm : Form
    {
        public InsertForm()
        {
            InitializeComponent();
        }

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;

        private void InsertForm_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=projectDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string phone = tb_phone.Text;
            string email = tb_email.Text;
            string birth = tb_birth.Text;
            int workingHours = Convert.ToInt32(tb_workingHours.Text);

            
            cmd.CommandText = "INSERT INTO worker (name, phone, email, birth, workingHours) VALUES (@name, @phone, @email, @birth, @workingHours)"; //worker 테이블에 추가
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@birth", birth);
            cmd.Parameters.AddWithValue("@workingHours", workingHours);
            cmd.ExecuteNonQuery();

            MessageBox.Show("신규 근무자가 등록되었습니다.");

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
