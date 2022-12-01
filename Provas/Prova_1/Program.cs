using System;

 class main
    {
        static void Main(string[] args)
        {
          // Na aplicação main instanciar as contas CC01, CC02 e CC03 de números de conta 1,2 e 3 respectivamente.
          // Todas irão ter depósito inicial de R$1000,00.
            Correntista CC01 = new Correntista(1, 1000);
            Correntista CC02 = new Correntista(2, 1000);
            Correntista CC03 = new Correntista(3, 1000);
            Banco b = new Banco(CC01, CC02, CC03);
          // Imprimir os saldos das contas.
            b.imprimeContas();
          // Realizar um depósito de R$500,00 na conta CC02.
            b.deposito(2, 500);
          // Tentar sacar R$1200,00 na conta CC01, informar valor sacado ou saldo insuficiente.
            b.saque(1, 1200);
          // Tentar sacar R$300,00 na conta CC03, informar valor sacado ou saldo insuficiente.
            b.saque(3, 300);
          // Imprimir o saldo da conta CC03.
            b.imprimeSaldo(3);
          // Informar, novamente os saldos das contas.
            b.imprimeContas();
        }

    }