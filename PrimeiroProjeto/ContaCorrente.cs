using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PrimeiroProjeto
{
    public class ContaCorrente
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaCorrente(int numeroConta, string nome)
        {
            Numero = numeroConta;
            Titular = nome;
        }

        public ContaCorrente(int numeroConta,string nome, double depositoInicial) : this(numeroConta, nome)
        {
            Deposito(depositoInicial);
        }

        public void Deposito(double valor)
        {
            Saldo += valor;
        }
        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
