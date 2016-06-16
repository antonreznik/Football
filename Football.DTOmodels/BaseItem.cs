using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DTOmodels
{
    [SitecoreType(AutoMap = true)]
    public class BaseItem
    {
        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual ID TemplateID { get; set; }

        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreField]
        public virtual string Name { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; set; }
    }
}
