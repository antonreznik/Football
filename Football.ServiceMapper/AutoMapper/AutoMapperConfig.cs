using AutoMapper;
using Football.DTOmodels;
using Football.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ServiceMapper.AutoMapper
{
    public static class AutoMapperConfig
    {
        private static MapperConfiguration _config;

        static AutoMapperConfig()
        {
            MakeMapperConfiguration();
        }

        private static void MakeMapperConfiguration()
        {
            _config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<HeaderDTOmodel, HeaderViewModel>()
                        .ForMember(c => c.HeaderLogoSrc, d => d.MapFrom(x => x.HeaderLogo.Src))
                        .ForMember(c => c.HeaderLogoAlt, d => d.MapFrom(x => x.HeaderLogo.Alt))

                        .ForMember(c => c.HeaderBookmakerLogoSrc, d => d.MapFrom(x => x.HeaderBookmakerLogo.Src))
                        .ForMember(c => c.HeaderBookmakerLogoAlt, d => d.MapFrom(x => x.HeaderBookmakerLogo.Alt));
                }
            );
        }

        public static IMapper CreateAutoMapper()
        {
           return _config.CreateMapper();
        }
    }
}
