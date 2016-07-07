﻿using LightInject;
using Microsoft.Owin;
using Owin;
using System.Reflection;

[assembly: OwinStartupAttribute(typeof(WebDeveloper.Startup))]
namespace WebDeveloper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            var container = new ServiceContainer();
            container.RegisterAssembly(Assembly.GetExecutingAssembly());
            container.RegisterAssembly("WebDeveloper.*.dll");
            container.RegisterControllers();
            container.EnableMvc();
        }
    }
}
