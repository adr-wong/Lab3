namespace Lab3otravez
{
    partial class Problema2
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
            btnInsert = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            txtBorrar = new TextBox();
            txtNum = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(3, 3);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "Insertar";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(3, 32);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(txtBorrar);
            panel1.Controls.Add(txtNum);
            panel1.Controls.Add(btnInsert);
            panel1.Controls.Add(btnDelete);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 395);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(770, 86);
            dataGridView1.TabIndex = 4;
            // 
            // txtBorrar
            // 
            txtBorrar.Location = new Point(84, 32);
            txtBorrar.Name = "txtBorrar";
            txtBorrar.Size = new Size(100, 23);
            txtBorrar.TabIndex = 3;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(84, 3);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(100, 23);
            txtNum.TabIndex = 2;
            // 
            // Problema2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 419);
            Controls.Add(panel1);
            Name = "Problema2";
            Text = "Problema2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnInsert;
        private Button btnDelete;
        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox txtBorrar;
        private TextBox txtNum;
    }
}