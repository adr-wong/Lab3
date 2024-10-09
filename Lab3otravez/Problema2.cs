using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3otravez
{
    public partial class Problema2 : Form
    {
        private int indice;
        public Problema2()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 1;
            indice = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int valor;
            try
            {
                valor = Convert.ToInt32(txtNum.Text);
                insercion(valor);
                txtNum.Text = "";
            }
            catch { MessageBox.Show("Error de entrada en la insercion"); }
        }
        private void insercion(int valor)
        {
            dataGridView1.Rows[0].Cells[indice].Value = valor;
            dataGridView1.Columns.Add(AsistenteGrid.CrearColumna(indice));
            indice++;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int target;
            try
            {
                target = Convert.ToInt32(txtBorrar.Text);
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    borrar(target);
                }
                txtBorrar.Text = "";
            }
            catch
            {
                MessageBox.Show("Error de entrada en la insercion");
            }
        }
        private void borrar(int t)
        {
            int temp;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                temp = Convert.ToInt32(dataGridView1.Rows[0].Cells[i].Value);
                if (temp == t)
                {
                    dataGridView1.Columns.RemoveAt(i);
                    continue;
                }
            }
        }
    }
}
