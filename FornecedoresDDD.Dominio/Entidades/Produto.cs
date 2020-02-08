using System;

namespace FornecedoresDDD.Dominio.Entidades
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto()
        {
            this.Id = new Guid();    
        }

        //TODO: Regras de negócio
    }
}
