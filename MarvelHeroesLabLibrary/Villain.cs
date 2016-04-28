using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelHeroesLabLibrary
{
    public class Villain : Person
    {
        public List<Power> Powers { get; set; }

        public static List<Villain> GetAllVillians()
        {
            SqliteDbLoader sqlite = new SqliteDbLoader(
                ConfigurationManager.ConnectionStrings["MarvelDbConnectionString"].ConnectionString);
            return sqlite.GetAllVillians();
        }
    }
}
