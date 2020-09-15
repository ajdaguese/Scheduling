using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Scheduling
{
    class DBAccess
    {
        public DBAccess()
        { 
        
        }
        public DataTable getTable(string tableName)
        {
            SQLiteDataAdapter adpt;
            DataTable dt = new DataTable();
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                adpt = new SQLiteDataAdapter("SELECT * FROM " + tableName, cnn);
                adpt.Fill(dt);
                cnn.Close();
            }
            return dt;
        }
        //Accepts anything implementing the interface TableEntry which will all have a createInsertQuery function
        public void addEntry(TableEntry toAdd)
        {
            using (SQLiteConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                SQLiteCommand cmd = new SQLiteCommand(toAdd.getInsertQuery(), cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
        }

            private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}

