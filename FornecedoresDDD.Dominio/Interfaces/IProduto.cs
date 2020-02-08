using FornecedoresDDD.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace FornecedoresDDD.Dominio.Interfaces
{
    public interface IProduto : IBase<Produto>
    {
        //Herdar todos os métodos de IBase
        //TODO: Outros contratos relevantes para produto
        //Exemplo: RecuperarPorNome()

        Produto RecuperarPorNome(string nome);

    }
}
