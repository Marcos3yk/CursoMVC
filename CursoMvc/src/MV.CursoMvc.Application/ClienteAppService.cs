using System;
using System.Collections.Generic;
using MV.CursoMvc.Application.Interface;
using MV.CursoMvc.Domain.Entities;
using MV.CursoMvc.Domain.Interfaces.Repository;
using MV.CursoMvc.Infra.Data.Repository;

namespace MV.CursoMvc.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly ClienteRepository Db = new ClienteRepository();

        public void Adicionar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Cliente ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cliente> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}