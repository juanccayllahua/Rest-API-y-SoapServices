using AppFastFoodService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AppFastFoodService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PedidosFastFoodServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PedidosFastFoodServices.svc o PedidosFastFoodServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PedidosFastFoodServices : IPedidosFastFoodServices
    {

        public Cliente registrarcliente(Cliente objcliente)
        {
            Cliente obj = new Cliente();
            obj = objcliente;
            obj.FechaCreacion = DateTime.Now;
            obj.FechaModifacion = DateTime.Now;
            obj.UsuarioCreacion = "usarApp";
            obj.UsuarioModificacion = "usarApp";
            obj.FechaNac = DateTime.Now;
            obj.IdDistrito = "1";
            obj.IdProvincia= "1";
            obj.IdDepartamento = "2";
             


            BDClientesEntities dbcontext = new BDClientesEntities();
            
            dbcontext.Cliente.Add(obj);
            dbcontext.SaveChanges();

            return obj;
        }

        public PedidoFastFood registrarPedido(PedidoFastFood pedidoFastFood)
        {
            BDPedidosFastFoodEntities dbContext = new BDPedidosFastFoodEntities();

            PedidoFastFood obj = new PedidoFastFood();
           
            
            obj = pedidoFastFood;
            obj.FechaPedido = DateTime.Now;

            dbContext.PedidoFastFood.Add(obj);
            dbContext.SaveChanges();

            return obj;
        }

        public List<PedidoFastFood> listaPedidos(int IdCliente)
        {           
            BDPedidosFastFoodEntities dbContext = new BDPedidosFastFoodEntities();
            List<PedidoFastFood> objlist = new List<PedidoFastFood>();
            objlist = dbContext.PedidoFastFood
                .Where(x => x.IdCliente == IdCliente).ToList();

            return objlist;
        }

        public PedidoFastFood actualizarEstadoPedido(PedidoFastFood pedidoFastFood) {
            BDPedidosFastFoodEntities dbContext = new BDPedidosFastFoodEntities();
            PedidoFastFood obj = dbContext.PedidoFastFood
                .SingleOrDefault(x => x.CodigoPedido == pedidoFastFood.CodigoPedido);
            obj.IdEstadoPedido = pedidoFastFood.IdEstadoPedido;

            dbContext.SaveChanges();
            
            return obj;
        }



    }
}
