using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            ViewForm subFrom = new ViewForm();
            subFrom.ShowDialog();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            InsertForm subFrom = new InsertForm();
            subFrom.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UpdateForm subFrom = new UpdateForm();
            subFrom.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DeleteForm subFrom = new DeleteForm();
            subFrom.ShowDialog();
        }
    }
}
