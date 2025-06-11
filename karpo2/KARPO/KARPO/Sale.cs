using System;
using System.Drawing;
using System.Windows.Forms;
using KARPO.Serves;
using System.Data;

namespace KARPO
{
    public partial class Sale : Form
    {
        //private string BILL_NO = "";
        //private string NAME = "";
        //private double QUANTITY = 0;
        //private string TYPE = "";
        //private string EXPIRE = "";
        private double QQQ = 0;
        Sale_Servace servace;
        public Sale()
        {
            servace = new Sale_Servace();
            InitializeComponent();
        }

        private void Sale_form_Load(object sender, EventArgs e)
        {
            txt_bill_no.Text = Form1.Bill_Number;

            //BILL_NO = txt_bill_no.Text.ToLower();

            txt_name.Text = Form1.name;
           // NAME = txt_name.Text.ToLower();

            txt_type.Text = Form1.type;
            //TYPE = txt_type.Text.ToLower();

            txt_quantity.Text = Form1.quntity.ToString();
            //QUANTITY = Form1.quntity;

            txt_price.Text = Form1.price.ToString();
            txt_customer.Text = Form1.customer;
            
            //EXPIRE = Form1.expire_date;
            table_sale.AutoGenerateColumns = true;
            table_sale.DataSource = servace.selectAllByBillNumber(txt_bill_no.Text);
        }
        

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_quantity_sale.Text = "";
            txt_sale_price.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double id = Convert.ToDouble(table_sale.SelectedRows[0].Cells[0].Value.ToString());

                string name = txt_name.Text;
                string type = txt_type.Text;

                double quantity = Convert.ToDouble(txt_quantity_sale.Text.Trim());
                double price = Convert.ToDouble(txt_sale_price.Text.Trim());
                
                if(isValedate())
                {
                   if (servace.updateBefor(name, type, QQQ))
                    {
                        if (servace.update(id, name, type, quantity, price))
                        {
                            if (servace.updateStock(name, type, quantity))
                            {
                                MessageBox.Show("Updated");

                                string bill = txt_bill_no.Text;
                                    table_sale.DataSource = servace.selectAllByBillNumber(bill);
                                    txt_quantity.Text = servace.selectRow(name, type).ToString();
                                    label8.Text = servace.totalPrice(txt_bill_no.Text.Trim()).ToString();
                            }
                            else
                            {
                                MessageBox.Show("Update stock has error");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Update slae has error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Update befor has error");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               double id = Convert.ToDouble(table_sale.SelectedRows[0].Cells[0].Value.ToString());
                string name = table_sale.SelectedRows[0].Cells[1].Value.ToString();

                if (MessageBox.Show($"Are you ready to delete {name} from saled", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    bool x = servace.delate(id);
                    if(x)
                    {
                        MessageBox.Show("Delete Operation Done");
                    }
                    // servace.updateThis(name, type, expire_date, quantiy);
                    table_sale.DataSource = servace.selectAllByBillNumber(txt_bill_no.Text.ToString().Trim());
                }
            }
            catch
            {
                MessageBox.Show("Please click the left side of id");
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(isValedate())
            {
                double genral_price = Convert.ToDouble(txt_price.Text.Trim());
                string bill_nomber = txt_bill_no.Text.Trim();
                string name = txt_name.Text.Trim();
                double quantity = Convert.ToDouble(txt_quantity.Text.Trim());
                string type = txt_type.Text.Trim();
                double price = Convert.ToDouble(txt_sale_price.Text.Trim());
                double Quantity_sale = Convert.ToDouble(txt_quantity_sale.Text.Trim());

                string expire =Form1.expire_date;
                double total = (price * Quantity_sale);
                
                if (Quantity_sale>quantity || genral_price<price)
                {
                    if (Quantity_sale > quantity)
                    {
                        txt_quantity_sale.ForeColor = Color.Red;
                        MessageBox.Show("Quantity you want to sale is bigger then stock");
                    }
                    if(genral_price < price)
                    {
                        txt_quantity_sale.ForeColor = Color.Red;
                        MessageBox.Show("Quantity you want to sale is bigger then stock");
                    }
                }
                else
                {
                    bool insert = servace.insertNew(name, Quantity_sale, type, price, total, bill_nomber);
                    if (insert)
                    {
                        bool update = servace.updateStock(name, type, Quantity_sale);
                        if (update)
                        {
                            table_sale.DataSource = servace.selectAllByBillNumber(bill_nomber);
                            MessageBox.Show("Sale saccsess");
                            txt_quantity.Text = servace.selectRow(name, type).ToString();
                            
                            label8.Text = servace.totalPrice(txt_bill_no.Text).ToString();
                        }
                    }
                }
            }
        }
        public bool isValedate()
        {
            bool valate = true;
            if(txt_sale_price.Text.Trim() =="")
            {
                MessageBox.Show("Price is empty");
                valate = false;
            }
            if(txt_quantity_sale.Text.Trim() == "")
            {
                MessageBox.Show("Quantity is empty");
                valate = false;
            }

            return valate;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = servace.totalPrice(txt_bill_no.Text).ToString("#,##0");
        }

        private void Sale_form_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                double id = Convert.ToDouble(table_sale.SelectedRows[0].Cells[0].Value.ToString());
                txt_name.Text = table_sale.SelectedRows[0].Cells[1].Value.ToString();
                txt_type.Text = table_sale.SelectedRows[0].Cells[3].Value.ToString();
                txt_quantity_sale.Text = Convert.ToDouble(table_sale.SelectedRows[0].Cells[2].Value).ToString();
                QQQ = Convert.ToDouble(txt_quantity_sale.Text.Trim());

                txt_sale_price.Text = Convert.ToDouble(table_sale.SelectedRows[0].Cells[4].Value).ToString();
 
                txt_quantity.Text = "---";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string date = txt_sarche_by_date.Value.Date.ToString();
            table_sale.DataSource = servace.selectAllByDate(date);
            txt_Total_of_day.Text =servace.selectAllPriceByDate(date).ToString("#,##0");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            table_sale.DataSource = servace.selectAllByBillNumber(txt_sarche_by_bill_number.Text.Trim().ToString());
        }

   

        private void txt_quantity_sale_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_sale_price.Focus();
            }
        }

        private void txt_sale_price_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                txt_sarche_by_bill_number.Focus();
            }
            if(e.KeyCode == Keys.Up)
            {
                txt_quantity_sale.Focus();
            }
            if(e.KeyCode == Keys.Enter)
            {
                btn_save_Click(sender, e);
            }
        }

        private void txt_sarche_by_bill_number_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                txt_sale_price.Focus();
            }
        }
    }
}
