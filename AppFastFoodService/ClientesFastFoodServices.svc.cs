using AppFastFoodService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AppFastFoodService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ClientesFastFoodServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ClientesFastFoodServices.svc o ClientesFastFoodServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ClientesFastFoodServices : IClientesFastFoodServices
    {


        public Cliente agregarCliente(Cliente cliente)
        {

            BDClientesEntities dbcontext = new BDClientesEntities();
            Cliente obj = new Cliente();
            obj = cliente;
            dbcontext.Cliente.Add(obj);
            dbcontext.SaveChanges();
            return obj;

        }

        public Cliente modificarCliente(Cliente cliente)
        {
            BDClientesEntities dbcontext = new BDClientesEntities();

            Cliente obj = dbcontext.Cliente
                .Where(x => x.Email == cliente.Email).FirstOrDefault();
            obj = cliente;

            dbcontext.SaveChanges();

            return obj;
        }

        public Cliente obtenerclienteporemail(string email)
        {
            BDClientesEntities dbcontext = new BDClientesEntities();

            Cliente obj = dbcontext.Cliente
                .Where(x => x.Email == email).FirstOrDefault();

            return obj;

        }
    }
}
