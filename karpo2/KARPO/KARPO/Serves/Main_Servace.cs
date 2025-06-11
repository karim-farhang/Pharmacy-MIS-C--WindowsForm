using System;
using System.Data;
using KARPO.Reposetory;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KARPO.Serves
{
    class Main_Servace : stock_Reposetooty
    {

        private string connectionString = "Data Source=.; Initial Catalog=KARPO; Integrated Security=true";
        
        public DataTable serach(string paramter)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM stock WHERE name like @paramter";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@paramter", "%" + paramter + "%");
            DataTable data = new DataTable();
            adapter.Fill(data);
            connection.Close();
            return data;
        }

        public bool delate(double id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "Delete from  stock where id=@ID";

            try
            {    
                SqlCommand comand = new SqlCommand(query, con);
                comand.Parameters.AddWithValue("@ID", id);
                con.Open();
                comand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool insert(string name, double quntity, string type,double price, string expire_date, string import_date)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "insert into stock (Name,Quantity,stock_type,price,Expire_date,Import_date) values(@N,@Q,@T,@PR,@E,@I);";
            
            try
            {
                SqlCommand comand = new SqlCommand(query,con);
                comand.Parameters.AddWithValue("@N", name);
                comand.Parameters.AddWithValue("@Q", quntity);
                comand.Parameters.AddWithValue("@T", type);
                comand.Parameters.AddWithValue("@PR", price);
                comand.Parameters.AddWithValue("@E", expire_date);
                comand.Parameters.AddWithValue("@I", import_date);
                con.Open();
                comand.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable selectAll()
        {
            string query = "SELECT * FROM Stock;";
            SqlConnection con = new SqlConnection(connectionString);
            DataTable data = new DataTable();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(data);
                return data;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return data;
            }
            finally
            {
                con.Close();  
            }
            
        }

      

        public bool update(string name, double quntity, string type,double price, string expire_date, string import_date, double id)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "update stock set name=@N , Quantity=@Q, stock_type=@T , price=@PR, expire_date=@Ex , import_date =@IM where id=@ID";
            try
            {
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@N", name);
                command.Parameters.AddWithValue("@Q", quntity);
                command.Parameters.AddWithValue("@T", type);
                command.Parameters.AddWithValue("@PR", price);
                command.Parameters.AddWithValue("@Ex", expire_date);
                command.Parameters.AddWithValue("@IM", import_date);
                command.Parameters.AddWithValue("@ID", id);
                con.Open();
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
                con.Close();
            }      
        }   
    }
}
