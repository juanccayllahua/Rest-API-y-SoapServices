using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AppFastFoodService.Model;

namespace AppFastFoodService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IProductoProveedorServices" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IProductoProveedorServices
    {
        

        [OperationContract]
        void DoWork();

        [OperationContract]
        ProductosProveedor agregarProductoProveedor(ProductosProveedor productoProveedor);
         



    }
}
