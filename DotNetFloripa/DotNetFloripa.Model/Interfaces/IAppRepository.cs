using System.Linq;
namespace DotNetFloripa.Model.Interfaces
{
    public interface IAppRepository
    {
        IQueryable<Event> GetEvents();
        Event GetEventBySlug(string slug);
        IQueryable<Company> GetCompanies();
        IQueryable<Job> GetJobs();
        void SaveJob(Job job);
    }
}
