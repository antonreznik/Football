using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DTOmodels
{
    public class HomePageDTOmodel
    {
        [SitecoreField]
        public string HeaderContent { get; set; }

        [SitecoreField]
        public string FooterContent { get; set; }
    }
}
