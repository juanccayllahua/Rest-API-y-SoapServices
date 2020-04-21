﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Http;
using AppRestFastFoodService.Model;

namespace AppRestFastFoodService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "FastFoodServiceApi" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione FastFoodServiceApi.svc o FastFoodServiceApi.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class FastFoodServiceApi : IFastFoodServiceApi
    {

        public string saludo(string nombre)
        {
            return "Hola " + nombre;
        }
        public Cliente cliente(Cliente pClient)
        {
            //Cliente pClient = new Cliente();
            //pClient.Nombres = nombre;


            BDClientesEntities bdContext = new BDClientesEntities();

            Cliente objcliente = new Cliente();
            objcliente = pClient;
            objcliente.IndAutorizaDato = pClient.IndAutorizaDato == "true" ? "1" : "0";
            objcliente.FechaCreacion = DateTime.Now;
            objcliente.UsuarioCreacion = "usuApiRest";


            bdContext.Cliente.Add(objcliente);
            bdContext.SaveChanges();

            return objcliente;
        }
        public List<Cliente> clientes()
        {
            BDClientesEntities bdContext = new BDClientesEntities();
            List<Cliente> listClientes = bdContext.Cliente.ToList();


            return listClientes;
        }
    }
}
