using System;
using System.Collections.Generic;
using MV.CursoMvc.Application.Interface;
using MV.CursoMvc.Application.ViewModels;
using MV.CursoMvc.Domain.Entities;
using MV.CursoMvc.Domain.Interfaces.Repository;
using MV.CursoMvc.Infra.Data.Repository;

namespace MV.CursoMvc.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly ClienteRepository clienteRespository = new ClienteRepository();

        public void Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            clienteRespository.Adicionar(clienteEnderecoViewModel);
        }

        public void Atualizar(ClienteViewModel clienteViewModel)
        {
           clienteRespository.Atualizar(clienteViewModel);
        }

        public void Dispose()
        {
            clienteRespository.Dispose();
            GC.SuppressFinalize(this);
        }

        public Cliente ObterPorCPF(string cpf)
        {
            return clienteRespository.ObterPorCPF(cpf);
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            return clienteRespository.ObterPorEmail(email);
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            return clienteRespository.ObterPorId(id);
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return clienteRespository.ObterTodos();
        }

        public void Remover(Guid id)
        {
            clienteRespository.Remover(id);
        }
    }
}