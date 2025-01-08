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

        private void textBox1_TextChanged(object sender, EventArgs e)
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
                todoList.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
                //todoList.Rows[dataGridView1.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titleTextbox.Text = "";
            descriptionTextbox.Text = "";
        }


        private void saveButton_Click(object sender, EventArgs e)
        {

            todoList.Rows.Add(titleTextbox.Text, descriptionTextbox.Text);
            titleTextbox.Text = "Add some tittle here";
            descriptionTextbox.Text = "Add some description here";
        }
    }
}
