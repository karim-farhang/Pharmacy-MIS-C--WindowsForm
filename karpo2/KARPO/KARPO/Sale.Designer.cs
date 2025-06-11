namespace KARPO
{
    partial class Sale
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_sale_price = new System.Windows.Forms.TextBox();
            this.txt_quantity_sale = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_customer = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_bill_no = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.table_sale = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Total_of_day = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sarche_by_bill_number = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_sarche_by_date = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_sale)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.txt_sale_price);
            this.panel1.Controls.Add(this.txt_quantity_sale);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_customer);
            this.panel1.Controls.Add(this.txt_price);
            this.panel1.Controls.Add(this.txt_type);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_quantity);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_bill_no);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 567);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 415);
            this.button2.MinimumSize = new System.Drawing.Size(20, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 456);
            this.button1.MinimumSize = new System.Drawing.Size(20, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(10, 375);
            this.btn_save.MinimumSize = new System.Drawing.Size(20, 30);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(196, 35);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_sale_price
            // 
            this.txt_sale_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sale_price.Location = new System.Drawing.Point(94, 329);
            this.txt_sale_price.Name = "txt_sale_price";
            this.txt_sale_price.Size = new System.Drawing.Size(113, 30);
            this.txt_sale_price.TabIndex = 7;
            this.txt_sale_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sale_price.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sale_price_KeyUp);
            // 
            // txt_quantity_sale
            // 
            this.txt_quantity_sale.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity_sale.Location = new System.Drawing.Point(95, 281);
            this.txt_quantity_sale.Name = "txt_quantity_sale";
            this.txt_quantity_sale.Size = new System.Drawing.Size(111, 30);
            this.txt_quantity_sale.TabIndex = 6;
            this.txt_quantity_sale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quantity_sale.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_quantity_sale_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Customer:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 184);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Price:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Type:";
            // 
            // txt_customer
            // 
            this.txt_customer.AutoSize = true;
            this.txt_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer.Location = new System.Drawing.Point(126, 225);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(35, 15);
            this.txt_customer.TabIndex = 2;
            this.txt_customer.Text = "none";
            // 
            // txt_price
            // 
            this.txt_price.AutoSize = true;
            this.txt_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_price.Location = new System.Drawing.Point(124, 190);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(35, 15);
            this.txt_price.TabIndex = 2;
            this.txt_price.Text = "none";
            // 
            // txt_type
            // 
            this.txt_type.AutoSize = true;
            this.txt_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_type.Location = new System.Drawing.Point(124, 146);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(35, 15);
            this.txt_type.TabIndex = 2;
            this.txt_type.Text = "none";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Price sale:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Quantity sale:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bill no:";
            // 
            // txt_quantity
            // 
            this.txt_quantity.AutoSize = true;
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(126, 101);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(35, 15);
            this.txt_quantity.TabIndex = 1;
            this.txt_quantity.Text = "none";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // txt_bill_no
            // 
            this.txt_bill_no.AutoSize = true;
            this.txt_bill_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bill_no.Location = new System.Drawing.Point(126, 12);
            this.txt_bill_no.Name = "txt_bill_no";
            this.txt_bill_no.Size = new System.Drawing.Size(35, 15);
            this.txt_bill_no.TabIndex = 0;
            this.txt_bill_no.Text = "none";
            // 
            // txt_name
            // 
            this.txt_name.AutoSize = true;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(124, 53);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(35, 15);
            this.txt_name.TabIndex = 0;
            this.txt_name.Text = "none";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Search By Bill number";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.table_sale);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(216, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 567);
            this.panel2.TabIndex = 1;
            // 
            // table_sale
            // 
            this.table_sale.AllowUserToAddRows = false;
            this.table_sale.AllowUserToDeleteRows = false;
            this.table_sale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_sale.Location = new System.Drawing.Point(1, 1);
            this.table_sale.Name = "table_sale";
            this.table_sale.ReadOnly = true;
            this.table_sale.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_sale.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
            this.table_sale.RowTemplate.Height = 32;
            this.table_sale.Size = new System.Drawing.Size(804, 464);
            this.table_sale.TabIndex = 0;
            this.table_sale.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel3.Controls.Add(this.txt_Total_of_day);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(216, 522);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(808, 45);
            this.panel3.TabIndex = 2;
            // 
            // txt_Total_of_day
            // 
            this.txt_Total_of_day.AutoSize = true;
            this.txt_Total_of_day.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total_of_day.Location = new System.Drawing.Point(656, 14);
            this.txt_Total_of_day.Name = "txt_Total_of_day";
            this.txt_Total_of_day.Size = new System.Drawing.Size(85, 16);
            this.txt_Total_of_day.TabIndex = 1;
            this.txt_Total_of_day.Text = "Click to show";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(224, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Click to show";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(431, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total this day:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total this Bill:";
            // 
            // txt_sarche_by_bill_number
            // 
            this.txt_sarche_by_bill_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sarche_by_bill_number.Location = new System.Drawing.Point(170, 11);
            this.txt_sarche_by_bill_number.Name = "txt_sarche_by_bill_number";
            this.txt_sarche_by_bill_number.Size = new System.Drawing.Size(200, 30);
            this.txt_sarche_by_bill_number.TabIndex = 7;
            this.txt_sarche_by_bill_number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_sarche_by_bill_number.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_sarche_by_bill_number.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_sarche_by_bill_number_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(424, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Search by Date";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(62)))), ((int)(((byte)(66)))));
            this.panel4.Controls.Add(this.txt_sarche_by_date);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_sarche_by_bill_number);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(216, 471);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(808, 51);
            this.panel4.TabIndex = 2;
            // 
            // txt_sarche_by_date
            // 
            this.txt_sarche_by_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sarche_by_date.Location = new System.Drawing.Point(545, 15);
            this.txt_sarche_by_date.MaximumSize = new System.Drawing.Size(200, 30);
            this.txt_sarche_by_date.Name = "txt_sarche_by_date";
            this.txt_sarche_by_date.Size = new System.Drawing.Size(200, 23);
            this.txt_sarche_by_date.TabIndex = 8;
            this.txt_sarche_by_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 567);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SALE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Sale_form_FormClosed);
            this.Load += new System.EventHandler(this.Sale_form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_sale)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_sale_price;
        private System.Windows.Forms.TextBox txt_quantity_sale;
        private System.Windows.Forms.Label txt_type;
        private System.Windows.Forms.Label txt_quantity;
        private System.Windows.Forms.Label txt_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView table_sale;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_bill_no;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_sarche_by_bill_number;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker txt_sarche_by_date;
        private System.Windows.Forms.Label txt_Total_of_day;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txt_price;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txt_customer;
    }
}