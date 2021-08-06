using ProjetoWEBMVC_CSharp_Nelio.Data;
using ProjetoWEBMVC_CSharp_Nelio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoWEBMVC_CSharp_Nelio.Services
{
    public class DepartamentService
    {
        private readonly ProjetoWEBMVC_CSharp_NelioContext _context;

        public DepartamentService(ProjetoWEBMVC_CSharp_NelioContext context)
        {
            _context = context;
        }

        public async Task<List<Departament>> FindAllAsync()
        {
            return await _context.Departament.OrderBy(x => x.Name).ToListAsync();
        }

        
    }
}
