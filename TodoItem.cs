
using System.Data.SqlClient;

public class DBProc
{
  public string Dbinquiry()
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
}

