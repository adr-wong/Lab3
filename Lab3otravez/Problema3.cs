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
    public partial class Problema3 : Form
    {
        private List<decimal> listaVentas = new List<decimal>();

        public Problema3()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("Importe", "Importe");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text, out decimal importe))
            {

                listBox1.Items.Add(importe);

                
                listaVentas.Add(importe);

                
                dataGridView1.Rows.Add(importe);

                
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un importe válido.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (listaVentas.Count == 0)
            {
                MessageBox.Show("No hay ventas para mostrar.");
                return;
            }

            
            var ventasFiltradas = Ventas.filtrarOrdenar();

            
            dataGridView1.Rows.Clear();

           
            if (ventasFiltradas != null && ventasFiltradas.Count > 0)
            {
                foreach (var venta in ventasFiltradas)
                {
                    dataGridView1.Rows.Add(venta);
                }
            }
            else
            {
                MessageBox.Show("No hay ventas en el rango especificado.");
            }
        }

    }
}