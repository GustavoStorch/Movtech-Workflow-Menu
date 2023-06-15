using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuWorkflow
{
    public class LoginDAO
    {
        private SqlConnection Connection { get; }

        public LoginDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public bool logar = false;
        SqlDataReader dr;

        public bool VerificaLogin(LoginModel login)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                command.CommandText = "select * from MvtAcessoUsuario where usuario = @usuario and senha = @senha";
                command.Parameters.AddWithValue("@usuario", login.Usuario);
                command.Parameters.AddWithValue("@senha", login.Senha);
                try
                {
                    dr = command.ExecuteReader();
                    if (dr.HasRows)
                    {
                        logar = true;
                    }
                }
                catch (SqlException ex)
                {
                    throw ex;
                }
                return logar;
            }
        }
    }
}
