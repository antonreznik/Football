using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DTOmodels
{
    [SitecoreType(TemplateId = "{1FA02DC9-6A94-4E3E-8A37-9D715A7D2235}")]
    public class HeaderDTOmodel : BaseItem
    {
        [SitecoreField]
        public virtual string HeaderLink { get; set; }

        [SitecoreField]
        public virtual Image HeaderLogo { get; set; }

        [SitecoreField]
        public virtual Image HeaderBookmakerLogo { get; set; }

        [SitecoreField]
        public virtual string HeaderBookmakerLink { get; set; }

        //[SitecoreChildren(InferType = true)]
        [SitecoreQuery("./*[@@templateid='{0B5DE11F-EC98-46C1-8C5A-D45F0C3951A6}']", IsRelative = true)]
        public virtual HeaderMenuDTOmodel MenuItems { get; set; }
    }
}
