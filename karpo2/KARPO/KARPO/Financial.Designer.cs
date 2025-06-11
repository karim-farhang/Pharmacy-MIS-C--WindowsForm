namespace KARPO
{
    partial class Financial
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
            this.txt_date_this_date = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.table_quarry = new System.Windows.Forms.DataGridView();
            this.table_bill_number = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_quantity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.table_sale = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_total_this_date = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_total_this_bill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_quarry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_bill_number)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_sale)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_date_this_date
            // 
            this.txt_date_this_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_date_this_date.Location = new System.Drawing.Point(758, 12);
            this.txt_date_this_date.Name = "txt_date_this_date";
            this.txt_date_this_date.Size = new System.Drawing.Size(331, 30);
            this.txt_date_this_date.TabIndex = 0;
            this.txt_date_this_date.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.table_quarry);
            this.panel1.Controls.Add(this.table_bill_number);
            this.panel1.Location = new System.Drawing.Point(8, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 489);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quarrys";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "All bill Today";
            // 
            // table_quarry
            // 
            this.table_quarry.AllowUserToAddRows = false;
            this.table_quarry.AllowUserToDeleteRows = false;
            this.table_quarry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_quarry.Location = new System.Drawing.Point(3, 37);
            this.table_quarry.Name = "table_quarry";
            this.table_quarry.ReadOnly = true;
            this.table_quarry.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_quarry.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
            this.table_quarry.RowTemplate.Height = 32;
            this.table_quarry.Size = new System.Drawing.Size(121, 454);
            this.table_quarry.TabIndex = 0;
            this.table_quarry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_quarry_CellClick);
            // 
            // table_bill_number
            // 
            this.table_bill_number.AllowUserToAddRows = false;
            this.table_bill_number.AllowUserToDeleteRows = false;
            this.table_bill_number.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_bill_number.Location = new System.Drawing.Point(129, 36);
            this.table_bill_number.Name = "table_bill_number";
            this.table_bill_number.ReadOnly = true;
            this.table_bill_number.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_bill_number.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
            this.table_bill_number.RowTemplate.Height = 32;
            this.table_bill_number.Size = new System.Drawing.Size(124, 454);
            this.table_bill_number.TabIndex = 0;
            this.table_bill_number.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_Bill_number_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_quantity);
            this.panel2.Controls.Add(this.txt_date_this_date);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1115, 52);
            this.panel2.TabIndex = 2;
            // 
            // txt_quantity
            // 
            this.txt_quantity.AutoSize = true;
            this.txt_quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity.Location = new System.Drawing.Point(541, 15);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(33, 25);
            this.txt_quantity.TabIndex = 0;
            this.txt_quantity.Text = "---";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(203, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(275, 30);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for this Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.table_sale);
            this.panel3.Location = new System.Drawing.Point(271, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(855, 489);
            this.panel3.TabIndex = 1;
            // 
            // table_sale
            // 
            this.table_sale.AllowUserToAddRows = false;
            this.table_sale.AllowUserToDeleteRows = false;
            this.table_sale.Location = new System.Drawing.Point(0, 0);
            this.table_sale.Name = "table_sale";
            this.table_sale.ReadOnly = true;
            this.table_sale.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_sale.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Green;
            this.table_sale.RowTemplate.Height = 32;
            this.table_sale.RowTemplate.ReadOnly = true;
            this.table_sale.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.table_sale.Size = new System.Drawing.Size(855, 483);
            this.table_sale.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel4.Controls.Add(this.txt_total_this_date);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txt_total_this_bill);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(8, 563);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1115, 57);
            this.panel4.TabIndex = 3;
            // 
            // txt_total_this_date
            // 
            this.txt_total_this_date.AutoSize = true;
            this.txt_total_this_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_this_date.Location = new System.Drawing.Point(1022, 16);
            this.txt_total_this_date.Name = "txt_total_this_date";
            this.txt_total_this_date.Size = new System.Drawing.Size(40, 25);
            this.txt_total_this_date.TabIndex = 0;
            this.txt_total_this_date.Text = "----";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(859, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total this date:";
            // 
            // txt_total_this_bill
            // 
            this.txt_total_this_bill.AutoSize = true;
            this.txt_total_this_bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total_this_bill.Location = new System.Drawing.Point(276, 16);
            this.txt_total_this_bill.Name = "txt_total_this_bill";
            this.txt_total_this_bill.Size = new System.Drawing.Size(33, 25);
            this.txt_total_this_bill.TabIndex = 0;
            this.txt_total_this_bill.Text = "---";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total This Bil";
            // 
            // Financial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 627);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "Financial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FINANCE";
            this.Load += new System.EventHandler(this.Finance_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table_quarry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_bill_number)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table_sale)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker txt_date_this_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView table_bill_number;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView table_sale;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label txt_total_this_bill;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txt_total_this_date;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txt_quantity;
        private System.Windows.Forms.DataGridView table_quarry;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}