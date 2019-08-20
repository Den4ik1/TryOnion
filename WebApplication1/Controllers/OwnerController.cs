using Domain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebApplication1.Mapper;
using WebApplication1.Models;
using WebApplication1.Attributes;


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

        [CustomActionLoggerAttributes, CustomExceptionLoggerAttributes]
        [HttpGet, Route("")]
        public IList<OwnerModel> GetAll()
        {
            var res = _domains.GetAllD();

            return res.Select(_ => _.ToApllication()).ToList();
        }
       
        [HttpPut, Route("Update/{IdOwner:int}/{nameOwner}")]
        public IHttpActionResult PutOwner(int IdOwner, string nameOwner)
        {
            _domains.UpDateDomain(IdOwner, nameOwner);
            return Ok();
        }

        [HttpGet, Route("{Id:int}")]
        public IHttpActionResult GetId(int Id)
        {
            var res = _domains.GetId(Id);
            return Ok(res.ToApllication());
        }

        [HttpPost, Route("AddOwner/Id/{IdOwner:int}/Name/{NameApi}")]
        public IHttpActionResult PostOw(int IdOwner, string NameApi)
        {
            _domains.AddOwnerDomain(IdOwner, NameApi);
            return Ok(_domains.GetId(IdOwner));
        }

        //Не переходит сюда.
        /*
        [HttpPost, Route("AddCar/OwnerId/{DomainownerId:int}/CarId/{DomainCarId:int}/Model/{DomainAddModel}/AgeMake/{DomainAddAgeMake}")]
        public IHttpActionResult PathcCar(int DomainownerId, int DomainCarId, string DomainAddModel, string DomainAddAgeMake)
        {
            _domains.AddCarDomain(DomainownerId, DomainCarId, DomainAddModel, DomainAddAgeMake);
            return Ok(_domains.GetId(DomainownerId));
        }
        */

        //Не реализовано 
        /*
       [HttpPatch, Route("EditOwner/OwnerId/{DomainownerId:int}/Name/{NameApi}")]
       public IHttpActionResult PathcCar(int DomainownerId, string NameApie)
       {
           _domains.PathcCarDomain(DomainownerId, DomainownerId, NameApie);
           return Ok(_domains.GetId(DomainownerId));
       }
       */

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