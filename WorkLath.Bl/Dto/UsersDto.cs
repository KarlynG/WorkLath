using System;
using System.Collections.Generic;
using System.Text;
using WorkLath.Core.BaseModel;
using WorkLath.Core.Enums;
using WorkLath.Model.Entities;

namespace WorkLath.Bl.Dto
{
    public class UsersDto : BaseEntityDto
    {
        public Roles Role { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int PhotoId { get; set; }
        public virtual DocumentDto Photo { get; set; }
    }
}
