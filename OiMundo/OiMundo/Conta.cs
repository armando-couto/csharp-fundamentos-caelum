using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OiMundo
{
    class Conta
    {
        public int numero;
        public string titular;
        public double saldo;

        public Cliente cliente;

        public void Saca(double valorASerSacado)
        {
            this.saldo -= valorASerSacado;
        }

        public void Deposita(double valorASerDepositado)
        {
            this.saldo += valorASerDepositado;
        }

        public void Transfere(double valor, Conta destino)
        {
            this.Saca(valor);
            destino.Deposita(valor);
        }
    }
}
