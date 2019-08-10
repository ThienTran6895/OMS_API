using OMS_API.Interface;
using OMS_API.Models;
using OMS_API.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace OMS_API.Controllers
{
    public class PullProjectDataController : ApiController
    {
        PullProjectDataRes pullprojectdataRes = new PullProjectDataRes();
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
        [HttpPost]
        public ResponseInterface Post(string secretKey, [FromBody] PullProjectData model)
        {
            var result = pullprojectdataRes.GetAllData(ProjectID: model.projectID, SourceID: model.sourceID, DateFrom: model.datefrom, DateEnd: model.dateend);
            
            return result;
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
