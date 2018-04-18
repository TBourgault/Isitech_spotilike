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
        // TODO: Modifier la variable Data Source dans la connectionString
        private string connectionString = @"Data Source=PATH_TO_DB_FILE\...\file.ABC; Version=3; FailIfMissing=True; Foreign Keys=True;";

        public Style create(Style o)
        {
            //throw new NotImplementedException();

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

        public void delete(int id)
        {
            //throw new NotImplementedException();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(conn))
                {
                    cmd.CommandText = "";
                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@Truc", "truc");
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException e)
                    {
                        System.Console.WriteLine(e);
                    }
                }
                conn.Close();
            }
        }

        public List<Style> findAll()
        {
            //throw new NotImplementedException();
            List<Style> styles = new List<Style>();
            int success = -1;
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string sql = "SELECT * FROM style";
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, conn))
                    {
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Style s = new Style();
                                s.setId(int.Parse(reader["id"].ToString()));
                                s.setName(reader["name"].ToString());
                                s.setPosition(int.Parse(reader["position"].ToString()));
                                s.setIsActive(int.Parse(reader["isActive"].ToString()));
                            }
                        }
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
                    return styles;
                }
                else
                {
                    return null;
                }
            }
        }

        public Style findById(int id)
        {
            //throw new NotImplementedException();

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

        public Style update(int id, Style o)
        {
            //throw new NotImplementedException();

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
    }
}
