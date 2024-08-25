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
        string username,website,password,comment,id;
        string[] rawText = { "0", "website1", "username1", "password1", "comments1", "id" };
        // w,n,p,c,id;
        public Form2(string a,string b,string c,string d,string id)
        {
            website = a;
            username = b;
            password = c;
            comment = d;
                
            this.id = id;
            
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            username1.Text = username;
            website1.Text = website;
            password1.Text = password;
            comments1.Text = comment;
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
                    string upd = "update password set name = @n, website = @w, password = @p, comments = @c where id = @id";
                    using (SQLiteCommand command = new SQLiteCommand(upd, connection))
                    {
                        command.Parameters.AddWithValue("@n", username1.Text);
                        command.Parameters.AddWithValue("@w", website1.Text);
                        command.Parameters.AddWithValue("@p", password1.Text);
                        command.Parameters.AddWithValue("@c", comments1.Text);
                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                        MessageBox.Show("修改成功");
                        this.Close();
                    }
                }
        }
    }
}
