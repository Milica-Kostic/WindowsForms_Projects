using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace ClCRUD
{
    public class ClsDataAccess
    {
        
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter DataAdapter = new SqlDataAdapter();
        
        public ClsDataAccess()
        {
            string ConnectionStr = ConfigurationManager.ConnectionStrings["Konekcija"].ToString();
            //Connection.ConnectionString = "server=localhost;integrated security=true;database=TSQL;Connection timeout=5;Application name=RAF";
            Connection.ConnectionString = ConnectionStr;
            Command.Connection = Connection;
            Command.CommandType = CommandType.StoredProcedure;
            DataAdapter.SelectCommand = Command;
        }

        public DataTable KlijentiSelect()
        {
            try
            {
                DataSet Ds = new DataSet();
                Command.CommandText = "dbo.KlijentiSelect";
                Command.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Default, null));
                DataAdapter.Fill(Ds);
                ProveriKonekciju();
                return Ds.Tables[0];
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void KlijentiInsert(string Naziv, string Kontakt, string Grad, string Zemlja)
        {
            try
            {
                Command.CommandText = "dbo.KlijentiInsert";
                Command.Parameters.Clear();
                Command.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Default, null));
                Command.Parameters.AddWithValue("@naziv", Naziv);
                Command.Parameters.AddWithValue("@kontakt", Kontakt);
                Command.Parameters.AddWithValue("@grad", Grad);
                Command.Parameters.AddWithValue("@zemlja", Zemlja);
                ProveriKonekciju();
                Connection.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }
        public void KlijentiUpdate(int klijentId , string Naziv, string Kontakt, string Grad, string Zemlja)
        {
            try
            {
                Command.CommandText = "dbo.KlijentiUpdate";
                Command.Parameters.Clear();
                Command.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Default, null));
                Command.Parameters.AddWithValue("@klijentId", klijentId);
                Command.Parameters.AddWithValue("@naziv", Naziv);
                Command.Parameters.AddWithValue("@kontakt", Kontakt);
                Command.Parameters.AddWithValue("@grad", Grad);
                Command.Parameters.AddWithValue("@zemlja", Zemlja);
                ProveriKonekciju();
                Connection.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public void KlijentiDelete(int klijentId)
        {
            try
            {
                Command.CommandText = "dbo.KlijentiDelete";
                Command.Parameters.Clear();
                Command.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, true, 0, 0, "", DataRowVersion.Default, null));
                Command.Parameters.AddWithValue("@klijentId", klijentId);
                ProveriKonekciju();
                Connection.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
     
        private void ProveriKonekciju()
        {
            try
            {
                int RetVal = 0;
                if (Connection.State != ConnectionState.Open)
                {
                    Connection.Open();
                   
                }
                Command.ExecuteNonQuery();
                RetVal = (int)Command.Parameters["@RETURN_VALUE"].Value;
                return;
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
