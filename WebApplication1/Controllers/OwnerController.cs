using Domain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication1.Mapper;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("Owner")]
    public class OwnerController : ApiController
    {
        private readonly IDomains _domains;

        public OwnerController(IDomains domains)
        {
            _domains = domains;
        }

        [HttpGet, Route ("")]
        public IList<OwnerModel> GetAll()
        {
            var res = _domains.GetAllD();

            return res.Select(_ => _.ToApllication()).ToList();
        }

    }
}