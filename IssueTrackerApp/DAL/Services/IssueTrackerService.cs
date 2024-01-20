using IssueTrackerApp.DAL.Interrfaces;
using IssueTrackerApp.DAL.Services.Repository;
using IssueTrackerApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace IssueTrackerApp.DAL.Services
{
    public class IssueTrackerService : IIssueTrackerService
    {
        private readonly IIssueTrackerRepository _repository;

        public IssueTrackerService(IIssueTrackerRepository repository)
        {
            _repository = repository;
        }

        public Task<Issue> CreateIssue(Issue issue)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public Task<bool> DeleteIssueById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public List<Issue> GetAllIssues()
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public Task<Issue> GetIssueById(long id)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }

        public Task<Issue> UpdateIssue(Issue model)
        {
            //Write Your Code Here
            throw new NotImplementedException();
        }
    }
}