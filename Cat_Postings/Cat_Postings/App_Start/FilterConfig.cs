﻿using System.Web;
using System.Web.Mvc;

namespace Cat_Postings
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
