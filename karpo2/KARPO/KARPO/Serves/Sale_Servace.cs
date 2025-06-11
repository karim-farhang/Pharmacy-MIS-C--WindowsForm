using System;
using System.Data;
using KARPO.Reposetory;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KARPO.Serves

{
    class Sale_Servace : sale_Reposetory
    {
        private string connectionString = "Data Source=.; Initial Catalog=KARPO; Integrated Security=true";
        
        public bool updateThis(double id, string type, double quantity, double price)
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                return true;

            }catch
            {
                return false;
            }
        }


        public bool delate(double ID)
        {
            string[] get = new string[3];
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                string query = "Select name as N,sale_type as T, Quantity as Q from sale where id=@ID";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ID", ID);
                con.Open();
                SqlDataReader red = command.ExecuteReader();
                if (red.Read())
                {
                    get[0] = red["N"].ToString();
                    get[1] = red["T"].ToString();
                    get[2] = red["Q"].ToString();

                    MessageBox.Show(get[0] + "   " + get[1] + "    " + get[2]);
                    con.Close();
                    query = "delete from dbo.sale where dbo.sale.id=@ID";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@ID", ID);
                    con.Open();
                    command.ExecuteReader();
                    con.Close();
                    double qu = Convert.ToDouble(get[2]);
                    con.Close();
                    query = "update dbo.stock set dbo.stock.Quantity = stock.Quantity+@Q where Name=@N and Stock_type=@T";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@N", get[0]);
                    command.Parameters.AddWithValue("@T", get[1]);
                    command.Parameters.AddWithValue("@Q", qu);
                    con.Open();
                    command.ExecuteReader();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        
        public double totalPrice(string bull_number)
        {
            double sum = 0;
            SqlConnection con = new SqlConnection(connectionString);
            string query = "Select sum(total) as S from dbo.sale where bill_number=@B and isQuarry=0";

            try
            {
               SqlCommand command = new SqlCommand(query, con);
               command.Parameters.AddWithValue("@B",bull_number);
               con.Open();
               SqlDataReader dataReader = command.ExecuteReader();
               dataReader.Read();
               sum = Convert.ToDouble(dataReader["S"].ToString());
               return sum;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public bool insertNew(string name, double quantity, string type, double price, double total, string bil_number)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "insert into sale(Name,Quantity,sale_type,Price,total,Bill_number,Sale_date,isQuarry) values(@N,@Q,@T,@P,@To,@B_N,GETDATE())";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@N", name);
                command.Parameters.AddWithValue("@Q", quantity);
                command.Parameters.AddWithValue("@T", type);
                command.Parameters.AddWithValue("@P", price);
                command.Parameters.AddWithValue("@To", total);
                command.Parameters.AddWithValue("@B_N", bil_number);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable selectAllByBillNumber(string bill_no)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM sale WHERE bill_number=@BN";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@BN",bill_no);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        public DataTable selectAllByDate(string date)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM sale WHERE sale_date=@SD";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@SD", date);
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }
        

        public double selectRow(string name, string type)
        {
            double Quantity = 0;
            SqlConnection con = new SqlConnection(connectionString);
            string query = "Select dbo.stock.Quantity as Q from dbo.stock where stock.Name=@N and stock.Stock_type=@Td";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@N", name);
                command.Parameters.AddWithValue("@Td", type);
                con.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                if(dataReader.Read())
                {
                    Quantity = Convert.ToDouble(dataReader["Q"].ToString());
                    return Quantity;
                }
                else
                {
                    return Quantity;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
        public double selectAllPriceByDate(string date)
        {
            double sum = 0;
            SqlConnection con = new SqlConnection(connectionString);
            string query = "Select sum(total) as S from dbo.sale where dbo.sale.Sale_date=@D";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@D", date);
                con.Open();
                SqlDataReader dataReader = command.ExecuteReader();
                dataReader.Read();
                sum = Convert.ToDouble(dataReader["S"].ToString());
                return sum;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public bool update(double id, string name, string type, double quantity, double price)
        {
            double total = (quantity * price);
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "update dbo.sale set dbo.sale.Quantity=@Q ,dbo.sale.Price=@P , dbo.sale.total=@T ,  where id=@ID";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@Q", quantity);
                sqlCommand.Parameters.AddWithValue("@P", price);
                sqlCommand.Parameters.AddWithValue("@T", total);
                sqlCommand.Parameters.AddWithValue("@ID", id);
                connection.Open();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool updateBefor(string name, string type, double sale_qantity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "update stock set dbo.stock.Quantity= dbo.stock.Quantity + (@Q) where Name=@N and Stock_type=@T";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Q", sale_qantity);
                command.Parameters.AddWithValue("@N", name);
                command.Parameters.AddWithValue("@T", type);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public bool updateStock(string name, string type, double sale_qantity)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "update stock set dbo.stock.Quantity= dbo.stock.Quantity - (@Q) where Name=@N and Stock_type=@T";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Q",sale_qantity);
                command.Parameters.AddWithValue("@N", name);
                command.Parameters.AddWithValue("@T", type);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
