using Microsoft.AspNetCore.Mvc;
using RM.API.Contexts;
using System;

namespace RM.API.Controllers
{
    [ApiController]
    [Route("api/testdatabase")]
    public class DummyController : ControllerBase
    {
        private readonly QuotationContext _ctx;

        public DummyController(QuotationContext ctx)
        {
            _ctx = ctx ?? throw new ArgumentNullException(nameof(ctx));
        }

        [HttpGet]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}
