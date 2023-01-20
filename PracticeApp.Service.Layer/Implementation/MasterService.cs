using Microsoft.EntityFrameworkCore;
using PracticeApp.Common.Layer.Models;
using PracticeApp.Entity.Layer.Infrastructure.Interface;
using PracticeApp.Service.Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Service.Layer.Implementation
{
    public class MasterService : IMasterService
    {
        private readonly IApplicationDBContext _dbContext;
        public MasterService(IApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<KeyValueSet> GetGender(bool? isActive)
        {
            try
            {
                var genderList =  (from gender in _dbContext.MasGenders.Where(x=>x.IsActive ==(isActive == null ? x.IsActive : isActive))
                                   select new KeyValueSet
                                   {
                                       Id = gender.GenderId,
                                       Value = gender.Name,
                                       IsActive = gender.IsActive
                                   }); 
                return  genderList;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
