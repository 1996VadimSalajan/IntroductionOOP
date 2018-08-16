using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace @base
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["Moodle"].ConnectionString;

            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var sqlCommandText = "SELECT* FROM Users;";
                using (var sqlCommand = new SqlCommand(sqlCommandText,sqlConnection))
                {
                    SqlDataReader usersReader = sqlCommand.ExecuteReader();
                    while (usersReader.Read())
                    {
                        int id = (int)usersReader["iduser"];
                        string firstname = (string)usersReader["firstname"];
                        string lastname = (string)usersReader["lastname"];
                        string email = (string)usersReader["email"];
                        string passworduser = (string)usersReader["passworduser"];
                        long idnp = (long)usersReader["IDNP"];
                        DateTime birthdate = (DateTime)usersReader["birthdate"];
                        int age = (int)usersReader["age"];                       
                       string composite="User Id={0,-15} FirstName={1,-15} LastName={2,-15} Email={3,-35} Password={4,-35} IDNP={5,-25} BirthDate={6,-25} Age={7,-25}";
                       Console.WriteLine(string.Format(composite, id, firstname,lastname,email,passworduser,idnp,birthdate,age));
                    }

                }

            }
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var sqlCommandText = "SELECT c.iduser, c.firstname,c.lastname FROM Users  c, students  s WHERE c.iduser=s.iduser;";
                using (var sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
                {
                    sqlCommand.Parameters.Add("@id", SqlDbType.Int);
                    sqlCommand.Parameters["@id"].Value = 2;
                    SqlDataReader usersReader = sqlCommand.ExecuteReader();
                    while (usersReader.Read())
                    {
                        int id = (int)usersReader["iduser"];
                        string lastname = (string)usersReader["lastname"];
                        string firstname = (string)usersReader["firstname"];
                        Console.WriteLine("User Id={0}, FirstName={1},LastName{2}",id, firstname,lastname);
                    }
                }
            }



            Console.ReadKey();
        }
    }
}
