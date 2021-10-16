using WorkLath.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Core;

namespace WorkLath.Model.Entities
{
    public class Post : BaseEntity
    {
        public string Category { get; set; }
        public string Schedule { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public int? PhotoId { get; set; }
        public Document Photo { get; set; }
        public string Url { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
