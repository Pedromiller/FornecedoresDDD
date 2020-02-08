using FornecedoresDDD.Dominio.Interfaces;
using FornecedoresDDD.Infra.Dados.Config;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FornecedoresDDD.Infra.Dados.Repositorio
{   
    public class RepositorioBase<T> : IBase<T> where T : class
    {
        private readonly DbContextOptions<FornecedoresDbContext> _optionsBuilder;

        public RepositorioBase()
        {
            _optionsBuilder = new DbContextOptions<FornecedoresDbContext>();
        }

        public void Adicionar(T obj)
        {
            using(var db = new FornecedoresDbContext(_optionsBuilder))
            {
                db.Set<T>().Add(obj);
                db.SaveChanges();
            }            
        }

        public void Atualizar(T obj)
        {
            throw new NotImplementedException();
        }

        public void Excluir(T obj)
        {
            throw new NotImplementedException();
        }

        public IList<T> Listar()
        {
            using(var db = new FornecedoresDbContext(_optionsBuilder))
            {
                return db.Set<T>().AsNoTracking().ToList();
            }
        }

        public T RecuperarPorId(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
