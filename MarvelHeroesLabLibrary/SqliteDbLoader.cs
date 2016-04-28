using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace MarvelHeroesLabLibrary
{
    public class SqliteDbLoader
    {
        public SqliteDbLoader()
        {

        }

        public List<Villian> GetAllVillians()
        {
            var villians = new List<Villian>();
            using (System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection("Data Source=.\\Villians.db"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM Villian",connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var villian = new Villian();
                    villian.Id = (int)reader["Id"];
                    villian.Name = (string)reader["Name"];
                    villian.Description = (string)reader["Description"];
                    villian.Powers = GetAllPowersForVillian(villian.Id);
                    villians.Add(villian);
                }
            }
            return villians;
        }

        private List<Power> GetAllPowersForVillian(int vId)
        {
            var powers = new List<Power>();
            using (System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection("Data Source=.\\Villians.db"))
            {
                connection.Open();
                SQLiteCommand command = new SQLiteCommand(string.Format("select p.* from Power p join powertovillian ptv ON p.Id = ptv.Id WHERE ptv.VillianId = {0}", vId), connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var power = new Power();
                    power.Id = (int)reader["Id"];
                    power.Name = (string)reader["Name"];
                    power.Description = (string)reader["Description"];
                    powers.Add(power);
                }
            }
            return powers;
        }
    }
}
