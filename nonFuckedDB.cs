using System;
using System.IO;
using Microsoft.Data.Sqlite;

namespace CTextCurrent
{
  public class Config
  {
      public SQLiteConnection sqlite_conn;
      public SQLiteCommand sqlite_cmd;
      public SQLiteDataReader sqlite_datareader;
    
      public Config(){}

      public void Connect(string dbName)
      {
           sqlite_conn = new SQLiteConnection("Data Source=" + dbName + ".db;Version=3;New=True;Compress=True;"); // TODO: CHECK DIFFERENCES
           sqlite_conn.Open();
           sqlite_cmd = sqlite_conn.CreateCommand();
       }
    
    public Object[] checkLogin(string Sql_command){
         var command = sqlite_conn.CreateCommand();
         command.CommandText = Sql_command;
      
         int count = 0;
         Object[] returnData = new Object[2]  //first element is boolean, second is username
         using(var reader = command.ExecuteReader()){
              while (reader.Read()){
                  returnData[1] = reader.GetString(0);
                  count = count + 1;
              }
          }
          returnData[0] = (count == 1);
          return returnData;
    }
    
   public void Execute(string query){
       var command = sqlite_conn.CreateCommand();
       command.CommandText = query;
       command.ExecuteNonQuery();
   }
   
  }
}
