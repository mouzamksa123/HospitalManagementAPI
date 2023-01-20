using PracticeApp.Common.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Business.Layer.Interfaces
{
    public interface IMasterBusiness
    {
        MasterData GetMasterActiveData();
    }
}
