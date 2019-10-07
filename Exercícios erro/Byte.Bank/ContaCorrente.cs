namespace Byte.Bank {
    public class ContaCorrente {

        public string Titular;
        public int Agencia;
        public int Numero;
        public double Saldo;

        public ContaCorrente (string titular, int agencia, int numero) {
            this.Titular = titular;
            this.Agencia = agencia;
            this.Numero = numero;
            this.Saldo = 0.0;
        }
        public bool ColocarSaldo (double saldo) {
            if (saldo > 0.0) {
                this.Saldo = saldo;
                return true;
            } else {
                return false;
            }
        }

        public double Deposito (double valor ) { // deposito
            return this.Saldo += valor;

            }


        public bool saque (double valor) {
            if (Saldo >= valor){
                Saldo -= valor;
                return true;
            }else{
                return false;
            } 
        }

        public bool Transferencia (ContaCorrente contaDestino, double valor) {
            if(this.saque(valor)){
                contaDestino.Deposito(valor);
                return true;
            }else{
                return false;
            }
            
            
        }

        }
    }
}