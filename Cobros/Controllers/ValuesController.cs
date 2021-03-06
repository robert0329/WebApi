﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cobros.Controllers
{
    public class ValuesController : ApiController
    {
        Cobros.Models.Cobros[] cobro = new Cobros.Models.Cobros[]{

       new Cobros.Models.Cobros{CobroId=1,Fecha="09/09/09",Referencia ="Bono",IdRemoto=1,idRuta=2,Mora=500,Monto=2000.00,Latitud=3502,Longitud=500,EsNulo=true },
       new Cobros.Models.Cobros{CobroId=2,Fecha="09/09/09",Referencia ="Bono",IdRemoto=1,idRuta=2,Mora=500,Monto=2000.00,Latitud=3502,Longitud=500,EsNulo=true },
       new Cobros.Models.Cobros{CobroId=3,Fecha="09/09/09",Referencia ="Bono",IdRemoto=1,idRuta=2,Mora=500,Monto=2000.00,Latitud=3502,Longitud=500,EsNulo=true },
       new Cobros.Models.Cobros{CobroId=4,Fecha="09/09/09",Referencia ="Bono",IdRemoto=1,idRuta=2,Mora=500,Monto=2000.00,Latitud=3502,Longitud=500,EsNulo=true },
       new Cobros.Models.Cobros{CobroId=5,Fecha="09/09/09",Referencia ="Bono",IdRemoto=1,idRuta=2,Mora=500,Monto=2000.00,Latitud=3502,Longitud=500,EsNulo=true }

       };


        public IEnumerable<Cobros.Models.Cobros> GetAllCarro()
        {
            return cobro;
        }


        public IHttpActionResult GetCarro(int id)
        {
            var cobros = cobro.FirstOrDefault((c) => c.CobroId == id);
            if (cobros != null)
            {
                return Ok(cobros);
            }
            else
            {
                return NotFound();
            }
        }
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
