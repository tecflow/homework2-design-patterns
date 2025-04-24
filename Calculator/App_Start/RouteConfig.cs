routes.MapRoute(
    name: "Default",
    url: "{controller}/{action}/{id}",
    defaults: new { controller = "Calculator", action = "Index", id = UrlParameter.Optional }
);
