using PracticeApp.Common.Layer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.Service.Layer.Interfaces
{
    public interface IMasterService
    {
        IEnumerable<KeyValueSet> GetGender(bool? isActive);
    }
}
