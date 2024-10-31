namespace Pie_Chart_Assignment
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.loadGraph = new System.Windows.Forms.Button();
            this.Data_lbl = new System.Windows.Forms.Label();
            this.editGraph = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 29);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(448, 389);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // loadGraph
            // 
            this.loadGraph.BackColor = System.Drawing.Color.Beige;
            this.loadGraph.Location = new System.Drawing.Point(648, 386);
            this.loadGraph.Name = "loadGraph";
            this.loadGraph.Size = new System.Drawing.Size(108, 32);
            this.loadGraph.TabIndex = 4;
            this.loadGraph.Text = "Generate";
            this.loadGraph.UseVisualStyleBackColor = false;
            // 
            // Data_lbl
            // 
            this.Data_lbl.AutoSize = true;
            this.Data_lbl.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_lbl.Location = new System.Drawing.Point(32, 89);
            this.Data_lbl.Name = "Data_lbl";
            this.Data_lbl.Size = new System.Drawing.Size(0, 24);
            this.Data_lbl.TabIndex = 6;
            // 
            // editGraph
            // 
            this.editGraph.BackColor = System.Drawing.Color.Beige;
            this.editGraph.Location = new System.Drawing.Point(505, 386);
            this.editGraph.Name = "editGraph";
            this.editGraph.Size = new System.Drawing.Size(108, 32);
            this.editGraph.TabIndex = 7;
            this.editGraph.Text = "Edit";
            this.editGraph.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(572, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(184, 117);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.editGraph);
            this.Controls.Add(this.Data_lbl);
            this.Controls.Add(this.loadGraph);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button loadGraph;
        private System.Windows.Forms.Label Data_lbl;
        private System.Windows.Forms.Button editGraph;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

