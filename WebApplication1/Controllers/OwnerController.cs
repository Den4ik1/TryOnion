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

        [HttpGet, Route("")]
        public IList<OwnerModel> GetAll()
        {
            var res = _domains.GetAllD();

            return res.Select(_ => _.ToApllication()).ToList();
        }

        [HttpGet, Route("{Id:int}")]
        public IHttpActionResult GetId(int Id)
        {
            var res = _domains.GetId(Id);
            return Ok(res.ToApllication());
        }

       /* [HttpPost, Route("Add")]
        public IHttpActionResult Post (int IdOwner = 4, string NameApi = "Vera")   */    
        [HttpPost, Route("Add/{Id:int}/{Name}")]
        public IHttpActionResult Post(int IdOwner, string NameApi)
        {
            _domains.AddOwnerDomain(IdOwner, NameApi);
            //_domains.AddOwnerDomain(new OwnerModel { Id = IdOwner, Name = NameApi });
            return Ok(_domains.GetId(IdOwner));
        }

        [HttpDelete, Route("Del/{Id:int}")]
        public IHttpActionResult Del(int Id)
        {
            _domains.DeleteOwnerDomain(Id);
            return NotFound();
        }


        [HttpDelete, Route("Drop")]
        public IHttpActionResult Drop()
        {
            _domains.DrpoAllOwnerDomain();
            return NotFound();
        }
    }
}