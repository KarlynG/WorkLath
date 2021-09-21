using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Core.BaseModel;

namespace WorkLath.Bl.Dto
{
    public class PostDto : BaseEntityDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
