using FornecedoresDDD.Dominio.Entidades;
using FornecedoresDDD.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FornecedoresDDD.Infra.Dados.Repositorio
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProduto
    {
        //Por herança já possui os métodos CRUD 
        //Por Implementar IProduto, precisa implementar o método RecuperarPorNome:
        public Produto RecuperarPorNome(string nome)
        {
            throw new NotImplementedException();
        }
    }
}
