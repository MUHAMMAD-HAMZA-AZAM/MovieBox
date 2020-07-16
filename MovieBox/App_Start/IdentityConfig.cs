using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using MovieBox.Models;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieBox.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            app.CreatePerOwinContext(() => new MovieBoxContext());
            app.CreatePerOwinContext<AppUserManager>(AppUserManager.Create);
            app.CreatePerOwinContext<RoleManager<AppCustomerRole>>((options, context) =>
                new RoleManager<AppCustomerRole>(
                    new RoleStore<AppCustomerRole>(context.Get<MovieBoxContext>("MovieBoxContext"))));

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                LoginPath = new PathString("/Home/Login"),
            });
        }

    }
}