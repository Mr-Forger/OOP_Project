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
    public partial class DeleteForm : Form
    {
        private string selectedName;

        public DeleteForm()
        {
            InitializeComponent();
        }

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        private void DeleteForm_Load(object sender, EventArgs e)
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
                
                tb_phone.Text = string.Empty;
                tb_email.Text = string.Empty;
                tb_birth.Text = string.Empty;
                tb_workingHours.Text = string.Empty; // 이름에 해당되는게 없으면 다 비운다
            }

            reader.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("근무자를 삭제하시겠습니까?", "삭제 확인", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                cmd.CommandText = "DELETE FROM worker WHERE name = @name";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", selectedName);
                cmd.ExecuteNonQuery();

                MessageBox.Show("근무자가 삭제되었습니다.");
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
