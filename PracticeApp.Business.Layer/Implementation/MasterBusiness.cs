using PracticeApp.Business.Layer.Interfaces;
using PracticeApp.Common.Layer.Models;
using PracticeApp.Service.Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Business.Layer.Implementation
{
    public class MasterBusiness : IMasterBusiness
    {
        private readonly IMasterService _masterService;
        public MasterBusiness(IMasterService masterService)
        {
            _masterService = masterService;
        }

        public MasterData GetMasterActiveData()
        {
            MasterData masterData = new MasterData();
            masterData.Gender = _masterService.GetGender(true);
            return masterData;
        }
    }
}
