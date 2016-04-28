using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelHeroesLabLibrary
{
    public class Villian
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<Power> Powers { get; set; }

        public static List<Villian> GetAllVillians()
        {
            SqliteDbLoader sqlite = new SqliteDbLoader();
            return sqlite.GetAllVillians();
        }
    }
}
