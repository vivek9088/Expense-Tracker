namespace Monthly_Expenses
{
    partial class Monthly_Expense_Tracker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.expdate = new System.Windows.Forms.DateTimePicker();
            this.ContName = new System.Windows.Forms.ComboBox();
            this.expamt = new System.Windows.Forms.TextBox();
            this.sharing = new System.Windows.Forms.CheckedListBox();
            this.Generate_Expense = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contributor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shared_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.expdetails = new System.Windows.Forms.TextBox();
            this.Add_Expense = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.summary = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // expdate
            // 
            this.expdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expdate.Location = new System.Drawing.Point(163, 31);
            this.expdate.Name = "expdate";
            this.expdate.Size = new System.Drawing.Size(200, 27);
            this.expdate.TabIndex = 0;
            // 
            // ContName
            // 
            this.ContName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContName.FormattingEnabled = true;
            this.ContName.Items.AddRange(new object[] {
            "--Select Contributor--"});
            this.ContName.Location = new System.Drawing.Point(165, 85);
            this.ContName.Name = "ContName";
            this.ContName.Size = new System.Drawing.Size(198, 27);
            this.ContName.TabIndex = 1;
            this.ContName.Text = "--Select Contributor--";
            this.ContName.SelectedIndexChanged += new System.EventHandler(this.ContName_SelectedIndexChanged);
            // 
            // expamt
            // 
            this.expamt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expamt.Location = new System.Drawing.Point(165, 201);
            this.expamt.Name = "expamt";
            this.expamt.Size = new System.Drawing.Size(145, 27);
            this.expamt.TabIndex = 3;
            this.expamt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expamt_KeyPress);
            // 
            // sharing
            // 
            this.sharing.CausesValidation = false;
            this.sharing.CheckOnClick = true;
            this.sharing.Enabled = false;
            this.sharing.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sharing.FormattingEnabled = true;
            this.sharing.Location = new System.Drawing.Point(391, 67);
            this.sharing.Name = "sharing";
            this.sharing.ScrollAlwaysVisible = true;
            this.sharing.Size = new System.Drawing.Size(146, 180);
            this.sharing.TabIndex = 4;
            // 
            // Generate_Expense
            // 
            this.Generate_Expense.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_Expense.Location = new System.Drawing.Point(598, 124);
            this.Generate_Expense.Name = "Generate_Expense";
            this.Generate_Expense.Size = new System.Drawing.Size(113, 34);
            this.Generate_Expense.TabIndex = 6;
            this.Generate_Expense.Text = "Per Capita";
            this.Generate_Expense.UseVisualStyleBackColor = true;
            this.Generate_Expense.Click += new System.EventHandler(this.Generate_Expense_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(623, 168);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(60, 34);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contirbutor Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(387, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Shared Among";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(820, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "fsfs";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Contributor,
            this.Amount,
            this.Shared_by,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(30, 282);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(570, 236);
            this.dataGridView1.TabIndex = 11;
            // 
            // Item
            // 
            this.Item.HeaderText = "Expense Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            // 
            // Contributor
            // 
            this.Contributor.HeaderText = "Contributor";
            this.Contributor.Name = "Contributor";
            this.Contributor.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Shared_by
            // 
            this.Shared_by.HeaderText = "Shared By";
            this.Shared_by.Name = "Shared_by";
            this.Shared_by.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Monthly Expense Report";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Expense Item";
            // 
            // expdetails
            // 
            this.expdetails.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expdetails.Location = new System.Drawing.Point(165, 130);
            this.expdetails.MaxLength = 200;
            this.expdetails.Multiline = true;
            this.expdetails.Name = "expdetails";
            this.expdetails.Size = new System.Drawing.Size(168, 49);
            this.expdetails.TabIndex = 2;
            // 
            // Add_Expense
            // 
            this.Add_Expense.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Expense.Location = new System.Drawing.Point(614, 80);
            this.Add_Expense.Name = "Add_Expense";
            this.Add_Expense.Size = new System.Drawing.Size(78, 34);
            this.Add_Expense.TabIndex = 5;
            this.Add_Expense.Text = "Add Expense";
            this.Add_Expense.UseVisualStyleBackColor = true;
            this.Add_Expense.Click += new System.EventHandler(this.Add_Expense_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(637, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Expense Summary";
            // 
            // summary
            // 
            this.summary.AutoSize = true;
            this.summary.Location = new System.Drawing.Point(637, 301);
            this.summary.Name = "summary";
            this.summary.Size = new System.Drawing.Size(0, 13);
            this.summary.TabIndex = 17;
            // 
            // Monthly_Expense_Tracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 561);
            this.Controls.Add(this.summary);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Add_Expense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.expdetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Generate_Expense);
            this.Controls.Add(this.sharing);
            this.Controls.Add(this.expamt);
            this.Controls.Add(this.ContName);
            this.Controls.Add(this.expdate);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Monthly_Expense_Tracker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Monthly Expense Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker expdate;
        private System.Windows.Forms.ComboBox ContName;
        private System.Windows.Forms.CheckedListBox sharing;
        private System.Windows.Forms.Button Generate_Expense;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox expdetails;
        private System.Windows.Forms.Button Add_Expense;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label summary;
        private System.Windows.Forms.TextBox expamt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contributor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shared_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

