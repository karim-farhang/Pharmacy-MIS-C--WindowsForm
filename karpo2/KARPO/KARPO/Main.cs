using System;
using System.Windows.Forms;
using KARPO.Serves;
using System.Data.SqlClient;

namespace KARPO
{
    public partial class Form1 : Form
    {
        Main_Servace serveses;

        public static string name = string.Empty, type= string.Empty, Bill_Number= string.Empty, customer = string.Empty, expire_date= string.Empty;
        public static double quntity=0,price=0;

        public Form1()
        {
            serveses = new Main_Servace();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bind_Grade();
            timer.Start();
            txt_last_bill.Text = getLastBuill();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void Clear()
        {
            txt_Type.Text = "";
            txt_price.Text = "";
            txt_expire_date.Text = "";
            txt_name.Text = "";
            txt_quntity.Text = "";
            txt_serach_byName.Text = "";
            txt_import_date.Text = "";

        }
        private void btn_add_Click(object sender, EventArgs e)
        {

            if (isValedate())
            {
                try
                {
                    double quantity = Convert.ToDouble(txt_quntity.Text.Trim());
                    string name = txt_name.Text.Trim().ToLower();
                    string type = txt_Type.Text.Trim().ToLower();
                    double  price = Convert.ToDouble(txt_price.Text.Trim());
                    string expire_date = txt_expire_date.Value.Date.ToShortDateString();
                    string import_date = txt_import_date.Value.Date.ToShortDateString();

                    if (name.Length > 0 && quantity >= 0 && type.Length > 0 && expire_date.Length > 0 && import_date.Length > 0)
                    {
                        serveses.insert(name, quantity, type,price, expire_date, import_date);
                        Bind_Grade();
                    }
                    else
                    {
                        MessageBox.Show("Empty Requeriment feild");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString() + "\nAleady exits");
                }
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                txt_name.Text = table.SelectedRows[0].Cells[1].Value.ToString().ToLower();

                txt_quntity.Text = table.SelectedRows[0].Cells[2].Value.ToString();

                txt_Type.Text = table.SelectedRows[0].Cells[3].Value.ToString().ToLower();

                txt_price.Text = table.SelectedRows[0].Cells[4].Value.ToString();

                txt_expire_date.Text = table.SelectedRows[0].Cells[5].Value.ToString();

                txt_import_date.Text = table.SelectedRows[0].Cells[6].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {

            bool up = false;
            if (isValedate())
            {
                try
                {
                    int ID = Convert.ToInt32(table.SelectedRows[0].Cells[0].Value.ToString());

                    string name = txt_name.Text.Trim().ToLower();
                    double quntity = Convert.ToDouble(txt_quntity.Text.Trim());
                    string type = txt_Type.Text.Trim().ToLower();

                    double price = Convert.ToDouble(txt_price.Text.Trim());
                    string expire_date = txt_expire_date.Value.Date.ToShortDateString().ToLower();
                    string import_date = txt_import_date.Value.Date.ToShortDateString().ToLower();
                    up = serveses.update(name, quntity, type,price, expire_date, import_date, ID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    if (up)
                    {
                        MessageBox.Show("Updated");
                        Bind_Grade();
                    }
                }
            }
        }

        private void btn_sale_Click(object sender, EventArgs e)
        {

            Sale sale = new Sale();
            try
            {

                Form1.Bill_Number = txt_bill_NO.Text;
                Form1.name = table.SelectedRows[0].Cells[1].Value.ToString().ToLower();
                Form1.quntity = Convert.ToDouble(table.SelectedRows[0].Cells[2].Value.ToString());
                Form1.type = table.SelectedRows[0].Cells[3].Value.ToString().ToLower();
                Form1.price = Convert.ToDouble(table.SelectedRows[0].Cells[4].Value.ToString().Trim());
                Form1.expire_date = table.SelectedRows[0].Cells[5].Value.ToString().ToLower();
                Form1.customer = txt_customer.Text.Trim();

                txt_last_bill.Text = getLastBuill();
                
                if (Bill_Number != "" || customer != "")
                {
                    if (sale.ShowDialog(this) == DialogResult.Cancel)
                    {
                        Bind_Grade();
                        Clear();
                        txt_last_bill.Text = getLastBuill();
                    }
                }
                else
                {
                    MessageBox.Show("Bill number or customer is empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void Refrech_Click(object sender, EventArgs e)
        {
            Bind_Grade();
            Clear();
            txt_last_bill.Text = getLastBuill();
        }
    
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Backup_and_Restor().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Financial().ShowDialog();
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            txt_date.Text = DateTime.Now.ToShortDateString ();
            txt_time.Text = DateTime.Now.ToShortTimeString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            bool deleted = false;
            string name = "";
            try
            {
                double ID = Convert.ToDouble(table.SelectedRows[0].Cells[0].Value.ToString());
                name = table.SelectedRows[0].Cells[1].Value.ToString().ToLower();

                if (MessageBox.Show($"Are you ready to delete {name} from stock", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    deleted = serveses.delate(ID);
                    Bind_Grade();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txt_serach_byName_TextChanged(object sender, EventArgs e)
        {
            table.DataSource = serveses.serach(txt_serach_byName.Text.ToLower());
        }

        private void btn_quarry_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_name_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_quntity.Focus();
            }
        }

        private void txt_quntity_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_Type.Focus();
            }
            if(e.KeyCode == Keys.Up)
            {
                txt_name.Focus();
            }
        }

        private void txt_Type_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode ==Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_price.Focus();
            }
            if(e.KeyCode == Keys.Up)
            {
                txt_quntity.Focus();
            }
        }

        private void txt_price_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Down || e.KeyCode == Keys.Enter)
            {
                txt_expire_date.Focus();
            }
            if(e.KeyCode==Keys.Up)
            {
                txt_Type.Focus();
            }
        }

        private void txt_expire_date_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.PageDown || e.KeyCode == Keys.Enter)
            {
                txt_import_date.Focus();
            }
            if(e.KeyCode == Keys.PageUp)
            {
                txt_price.Focus();
            }
        }

        private void txt_import_date_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_add_Click(sender, e);
            }
            if(e.KeyCode == Keys.PageUp)
            {
                txt_expire_date.Focus();
            }
            if(e.KeyCode == Keys.PageDown)
            {
                txt_serach_byName.Focus();
            }
        }
        
