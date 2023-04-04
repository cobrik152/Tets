using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApplicationDbContext.Data
{ 
    public class DataContext : IdentityDbContext
    { 
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }
    }
}