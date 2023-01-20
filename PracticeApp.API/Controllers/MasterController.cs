using Microsoft.AspNetCore.Mvc;
using PracticeApp.Business.Layer.Interfaces;
using PracticeApp.Common.Layer.Models;
using PracticeApp.Encryption.Interface;
using System.Threading.Tasks;

namespace PracticeApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MasterController : Controller
    {
        private readonly IMasterBusiness _masterBusiness;
        public MasterController(IMasterBusiness masterBusiness)
        {
            _masterBusiness = masterBusiness;
        }
        [HttpGet("GetMasterData")]
        public  MasterData GetMasterData()
        {
            return _masterBusiness.GetMasterActiveData();
        }
    }
}
