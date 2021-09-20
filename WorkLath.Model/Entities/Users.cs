using WorkLath.Core.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Core;
using WorkLath.Core.Enums;

namespace WorkLath.Model.Entities
{
    public class Users : BaseEntity
    {
        public Roles Role { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int PhotoId { get; set; }
        public virtual Document Photo { get; set; }
    }
}
