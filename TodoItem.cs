
using System.Data.SqlClient;
using System;
using Npgsql;

public class DBProc
{
  public string Dbinquiry1()
    { 
     /*SqlConnection conn=new SqlConnection("server=ss-dfc-pbi.database.windows.net;Database=dw-dfc-pbi;uid=dfc\\chixxl;integrated security=SSPI;");
      conn.Open();
      //string sql1 ="update tony_test set strsql='abc' where strsql='1'";
      //SqlCommand Io_cmd1=new SqlCommand(sql1,conn);d
      //Io_cmd1.ExecuteNonQuery();
      string sql ="SELECT TOP (1000) * FROM [S4].[USR21]";
      SqlCommand Io_cmd=new SqlCommand(sql,conn);
      SqlDataReader read=Io_cmd.ExecuteReader();
      string rs1 = "abc";
      while (read.Read())
      { 
       rs1 = read["Bname"].ToString();
          Console.WriteLine(rs1);
      }
      conn.Close();*/ 
      string rs1 = "abc1234";
      return rs1;
     }

     public string Dbinquiry()
    { 

      // Obtain connection string information from the portal
        //
          string Host = "blazorapps-server.postgres.database.azure.com";
          string User = "jwihtfprvs";
          string DBname = "postgres";
          string Password = "8Y028X0G4W718KCK$";
          string Port = "5432";

            //
            string connString =
                String.Format(
                    "Server={0};Username={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);


            using (var conn = new NpgsqlConnection(connString))

            {
                Console.Out.WriteLine("Opening connection");
                conn.Open();

                using (var command = new NpgsqlCommand("DROP TABLE IF EXISTS inventory", conn))
                {
                    command.ExecuteNonQuery();
                    Console.Out.WriteLine("Finished dropping table (if existed)");

                }

                using (var command = new NpgsqlCommand("CREATE TABLE inventory(id serial PRIMARY KEY, name VARCHAR(50), quantity INTEGER)", conn))
                {
                    command.ExecuteNonQuery();
                    Console.Out.WriteLine("Finished creating table");
                }

                using (var command = new NpgsqlCommand("INSERT INTO inventory (name, quantity) VALUES (@n1, @q1), (@n2, @q2), (@n3, @q3)", conn))
                {
                    command.Parameters.AddWithValue("n1", "banana");
                    command.Parameters.AddWithValue("q1", 150);
                    command.Parameters.AddWithValue("n2", "orange");
                    command.Parameters.AddWithValue("q2", 154);
                    command.Parameters.AddWithValue("n3", "apple");
                    command.Parameters.AddWithValue("q3", 100);

                    int nRows = command.ExecuteNonQuery();
                    Console.Out.WriteLine(String.Format("Number of rows inserted={0}", nRows));
                }
            }

            Console.WriteLine("Press RETURN to exit");
            Console.ReadLine();
            return "12345678";
}
     }


