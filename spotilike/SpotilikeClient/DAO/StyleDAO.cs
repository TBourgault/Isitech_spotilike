using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SpotilikeClient.Models;

namespace SpotilikeClient.DAO
{
    class StyleDAO : IDAO<Style>
    {
        private string connectionString = @"Data Source=C:\Users\thiba\Desktop\Isitech_spotilike\db_spotilike.db; Version=3; FailIfMissing=True; Foreign Keys=True;";

        public List<Style> findAll()
        {
            List<Style> styles = new List<Style>();
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Style";

                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Style s = new Style();
                                s.setId(int.Parse(reader["id"].ToString()));
                                s.setName(reader["nom"].ToString());
                                s.setPosition(int.Parse(reader["position"].ToString()));
                                s.setIsActive(bool.Parse(reader["isActive"].ToString()));

                                styles.Add(s);
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

            return styles;
        }

        public Style findById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
