using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3otravez
{
    public static class Ventas
    {
        private static List<decimal> lista_ventas = new List<decimal>();

        public static void agregarVenta(List<decimal> importes)
        {
            lista_ventas.AddRange(importes);
        }

        public static List<decimal> filtrarOrdenar()
        {
            // Filtra las ventas en el rango especificado y las ordena
            return lista_ventas.Where(v => v >= 50 && v <= 287).OrderBy(v => v).ToList();
        }

        public static List<decimal> obtenerVentas()
        {
            return lista_ventas;
        }
    }
}
