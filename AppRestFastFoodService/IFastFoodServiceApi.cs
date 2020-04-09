using AppRestFastFoodService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Http.Cors;

namespace AppRestFastFoodService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IFastFoodServiceApi" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IFastFoodServiceApi
    { 

        [OperationContract]
        [WebInvoke(Method = "POST",
             BodyStyle = WebMessageBodyStyle.WrappedRequest,
                RequestFormat = WebMessageFormat.Json,
                ResponseFormat = WebMessageFormat.Json,
                UriTemplate = "post/cliente")]
        Cliente cliente(Cliente cliente);

        [OperationContract]
        [WebGet]
        [EnableCors(origins: "http://mywebclient.azurewebsites.net", headers: "*", methods: "*")]
        List<Cliente> clientes();
    }
}
