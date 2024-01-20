using IssueTrackerApp.DAL.Interrfaces;
using IssueTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace IssueTrackerApp.Controllers
{
    public class IssueController : ApiController
    {
        private readonly IIssueTrackerService _service;
        public IssueController(IIssueTrackerService service)
        {
            _service = service;
        }
        public IssueController()
        {
            // Constructor logic, if needed
        }
        [HttpPost]
        [Route("api/Issue/CreateIssue")]
        [AllowAnonymous]
        public async Task<IHttpActionResult> CreateIssue([FromBody] Issue model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpPut]
        [Route("api/Issue/UpdateIssue")]
        public async Task<IHttpActionResult> UpdateIssue([FromBody] Issue model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpDelete]
        [Route("api/Issue/DeleteIssue")]
        public async Task<IHttpActionResult> DeleteIssue(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Issue/GetIssueById")]
        public async Task<IHttpActionResult> GetIssueById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }


        [HttpGet]
        [Route("api/Issue/GetAllIssues")]
        public async Task<IEnumerable<Issue>> GetAllIssues()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}
