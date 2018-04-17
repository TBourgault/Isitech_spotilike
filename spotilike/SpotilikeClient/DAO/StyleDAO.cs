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
        private string connectionString = @"Data Source=PATH_TO_DB_FILE\...\file.ABC; Version=3; FailIfMissing=True; Foreign Keys=True;";

        public Style create(Style o)
        {
            throw new NotImplementedException(); // COMMENT, TEST & REMOVE.

            int success = -1;
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "INSERT INTO Style(name, position, isActive) VALUES (@Name, @Position, @IsActive)";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@Name", o.getName());
                    cmd.Parameters.AddWithValue("@Position", o.getPosition());
                    cmd.Parameters.AddWithValue("@IsActive", o.getIsActive());
                    try
                    {
                        success = cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        System.Console.WriteLine(e);

                    }
                }
                conn.Close();
            }
            if (success != -1)
            {
                return o;
            }
            else
            {
                return null;
            }
        }

        public Style delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Style> findAll()
        {
            throw new NotImplementedException();
        }

        public Style findById(int id)
        {
            throw new NotImplementedException();
        }

        public Style update(int id, Style o)
        {
            throw new NotImplementedException();
        }
    }
}
