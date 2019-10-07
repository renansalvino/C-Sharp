using System; 

 namespace McBonalds
 {
     public class Cliente
 {
      //proprieadades
      public string Nome; //nome do cliente
      public string Endereco; // Endereço do cliente 
      public string Telefone; // Telefone do cliente
      public string Senha; //Senha de acesso do cliente ao sistema
      public string Email; //email do cliente e nome de usuário de acessso ao sistema
      public DateTime Datadenascimento; //Data de nascimento do cliente (//datetime é uma classe por isso que a cor está diferenciada)

    //construtores
    public Cliente(string Nome, string Telefone, string Email){
        this.Nome = Nome;
        this.Telefone = Telefone;
        this.Email = Email;
    }


 }

 }