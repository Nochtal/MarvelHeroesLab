using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace MarvelHeroesLabLibrary
{
    public class SqliteDbLoader
    {
        private SQLiteConnection _connection;

        public SqliteDbLoader(string connectionString)
        {
            _connection = new SQLiteConnection(connectionString);
            _connection.Open();
        }

        public DataSet ExecuteSql(string sql)
        {
            var db = new SQLiteDataAdapter(sql, _connection);
            var dataSet = new DataSet();
            db.Fill(dataSet);
            return dataSet;
        }

        public List<Villain> GetAllVillians()
        {
            var sql = "SELECT * FROM Villain";
            var dataTable = ExecuteSql(sql).Tables[0];
            return (from DataRow row in dataTable.Rows
                select new Villain
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = (string) row["Name"],
                    Description = (string) row["Description"],
                    Powers = GetAllPowersForVillian(Convert.ToInt32(row["Id"]))
                }).ToList();
        }

        private List<Power> GetAllPowersForVillian(int vId)
        {
            var sql = string.Format(
                    "SELECT p.* FROM Power p JOIN PowerToVillain ptv ON p.Id = ptv.PowerId WHERE ptv.VillainId = {0}", vId);
            var dataTable = ExecuteSql(sql).Tables[0];
            return (from DataRow row in dataTable.Rows
                select new Power
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = (string) row["Name"],
                    Description = (string) row["Description"]
                }).ToList();
        }

        public List<Hero> GetAllHeroes()
        {
            var sql = "SELECT * FROM Hero";
            var dataTable = ExecuteSql(sql).Tables[0];
            return (from DataRow row in dataTable.Rows
                    select new Hero
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = (string)row["Name"],
                        Description = (string)row["Description"],
                        Powers = GetAllPowersForHero(Convert.ToInt32(row["Id"]))
                    }).ToList();
        }

        private List<Power> GetAllPowersForHero(int hId)
        {
            var sql = string.Format(
                    "SELECT p.* FROM Power p JOIN PowerToHero pth ON p.Id = pth.PowerId WHERE pth.HeroId = {0}", hId);
            var dataTable = ExecuteSql(sql).Tables[0];
            return (from DataRow row in dataTable.Rows
                    select new Power
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = (string)row["Name"],
                        Description = (string)row["Description"]
                    }).ToList();
        }
    }
}
