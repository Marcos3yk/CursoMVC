using System;
using System.Linq;
using Dapper;
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

        public override Cliente ObterPorId(Guid id)
        {
            var sql = @"SELECT * FROM Clientes c" +
                      " INNER JOIN Enderecos e" +
                      " ON c.ClienteId = e.ClienteId" +
                      " WHERE c.ClienteId = @sid";
            using (var cn = Db.Database.Connection)
            {
                cn.Open();
                var cliente = cn.Query<Cliente, Endereco, Cliente>(sql,
                    (c, e) =>
                    {
                        c.Enderecos.Add(e);
                        return c;
                    }, new {sid = id}, splitOn: "ClienteId, EnderecoId");

                return cliente.FirstOrDefault();

            }
        }
    }
}