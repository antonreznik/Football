using Football.Interfaces;
using Football.ServiceMapper;
using Glass.Mapper.Sc.Web.Mvc;
using Sitecore.Data;
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
        private IServiceSitecoreMapper<Guid> _serviceMapper;

        public HomeController()
        {
            _serviceMapper = new SitecoreGlassMapper();
        }

        public ActionResult GetHeader()
        {
            //var str = Sitecore.Context.Site.Properties["glassContext"];
            Guid sourceItemGuid;
            if(!Guid.TryParse(Sitecore.Mvc.Presentation.RenderingContext.Current.Rendering.DataSource, out sourceItemGuid))
            {
                sourceItemGuid = Sitecore.Context.Item.ID.Guid;
            }
            //var x = _serviceMapper.GetHeaderViewModel(sourceItemGuid);
            var y = _serviceMapper.GetHeaderDTOModel(sourceItemGuid);
            //return View(_serviceMapper.GetHeaderViewModel(sourceItemGuid));
            return View(y);
        }

        public ActionResult GetPageContent()
        {
            var model = _serviceMapper.GetBodyContentDTOModel(Sitecore.Context.Item.ID.Guid);

            return View(model);
        }
    }
}