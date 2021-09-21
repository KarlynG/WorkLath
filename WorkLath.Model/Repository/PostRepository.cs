using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Model.Context;
using WorkLath.Model.Entities;
using WorkLath.Service.Repository;

namespace WorkLath.Model.Repository
{
    public interface IPostRepository: IBaseRepository<Post> { }
    public class PostRepository :BaseRepository<Post>, IPostRepository
    {
        public PostRepository(WorkLathContext context): base(context)
        {
        }
    }
}
