using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Anc20_core_IndAuth_1.Identity.Models.HomeViewModels
{
    public class IdentityServiceViewModel
    {
        public string Issuer { get; set; }

        public IEnumerable<ClientViewModel> Clients { get; set; }
    }
}
