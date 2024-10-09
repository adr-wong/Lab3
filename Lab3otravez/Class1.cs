using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3otravez
{
    public class CuentaAhorros
    {
        public string Cliente { get; set; }
        public decimal Saldo { get; private set; }
        public List<decimal> Depositos { get; private set; }
        public List<decimal> Retiros { get; private set; }

        public CuentaAhorros(string cliente, decimal montoInicial)
        {
            Cliente = cliente;
            Saldo = montoInicial;
            Depositos = new List<decimal>();
            Retiros = new List<decimal>();
        }

        public void Depositar(decimal monto)
        {
            Saldo += monto;
            Depositos.Add(monto);
        }

        public bool Retirar(decimal monto)
        {
            if (monto <= Saldo)
            {
                Saldo -= monto;
                Retiros.Add(monto);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}