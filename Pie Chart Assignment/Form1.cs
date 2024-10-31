using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pie_Chart_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Size = new Size(800, 500);
            this.BackColor = Color.Beige;

            //creating datagridview columns and setting features....
            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "NameColumn"; // Set the column name
            column1.HeaderText = "Name"; // Set the header text
            this.dataGridView1.Columns.Add(column1); // Add the column to the DataGridView
            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "ValueColumn";
            column2.HeaderText = "Value";
            this.dataGridView1.Columns.Add(column2);

            // positioning, sizing and styling datagrid and buttons and picturebox elements
            dataGridView1.BackgroundColor = Color.Beige;
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Size = new Size(230, 230);

            pictureBox.Size = new Size(500, 500);
            loadGraph.Size = new Size(100, 40);
            editGraph.Size = new Size(100, 40);
            dataGridView1.Location = new Point(this.ClientSize.Width - dataGridView1.Width - 20, 50);
            loadGraph.Location = new Point(this.ClientSize.Width - (dataGridView1.Width / 2), 350);
            editGraph.Location = new Point(this.ClientSize.Width - (dataGridView1.Width) - 30, 350);
        }
    }
}
