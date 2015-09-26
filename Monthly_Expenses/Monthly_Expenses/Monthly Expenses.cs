using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Monthly_Expenses
{
    public partial class Monthly_Expense_Tracker : Form
    {
        bool flag = false;
        string summary_val = "";// conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ExpenseDB.accdb;Persist Security Info=True";
        string[] contributors = {"RamMohan", "Sanker", "Senthil", "Prashanth","Mari"};

        public Monthly_Expense_Tracker()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int usrcnt = ContName.Items.Count;
            
            ReadUsers(contributors);
            
            this.ControlBox = false;
            
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

      public void ReadUsers(string[] contList)
        {
            //String tableName="Users",query = String.Format("select * from [{0}]",tableName);
            
          int chk_limit = sharing.Items.Count;
          
          //gets connection string from the settings file
          /*  OleDbConnection conn = new OleDbConnection(conString);
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataReader dr;

            try
            {
                //Open Database Connection
                conn.Open();
                
                dr = cmd.ExecuteReader();
                
                if (!dr.HasRows)
                {
                    MessageBox.Show("No Users exist. Please Add Contributors", "User Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {*/
                    ContName.Items.Clear();
                    ContName.Items.Add("--Select Contributor--");

                    //while (dr.Read())
                    for(int listIdx=0;listIdx<contList.Length;listIdx++)
                    {
                        /*ContName.Items.Add(dr.GetString(1));
                        sharing.Items.Insert(chk_limit,dr.GetString(1));
                        sharing.SetItemCheckState(chk_limit, CheckState.Unchecked);
                         */
                        ContName.Items.Add(contList[listIdx]);
                        sharing.Items.Insert(chk_limit,contList[listIdx]);
                        sharing.SetItemCheckState(chk_limit, CheckState.Unchecked);
                    }
               /* }
            }
            catch (OleDbException exp)
            {
                MessageBox.Show("Database Error: Could not connect to Database","Connect Error");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }*/
        }
        
       

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                Application.Exit();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            expdate.Value = DateTime.Now.Date;
            ContName.SelectedIndex = 0;
            expdetails.Text = "";
            expamt.Text = "";

            //Clear all items in checklistbox
            if (!flag)
            {
                Create_CheckBox(sender, e);
            }

            summary.Text = " ";

        }
        private void Create_CheckBox(object sender, EventArgs e)
        {
            
            //First Remove All items from Checkboxlist
            int lastIndex = sharing.Items.Count - 1;
            for (int i = lastIndex; i >= 0; i--)
            {
                if (sharing.GetItemCheckState(i) == CheckState.Checked || sharing.GetItemCheckState(i) == CheckState.Unchecked)
                {
                    sharing.Items.RemoveAt(i);
                }
            }
            
            //Create New checkboxlist based on items from combobox
            for (int i=1,indx=0; i < ContName.Items.Count; i++,indx++)
            {
                sharing.Items.Insert(indx,ContName.Items[i]);
            }

            flag = true; //clear must be disabled once cleared. No twice action allowed without any user action
        }
        private void ContName_SelectedIndexChanged(object sender, EventArgs e)
        {
            flag = false; // Clear must be enabled on user action with combobox again
            
            sharing.Enabled = true;
            
           //change the state of each checkboxlist to unchecked
            for (int i = 0; i < ContName.Items.Count; i++)
            {
                if (sharing.Items.Contains(ContName.SelectedItem))
                {
                    sharing.Items.Remove(ContName.SelectedItem);
                }
            }
        }

        /*private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string temp_name = Microsoft.VisualBasic.Interaction.InputBox("Enter Contributor Name:","Add Contributor");
            int list_limit = ContName.Items.Count - 1,chk_limit=sharing.Items.Count;

            ContName.Items.Insert(list_limit + 1, temp_name);
            sharing.Items.Insert(chk_limit, temp_name);
            sharing.SetItemCheckState(chk_limit, CheckState.Unchecked);

            WriteQuery("insert into Users(Username) Values('" + temp_name + "')");
        }

        public void WriteQuery(string qry)
       {
           String query = qry;  

           //gets connection string from the settings file
           OleDbConnection conn = new OleDbConnection(conString);
         
            try
           {
               conn.Open();
               OleDbCommand cmd = new OleDbCommand(query, conn);
               int chk = cmd.ExecuteNonQuery();
               if (chk > 0)
               {
                   MessageBox.Show("User Action Success", "Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
               }
               else
               {
                   MessageBox.Show("User Action Failed", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
               
           }
           catch (OleDbException exp)
           {
               MessageBox.Show("Database Error: " + exp.Message, "Connect Error");
           }
           finally
           {
               if (conn.State == ConnectionState.Open)
               {
                   conn.Close();
               }
           }
       }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string temp_name = "";
            int list_limit = ContName.Items.Count - 1, chk_limit = sharing.Items.Count;
            bool check = false;

            while (!check)
            {
                temp_name=Microsoft.VisualBasic.Interaction.InputBox("Enter Contributor Name:", "Delete Contributor");

                    if (ContName.Items.Contains(temp_name))
                    {
                        ContName.Items.Remove(temp_name);
                        sharing.Items.Remove(temp_name);
                        check = true;
                        WriteQuery("delete from Users where Username='"+temp_name+"'");
                    }
                    else
                    {
                        check = false;
                    }
                }
         
        }*/

        private void Generate_Expense_Click(object sender, EventArgs e)
        {
            int tot_select =0,amount=0,share=0;

            if (inputValidate())
            {
                tot_select = sharing.CheckedItems.Count + 1;
                amount = Convert.ToInt32(expamt.Text);

                share = amount / tot_select;

                summary_val = "Total Expense : " + amount + "\n\n"
                             + "Per Head Expense : " + "\n\n";

                summary_val += ContName.SelectedItem + "- " + share + "\n\n";

                for (int i = 0; i < sharing.Items.Count; i++)
                {
                    if (sharing.GetItemChecked(i))
                        summary_val += sharing.Items[i].ToString() + "- " + share + "\n\n";

                }
                summary.Text = summary_val;
            }
        }

        private bool inputValidate()
        {
            bool flag=false;

            if (ContName.SelectedIndex == -1 || expdetails.Text.Trim() == "" || expamt.Text.Trim() == "" || sharing.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please fill below Details :\n\n1.Contributor Name\n\n2.Details\n\n3.Amount\n\n4.Shared By", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ContName.Focus();
                flag = false;
            }
            else
            {
                flag = true;
            }
            return flag;
        }

        private void Add_Expense_Click(object sender, EventArgs e)
        {
            int cnt_rows=dataGridView1.Rows.Count;
            string listname = "";

            if (inputValidate())
            {
            
                dataGridView1.Rows.Add();
                dataGridView1.Rows[cnt_rows].Cells[0].Value = expdetails.Text;
                dataGridView1.Rows[cnt_rows].Cells[1].Value = ContName.Text;
                dataGridView1.Rows[cnt_rows].Cells[2].Value = expamt.Text;
                for (int i = 0; i < sharing.Items.Count; i++)
                {
                    if (sharing.GetItemCheckState(i) == CheckState.Checked)
                    {
                        listname += sharing.Items[i].ToString()+", ";
                    }
                    
                }
           
                dataGridView1.Rows[cnt_rows].Cells[3].Value = listname.Substring(0, listname.Length - 2);
                dataGridView1.Rows[cnt_rows].Cells[4].Value = expdate.Text;
               
           }
                
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // int count = dataGridView1.Rows.Count;
            string fileName = "";

            if (dataGridView1.Rows.Count != 0)
            {
                saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName =saveFileDialog1.FileName;
                }

              /*  // creating Excel Application
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();

                // creating new WorkBook within Excel application
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);

                // creating new Excelsheet in workbook
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                // see the excel sheet behind the program
                app.Visible = true;

                // get the reference of first sheet. By default its name is Sheet1.
                // store its reference to worksheet
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;

                // changing the name of active sheet
                worksheet.Name = DateTime.Now.Date.ToShortDateString();


                // storing header part in Excel
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    worksheet.Columns.ColumnWidth = 20;
                }

                // storing Each row and column value to excel sheet
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView1.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1] = dataGridView1.Rows[row].Cells[col].Value.ToString();
                    }
                }

                // save the application
                workbook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
          */

                StreamWriter write = new StreamWriter(fileName);
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    write.Write(dataGridView1.Columns[i - 1].HeaderText);
                    write.Write("\t");
                }
                write.WriteLine();
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    for (int col = 0; col < dataGridView1.Columns.Count; col++)
                    {
                        write.Write(dataGridView1.Rows[row].Cells[col].Value.ToString());
                        write.Write("\t\t");
                    }
                    write.WriteLine();
                }
                write.Flush();
                write.Close();
            }
            else
            {
                MessageBox.Show("Report is empty.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void expamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Only Integers Allowed", "Numeric Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                expamt.Focus();
                e.Handled = true;
            }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            String existFile = " ";
            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                existFile = openFile.FileName;    
            }
           
        }
    }
}
