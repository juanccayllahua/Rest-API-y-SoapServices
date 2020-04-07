using AppFastFoodService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AppFastFoodService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IClientesFastFoodServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IClientesFastFoodServices
    {
        [OperationContract]
        Cliente agregarCliente(Cliente cliente);

        [OperationContract]
        Cliente modificarCliente(Cliente cliente);

        [OperationContract]
        Cliente obtenerclienteporemail(string email);

    }
}
