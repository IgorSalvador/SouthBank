using System;
using System.Collections.Generic;
using System.Text;

namespace _01_SouthBack
{
    class ContaCorrente
    {
        public Cliente Titular;

        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                else
                {
                    _agencia = value;
                }

            }
        }
        public int Numero { get; set; }
        
        
        
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

        //Construtor de inicio da classe
        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            
        }

    }
}
