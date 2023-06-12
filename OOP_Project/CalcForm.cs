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
    public partial class CalcForm : Form
    {
        private string selectedName;
        private int workHours;
        private int count;
        private int weekPay;
        private int allowance;
        private int totalPay;

        public CalcForm(string name)
        {
            InitializeComponent();
            selectedName = name;
            tb_name.Text = selectedName;
        }

        string connStr;
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataReader reader;

        private void CalcForm_Load(object sender, EventArgs e)
        {
            connStr = "Server=localhost\\SQLEXPRESS;Database=projectDB;Trusted_Connection=True;";
            conn = new SqlConnection(connStr);
            conn.Open();

            cmd = new SqlCommand();
            cmd.Connection = conn;

            LoadWorkerData();
        }


        private void LoadWorkerData()
        {
            cmd.CommandText = "SELECT workingHours, count, (workingHours * count * 9620) AS weekPay FROM worker WHERE name = @name";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@name", selectedName);
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                workHours = reader.GetInt32(0);
                count = reader.GetInt32(1);
                weekPay = reader.GetInt32(2);
                allowance = CalculateAllowance(workHours, count); // 주휴수당 계산
            }

            reader.Close();

            CalculateTotalPay();
        }

        private int CalculateAllowance(int workHours, int count)
        {
            int regularHours = 40; // 정규 근무시간 8시간 * 5일 = 40시간

            if (count >= 5 && (workHours * count) >= 15) // 주 5회 근무 기준
            {
                int overtimeHours = workHours * count;
                int overtimeAllowance = (int)((overtimeHours / (double)regularHours) * 8 * 9620);
                return overtimeAllowance;
            }
            else
            {
                return 0;
            }
        }


        private void CalculateTotalPay()
        {
            totalPay = weekPay + allowance;
            DisplayCalculatedValues();
        }




        private void DisplayCalculatedValues()
        {
            tb_workhours.Text = workHours.ToString();
            tb_count.Text = count.ToString();
            tb_weekpay.Text = weekPay.ToString();
            tb_allowance.Text = allowance.ToString();
            tb_totalpay.Text = totalPay.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
