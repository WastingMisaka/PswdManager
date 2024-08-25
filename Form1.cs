using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PswdManager
{
    public partial class Form1 : Form
    {
        string selectSQL = "Data Source=pswdManager.db;Version=3;";
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            
            using (var connection = new SQLiteConnection(selectSQL))
            {
                connection.Open();
                var command = new SQLiteCommand("select name,website,password,comments,id from password", connection);
                var adapter = new SQLiteDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);
                test.DataSource = table;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        /**
         * 新增密码 点击事件
         */
        private void AddPswd_Click(object sender, EventArgs e)
        {
            var websiteText = website.Text;
            var nameText = name.Text;
            var pswdText = pswd.Text;
            var commentText = comment.Text;

            if (websiteText == "" && nameText == ""){
                MessageBox.Show("网址和名称至少填写一个！");
            }
            else
            {
                using (var connection = new SQLiteConnection(selectSQL))
                {
                    connection.Open();
                    var command = new SQLiteCommand("insert into password (website,name,password,comments)" +
                        " values (@websiteText, @nameText, @pswdText, @commentText)", connection);
                    command.Parameters.AddWithValue("@websiteText", websiteText);
                    command.Parameters.AddWithValue("@nameText", nameText);
                    command.Parameters.AddWithValue("@pswdText", pswdText);
                    command.Parameters.AddWithValue("commentText", commentText);
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("添加成功");
                setTextBlank();
                LoadData();
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void website_TextChanged(object sender, EventArgs e)
        {

        }

        private void pswd_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchPswd_Click(object sender, EventArgs e)
        {
            string[] rawText = { "0", "website", "name", "password", "comments" };
            string[] text = { "0", website.Text, name.Text, pswd.Text,comment.Text };
            int cnt = 4;
            for (int i = 1; i <= 4; i++) if (text[i] == "") cnt--;
            if (cnt==0)
            {
                LoadData();
            }
            else
            {
                using (var connection = new SQLiteConnection(selectSQL))
                {
                    connection.Open();
                    String command = "select name,website,password,comments,id from password where ";
                    for(int i = 1; i <= 4; i++)
                    {
                        if (text[i] == "") continue;
                        else
                        {
                            command += rawText[i];
                            command += " like @";
                            command += rawText[i];
                            if (cnt != 1)
                                command += " and ";
                            cnt--;
                        }
                    }
                    
                    using(SQLiteDataAdapter adapter = new SQLiteDataAdapter(command, connection))
                    {
                        for(int i = 1; i <= 4; i++)
                        {
                            if (text[i] != "")
                            {
                                adapter.SelectCommand.Parameters.AddWithValue("@" + rawText[i], "%" + text[i] + "%");
                            }
                        }
                        // MessageBox.Show(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        test.DataSource = dataTable;
                    }
                }
            }
            setTextBlank();
        }

        private void deletePswd_Click(object sender, EventArgs e)
        {

        }
        private void setTextBlank()
        {
            website.Text = "";
            name.Text = "";
            pswd.Text = "";
            comment.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deletePswd_Click_1(object sender, EventArgs e)
        {
            int cnt = 0;
            // 检查是否有选中的行
            if ((cnt = test.SelectedRows.Count) > 0)
            {
                for (int i = 0; i < cnt; i++)
                {
                    int id = Convert.ToInt32(test.SelectedRows[i].Cells["Id"].Value);
                    using (SQLiteConnection connection = new SQLiteConnection(selectSQL))
                    {
                        connection.Open();
                        string del = "delete from password where id = @id";
                        using (SQLiteCommand command = new SQLiteCommand(del, connection))
                        {
                            command.Parameters.AddWithValue("@id", id);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                MessageBox.Show("删除成功");
                LoadData();
            }
            else
            {
                MessageBox.Show("没有选中的行pup");
            }
        }
    }
}
