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
        private IServiceMapper<string> _serviceMapper;



        public HomeController()
        {
            _serviceMapper = new SitecoreGlassMapper();
        }

        public ActionResult Index()
        {
            return View(_serviceMapper.GetHomePageViewModel(Sitecore.Context.Item.Paths.Path));
        }
    }
}