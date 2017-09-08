using MV.CursoMvc.Domain.Entities;

namespace MV.CursoMvc.Domain.Interfaces.Repository
{
    public interface IClienteRepository :IRepository<Cliente>
    {
        Cliente ObterPorCPF(string cpf);
        Cliente ObterPorEmail(string email);
    }
}