using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace assit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TimeSpan ts = new TimeSpan(-1);
            DTt_work_date.Value = DateTime.Today + ts;
        }

        private void BTcheck_status_Click_Click(object sender, EventArgs e)
        {
            String datetime = DTt_work_date.Value.ToString("yyyy-MM-dd");
            object status = SQLHelper.ExecuteScalar("select c_status from t_ast_batch where t_work_date = ?", new OleDbParameter("@date", datetime));
            TBc_status.Text = Convert.ToString(status, CultureInfo.CurrentCulture);
        }

        private void BTupd_status_Click_Click(object sender, EventArgs e)
        {
            String datetime = DTt_work_date.Value.ToString("yyyy-MM-dd");
            int upd_status = SQLHelper.ExecuteNonQuery("update t_ast_batch set c_status = ? where t_work_date = ?", new OleDbParameter("@status", TBupd_status.Text), new OleDbParameter("@date", datetime));
            if (upd_status > 0)
            {
                MessageBox.Show("更新成功");
            }
            else
            {
                MessageBox.Show("更新失败");
            }
        }

        private void BTdel_status_Click_Click(object sender, EventArgs e)
        {
            String datetime = DTt_work_date.Value.ToString("yyyy-MM-dd");
            int del_status = SQLHelper.ExecuteNonQuery("delete from t_ast_batch where t_work_date = ?", new OleDbParameter("@date", datetime));
            if (del_status > 0)
            {
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }

        private void BTins_status_Click_Click(object sender, EventArgs e)
        {
            String datetime = DTt_work_date.Value.ToString("yyyy-MM-dd");
            //int del_status = SQLHelper.ExecuteNonQuery("insert into t_ast_batch values(@date,'@status')", new OleDbParameter("@date", DTt_work_date.Text), new OleDbParameter("@status", TBupd_status.Text));
            int del_status = SQLHelper.ExecuteNonQuery("insert into t_ast_batch values('" + datetime + "','" + TBupd_status.Text + "')");
            if (del_status > 0)
            {
                MessageBox.Show("新增成功");
            }
            else
            {
                MessageBox.Show("新增失败");
            }
        }
    }
}
