using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeConta.Classes
{
    class Conta
    {
    private TipoConta tipoconta{get; set;}
    private double saldo {get; set;}
    private double credito{get; set;}
    private string nome {get; set;}
    public Conta(TipoConta tipoconta, string nome, double saldo, double credito) {
        this.credito = credito;
        this.nome = nome;
        this.saldo = saldo;
        this.tipoconta = tipoconta;
    }
        public bool Sacar(double valorSaque)
        {
            // Validação de saldo suficiente
            if (this.saldo - valorSaque < (this.credito * -1))
            {
                Console.WriteLine("Saldo insuficiente!");
                return false;
            }
            this.saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.nome, this.saldo);
          
            return true;
        }
        public void VisualizarSaldo()
        {
            Console.WriteLine("Seu saldo é {0}", saldo);
        }

        public void Depositar(double valorDeposito)
        {
            this.saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.nome, this.saldo);
        }

        public void Transferir(double valorTransferencia, Conta contaDestino)
        {
            if (this.Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "TipoConta " + this.tipoconta + " | ";
            retorno += "Nome " + this.nome + " | ";
            retorno += "Saldo " + this.saldo + " | ";
            retorno += "Crédito " + this.credito;
            return retorno;
        }
    }


}

