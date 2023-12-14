using IssueTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace IssueTrackerApp.DAL.Services.Repository
{
    public class IssueTrackerRepository : IIssueTrackerRepository
    {
        private readonly DatabaseContext _dbContext;
        public IssueTrackerRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<Issue> CreateIssue(Issue issue)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteIssueById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public List<Issue> GetAllIssues()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public async Task<Issue> GetIssueById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }       

        public async Task<Issue> UpdateIssue(Issue model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}