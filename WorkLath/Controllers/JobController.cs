using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkLath.Bl.Dto;
using WorkLath.Model.Entities;
using WorkLath.Service.Services;

namespace WorkLath.Controllers
{
    public class JobController : BaseController<Job, JobDto>
    {
        public JobController(IJobService service) : base(service)
        {
        }
    }
}
