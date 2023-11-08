using WebApiEstudosMatheus.Entities;

namespace WebApiEstudosMatheus.Interfaces
{
    public interface IClienteRepository
    {
        bool Insert(Cliente entity);
    }
}
