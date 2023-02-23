﻿using Core.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IWatchListService
    {
        IDataResult<List<WatchList>> GetAll();
        IResult Add(WatchList list);
        IResult Delete(WatchList list);
    }
}
