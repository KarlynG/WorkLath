using WorkLath.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Core;

namespace WorkLath.Model.Entities
{
    public class Job : BaseEntity
    {
        public Job()
        {
            Posts = new HashSet<Post>();
        }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
