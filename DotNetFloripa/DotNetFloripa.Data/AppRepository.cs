﻿using DotNetFloripa.Model;
using DotNetFloripa.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFloripa.Data
{
    public class AppRepository : IAppRepository
    {
        public AppRepository()
        {
        }

        DotNetFloripaContext _db = new DotNetFloripaContext();

        public IQueryable<Event> GetEvents()
        {
            return _db.Events.AsQueryable();
        }

        public Event GetEventBySlug(string slug)
        {
            return _db.Events.FirstOrDefault(e => e.Slug.Equals(slug, StringComparison.InvariantCultureIgnoreCase));
        }

        public IQueryable<Company> GetCompanies()
        {
            return _db.Companies.AsQueryable();
        }


        public IQueryable<Job> GetJobs()
        {
            return _db.Jobs.AsQueryable();
        }

        public void SaveJob(Job job)
        {
            _db.Jobs.Add(job);
            _db.SaveChanges();
        }
    }
}
