using kpiWebApiMvcBlank.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace kpiWebApiMvcBlank.Controllers
{
    public class DatasetsController : ApiController
    {
        private DataDtoRepo dataDtoRepo;

        public DatasetsController()
        {
            this.dataDtoRepo = new DataDtoRepo();
        }
        
        [HttpGet]
        public IEnumerable<DataDto> data()
        {
            return this.dataDtoRepo.getAllDataDto();
        }

    }
}
