﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;

namespace Wodsoft.ComBoost.AspNetCore
{
    public class HttpFormValueSelector : HttpStringValuesSelector
    {
        public HttpFormValueSelector(HttpContext httpContext) : base(httpContext)
        { }

        protected override string[] GetKeysCore()
        {
            return HttpContext.Request.Form.Keys.ToArray();
        }

        protected override StringValues GetStringValue(string key)
        {
            return HttpContext.Request.Form[key];
        }
    }
}
