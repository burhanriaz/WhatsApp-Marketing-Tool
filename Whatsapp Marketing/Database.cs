using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace Whatsapp_Marketing
{
    internal class Database
    {
        SQLiteConnection con;
        SQLiteCommand cmd;

        public static Database db;

        public static Database get_db()
        {
            if(db == null)
            {
                db=new Database();
                return db;
            }
            else
            {
                return db;
            }
        }

        public Database()
        {
            String path=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"\\WhatsApp_Markeeting";
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path += "\\Database.db";
            
            if(!File.Exists(path))
            {
                File.Copy("Database.db", path);
            }
            //path = "Database.db";
            String conString = $"Data Source={path};Version=3;";



            con=new SQLiteConnection(conString);
            // Insert Table Creation Queries  :: try Catch
            //executeQuery("DELETE FROM `MyNumbers`");


        }

        public Boolean executeQuery(String query)
        {
            
            cmd=new SQLiteCommand(query,con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {   
                con.Close();
                return false;
            }
        }

        public List<MyNumbers> get_Numbers()
        {
            List<MyNumbers> list = new List<MyNumbers>();   
            String query = "Select `id`,`number` from `MyNumbers`";
            cmd = new SQLiteCommand(query, con);
            try
            {
                con.Open();
                using(SQLiteDataReader reader=cmd.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        list.Add(new MyNumbers()
                        {
                            id = Convert.ToInt32(reader.GetValue(0)),
                             number=Convert.ToString(reader.GetValue(1))
                        });
                    }
                }
                con.Close();
            }
            catch
            {
                con.Close();
            }
            return list;
        }
        public List<MyNumbers> get_CountryCode()
        {
            List<MyNumbers> list = new List<MyNumbers>();
            String query = "Select `ID`,`CountryName`,`Code` from `CountryTable`";
            cmd = new SQLiteCommand(query, con);
            try
            {
                con.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MyNumbers()
                        {
                            ID = Convert.ToInt32(reader.GetValue(0)),
                            CountryName = Convert.ToString(reader.GetValue(1)),
                            Code = Convert.ToInt32(reader.GetValue(2)),

                        });
                    }
                    
                }
                con.Close();
            }
            catch
            {
                con.Close();
            }
            
          
            return list;
        }
    }
}
