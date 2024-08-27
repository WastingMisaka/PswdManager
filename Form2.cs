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
    public partial class Form2 : Form
    {
        string selectSQL = "Data Source=pswdManager.db;Version=3;";
        string name,username,website,password,comment,id;
        string[] rawText = { "0", "name","website", "username", "password", "comments", "id" };
        // w,n,u,p,c,id;
        public Form2(string a,string b,string c,string d,string e,string id)
        {
            name = a;
            website = b;
            username = c;
            password = d;
            comment = e;
                
            this.id = id;
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            name1.Text = name;
            username1.Text = username;
            website1.Text = website;
            password1.Text = password;
            comment1.Text = comment;
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void password2_Click(object sender, EventArgs e)
        {

        }

        private void username1_TextChanged(object sender, EventArgs e)
        {

        }

        private void confirmModify_Click(object sender, EventArgs e)
        {
                using (SQLiteConnection connection = new SQLiteConnection(selectSQL))
                {
                    connection.Open();
                    string upd = "update password set name = @n, website = @w,username = @u, password = @p, comment = @c where id = @id";
                    using (SQLiteCommand command = new SQLiteCommand(upd, connection))
                    {
                        command.Parameters.AddWithValue("@n", name1.Text);
                        command.Parameters.AddWithValue("@w", website1.Text);
                        command.Parameters.AddWithValue("@u", username1.Text);
                        command.Parameters.AddWithValue("@p", password1.Text);
                        command.Parameters.AddWithValue("@c", comment1.Text);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("修改成功");
                        this.Close();
                    }
                }
        }
    }
}
