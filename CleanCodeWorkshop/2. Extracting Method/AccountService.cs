using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CleanCodeWorkshop._2._Extracting_Method
{
    public class AccountService
    {
        public void Register(string username, string password)
        {
            // username should be a-z and long at least 4 characters
            if (username != null
                    && username.Length >= 4
                    //&& Regex.IsMatch(username, "[a-z0-9]")
                    && Regex.IsMatch(username, "[A-Za-z0-9]"))
            {
                // password should long at least 6 characters
                if (password != null
                        && password.Length >= 8)
                {
                    // instance connection and command
                    using (SqlConnection cn = new SqlConnection("connection string"))
                    {
                        // Query to be executed
                        string query = "INSERT INTO User (Username, Password) VALUES (@Username, @Password) ";

                        using (SqlCommand cmd = new SqlCommand(query, cn))
                        {
                            // add parameters and their values
                            cmd.Parameters.Add("@Username", System.Data.SqlDbType.VarChar, 100).Value = username;
                            cmd.Parameters.Add("@Password", System.Data.SqlDbType.VarChar, 100).Value = password;

                            // open connection, execute command and close connection
                            cn.Open();
                            cmd.ExecuteNonQuery();
                            cn.Close();
                        }
                    }
                }
            }
        }
    }
}