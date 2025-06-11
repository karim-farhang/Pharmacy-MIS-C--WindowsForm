using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace KARPO
{
    public partial class Backup_and_Restor : Form
    {

        private string connectionString = "Data Source=.; Initial Catalog=KARPO; Integrated Security=true";

        public Backup_and_Restor()
        {
            InitializeComponent();
        }

        private void btn_save_to_Click(object sender, EventArgs e)
        {
            save.AddExtension = true;
            save.Filter = "Backup file (*.bak)|*.bak";
            save.ShowDialog();
            txt_save_path.Text = save.FileName;
           
            if(txt_save_path.Text != string.Empty)
            {
                btn_backup.Enabled = true;
            }
            else
            {
                MessageBox.Show("Path is empty");
            }
        }

        private void Backup_and_Restor_Load(object sender, EventArgs e)
        {
            btn_backup.Enabled = false;
            btn_restor.Enabled = false;
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            SqlConnection conect = new SqlConnection(connectionString);
            try
            {
                
                string query = $"BACKUP DATABASE KARPO TO DISK='"+txt_save_path.Text+"'";
                SqlCommand coomand = new SqlCommand(query, conect);
                conect.Open();
                coomand.ExecuteNonQuery();
                MessageBox.Show("Backup done");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conect.Close();
            }
        }

        private void btn_restor_Click(object sender, EventArgs e)
        {
            
            SqlConnection conect = new SqlConnection(connectionString);
            try
            {
                if(txt_open_path.Text != string.Empty)
                {
                    string query = "use master; RESTORE DATABASE KARPO FROM DISK='" + txt_open_path.Text + "' WITH REPLACE";
                    SqlCommand coomand = new SqlCommand(query, conect);
                    conect.Open();
                    coomand.ExecuteNonQuery();
                    MessageBox.Show("Restor  done");
                }
                else
                {
                    MessageBox.Show("Path is empty");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conect.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            open.AddExtension = true;
            open.Filter = "Restor database file (*.bak)|*.bak";
            open.ShowDialog();
            txt_open_path.Text = open.FileName;

            if (txt_open_path.Text != string.Empty)
            {
                btn_restor.Enabled = true;
            }
            else
            {
                MessageBox.Show("Path is empty");
            }

        }
    }
}
