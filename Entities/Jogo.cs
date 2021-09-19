using System;

namespace ExemploApiCatalogoJogos.Entities
{
    //Elementos necessários para cadastro de jogos
    public class Jogo
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Produtora { get; set; }
        public double Preco { get; set; }
    }
}
