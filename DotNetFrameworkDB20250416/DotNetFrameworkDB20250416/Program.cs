using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Configuration;

namespace DotNetFrameworkDB20250416 {
    internal class Program {
        static void Main(string[] args) {
            string provider = ConfigurationManager.AppSettings["provider"];
            string connectionString = ConfigurationManager.AppSettings["connectionString"];
            // let's establish a connection
            DbProviderFactory factory = DbProviderFactories.GetFactory(provider); // Sql server specific
            using (DbConnection conn = factory.CreateConnection()) {
                if (conn == null) {
                    Console.WriteLine("Could not connect to database server.");
                    return;
                }
                conn.ConnectionString = connectionString;
                conn.Open();
                // now our program has the abiltiy to talk with the database.
                // but it needs a megaphone - DbCommand
                DbCommand cmd = conn.CreateCommand();
                // set the SQL we want cmd to communicate to the server
                cmd.CommandText = "select * from Products";
                // use a DbDataReader to rifle through the returned results
                using (DbDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        Console.WriteLine($"{reader["Id"]}\t{reader["Name"]}\t{reader["Description"]}");
                    }
                }
                string id, name, description;
                Console.Write("Enter id for new cereal: ");
                id = Console.ReadLine();
                Console.Write("Enter name for new cereal: ");
                name = Console.ReadLine();
                Console.Write("Enter description for new cereal: ");
                description = Console.ReadLine();
                cmd.CommandText = $"insert into Products (Id, Name, Description) values ('{id}','{name}','{description}')";
                int insertCount = cmd.ExecuteNonQuery();
                if (insertCount > 0) {
                    Console.WriteLine("The new record was added.");
                } else {
                    Console.WriteLine("The new record was not added.");
                }
            }
        }
    }
}
