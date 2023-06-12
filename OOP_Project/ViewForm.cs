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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
        }

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        private void ViewForm_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=projectDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            list_member.View = View.Details;
            list_member.GridLines = true;
            int listWidth = list_member.Width;
            list_member.Columns.Add("이름", (int)(listWidth * 0.1));
            list_member.Columns.Add("전화번호", (int)(listWidth * 0.2));
            list_member.Columns.Add("이메일", (int)(listWidth * 0.2));
            list_member.Columns.Add("생년월일", (int)(listWidth * 0.15));
            list_member.Columns.Add("근무시간", (int)(listWidth * 0.1));
            list_member.Columns.Add("급여", (int)(listWidth * 0.1));
            list_member.Columns.Add("근무횟수", (int)(listWidth * 0.1));


            
            ListUpdate();

        }


        private void ViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Close();
        }

        private void btn_gowork_Click(object sender, EventArgs e)
        {
            if (list_member.SelectedItems.Count > 0)
            {
                string selectedName = list_member.SelectedItems[0].SubItems[0].Text;
                int selectedCount = int.Parse(list_member.SelectedItems[0].SubItems[6].Text);

                selectedCount++;

                cmd.CommandText = "UPDATE worker SET count = @count WHERE name = @name";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@count", selectedCount);
                cmd.Parameters.AddWithValue("@name", selectedName);
                cmd.ExecuteNonQuery();

                //창 업데이트
                ListUpdate();
            }
        }

        private void ListUpdate() //기존 코드를 함수로 따로 뺌
        {
            cmd.CommandText = "SELECT name, phone, email, CONVERT(varchar, birth, 23) AS birth, workingHours, (workingHours * 9620) AS pay, count FROM worker";
            SqlDataReader reader = cmd.ExecuteReader();

            list_member.Items.Clear();
            ListViewItem item;
            while (reader.Read())
            {
                string name = reader.GetString(0);
                string phone = reader.GetString(1);
                string email = reader.GetString(2);
                string birth = reader.GetString(3);
                string workingHours = reader.GetInt32(4).ToString();
                string pay = reader.GetInt32(5).ToString();
                string count = reader.GetInt32(6).ToString();


                item = new ListViewItem(name);
                item.SubItems.Add(phone);
                item.SubItems.Add(email);
                item.SubItems.Add(birth);
                item.SubItems.Add(workingHours);
                item.SubItems.Add(pay);
                item.SubItems.Add(count);

                list_member.Items.Add(item);
            }
            reader.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
            cmd.CommandText = "UPDATE worker SET count = 0"; //테이블상의 모든 count를 0으로 변경
            cmd.ExecuteNonQuery();

            // list_member를 업데이트
            ListUpdate();
        }



        private void btn_calc_Click(object sender, EventArgs e)
        {
            if (list_member.SelectedItems.Count > 0)
            {
                string selectedName = list_member.SelectedItems[0].SubItems[0].Text;

                // CalcForm으로 이동하면서 선택된 근무자의 이름을 전달합니다.
                CalcForm calcForm = new CalcForm(selectedName);
                calcForm.Show();
            }
        }




    }
}

