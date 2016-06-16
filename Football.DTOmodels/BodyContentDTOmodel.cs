using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.DTOmodels
{
    public class BodyContentDTOmodel : BaseItem
    {
        [SitecoreField]
        public string Content { get; set; }

        [SitecoreQuery("./*[@@templateid='{872F1A12-F6A6-4750-9C25-ACD1FC15F008}']", IsRelative = true)]
        public LeftMenuDTOmodel Items { get; set; }
    }
}
