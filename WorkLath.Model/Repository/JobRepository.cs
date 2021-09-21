
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Model.Context;
using WorkLath.Model.Entities;
using WorkLath.Service.Repository;

namespace WorkLath.Model.Repository
{
        public interface IJobRepository: IBaseRepository<Job> { }
        public class JobRepository : BaseRepository<Job>, IJobRepository
        {
            public JobRepository(WorkLathContext context) : base(context)
            {
            }
        }
    
}
