using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OkulOtomasyon
{
    class sqlbaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-8BVM4NR\SQLEXPRESS;Initial Catalog=dbo.okulOtomasyon;Integrated Security=True;Trust Server Certificate=True");
            baglan.Open();
            return baglan;

        }
    }
}
