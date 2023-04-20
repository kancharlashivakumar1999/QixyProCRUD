using QixyPro.IRespo;
using QixyPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace QixyPro.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]  
    public class HotelController : ApiController
    {
        public readonly IHotel local;

        private HotelController() { }
        public HotelController(IHotel ramp)
        {
            this.local = ramp;
        }

        [Route("api/Hotel/get")]
        [HttpGet]
        public IHttpActionResult get()
        { 
            var virat = local.getHotel();
            return Ok(virat);
        }
       
        [Route("api/Hotel/insert")]
        [HttpPost]
        public IHttpActionResult post(HotelModel s)
        {
            var shiva = local.insert(s);
            if(shiva=="inserted")
            {
                return Ok(shiva);
            }
            else if(shiva=="update")
            {
                return Ok(shiva);
            }
            return NotFound();
        }
        
        [Route("api/Hotel/delete/{det}")]
        [HttpDelete]
        public IHttpActionResult Delete(int Det)
        {
            var vk = local.Delete(Det);
            if (vk== "Delete")
            {
                return Ok(vk);
            }
            return NotFound();
        }




        //[Route("api/Hotel/edit/")]
        //[HttpPost]

        //public IHttpActionResult Post(HotelModel s)
        //{
        //    var K = local.Edit(s);
        //    if(K== "update")
        //    {
        //        return Ok(K);
        //    }
        //    return NotFound();
        //}


        [Route("api/Hotel/getId/{s}")]
        [HttpGet]
        public IHttpActionResult get(int s)
        {
            var K = local.getID(s);
            return Ok(K);
        }


    }
}
