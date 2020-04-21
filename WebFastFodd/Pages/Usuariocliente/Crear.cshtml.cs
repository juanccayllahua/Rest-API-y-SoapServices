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
        public RestServiceReference.Cliente cliente { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            RestServiceReference.FastFoodServiceApiClient apiClient
                = new RestServiceReference.FastFoodServiceApiClient();

            //PedidosServiceReference.PedidosFastFoodServicesClient objcliente
            //    = new PedidosServiceReference.PedidosFastFoodServicesClient();


            if (!ModelState.IsValid)
            {
                return Page();
            }

            var result = await apiClient.clienteAsync(cliente);


            return RedirectToPage("./gracias");
        }
    }
}
