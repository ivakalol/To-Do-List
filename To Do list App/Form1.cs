using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_list_App
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void descriptionTextbox_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        DataTable todoList = new DataTable();
        bool isEditing = false;

        private void ToDoList_Load(object sender, EventArgs e)
        {
            //Create columns
            todoList.Columns.Add("Titltle");
            todoList.Columns.Add("Description");

            //Point our datagridview to our datasource
            dataGridView1.DataSource = todoList;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.CurrentCell != null)
                {
                    todoList.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                }
                else
                {
                    consoleLog.Text = "Please select a valid row";
                }
                //todoList.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                consoleLog.Text = "Error: " + ex;
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextbox.Text = "";
            descriptionTextbox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if ((dataGridView1.CurrentCell != null) || dataGridView1.CurrentCell != null)
            {
                isEditing = true;
                // Fill text fields with data from table
                titleTextbox.Text = todoList.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[0].ToString();
                descriptionTextbox.Text = todoList.Rows[dataGridView1.CurrentCell.RowIndex].ItemArray[1].ToString();
            }
                
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                todoList.Rows[dataGridView1.CurrentCell.RowIndex]["Title"] = titleTextbox.Text.ToString();
                todoList.Rows[dataGridView1.CurrentCell.RowIndex]["Description"] = descriptionTextbox.Text.ToString();
            }
            else
            {
                todoList.Rows.Add(titleTextbox.Text, descriptionTextbox.Text);
            }
            titleTextbox.Text = "";
            descriptionTextbox.Text = "";
            isEditing = false;
        }

        private void consoleLog_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
