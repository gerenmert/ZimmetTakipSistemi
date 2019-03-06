using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip
{
    public class Connection
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-8KDJFLK;Initial Catalog=StokTakipDatabase;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
        // public static readonly SqlConnection STR = new SqlConnection(@"Data Source=DESKTOP-8KDJFLK;Initial Catalog=StokTakipDatabase;Integrated Security=True");
        
    }
}
