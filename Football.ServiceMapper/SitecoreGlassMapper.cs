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
using AutoMapper;
using Football.ServiceMapper.AutoMapper;

namespace Football.ServiceMapper
{
    public class SitecoreGlassMapper : IServiceSitecoreMapper<string>
    {
        private IMapper _mapper;
        public SitecoreGlassMapper()
        {
            _mapper = AutoMapperConfig.CreateAutoMapper();
        }

        public HeaderViewModel GetHeaderViewModel(string itemPath)
        {
            SitecoreContext service = new SitecoreContext();
            var DTOmodel = service.GetItem<HeaderDTOmodel>(itemPath);
      
            return _mapper.Map<HeaderViewModel>(DTOmodel);          
        }
    }
}
