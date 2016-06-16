using Football.DTOmodels;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.ViewModels
{
    public class HeaderViewModel
    {
        //private HeaderDTOmodel headerDTOmodel;
        //public string HeaderLink
        //{
        //    get { return headerDTOmodel.HeaderLink; }
        //    set { headerDTOmodel.HeaderLink = value; }
        //}

        //public string HeaderLogoSrc
        //{
        //    get { return headerDTOmodel.HeaderLogo.Src; }
        //    set { headerDTOmodel.HeaderLogo.Src = value; }
        //}
        public string HeaderLink { get; set; }
        public string HeaderLogoSrc { get; set; }
        public string HeaderLogoAlt { get; set; }
        public string HeaderBookmakerLink { get; set; }
        public string HeaderBookmakerLogoSrc { get; set; }
        public string HeaderBookmakerLogoAlt { get; set; }
        //public IEnumerable<HeaderMenuViewModel> MenuItems { get; set; }
        public IEnumerable<HeaderMenuItemViewModel> MenuItems { get; set; }

    }
}
