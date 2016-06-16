using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DTOmodels
{
    [SitecoreType(TemplateId = "{0B5DE11F-EC98-46C1-8C5A-D45F0C3951A6}")]
    public class HeaderMenuDTOmodel
    {
        //[SitecoreQuery("/sitecore/content/Home/Header Menu/*[@@templateid='{69E5F3C4-897B-406A-B6EC-1EEF7E777386}']", IsRelative = true)]
        [SitecoreChildren(InferType = true)]
        public virtual IEnumerable<MenuItemDTOmodel> HeaderItems { get; set; }
    }
}
