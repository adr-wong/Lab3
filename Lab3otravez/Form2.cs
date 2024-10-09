
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            // Convertir Form2 en un contenedor MDI
            this.IsMdiContainer = true;
        }

        // Método para abrir el formulario Problema1 como hijo
        private void problema1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica si ya existe una instancia de Problema1
            foreach (Form form in this.MdiChildren)
            {
                if (form is Problema1)
                {
                    form.Activate(); // Si ya está abierto, lo activa
                    return;
                }
            }

            // Crear una nueva instancia de Problema1
            Problema1 formProblema1 = new Problema1
            {
                MdiParent = this,  // Establecer como hijo de Form2
                WindowState = FormWindowState.Maximized
            };
            formProblema1.Show();
        }

        // Método para abrir el formulario Problema2 como hijo
        private void problema2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica si ya existe una instancia de Problema2
            foreach (Form form in this.MdiChildren)
            {
                if (form is Problema2)
                {
                    form.Activate(); // Si ya está abierto, lo activa
                    return;
                }
            }

            // Crear una nueva instancia de Problema2
            Problema2 formProblema2 = new Problema2
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            formProblema2.Show();
        }

        // Método para abrir el formulario Problema3 como hijo
        private void problema3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica si ya existe una instancia de Problema3
            foreach (Form form in this.MdiChildren)
            {
                if (form is Problema3)
                {
                    form.Activate(); // Si ya está abierto, lo activa
                    return;
                }
            }

            // Crear una nueva instancia de Problema3
            Problema3 formProblema3 = new Problema3
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            formProblema3.Show();
        }

    }
}
