using Microsoft.AspNetCore.Mvc;
using ProjetoWEBMVC_CSharp_Nelio.Models;
using ProjetoWEBMVC_CSharp_Nelio.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWEBMVC_CSharp_Nelio.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;
        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }
        public IActionResult Index()
        {
            List<Seller> list = _sellerService.FindAll();
            return View(list);
        }
    }
}
