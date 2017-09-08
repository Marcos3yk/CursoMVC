using System;
using System.Linq;
using MV.CursoMvc.Domain.Entities;
using MV.CursoMvc.Domain.Interfaces.Repository;

namespace MV.CursoMvc.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        //public override void Remover(Guid id)
        //{
        //    Db.Clientes.Remove(Db.Clientes.Find(id));
        //}

        public Cliente ObterPorCPF(string cpf)
        {
            return Buscar(C => C.CPF == cpf).FirstOrDefault();
        }

        public Cliente ObterPorEmail(string email)
        {
            return Buscar(c => c.Email == email).FirstOrDefault();
        }

    }
}