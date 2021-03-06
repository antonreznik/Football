﻿using Football.DTOmodels;
using Football.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football.Interfaces
{
    public interface IServiceSitecoreMapper<T>
    {
        HeaderViewModel GetHeaderViewModel(T itemGuid);
        HeaderDTOmodel GetHeaderDTOModel(T itemGuid);
        BodyContentDTOmodel GetBodyContentDTOModel(T itemGuid);
    }
}
