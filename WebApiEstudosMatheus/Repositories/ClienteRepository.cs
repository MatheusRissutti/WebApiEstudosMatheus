using WebApiEstudosMatheus.Entities;
using WebApiEstudosMatheus.Interfaces;

namespace WebApiEstudosMatheus.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public bool Insert(Cliente entity)
        {
            //Mapeia a model pra entidade
            //faz conexão com o banco de dados
            //passa a entidade
            //salva no banco de dados
            // fecha a conex'ao com o banco de dados
            return true;
        }
    }
}
