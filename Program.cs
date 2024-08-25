using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PswdManager
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            string selectSQL = "Data Source=pswdManager.db;Version=3;";
            using (var connection = new SQLiteConnection(selectSQL))
            {
                connection.Open();
                string createTable = "CREATE TABLE IF NOT EXISTS PASSWORD (" +
                    "Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    "Name Text," +
                    "Website TEXT," +
                    "Password TEXT," +
                    "Comments TEXT" +
                    ")";
                using (var command = new SQLiteCommand(createTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


        }
    }
}
