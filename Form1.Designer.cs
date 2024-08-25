
namespace PswdManager
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.name = new System.Windows.Forms.TextBox();
            this.website = new System.Windows.Forms.TextBox();
            this.pswd = new System.Windows.Forms.TextBox();
            this.AddPswd = new System.Windows.Forms.Button();
            this.comment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.DataGridView();
            this.SearchPswd = new System.Windows.Forms.Button();
            this.deletePswd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.test)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AccessibleDescription = "";
            this.name.AccessibleName = "";
            this.name.Location = new System.Drawing.Point(49, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 21);
            this.name.TabIndex = 0;
            this.name.Tag = "";
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // website
            // 
            this.website.Location = new System.Drawing.Point(49, 39);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(100, 21);
            this.website.TabIndex = 1;
            this.website.TextChanged += new System.EventHandler(this.website_TextChanged);
            // 
            // pswd
            // 
            this.pswd.Location = new System.Drawing.Point(49, 66);
            this.pswd.Name = "pswd";
            this.pswd.Size = new System.Drawing.Size(100, 21);
            this.pswd.TabIndex = 2;
            this.pswd.TextChanged += new System.EventHandler(this.pswd_TextChanged);
            // 
            // AddPswd
            // 
            this.AddPswd.Location = new System.Drawing.Point(12, 123);
            this.AddPswd.Name = "AddPswd";
            this.AddPswd.Size = new System.Drawing.Size(75, 23);
            this.AddPswd.TabIndex = 3;
            this.AddPswd.Text = "新增密码";
            this.AddPswd.UseVisualStyleBackColor = true;
            this.AddPswd.Click += new System.EventHandler(this.AddPswd_Click);
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(49, 93);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(100, 21);
            this.comment.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "名称";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "网址";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "密码";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "备注";
            // 
            // test
            // 
            this.test.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.test.Location = new System.Drawing.Point(389, 15);
            this.test.Name = "test";
            this.test.RowTemplate.Height = 23;
            this.test.Size = new System.Drawing.Size(358, 267);
            this.test.TabIndex = 9;
            this.test.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SearchPswd
            // 
            this.SearchPswd.Location = new System.Drawing.Point(106, 123);
            this.SearchPswd.Name = "SearchPswd";
            this.SearchPswd.Size = new System.Drawing.Size(75, 23);
            this.SearchPswd.TabIndex = 10;
            this.SearchPswd.Text = "查找密码";
            this.SearchPswd.UseVisualStyleBackColor = true;
            this.SearchPswd.Click += new System.EventHandler(this.SearchPswd_Click);
            // 
            // deletePswd
            // 
            this.deletePswd.Location = new System.Drawing.Point(12, 164);
            this.deletePswd.Name = "deletePswd";
            this.deletePswd.Size = new System.Drawing.Size(75, 23);
            this.deletePswd.TabIndex = 11;
            this.deletePswd.Text = "删除密码";
            this.deletePswd.UseVisualStyleBackColor = true;
            this.deletePswd.Click += new System.EventHandler(this.deletePswd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deletePswd);
            this.Controls.Add(this.SearchPswd);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comment);
            this.Controls.Add(this.AddPswd);
            this.Controls.Add(this.pswd);
            this.Controls.Add(this.website);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.test)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox website;
        private System.Windows.Forms.TextBox pswd;
        private System.Windows.Forms.Button AddPswd;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView test;
        private System.Windows.Forms.Button SearchPswd;
        private System.Windows.Forms.Button deletePswd;
    }
}

