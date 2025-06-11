using System;
using System.Windows.Forms;
using KARPO.Serves;

namespace KARPO
{
    public partial class Financial : Form
    {

        Financial_Servace servers;
        Sale_Servace sel_service;
        
        public Financial()
        {
            sel_service = new Sale_Servace();
            servers = new Financial_Servace();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_total_range_Click(object sender, EventArgs e)
        {

        }

        private void Finance_Load(object sender, EventArgs e)
        {

            //table_quarry.AutoGenerateColumns = true;
            //table_quarry.DataSource = servers.getQuarryBill_number();

        }
        
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string date = txt_date_this_date.Value.Date.ToString();
            table_sale.AutoGenerateColumns = true;
            table_sale.DataSource = servers.selectThisDate(date);
            table_bill_number.AutoGenerateColumns = true;

            table_bill_number.DataSource = servers.getBillNumberByDate(date);
            
            txt_total_this_date.Text = sel_service.selectAllPriceByDate(date).ToString("#,##0");
        }
        
        private void table_Bill_number_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string bil_number = table_bill_number.SelectedRows[0].Cells[0].Value.ToString();
                table_sale.DataSource = servers.selectBillNumber(bil_number);
                txt_total_this_bill.Text = sel_service.totalPrice(bil_number).ToString("#,##0");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please click the left side of bill number\n"+ex.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string date = txt_date_this_date.Value.Date.ToString();
            string name = textBox1.Text;
            table_sale.DataSource = servers.serach(name,date);
            txt_quantity.Text = servers.getQuantitySerach(name,date).ToString("#,##0");
        }

     

        private void table_quarry_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string bil_number = table_bill_number.SelectedRows[0].Cells[0].Value.ToString();
                table_sale.DataSource = servers.selectBillNumber(bil_number);
                txt_total_this_bill.Text = sel_service.totalPrice(bil_number).ToString("#,##0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please click the left side of bill number\n" + ex.ToString());
            }
        }
    }
}
