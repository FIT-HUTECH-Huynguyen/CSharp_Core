﻿using System.Web;
using System.Web.Mvc;

namespace NguyenMaiBaoHuy_7564_Tuan4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
