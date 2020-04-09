using AppFastFoodService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace AppFastFoodService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IPedidosFastFoodServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IPedidosFastFoodServices
    {
        [OperationContract]//hola 
        PedidoFastFood registrarPedido(PedidoFastFood pedidoFastFood);
        
        [OperationContract]
        List<PedidoFastFood> listaPedidos(int idcliente);

        [OperationContract]
        PedidoFastFood actualizarEstadoPedido(PedidoFastFood pedidoFastFood);
        

         


    }
}
