using AppFastFoodService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AppFastFoodService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ProveedoresFastFoodServices" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ProveedoresFastFoodServices.svc o ProveedoresFastFoodServices.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ProveedoresFastFoodServices : IProveedoresFastFoodServices
    {
        public Proveedor agregarProveedor(Proveedor proveedor)
        {
            Proveedor obj = new Proveedor();
            try
            {
                BDProveedoresEntities dbcontext = new BDProveedoresEntities();

               
                obj = proveedor;

                dbcontext.Proveedor.Add(obj);

                dbcontext.SaveChanges();

                return obj;
            }
            catch (Exception ex)
            {

                return obj;
                //var wex = agregarProveedor<WebException>(ex);

                //// If there is no nested WebException, re-throw the exception.
                //if (wex == null) { throw; }

                //// Get the response object.
                //var response = wex.Response as HttpWebResponse;

                //// If it's not an HTTP response or is not error 403, re-throw.
                //if (response == null || response.StatusCode != HttpStatusCode.Forbidden)
                //{
                //    throw;
                //}

                //// The error is 403.  Handle it here.
            }
        }
    }
}
