using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DTOmodels
{
    public class LeftMenuDTOmodel
    {
        //[SitecoreQuery("./*[@@templateid='888E2541-FC03-46B9-87BB-3D8B62CE2872']", IsRelative = true)]
        [SitecoreChildren(InferType = true)]
        public virtual IEnumerable<MenuItemDTOmodel> News { get; set; }
    }
}
