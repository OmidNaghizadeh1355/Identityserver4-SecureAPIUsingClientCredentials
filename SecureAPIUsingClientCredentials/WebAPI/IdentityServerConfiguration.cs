﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI
{
    public class IdentityServerConfiguration
    {
        private readonly IConfiguration Configuration;

        public const string Alias = "IdentityServerConfiguration";
        public String Authority { get; set; }
        public Boolean RequireHttpsMetadata { get; set; }
        public String Audience { get; set; }
    }
}
