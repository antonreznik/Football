using Football.Interfaces;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Football.ViewModels;
using Glass.Mapper.Sc;
using Football.DTOmodels;

namespace Football.ServiceMapper
{
    public class SitecoreGlassMapper : IServiceMapper<string>
    {
        public HomePageViewModel GetHomePageViewModel(string itemPath)
        {
            SitecoreContext service = new SitecoreContext();
            var DTOmodel = service.GetItem<HomePageDTOmodel>(itemPath);


            return service.GetItem<HomePageViewModel>(itemPath);          
        }
    }
}
