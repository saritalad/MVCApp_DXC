﻿using System.Web;
using System.Web.Mvc;

namespace MVCApp_DXC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
