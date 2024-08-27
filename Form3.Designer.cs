
namespace PswdManager
{
    partial class Form3
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
            this.LoadedTable = new System.Windows.Forms.DataGridView();
            this.LoadConfirm = new System.Windows.Forms.Button();
            this.DeleteRow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoadedTable)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadedTable
            // 
            this.LoadedTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LoadedTable.Location = new System.Drawing.Point(234, 12);
            this.LoadedTable.Name = "LoadedTable";
            this.LoadedTable.RowTemplate.Height = 23;
            this.LoadedTable.Size = new System.Drawing.Size(554, 426);
            this.LoadedTable.TabIndex = 10;
            this.LoadedTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.test_CellContentClick);
            // 
            // LoadConfirm
            // 
            this.LoadConfirm.Location = new System.Drawing.Point(12, 85);
            this.LoadConfirm.Name = "LoadConfirm";
            this.LoadConfirm.Size = new System.Drawing.Size(75, 23);
            this.LoadConfirm.TabIndex = 11;
            this.LoadConfirm.Text = "确认导入";
            this.LoadConfirm.UseVisualStyleBackColor = true;
            this.LoadConfirm.Click += new System.EventHandler(this.LoadConfirm_Click);
            // 
            // DeleteRow
            // 
            this.DeleteRow.Location = new System.Drawing.Point(113, 85);
            this.DeleteRow.Name = "DeleteRow";
            this.DeleteRow.Size = new System.Drawing.Size(75, 23);
            this.DeleteRow.TabIndex = 12;
            this.DeleteRow.Text = "删除选中列";
            this.DeleteRow.UseVisualStyleBackColor = true;
            this.DeleteRow.Click += new System.EventHandler(this.DeleteRow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "可以在表中添加备注";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeleteRow);
            this.Controls.Add(this.LoadConfirm);
            this.Controls.Add(this.LoadedTable);
            this.Name = "Form3";
            this.Text = "导入文件";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoadedTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView LoadedTable;
        private System.Windows.Forms.Button LoadConfirm;
        private System.Windows.Forms.Button DeleteRow;
        private System.Windows.Forms.Label label1;
    }
}