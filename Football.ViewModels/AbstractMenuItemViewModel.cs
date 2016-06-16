using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ViewModels
{
    public abstract class AbstractMenuItemViewModel
    {
        public ID TemplateID { get; set; }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
    }
}
