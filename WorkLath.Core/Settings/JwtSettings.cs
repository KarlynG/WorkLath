using System;
using System.Collections.Generic;
using System.Text;

namespace WorkLath.Core.Settings
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public int ExpiresInMinutes { get; set; }
    }
}
