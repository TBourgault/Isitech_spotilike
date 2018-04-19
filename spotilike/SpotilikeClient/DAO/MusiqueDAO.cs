using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SpotilikeClient.Models;

namespace SpotilikeClient.DAO
{
    class MusiqueDAO : IDAO<Musique>
    {
        private string connectionString = @"Data Source=C:\Users\thiba\Desktop\Isitech_spotilike\db_spotilike.db; Version=3; FailIfMissing=True; Foreign Keys=True;";

        public List<Musique> findAll()
        {
            List<Musique> musics = new List<Musique>();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Musique";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Musique m = new Musique();

                                m.setId(int.Parse(reader["id"].ToString()));
                                m.setTitle(reader["title"].ToString());
                                m.setDetails(reader["details"].ToString());
                                m.setDate(DateTime.Parse(reader["date"].ToString()));
                                m.setPath(reader["path"].ToString());
                                musics.Add(m);
                            }
                        }
                    }
                    conn.Close();
                }
            }
            catch (SQLiteException e)
            {
                e.GetBaseException();
            }

            return musics;
        }
    }
}
