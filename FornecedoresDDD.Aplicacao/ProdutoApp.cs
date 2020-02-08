using FornecedoresDDD.Aplicacao.Interfaces;
using FornecedoresDDD.Dominio.Entidades;
using FornecedoresDDD.Dominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FornecedoresDDD.Aplicacao
{
    public class ProdutoApp : IProdutoApp
    {
        private readonly IProduto _produtoInterface;
        public ProdutoApp(IProduto produtoInterface)
        {
            _produtoInterface = produtoInterface;
        }

        public void Adicionar(Produto obj)
        {
            //Validações das Regras de negócio
            //Chamar métodos de domínio

            _produtoInterface.Adicionar(obj);
        }

        public void Atualizar(Produto obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(Produto obj)
        {
            throw new NotImplementedException();
        }

        public IList<Produto> Listar()
        {
            return _produtoInterface.Listar();
        }

        public Produto RecuperarPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
