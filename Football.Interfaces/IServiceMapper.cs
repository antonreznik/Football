using Football.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Interfaces
{
    public interface IServiceMapper<T>
    {
        HomePageViewModel GetHomePageViewModel(T itemPath);
    }
}
