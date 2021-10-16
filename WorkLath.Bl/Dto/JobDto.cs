using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Core.BaseModel;

namespace WorkLath.Bl.Dto
{
    public class JobDto : BaseEntityDto
    {
        public JobDto()
        {
            Posts = new HashSet<PostDto>();
        }
        public string Name { get; set; }
        public ICollection<PostDto> Posts { get; set; }
    }
}
