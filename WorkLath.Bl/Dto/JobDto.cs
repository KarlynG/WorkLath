using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Core.BaseModel;

namespace WorkLath.Bl.Dto
{
    public class JobDto : BaseEntityDto
    {
        public string Location { get; set; }
        public string Postition { get; set; }
        public string Company { get; set; }
    }
}
