using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bookstore.Models
{
    public class AppIdentityDBContext : IdentityDbContext<IdentityUser>
    // Inherit from the IdentityDbContext 
    {
        public AppIdentityDBContext(DbContextOptions options) : base(options)
        {
        }
    }
}
