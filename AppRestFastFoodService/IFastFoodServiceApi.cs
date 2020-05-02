using AppRestFastFoodService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Http;
using System.Web.Http.Cors;

namespace AppRestFastFoodService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IFastFoodServiceApi" en el código y en el archivo de configuración a la vez.
    //[ServiceContract]


    [ServiceContract]
    public interface IFastFoodServiceApi
    {
        [OperationContract]

        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        string saludo(string nombre);

        [OperationContract] 
        Cliente cliente(Cliente pClient);

        [OperationContract]

        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        List<Cliente> clientes();
    }
}
