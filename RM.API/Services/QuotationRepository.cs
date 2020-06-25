using RM.API.Contexts;
using RM.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RM.API.Services
{
    public class QuotationRepository : IQuotationRepository
    {
        private readonly QuotationContext _context;

        public QuotationRepository(QuotationContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public Quotation GetQuotation(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Quotation> GetQuotes()
        {
            return _context.Quotes.OrderBy(c => c.Character).ToList();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
