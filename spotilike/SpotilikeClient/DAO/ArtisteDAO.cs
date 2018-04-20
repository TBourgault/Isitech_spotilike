using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SpotilikeClient.Models;

namespace SpotilikeClient.DAO
{
    class ArtisteDAO : IDAO<Artiste>
    {
        private string connectionString = @"Data Source=C:\Users\thiba\Desktop\Isitech_spotilike\db_spotilike.db; Version=3; FailIfMissing=True; Foreign Keys=True;";

        public List<Artiste> findAll()
        {
            List<Artiste> artistes = new List<Artiste>();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Artiste";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Artiste a = new Artiste();
                                a.setId(int.Parse(reader["id"].ToString()));
                                a.setFirstName(reader["first_name"].ToString());
                                a.setLastName(reader["last_name"].ToString());
                                a.setIsGroup(bool.Parse(reader["isGroup"].ToString()));
                                a.setCountry(reader["country"].ToString());
                                a.setCreatedAt(DateTime.Parse(reader["created_at"].ToString()));
                                a.setGender(reader["gender"].ToString());

                                artistes.Add(a);
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

            return artistes;
        }

        public Artiste findById(int id)
        {
            Artiste artiste = new Artiste();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Artiste WHERE id = " + id;

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Artiste a = new Artiste();
                                a.setId(int.Parse(reader["id"].ToString()));
                                a.setFirstName(reader["first_name"].ToString());
                                a.setLastName(reader["last_name"].ToString());
                                bool isGroup = false;
                                if(reader["isGroup"].ToString().Equals("0"))
                                {
                                    isGroup = false;
                                } else
                                {
                                    isGroup = true;
                                }
                                a.setIsGroup(isGroup);
                                a.setCountry(reader["country"].ToString());
                                a.setCreatedAt(DateTime.Parse(reader["created_at"].ToString()));
                                a.setGender(reader["gender"].ToString());

                                artiste = a;
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

            return artiste;
        }
    }
}
