using System;
using System.Data;
using KARPO.Reposetory;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KARPO.Serves
{

    class Financial_Servace : Financial_Reposetory
    {
        string connectionPath = "Data Source=.; Initial Catalog=KARPO; Integrated Security=true";

        public DataTable getBillNumberByDate(string date)
        {
            SqlConnection connection = new SqlConnection(connectionPath);
            string query = "select dbo.sale.Bill_number from dbo.sale where dbo.sale.Sale_date=@SD group by dbo.sale.Bill_number";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@SD",date);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public DataTable getBillNumberByDate(string start, string end)
        {
            SqlConnection connection = new SqlConnection(connectionPath);
            string query = "select dbo.sale.Bill_number from dbo.sale where dbo.sale.Sale_date >=@SD  and dbo.sale.Sale_date<=@ED GROUP BY dbo.sale.Bill_number";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@SD", start);
            adapter.SelectCommand.Parameters.AddWithValue("@ED", end);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public DataTable selectAll()
        {
            SqlConnection connection = new SqlConnection(connectionPath);
            string query = "SELECT * FROM sale";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);

            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;

        }

        public DataTable selectBillNumber(string bull_number)
        {
            SqlConnection connection = new SqlConnection(connectionPath);
            string query = "SELECT * FROM sale where bill_number=@B";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@B",bull_number);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        
        public DataTable selectRange(string startDate, string endDate)
        {
            SqlConnection connection = new SqlConnection(connectionPath);
            string query = "SELECT * FROM sale where sale_date<=@SD  and sale_date>=@ED ";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@SD",startDate);
            adapter.SelectCommand.Parameters.AddWithValue("@ED",endDate);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public DataTable serach(string paramter, string date)
        {
            SqlConnection connection = new SqlConnection(connectionPath);
            string query = "SELECT * FROM sale WHERE name like @paramter and sale_date=@D";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@paramter", "%" + paramter + "%");
            adapter.SelectCommand.Parameters.AddWithValue("@D",date);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public double getQuantitySerach(string paramter, string date)
        {
            SqlConnection connection = new SqlConnection(connectionPath);

            try
            {
                string query = "SELECT sum(dbo.sale.Quantity) as Qu FROM dbo.sale WHERE name like @P and sale_date=@D";
                {
                    SqlCommand commands = new SqlCommand(query, connection);
                    commands.Parameters.AddWithValue("@P", "%" + paramter + "%");
                    commands.Parameters.AddWithValue("@D", date);
                    connection.Open();
                    SqlDataReader reder = commands.ExecuteReader();
                    if (reder.Read())
                    {
                        return Convert.ToDouble(reder["Qu"].ToString());
                    }
                    else
                    {
                        return 0.00;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0.00;
            }

            finally
            {
                connection.Close();
            }
            
        }


        public DataTable selectThisBill(string Bill)
        {
            SqlConnection connection = new SqlConnection(connectionPath);
            string query = "SELECT * FROM sale where bill_number=@ED ";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@ED", Bill);
                DataTable data = new DataTable();
                adapter.Fill(data);
                connection.Close();
                return data;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable selectThisDate(string Date)
        {
            SqlConnection connection = new SqlConnection(connectionPath);
            string query = "SELECT * FROM sale where sale_date=@D ";
            try
            { 
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@D", Date);
                DataTable data = new DataTable();
                adapter.Fill(data);
                connection.Close();
                return data;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                connection.Close();
            }   
        }

        public double totalRange()
        {
            throw new NotImplementedException();
        }

        public double totalPrice(string bull_number)
        {
            throw new NotImplementedException();
        }


        public DataTable getQuarry()
        {
            SqlConnection connection = new SqlConnection(connectionPath);
            string query = "select * from dbo.sale where dbo.sale.isQuarry=1";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            connection.Open();
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }


        public DataTable getQuarryBill_number()
        {
            SqlConnection connection = new SqlConnection(connectionPath);
            string query = "select dbo.sale.Bill_number as Bill from dbo.sale where dbo.sale.isQuarry=1 group by dbo.sale.Bill_number";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            connection.Open();
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }

    }
}
