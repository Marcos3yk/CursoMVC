using MV.CursoMvc.Domain.Entities;
using System;
using System.Collections.Generic;

namespace MV.CursoMvc.Application.Interface
{
    public interface IClienteAppService : IDisposable
    {
        //Cliente ObterPorCPF(string cpf);
        //Cliente ObterPorEmail(string email);

        void Adicionar(Cliente cliente);
        Cliente ObterPorId(Guid id);
        IEnumerable<Cliente> ObterTodos();
        void Atualizar(Cliente cliente);
        void Remover(Guid id);
    }
}