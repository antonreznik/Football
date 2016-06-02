using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DTOmodels
{
    public class HeaderDTOmodel
    {
        [SitecoreField]
        public string HeaderLink { get; set; }

        [SitecoreField]
        public Image HeaderLogo { get; set; }

        [SitecoreField]
        public Image HeaderBookmakerLogo { get; set; }

        [SitecoreField]
        public string HeaderBookmakerLink { get; set; }
    }
}
