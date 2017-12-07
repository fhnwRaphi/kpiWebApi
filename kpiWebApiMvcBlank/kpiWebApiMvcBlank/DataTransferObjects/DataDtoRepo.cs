using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kpiWebApiMvcBlank.DTO
{
    public class DataDtoRepo
    {
        private List<DataDto> datalist = new List<DataDto>();
        public IEnumerable<DataDto> getAllDataDto()
        {
            DataDto ddto = new DataDto();
            ddto.data = 1;
            ddto.dataId = 2;
            datalist.Add(ddto);
            return datalist;
        }
    }
}