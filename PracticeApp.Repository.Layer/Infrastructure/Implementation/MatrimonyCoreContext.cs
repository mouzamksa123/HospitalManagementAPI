using Microsoft.EntityFrameworkCore;
using PracticeApp.Entity.Layer.Entities;
using PracticeApp.Entity.Layer.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Entity.Layer.Entities
{
    public partial class MatrimonyCoreContext : DbContext, IApplicationDBContext
    {
        #region DbSet

        public virtual DbSet<AdminUser> AdminUsers { get; set; }

        public virtual DbSet<MasGender> MasGenders { get; set; }

        public virtual DbSet<UsrProfile> UsrProfiles { get; set; }

        public virtual DbSet<UsrSalt> UsrSalts { get; set; }
        #endregion
        #region Methods
        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
        #endregion

    }
}
