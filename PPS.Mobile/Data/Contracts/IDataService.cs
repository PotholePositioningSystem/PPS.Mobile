using System;
using System.Threading.Tasks;
using PPS.Mobile.Data.Models;

namespace PPS.Mobile.Data.Contracts
{
    public interface IDataService
    {
        Task AddIssue(Issue issue);
    }
}
