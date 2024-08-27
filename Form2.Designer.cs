
namespace PswdManager
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.username1 = new System.Windows.Forms.TextBox();
            this.website1 = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.TextBox();
            this.comment1 = new System.Windows.Forms.TextBox();
            this.username2 = new System.Windows.Forms.Label();
            this.website2 = new System.Windows.Forms.Label();
            this.password2 = new System.Windows.Forms.Label();
            this.comments2 = new System.Windows.Forms.Label();
            this.confirmModify = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.name1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // username1
            // 
            this.username1.Location = new System.Drawing.Point(58, 63);
            this.username1.Name = "username1";
            this.username1.Size = new System.Drawing.Size(100, 21);
            this.username1.TabIndex = 0;
            this.username1.TextChanged += new System.EventHandler(this.username1_TextChanged);
            // 
            // website1
            // 
            this.website1.Location = new System.Drawing.Point(60, 36);
            this.website1.Name = "website1";
            this.website1.Size = new System.Drawing.Size(100, 21);
            this.website1.TabIndex = 1;
            // 
            // password1
            // 
            this.password1.Location = new System.Drawing.Point(60, 90);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(100, 21);
            this.password1.TabIndex = 2;
            // 
            // comment1
            // 
            this.comment1.Location = new System.Drawing.Point(58, 117);
            this.comment1.Name = "comment1";
            this.comment1.Size = new System.Drawing.Size(100, 21);
            this.comment1.TabIndex = 3;
            // 
            // username2
            // 
            this.username2.AutoSize = true;
            this.username2.Location = new System.Drawing.Point(11, 66);
            this.username2.Name = "username2";
            this.username2.Size = new System.Drawing.Size(41, 12);
            this.username2.TabIndex = 4;
            this.username2.Text = "用户名";
            this.username2.Click += new System.EventHandler(this.label1_Click);
            // 
            // website2
            // 
            this.website2.AutoSize = true;
            this.website2.Location = new System.Drawing.Point(13, 39);
            this.website2.Name = "website2";
            this.website2.Size = new System.Drawing.Size(29, 12);
            this.website2.TabIndex = 5;
            this.website2.Text = "网站";
            // 
            // password2
            // 
            this.password2.AutoSize = true;
            this.password2.Location = new System.Drawing.Point(10, 93);
            this.password2.Name = "password2";
            this.password2.Size = new System.Drawing.Size(29, 12);
            this.password2.TabIndex = 6;
            this.password2.Text = "密码";
            this.password2.Click += new System.EventHandler(this.password2_Click);
            // 
            // comments2
            // 
            this.comments2.AutoSize = true;
            this.comments2.Location = new System.Drawing.Point(11, 120);
            this.comments2.Name = "comments2";
            this.comments2.Size = new System.Drawing.Size(29, 12);
            this.comments2.TabIndex = 7;
            this.comments2.Text = "备注";
            // 
            // confirmModify
            // 
            this.confirmModify.Location = new System.Drawing.Point(12, 156);
            this.confirmModify.Name = "confirmModify";
            this.confirmModify.Size = new System.Drawing.Size(75, 23);
            this.confirmModify.TabIndex = 8;
            this.confirmModify.Text = "确认";
            this.confirmModify.UseVisualStyleBackColor = true;
            this.confirmModify.Click += new System.EventHandler(this.confirmModify_Click);
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(116, 156);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(75, 23);
            this.goBack.TabIndex = 9;
            this.goBack.Text = "返回";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(60, 6);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(100, 21);
            this.name1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "名字";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name1);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.confirmModify);
            this.Controls.Add(this.comments2);
            this.Controls.Add(this.password2);
            this.Controls.Add(this.website2);
            this.Controls.Add(this.username2);
            this.Controls.Add(this.comment1);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.website1);
            this.Controls.Add(this.username1);
            this.Name = "Form2";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username1;
        private System.Windows.Forms.TextBox website1;
        private System.Windows.Forms.TextBox password1;
        private System.Windows.Forms.TextBox comment1;
        private System.Windows.Forms.Label username2;
        private System.Windows.Forms.Label password2;
        private System.Windows.Forms.Label comments2;
        private System.Windows.Forms.Label website2;
        private System.Windows.Forms.Button confirmModify;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.Label label1;
    }
}