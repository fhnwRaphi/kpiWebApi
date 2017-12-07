using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;

namespace kpiWebApiMvc.Controllers
{
    public class SerialController : ApiController
    {
        [HttpGet]
        public IEnumerable< Models.eSerial> Order(int? serialId)
        {
            var model = new Models.EOSEntities();
            model.Configuration.LazyLoadingEnabled = false;

            var ser = model.eSerials.Where(x => x.SerialId == serialId);
            /*var order = serial.eSerials.Join(serial.eOrders, x => x.OrderId, y => y.OrderId, (x, y) => new { x }).FirstOrDefault(x=> x.x.SerialId == serialId);
                //FirstOrDefault(x => x.SerialId == serialId).eOrder;*/
            return ser;
        }
    }
}
