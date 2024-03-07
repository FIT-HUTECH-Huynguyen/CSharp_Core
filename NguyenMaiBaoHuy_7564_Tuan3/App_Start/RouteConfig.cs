﻿using System.Web.Mvc;
using System.Web.Routing;

namespace NguyenMaiBaoHuy_7564_Tuan3
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "TheLoai", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}