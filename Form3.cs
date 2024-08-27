using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
namespace PswdManager
{
    
    public partial class Form3 : Form
    {
        string selectSQL = "Data Source=pswdManager.db;Version=3;";
        string[] column_text = { "0", "name", "website", "username", "password", "comment" };
        string path;
        DataTable dataTable = new DataTable();
        public Form3(string path)
        {
            this.path = path;
            InitializeComponent();
        }

        private void test_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private DataTable LoadLoadedData(string path)
        {
            
            using (StreamReader reader = new StreamReader(path))
            {
                bool firstRow = true;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    if (firstRow)
                    {
                        for(int i = 1; i <= 5; i++)
                        {
                            dataTable.Columns.Add(column_text[i]);
                        }
                        firstRow = false;
                    }
                    else
                    {
                        dataTable.Rows.Add(values);
                    }
                }
            }
            return dataTable;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadedTable.DataSource = LoadLoadedData(path);

        }

        private void LoadConfirm_Click(object sender, EventArgs e)
        {
            string[] table_text = new string[15];
            int tot = LoadedTable.RowCount;
            for(int i = 0; i < tot-1; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    // 把值赋给 table_text
                    table_text[j] = (string)LoadedTable.Rows[i].Cells[j].Value;
                }
                using (var connection = new SQLiteConnection(selectSQL))
                {
                    connection.Open();
                    var command = new SQLiteCommand("insert into password (website,name,username,password,comment)" +
                        " values (@websiteText, @nameText,@usernameText, @passwordText, @commentText)", connection);
                    for(int j = 0; j < 5; j++)
                    {
                        string ll = "@" + column_text[j+1] + "Text";
                        command.Parameters.AddWithValue(ll, table_text[j]);
                    }
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("添加成功");
            this.Close();
        }
        // TODO 删除了空行会报错
        private void DeleteRow_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            // 检查是否有选中的行
            if ((cnt = LoadedTable.SelectedRows.Count) > 0)
            {
                for(int i = cnt - 1; i >= 0; i--)
                {
                    if(!LoadedTable.SelectedRows[i].IsNewRow)
                    LoadedTable.Rows.RemoveAt(LoadedTable.SelectedRows[i].Index);
                    else
                    {
                        MessageBox.Show("未填写的新行不能删除");
                    }
                }
                MessageBox.Show("删除成功");
            }
            else
            {
                MessageBox.Show("没有选中的行pup");
            }
        }
    }
}
