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

    public partial class LoginIn : Form
    {
        //private Form1 f = new Form1();
        private static string _conn = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;
        List<TextBox> textboxs = new List<TextBox>();
        public LoginIn()
        {
            InitializeComponent();
            textboxs.Add(txt_username);
            textboxs.Add(txt_pwd);

            foreach (var textBox in textboxs)
            {
                textBox.KeyPress += textBox_KeyPress;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //THread 執行緒

            //string password = textBox1.Text;
            string sql = @"SELECT * FROM LoginInUser WHERE UserName = @UserName AND [PassWord] = @PassWord";

            using (var conn = new SqlConnection(_conn))
            {
                DynamicParameters para = new DynamicParameters();
                para.Add("@UserName", txt_username.Text, DbType.AnsiString, size:50) ;
                para.Add("@PassWord", txt_pwd.Text, DbType.AnsiString, size: 50);
                conn.Open();
                var usermdoel=conn.QueryFirstOrDefault<UserLoginModel>(sql, para);
                if (usermdoel != null)
                {
                    MessageBox.Show("登入成功");
                    FormContext.Current.FormView.Visible = true;
                    FormContext.Current.UserContent = usermdoel;
                    //f.Visible=true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("登入失敗");
                    FormContext.Current.UserContent = null;
                }
            }
        }
        private void LoginIn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);
            }
        }
    }
}
