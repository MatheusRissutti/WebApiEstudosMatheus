using Microsoft.AspNetCore.Mvc;
using WebApiEstudosMatheus.Model;

namespace WebApiEstudosMatheus.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ClienteController
    {

        [HttpPost]
        public void Create(CreateClienteModel model)
        {


        }
    }
}
