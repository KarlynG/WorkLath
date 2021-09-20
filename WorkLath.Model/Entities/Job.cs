using WorkLath.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Core;

namespace WorkLath.Model.Entities
{
    public class Job : BaseEntity
    {
        public string Location { get; set; }
        public string Postition { get; set; }
        public string Company { get; set; }
    }
}