        private void btn_update_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btn_clear_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void btn_delete_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txt_serach_byName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txt_bill_NO.Focus();
            }

            if (e.KeyCode == Keys.Up)
            {
                txt_import_date.Focus();
            }
            if(e.KeyCode == Keys.Down)
            {
                txt_bill_NO.Focus();
            }
        }

        private void txt_bill_NO_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txt_customer.Focus();
            }
            if(e.KeyCode == Keys.Up)
            {
                txt_serach_byName.Focus();
            }
        }
        
        private void txt_customer_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_sale_Click(sender, e);
            }
            if(e.KeyCode == Keys.Down)
            {
                btn_sale.Focus();
            }
            if(e.KeyCode == Keys.Up)
            {
                txt_bill_NO.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Quarry().ShowDialog();
        }

        public void Bind_Grade()
        {
            table.AutoGenerateColumns = true;
            table.DataSource = serveses.selectAll();
        }
      
        public string getLastBuill()
        {
            string connectionString = "Data Source=.; Initial Catalog=KARPO; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);
            string bull = "";
            try
            {
                string query = "SELECT TOP 1 dbo.sale.Bill_number FROM dbo.sale ORDER BY dbo.sale.ID DESC";
                SqlCommand conend = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader red = conend.ExecuteReader();
                if(red.Read())
                {
                    bull = red["Bill_number"].ToString();
                }
                else
                {
                    bull = "error";
                }
                
                return bull;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                conn.Close();
            }
         }
        
        public bool isValedate()
        {
            bool x = true;
            if(txt_name.Text.Trim() == "")
            {
                MessageBox.Show("Name is empty!");
                x = false;
            }
            if (txt_quntity.Text.Trim()=="")
            {
                MessageBox.Show("Quantity is invaled!");
                x = false;
            }
            if(txt_Type.Text.Trim()=="")
            {
                MessageBox.Show("Type is empty!");
                x = false;
            }
            if(txt_expire_date.Text.Trim() == "")
            {
                MessageBox.Show("Expire date is empty!");
                x = false;
            }
            if(txt_import_date.Text.Trim() == "")
            {
                MessageBox.Show("Import date is empty!");
                x = false;
            }
            return x;
        }
    }
}
