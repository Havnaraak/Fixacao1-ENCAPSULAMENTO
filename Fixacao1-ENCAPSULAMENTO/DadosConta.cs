using System;
using System.Globalization;

namespace Fixacao1
{
    internal class DadosConta
    {
        private int _numConta;
        private string _titular;
        public double Saldo { get; private set; }

        public  DadosConta( int numConta, string titular, double saldo ){

            _numConta = numConta;
            _titular = titular;
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saque(double valor)
        {
            Saldo = (Saldo - valor) - 5;
        }

        public int NumConta
        {
            get { return _numConta; }

            set { _numConta = value; }
        }

        public string Titular
        {
            get { return _titular; }

            set { 
                if (value.Length > 1)
                {
                    _titular = value;
                }
            }
        }

        public override string ToString()
        {
            return "Conta: " + _numConta + ",  Titular: " + _titular + ", Saldo: R$" + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
