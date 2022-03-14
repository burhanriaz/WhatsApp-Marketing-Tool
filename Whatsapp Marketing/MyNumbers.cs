using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Whatsapp_Marketing
{
    internal class MyNumbers
    {

        public int id { get; set; }
        public String number { get; set; }
        public int ID { get; set; }
        public String CountryName { get; set; }
        public int Code { get; set; }

        public Boolean Save()
        {
            if(Handler.myNumbersList.Find(x=> x.number == this.number)==null)
            {
                return Database.get_db().executeQuery($"INSERT INTO `MyNumbers` (`number`) VALUES ('{this.number}')");
            }
            else
            {
                return false;
            }
            
        }

        public static void Load()
        {
            Handler.myNumbersList=Database.get_db().get_Numbers();
            Handler.myCountryList = Database.get_db().get_CountryCode();
          


        }



        public static DataTable get_Datatable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Number", typeof(String));
            foreach (var item in Handler.myNumbersList)
            {
                dt.Rows.Add(item.id, item.number);
            }
            return dt;

        }

      

        public static void Clear()
        {
            Database.get_db().executeQuery("DELETE FROM `MyNumbers`");
        }

    }
}
