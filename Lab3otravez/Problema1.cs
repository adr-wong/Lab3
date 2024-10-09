using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab3otravez
{
    public partial class Problema1 : Form
    {
        private CuentaAhorros? cuenta = null;
        public Problema1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = textBox1.Text;
            var monto = Convert.ToDecimal(textBox2.Text);

            cuenta = new CuentaAhorros(cliente, monto);

            listBox1.Enabled = true;
            listBox2.Enabled = true;
            textBox3.Text = cuenta.Saldo.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal monto = decimal.Parse(textBox2.Text);

            if (radioButton1.Checked) // Depósito
            {
                cuenta.Depositar(monto);
                listBox2.Items.Add(monto);  // Agregar el depósito a la lista
            }
            else if (radioButton2.Checked) // Retiro
            {
                if (cuenta.Retirar(monto))
                {
                    listBox1.Items.Add(monto);  // Agregar el retiro a la lista
                }
                else
                {
                    MessageBox.Show("Fondos insuficientes.");
                }
            }

            // Actualizar el saldo
            textBox3.Text = cuenta.Saldo.ToString();
        }
    }
}
