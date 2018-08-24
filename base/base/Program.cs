using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.Common;

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
                using (var sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
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
                        string composite = "User Id={0,-15} FirstName={1,-15} LastName={2,-15} Email={3,-35} Password={4,-35} IDNP={5,-25} BirthDate={6,-25} Age={7,-25}";
                        Console.WriteLine(string.Format(composite, id, firstname, lastname, email, passworduser, idnp, birthdate, age));
                    }

                }

            }
            using (var sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                var sqlCommandText = "Select u.iduser, u.FirstName,u.LastName,e.EventName,ut.FirstName as FirstNameTeacher,ut.LastName as LastNameTeacher From Users as u,Users as ut,Students as st,Subscribes as sb,Events as e where u.IdUser = st.IdUser and st.IdStudent = sb.IdStudent and sb.IdEvent = e.IdEvent and (ut.FirstName)in(Select u.FirstName From Users as u,Teachers as t,Events e where u.IdUser = t.IdTeacher and t.IdTeacher = e.Createby); ";
                using (var sqlCommand = new SqlCommand(sqlCommandText, sqlConnection))
                {
                    SqlDataReader usersReader = sqlCommand.ExecuteReader();
                    while (usersReader.Read())
                    {
                        int id = (int)usersReader["iduser"];
                        string firstname = (string)usersReader["firstname"];
                        string lastname = (string)usersReader["lastname"];
                        string eventname = (string)usersReader["eventname"];
                        string firstnameteacher = (string)usersReader["FirstNameTeacher"];
                        string lastnameteacher = (string)usersReader["LastNameTeacher"];
                        string composite = "User Id={0,-15} FirstName={1,-15} LastName={2,-15} EventName={3,-15} TeacherFirstName={4,-15} TeacherLastName={5,-15}";
                        Console.WriteLine(string.Format(composite, id, firstname, lastname, eventname, firstnameteacher, lastnameteacher));
                    }
                }
            }

            var datatable = GetTable();
            foreach (var col in datatable.Columns)
            {
                Console.Write("\t{0}", col);
            }
            Console.WriteLine();
            foreach (DataRow dt in datatable.Rows)
            {
                foreach (var item in dt.ItemArray)
                {

                    Console.Write("\t{0}\t", item);
                }

                Console.WriteLine();
            }
            Table();
           // InsertTable();
              Console.ReadKey();
        }
        public static DataTable GetTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Date", typeof(DateTime));
            table.Rows.Add(25, "Indocin","David", DateTime.Now);
            table.Rows.Add(50, "Enebrel","Sam", DateTime.Now);
            table.Rows.Add(10, "Hydi","Chris", DateTime.Now);
            table.Rows.Add(21, "Cass","Janet", DateTime.Now);
            table.Rows.Add(100,"Dilan","Mela", DateTime.Now);
            table.Rows.RemoveAt(1);
            List<DataRow> rows_to_remove = new List<DataRow>();
            foreach (DataRow row1 in table.Rows)
            {             
                    if (row1["FirstName"].ToString() =="Cass")
                    {
                        rows_to_remove.Add(row1);
                    }               
            }
            foreach (DataRow row in rows_to_remove)
            {
                table.Rows.Remove(row);
                table.AcceptChanges();
            }
            return table;
        }
        public static void Table()
        {   
            string connectionString = ConfigurationManager.ConnectionStrings["Moodle"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            { string sql = "Select u.iduser, u.FirstName,u.LastName,c.NameCourse  From Courses as c,Groups as g,Users u,Students as s where u.IdUser = s.IdUser and s.GroupId = g.GroupId and g.GroupId = c.GroupId";
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataTable dt in ds.Tables)
                {
                    Console.WriteLine(dt.TableName); 
                    foreach (DataColumn column in dt.Columns)
                    Console.Write("\t     {0}", column.ColumnName);
                    Console.WriteLine();                 
                    foreach (DataRow row in dt.Rows)
                    {
                        var cells = row.ItemArray;
                        foreach (object cell in cells)
                        Console.Write("\t\t{0}", cell);
                        Console.WriteLine();
                    }
                }
            }
           
        }
        public static void InsertTable()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Moodle"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter myAdapter = new SqlDataAdapter("SELECT * FROM Users", connection);
                myAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                DataSet myDataSet = new DataSet();
                myAdapter.Fill(myDataSet, "Users");
                object[] rowVals = new object[11];
                DateTime data1 = new DateTime(2018, 02, 02);
                DateTime data2 = new DateTime(2000, 02, 02);
                rowVals[1] = "Salajan";
                rowVals[2] = "Vadim";
                rowVals[3] = "salajan96@mail.ru";
                rowVals[4] = "fsfdssvfdgsfsdfdsf";
                rowVals[5] = 1332123423432;
                rowVals[6] = "sfddfss123fsdfsf";
                rowVals[7] = data1;
                rowVals[8] = data2;
                rowVals[9] = 18;
                rowVals[10] = "m";
                myDataSet.Tables["Users"].Rows.Add(rowVals);
                myAdapter.InsertCommand = new SqlCommand("INSERT INTO Users (firstname,lastname,email,passworduser,idnp,photo,datecreated,birthdate,age,gender) " +
                "VALUES ( @firstname, @lastname, @email,@passworduser, @idnp, @photo, @datecreated, @birthdate, @age, @gender)", connection);
                myAdapter.InsertCommand.Parameters.Add("@firstname", SqlDbType.VarChar, 50, "firstname");
                myAdapter.InsertCommand.Parameters.Add("@lastname", SqlDbType.VarChar, 50, "lastname");
                myAdapter.InsertCommand.Parameters.Add("@email", SqlDbType.VarChar, 50, "email");
                myAdapter.InsertCommand.Parameters.Add("@passworduser", SqlDbType.VarChar, 50, "passworduser");
                myAdapter.InsertCommand.Parameters.Add("@idnp", SqlDbType.BigInt, 0, "idnp");
                myAdapter.InsertCommand.Parameters.Add("@photo", SqlDbType.VarChar, 100, "photo");
                myAdapter.InsertCommand.Parameters.Add("@datecreated", SqlDbType.Date, 0, "datecreated");
                myAdapter.InsertCommand.Parameters.Add("@birthdate", SqlDbType.Date, 0, "birthdate");
                myAdapter.InsertCommand.Parameters.Add("@age", SqlDbType.BigInt, 0, "age");
                myAdapter.InsertCommand.Parameters.Add("@gender", SqlDbType.VarChar, 0, "gender");
                myAdapter.Update(myDataSet, "Users");
                myDataSet.Tables["users"].Rows[24].Delete();
                myAdapter.DeleteCommand = new SqlCommand("Delete From Users where iduser=@iduser", connection);
                myAdapter.DeleteCommand.Parameters.Add("@iduser", SqlDbType.BigInt, 0, "iduser").SourceVersion = DataRowVersion.Original;
                myAdapter.Update(myDataSet, "Users");
                myDataSet.Tables["Users"].Rows[3]["email"] = "raluca@mail.ru";
                myAdapter.UpdateCommand = new SqlCommand("UPDATE Users SET email=@email WHERE iduser=@iduser", connection);
                myAdapter.UpdateCommand.Parameters.Add("@email", SqlDbType.VarChar,30, "email");
                myAdapter.UpdateCommand.Parameters.Add("@iduser", SqlDbType.Int,0, "iduser").SourceVersion = DataRowVersion.Original;
                myAdapter.Update(myDataSet, "Users");

            }
        }
    }
}
