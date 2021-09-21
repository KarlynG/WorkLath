using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Bl.Dto;
using WorkLath.Model.Entities;
using WorkLath.Model.Repository;

namespace WorkLath.Service.Services
{
    public interface IJobService : IBaseService<Job, JobDto> { }
    public class JobService : BaseService<Job, JobDto>, IJobService
    {
        public JobService(
            IJobRepository repository,
            IMapper mapper,
            IValidator<JobDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
