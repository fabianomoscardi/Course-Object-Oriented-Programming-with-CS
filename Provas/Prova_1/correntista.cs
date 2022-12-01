using System;

class Correntista
    {
        private int numeroConta;
        private double saldo;

        public Correntista() {}

        public Correntista(int numeroConta, double saldo)
        {
            this.numeroConta = numeroConta;
            this.saldo = saldo;
        }

        public void setNumeroConta(int numeroConta) {
            this.numeroConta = numeroConta;
        }
        public int getNumeroConta(){
           return this.numeroConta;
        }

        public void setSaldo(double saldo) {
            this.saldo = saldo;
        }

        public double getSaldo() {
            return this.saldo;
        }
    }