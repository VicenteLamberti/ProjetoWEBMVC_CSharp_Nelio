using ProjetoWEBMVC_CSharp_Nelio.Data;
using ProjetoWEBMVC_CSharp_Nelio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWEBMVC_CSharp_Nelio.Services
{
    public class SellerService
    {
        private readonly ProjetoWEBMVC_CSharp_NelioContext _context;

        public SellerService(ProjetoWEBMVC_CSharp_NelioContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

    }
}
