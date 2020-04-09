using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebFastFodd.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {

        }


        [BindProperty]
        public PedidosServiceReference.PedidoFastFood PedidoFastFood { get; set; }
        public async Task<IActionResult> OnPostAsync()
        {
            PedidosServiceReference.PedidosFastFoodServicesClient objcliente
                = new PedidosServiceReference.PedidosFastFoodServicesClient();


            if (!ModelState.IsValid)
            {
                return Page();
            }
             
            await objcliente.registrarPedidoAsync(PedidoFastFood);

            return RedirectToPage("./Index");
        }
    }
}
