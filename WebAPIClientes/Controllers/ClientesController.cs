using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BusinessLogic;
using Domain;

namespace WebAPIClientes.Controllers
{
    [EnableCors(origins: "https://localhost:44386", headers: "*", methods: "*")]
    public class ClientesController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Cliente> Get()
        {
            return ClientesManager.Buscar();
        }

        // POST api/<controller>
        public void Post([FromBody]Cliente cliente)
        {
            ClientesManager.Guardar(cliente);
        }

        // PUT api/<controller>/5
        public void Put([FromBody]Cliente cliente)
        {
            ClientesManager.Guardar(cliente);
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            ClientesManager.Eliminar(id);
        }
    }
}