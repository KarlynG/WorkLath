using System;
using System.Collections.Generic;
using System.Text;

namespace WorkLath.Bl.Dto
{
    public class AuthenticateResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Token { get; set; }
    }
}
