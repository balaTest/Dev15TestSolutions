﻿using System.Web;
using System.Web.Mvc;

namespace Mvc5App_net461_cs_NoAuth_1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
