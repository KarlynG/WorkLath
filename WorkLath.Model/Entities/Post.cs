using WorkLath.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Core;

namespace WorkLath.Model.Entities
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
