using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieBox.Models
{
      public class MovieBoxContext : IdentityDbContext<AppCustomer>
    {
            public MovieBoxContext() : base("Name= MovieBoxContext")
            {

            }

      //  public DbSet<AppCustomer> AppCustomers { get; set; }

        }
    
}