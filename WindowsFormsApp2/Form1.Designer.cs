namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.I_result = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.user_Result1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.datagv1 = new System.Windows.Forms.DataGridView();
            this.chb1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.button7 = new System.Windows.Forms.Button();
            this.txt_rt_no = new System.Windows.Forms.TextBox();
            this.txt_supplier_code = new System.Windows.Forms.TextBox();
            this.txt_emp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_item_no = new System.Windows.Forms.TextBox();
            this.txt_part_no = new System.Windows.Forms.TextBox();
            this.txt_item_qty = new System.Windows.Forms.TextBox();
            this.txt_datecode = new System.Windows.Forms.TextBox();
            this.txt_lotcode = new System.Windows.Forms.TextBox();
            this.txt_po_no = new System.Windows.Forms.TextBox();
            this.txt_po_item = new System.Windows.Forms.TextBox();
            this.txt_self_sn = new System.Windows.Forms.TextBox();
            this.txt_intcoming_qty = new System.Windows.Forms.TextBox();
            this.txt_issue_no = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.chb_01 = new System.Windows.Forms.ComboBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.storage_txt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.smt_txt = new System.Windows.Forms.TextBox();
            this.backlog_smt = new System.Windows.Forms.Label();
            this.backlog_storage = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagv1)).BeginInit();
            this.SuspendLayout();
            // 
            // I_result
            // 
            this.I_result.AutoEllipsis = true;
            this.I_result.AutoSize = true;
            this.I_result.Location = new System.Drawing.Point(619, 65);
            this.I_result.Name = "I_result";
            this.I_result.Size = new System.Drawing.Size(0, 12);
            this.I_result.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(12, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "廠商明細";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_Result1
            // 
            this.user_Result1.AutoSize = true;
            this.user_Result1.Location = new System.Drawing.Point(1262, 34);
            this.user_Result1.Name = "user_Result1";
            this.user_Result1.Size = new System.Drawing.Size(0, 12);
            this.user_Result1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(141, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "收料單明細";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(295, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 30);
            this.button5.TabIndex = 10;
            this.button5.Text = "倉儲庫存";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // datagv1
            // 
            this.datagv1.BackgroundColor = System.Drawing.Color.Silver;
            this.datagv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chb1});
            this.datagv1.GridColor = System.Drawing.SystemColors.Desktop;
            this.datagv1.Location = new System.Drawing.Point(12, 147);
            this.datagv1.Name = "datagv1";
            this.datagv1.RowTemplate.Height = 24;
            this.datagv1.Size = new System.Drawing.Size(898, 310);
            this.datagv1.TabIndex = 12;
            // 
            // chb1
            // 
            this.chb1.HeaderText = "chb1";
            this.chb1.Name = "chb1";
            this.chb1.Width = 50;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button7.Location = new System.Drawing.Point(598, 111);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 30);
            this.button7.TabIndex = 16;
            this.button7.Text = "新增資料";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txt_rt_no
            // 
            this.txt_rt_no.Location = new System.Drawing.Point(12, 68);
            this.txt_rt_no.Name = "txt_rt_no";
            this.txt_rt_no.Size = new System.Drawing.Size(100, 22);
            this.txt_rt_no.TabIndex = 17;
            // 
            // txt_supplier_code
            // 
            this.txt_supplier_code.Location = new System.Drawing.Point(121, 68);
            this.txt_supplier_code.Name = "txt_supplier_code";
            this.txt_supplier_code.Size = new System.Drawing.Size(100, 22);
            this.txt_supplier_code.TabIndex = 18;
            // 
            // txt_emp
            // 
            this.txt_emp.Location = new System.Drawing.Point(278, 68);
            this.txt_emp.Name = "txt_emp";
            this.txt_emp.Size = new System.Drawing.Size(100, 22);
            this.txt_emp.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "RT_No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(117, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Supplier_Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(274, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Emp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(382, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Item_No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(488, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Part_No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(594, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Item_Qty";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(700, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "DateCode";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(806, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "LotCode";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(117, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Po_Item";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(8, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Po_No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(223, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Self_Sn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(329, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Intcoming_Qty";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(488, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Issue_No";
            // 
            // txt_item_no
            // 
            this.txt_item_no.Location = new System.Drawing.Point(386, 68);
            this.txt_item_no.Name = "txt_item_no";
            this.txt_item_no.Size = new System.Drawing.Size(100, 22);
            this.txt_item_no.TabIndex = 33;
            // 
            // txt_part_no
            // 
            this.txt_part_no.Location = new System.Drawing.Point(492, 68);
            this.txt_part_no.Name = "txt_part_no";
            this.txt_part_no.Size = new System.Drawing.Size(100, 22);
            this.txt_part_no.TabIndex = 34;
            // 
            // txt_item_qty
            // 
            this.txt_item_qty.Location = new System.Drawing.Point(598, 68);
            this.txt_item_qty.Name = "txt_item_qty";
            this.txt_item_qty.Size = new System.Drawing.Size(100, 22);
            this.txt_item_qty.TabIndex = 35;
            // 
            // txt_datecode
            // 
            this.txt_datecode.Location = new System.Drawing.Point(704, 68);
            this.txt_datecode.Name = "txt_datecode";
            this.txt_datecode.Size = new System.Drawing.Size(100, 22);
            this.txt_datecode.TabIndex = 36;
            // 
            // txt_lotcode
            // 
            this.txt_lotcode.Location = new System.Drawing.Point(810, 68);
            this.txt_lotcode.Name = "txt_lotcode";
            this.txt_lotcode.Size = new System.Drawing.Size(100, 22);
            this.txt_lotcode.TabIndex = 37;
            // 
            // txt_po_no
            // 
            this.txt_po_no.Location = new System.Drawing.Point(12, 119);
            this.txt_po_no.Name = "txt_po_no";
            this.txt_po_no.Size = new System.Drawing.Size(100, 22);
            this.txt_po_no.TabIndex = 38;
            // 
            // txt_po_item
            // 
            this.txt_po_item.Location = new System.Drawing.Point(121, 119);
            this.txt_po_item.Name = "txt_po_item";
            this.txt_po_item.Size = new System.Drawing.Size(100, 22);
            this.txt_po_item.TabIndex = 39;
            // 
            // txt_self_sn
            // 
            this.txt_self_sn.Location = new System.Drawing.Point(227, 119);
            this.txt_self_sn.Name = "txt_self_sn";
            this.txt_self_sn.Size = new System.Drawing.Size(100, 22);
            this.txt_self_sn.TabIndex = 40;
            // 
            // txt_intcoming_qty
            // 
            this.txt_intcoming_qty.Location = new System.Drawing.Point(333, 119);
            this.txt_intcoming_qty.Name = "txt_intcoming_qty";
            this.txt_intcoming_qty.Size = new System.Drawing.Size(100, 22);
            this.txt_intcoming_qty.TabIndex = 41;
            // 
            // txt_issue_no
            // 
            this.txt_issue_no.Location = new System.Drawing.Point(492, 119);
            this.txt_issue_no.Name = "txt_issue_no";
            this.txt_issue_no.Size = new System.Drawing.Size(100, 22);
            this.txt_issue_no.TabIndex = 42;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button8.Location = new System.Drawing.Point(724, 111);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(150, 30);
            this.button8.TabIndex = 43;
            this.button8.Text = "清除欄位資訊";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(12, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 30);
            this.button2.TabIndex = 44;
            this.button2.Text = "刪除資料";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(790, 463);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 30);
            this.button4.TabIndex = 45;
            this.button4.Text = "登出";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button6.Location = new System.Drawing.Point(790, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 30);
            this.button6.TabIndex = 46;
            this.button6.Text = "庫存警示";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // chb_01
            // 
            this.chb_01.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chb_01.FormattingEnabled = true;
            this.chb_01.Location = new System.Drawing.Point(675, 12);
            this.chb_01.Name = "chb_01";
            this.chb_01.Size = new System.Drawing.Size(100, 20);
            this.chb_01.TabIndex = 49;
            this.chb_01.SelectedIndexChanged += new System.EventHandler(this.chb_01_SelectedIndexChanged);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button9.Location = new System.Drawing.Point(549, 4);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(120, 30);
            this.button9.TabIndex = 50;
            this.button9.Text = "報表查詢";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button10.Location = new System.Drawing.Point(916, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(120, 30);
            this.button10.TabIndex = 51;
            this.button10.Text = "倉庫發料";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // storage_txt
            // 
            this.storage_txt.Location = new System.Drawing.Point(916, 68);
            this.storage_txt.Name = "storage_txt";
            this.storage_txt.Size = new System.Drawing.Size(100, 22);
            this.storage_txt.TabIndex = 52;
            this.storage_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.storage_txt_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(912, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 20);
            this.label14.TabIndex = 54;
            this.label14.Text = "Storage_SN";
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button11.Location = new System.Drawing.Point(1042, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(120, 30);
            this.button11.TabIndex = 55;
            this.button11.Text = "SMT退料";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("標楷體", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(1038, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 20);
            this.label15.TabIndex = 56;
            this.label15.Text = "Smt_SN";
            // 
            // smt_txt
            // 
            this.smt_txt.Location = new System.Drawing.Point(1042, 68);
            this.smt_txt.Name = "smt_txt";
            this.smt_txt.Size = new System.Drawing.Size(100, 22);
            this.smt_txt.TabIndex = 57;
            this.smt_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.smt_txt_KeyDown);
            // 
            // backlog_smt
            // 
            this.backlog_smt.AutoSize = true;
            this.backlog_smt.Location = new System.Drawing.Point(1040, 103);
            this.backlog_smt.Name = "backlog_smt";
            this.backlog_smt.Size = new System.Drawing.Size(0, 12);
            this.backlog_smt.TabIndex = 58;
            // 
            // backlog_storage
            // 
            this.backlog_storage.AutoSize = true;
            this.backlog_storage.Location = new System.Drawing.Point(916, 103);
            this.backlog_storage.Name = "backlog_storage";
            this.backlog_storage.Size = new System.Drawing.Size(0, 12);
            this.backlog_storage.TabIndex = 59;
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button12.Location = new System.Drawing.Point(423, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(120, 30);
            this.button12.TabIndex = 60;
            this.button12.Text = "SMT庫存";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 504);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.backlog_storage);
            this.Controls.Add(this.backlog_smt);
            this.Controls.Add(this.smt_txt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.storage_txt);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.chb_01);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txt_issue_no);
            this.Controls.Add(this.txt_intcoming_qty);
            this.Controls.Add(this.txt_self_sn);
            this.Controls.Add(this.txt_po_item);
            this.Controls.Add(this.txt_po_no);
            this.Controls.Add(this.txt_lotcode);
            this.Controls.Add(this.txt_datecode);
            this.Controls.Add(this.txt_item_qty);
            this.Controls.Add(this.txt_part_no);
            this.Controls.Add(this.txt_item_no);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_emp);
            this.Controls.Add(this.txt_supplier_code);
            this.Controls.Add(this.txt_rt_no);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.datagv1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.user_Result1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.I_result);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.datagv1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label I_result;
        private System.Windows.Forms.Label user_Result1;
        private System.Windows.Forms.DataGridView datagv1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txt_rt_no;
        private System.Windows.Forms.TextBox txt_supplier_code;
        private System.Windows.Forms.TextBox txt_emp;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_item_no;
        private System.Windows.Forms.TextBox txt_part_no;
        private System.Windows.Forms.TextBox txt_item_qty;
        private System.Windows.Forms.TextBox txt_datecode;
        private System.Windows.Forms.TextBox txt_lotcode;
        private System.Windows.Forms.TextBox txt_po_no;
        private System.Windows.Forms.TextBox txt_po_item;
        private System.Windows.Forms.TextBox txt_self_sn;
        private System.Windows.Forms.TextBox txt_intcoming_qty;
        private System.Windows.Forms.TextBox txt_issue_no;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox chb_01;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox storage_txt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox smt_txt;
        private System.Windows.Forms.Label backlog_smt;
        private System.Windows.Forms.Label backlog_storage;
        private System.Windows.Forms.Button button12;
    }
}

