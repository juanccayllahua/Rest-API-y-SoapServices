using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebFastFodd.Pages.Home
{
    public class CrearModel : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty]
        public FastSoapServiceReference.Cliente cliente { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            FastSoapServiceReference.PedidosFastFoodServicesClient apiClient
                = new FastSoapServiceReference.PedidosFastFoodServicesClient();

            //PedidosServiceReference.PedidosFastFoodServicesClient objcliente
            //    = new PedidosServiceReference.PedidosFastFoodServicesClient();


            if (!ModelState.IsValid)
            {
                return Page();
            }

            var result = await apiClient.registrarclienteAsync(cliente);
            var nombre = result.Nombres + " " + result.Apellidos;

            return RedirectToPage("./gracias?nombre="+nombre);
        }
    }
}
