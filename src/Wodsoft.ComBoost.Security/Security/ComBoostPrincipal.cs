﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Wodsoft.ComBoost.Security
{
    public class ComBoostPrincipal : ClaimsPrincipal, IAuthentication
    {
        public ComBoostPrincipal(ISecurityProvider securityProvider)
        {
            if (securityProvider == null)
                throw new ArgumentNullException(nameof(securityProvider));
            SecurityProvider = securityProvider;
        }

        public ISecurityProvider SecurityProvider { get; private set; }

        public T GetUser<T>()
        {
            throw new NotImplementedException();
        }

        public bool IsInRole(object role)
        {
            throw new NotImplementedException();
        }
    }
}