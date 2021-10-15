using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Core.BaseModel;

namespace WorkLath.Bl.Dto
{
    public class PostDto : BaseEntityDto
    {
        public string Category { get; set; }
        public string Schedule { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string PhotoId { get; set; }
        public string Url { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
