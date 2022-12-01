using System;

class Banco
    {
      // O Banco possui 3 correntistas
        private Correntista CC01;
        private Correntista CC02;
        private Correntista CC03;

        public Banco() { }
        public Banco(Correntista CC01, Correntista CC02, Correntista CC03) {
            this.CC01 = CC01;
            this.CC02 = CC02;
            this.CC03 = CC03;
        }

        public void setCC01(Correntista CC01) {
            this.CC01 = CC01;
        }
        public void setCC02(Correntista CC02) {
            this.CC02 = CC02;
        }
        public void setCC03(Correntista CC03) {
            this.CC03 = CC03;
        }

        public void imprimeContas() {
            Console.WriteLine("Número da conta C001: " + this.CC01.getNumeroConta() + " | saldo: R$" + this.CC01.getSaldo());
            Console.WriteLine("Número da conta C002: " + this.CC02.getNumeroConta() + " | saldo: R$" + this.CC01.getSaldo());
            Console.WriteLine("Número da conta C003: " + this.CC03.getNumeroConta() + " | saldo: R$" + this.CC01.getSaldo());
        }

        public void deposito(int numeroConta, double valor) {
            if (numeroConta == CC01.getNumeroConta())
            {
                this.CC01.setSaldo(CC01.getSaldo() + valor);
                Console.WriteLine("Deposito no valor de R$" + valor + " na conta " + this.CC01.getNumeroConta() + " realizado com sucesso.");
            }
            else if (numeroConta == CC02.getNumeroConta())
            {
                this.CC02.setSaldo(CC02.getSaldo() + valor);
                Console.WriteLine("Deposito no valor de R$" + valor + " na conta " + this.CC02.getNumeroConta() +  " realizado com sucesso.");
            }
            else if (numeroConta == CC03.getNumeroConta())
            {
                this.CC03.setSaldo(CC03.getSaldo() + valor);
                Console.WriteLine("Deposito no valor de R$" + valor + " na conta " + this.CC03.getNumeroConta() +  " realizado com sucesso.");
            }
        }

        public void saque(int numeroConta, double valor)
        {
            if (numeroConta == CC01.getNumeroConta())
            {
                if (valor <= CC01.getSaldo())
                {
                    this.CC01.setSaldo(CC01.getSaldo() - valor);
                    Console.WriteLine("Valor de R$" + valor + " sacado da conta " + this.CC01.getNumeroConta() + " com sucesso.");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente!");
                }
            }
            else if (numeroConta == CC02.getNumeroConta())
            {
                if (valor <= CC02.getSaldo())
                {
                    this.CC02.setSaldo(CC02.getSaldo() - valor);
                    Console.WriteLine("Valor de R$" + valor + " sacado da conta " + this.CC02.getNumeroConta() + " com sucesso.");
                }
                else
                {
                     Console.WriteLine("Saldo insuficiente!");
                }
            }
            else if (numeroConta == CC03.getNumeroConta())
            {
                if (valor <= CC03.getSaldo())
                {
                   this.CC03.setSaldo(CC03.getSaldo() - valor);
                    Console.WriteLine("Valor de R$" + valor + " sacado da conta " + this.CC03.getNumeroConta() + " com sucesso.");
                }
                else
                {
                     Console.WriteLine("Saldo insuficiente!");
                }
            }
        }

        public void imprimeSaldo(int numeroConta)
        {
            if (numeroConta == CC01.getNumeroConta()) {
            Console.WriteLine("A conta " + this.CC01.getNumeroConta() + " possui o saldo de R$" + this.CC01.getSaldo() + ".");
            } else if (numeroConta == CC02.getNumeroConta()) {
            Console.WriteLine("A conta " + this.CC02.getNumeroConta() + " possui o saldo de R$" + this.CC02.getSaldo() + ".");
            }
            else if (numeroConta == CC03.getNumeroConta()) {
            Console.WriteLine("A conta " + this.CC03.getNumeroConta() + " possui o saldo de R$" + this.CC03.getSaldo() + ".");
            }    
        }
    }
    