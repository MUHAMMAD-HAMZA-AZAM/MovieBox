using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieBox.Models
{
      public class MovieBoxContext : DbContext
        {
            public MovieBoxContext() : base("Name= MovieBoxContext")
            {

            }

        }
    
}