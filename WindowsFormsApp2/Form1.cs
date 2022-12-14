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
using Dapper;

namespace WindowsFormsApp2
{
    public enum MerchntType
    {
        None,
        RT,
        SUPPLIER,
        PART
    }
    public partial class Form1 : Form
    {
        private static string _conn = ConfigurationManager.ConnectionStrings["DbConn"].ConnectionString;
        private MerchntType _merchntType;
        List<TextBox> textboxs = new List<TextBox>();

        public Form1()
        {
            InitializeComponent();

            textboxs.Add(textBox1);
            textboxs.Add(textBox2);
            textboxs.Add(textBox3);
            textboxs.Add(textBox4);
            textboxs.Add(textBox5);
            textboxs.Add(textBox6);
            textboxs.Add(textBox7);
            textboxs.Add(textBox8);
            textboxs.Add(textBox9);
            textboxs.Add(textBox10);
            textboxs.Add(textBox11);
            textboxs.Add(textBox12);
            textboxs.Add(textBox13);

            foreach (var textBox in textboxs)
            {
                textBox.KeyPress += textBox_KeyPress;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string password = textBox1.Text;
            string sql = @"SELECT * FROM DBO.RT_BASE";

            //int,double,floar...
            //stack/heap

            //建立SqlConnection物件
            var list = SqlExecuteReader1("", sql);
            datagv1.DataSource = list;
            _merchntType = MerchntType.RT;
            //SqlDataAdapter(password, sql);
        }
        private List<DataModel1> SqlExecuteReader1(string parameter, string sql)
        {
            DynamicParameters Parameters = new DynamicParameters();
            Parameters.Add("RT_NO", parameter, DbType.AnsiString);

            using (var conn = new SqlConnection(_conn))
            {
                conn.Open();
                return conn.Query<DataModel1>(sql, Parameters).ToList();
            }
        }
        private void Delete_RT()
        {
            foreach (DataGridViewRow row in datagv1.Rows)
            {
                if (row.Cells["chb1"].Value != null &&
                    (bool)row.Cells["chb1"].Value == true)
                {
                    MessageBox.Show("已刪除" + row.Cells["RT_NO"].Value.ToString());
                    delYES2($"{ row.Cells["RT_NO"].Value}");
                }
            }

            string sql = @"SELECT * FROM DBO.RT_BASE";
            var list = SqlExecuteReader1("", sql);
            datagv1.DataSource = list;
            //dataGridView1.Rows
        }
        public void delYES2(string INDEX2)
        {
            string sql = @"DELETE FROM DBO.RT_BASE WHERE RT_NO=@RT_NO";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("RT_NO", INDEX2, DbType.AnsiString);

            using (var conn = new SqlConnection(_conn))
            {
                //打開與資料庫的連接
                conn.Open();
                conn.Execute(sql, parameters);
            }
        }
        public class DataModel1
        {
            public string RT_NO { get; set; }
            public string SUPPLIER_CODE { get; set; }
            public string EMP { get; set; }
            public string UPDATE_TIME { get; set; }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //string password = textBox1.Text;
            string sql = @"SELECT * FROM DBO.RT_DETAIL";

            //int,double,floar...
            //stack/heap

            //建立SqlConnection物件
            var list = SqlExecuteReader3("", sql);
            datagv1.DataSource = list;
            _merchntType = MerchntType.SUPPLIER;
            //SqlDataAdapter(password, sql);
        }
        private List<DataModel3> SqlExecuteReader3(string parameter, string sql)
        {
            DynamicParameters Parameters = new DynamicParameters();
            Parameters.Add("RT_NO", parameter, DbType.AnsiString);

            using (var conn = new SqlConnection(_conn))
            {
                conn.Open();
                return conn.Query<DataModel3>(sql, Parameters).ToList();
            }
        }
        private void Delete_SUPPLIER()
        {
            foreach (DataGridViewRow row in datagv1.Rows)
            {
                if (row.Cells["chb1"].Value != null &&
                    (bool)row.Cells["chb1"].Value == true)
                {
                    MessageBox.Show("已刪除" + row.Cells["RT_NO"].Value.ToString());
                    delYES4($"{ row.Cells["RT_NO"].Value}");
                }
            }
            string sql = @"SELECT * FROM DBO.RT_DETAIL";
            var list = SqlExecuteReader3("", sql);
            datagv1.DataSource = list;
            //dataGridView1.Rows
        }
        public void delYES4(string INDEX4)
        {
            string sql = @"DELETE  DBO.RT_DETAIL WHERE RT_NO=@RT_NO";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("RT_NO", INDEX4, DbType.AnsiString);

            using (var conn = new SqlConnection(_conn))
            {
                //打開與資料庫的連接
                conn.Open();
                conn.Execute(sql, parameters);
            }
        }
        public class DataModel3
        {
            public string RT_NO { get; set; }
            public string ITEM_NO { get; set; }
            public string PART_NO { get; set; }
            public string ITEM_QTY { get; set; }
            public string DATECODE { get; set; }
            public string LOTCODE { get; set; }
            public string PO_NO { get; set; }
            public string PO_ITEM { get; set; }
            public string INCOMING_TIME { get; set; }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //string password = textBox1.Text;
            string sql = @"SELECT *FROM DBO.PART_LNK";

            //int,double,floar...
            //stack/heap

            //建立SqlConnection物件
            var list = SqlExecuteReader5("", sql);
            datagv1.DataSource = list;
            _merchntType = MerchntType.PART;

            //SqlDataAdapter(password, sql);
        }
        private List<DataModel5> SqlExecuteReader5(string parameter, string sql)
        {
            DynamicParameters Parameters = new DynamicParameters();
            Parameters.Add("RT_NO", parameter, DbType.AnsiString);

            using (var conn = new SqlConnection(_conn))
            {
                conn.Open();
                return conn.Query<DataModel5>(sql, Parameters).ToList();
            }
        }
        private void Delete_PART()
        {
            foreach (DataGridViewRow row in datagv1.Rows)
            {
                if (row.Cells["chb1"].Value != null &&
                    (bool)row.Cells["chb1"].Value == true)
                {
                    MessageBox.Show("已刪除" + row.Cells["SELF_SN"].Value.ToString());
                    delYES6($"{ row.Cells["SELF_SN"].Value}");
                }
            }
            string sql = @"SELECT *FROM DBO.PART_LNK";
            var list = SqlExecuteReader5("", sql);
            datagv1.DataSource = list;
            //dataGridView1.Rows
        }
        public void delYES6(string INDEX6)
        {
            string sql = @"DELETE DBO.PART_LNK WHERE SELF_SN=@SELF_SN";

            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("SELF_SN", INDEX6, DbType.AnsiString);

            using (var conn = new SqlConnection(_conn))
            {
                //打開與資料庫的連接
                conn.Open();
                conn.Execute(sql, parameters);
            }
        }
        public class DataModel5
        {
            public string SELF_SN { get; set; }
            public string RT_NO { get; set; }
            public string SUPPLER_CODE { get; set; }
            public string INCOMING_TIME { get; set; }
            public string PART_NO { get; set; }
            public string INTCOMING_QTY { get; set; }
            public string UPDATE_TIME { get; set; }
            public string EMP { get; set; }
            public string ITEM_NO { get; set; }
            public string DATECODE { get; set; }
            public string LOTCODE { get; set; }
            public string ISSUE_NO { get; set; }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            string VAL1 = textBox1.Text;             //RT_NO
            string VAL2 = textBox2.Text;             //SUPPLIER_CODE
            string VAL3 = textBox3.Text;             //EMP
            DateTime VALA = DateTime.Now.Date;            //UPDATE_TIME 
            string VAL4 = textBox4.Text;             //ITEM_NO
            string VAL5 = textBox5.Text;             //PART_NO
            string VAL6 = textBox6.Text;             //ITEM_QTY
            string VAL7 = textBox7.Text;             //DATECODE
            string VAL8 = textBox8.Text;             //LOTCODE
            string VAL9 = textBox9.Text;             //PO_NO
            string VAL10 = textBox10.Text;           //PO_ITEM
            DateTime VALB = DateTime.Now.Date;             //INCOMING_TIME
            string VAL11 = textBox11.Text;           //SELF_SN
            DateTime VALC = DateTime.Now.Date;             //INCOMING_TIME
            string VAL12 = textBox12.Text;           //INCOMING_QTY
            DateTime VALD = DateTime.Now.Date;             //UPDATE_TIME
            string VAL13 = textBox13.Text;           //ISSUE_NO


            MessageBox.Show("新增成功");

            AddDate(VAL1, VAL2, VAL3, VALA
                    , VAL4, VAL5, VAL6, VAL7, VAL8, VAL9, VAL10, VALB
                    , VAL11, VALC
                    , VAL12, VALD
                    , VAL13
                    );

            string sql = @"SELECT *FROM DBO.RT_BASE";
            var list = SqlExecuteReader1("", sql);
            datagv1.DataSource = list;
        }
        //新增
        public void AddDate
            (
             string RT_NO, string SUPPLIER_CODE, string EMP, DateTime UPDATE_TIME
            , string ITEM_NO
            , string PART_NO, string ITEM_QTY, string DATECODE, string LOTCODE
            , string PO_NO, string PO_ITEM, DateTime INCOMING_TIME
            , string SELF_SN, DateTime INCOMING_TIMEB
            , string INCOMING_QTY, DateTime UPDATE_TIMEB
            , string ISSUE_NO
            )

        {
            string sql =
             @"insert into [dbo].[RT_BASE]
                          ([RT_NO]
                          ,[SUPPLIER_CODE]
                          ,[EMP]
                          ,[UPDATE_TIME])                                                   
                     values(@RT_NO
                          ,@SUPPLIER_CODE
                          ,@EMP
                          ,@UPDATE_TIME);

                 insert into [dbo].[RT_DETAIL]
                         ([RT_NO]
                         ,[ITEM_NO]
                         ,[PART_NO]
                         ,[ITEM_QTY]
                         ,[DATECODE]
                         ,[LOTCODE]
                         ,[PO_NO]
                         ,[PO_ITEM]
                         ,[INCOMING_TIME])
                     values(@RT_NO
                          , @ITEM_NO
                          , @PART_NO
                          , @ITEM_QTY
                          , @DATECODE
                          , @LOTCODE
                          , @PO_NO
                          , @PO_ITEM
                          , @INCOMING_TIME);

                insert into[dbo].[PART_LNK]
                         ([SELF_SN]
                         ,[RT_NO]
                         ,[SUPPLER_CODE]
                         ,[INCOMING_TIME]
                         ,[PART_NO]
                         ,[INTCOMING_QTY]
                         ,[UPDATE_TIME]
                         ,[EMP]
                         ,[ITEM_NO]
                         ,[DATECODE]
                         ,[LOTCODE]
                         ,[ISSUE_NO])
                     values(@SELF_SN
                          , @RT_NO
                          , @SUPPLIER_CODE
                          , @INCOMING_TIME
                          , @PART_NO
                          , @INCOMING_QTY
                          , @UPDATE_TIME
                          , @EMP
                          , @ITEM_NO
                          , @DATECODE
                          , @LOTCODE
                          , @ISSUE_NO);
              ";
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@RT_NO", RT_NO, DbType.AnsiString);
            parameters.Add("@SUPPLIER_CODE", SUPPLIER_CODE, DbType.AnsiString);
            parameters.Add("@EMP", EMP, DbType.AnsiString);
            parameters.Add("@UPDATE_TIME", UPDATE_TIME, DbType.DateTime);
            parameters.Add("@ITEM_NO", ITEM_NO, DbType.AnsiString);
            parameters.Add("@PART_NO", PART_NO, DbType.AnsiString);
            parameters.Add("@ITEM_QTY", ITEM_QTY, DbType.AnsiString);
            parameters.Add("@DATECODE", DATECODE, DbType.AnsiString);
            parameters.Add("@LOTCODE", LOTCODE, DbType.AnsiString);
            parameters.Add("@PO_NO", PO_NO, DbType.AnsiString);
            parameters.Add("@PO_ITEM", PO_ITEM, DbType.AnsiString);
            parameters.Add("@INCOMING_TIME", INCOMING_TIME, DbType.DateTime);
            parameters.Add("@SELF_SN", SELF_SN, DbType.AnsiString);
            parameters.Add("@INCOMING_TIME", INCOMING_TIME, DbType.DateTime);
            parameters.Add("@INCOMING_QTY", INCOMING_QTY, DbType.AnsiString);
            parameters.Add("@UPDATE_TIME", UPDATE_TIME, DbType.DateTime);
            parameters.Add("@ISSUE_NO", ISSUE_NO, DbType.AnsiString);

            using (var conn = new SqlConnection(_conn))
            {
                conn.Open();
                conn.Execute(sql, parameters);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            foreach (var textBox in textboxs)
            {
                textBox.Clear();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (FormContext.Current.UserContent.RoleType == RoleType.User)
            {
                MessageBox.Show("權限不足");
                return;
            }

            if (_merchntType == MerchntType.RT)
            {
                Delete_RT();
            }
            else if (_merchntType == MerchntType.SUPPLIER)
            {
                Delete_SUPPLIER();
            }
            else if (_merchntType == MerchntType.PART)
            {
                Delete_PART();
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            FormContext.Current.Logout();
        }
    }
}
//using (var conn = new SqlConnection(_conn))
//{
//    //打開與資料庫的連接
//    conn.Open();

//    //建立Sql的命令類別
//    using (SqlCommand cmd = conn.CreateCommand())
//    {
//        cmd.CommandText = sql;
//        //預設是 CommandType.Text
//        cmd.CommandType = CommandType.Text;

//        //如果有使用到參數 添加參數
//        var para = new SqlParameter(
//            "@emp", SqlDbType.VarChar, 50)
//        {
//            Value = parameter
//        };

//        //var para1 = new SqlParameter(
//        //   "@test", SqlDbType.VarChar, 50)
//        //{
//        //    Value = parameter
//        //};

//        cmd.Parameters.Add(para);

//        //cmd.Parameters.Add(para1);
//        List<DataModel1> list = new List<DataModel1>();
//        //從料庫中讀取資料
//        using (var dr = cmd.ExecuteReader())
//        {

//            //判斷是否還有下一筆資料
//            while (dr.Read())
//            {
//                list.Add(new DataModel1()
//                {
//                    RT_NO = dr["RT_NO"].ToString(),
//                    SUPPLIER_CODE = dr["SUPPLIER_CODE"].ToString(),
//                    EMP = dr["EMP"].ToString(),
//                    UPDATE_TIME = dr["UPDATE_TIME"].ToString()
//                });
//                //user_Result.Text += $"{dr["RT_NO"]} {dr["SUPPLIER_CODE"]} {dr["EMP"]} {dr["UPDATE_TIME"]}\r\n\t";
//                //user_Result.Text = user_Result.Text + $"{dr["RT_NO"]} {dr["SUPPLIER_CODE"]} {dr["EMP"]} {dr["UPDATE_TIME"]}\r\n\t";
//                //Console.WriteLine($"{dr["UserId"]} {dr["UserName"]} {dr["PassWord"]}");
//                //list.Add($"{dr["RT_NO"]} {dr["SUPPLIER_CODE"]} {dr["EMP"]} {dr["UPDATE_TIME"]}");
//            }
//        }
//        return list;
//        //user_Result1.Text = String.Join("\n", list);
//    }
//}

//using (var conn = new SqlConnection(_conn))
//{
//    //打開與資料庫的連接
//    conn.Open();

//    //建立Sql的命令類別
//    using (SqlCommand cmd = conn.CreateCommand())
//    {
//        cmd.CommandText = sql;
//        //預設是 CommandType.Text
//        cmd.CommandType = CommandType.Text;

//        //如果有使用到參數 添加參數
//        var para = new SqlParameter(
//            "@emp", SqlDbType.VarChar, 50)
//        {
//            Value = parameter
//        };

//        //var para1 = new SqlParameter(
//        //   "@test", SqlDbType.VarChar, 50)
//        //{
//        //    Value = parameter
//        //};

//        cmd.Parameters.Add(para);

//        //cmd.Parameters.Add(para1);
//        List<DataModel3> list = new List<DataModel3>();
//        //從料庫中讀取資料
//        using (var dr = cmd.ExecuteReader())
//        {

//            //判斷是否還有下一筆資料
//            while (dr.Read())
//            {
//                list.Add(new DataModel3()
//                {
//                    RT_NO = dr["RT_NO"].ToString(),
//                    ITEM_NO = dr["ITEM_NO"].ToString(),
//                    PART_NO = dr["PART_NO"].ToString(),
//                    ITEM_QTY = dr["ITEM_QTY"].ToString(),
//                    DATECODE = dr["DATECODE"].ToString(),
//                    LOTCODE = dr["LOTCODE"].ToString(),
//                    PO_NO = dr["PO_NO"].ToString(),
//                    PO_ITEM = dr["PO_ITEM"].ToString(),
//                    INCOMING_TIME = dr["INCOMING_TIME"].ToString()
//                });
//                //user_Result.Text += $"{dr["RT_NO"]} {dr["SUPPLIER_CODE"]} {dr["EMP"]} {dr["UPDATE_TIME"]}\r\n\t";
//                //user_Result.Text = user_Result.Text + $"{dr["RT_NO"]} {dr["SUPPLIER_CODE"]} {dr["EMP"]} {dr["UPDATE_TIME"]}\r\n\t";
//                //Console.WriteLine($"{dr["UserId"]} {dr["UserName"]} {dr["PassWord"]}");
//                //list.Add($"{dr["RT_NO"]} {dr["INEM_NO"]} {dr["PART_NO"]} {dr["INEM_QTY"]} " +
//                //    $"{dr["DATECODE"]} {dr["LOTCODE"]} {dr["PO_NO"]} {dr["PO_ITEM"]} {dr["INCOMING_TIME"]}");
//            }
//        }
//        return list;
//        //user_Result1.Text = String.Join("\n", list);
//    }
//}
//using (var conn = new SqlConnection(_conn))
//{
//    //打開與資料庫的連接
//    conn.Open();

//    //建立Sql的命令類別
//    using (SqlCommand cmd = conn.CreateCommand())
//    {
//        cmd.CommandText = sql;
//        //預設是 CommandType.Text
//        cmd.CommandType = CommandType.Text;

//        //如果有使用到參數 添加參數
//        var para = new SqlParameter(
//            "@emp", SqlDbType.VarChar, 50)
//        {
//            Value = parameter
//        };

//        //var para1 = new SqlParameter(
//        //   "@test", SqlDbType.VarChar, 50)
//        //{
//        //    Value = parameter
//        //};

//        cmd.Parameters.Add(para);

//        //cmd.Parameters.Add(para1);
//        List<DataModel5> list = new List<DataModel5>();
//        //從料庫中讀取資料
//        using (var dr = cmd.ExecuteReader())
//        {

//            //判斷是否還有下一筆資料
//            while (dr.Read())
//            {
//                list.Add(new DataModel5()
//                {
//                    SELF_SN = dr["SELF_SN"].ToString(),
//                    RT_NO = dr["RT_NO"].ToString(),
//                    SUPPLER_CODE = dr["SUPPLER_CODE"].ToString(),
//                    INCOMING_TIME = dr["INCOMING_TIME"].ToString(),
//                    PART_NO = dr["PART_NO"].ToString(),
//                    INTCOMING_QTY = dr["INTCOMING_QTY"].ToString(),
//                    UPDATE_TIME = dr["UPDATE_TIME"].ToString(),
//                    EMP = dr["EMP"].ToString(),
//                    ITEM_NO = dr["ITEM_NO"].ToString(),
//                    DATECODE = dr["DATECODE"].ToString(),
//                    LOTCODE = dr["LOTCODE"].ToString(),
//                    ISSUE_NO = dr["ISSUE_NO"].ToString()
//                });
//                //user_Result.Text += $"{dr["RT_NO"]} {dr["SUPPLIER_CODE"]} {dr["EMP"]} {dr["UPDATE_TIME"]}\r\n\t";
//                //user_Result.Text = user_Result.Text + $"{dr["RT_NO"]} {dr["SUPPLIER_CODE"]} {dr["EMP"]} {dr["UPDATE_TIME"]}\r\n\t";
//                //Console.WriteLine($"{dr["UserId"]} {dr["UserName"]} {dr["PassWord"]}");
//                //list.Add($"{dr["SELF_SN"]} {dr["RT_NO"]} {dr["SUPPLER_CODE"]} {dr["INCOMING_TIME"]} " +
//                //    $"{dr["PART_NO"]} {dr["INTCOMING_QTY"]} {dr["UPDATE_TIME"]} {dr["EMP"]} {dr["ITEM_NO"]}" +
//                //    $"{dr["DATECODE"]} {dr["LOTCODE"]} {dr["ISSUE_NO"]}");
//            }
//        }
//        return list;
//        //user_Result1.Text = String.Join("\n", list);
//    }
//}