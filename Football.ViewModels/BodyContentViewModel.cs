using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ViewModels
{
    public class BodyContentViewModel
    {
        public string Content { get; set; }
        public IEnumerable<LeftMenuViewModel> Items { get; set; }
    }
}
