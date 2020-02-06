using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CookieSessions.Models
{
    public class UserAccountContextcs:DbContext
    {
        public UserAccountContextcs(DbContextOptions<UserAccountContextcs> options) : base(options) { }  
  
	        public DbSet<UserAccount> UserAccounts { get; set; }

    }
}
