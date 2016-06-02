using Football.Interfaces;
using Football.ServiceMapper;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Football.Controllers
{
    public class HomeController : Controller
    {
        private IServiceSitecoreMapper<string> _serviceMapper;

        public HomeController()
        {
            _serviceMapper = new SitecoreGlassMapper();
        }

        public ActionResult GetHeader()
        {
            return View(_serviceMapper.GetHeaderViewModel(Sitecore.Context.Item.Paths.Path));
        }
    }
}