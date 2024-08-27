using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Threading;
namespace PswdManager
{
    static class Program
    {
        // Mutex 名字，全局唯一
        static readonly Mutex mutex = new Mutex(true, "hsoFA15E64-2412-FB13-CCAC");
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                string selectSQL = "Data Source=pswdManager.db;Version=3;";
                using (var connection = new SQLiteConnection(selectSQL))
                {
                    connection.Open();
                    string createTable = "CREATE TABLE IF NOT EXISTS PASSWORD (" +
                        "Id INTEGER PRIMARY KEY AUTOINCREMENT," +
                        "Name Text," +
                        "Username Text,"+
                        "Website TEXT," +
                        "Password TEXT," +
                        "Comment TEXT" +
                        ")";
                    string dropTable = "drop table password";
                    using (var command = new SQLiteCommand(createTable, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                MessageBox.Show("不要运行超过一个啊啊啊啊");
            }
        }
    }
}
