using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Bl.Dto;
using WorkLath.Model.Repository;
using WorkLath.Model.Entities;

namespace WorkLath.Service.Services
{
    public interface IDocumentService : IBaseService<Document, DocumentDto> { }
    public class DocumentService : BaseService<Document, DocumentDto>, IDocumentService
    {
        public DocumentService(
            IDocumentRepository repository,
            IMapper mapper,
            IValidator<DocumentDto> validator) : base(repository, mapper, validator)
        {
        }
    }
}
