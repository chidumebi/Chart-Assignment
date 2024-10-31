using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pie_Chart_Assignment
{
    public partial class Form1 : Form
    {
        // dictionary to store name and value pair from datagridview table
        public Dictionary<string, double> table = new Dictionary<string, double>();
        public Random rand = new Random(); // random class to get color
        private List<Color> segmentColors = new List<Color>(); // list to keep record of random colors
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

        private void loadGraph_Click(object sender, EventArgs e)
        {
            string nameCol, valueCol;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // check if row is for new records
                {
                    nameCol = (string)row.Cells["NameColumn"].Value;
                    valueCol = (string)row.Cells["ValueColumn"].Value;

                    // Check if nameCol and valueCol are not null or empty
                    if (!string.IsNullOrEmpty(nameCol) && double.TryParse(valueCol, out double parsedValue))
                    {
                        // check if name col and value col already exists then just replace the valuecol
                        if (table.ContainsKey(nameCol))
                        {
                            table[nameCol] = parsedValue;
                        }

                        else // else create new name and value pair
                        {
                            table.Add(nameCol, parsedValue);
                        }
                    }
                }
            }

            //clear list of initial colors when graph is redrawn
            segmentColors.Clear();
            pictureBox.Invalidate(); //makes picturebox redrawn
            pictureBox.Paint -= DrawPieRectangle; // Unsubscribe previous event handler if necessary

            //subscribe event handlers
            pictureBox.Paint += DrawPieRectangle;
            pictureBox.Paint += DrawStringFloatFormat;
            pictureBox.Paint += DrawLegend;
            dataGridView1.Hide(); //hide datagrid view when graph is loaded
        }

        protected void DrawPieRectangle(Object Sender, PaintEventArgs e)
        {


        }

        protected void DrawStringFloatFormat(Object Sender, PaintEventArgs e)
        {


        }

        protected void DrawLegend(Object Sender, PaintEventArgs e)
        {


        }
    }
}
