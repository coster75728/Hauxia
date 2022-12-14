using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LoginIn1 : Form
    {
        private static string _conn = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;
        public LoginIn1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string password = textBox1.Text;
            string sql = @"SELECT * FROM LoginInUser WHERE UserName = @UserName AND [PassWord] = @PassWord";

            using (var conn = new SqlConnection(_conn))
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@UserName", txt_username.Text, DbType.AnsiString, size: 50);
                para.Add("@PassWord", txt_pwd.Text, DbType.AnsiString, size: 50);
                conn.Open();
                var usermdoel = conn.QueryFirstOrDefault<UserLoginMode2>(sql, para);
                if (usermdoel != null)
                {
                    MessageBox.Show("登入成功");
                    f.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("登入失敗");
                }
            }
        }
    }
    public class UserLoginMode2
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }
    }
}
