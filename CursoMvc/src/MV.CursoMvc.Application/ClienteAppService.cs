using System;
using System.Collections.Generic;
using AutoMapper;
using MV.CursoMvc.Application.Interface;
using MV.CursoMvc.Application.ViewModels;
using MV.CursoMvc.Domain.Entities;
using MV.CursoMvc.Domain.Interfaces.Repository;
using MV.CursoMvc.Infra.Data.Repository;

namespace MV.CursoMvc.Application
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly ClienteRepository _clienteRespository = new ClienteRepository();

        public void Adicionar(ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var cliente = Mapper.Map<ClienteEnderecoViewModel, Cliente>(clienteEnderecoViewModel);
            var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnderecoViewModel);

            cliente.Enderecos.Add(endereco);
            _clienteRespository.Adicionar(cliente);
        }

        public void Atualizar(ClienteViewModel clienteViewModel)
        {
            var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
            //var endereco = Mapper.Map<ClienteEnderecoViewModel, Endereco>(clienteEnderecoViewModel);

            _clienteRespository.Atualizar(cliente);
        }

        public void Dispose()
        {
            _clienteRespository.Dispose();
            GC.SuppressFinalize(this);
        }

        public ClienteViewModel ObterPorCPF(string cpf)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteRespository.ObterPorCPF(cpf));
        }

        public ClienteViewModel ObterPorEmail(string email)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteRespository.ObterPorEmail(email));
        }

        public ClienteViewModel ObterPorId(Guid id)
        {
            return Mapper.Map<Cliente, ClienteViewModel>(_clienteRespository.ObterPorId(id));
        }

        public IEnumerable<ClienteViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(_clienteRespository.ObterTodos());

        }

        public void Remover(Guid id)
        {
            _clienteRespository.Remover(id);
        }
    }
}