using MV.CursoMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using MV.CursoMvc.Application.ViewModels;

namespace MV.CursoMvc.Application.Interface
{
    public interface IClienteAppService : IDisposable
    {
        ClienteViewModel ObterPorCPF(string cpf);
        ClienteViewModel ObterPorEmail(string email);

        void Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel);
        ClienteViewModel ObterPorId(Guid id);
        IEnumerable<ClienteViewModel> ObterTodos();
        void Atualizar(ClienteViewModel clienteViewModel);
        void Remover(Guid id);
    }
}