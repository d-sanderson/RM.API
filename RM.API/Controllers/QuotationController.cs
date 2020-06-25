using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RM.API.Models;
using RM.API.Services;
using System;
using System.Collections.Generic;

namespace RM.API.Controllers
{
    [ApiController]
    [Route("api/quotes")]
    public class QuotationController : ControllerBase
    {
        private readonly IQuotationRepository _quotationRepository;
        private readonly IMapper _mapper;

        public QuotationController(IQuotationRepository quotationRepository,
            IMapper mapper)
        {
            _quotationRepository = quotationRepository ??
                                   throw new ArgumentNullException(nameof(quotationRepository));
            _mapper = mapper ??
                      throw new ArgumentNullException(nameof(mapper));
        }
        [HttpGet]
        public IActionResult GetQuotes()
        {
            var quoteEntities = _quotationRepository.GetQuotes();

            return Ok(_mapper.Map<IEnumerable<QuotationDto>>(quoteEntities));
        }

    }
}
