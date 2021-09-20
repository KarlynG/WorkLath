using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Model.Context;
using WorkLath.Model.Entities;
using WorkLath.Service.Repository;

namespace WorkLath.Model.Repository
{
    public interface IDocumentRepository : IBaseRepository<Document> { }
    public class DocumentRepository : BaseRepository<Document>, IDocumentRepository
    {
        public DocumentRepository(WorkLathContext context) : base(context)
        {
        }
    }
}
