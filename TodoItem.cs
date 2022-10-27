
using System.Data.SqlClient;

public class DBProc
{
  public string Dbinquiry()
    { 
     /*SqlConnection conn=new SqlConnection("server=PADWPD2;Database=PYPTSDB;uid=dfc\\chixxl;integrated security=SSPI;");
      conn.Open();
      string sql1 ="update tony_test set strsql='abc' where strsql='1'";
      SqlCommand Io_cmd1=new SqlCommand(sql1,conn);
      Io_cmd1.ExecuteNonQuery();
      string sql ="select * from PT_Task";
      SqlCommand Io_cmd=new SqlCommand(sql,conn);
      SqlDataReader read=Io_cmd.ExecuteReader();
      string rs1 = "abc";
      while (read.Read())
      { 
       rs1 = read["TaskName"].ToString();
          Console.WriteLine(rs1);
      }
      conn.Close(); */
      string rs1 = "abc";
      return rs1;
     }
}

