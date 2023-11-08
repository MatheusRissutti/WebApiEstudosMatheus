using WebApiEstudosMatheus.Entities;
using WebApiEstudosMatheus.Interfaces;
using WebApiEstudosMatheus.Model;

namespace WebApiEstudosMatheus.Services
{
    public class ClienteService
    {
        IClienteRepository _repository;

        ContaCorrente conta;
        public ClienteService(IClienteRepository repository)
        {
            ContaCorrente contaDaJapa = new ContaCorrente();

            _repository = repository;


            conta = contaDaJapa;
            contaDaJapa.Id = 2;
        }

        public bool Create(CreateClienteModel model)
        {
            Cliente entity = new Cliente();
            entity.CpfCnpj = model.CpfCnpj;
            entity.PessoaTipoId = model.PessoaTipoId;
            entity.Nome = model.Nome;


            _repository.Insert(entity);


            return true;
        }

        public GetClienteModel Get(int id)
        {


            return null;
        }
    }
}
