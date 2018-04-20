using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SpotilikeClient.Models;

namespace SpotilikeClient.DAO
{
    class AlbumDAO : IDAO<Album>
    {
        private string connectionString = @"Data Source=C:\Users\thiba\Desktop\Isitech_spotilike\db_spotilike.db; Version=3; FailIfMissing=True; Foreign Keys=True;";

        public List<Album> findAll()
        {
            List<Album> albums = new List<Album>();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Album";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Album a = new Album();
                                a.setId(int.Parse(reader["id"].ToString()));
                                a.setTitle(reader["title"].ToString());
                                a.setDuration(int.Parse(reader["duration"].ToString()));
                                a.setPublishedAt(DateTime.Parse(reader["publishedAt"].ToString()));
                                albums.Add(a);
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

            return albums;
        }

        public Album findById(int id)
        {
            Album album = new Album();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Album WHERE id = " + id;

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Album a = new Album();
                                a.setId(int.Parse(reader["id"].ToString()));
                                a.setTitle(reader["title"].ToString());
                                a.setDuration(int.Parse(reader["duration"].ToString()));
                                a.setPublishedAt(DateTime.Parse(reader["publishedAt"].ToString()));

                                album = a;
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

            return album;
        }
    }
}
