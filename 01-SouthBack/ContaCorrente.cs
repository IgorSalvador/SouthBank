using System;
using System.Collections.Generic;
using System.Text;

namespace _01_SouthBack
{
    class ContaCorrente
    {
        public Cliente Titular;
        public int Agencia { get; set; }
        public int Conta { get; set; }
        private double _saldo;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                //Value representa o valor externo a ser adicionado
                if(value < 0)
                {
                    _saldo = value;
                }
            }
        }

    }
}
