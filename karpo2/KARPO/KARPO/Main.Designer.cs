namespace KARPO
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_inserArea = new System.Windows.Forms.Panel();
            this.btn_sale = new System.Windows.Forms.Button();
            this.txt_last_bill = new System.Windows.Forms.Label();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_bill_NO = new System.Windows.Forms.TextBox();
            this.txt_import_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_expire_date = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_serach_byName = new System.Windows.Forms.TextBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_Type = new System.Windows.Forms.TextBox();
            this.txt_quntity = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.table = new System.Windows.Forms.DataGridView();
            this.lbl_alert = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_date = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_financial = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Expire_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_import_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_inserArea.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_inserArea
            // 
            this.panel_inserArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel_inserArea.Controls.Add(this.btn_sale);
            this.panel_inserArea.Controls.Add(this.txt_last_bill);
            this.panel_inserArea.Controls.Add(this.txt_customer);
            this.panel_inserArea.Controls.Add(this.label11);
            this.panel_inserArea.Controls.Add(this.txt_bill_NO);
            this.panel_inserArea.Controls.Add(this.txt_import_date);
            this.panel_inserArea.Controls.Add(this.label1);
            this.panel_inserArea.Controls.Add(this.txt_expire_date);
            this.panel_inserArea.Controls.Add(this.label10);
            this.panel_inserArea.Controls.Add(this.label9);
            this.panel_inserArea.Controls.Add(this.label8);
            this.panel_inserArea.Controls.Add(this.label7);
            this.panel_inserArea.Controls.Add(this.label3);
            this.panel_inserArea.Controls.Add(this.label6);
            this.panel_inserArea.Controls.Add(this.label5);
            this.panel_inserArea.Controls.Add(this.label4);
            this.panel_inserArea.Controls.Add(this.label2);
            this.panel_inserArea.Controls.Add(this.btn_delete);
            this.panel_inserArea.Controls.Add(this.btn_add);
            this.panel_inserArea.Controls.Add(this.btn_update);
            this.panel_inserArea.Controls.Add(this.btn_clear);
            this.panel_inserArea.Controls.Add(this.txt_serach_byName);
            this.panel_inserArea.Controls.Add(this.txt_price);
            this.panel_inserArea.Controls.Add(this.txt_Type);
            this.panel_inserArea.Controls.Add(this.txt_quntity);
            this.panel_inserArea.Controls.Add(this.txt_name);
            this.panel_inserArea.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_inserArea.Location = new System.Drawing.Point(0, 0);
            this.panel_inserArea.Name = "panel_inserArea";
            this.panel_inserArea.Size = new System.Drawing.Size(281, 749);
            this.panel_inserArea.TabIndex = 0;
            // 
            // btn_sale
            // 
            this.btn_sale.BackColor = System.Drawing.Color.Gray;
            this.btn_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sale.Location = new System.Drawing.Point(144, 646);
            this.btn_sale.Name = "btn_sale";
            this.btn_sale.Size = new System.Drawing.Size(120, 36);
            this.btn_sale.TabIndex = 5;
            this.btn_sale.Text = "Sale";
            this.btn_sale.UseVisualStyleBackColor = false;
            this.btn_sale.Click += new System.EventHandler(this.btn_sale_Click);
            // 
            // txt_last_bill
            // 
            this.txt_last_bill.AutoSize = true;
            this.txt_last_bill.ForeColor = System.Drawing.Color.White;
            this.txt_last_bill.Location = new System.Drawing.Point(81, 656);
            this.txt_last_bill.Name = "txt_last_bill";
            this.txt_last_bill.Size = new System.Drawing.Size(41, 13);
            this.txt_last_bill.TabIndex = 11;
            this.txt_last_bill.Text = "label11";
            // 
            // txt_customer
            // 
            this.txt_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer.Location = new System.Drawing.Point(118, 590);
            this.txt_customer.MinimumSize = new System.Drawing.Size(150, 30);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(150, 30);
            this.txt_customer.TabIndex = 9;
            this.txt_customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_customer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_customer_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(12, 653);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Last Bill:";
            // 
            // txt_bill_NO
            // 
            this.txt_bill_NO.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bill_NO.Location = new System.Drawing.Point(118, 553);
            this.txt_bill_NO.MinimumSize = new System.Drawing.Size(150, 30);
            this.txt_bill_NO.Name = "txt_bill_NO";
            this.txt_bill_NO.Size = new System.Drawing.Size(150, 30);
            this.txt_bill_NO.TabIndex = 9;
            this.txt_bill_NO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_bill_NO.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_bill_NO_KeyUp);
            // 
            // txt_import_date
            // 
            this.txt_import_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_import_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_import_date.Location = new System.Drawing.Point(96, 244);
            this.txt_import_date.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_import_date.Name = "txt_import_date";
            this.txt_import_date.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_import_date.Size = new System.Drawing.Size(167, 30);
            this.txt_import_date.TabIndex = 8;
            this.txt_import_date.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.txt_import_date.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_import_date_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer name";
            // 
            // txt_expire_date
            // 
            this.txt_expire_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_expire_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_expire_date.Location = new System.Drawing.Point(96, 196);
            this.txt_expire_date.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_expire_date.Name = "txt_expire_date";
            this.txt_expire_date.Size = new System.Drawing.Size(167, 30);
            this.txt_expire_date.TabIndex = 8;
            this.txt_expire_date.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.txt_expire_date.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_expire_date_KeyUp);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 558);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Bill Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(8, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Seach By Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Import Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(9, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Expire Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(8, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.FlatAppearance.BorderSize = 0;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(11, 444);
            this.btn_delete.MinimumSize = new System.Drawing.Size(100, 30);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(252, 36);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Delate";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_add.FlatAppearance.BorderSize = 0;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(11, 291);
            this.btn_add.MinimumSize = new System.Drawing.Size(100, 30);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(252, 36);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.Green;
            this.btn_update.FlatAppearance.BorderSize = 0;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(11, 342);
            this.btn_update.MinimumSize = new System.Drawing.Size(100, 30);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(252, 36);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.Yellow;
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(11, 393);
            this.btn_clear.MinimumSize = new System.Drawing.Size(100, 30);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(252, 36);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_serach_byName
            // 
            this.txt_serach_byName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serach_byName.Location = new System.Drawing.Point(118, 504);
            this.txt_serach_byName.MinimumSize = new System.Drawing.Size(150, 30);
            this.txt_serach_byName.Name = "txt_serach_byName";
            this.txt_serach_byName.Size = new System.Drawing.Size(150, 29);
            this.txt_serach_byName.TabIndex = 0;
            this.txt_serach_byName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_serach_byName.TextChanged += new System.EventHandler(this.txt_serach_byName_TextChanged);
            this.txt_serach_byName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_serach_byName_KeyUp);
            // 
            // txt_price
            // 
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(96, 149);
            this.txt_price.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(167, 29);
            this.txt_price.TabIndex = 0;
            this.txt_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_price_KeyUp);
            // 
            // txt_Type
            // 
            this.txt_Type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Type.Location = new System.Drawing.Point(96, 102);
            this.txt_Type.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_Type.Name = "txt_Type";
            this.txt_Type.Size = new System.Drawing.Size(167, 29);
            this.txt_Type.TabIndex = 0;
            this.txt_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Type.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Type_KeyUp);
            // 
            // txt_quntity
            // 
            this.txt_quntity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quntity.Location = new System.Drawing.Point(96, 57);
            this.txt_quntity.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_quntity.Name = "txt_quntity";
            this.txt_quntity.Size = new System.Drawing.Size(167, 29);
            this.txt_quntity.TabIndex = 0;
            this.txt_quntity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quntity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_quntity_KeyUp);
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(96, 11);
            this.txt_name.MinimumSize = new System.Drawing.Size(100, 30);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(167, 29);
            this.txt_name.TabIndex = 0;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_name_KeyUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.flowLayoutPanel1.Controls.Add(this.table);
            this.flowLayoutPanel1.Controls.Add(this.lbl_alert);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(281, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1053, 749);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // table
            // 
            this.table.AllowUserToAddRows = false;
            this.table.AllowUserToDeleteRows = false;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.col_name,
            this.col_quantity,
            this.col_Type,
            this.col_price,
            this.col_Expire_date,
            this.col_import_date});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.table.DefaultCellStyle = dataGridViewCellStyle5;
            this.table.Location = new System.Drawing.Point(3, 3);
            this.table.Name = "table";
            this.table.ReadOnly = true;
            this.table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table.RowTemplate.Height = 32;
            this.table.Size = new System.Drawing.Size(1050, 603);
            this.table.TabIndex = 0;
            this.table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbl_alert
            // 
            this.lbl_alert.AutoSize = true;
            this.lbl_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alert.Location = new System.Drawing.Point(3, 609);
            this.lbl_alert.Name = "lbl_alert";
            this.lbl_alert.Size = new System.Drawing.Size(89, 25);
            this.lbl_alert.TabIndex = 1;
            this.lbl_alert.Text = "-----------";
            this.lbl_alert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.txt_date);
            this.panel1.Controls.Add(this.txt_time);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_financial);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(281, 677);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1053, 72);
            this.panel1.TabIndex = 2;
            // 
            // txt_date
            // 
            this.txt_date.AutoSize = true;
            this.txt_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date.Location = new System.Drawing.Point(694, 23);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(53, 25);
            this.txt_date.TabIndex = 3;
            this.txt_date.Text = "Date";
            // 
            // txt_time
            // 
            this.txt_time.AutoSize = true;
            this.txt_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_time.Location = new System.Drawing.Point(1118, 32);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(56, 25);
            this.txt_time.TabIndex = 2;
            this.txt_time.Text = "Time";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(441, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(207, 41);
            this.button2.TabIndex = 0;
            this.button2.Text = "Quarry";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_financial
            // 
            this.btn_financial.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_financial.Location = new System.Drawing.Point(228, 15);
            this.btn_financial.Name = "btn_financial";
            this.btn_financial.Size = new System.Drawing.Size(207, 41);
            this.btn_financial.TabIndex = 0;
            this.btn_financial.Text = "Finance and vendor";
            this.btn_financial.UseVisualStyleBackColor = true;
            this.btn_financial.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buckup and Restor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 70;
            // 
            // col_name
            // 
            this.col_name.DataPropertyName = "Name";
            this.col_name.HeaderText = "Name";
            this.col_name.Name = "col_name";
            this.col_name.ReadOnly = true;
            this.col_name.Width = 250;
            // 
            // col_quantity
            // 
            this.col_quantity.DataPropertyName = "Quantity";
            this.col_quantity.HeaderText = "Quantity";
            this.col_quantity.Name = "col_quantity";
            this.col_quantity.ReadOnly = true;
            // 
            // col_Type
            // 
            this.col_Type.DataPropertyName = "stock_type";
            this.col_Type.HeaderText = "Type";
            this.col_Type.Name = "col_Type";
            this.col_Type.ReadOnly = true;
            // 
            // col_price
            // 
            this.col_price.DataPropertyName = "Price";
            this.col_price.HeaderText = "Price";
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            // 
            // col_Expire_date
            // 
            this.col_Expire_date.DataPropertyName = "Expire_date";
            this.col_Expire_date.HeaderText = "Expire Date";
            this.col_Expire_date.Name = "col_Expire_date";
            this.col_Expire_date.ReadOnly = true;
            // 
            // col_import_date
            // 
            this.col_import_date.DataPropertyName = "Import_date";
            this.col_import_date.HeaderText = "Import Date";
            this.col_import_date.Name = "col_import_date";
            this.col_import_date.ReadOnly = true;
            this.col_import_date.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel_inserArea);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_inserArea.ResumeLayout(false);
            this.panel_inserArea.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_inserArea;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_Type;
        private System.Windows.Forms.TextBox txt_quntity;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_serach_byName;
        private System.Windows.Forms.Button btn_sale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txt_import_date;
        private System.Windows.Forms.DateTimePicker txt_expire_date;
        private System.Windows.Forms.TextBox txt_bill_NO;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_financial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txt_date;
        private System.Windows.Forms.Label txt_time;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label txt_last_bill;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label lbl_alert;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Expire_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_import_date;
    }
}

