using Microsoft.EntityFrameworkCore;
using PracticeApp.Entity.Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Entity.Layer.Infrastructure.Interface
{
    public interface IApplicationDBContext
    {
        DbSet<AdminUser> AdminUsers { get; set; }

        DbSet<MasGender> MasGenders { get; set; }

        DbSet<UsrProfile> UsrProfiles { get; set; }

        DbSet<UsrSalt> UsrSalts { get; set; }
        Task<int> SaveChangesAsync();
    }
}
