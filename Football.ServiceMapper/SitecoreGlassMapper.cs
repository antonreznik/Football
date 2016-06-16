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
using Sitecore.Data;

namespace Football.ServiceMapper
{
    public class SitecoreGlassMapper : IServiceSitecoreMapper<Guid>
    {
        private IMapper _mapper;
        public SitecoreGlassMapper()
        {
            _mapper = AutoMapperConfig.CreateAutoMapper();
        }

        public HeaderViewModel GetHeaderViewModel(Guid itemGuid)
        {
            SitecoreContext service = new SitecoreContext();
            
            var DTOmodel = service.GetItem<HeaderDTOmodel>(itemGuid);

            //var x = _mapper.Map<List<HeaderMenuViewModel>>(DTOmodel.MenuItems.ElementAt(0).HeaderItems.ToList());
            var t = _mapper.Map<HeaderViewModel>(DTOmodel);
            return _mapper.Map<HeaderViewModel>(DTOmodel);          
        }

        public HeaderDTOmodel GetHeaderDTOModel(Guid itemGuid)
        {
            SitecoreContext service = new SitecoreContext();
            var DTOmodel = service.GetItem<HeaderDTOmodel>(itemGuid);
        
            return DTOmodel;
        }

        public BodyContentViewModel GetBodyContentViewModel(Guid itemGuid)
        {
            SitecoreContext service = new SitecoreContext();
            var DTOmodel = service.GetItem<BodyContentDTOmodel>(itemGuid);

            return _mapper.Map<BodyContentViewModel>(DTOmodel);
        }

        public BodyContentDTOmodel GetBodyContentDTOModel(Guid itemGuid)
        {
            SitecoreContext service = new SitecoreContext();
            var DTOmodel = service.GetItem<BodyContentDTOmodel>(itemGuid);

            return DTOmodel;
        }
    }
}
