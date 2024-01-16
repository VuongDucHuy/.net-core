using Microsoft.AspNetCore.Mvc;
using TRANNING.Entity;
using TRANNING.IServices;
using TRANNING.Models;

namespace TRANNING.Controllers
{
    public class GetDataController : Controller
    {
        private readonly ILogger<GetDataController> _logger;
        private readonly IGetdataService _GetdataService;
        public GetDataController(ILogger<GetDataController> logger,
            IGetdataService getdataService)
        {
            _logger = logger;
            _GetdataService = getdataService;
        }
        [HttpPost]

        public IActionResult Data()
        {
            //lấy dữ liệu từ sql server truy cấp qua server, reponsitory, sử dung store
            var data = _GetdataService.GetData();
            if (data.Listt.Count > 0)
            {
                return View(data);
            }
            else
            {
                return Redirect("Index");
            }
            //end

            return View(data);

                       

    }
    }
}
