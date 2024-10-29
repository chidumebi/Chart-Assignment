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
            this.label1 = new System.Windows.Forms.Label();
            this.DataName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Value_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gen_btn = new System.Windows.Forms.Button();
            this.Apply_btn = new System.Windows.Forms.Button();
            this.Data_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Data:";
            // 
            // DataName
            // 
            this.DataName.Location = new System.Drawing.Point(209, 16);
            this.DataName.Multiline = true;
            this.DataName.Name = "DataName";
            this.DataName.Size = new System.Drawing.Size(409, 32);
            this.DataName.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(15, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 282);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Value_1,
            this.value_2});
            this.dataGridView1.Location = new System.Drawing.Point(423, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(333, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Value_1
            // 
            this.Value_1.HeaderText = "Value";
            this.Value_1.MinimumWidth = 6;
            this.Value_1.Name = "Value_1";
            this.Value_1.Width = 125;
            // 
            // value_2
            // 
            this.value_2.HeaderText = "Value";
            this.value_2.MinimumWidth = 6;
            this.value_2.Name = "value_2";
            this.value_2.Width = 125;
            // 
            // Gen_btn
            // 
            this.Gen_btn.Location = new System.Drawing.Point(648, 357);
            this.Gen_btn.Name = "Gen_btn";
            this.Gen_btn.Size = new System.Drawing.Size(108, 32);
            this.Gen_btn.TabIndex = 4;
            this.Gen_btn.Text = "Generate";
            this.Gen_btn.UseVisualStyleBackColor = true;
            // 
            // Apply_btn
            // 
            this.Apply_btn.Location = new System.Drawing.Point(637, 16);
            this.Apply_btn.Name = "Apply_btn";
            this.Apply_btn.Size = new System.Drawing.Size(88, 32);
            this.Apply_btn.TabIndex = 5;
            this.Apply_btn.Text = "Apply";
            this.Apply_btn.UseVisualStyleBackColor = true;
            this.Apply_btn.Click += new System.EventHandler(this.Apply_btn_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Data_lbl);
            this.Controls.Add(this.Apply_btn);
            this.Controls.Add(this.Gen_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DataName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn value_2;
        private System.Windows.Forms.Button Gen_btn;
        private System.Windows.Forms.Button Apply_btn;
        private System.Windows.Forms.Label Data_lbl;
    }
}

