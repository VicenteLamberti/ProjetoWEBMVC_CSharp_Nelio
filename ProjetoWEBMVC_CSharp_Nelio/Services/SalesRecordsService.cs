using Microsoft.EntityFrameworkCore;
using ProjetoWEBMVC_CSharp_Nelio.Data;
using ProjetoWEBMVC_CSharp_Nelio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoWEBMVC_CSharp_Nelio.Services
{
    public class SalesRecordsService
    {
        private readonly ProjetoWEBMVC_CSharp_NelioContext _context;

        public SalesRecordsService(ProjetoWEBMVC_CSharp_NelioContext context)
        {
            _context = context;
        }

        public async Task<List<SalesRecords>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.SalesRecord select obj;

            if (minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return await result
                .Include(x => x.Seller)
                .Include(x => x.Seller.Departament)
                .OrderByDescending(x => x.Date)
                .ToListAsync();
        }
    }
}
