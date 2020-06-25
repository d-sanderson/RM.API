using RM.API.Entities;
using System.Collections.Generic;

namespace RM.API.Services
{
    public interface IQuotationRepository
    {

        IEnumerable<Quotation> GetQuotes();

        Quotation GetQuotation(int id);

        bool Save();
    }
}
